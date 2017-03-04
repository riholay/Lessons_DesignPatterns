using DesignPatterns.Adapters;
using DesignPatterns.Interface;

namespace DesignPatterns
{
    public class Client
    {
        private readonly IAdapter _adapter;

        public Client()
        {
            _adapter = new SomeAdapter();
        }

        public string Get()
        {
            return _adapter.DoSomething();
        }
    }
}
