using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hello_Word
{
    class FileIO
    {
        static private int x;
    }
    class MyFile : FileIO
    {
        public MyFile()
        {
            Console.WriteLine(FileIO.x);
        }

    }
    internal class Program
    {
        static void PrintName(string _name, string _order = "fgsdrg")
        {
            Console.WriteLine("Hello, ");
            Console.Write("Hello, \n");
            if (_order == "-")
            {
                for (int i = 1; i < _name.Length; i += 2)
                {
                    Console.Write(_name[i] + "\n");
                }
            }
            else
            {

                for (int i = 1; i < _name.Length; i += 2)
                {
                    Console.Write(_name[i] + "\n");
                }
            }
            Console.WriteLine("!");
        }
        static void Main(string[] args)
        {
            string name = "", order = "";
            Console.WriteLine(value: FileIO.x);
            try
            {
                name = args[0];
                order = args[1];
            }
            catch
            {
                Console.WriteLine("Как вас зовут?");
                name = Console.ReadLine();
            }
            finally
            {
                PrintName(name, order);

            }
            Console.ReadKey();
        }
    }
}