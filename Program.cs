using System;
using System.Collections.Generic;
using UserRegistationWithLambdaExpression;

namespace UserRegistrationUsingLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Welcome To User Registration With Lambda Expression------");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Press 0 For Exit");
            Console.WriteLine("1.Check User FirstName");
            Console.WriteLine("2.Check User LastName");
            Console.WriteLine("3.Check User Valid Email");
            Console.WriteLine("4.Check User Name With Country Code");
            Console.WriteLine("5.Enter The Password For Minimum 8 Characters");
            Console.WriteLine("6.Enter The Password For Should Have Atleast 1 UpperCase ");
            Console.WriteLine("7.Enter The Password For Should Have Atleast 1 Numeric Number ");
            Console.WriteLine("8.Enter The Password For Should Have Atleast 1 Special Character ");
            Console.WriteLine("9.Enter A Valid Email Address E.g.- abc@yahoo.com ");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    UserFirstName user = new UserFirstName();
                    Console.WriteLine("User Registration");
                    Console.WriteLine("Enter Firstname");
                    string Firstname = Console.ReadLine();
                    string opt = user.FirstnameCheckusingLambda(Firstname);
                    if (opt == "FirstName is Valid")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(opt);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(opt);
                        Console.ResetColor();
                    }
                    break;
                case 2:
                    UserLastName userlast = new UserLastName();
                    Console.WriteLine("User Registration");
                    Console.WriteLine("Enter Lastname");
                    string Lastname = Console.ReadLine();
                    string opt1 = userlast.LastnameCheckusingLambda(Lastname);
                    if (opt1 == "LastName is Valid")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(opt1);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(opt1);
                        Console.ResetColor();
                    }
                    break;

                case 3:
                    UserValidEmail email = new UserValidEmail();
                    Console.WriteLine("User Registration");
                    Console.WriteLine("Enter Email");
                    string Email = Console.ReadLine();
                    string opt2 = email.ValidEmailCheckusingLambda(Email);
                    if (opt2 == "Email is Valid")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(opt2);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(opt2);
                        Console.ResetColor();
                    }
                    break;
                case 4:
                    UserMobileNumber mobileNumber = new UserMobileNumber();
                    Console.WriteLine("User Registration");
                    Console.WriteLine("Enter Mobile Number");
                    string Mobile = (Console.ReadLine());
                    string opt3 = mobileNumber.ValidMobilenumberCheckusingLambda(Mobile);
                    if (opt3 == "Mobile Number is Valid")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(opt3);
                        Console.ResetColor();

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(opt3);
                        Console.ResetColor();
                    }
                    break;
                case 5:
                    UserPasswordRule1 rule1 = new UserPasswordRule1();
                    Console.WriteLine("User Registration");
                    Console.WriteLine("Enter Password");
                    string UserPass1 = (Console.ReadLine());
                    string opt4 = rule1.ValidPasswordCheckusingLambda(UserPass1);
                    if (opt4 == "Password is Valid")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(opt4);
                        Console.ResetColor();

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(opt4);
                        Console.ResetColor();
                    }
                    break;
                case 6:
                    UserPasswordRule2 rule2 = new UserPasswordRule2();
                    Console.WriteLine("User Registration");
                    Console.WriteLine("Enter Password");
                    string UserPass2 = (Console.ReadLine());
                    string opt5 = rule2.ValidPasswordCheckusingLambda(UserPass2);
                    if (opt5 == "Enter Valid Password")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(opt5);
                        Console.ResetColor();

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(opt5);
                        Console.ResetColor();
                    }
                    break;
                case 7:
                    UserPasswordRule3 rule3 = new UserPasswordRule3();
                    Console.WriteLine("User Registration");
                    Console.WriteLine("Enter Password");
                    string UserPass3 = (Console.ReadLine());
                    string opt6 = rule3.ValidPasswordCheckusingLambda(UserPass3);
                    if (opt6 == "Enter Valid Password")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(opt6);
                        Console.ResetColor();

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(opt6);
                        Console.ResetColor();
                    }
                    break;
                case 8:
                    UserPasswordRule4 rule4 = new UserPasswordRule4();
                    Console.WriteLine("User Registration");
                    Console.WriteLine("Enter Password");
                    string UserPass4 = (Console.ReadLine());
                    string opt7 = rule4.ValidPasswordCheckusingLambda(UserPass4);
                    if (opt7 == "Enter Valid Password")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(opt7);
                        Console.ResetColor();

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(opt7);
                        Console.ResetColor();
                    }
                    break;
                case 9:
                    UserValidEmailId emailid = new UserValidEmailId();
                    Console.WriteLine("User Registration");
                    Console.WriteLine("Enter Email");
                    string EmailId = Console.ReadLine();
                    string opt8 = emailid.ValidEmailCheckusingLambda(EmailId);
                    if (opt8 == "Email is Valid")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(opt8);
                        Console.ResetColor();

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(opt8);
                        Console.ResetColor();
                    }
                    break;
            }
        }
    }
}