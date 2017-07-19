using System;

namespace e1
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            Alloggio[] lista = new Alloggio[2];
            for (int i = 0; i < lista.Length; i++)
            {
                Alloggio n1 = new Alloggio();
                Console.WriteLine("Codice:");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Estensione:");
                double b= Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Costo:");
                double c = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Metri Q:");
                double d = Convert.ToDouble(Console.ReadLine());
                n1.Inserisci(a,b,c,d);
                Console.WriteLine(n1.Stampa());
            }
            Console.WriteLine("Inserire il codice:");
            int e = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < lista.Length; i++)
            {
                Alloggio n2 = (Alloggio)lista[i];
                Console.WriteLine(n2.getCodice().ToString());
                if(e==n2.getCodice()){
                    Console.WriteLine(n2.Stampa());
                }
            }







        }
    }
}