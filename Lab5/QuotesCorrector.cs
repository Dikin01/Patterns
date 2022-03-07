namespace Lab5
{
    public class QuotesCorrector : ITextCorrector
    {
        public string Correct(string text)
        {
            
            for (int i = 1; i < text.Length; i++)
            {
                if(text[i].Equals('“'))
                {
                    text = text.Remove(i, 1);
                    text = text.Insert(i, "«");
                }
                else if(text[i].Equals('”'))
                {
                    text = text.Remove(i, 1);
                    text = text.Insert(i, "»");
                }
                
            }

            return text;
        }
    }
}
