using System;

namespace HelloWorld
{
    class Program
    {
        // method to sort by cost
        static void SortByCost(Goods[] goodsArray)
        {
            for (int i = 0; i < goodsArray.Length - 1; i++)
            {
                for (int j = 0; j < goodsArray.Length - 1 - i; j++)
                {
                    if (goodsArray[j].CalculateCost() > goodsArray[j + 1].CalculateCost())
                    {
                        Goods temp = goodsArray[j];
                        goodsArray[j] = goodsArray[j + 1];
                        goodsArray[j + 1] = temp;
                    }
                }
            }
        }

        // method to output array
        static void DisplayTable(Goods[] goodsArray)
        {
            Console.WriteLine("{0,-20} {1,-10} {2,10} {3,10} {4,20}", "Name", "ID", "Price", "Quantity", "Additional Info");
            Console.WriteLine(new string('-', 70));
            for (int i = 0; i < goodsArray.Length; i++)
            {
                goodsArray[i].DisplayInfo();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Task 2:\n");
            Console.WriteLine("Variant: 7\n");

            //Creating arrays of 5 objects of every class-inheritor
            Goods[] products = new Goods[5];
            products[0] = new Product("Milk", "P1001", 1.50, 10, 7);
            products[1] = new Product("Bread", "P1002", 0.80, 20, 3);
            products[2] = new Product("Cheese", "P1003", 5.00, 5, 30);
            products[3] = new Product("Butter", "P1004", 2.50, 8, 60);
            products[4] = new Product("Yogurt", "P1005", 1.20, 15, 10);

            Goods[] equipment = new Goods[5];
            equipment[0] = new Equipment("Washing Machine", "E2001", 500.00, 2, 24);
            equipment[1] = new Equipment("Refrigerator", "E2002", 800.00, 1, 36);
            equipment[2] = new Equipment("Microwave", "E2003", 150.00, 3, 12);
            equipment[3] = new Equipment("Dishwasher", "E2004", 400.00, 2, 18);
            equipment[4] = new Equipment("Oven", "E2005", 600.00, 1, 24);

            Goods[] tools = new Goods[5];
            tools[0] = new Tool("Hammer", "T3001", 15.00, 20, 1);
            tools[1] = new Tool("Screwdriver", "T3002", 7.50, 30, 2);
            tools[2] = new Tool("Wrench", "T3003", 20.00, 15, 3);
            tools[3] = new Tool("Pliers", "T3004", 10.00, 25, 1);
            tools[4] = new Tool("Saw", "T3005", 25.00, 10, 2);

            //sorting arrays of objects
            SortByCost(products);

            SortByCost(equipment);

            SortByCost(tools);

            //outputting arrays in a form of a table
            Console.WriteLine("Products:");
            DisplayTable(products);

            Console.WriteLine("\nEquipment:");
            DisplayTable(equipment);

            Console.WriteLine("\nTools:");
            DisplayTable(tools);

            //combining array in one
            Goods[] allGoods = new Goods[15];
            Array.Copy(products, 0, allGoods, 0, products.Length);
            Array.Copy(equipment, 0, allGoods, products.Length, equipment.Length);
            Array.Copy(tools, 0, allGoods, products.Length + equipment.Length, tools.Length);

            //sorting combined array
            SortByCost(allGoods);

            //outputting combined array in a form of a table
            Console.WriteLine("\nAll Goods Sorted by Cost:");
            DisplayTable(allGoods);
        }
    }

    abstract class Goods
    {
        public string Name { get; set; }
        public string ID;
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Goods(string name, string id, double price, int quantity)
        {
            Name = name;
            ID = id;
            Price = price;
            Quantity = quantity;
        }

        // method to calculate cost
        public abstract double CalculateCost();

        // method to output info
        public abstract void DisplayInfo();
    }

    class Product : Goods
    {
        public int Expiration { get; set; }

        //constructor for inherited class Product
        public Product(string name, string id, double price, int quantity, int expires)
            : base(name, id, price, quantity)
        {
            Expiration = expires;
        }

        //method to calculate cost
        public override double CalculateCost()
        {
            return Quantity * Expiration;
        }

        //method to output info
        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name} | ID: {ID} | Price: {Price} | Quantity: {Quantity} | Expires in: {Expiration} months");
        }
    }

    class Tool : Goods
    {
        public int ClassOfQuality { get; set; }

        //constructor for inherited class Tool
        public Tool(string name, string id, double price, int quantity, int clas)
            : base(name, id, price, quantity)
        {
            ClassOfQuality = clas;
        }

        //method to calculate cost
        public override double CalculateCost()
        {
            return Quantity * ClassOfQuality;
        }

        //method to output info
        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name} | ID: {ID} | Price: {Price} | Quantity: {Quantity} | Class of quality: {ClassOfQuality}");
        }
    }

    class Equipment : Goods
    {
        public int WarrancyDate { get; set; }

        //constructor for inherited class Equipment
        public Equipment(string name, string id, double price, int quantity, int warrancy)
      : base(name, id, price, quantity)
        {
            WarrancyDate = warrancy;
        }

        //method to calculate cost
        public override double CalculateCost()
        {
            return Quantity * WarrancyDate;
        }

        //method to output info
        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name} | ID: {ID} | Price: {Price} | Quantity: {Quantity} | Warrancy ends in: {WarrancyDate} months");
        }
    }
}