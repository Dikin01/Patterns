namespace Lab5
{
    public class MultSpacesCorrector : ITextCorrector
    {
        public string Correct(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (i < text.Length - 1 && text[i].Equals(' '))
                {
                    int j;
                    for (j = i + 1; j < text.Length; j++)
                    {
                        if (!text[j].Equals(' '))
                        {                            
                            break;
                        }
                    }
                    text = text.Remove(i + 1, j - i - 1);
                }
            }

            return text;
        }
    }
}
