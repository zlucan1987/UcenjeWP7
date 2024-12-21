using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class Q01Vjezba
    {

        public static void Izvedi()
        {

            //Console.WriteLine("Q01Vjezba");

            bool x = true;
            bool y = false;

            bool andResult = (x && y); // ako je x istinit i ako je y istinit onda se podrazumjeva da je istinito
                                       // u ovom slucaju je False jer Y ne zadovoljava uvjet
            Console.WriteLine(andResult);

            bool orResult = (x || y); // ako x ili y zadovoljavaju true onda je rezultat istinit= true = tocan, btw -->  || - double pipe oznaka je ujedno oznaka za "or"
            Console.WriteLine(orResult);

            bool notResult1 = (x && !y); // x= true, y= false, ali u ovom slucaju sa oznakom ! mjenjamo y u true
            Console.WriteLine(notResult1);

            bool notResult2 = !x; // ! invert x koji je bio true, sada je false
            Console.WriteLine(notResult2);



        }
    }
}
