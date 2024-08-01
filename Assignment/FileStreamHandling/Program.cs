using FileStreamHandling;
using System.Runtime.Serialization;

static void SectionTitle(string title)
{
    ConsoleColor previousColor = ForegroundColor;
    ForegroundColor = ConsoleColor.Yellow;
    WriteLine("*");
    WriteLine($"* {title}");
    WriteLine("*");
    ForegroundColor = previousColor;
}
SectionTitle("File Handling Assignment\n* Sample Text\n* Ecouragement Poem");

string writeText = "When shadows fall and hopes grow dim," +
    "\nRemember dawn will come again." +
    "\nWhen burdens weigh upon your heart," +
    "\nStay strong, don't let your dreams depart." +
    "\n" +
    "\nWhen doubts and fears cloud up your mind," +
    "\nLook within, courage you'll find.\r" +
    "\nWhen roads are rough and bends are steep," +
    "\nKeep moving forward, don't retreat." +
    "\n" +
    "\nFailures may come, tears may fall," +
    "\nBut stand tall, and give your all." +
    "\nNever give up, let your heart lead," +
    "\nFor strength within is all you need.";

Write(writeText);

WriteLine();
try
{
    ForegroundColor = ConsoleColor.Blue;
    WriteLine("\nSave File");
    Control.SaveFile(writeText);

    ForegroundColor = ConsoleColor.Green;
    WriteLine("\nOpening File");
    Control.OpenFile();

    ForegroundColor = ConsoleColor.Red;
    WriteLine("\nDelete File");
    Control.DeleteFile();
    ReadLine();

}
catch (UnauthorizedAccessException ex)
{ 
    WriteLine(ex.Message);
}
catch (SerializationException ex)
{
    WriteLine(ex.Message);
}
catch (Exception ex)
{
    WriteLine("An error occurred while writing to the file.");
    WriteLine($"Exception Message: {ex.Message}");
}

ReadLine();
