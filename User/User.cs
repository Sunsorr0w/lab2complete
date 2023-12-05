class User
{
    // Properties for user information
    public string Login { get; private set; }
    public string Name { get; private set; }
    public string Surname { get; private set; }
    public int Age { get; private set; }
    public DateTime RegistrationDate { get; }

    // Constructor to initialize user information
    public User(string login, string name, string surname, int age)
    {
        Login = login;
        Name = name;
        Surname = surname;
        Age = age;
        RegistrationDate = DateTime.Now; // Initialize registration date only once
    }

    // Method to display user information
    public void DisplayUserInfo()
    {
        Console.WriteLine("User Information:");
        Console.WriteLine($"Login: {Login}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Surname: {Surname}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Registration Date: {RegistrationDate}");
    }
}
