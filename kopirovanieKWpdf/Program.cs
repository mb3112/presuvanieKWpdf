using System;
using System.IO;

namespace kopirovanieKWpdf
{
    class Program
    {
        static void Main(string[] args)
        {

            string endfolder = @"Z:\Kvalita\Vyhodnotenia\Wochenubersicht pro Spedition\pro Woche";

            string[] array1 = Directory.GetFiles(endfolder, "*.pdf");
            //Console.WriteLine("--- Files: ---");

            foreach (string name in array1)
            {
                int charPos = name.IndexOf(" Beanstandungen");
                string lastName = name.Substring(0, charPos);
                string pathString = Path.Combine(endfolder, lastName);

                if (!Directory.Exists(pathString))
                {
                    //Console.WriteLine(pathString);
                    //Console.WriteLine(Path.GetFileName(name));
                    //Console.WriteLine(Path.Combine(pathString, Path.GetFileName(name)));
                    Directory.CreateDirectory(pathString);
                    File.Move(name, Path.Combine(pathString, Path.GetFileName(name)), true);
                    //File.WriteAllText(@"C:\martin\prac\export\WriteText.txt", pathString);
                    Console.WriteLine("--- :HOTOVO!: ---");
                }
                else
                {
                    File.Move(name, Path.Combine(pathString, Path.GetFileName(name)));
                }
            }

            Console.WriteLine("--- :HOTOVO!: ---");
        }
    }
}
