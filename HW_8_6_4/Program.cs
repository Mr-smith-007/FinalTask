using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace FinalTask
{
    class Programm
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите путь к файлу");
            string path = Console.ReadLine();
            string writeDirectory = @"C:\Users\repnikov.a\Desktop\Students";
            if (!Directory.Exists(writeDirectory))
            {
                Directory.CreateDirectory(writeDirectory);
            }
            ReadWriteData.RWValues(path, writeDirectory);
        }




    }
}
