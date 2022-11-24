using System;

namespace binary_search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Select Programs\n 1.Binary search");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        binary binarysearch = new binary();
                        binarysearch.Search("C:\\Users\\RJ EMPIRE\\Desktop\\New folder\\sorting\\binary_search\\TextFile1.txt");
                        break;
                }
            }
        }
    }
}