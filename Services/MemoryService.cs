using System.Collections.Generic;

namespace CyberSecurityChatbotGUI.Services
{
    internal class MemoryService
    {
        private readonly Dictionary<string, string> userMemory = new Dictionary<string, string>();

        public void SaveMemory(string key, string value)
        {
            if (userMemory.ContainsKey(key))
            {
                userMemory[key] = value;
            }
            else
            {
                userMemory.Add(key, value);
            }
        }

        public string GetMemory(string key)
        {
            if (userMemory.ContainsKey(key))
            {
                return userMemory[key];
            }

            return null;
        }
    }
}