
namespace ClassLibrary1
{
    public class Alphabet : ILearning
    {
        char _currentValue;

        public string CurrentValue { get { return _currentValue.ToString(); } }

        public Alphabet()
        {
            _currentValue = 'A';
        }

        public Alphabet(char value)
        {
            _currentValue = value;
        }

        public string Next()
        {
            if (_currentValue == 'Z') _currentValue = 'A';
            else _currentValue++;
            return _currentValue.ToString();
        }

        public string Previous()
        {
            if (_currentValue == 'A') _currentValue = 'Z';
            else _currentValue--;
            return _currentValue.ToString();
        }

        public void Reset()
        {
            _currentValue = 'A';
        }

    }
}
