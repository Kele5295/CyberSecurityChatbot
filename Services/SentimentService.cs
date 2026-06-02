using System;

namespace CyberSecurityChatbotGUI.Services
{
    internal class SentimentService
    {
        public string DetectSentiment(string input)
        {
            input = input.ToLower();

            if (input.Contains("worried") ||
                input.Contains("scared") ||
                input.Contains("afraid") ||
                input.Contains("nervous"))
            {
                return "negative";
            }

            if (input.Contains("happy") ||
                input.Contains("great") ||
                input.Contains("good") ||
                input.Contains("excited"))
            {
                return "positive";
            }

            return "neutral";
        }

        public string GetSentimentResponse(string sentiment)
        {
            switch (sentiment)
            {
                case "negative":
                    return "I understand your concern. Let me help you stay safe online.";

                case "positive":
                    return "That's great to hear! Let's continue improving your cybersecurity awareness.";

                default:
                    return "Thank you for sharing. How can I help you with cybersecurity today?";
            }
        }
    }
}