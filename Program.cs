using System.Threading.Channels;

namespace CustomStringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "haSan";
            string surname = "abBasov";
            string? domain = string.Empty;

            char oldSymbol = 'a';
            char newSymbol = 'e';

            Convert(name, surname, domain);
            ToUpperCase(name, surname);
            Replace(name, surname,oldSymbol,newSymbol);

        }
        #region UpperCase
        public static void Convert(string name, string surname, string? domain = ".code.edu.az")
        {
            string result = name + " " + surname + domain;

            char[] charArray = result.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {

                char c = charArray[i];
                if (c >= 'a' && c <= 'z')
                {
                    charArray[i] = (char)(c - 'a' + 'A');
                }

            }

            Console.WriteLine((charArray));


        }
        #endregion


        public static void Replace(string name, string surname, char oldSymbol, char newSymbol)
        {
            string result = name + " " + surname;

            char[] charArray = result.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == oldSymbol) charArray[i] = newSymbol;
            }
            Console.WriteLine(charArray);

        }
        #region ToUpperCase
        public static void ToUpperCase(string name, string surname)
        {

            char[] charArray = name.ToCharArray();
            char[] chars = surname.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {

                char c = charArray[i];
                if (c >= 'a' && c <= 'z')
                {
                    charArray[i] = (char)(c - 'a' + 'A');
                    break;
                }

            }
            for (int i = 0; i < chars.Length; i++)
            {

                char c = chars[i];
                if (c >= 'a' && c <= 'z')
                {
                    chars[i] = (char)(c - 'a' + 'A');
                    break;
                }

            }

            Console.Write((charArray));
            Console.WriteLine(chars);

        }

        #endregion
    }
}

