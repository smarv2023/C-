using System.Text.Json;

namespace FileStreamHandling2
{
    internal class Control
    {
        static string? inputReader;
        static string directoryPath = @"D:\tempMarvinSoro\";
        static string? fileName;

        // JSON Serialization
        // BinaryFormatter bf = new BinaryFormatter();   //deprecated
        public static void SerializeFile(List<Person> people)
        {
            do
            {
                Console.Write("Enter file name:");
                inputReader = Console.ReadLine();
                if (inputReader != null)
                    fileName = inputReader.Trim();
            } while (fileName == "");

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            directoryPath = directoryPath + $"{fileName}.json";

            string js = JsonSerializer.Serialize(people);
            Console.WriteLine("Serialized Version of List object to JSON");
            Console.WriteLine(js);
            // Serialize the object to a memory stream
            using (StreamWriter writer = new StreamWriter(directoryPath))
            {
                writer.Write(js);
            }
            Console.Write("File Serialize");
        }

        public static List<Person>? DeserializeFile()
        {
            string jsonString = File.ReadAllText(directoryPath);
            return JsonSerializer.Deserialize<List<Person>>(jsonString);
        }

    }
}
