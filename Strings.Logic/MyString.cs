namespace Strings.Logic
{
    public class MyString
    {
        private readonly string _text;

        public MyString(string text)
        {
            _text = text;
        }

       public string ReadBeam()
        {
            string myBeam = Console.ReadLine();
            return myBeam;
        }

        public bool ValidateBase()
        {
            char baseBeam = _text[0];
            return (baseBeam == '%' || baseBeam == '&' || baseBeam == '#');
        }

        public bool ValidateConnections()
        {
            string aux = _text;
            for (int i = 0; i < aux.Length - 1; i++)
            {
                if (aux[i] == '*')
                {
                    if (aux[i] == '*' && aux[i+1] == '*')
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public int CalculateWeightBeam()
        {
            string aux = _text;
            int weight = 0;
            int crossbarCount = 0;
            for (int i = 1; i < aux.Length; i++)
            {
                if (aux[i] == '=')
                {
                    crossbarCount++;
                    weight += crossbarCount;
                }
                if (aux[i] == '*')
                {
                    weight += 2 * (crossbarCount * (crossbarCount + 1)/2);
                    crossbarCount = 0;
                }
            }
            return weight;
        }

        public bool beamResists(int weight)
        {
            char baseBeam = _text[0];
            if (baseBeam == '%' && weight > 10)
            {
                return false;
            }
            if (baseBeam == '&' && weight > 30)
            {
                return false;
            }
            if (baseBeam == '#' && weight > 90)
            {
                return false;
            }
            return true;
        }

        public string? PrintString(MyString myBeam)
        {
            string output = string.Empty;
            for (int i = 0; i < _text.Length; i++)
            {
                output += $"{_text[i]}";
            }
            return output;
        }

    }
}

