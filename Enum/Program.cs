using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Alfabede merak ettiğiniz sıra numarasını giriniz.");
            byte alfabe_no = Convert.ToByte(Console.ReadLine());
            Alfabeler alfabe;
            Console.WriteLine(alfabe = (Alfabeler)alfabe_no);
            Console.WriteLine("Sıra numarasını  merak ettiğiniz alfabeyi giriniz.");
            String alfabe_adi = Console.ReadLine();
            String[] alfabeler = Alfabeler.GetNames(typeof(Alfabeler));
            foreach (String a in alfabeler)
            {
                if (a == alfabe_adi)
                {
                    var number = (byte)((Alfabeler) Enum.Parse(typeof(Alfabeler), alfabe_adi));
                    Console.WriteLine(number);
                }
            }


            Console.ReadKey();
        }
    }
    enum Alfabeler : byte
    {
        a=1,
        b,
        c,
        ç,
        d,
        e,
        f,
        g,
        ğ,
        h,
        ı,
        i,
        j,
        k,
        l,
        m,
        n,
        o,
        ö,
        p,
        r,
        s,
        ş,
        t,
        u,
        ü,
        v,
        y,
        z,

    }
}
