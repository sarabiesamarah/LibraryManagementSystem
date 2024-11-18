namespace LibraryManagementSystem
{

using System;

public class Book : Item
{
    private string _author = string.Empty;

    public string Author
    {
        get { return _author; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new InvalidItemDataException("Author cannot be empty.");
            _author = value;
        }
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Author: {Author}");
    }
}
}