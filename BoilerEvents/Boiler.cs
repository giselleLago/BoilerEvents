

namespace BoilerEvents
{
    public class Boiler
    {
        private readonly int temp;
        private readonly int pressure;

        public Boiler(int t, int p)
        {
            temp = t;
            pressure = p;
        }

        public int getTemp()
        {
            return temp;
        }

        public int getPressure()
        {
            return pressure;
        }
    }
}
