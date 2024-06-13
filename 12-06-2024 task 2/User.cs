using _12_06_2024_task_2;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;



public class User : Account
{
    private static int userIdCounter = 1;
    private readonly int id;
    public string Fullname { get; set; }
    public string Email { get; set; }
    public string Password { get; private set; }

    public User(string fullname, string email, string password)
    {
        this.id = userIdCounter++;
        this.Fullname = fullname;
        this.Email = email;
        if (PasswordChecker(password))
        {
            this.Password = password;
        }
        else
        {
            throw new ArgumentException("Password does not meet the requirements");
        }
    }

    public int Id => id;

    public override bool PasswordChecker(string password)
    {
        if (password.Length < 8)
        {
            return false;
        }

        bool hasUpperCase = false;
        bool hasLowerCase = false;
        bool hasDigit = false;

        foreach (char c in password)
        {
            if (char.IsUpper(c)) hasUpperCase = true;
            if (char.IsLower(c)) hasLowerCase = true;
            if (char.IsDigit(c)) hasDigit = true;

            if (hasUpperCase && hasLowerCase && hasDigit)
                return true;
        }

        return false;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"ID: {Id}, Fullname: {Fullname}, Email: {Email}");
    }
}