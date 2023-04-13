namespace Pramptests
{
    public class Decrypter
    {
        public static string Decrypt(string word)
        {
            string decryptedWord = "";
            int oldValue = 1, newValue;
            int valueOfA = (int)'a';

            for (int i = 0; i < word.Length; i++)
            {
                newValue = (int)(word[i]) - oldValue;
                oldValue = (int)(word[i]);

                while (newValue < valueOfA)
                {
                    newValue += 26;
                }
                decryptedWord = decryptedWord + (char)newValue;
            }
            return decryptedWord;
        }
    }
}
