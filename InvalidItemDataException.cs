namespace LibraryManagementSystem {

using System;

public class InvalidItemDataException : Exception
{
    public InvalidItemDataException(string message) : base(message)
    {
    }
}
}