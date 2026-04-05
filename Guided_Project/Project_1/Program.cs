//Animal Adoption Application : 
using System;

class Program
{
    static void Main(string[] args)
    {
        // 2D array: each row = one pet
        // Fields: ID, Name, Age, Physical Description, Personality, Suggested Donation, Species
        string[,] ourAnimals = new string[,]
        {
            { "1", "Buddy", "2", "Medium sized brown dog", "Friendly and energetic", "150", "dog" },
            { "2", "Max", "4", "Large black dog", "Calm and protective", "200", "dog" },
            { "3", "Whiskers", "1", "Small white cat", "Playful and curious", "100", "cat" },
            { "4", "Bella", "3", "Golden retriever dog", "Loyal and affectionate", "180", "dog" }
        };

        Console.WriteLine("🐶 Welcome to Contoso Pets Application 🐾\n");

        // SEARCH FEATURE
        Console.Write("Enter a search term (e.g., friendly, brown, calm): ");
        string searchTerm = Console.ReadLine().ToLower();

        Console.WriteLine("\nMatching Dogs:\n");

        bool found = false;

        // Loop through animals
        for (int i = 0; i < ourAnimals.GetLength(0); i++)
        {
            string species = ourAnimals[i, 6];

            // Step 1: Identify dogs only
            if (species == "dog")
            {
                string physical = ourAnimals[i, 3].ToLower();
                string personality = ourAnimals[i, 4].ToLower();

                // Step 2: Combine descriptions
                string combined = physical + " " + personality;

                // Step 3: Search term match
                if (combined.Contains(searchTerm))
                {
                    found = true;

                    // Display result
                    Console.WriteLine($"ID: {ourAnimals[i, 0]}");
                    Console.WriteLine($"Name: {ourAnimals[i, 1]}");
                    Console.WriteLine($"Age: {ourAnimals[i, 2]}");
                    Console.WriteLine($"Description: {ourAnimals[i, 3]}");
                    Console.WriteLine($"Personality: {ourAnimals[i, 4]}");

                    // Suggested Donation with currency
                    Console.WriteLine($"Suggested Donation: ${ourAnimals[i, 5]}");

                    Console.WriteLine("---------------------------");
                }
            }
        }

        if (!found)
        {
            Console.WriteLine("❌ No matching dogs found.");
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}