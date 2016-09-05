
namespace Reflection2
{
    public class Counter
    {
        public delegate void CounterDelegate();

        public event CounterDelegate OnCount;

        public void Count()
        {
            for (int i = 0; i < 50; i++)
            {
                if (i == 25)
                {
                    this.OnCount();
                }
            }
        }
    }
}

