using System;
using System.IO;
using System.Media;

class Program
{
    // Main entry point of the application
    static void Main(string[] args)
    {
        StartChatbot(); // Start the chatbot
    }

    // This method starts the chatbot interaction
    static void StartChatbot()
    {
        // Set the console window title
        Console.Title = "Cybersecurity Awareness Bot";

        // Play voice greeting when chatbot starts
        try
        {
            string audioPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "greeting.wav");
            SoundPlayer player = new SoundPlayer(audioPath);
            player.Load();
            player.PlaySync();
        }
        catch (Exception)
        {
            Console.WriteLine("Audio file could not be played.");
        }

        // Display the ASCII art logo
        DisplayAsciiArt();

        // Ask user for their name
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Please enter your name: ");
        string? userName = Console.ReadLine();

        // Input validation: check if user entered nothing
        if (string.IsNullOrWhiteSpace(userName))
        {
            userName = "User";
        }

        // Display personalised greeting
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nHello, {userName}! Welcome to the Cybersecurity Awareness Bot.");
        Console.WriteLine("I'm here to help you stay safe online.");
        Console.WriteLine("You can ask me about password safety, phishing, safe browsing, or my purpose.");
        Console.WriteLine("Type 'exit' to close the chatbot.\n");

        Console.ResetColor();

        // Start chatbot conversation loop
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("You: ");
            string? userInput = Console.ReadLine();

            // Input validation: check for empty input
            if (string.IsNullOrWhiteSpace(userInput))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Bot: Please enter something.");
                Console.ResetColor();
                continue;
            }

            // Convert input to lowercase for easier comparison
            userInput = userInput.ToLower();

            // Exit condition
            if (userInput == "exit")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Bot: Goodbye! Stay safe online.");
                Console.ResetColor();
                break;
            }

            // Get chatbot response
            string response = GetResponse(userInput);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Bot: " + response);
            Console.ResetColor();
            Console.WriteLine();
        }
    }

    // This method displays the ASCII art logo/header
    static void DisplayAsciiArt()
    {
     // Display decorative chatbot banner
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("====================================================");
        Console.WriteLine("   _____       _                ____        _      ");
        Console.WriteLine("  / ____|     | |              |  _ \\      | |     ");
        Console.WriteLine(" | |    _   _ | |__    ___ _ __| |_) | ___ | |_    ");
        Console.WriteLine(" | |   | | | || '_ \\  / _ \\ '__|  _ < / _ \\| __|   ");
        Console.WriteLine(" | |___| |_| || |_) ||  __/ |  | |_) | (_) | |_    ");
        Console.WriteLine("  \\_____\\__, ||_.__/  \\___|_|  |____/ \\___/ \\__|   ");
        Console.WriteLine("         __/ |                                      ");
        Console.WriteLine("        |___/   CYBERSECURITY AWARENESS BOT         ");
        Console.WriteLine("====================================================\n");
        Console.ResetColor();
    }

    // This method returns chatbot responses based on user input
    static string GetResponse(string input)
    {
        if (input.Contains("how are you"))
        {
            return "I'm doing well, thank you. I'm here and ready to help you stay safe online.";
        }
        else if (input.Contains("purpose") || input.Contains("what do you do"))
        {
            return "My purpose is to educate users about cybersecurity and help them stay safe online.";
        }
        else if (input.Contains("what can i ask") || input.Contains("help"))
        {
            return "You can ask me about password safety, phishing, safe browsing, and my purpose.";
        }
        else if (input.Contains("password"))
        {
            return "Use strong passwords with uppercase letters, lowercase letters, numbers, and symbols. Avoid using personal information and never share your password.";
        }
        else if (input.Contains("phishing"))
        {
            return "Phishing is a scam where criminals trick you into giving away personal information. Be careful of suspicious emails, fake websites, and unknown links.";
        }
        else if (input.Contains("browsing") || input.Contains("safe browsing"))
        {
            return "Always check if a website uses https, avoid clicking suspicious links, and do not download files from untrusted websites.";
        }
        else
        {
            return "I didn’t quite understand that. Could you rephrase?";
        }
    }
}