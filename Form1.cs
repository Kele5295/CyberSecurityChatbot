using System;
using System.Windows.Forms;
using CyberSecurityChatbotGUI.Services;

namespace CyberSecurityChatbotGUI
{
    public partial class Form1 : Form
    {
        private readonly ChatbotService chatbotService = new ChatbotService();

        public Form1()
        {
            InitializeComponent();

            rtbChat.AppendText("Bot: Welcome to the Cybersecurity Awareness Chatbot!\n");
            rtbChat.AppendText("Bot: Ask me about passwords, phishing, privacy, scams, malware, or safe browsing.\n\n");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string userInput = txtUserInput.Text.Trim();

            rtbChat.AppendText("You: " + userInput + "\n");

            string sentimentMessage = chatbotService.GetSentimentMessage(userInput);
            string botResponse = chatbotService.GetResponse(userInput);

            rtbChat.AppendText("Bot: " + sentimentMessage + "\n");
            rtbChat.AppendText("Bot: " + botResponse + "\n\n");

            txtUserInput.Clear();
            txtUserInput.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbChat.Clear();
            rtbChat.AppendText("Bot: Chat cleared. How can I help you stay safe online?\n\n");
        }
    }
}