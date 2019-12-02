using System;
using System.Collections.Generic;
using System.Text;

namespace DisplayHelper
{
    public class Item
    {
        public string _name { get; set; }
        public object _value { get; set; }

        public Item(string name, object value)
        {
            _name = name;
            _value = value;
        }  
    }
}
