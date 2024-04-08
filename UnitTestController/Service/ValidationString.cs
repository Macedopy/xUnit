namespace UnitTestController.Service
{
    public class ValidationString
    {
        public int ReturnTheLenght(string text)
        {
            var numberCharacteres = text.Length;
            return numberCharacteres;
        }

        public bool HasCharacteres(string text, string FindText)
        {
            var hasCharacter = text.Contains(FindText);
            return hasCharacter;
        }

        public bool EndWith(string text, string FindText)
        {
            var end = text.EndsWith(FindText);
            return end;
        }
    }
}