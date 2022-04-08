using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestGranularityDemo
{
    public record Item
    {
        public string Value { get; set; }
        public ItemType Type { get; set; }
    }

    public enum ItemType
    {
        String = 0,
        Geo = 1,
        Range = 2
    }
}
