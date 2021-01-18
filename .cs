using System;
using static System.Console;

namespace _
{
    class _
    {
        static void Main()
        {            
            var arrUsers = new Users[]
            {
            new Users("D","E",1),
            new Users("N","I",2),
            new Users("S","Rafi",3)
            };
        Start:
            WriteLine("login (1) | Register (2)");
            var input =ReadLine();
            bool successfull = false;
            while (!successfull)
            {
                if (input == "1")
                {
                    Write("Username:");
                    var username =ReadLine();
                    Write("Password:");
                    var password = ReadLine();

                    foreach (Users user in arrUsers)
                    {
                        if (username == user.username && password == user.password)
                        {
                            Write("Login Successful");
                            ReadLine();
                            successfull = true;
                            break;
                        }
                    }
                    if (!successfull)
                    {
                        Write("Error The Username or Password you Entered is Incorrect.");
                    }
                }
                else if (input == "2")
                {
                    Write("Username:");
                    var username = ReadLine();
                    Write("Password:");
                    var password =ReadLine();
                    Write("Id:");
                    int id = int.Parse(ReadLine());
                    Array.Resize(ref arrUsers, arrUsers.Length + 1);
                    arrUsers[arrUsers.Length - 1] = new Users(username, password, id);
                    successfull = true;
                    goto Start;
                }              
            }
        }
    }
    public class Users
    {
        public string username;
        public string password;
        private readonly int id;
        public Users(string username, string password, int id)
        {
            this.username = username;
            this.password = password;
            this.id = id;
        }
    }
}
