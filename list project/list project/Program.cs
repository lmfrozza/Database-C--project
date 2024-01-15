using System;

class Program
{
    private string[] AgeArray = new string[5];
    private string[] NameArray = new string[5];
    private string[] CPFArray = new string[5];
    private string[] JobArray = new string[5];

    static void Main()
    {
        Program programa = new Program();
        programa.Run();
    }

    void Run()
    {
        Console.WriteLine("Welcome to this DataBase!");
        Console.WriteLine("https://github.com/lmfrozza to access README file");

        while (true)
        {
            Console.WriteLine("=== Menu ===");
            Console.WriteLine("1- Input Data");
            Console.WriteLine("2- Search Data");
            Console.WriteLine("3- Close");

            string menu = Console.ReadLine();

            if (menu == "1")
            {
                InputData();
            }
            else if (menu == "2")
            {
                SearchData();
            }
            else if (menu == "3")
            {
                Console.WriteLine("Bye Bye!");
                break;  // Sai do loop e encerra o programa
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        }
    }

    void InputData()
    {
        for (int q = 0; q < NameArray.Length; q++)
        {
            Console.WriteLine($"{q + 1}° Slot: ");
            Console.Write($"Name: ");
            NameArray[q] = Console.ReadLine();
            Console.Write($"Age: ");
            AgeArray[q] = Console.ReadLine();
            Console.Write($"CPF: ");
            CPFArray[q] = Console.ReadLine();
            Console.Write($"Job: ");
            JobArray[q] = Console.ReadLine();
            
        }
    }

    void SearchData()
    {
        Console.Write("Search the word you're looking for! ");
        string search = Console.ReadLine();
        bool found = false;

        for (int q = 0; q < NameArray.Length; q++)
        {
            if (NameArray[q] == search)
            {
                Console.WriteLine($"A result for {search} has been found in the {q + 1}° slot");
                found = true;
                Console.WriteLine($"Name: {NameArray[q]}");
                Console.WriteLine($"Age: {AgeArray[q]}");
                Console.WriteLine($"CPF: {CPFArray[q]}");
                Console.WriteLine($"Job: {JobArray[q]}");
                //break;  // Sai do loop assim que encontrar uma correspondência
            }
        }

        if (!found)
        {
            Console.WriteLine($"No results for: {search}");
        }
    }
}
