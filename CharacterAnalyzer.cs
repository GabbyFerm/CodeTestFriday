namespace CodeTestFriday
{
    public class CharacterAnalyzer
    {

        public static char FirstNonRepeatingCharacter(string inputText)
        {
            // Dictionary för att hålla koll på antalet förekomster av varje tecken
            Dictionary<char, int> characterCount = new Dictionary<char, int>();

            // Första iteraktionen räkna antalet förekomster av varje tecken
            foreach (char character in inputText)
            {
                if (characterCount.ContainsKey(character))
                {
                    characterCount[character]++;
                }
                else
                {
                    characterCount[character] = 1;
                }
            }

            // Andra iteraktionen hitta det första tecknet som inte upprepas
            foreach (char character in inputText)
            {
                if (characterCount[character] == 1)
                {
                    return character;
                }
            }

            // Om inget tecken är unikt, returnera '_'
            return '_';
        }
    }
}