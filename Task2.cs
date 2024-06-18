using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Variant_1
{
    public class Task2
    {
        //class Number from task 1 
        public class Number
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

        //inherited class complexnumber from class number
        public class ComplexNumber : Number
        {
            //fields
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
                //everything comes from formula of complex number division from the internet
                double denominator = number.Real * number.Real + number.Imagine * number.Imagine;
                double real = (this.Real * number.Real + this.Imagine * number.Imagine) / denominator;
                double imagine = (this.Imagine * number.Real - this.Real * number.Imagine) / denominator;

                if (number.Real != 0) 
                    return new ComplexNumber(real, imagine);
                else
                    return new ComplexNumber(0, 0);
            }

            //method to output results
            public override string ToString()
            {
                return $"Number = {Real} {(Imagine >= 0 ? "+" : "-")} {Math.Abs(Imagine)}i"; //math.abs imagine part always positive
            }
        }

        //new code particularly for task 2

        //field
        private ComplexNumber[] numbers;

        //property to read a field
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

                numbers[j + 1] = (ComplexNumber)key;
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
}
