using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask
{
    static class ReadWriteData
    {
        public static void RWValues(string path, string writedir)
        {
            if (File.Exists(path))
            {
                BinaryFormatter bf = new BinaryFormatter();
                using (var FS = new FileStream(path, FileMode.OpenOrCreate))
                {
                    var Students = (Student[])bf.Deserialize(FS);
                    Console.WriteLine($"Данные считаны из {path}");
                    foreach (var student in Students)
                    {
                        string groupFile = writedir + "/" + student.Group + ".txt";
                        using (FileStream fs = new FileStream(groupFile, FileMode.Append))
                        {
                            using (StreamWriter sw = new StreamWriter(fs))
                                sw.WriteLine($"{student.Name}, {student.DateOfBirth}");
                        }
                    }
                }

                Console.WriteLine("Данные отсортированны по названию групп");
            }
            else
            {
                Console.WriteLine("File not found");
            }
        }
    }
}
