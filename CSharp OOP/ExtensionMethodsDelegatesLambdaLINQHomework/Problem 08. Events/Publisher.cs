namespace Events
{
    using System;

    class Publisher
    {
        public delegate void CustomEventHandler(object sender, SomeEvent e);
        public event CustomEventHandler RaiseCustomEvent;
        public void RaiseSampleEvent()
        {
            Console.WriteLine("An event will be raised!");
            OnRaiseCustomEvent(new SomeEvent("This is some event"));
        }
        protected virtual void OnRaiseCustomEvent(SomeEvent e)
        {
            CustomEventHandler handler = RaiseCustomEvent;
            if (handler != null)
            {
                e.Message += String.Format(" at {0}", DateTime.Now);
                handler(this, e);
            }
        }
    }
}
