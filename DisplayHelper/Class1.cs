using System;
using System.Collections.Generic;
using System.Text;

namespace DisplayHelper
{
    public class Display
    {
        private int _width, _height, _x, _y;
        private List<Item> Items;
        private int _i = 1;


        public Display(int width, int height, int x, int y)
        {
            _width = width;
            _height = height;
            _x = x;
            _y = y;                      
        }
        public void AddItem(Item item)
        {
            Items.Add(item);  
        }
        public void Repaint()
        {
            Console.Clear();
            Console.SetCursorPosition(_x, _y);
            Console.Write("+");

            for (int i = 0; i < _width - 2; i++)
            {
                Console.Write("─");
            }

            Console.Write("+");

            for (int i = 0; i < _height - 2; i++)
            {
                Console.SetCursorPosition(_x, _y + i + 1);
                Console.Write("I");
            }
            Console.SetCursorPosition(_x, _y + _height - 1);
            Console.Write("+");

            for (int i = 0; i < _width - 2; i++)
            {
                Console.Write("─");
            }
            Console.Write("+");

            for (int i = 0; i < _height - 2; i++)
            {
                Console.SetCursorPosition(_x + _width - 1, _y + _height - i - 2);
                Console.Write("I");
            }

            foreach(Item item in Items)
            {
                Console.SetCursorPosition(_x, _y + _i);
                Console.Write(item.Value);
                _i++;
            }
        }
    }
}
