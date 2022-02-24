using System;
using Roman;

namespace lab1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RomanNumber rn1 = new RomanNumber(71);
            RomanNumber rn2 = (RomanNumber)rn1.Clone();
            //rn2 = RomanNumber.Add(rn1, rn2);
            Console.WriteLine($"{rn1.ToString()}  {rn2.ToString()} {rn1.CompareTo(rn2)}");
        }
    }
}