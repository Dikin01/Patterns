namespace Lab5
{
    public class DashesCorrector : ITextCorrector
    {
        public string Correct(string text)
        {
            string dashTemplate = " — ";
            for (int i = 1; i < text.Length; i++)
            {
                if (i < text.Length - 1 && text[i].Equals('-') &&
                    text[i - 1].Equals(' ') && text[i + 1].Equals(' ')) //Если мы встретили дефис, а слева и справа пробелы
                {
                    text = text.Remove(i - 1, 3);
                    text = text.Insert(i - 1, dashTemplate);
                }
            }

            return text;
        }
    }
}
