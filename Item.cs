namespace LibraryManagementSystem
{

using System;

public class Item
{
   private string _title = string.Empty;
    private string _publisher = string.Empty;
    private int _publicationYear;

    public string Title
    {
        get { return _title; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new InvalidItemDataException("Title cannot be empty.");
            _title = value;
        }
    }

    public string Publisher
    {
        get { return _publisher; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new InvalidItemDataException("Publisher cannot be empty.");
            _publisher = value;
        }
    }

    public int PublicationYear
    {
        get { return _publicationYear; }
        set
        {
            if (value < 0 || value > DateTime.Now.Year)
                throw new InvalidItemDataException("Publication year is invalid.");
            _publicationYear = value;
        }
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}, Publisher: {Publisher}, Year: {PublicationYear}");
    }
}
}