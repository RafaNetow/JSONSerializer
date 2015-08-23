
namespace JsonSerializer
{
    public class Calculetor
    {
        public int FirstNumber { set; private get; }
        public int SecondNumber { set; private get; }

        public int add()
        {
            return SecondNumber + FirstNumber;
        }
    }
}
