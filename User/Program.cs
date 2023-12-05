using System;

class Program
{
    static void Main()
    {
        // Creating an instance of the User class
        User user = new User("john_doe", "John", "Doe", 25);

        // Displaying user information
        user.DisplayUserInfo();

        Console.ReadLine(); // Pause to see the output
    }
}

