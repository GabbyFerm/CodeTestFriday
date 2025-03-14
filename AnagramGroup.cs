namespace CodeTestFriday
{
    public class AnagramGroup
    {

        public static List<List<string>> GroupAnagrams(List<string> wordList)
        {

            // Skapa en dictionary för att hålla koll på anagrammen
            Dictionary<string, List<string>> anagramGroups = new Dictionary<string, List<string>>();

            // Gå igenom varje ord i listan
            foreach (string word in wordList)
            {
                // Sortera bokstäverna i ordet
                string sortedWord = new string(word.OrderBy(character => character).ToArray());

                // Om sorterade ordet redan finns i dictionary
                if (anagramGroups.ContainsKey(sortedWord))
                {
                    // Lägg till ordet i listan för detta anagram
                    anagramGroups[sortedWord].Add(word);
                }
                else
                {
                    // Skapa en ny lista för detta anagram
                    anagramGroups[sortedWord] = new List<string> { word };
                }
            }

            // Returnera alla anagramgrupper
            return anagramGroups.Values.ToList();
        }
    }
}