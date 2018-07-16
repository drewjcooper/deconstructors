using System;
using FluentAssertions;
using Xunit;

namespace Extensions.Generic.Deconstructors.ArrayDeconstructors
{
    public class NineElementDeconstructorShould : ArrayDeconstructionTest
    {
        public NineElementDeconstructorShould() 
            : base(elementCount: 9)
        {
        }

        protected override void TestDeconstruction<T>(T[] array)
        {
            var (first, second, third, fourth, fifth, sixth, seventh, eighth, ninth) = array;

            first.Should().Be(array[0]);
            second.Should().Be(array[1]);
            third.Should().Be(array[2]);
            fourth.Should().Be(array[3]);
            fifth.Should().Be(array[4]);
            sixth.Should().Be(array[5]);
            seventh.Should().Be(array[6]);
            eighth.Should().Be(array[7]);
            ninth.Should().Be(array[8]);
        }
    }
}


