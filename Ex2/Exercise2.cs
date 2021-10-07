using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Exercise2
    {
        public int x;
        public double y;
        public string z;
        private string rating;
        private string palindrome;


        //Constructor overloading.
        public Exercise2(int a, string text, string value)
        {
            this.x = a;
            this.z = text;
            this.Rating = value;
        }

        public Exercise2(double a, string text,string value)
        {
            this.y = a;
            this.z = text.ToUpper();
            this.Palindrome = value;
        }

        public Exercise2(string text, string text2)
        {
            this.z = text + " " + text2;
        }

        //Method overloading
        public int multiplicar(int a)
        {
            return a * a;
        }
        public double multiplicar(double b)
        {
            return b * b;
        }

        // Properties 
        public string Rating
        {
            get { return rating; }
            set
            {

                if (value == "A" || value == "B" || value == "C" || value == "D" || value == "F")
                {
                    rating = value;
                }
                else
                {
                    rating = "N/A";
                }
            }
        }

        public string Palindrome
        {
            get
            {
                return palindrome;
            }

            set
            {
                if (value.SequenceEqual(value.Reverse()))
                {
                    palindrome = value;
                }
                else
                {
                    Console.WriteLine("Not a palindrome");
                }
            }
        }

        //Method to print numbers in diagonal.
        public void digonal_print()
        {
            int i = 0;
            string space = "";
            while(i <= 50)
            {
                Console.WriteLine(space + i);
                space = space + " ";
                i++;
            }
            
        }
    }
}

