using System;

// https://docs.microsoft.com/en-us/dotnet/standard/events/index

namespace EventosConsola
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Counter c = new Counter(new Random().Next(10));
            Subscriber s = new Subscriber();
            OtherSubs os = new OtherSubs();

            //Subscripcion a evento ThresholdReached de la clase Counter
            //En la subscrpcion, las clases le pasan los metodos que seran
            //invocados cuando se lance el evento
            c.ThresholdReached += s.c_ThresholdReached;
            c.ThresholdReached += os.OtherMethodForThreshold;

            Console.WriteLine("press 'a' key to increase total");
            while (Console.ReadKey(true).KeyChar == 'a')
            {
                Console.WriteLine("adding one");
                c.Add(1);
            }
        }


    }
}
