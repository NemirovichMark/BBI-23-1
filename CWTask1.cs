using System.Diagnostics;
using System.Xml.Linq;

//Вариант 7

struct Goods
{
    public string name;
    public int article;
    public double price;
    public int quantity;
}

class program
{
    static void Main()
    {
        Random art = new Random();
        Goods[] goods = new Goods[]
        {
            new Goods {name = "Хлеб     ", article = art.Next(100000000,1000000000), price = 34.5, quantity = 132},
            new Goods {name = "Молоко   ", article = art.Next(100000000,1000000000), price = 79.9, quantity = 573},
            new Goods {name = "Чебупели ", article = art.Next(100000000,1000000000), price = 170, quantity = 75},
            new Goods {name = "Пельмени ", article = art.Next(100000000,1000000000), price = 463.9, quantity = 83},
            new Goods {name = "Апельсины", article = art.Next(100000000,1000000000), price = 75.5, quantity = 563}
        };
        for (int i = 0; i < goods.Length - 1; i++)
        {
            if (goods[i].price < goods[i + 1].price)
            {
                double t = goods[i].price;
                goods[i].price = goods[i + 1].price;
                goods[i + 1].price = t;
            }
        }
        Console.WriteLine("Товар   \t" + "Артикул   \t" + "Цена  \t" + "Количество\t");
        print(goods);
    }
    static void print(Goods [] matrix)
    {
        for (int i = 0; i < matrix.Length; i++)
        {
            Console.WriteLine(matrix[i].name +"\t" + matrix[i].article + "\t" +  matrix[i].price + "\t" +  matrix[i].quantity);
        }
    }
}


