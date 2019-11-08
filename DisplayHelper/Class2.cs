﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DisplayHelper
{
    public class Item
    {
        private string _name;
        private object _value;

        public Item(string name, object value)
        {
            _name = name;
            _value = value;
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public string Value
        {
            get
            {
                return _value.ToString();
            }
        }
    }
}
