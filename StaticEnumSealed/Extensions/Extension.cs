using System;
using System.Collections.Generic;
using System.Text;

namespace StaticEnumSealed.Extentions
{
   public static class Extension
    {

       public static void Find(this string word,char letter) {
            foreach (var item in word)
            {
                if (item == letter)
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("no");
                }
            }

        }


        public static void ExMethod(this int num1,int num2)
        {
            if (num1 > num2)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }

    }
}
