namespace FileStreamHandling;

public static class Control
{
    static string? inputReader;
    static string directoryPath = @"D:\tempMarvinSoro\";
    static string? fileName;

    // Open file
    public static void OpenFile()
    {
        string fileContent = File.ReadAllText(directoryPath);
        WriteLine(fileContent);
        WriteLine(directoryPath + " Open");
    }

    // Save file
    public static void SaveFile(string data)
    {
        do
        {
            Write("Enter file name:");
            inputReader = ReadLine();
            if (inputReader != null)
                fileName = inputReader.Trim();
        } while (fileName == "");

        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }
        directoryPath = directoryPath + $"{fileName}.txt";

        using (StreamWriter write = new StreamWriter(directoryPath))
        {
            write.Write(data);
        }
        WriteLine(directoryPath + " Saved");
    }

    // Delete file
    public static void DeleteFile()
    {
        File.Delete(directoryPath);
        WriteLine(directoryPath + " Deleted");
    }
}
