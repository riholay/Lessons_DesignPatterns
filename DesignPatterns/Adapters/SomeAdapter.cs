using DesignPatterns.Interface;

namespace DesignPatterns.Adapters
{
    public class SomeAdapter : IAdapter
    {
        private readonly Adaptee _adaptee;

        public SomeAdapter()
        {
            _adaptee = new Adaptee();
        }

        public string DoSomething()
        {
            var result = _adaptee.GetSomething();
            return $"something else with {result}.";
        }
    }
}
