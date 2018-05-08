using System;
namespace EventosConsola
{
    public class Counter
    {
        //Este es el delegate del evento, ver 
        //https://docs.microsoft.com/en-us/dotnet/api/system.eventhandler?view=netframework-4.7.2
        public event EventHandler ThresholdReached;

        private int threshold;
        private int total;

        public Counter(int passedThreshold)
        {
            threshold = passedThreshold;
            Console.WriteLine("Threshold: " + threshold);
        }

        public int GetTotal()
        {
            return total;
        }

        public void Add(int x)
        {
            total += x;
            if (total >= threshold)
            {
                //Se lanza el evento
                OnThresholdReached(EventArgs.Empty);
            }
        }

        //Firma del metodo es obligatoria
        protected virtual void OnThresholdReached(EventArgs e)
        {
            EventHandler handler = ThresholdReached;
            //Si hay alguien subscrito...
            if (handler != null)
            {
                handler(this, e);
            }
        }

       
    }
}
