using System;
using FluentAssertions;
using Xunit;

namespace Extensions.Generic.Deconstructors
{
    public class ArrayDeconstructorForTwoElementsShould
    {
        [Fact]
        public void ThrowArgumentNullExceptionGivenNullInput()
        {
            int[] array = null;

            Action deconstruction = () => { var (first, second, third) = array; };

            deconstruction.Should().Throw<ArgumentNullException>().WithMessage("*array");
        }

        [Fact]
        public void ThrowArgumentExceptionGivenEmptyInt32Array()
        {
            var array = new int[0];
            var expectedMessage = 
                "The provided array must have at least 3 elements." +
                Environment.NewLine + "Parameter Name: array";

            Action deconstruction = () => { var (first, second, third) = array; };

            deconstruction.Should().Throw<ArgumentException>().WithMessage(expectedMessage);
        }

        [Fact]
        public void ThrowArgumentExceptionGivenInt32ArrayWithInsufficientElements()
        {
            var array = new int[2];
            var expectedMessage = 
                "The provided array must have at least 3 elements." +
                Environment.NewLine + "Parameter Name: array";

            Action deconstruction = () => { var (first, second, third) = array; };

            deconstruction.Should().Throw<ArgumentException>().WithMessage(expectedMessage);
        }

        [Fact]
        public void DeconstructInt32ArrayAsExpected()
        {
            var array = new[] { 1, 2, 3 };

            var (first, second, third) = array;

            first.Should().Be(1);
            second.Should().Be(2);
            third.Should().Be(3);
        }

[Fact]
        public void ReturnFirstTwoElementsOfLargerArray()
        {
            var array = new[] { 4, 3, 1, 2 };

            var (first, second, third) = array;

            first.Should().Be(4);
            second.Should().Be(3);
            third.Should().Be(1);
        }

        [Fact]
        public void DeconstructStringArrayAsExpected()
        {
            var array = new[] { "foo", "bar", "baz" };

            var (first, second, third) = array;

            first.Should().Be("foo");
            second.Should().Be("bar");
            third.Should().Be("baz");
        }
    }
}


