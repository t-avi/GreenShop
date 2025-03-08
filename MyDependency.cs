namespace GreenShop
{
    public class MyDependency : IMyDependency
    {
        //пример DI
        private int _value;

        public int Value { get { return _value; } }
    }

    public interface IMyDependency
    {
        int Value { get; }
    }

}
