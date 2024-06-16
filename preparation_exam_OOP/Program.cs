using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static preparation_exam_OOP.Task1;

namespace preparation_exam_OOP
{
    public class Task1
    {
        public struct Number
        {
            public double Real { get; }

            //constructor
            public Number(double real)
            {
                Real = real;
            }

            //method to add numbers
            public Number Add(Number number)
            {
                return new Number(this.Real + number.Real);
            }

            //method to subtract numbers
            public Number Sub(Number number)
            {
                return new Number(this.Real - number.Real);
            }

            //method to multiply numbers
            public Number Mul(Number number)
            {
                return new Number(this.Real * number.Real);
            }

            //method to divide numbers
            public Number Div(Number number)
            {
                return new Number(this.Real / number.Real);
            }

            //method to output results
            public override string ToString()
            {
                return $"Number = {Real}";
            }
        }

        private Number[] numbers;
        public Number[] Numbers
        {
            get { return numbers; }
        }

        //constructor
        public Task1(Number[] number)
        {
            this.numbers = number;
        }

        //method to sort array with numbers in ascending order
        public void Sorting() //insertion sort
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                Number key = numbers[i];
                int j = i - 1;

                while (j >= 0 && numbers[j].Real > key.Real)
                {
                    numbers[j + 1] = numbers[j];
                    j--;
                }
                numbers[j + 1] = key;
            }
        }

        //method to output the array with numbers
        public override string ToString()
        {
            string result = string.Empty;

            foreach (var number in numbers)
            {
                result += number.ToString() + Environment.NewLine;
            }

            return result;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //task 1 var 1 

            Number[] numbers = new Number[]
            {
                new Number(5.4573),
                new Number(6.34727272),
                new Number(2.1),
                new Number(1.3262),
                new Number(3.67788)
            };

            Task1 task = new Task1(numbers);

            Console.WriteLine("Before sorting:");
            Console.WriteLine(task);

            task.Sorting();

            Console.WriteLine("After sorting:");
            Console.WriteLine(task);

            Console.ReadKey();
        }
    }
}
