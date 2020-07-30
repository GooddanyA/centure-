using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;


namespace ConsoleApp1
{
    class Program
    {
        

        static void Main()
        {
          Centure();
        }
        public static void Centure()
        {
            Console.WriteLine("Введите ваш год ");
            
            int year = int.Parse (Console.ReadLine());
            
            if (year % 100 == 0)
            {
                
                Console.Write
                    ( year / 100  );
                Console.WriteLine(" Век");
            }
            if (year % 100 != 0)
            {
                Console.Write((year / 100) + 1);
                Console.WriteLine(" Век");
            }

            Console.WriteLine("Желаете еще?");
            string g = Console.ReadLine();
            switch (g)
            {
                case "Да":
                   Centure();
                    break;
                    
                case "Нет":
                    break;

            }
        }
    }    
}

