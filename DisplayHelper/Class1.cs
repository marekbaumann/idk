using System;
using System.Collections.Generic;
using System.Text;

namespace DisplayHelper
{
    public class Display
    {
        public int width { get; protected set; }
        public int height { get; protected set; }
        public int x { get; protected set; }
        public int y { get; protected set; }
        private List<Item> Items = new List<Item>();
        private int _i = 1;


        public Display(int Width, int Height, int X, int Y)
        {
            width = Width;
            height = Height;
            x = X;
            y = Y;
        }
        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public void Repaint()
        {
            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.Write("+");

            for (int i = 0; i < width - 2; i++)
            {
                Console.Write("─");
            }

            Console.Write("+");

            for (int i = 0; i < height - 2; i++)
            {
                Console.SetCursorPosition(x, y + i + 1);
                Console.Write("I");
            }
            Console.SetCursorPosition(x, y + height - 1);
            Console.Write("+");

            for (int i = 0; i < width - 2; i++)
            {
                Console.Write("─");
            }
            Console.Write("+");

            for (int i = 0; i < height - 2; i++)
            {
                Console.SetCursorPosition(x + width - 1, y + height - i - 2);
                Console.Write("I");
            }

            foreach (Item item in Items)
            {
                Console.SetCursorPosition(x + 2, y + _i);
                Console.Write(item.name);
                Console.Write(item.value);
                _i++;
            }
        }
    }
}
