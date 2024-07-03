using System;

bool loggingIn = true;
//variable for exiting code
Console.WriteLine("Welcome\n");
while (loggingIn)
//while loop for keeping user in the loop until they get the login details right
{
    
    Console.WriteLine("Enter corect username\n");
    Console.WriteLine("Or press 'x' to exit\n");
    string username = Console.ReadLine();
    string lowerCaseUsername = username.ToLower();
    //converts username to lower case
    //to ensure consistency since usernames are usually not case sensitive while passwords are


    if (lowerCaseUsername == "admin")
    {
        Console.Clear();
        Console.WriteLine("\nHello Admin\n");
        Console.WriteLine("\nPlease enter your password\n");
        //in this part user gets the correct username so is prompted for password
        string password = Console.ReadLine();
        if (password == "Admin123@")
        {
          
            break;
            //if password is correct break out of loop
        }
        else
        {
            Console.Clear();
            Console.WriteLine("\nWrong password try again\n");
            //wrong password prompts user to try again from beginning
        }
    }
    else if (username == "x")
    {
        loggingIn = false;
        //breaks from the loop since user wants to exit
        
    }
    else
    {
        Console.Clear();
        Console.WriteLine("\nWrong username\n");
        //user gets wring username and gets to try again
    }
        
}
  
if (loggingIn == false)
{
    Console.Clear();
    Console.WriteLine("\nThank you\n");
    Console.WriteLine("\nHope to see you again\n");
    //if user presses x 
}
else
{
    //if user gets login details right console is cleared and they "enter their account"
    Console.Clear();
    Console.WriteLine("Welcome Admin!\n");
    Console.WriteLine("\nProfile");
    Console.WriteLine("\nDashboard");
    Console.WriteLine("\nSign out");
}


