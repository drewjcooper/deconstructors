using System;
using FluentAssertions;
using Xunit;

namespace Extensions.Generic.Deconstructors.ArrayDeconstructors
{
    public class ThreeElementDeconstructorShould : ArrayDeconstructionTest
    {
        public ThreeElementDeconstructorShould() 
            : base(elementCount: 3)
        {
        }

        protected override void TestDeconstruction<T>(T[] array)
        {
            var (first, second, third) = array;

            first.Should().Be(array[0]);
            second.Should().Be(array[1]);
            third.Should().Be(array[2]);
        }
    }
}


