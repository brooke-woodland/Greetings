using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFun2
{
    internal class PrintStuff
    {
        private string language;

        //constructor: automatically called when program runs
      public PrintStuff(string temp)
        {
            language = temp;
        }

      public PrintStuff()
        {
            language = "EN";
        }
        public void PrintName(string firstName)
        {   
            if (language == "EN")
            {
            System.Console.WriteLine("hello, " + firstName + "!");
     
            }

            if (language == "PT")
            {
                System.Console.WriteLine("oi, " + firstName + "!");
            }
        }

        public void PrintName()
        {
            if (language == "EN")
            {
                System.Console.WriteLine("hello, winner!");

            }

            if (language == "PT")
            {
                System.Console.WriteLine("oi, winner!");
            }
        }
    }
}
