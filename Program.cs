
namespace CodeTestFriday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Testa GroupAnagrams
            var input = new List<string> { "listen", "silent", "enlist", "rat", "tar", "art", "evil", "vile", "live" };
            var resultat = AnagramGroup.GroupAnagrams(input);

            // Skriv ut resultatet
            foreach (var grupp in resultat)
            {
                Console.WriteLine(string.Join(", ", grupp));
            }
            Console.WriteLine();

            // Testa first repeating character
            Console.WriteLine(CharacterAnalyzer.FirstNonRepeatingCharacter("swiss")); // w
            Console.WriteLine(CharacterAnalyzer.FirstNonRepeatingCharacter("racecars")); // e
            Console.WriteLine(CharacterAnalyzer.FirstNonRepeatingCharacter("aabb")); // _
        }
    }
}
