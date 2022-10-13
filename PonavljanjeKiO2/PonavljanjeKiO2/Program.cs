using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PonavljanjeKiO2
{
    internal class Program
    {

        class GeometrijskiLik
        {
            int BrojStranica;
             double[] Str = new double[10];

             int BrojStranica1 { get => BrojStranica; set => BrojStranica = value; }
            public double[] Str1 { get => Str; set => Str = value; }

            public void UcitajStranice(double stranica)
            {
                Str1.Append(stranica);

            }
            public double Opseg(double[] str12)
            {
                double s = 0;

                for (int i = 0; i < str12.Length; i++)
                {
                    s = s + str12[i];
                }
                return s;
            }
        }
        class Trokut : GeometrijskiLik
        {
            int BrojStranica = 3;
        }
        class Cetverokut : GeometrijskiLik
        {
            int BrojStranica = 4;

        }


        static void Main(string[] args)
        {

            Trokut Trokut = new Trokut();
            Cetverokut Cetverokut = new Cetverokut();

            Trokut.UcitajStranice(12.34);
            Cetverokut.UcitajStranice(20.34);
            Trokut.UcitajStranice(22.34);
            Cetverokut.UcitajStranice(12.94);
            Trokut.UcitajStranice(13.34);
            Cetverokut.UcitajStranice(12.34);
            Cetverokut.UcitajStranice(124.34);

            Console.WriteLine(Cetverokut.Opseg(Cetverokut.Str1));
            Console.WriteLine(Trokut.Opseg(Trokut.Str1));
            Console.ReadKey();

        }
    }
}
