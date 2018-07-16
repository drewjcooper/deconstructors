using System;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace Extensions.Generic.Deconstructors.ArrayDeconstructors
{
    public abstract class ArrayDeconstructionTest
    {
        public ArrayDeconstructionTest(int elementCount)
        {
            ElementCount = elementCount;
        }

        public int ElementCount { get; }

        protected string ExpectedUndersizeArrayMessage =>
            $"The provided array must have at least {ElementCount} elements." +
            Environment.NewLine + "Parameter Name: array";

        [Fact]
        public void ThrowArgumentNullExceptionGivenNullInput()
        {
            int[] array = null;

            Action deconstruction = () => TestDeconstruction(array);

            deconstruction.Should().Throw<ArgumentNullException>().WithMessage("*array");
        }

        [Fact]
        public void ThrowArgumentExceptionGivenEmptyInt32Array()
        {
            var array = new int[0];

            Action deconstruction = () => TestDeconstruction(array);

            deconstruction.Should().Throw<ArgumentException>()
                .WithMessage(ExpectedUndersizeArrayMessage);
        }

        [Fact]
        public void ThrowArgumentExceptionGivenInt32ArrayWithInsufficientElements()
        {
            var array = new int[ElementCount - 1];

            Action deconstruction = () => TestDeconstruction(array);

            deconstruction.Should().Throw<ArgumentException>()
                .WithMessage(ExpectedUndersizeArrayMessage);
        }

        [Fact]
        public void DeconstructInt32ArrayOfMinimumSizeAsExpected()
        {
            var array = Enumerable.Range(1, ElementCount).ToArray();

            TestDeconstruction(array);
        }

        [Fact]
        public void ReturnFirstElementsOfLargerArray()
        {
            var array = Enumerable.Range(1, ElementCount).Reverse().ToArray();

            TestDeconstruction(array);
        }

        [Fact]
        public void DeconstructStringArrayAsExpected()
        {
            var array = new[] { "foo", "bar", "baz", "qux", "quux", "quuz", "corge", "grault", "garply", "waldo" };

            TestDeconstruction(array);
        }

        protected abstract void TestDeconstruction<T>(T[] array);
    }
}