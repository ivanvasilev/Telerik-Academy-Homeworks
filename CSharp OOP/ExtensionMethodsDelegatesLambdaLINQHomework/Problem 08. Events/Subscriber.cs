namespace Events
{
    using System;

    class Subscriber
    {
        private string name;
        public Subscriber(string name, Publisher pub)
        {
            this.Name = name;
            pub.RaiseCustomEvent += HandleSomeEvent;
        }
        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }
        void HandleSomeEvent(object sender, SomeEvent e)
        {
            Console.WriteLine("\nThis is how the event is handled:\n");
            Console.WriteLine(this.name + " received this message: {0}", e.Message);
        }
    }
}
