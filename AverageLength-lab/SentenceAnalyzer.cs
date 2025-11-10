namespace AverageLength_lab;

public class SentenceAnalyzer
{
    public int Letters { get; private set; }
    public int Words { get; private set; }
    public double AverageWordLength { get; private set; }
    public double CalculateAverageWordLength(string sentence)
    {
        Letters = 0;
        Words = 0;

        int currentWordLength = 0;

        for (int i = 0; i < sentence.Length; i++)
        {
            char c = sentence[i];

            if (char.IsLetter(c))
            {
                currentWordLength++;
            }
            else
            {
                if (currentWordLength > 0)
                {
                    Letters += currentWordLength;
                    Words++;
                    currentWordLength = 0;
                }
            }
        }

        if (currentWordLength > 0)
        {
            Letters += currentWordLength;
            Words++;
        }

        double average = 0;

        if (Words > 0)
        {
            average = (double)Letters / Words;
            average = Math.Round(average, 2);
        }

        AverageWordLength = average;
        return average;
    }
    public string GetFeedback(string sentence)
    {
        double average = CalculateAverageWordLength(sentence);

        if (Words == 0)
        {
            return "Det finns ingen text att analysera.";
        }

        return $"Antal ord: {Words}, antal bokstäver: {Letters}, medellängd: {average}.";

    }
   
}
