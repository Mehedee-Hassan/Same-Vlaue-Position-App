using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "aa" ,"bb" , "cc" ,"aa" ,"vv" ,"aa" };
            int[] position = new int[6];

            findAllPosition(names, position , "aa");
            
            
            bool first = true;
        
           
            for (int i = 0 ;i < position.Length ; i ++)
            {

               
                
                if (position[i] == 1)
                {
                    if (first != true)
                    {
                        Console.Write(",");

                    }
                    Console.Write(i);
                    first = false;
                }


            }






            //names.ToArray<string>();
            //Console.WriteLine(Array.IndexOf(names, "aa"));
            ;
            Console.Read();
        }

        private static int[] findAllPosition(string[] names, int[] position ,string nameToMatch)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (nameToMatch == names[i])
                {
                    position[i] = 1;
                }
            }
            return position;
        }
    }
}
