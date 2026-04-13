# CyberSecurityChatbot

## Overview
CyberSecurityChatbot is a C# console application created for Part 1 of the PROG6221 POE.  
The chatbot helps users learn about basic cybersecurity topics such as password safety, phishing, and safe browsing.
This project was developed using Visual Studio and C# as a console-based chatbot application.

## Features
- Voice greeting using a WAV audio file
- ASCII art title screen
- Personalised greeting using the user's name
- Basic chatbot responses to cybersecurity-related questions
- Input validation for empty or unsupported input
- Coloured console interface for better user experience

## Cybersecurity Topics Covered
- Password safety
- Phishing
- Safe browsing
- Chatbot purpose/help

## Requirements
- Visual Studio 2022
- .NET 10.0
- Windows operating system
- `greeting.wav` audio file included in the project

## How to Run the Program
1. Open the project in Visual Studio.
2. Make sure the `greeting.wav` file is included in the project.
3. Ensure the file property **Copy to Output Directory** is set to **Copy if newer**.
4. Press `F5` or click the green Run button.
5. The chatbot will play the voice greeting, display the ASCII art, and start the conversation.

## How to Use the Chatbot
You can type questions such as:
- `How are you?`
- `What is your purpose?`
- `What can I ask you about?`
- `Tell me about password safety`
- `What is phishing?`
- `Tell me about safe browsing`

Type `exit` to close the chatbot.

## Project Structure
- `Program.cs` - Main chatbot logic
- `greeting.wav` - Voice greeting audio file
- `README.md` - Project documentation

## GitHub
This project is version controlled using GitHub with meaningful commits.

## Continuous Integration (CI)
GitHub Actions is used to build the project automatically on each push.

## Author
Kelebogile FrankLebese
ST10486796