using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Extensions.Generic.Deconstructors
{
    public class KeyValuePairDeconstructorShould
    {
        [Fact]
        public void DeconstructKeyValuePairOfInt32Int32()
        {
            var kvp = new KeyValuePair<int, int>(2, 4);

            var (key, value) = kvp;

            key.Should().Be(2);
            value.Should().Be(4);
        }
    }
}