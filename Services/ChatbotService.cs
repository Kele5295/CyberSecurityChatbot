using CyberSecurityChatbotGUI.Data;

namespace CyberSecurityChatbotGUI.Services
{
    internal class ChatbotService
    {
        private readonly ResponseRepository responseRepository;
        private readonly MemoryService memoryService;
        private readonly SentimentService sentimentService;

        public ChatbotService()
        {
            responseRepository = new ResponseRepository();
            memoryService = new MemoryService();
            sentimentService = new SentimentService();
        }

        public string GetResponse(string userInput)
        {
            if (string.IsNullOrWhiteSpace(userInput))
            {
                return "Please enter a question or message.";
            }

            string sentiment = sentimentService.DetectSentiment(userInput);

            string topic = responseRepository.GetDetectedTopic(userInput);

            if (!string.IsNullOrEmpty(topic))
            {
                memoryService.SaveMemory("LastTopic", topic);
            }

            string response = responseRepository.GetResponse(userInput);

            if (topic != null)
            {
                response += $"\n\nTopic detected: {topic}";
            }

            return response;
        }

        public string GetSentimentMessage(string userInput)
        {
            string sentiment = sentimentService.DetectSentiment(userInput);
            return sentimentService.GetSentimentResponse(sentiment);
        }
    }
}