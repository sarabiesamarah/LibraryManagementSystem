namespace LibraryManagementSystem
{

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Item> library = new List<Item>();

        try
        {
            // Adding a valid book
            Book book = new Book
            {
                Title = "C# Programming",
                Publisher = "Tech Publishers",
                PublicationYear = 2022,
                Author = "John Doe"
            };
            library.Add(book);

            // Adding a valid magazine
            Magazine magazine = new Magazine
            {
                Title = "Tech Today",
                Publisher = "Tech Magazines Inc.",
                PublicationYear = 2023,
                IssueNumber = 45
            };
            library.Add(magazine);

            // Attempting to add an invalid book (to trigger exception)
            Book invalidBook = new Book
            {
                Title = "",
                Publisher = "Unknown",
                PublicationYear = 2025,
                Author = "Jane Smith"
            };
            library.Add(invalidBook);
        }
        catch (InvalidItemDataException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected Error: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("\nLibrary processing completed.");
        }

        // Display all items in the library
        Console.WriteLine("\nLibrary Items:");
        foreach (var item in library)
        {
            item.DisplayInfo();
            Console.WriteLine();
        }
    }
}
}