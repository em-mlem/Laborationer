namespace AverageLength_lab;

public class SentenceAnalyzer
{
    public int Letters { get; private set; }
    public int Words { get; private set; }
    public double AverageWordLength { get; private set; }

    public string GetFeedback(string sentence)
    {
        return "Det finns ingen text att analysera.";
    }
}
