// See https://aka.ms/new-console-template for more information

public class UserInterface
{
    private string _username;
    private string _password;

    private void GetData()
    {
        Console.WriteLine("Enter your username: ");
        _username = Console.ReadLine();
        Console.WriteLine("Enter your password: ");
        _password = Console.ReadLine();
    }

    //sign up
    public void SignUp()
    {
        GetData();
        Business business = new Business();
        business.SignUp(_username, _password);
    }
}

public interface IBusiness
{
    void SignUp(string username, string password);
}

public class Business : IBusiness
{
    public void SignUp(string username, string password)
    {
        DataAccess dataAccess = new DataAccess();
        dataAccess.SignUp(username, password);
    }
}

public class DataAccess
{

    public void SignUp(string username, string password)
    {
        Console.WriteLine("User signed up successfully");
    }
}