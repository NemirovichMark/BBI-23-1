using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static preparation_exam_OOP.Task1;
using static preparation_exam_OOP.Task2;

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
                Number current = numbers[i];
                int j = i - 1;

                while (j >= 0 && numbers[j].Real > current.Real)
                {
                    numbers[j + 1] = numbers[j];
                    j--;
                }
                numbers[j + 1] = current;
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

    public class Task2
    {
        public class Number
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

        public class ComplexNumber : Number
        {
            //properties
            public double Imagine { get; }

            //constructor 
            public ComplexNumber(double real, double imagine) : base(real)
            {
                Imagine = imagine;
            }

            //method to add complex numbers
            public ComplexNumber Add(ComplexNumber number)
            {
                return new ComplexNumber(this.Real + number.Real, this.Imagine + number.Imagine);
            }

            //method to subtract complex numbers
            public ComplexNumber Sub(ComplexNumber number)
            {
                return new ComplexNumber(this.Real - number.Real, this.Imagine - number.Imagine);
            }

            //method to multiply complex numbers
            public ComplexNumber Mul(ComplexNumber number)
            {
                double real = this.Real * number.Real - this.Imagine * number.Imagine;
                double imagine = this.Real * number.Imagine + this.Imagine * number.Real;

                return new ComplexNumber(real, imagine);
            }

            //method to divide complex numbers
            public ComplexNumber Div(ComplexNumber number)
            {
                double denominator = number.Real * number.Real + number.Imagine * number.Imagine;
                double real = (this.Real * number.Real + this.Imagine * number.Imagine) / denominator;
                double imagine = (this.Imagine * number.Real - this.Real * number.Imagine) / denominator;

                return new ComplexNumber(real, imagine);
            }

            //method to output results
            public override string ToString()
            {
                return $"Number = {Real} {(Imagine >= 0 ? "+" : "-")} {Math.Abs(Imagine)}i";
            }
        }

        //properties for class Task2
        private ComplexNumber[] numbers;
        public ComplexNumber[] Numbers
        {
            get { return numbers; }
        }

        //constructor
        public Task2(ComplexNumber[] number)
        {
            this.numbers = number;
        }

        //method to sort array with numbers in ascending order
        public void Sorting()
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                Number key = numbers[i];
                double keyModulus = 0;

                // key modulus
                if (key is ComplexNumber complexKey)
                {
                    keyModulus = Math.Sqrt(complexKey.Real * complexKey.Real + complexKey.Imagine * complexKey.Imagine);
                }

                int j = i - 1;

                while (j >= 0)
                {
                    double currentModulus;

                    if (numbers[j] is ComplexNumber complexNumber)
                    {
                        currentModulus = Math.Sqrt(complexNumber.Real * complexNumber.Real + complexNumber.Imagine * complexNumber.Imagine);
                    }
                    else
                    {
                        currentModulus = Math.Abs(numbers[j].Real);
                    }

                    if (currentModulus > keyModulus)
                    {
                        numbers[j + 1] = numbers[j];
                        j--;
                    }
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
            #region task1
            //Number[] numbers = new Number[]
            //{
            //    new Number(5.4573),
            //    new Number(6.34727272),
            //    new Number(2.1),
            //    new Number(1.3262),
            //    new Number(3.67788)
            //};

            //Task1 task = new Task1(numbers);

            //Console.WriteLine("Before sorting:");
            //Console.WriteLine(task);

            //task.Sorting();

            //Console.WriteLine("After sorting:");
            //Console.WriteLine(task);
            #endregion


            #region task 2
            preparation_exam_OOP.Task2.Number[] nums = new preparation_exam_OOP.Task2.Number[]
            {
                new preparation_exam_OOP.Task2.Number(5.5),
                new preparation_exam_OOP.Task2.ComplexNumber(3.2, 4.1),
                new preparation_exam_OOP.Task2.Number(8.1),
                new preparation_exam_OOP.Task2.ComplexNumber(1.4, -1.2)
            };

            Task2 task2 = new Task2(nums);

            Console.WriteLine("Before Sorting:");
            Console.WriteLine(task2);

            task2.Sorting();

            Console.WriteLine("After Sorting:");
            Console.WriteLine(task2);
            #endregion
            Console.ReadKey();
        }
    }
}
