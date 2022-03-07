namespace Lab5
{
    public class SeparationCorrector : ITextCorrector
    {
        public string Correct(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {                
                switch (text[i])
                {
                    case '(':
                        if(i < text.Length - 1 && text[i+1].Equals(' '))
                        {
                            text = text.Remove(i+1, 1);
                        }
                        break;
                    case '.':
                    case ',':
                    case ')':
                        if(i > 0)
                        {
                            text = text.Remove(i - 1, 1);
                        }
                        break;
                }
            }

            return text;
        }
    }
}
