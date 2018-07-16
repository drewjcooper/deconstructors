using System;
using FluentAssertions;
using Xunit;

namespace Extensions.Generic.Deconstructors.ArrayDeconstructors
{
    public class TwoElementDeconstructorShould : ArrayDeconstructionTest
    {
        public TwoElementDeconstructorShould() 
            : base(elementCount: 2)
        {
        }

        protected override void TestDeconstruction<T>(T[] array)
        {
            var (first, second) = array;

            first.Should().Be(array[0]);
            second.Should().Be(array[1]);
        }
    }
}


