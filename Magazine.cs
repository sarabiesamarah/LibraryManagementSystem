namespace LibraryManagementSystem
{

using System;

public class Magazine : Item
{
    private int _issueNumber;

    public int IssueNumber
    {
        get { return _issueNumber; }
        set
        {
            if (value <= 0)
                throw new InvalidItemDataException("Issue number must be greater than zero.");
            _issueNumber = value;
        }
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Issue Number: {IssueNumber}");
    }
}
}