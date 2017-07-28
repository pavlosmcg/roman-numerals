using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace RomanNumerals.Tests {
    public class TestData : IEnumerable<object[]> {

        private IEnumerable<object[]> ReadData() {
            var data = File.ReadAllLines("TestData.txt");
            foreach (var line in data)
            {
                var datum = line.Split(',');
                yield return new[] {datum[0], datum[1]};
            }
        }

        public IEnumerator<object[]> GetEnumerator()
        {
            return ReadData().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
