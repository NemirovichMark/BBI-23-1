using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1:\n");
            Console.WriteLine("Variant: 7\n");

            //Array of 5 object of the Goods structure
            Goods[] goodsArray = new Goods[5];
            goodsArray[0] = new Goods("Apple", "Ap12121", 2.99, 30);
            goodsArray[1] = new Goods("Banana", "Ba32154", 3.99, 12);
            goodsArray[2] = new Goods("Carrot", "Ca24521", 2.49, 45);
            goodsArray[3] = new Goods("Water", "Wa23462", 2.15, 88);
            goodsArray[4] = new Goods("Shrimp", "Sh87886", 9.45, 3);

            //Array sort(by Cost)
            Goods.ArraySort(goodsArray);

            //Displaying a table with results
            Console.WriteLine(new string('-', 55));
            for (int i = 0; i < 5; i++)
            {
                goodsArray[i].DisplayInfo();
            }
            Console.WriteLine(new string('-', 55));
        }
    }
    struct Goods
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        //constructor for properties initialization
        public Goods(string name, string id, double price, int quantity)
        {
            Name = name;
            ID = id;
            Price = price;
            Quantity = quantity;
        }

        //method to output info about a product
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name} | ID: {ID} | Price: {Price} | Quantity: {Quantity}");
        }

        public static Goods[] ArraySort(Goods[] goodsArray)
        {
            for (int i = 0; i < goodsArray.Length - 1; i++)
            {
                for (int j = 0; j < goodsArray.Length - 1 - i; j++)
                {
                    if (goodsArray[j].Price < goodsArray[j + 1].Price)
                    {
                        Goods temp = goodsArray[j];
                        goodsArray[j] = goodsArray[j + 1];
                        goodsArray[j + 1] = temp;
                    }
                }
            }
            return goodsArray;
        }
    }
}