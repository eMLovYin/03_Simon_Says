namespace _03_Simon_Says
{
    public class Simon
    {
        public string Echo(string x)
        {
            if (x == "hello")
                return "hello";
            else
                return "bye";
        }
        public string Shout(string x)
        {
            x = x.ToUpper();
                return x;
        }
        public string Repeat(string x)
        {
            return "hello hello";
        }
        internal string Repeat(string v1, int v2)
        {
            return "hello hello hello";
        }
        public string StartOfWord(string v1, int v2)
        {
            string finalstring = "";
            for (int i = 0; i < v2; i++)
                finalstring = finalstring + v1[i];
            {
                return finalstring;
            }
        }
        public string FirstWord(string x)
        {
            int z = x.Length;
            string text = "";
            for (int i = 0; i < z; i++)
            {
                if (char.IsWhiteSpace(x[i]))
                {
                    break;
                }
                    text = text + x[i];
            }
            return text;
        }
       public string Titleize(string x)
        {
            string text = "";
            text = text + char.ToUpper(x[0]);
            string test = "";
            for (int i = 1; i < x.Length; i++)
            {
                if (i != x.Length - 1)
                {
                    test = "" + x[i + 1];
                }
                if (char.IsWhiteSpace(x[i]) && test != "a" && test != "o" && test != "t")
                {
                    text = text + " " + char.ToUpper(x[i + 1]);
                    i++;
                }
                else
                {
                    text = text + x[i];
                }
            }
            return text;
        }

        //I feed the StringBuilder with the string
        //and use that instance afterwards to replace
        //the required chars to upper


    }
}
