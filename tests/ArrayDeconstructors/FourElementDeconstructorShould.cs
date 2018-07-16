using System;
using FluentAssertions;
using Xunit;

namespace Extensions.Generic.Deconstructors.ArrayDeconstructors
{
    public class FourElementDeconstructorShould : ArrayDeconstructionTest
    {
        public FourElementDeconstructorShould() 
            : base(elementCount: 4)
        {
        }

        protected override void TestDeconstruction<T>(T[] array)
        {
            var (first, second, third, fourth) = array;

            first.Should().Be(array[0]);
            second.Should().Be(array[1]);
            third.Should().Be(array[2]);
            fourth.Should().Be(array[3]);
        }
    }
}


