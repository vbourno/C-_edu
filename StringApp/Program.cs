namespace StringApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "       AUEB       ";                               // Not nullable
            string? s2;                              // Nullable
            string s3 = "AUEBEUA";
            string s4 = "Coding Factory";
            string s5 = new string("AUEB");
            string s6 = new("aueB");
            string s7 = String.Intern("AUEB");

            bool eq1 = (s1 == s5);
            bool eq2 = s1.Equals(s5);
            bool refEq = ReferenceEquals(s1, s7);

            int state = string.Compare(s1, s3);
            Console.WriteLine(state);

            string s1s3 = s1 + s3;

            string uppers3 = s3.ToUpper();

            Console.WriteLine(eq1);
            Console.WriteLine(eq2);
            Console.WriteLine(refEq);

            Console.WriteLine(s1.ToUpper() == s6.ToUpper());

            int index = s4.IndexOf("o", 7);

            string factory = s4.Substring(7, 7);
            Console.WriteLine(factory);

            char[] trimChars = { ' ', '*', '&', '%', '$' };
            string trimmedS1 = s1.Trim(trimChars);

            bool isPalindrome = true;
            for (int i = 0, j = s3.Length - 1; i < j; i++, j--)
            {
                if (s3[i] != s3[j])
                {
                    isPalindrome = false;
                    break;
                }
            }
            Console.WriteLine(isPalindrome);
        }
    }
}