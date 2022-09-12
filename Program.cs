using System;

namespace overloading_ep
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.convert(9);
            program.convert(9.8F);
            program.convert(14.54D);

            Deneme deneme = new Deneme();
            deneme.Convert(4);
            deneme.Convert(6,4);

            Deneme nesne = new NesneD();
            NesneD nesne1 = (NesneD)nesne;
            nesne1.Convert(1, 2, 3);
            nesne.Deneme2();
        }
        public void convert(int a)
        {
            Console.WriteLine("Value is integer : " + a.ToString());
        }
        public void convert (float b)
        {
            Console.WriteLine("Value is float : " + b.ToString());
        }
        public void convert (double c)
        {
            Console.WriteLine("Value is double : " + c.ToString());
        }
    }
    class Deneme
    {
        public void Convert(int a)
        {           
            Console.WriteLine("Value is integer : " + a.ToString());
            
        }
        public void Convert(int x, int y)
        {
            int sonuc;
            sonuc = x + y;
            Console.WriteLine("Value x + y = " + sonuc.ToString());
        }
        public virtual void Deneme2()
        {
            Console.WriteLine("Vol1: Deneme2");
        }
    }
    class NesneD : Deneme
    {
        public void Convert(int x, int y, int z)
        {
            int sonuc;
            sonuc = x + y + z;
            Console.WriteLine("Value x + y + z = " + sonuc.ToString());
        }
        public override void Deneme2()
        {
            base.Deneme2();
            Console.WriteLine("Vol2: Deneme2 ");
        }
    }
}
