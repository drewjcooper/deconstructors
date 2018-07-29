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

        [Fact]
        public void DeconstructKeyValuePairOfStringString()
        {
            var kvp = new KeyValuePair<string, string>("foo", "bar");

            var (key, value) = kvp;

            key.Should().Be("foo");
            value.Should().Be("bar");
        }

        [Fact]
        public void DeconstructKeyValuePairOfInt64Double()
        {
            var kvp = new KeyValuePair<long, double>(42, Math.PI);

            var (key, value) = kvp;

            key.Should().Be(42);
            value.Should().Be(Math.PI);
        }
    }
}