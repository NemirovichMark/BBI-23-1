using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace kr_19._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task 1 Variant 13
            Goods pencil = new Goods();
            pencil.ShowInfo();

            Goods can = new Goods();
            can.ShowInfo();

            Goods soda = new Goods("cola", "very delicious", 12);
            soda.ShowInfo();

            Goods tomato = new Goods("tomato", "extremely red", 222);
            tomato.ShowInfo();

            Goods banana = new Goods("banana", "malicuously yellow", 521);
            banana.ShowInfo();
            #endregion
            Console.ReadKey();
        }
    }
    //classes for task 1 
    public struct Goods
    {
        private string Name { get; set; }
        private string Description { get => _description; set { if (_description.Length < 20 || _description.Length > 200) {_description = "Description not found"; } } }
        static string _description = "Description not found";
        private int Cost { get; set; }
        static int Code { get; set; } = 23152;
        public Goods(string name, string desc, int cost)
        {
            Name = name;
            _description = desc;
            Cost = cost;
        }
        
        public void ShowInfo()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Good information:");
            Console.ResetColor();
            Console.WriteLine($"Name: {Name}\nDescription: {Description}\nCost: {Cost}\nUnique code: {Code}\n");
        }




    }
}
