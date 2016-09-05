using System;

namespace Reflection2
{
    public class Program
    {
        static void Main(string[] args)
        {

            Counter counter = new Counter();
            Handler handler = new Handler();

            Console.WriteLine(counter.GetType());

            var eventInfo = counter.GetType().GetEvent("OnCount");
            var methodInfo = handler.GetType().GetMethod("MessageDisplay");
            Delegate handler1 = Delegate.CreateDelegate(eventInfo.EventHandlerType,
                                         handler,
                                         methodInfo);

            eventInfo.AddEventHandler(counter, handler1);
            counter.Count();

            Console.ReadKey();
        }
    }
}
