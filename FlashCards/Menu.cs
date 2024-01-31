namespace FlashCards;

public class Menu
{
    internal static void MenuSelector()
    {
        Console.Clear();

        Console.WriteLine("Welcome to my Flashcards Application!" +
                          "Choose one of the following: " +
                          "\n1. Add a new Flashcard." +
                          "\n2. Edit an existing Flashcard." +
                          "\n3. Delete an existing Flashcard" +
                          "\n4. View all Flashcards." +
                          "\n5. Press 0 to exit the program.");

        bool appState = true;

        while (appState)
        {
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "0":
                {
                    Console.WriteLine("Sayonara!");
                    appState = false;
                    Environment.Exit(0);
                    break;
                }
                case "1":
                {
                    //add();
                    break;
                }
                case "2":
                {
                    //edit()
                    break;
                }
                case "3":
                {
                    //delete()
                    break;
                }
                case "4":
                {
                    //view()
                    break;
                }
                default:
                {
                    Console.WriteLine("Invalid Choice Entered");
                    break;
                }
            }
        }
    }
}