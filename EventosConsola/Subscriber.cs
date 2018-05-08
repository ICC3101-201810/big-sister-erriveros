using System;
namespace EventosConsola
{
    public class Subscriber
    {
        public Subscriber()
        {
        }

        //Tiene la misma firma del delegate del evento
        public void c_ThresholdReached(object sender, EventArgs e)
        {
            Counter c = (Counter)sender;
            Console.WriteLine("The threshold was reached.");
            Console.WriteLine(c.GetTotal());
        }
    }
}
