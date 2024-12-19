using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E03Operatori
    {

        public static void Izvedi()
        {

            // Console.WriteLine("E03");
            // nećemo objašnjavati + - * / jer smo to radili u sql-u

            int i, j;
            i = 2;j = 3;
            i += j; // ekvivalent i=i+j, ista prica je i kod - * / 

            // modulo operator % ostatak nakon cijelobrojnog dijeljenja 

            Console.WriteLine( i/j); // kada se dijele dva int dobije se int (izgubi se decimalni dio)

            Console.WriteLine(i/(float)j); // na ovaj nacin dobijemo decimalni broj jer smo jedan od ova dva broja naveli pod float

            Console.WriteLine(5 % 2); // operatorom modulo (%) koristimo da bi otkrili sta je parni a sta neparni broj, 

            // increment i decrement

            i = 1;
            // razliciti nacin uvecanja varijable za broj 1
            i = i + 1;
            i += 1;
            i++;
            ++i;



            Console.WriteLine("*********************");
            i = 1;
            Console.WriteLine(i); // 1
            Console.WriteLine(i++); // 1 -> Prvo se koristi pa se onda uveca
            Console.WriteLine(++i); // 3 -> Prvo se uveca pa se onda koristi/ispise

            // sve isto vrijedi i za decrement i--, --i
            Console.WriteLine("---------------------");
            int x = 1, y = 0;

            x = x + --y; // x= 0, y= -1
            y += ++x; // x= 1, y= 0
            Console.WriteLine(++x - y--); // 2 - 0 = 2
            
                                  


        }



    }
}
