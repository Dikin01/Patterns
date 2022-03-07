namespace Lab5
{
    public class TabCorrector : ITextCorrector
    {
        public string Correct(string text)
        {
            for (int i = 1; i < text.Length; i++)
            {
                if (text[i].Equals('\t') && !text[i - 1].Equals('\n'))
                {
                    text = text.Remove(i, 1);                    
                }
            }

            return text;
        }
    }
}
