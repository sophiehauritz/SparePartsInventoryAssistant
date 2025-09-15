
class Program
{
    static void Main() // Definerer Main-metoden som er programmets startpunkt
    {
        // Her bliver lageret defineret med eksakte titler
        List<string> inventory = new List<string>
        {
            "hydraulic pump", // reservedel 1
            "PLC module", // reservedel 2
            "servo motor" // reservedel 3
        };

        Console.WriteLine("Hej. Welcome to the spare parts inventory!"); // skriver en velkomstbesked til brugeren
        Console.WriteLine("Which part do you need?"); // spørger brugeren hvilken reservedel de har brug for

        while (true) // starter her en løkke, der kun stopper når der "breakes"
        {
            // læser brugerens input fra konsollen
            string? input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input)) // tjekker om input er tomt eller kun mellemrum
            {
                // hvis input er tomt, spørger vi igen
                Console.WriteLine("Which part do you need?");
                continue;
            }

            // tjekker om brugerens input passer nøjagtigt til et af reservedelene
            if (inventory.Contains(input))
            {
                Console.WriteLine($"I've got {input} here for you 😊"); // bekræfter at reservedelen findes
                break; // afslutter løkken, fordi brugeren har fået en reservedel
            }

            // tjekker om input er et af de særlige spørgsmål
            if (input.Equals("Do you actually have any parts?", StringComparison.OrdinalIgnoreCase) ||
                input.Equals("Is there anything in stock at all?", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"We have {inventory.Count} part(s)!"); // skriver her hvor mange dele der er på lager
                foreach (var part in inventory) // gennemløber alle dele i lageret
                {
                    Console.WriteLine(part); // skriver hver reservedels navn på en ny linje
                }
            }
            else
            {
                // hvis input hverken er i lageret eller et specielt spørgsmål
                Console.WriteLine($"I am afraid we don't have any {input} in the inventory 😔");
            }

            // efter hvert svar (hvis løkken ikke er brudt), spørger vi brugeren igen
            Console.WriteLine("Which part do you need?");
        }
    }
}