using System;
using FluentAssertions;
using Xunit;

namespace Extensions.Generic.Deconstructors.ArrayDeconstructors
{
    public class TwoElementDeconstructorShould
    {
        [Fact]
        public void ThrowArgumentNullExceptionGivenNullInput()
        {
            int[] array = null;

            Action deconstruction = () => { var (first, second) = array; };

            deconstruction.Should().Throw<ArgumentNullException>().WithMessage("*array");
        }

        [Fact]
        public void ThrowArgumentExceptionGivenEmptyInt32Array()
        {
            var array = new int[0];
            var expectedMessage = 
                "The provided array must have at least 2 elements." +
                Environment.NewLine + "Parameter Name: array";

            Action deconstruction = () => { var (first, second) = array; };

            deconstruction.Should().Throw<ArgumentException>().WithMessage(expectedMessage);
        }

        [Fact]
        public void ThrowArgumentExceptionGivenInt32ArrayWithInsufficientElements()
        {
            var array = new int[1];
            var expectedMessage = 
                "The provided array must have at least 2 elements." +
                Environment.NewLine + "Parameter Name: array";

            Action deconstruction = () => { var (first, second) = array; };

            deconstruction.Should().Throw<ArgumentException>().WithMessage(expectedMessage);
        }

        [Fact]
        public void DeconstructInt32ArrayAsExpected()
        {
            var array = new[] { 1, 2 };

            var (first, second) = array;

            first.Should().Be(1);
            second.Should().Be(2);
        }

        [Fact]
        public void ReturnFirstTwoElementsOfLargerArray()
        {
            var array = new[] { 3, 1, 2 };

            var (first, second) = array;

            first.Should().Be(3);
            second.Should().Be(1);
        }

        [Fact]
        public void DeconstructStringArrayAsExpected()
        {
            var array = new[] { "foo", "bar" };

            var (first, second) = array;

            first.Should().Be("foo");
            second.Should().Be("bar");
        }
    }
}


