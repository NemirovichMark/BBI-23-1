using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Variant_1
{
    public class Task1
    {
        //struct Number
        public struct Number
        {
            //field
            private double real;

            //property to read a field
            public double Real
            {
                get
                {
                    return real;
                }
            }

            //constructor
            public Number(double realNum)
            {
                this.real = realNum;
            }

            //method to add numbers
            public Number Add(Number num)
            {
                return new Number(this.real + num.real);
            }

            //method to subtract numbers
            public Number Sub(Number other)
            {
                return new Number(this.real - other.real);
            }

            //method to multiply numbers
            public Number Mul(Number other)
            {
                return new Number(this.real * other.real);
            }

            //method to divide numbers
            public Number Div(Number num)
            {
                if (num.real != 0)
                    return new Number(this.real / num.real);
                else
                    return new Number(0);
            }

            //output
            public override string ToString()
            {
                return $"Number = {this.real}";
            }
        }

        //stuff particularly for class Task1

        //field
        private Number[] numbers;

        //property to read a field
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
            string result = "";
            
            foreach (var number in numbers)
            {
                Console.WriteLine();
                result +=  number.ToString();
            }

            return result;
        }
    }
}
