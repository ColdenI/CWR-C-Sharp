using System;
using CWR;

//example CWR

namespace CWRlibrary___test
{
    class Program
    {
        static void Main(string[] args)
        { 
            CWRFile File = new CWRFile("file.txt");
            CWRItem Item = new CWRItem("item.txt");

            Console.WriteLine("\tCWR File\n\n");

            string text = "Hello World!";
            File.Write(text);
            File.Append("\nHi CWR - Colden Write Read");
            Console.WriteLine(File.Read());

            Console.WriteLine("\n\nCWR Item");

            Item.AddItem("item_1", 123);
            Item.AddItem("item_2", "Hello");
            Item.AddItem("item_3", 3.14);

            foreach (string i in Item.GetItems())
                Console.WriteLine(i + ", ");

            Console.WriteLine(Item.GetItemString("item_1"));
            Console.WriteLine(Item.GetItemString("item_2"));
            Console.WriteLine(Item.GetItemString("item_3"));

            Item.SetItem("item_2", 0.1234);
            Item.SetOrAddItem("item_3", Item.GetItemString("item_1"));
            Item.SetOrAddItem("item_4", "CWR Item");

            if (Item.ContainsItem("item_1")) Item.RemoveItem("item_1");
            else Console.WriteLine("Item 'item_1' - not found!");

            if (Item.ContainsItem("item_5")) Item.RemoveItem("item_5");
            else Console.WriteLine("Item 'item_5' - not found!");

            foreach (string i in Item.GetItems())
                Console.WriteLine(i + " = " + Item.GetItemString(i));



            Console.WriteLine("\n\nend.");
            Console.ReadKey();
        }
    }
}
