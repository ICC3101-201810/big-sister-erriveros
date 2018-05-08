using System;
namespace EventosConsola
{
    public class OtherSubs
    {
        public OtherSubs()
        {
        }

        //Tiene la misma firma del delegate del evento
        public void OtherMethodForThreshold(object sender, EventArgs e)
        {
            Console.WriteLine("New Alarm!");
        }
    }
}
