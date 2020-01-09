using System;
using System.Collections.Generic;
using System.Text;

namespace DisplayHelper
{
    public class Item
    {
        public string name { get; protected set; }
        public object value { get; protected set; }

        public Item(string Name, object Value)
        {
            name = Name;
            value = Value;
        }

    }
}
