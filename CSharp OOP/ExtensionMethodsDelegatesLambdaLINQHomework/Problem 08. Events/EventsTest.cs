//Problem 8.* Events
//    Read in MSDN about the keyword event in C# and how to publish events.
//    Re-implement the above using .NET events and following the best practices.

namespace Events
{
    public class EventsTest
    {
        static void Main()
        {
            Publisher eventPublisher = new Publisher();
            new Subscriber("Pesho", eventPublisher);
            new Subscriber("Gosho", eventPublisher);
            eventPublisher.RaiseSampleEvent();
        }
    }
}
