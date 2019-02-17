using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string xstring = ""; //mayor a 4
            int d = 0; //Numeros que se tomarán de en medio
            int r = 0;
            string cadena = ""; 
            Console.WriteLine("Introduzca X inicial");
            xstring = Console.ReadLine();

            Console.WriteLine("Cantidad a tomar");
            d = int.Parse(Console.ReadLine());

            Console.WriteLine("Número de repeticiones");
            r = int.Parse(Console.ReadLine());


            #region proceso
            for (int dos = 0; dos < r; dos++)
            {

            double x = Convert.ToDouble(xstring);
            double y = Math.Pow(x, 2);

            string ystring = Convert.ToString(y);
            int middle = ((ystring.Length - 1) / 2);
            char chart = ystring[middle];

            int izquierda  = d / 2;
            int derecha = d -izquierda;

            for (int i = 0; i < izquierda; i++)
            {
                cadena = cadena + Convert.ToString(ystring[middle - 1]);
            }
            for (int i = 0; i < derecha; i++)
            {
                cadena = cadena + Convert.ToString(ystring[middle + i]);
            }

            
            xstring = cadena;
                double rx = (Convert.ToDouble(xstring)/1000);
            //Console.WriteLine(ystring+" "+cadena.ToString() );
            Console.WriteLine("X="+cadena.ToString() +" R="+rx);
                cadena = "";
            }
            //Console.Write(i.ToString()+" "+de.ToString());
            Console.ReadKey();
            #endregion
        }
    }
}
