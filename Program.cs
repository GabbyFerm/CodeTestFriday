
namespace CodeTestFriday
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            // Testa funktionen
            var input = new List<string> { "listen", "silent", "enlist", "rat", "tar", "art", "evil", "vile", "live" };
            var resultat = AnagramGroup.GroupAnagrams(input);

            // Skriv ut resultatet
            foreach (var grupp in resultat)
            {
                Console.WriteLine(string.Join(", ", grupp));
            }
        }
    }
}
