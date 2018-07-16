using System;
using FluentAssertions;
using Xunit;

namespace Extensions.Generic.Deconstructors.ArrayDeconstructors
{
    public class FiveElementDeconstructorShould : ArrayDeconstructionTest
    {
        public FiveElementDeconstructorShould() 
            : base(elementCount: 5)
        {
        }

        protected override void TestDeconstruction<T>(T[] array)
        {
            var (first, second, third, fourth, fifth) = array;

            first.Should().Be(array[0]);
            second.Should().Be(array[1]);
            third.Should().Be(array[2]);
            fourth.Should().Be(array[3]);
            fifth.Should().Be(array[4]);
        }
    }
}


