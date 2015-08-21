namespace Events
{
    using System;

    class SomeEvent : EventArgs
    {
        private string message;

        public SomeEvent(string s)
        {
            this.Message = s;
        }

        public string Message 
        {
            get
            {
                return this.message;
            }
            set
            {
                this.message = value;
            }
        }
    }
}
