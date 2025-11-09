# LOVE CONSOLE APPLICATION

## DESCRIPTION

A interactive console application designed as a romantic gift, featuring a personalized quiz, message gallery, and love notes.

## FEATURES

### INTERACTIVE QUIZ

- Multiple-choice questions about your relationship
- Scoring system based on answer selection
- Input validation for smooth user experience

### MESSAGE GALLERY

- Collection of memorable messages and moments
- Sequential display with navigation
- Romantic and funny memories

### LOVE NOTES

- Personal love letters and dedications
- Heartfelt messages and expressions
- Customizable content

## TECHNICAL SPECIFICATIONS

- **Platform**: .NET Console Application
- **Language**: C#
- **Architecture**: Modular class-based design
- **Dependencies**: Standard .NET libraries

## PROJECT STRUCTURE

```text
LoveQuiz/
├── CommandsManager.cs      # Main menu and command handler
├── QuizHelper.cs           # Quiz logic and questions
├── GalleryHelper.cs        # Message gallery management
├── ConsolePersonalizer.cs  # Console formatting utilities
└── Parameters.cs           # Application constants and emojis
```

## USAGE

1. **Run the application**

   ```bash
   dotnet run
   ```

2. **Select from the main menu:**
   - `[1]` Take the interactive quiz
   - `[2]` Browse the message gallery
   - `[3]` Read love note
   - `[4]` Exit application

3. **Follow on-screen instructions for each feature**

## CUSTOMIZATION

To personalize this application for your relationship:

- Edit `QuizHelper.cs` to add your own questions
- Modify `GalleryHelper.cs` with your special messages
- Update the love note in `CommandsManager.cs`
- Adjust `Parameters.cs` for custom emojis and constants

## BUILD INSTRUCTIONS

1. Ensure .NET SDK is installed
2. Navigate to project directory
3. Run: `dotnet build`
4. Run: `dotnet run`

## CLASS OVERVIEW

- **CommandsManager**: Orchestrates application flow and menu navigation
- **QuizHelper**: Manages quiz questions, scoring, and validation
- **GalleryHelper**: Handles message storage and display
- **ConsolePersonalizer**: Provides colored console output utilities

## IMPORTANT

This application is designed as a romantic gesture and should be customized with personal content to make it special for your loved one.
