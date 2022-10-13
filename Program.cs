using System;
using System.IO;

namespace Word_Count
{
    class Program
    {
        static void Main()
        {
            while(true)
            {
                Console.Write("Press enter to start the count: ");            
                Console.ReadLine();
                LoadIcon(100);

                string[] text = File.ReadAllLines("TextFile\\File.txt");
                int words = 0;
                bool canCount = false;

                for (int i = 0; i < text.Length; i++)
                {
                    text[i] += ' ';
                    string s = text[i];

                    for (int j = 0; j < s.Length; j++)
                    {
                        if(s[j] != ' ')
                        {
                            canCount = true;
                        }
                        else if(s[j] == ' ' && canCount == true)
                        {
                            canCount = false;
                            words++;
                        }

                    }

                }

                Console.Write("This text has ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(words);
                Console.ForegroundColor = ConsoleColor.White; 
                Console.WriteLine(" words in it");
                Console.WriteLine("Type n to quit or just press enter to count again");
                string ask = Console.ReadLine();
                if(ask == "n")
                {
                    Environment.Exit(0);
                } 
            }

        }

        static void LoadIcon(int SleepTime)
        {
            Console.WriteLine("|");      
            Thread.Sleep(SleepTime);
            Console.Clear();
            Console.WriteLine("/"); 
            Thread.Sleep(SleepTime);   
            Console.Clear();
            Console.WriteLine("-"); 
            Thread.Sleep(SleepTime);   
            Console.Clear();
            Console.WriteLine("\\");
            Thread.Sleep(SleepTime);    
            Console.Clear();
            Console.WriteLine("|"); 
            Thread.Sleep(SleepTime);   
            Console.Clear();
        }

    }   
}