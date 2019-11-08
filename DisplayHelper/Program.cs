using System;

namespace DisplayHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            Display d1 = new Display(75, 20, 5, 5);
            d1.AddItem(new Item("Popisek", 0));
            d1.AddItem(new Item("Jiný", 0));
            
        }
    }
}
