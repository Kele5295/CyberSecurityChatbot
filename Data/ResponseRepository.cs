using System;
using System.Collections.Generic;
using System.Linq;

namespace CyberSecurityChatbotGUI.Data
{
    internal class ResponseRepository
    {
        private readonly Random random = new Random();

        private readonly Dictionary<string, List<string>> responses = new Dictionary<string, List<string>>
        {
            { "password", new List<string>
                {
                    "Use strong passwords with uppercase letters, lowercase letters, numbers and symbols.",
                    "Avoid using the same password on many accounts. A password manager can help.",
                    "Never share your password with anyone, even if the message looks official."
                }
            },
            { "phishing", new List<string>
                {
                    "Phishing messages often create panic. Always check the sender and avoid clicking suspicious links.",
                    "If an email asks for your password or banking details, treat it as suspicious.",
                    "Report phishing emails instead of replying to them."
                }
            },
            { "privacy", new List<string>
                {
                    "Review your privacy settings on social media and limit what strangers can see.",
                    "Avoid sharing personal details like your ID number, address or banking information online.",
                    "Use two-factor authentication to protect private accounts."
                }
            },
            { "scam", new List<string>
                {
                    "Scams often promise quick money or urgent action. Pause and verify before responding.",
                    "Do not send money or personal details to someone you only met online.",
                    "If an offer sounds too good to be true, it is probably a scam."
                }
            },
            { "malware", new List<string>
                {
                    "Malware can come from unsafe downloads, fake apps or infected links.",
                    "Keep your antivirus and operating system updated.",
                    "Avoid downloading files from unknown websites."
                }
            },
            { "browsing", new List<string>
                {
                    "Only enter personal information on secure websites that use HTTPS.",
                    "Avoid clicking pop-up adverts or unknown download buttons.",
                    "Be careful when using public Wi-Fi for banking or private accounts."
                }
            }
        };

        public string GetResponse(string userInput)
        {
            string input = userInput.ToLower();

            foreach (var topic in responses.Keys)
            {
                if (input.Contains(topic))
                {
                    List<string> topicResponses = responses[topic];
                    return topicResponses[random.Next(topicResponses.Count)];
                }
            }

            return "I'm not sure I understand. Can you try rephrasing or ask about password safety, phishing, privacy, scams, malware or safe browsing?";
        }

        public string GetDetectedTopic(string userInput)
        {
            string input = userInput.ToLower();

            return responses.Keys.FirstOrDefault(topic => input.Contains(topic));
        }
    }
}