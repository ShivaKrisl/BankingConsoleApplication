using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            UserNameNotEntered:
            Console.WriteLine("*************BANKING CONSOLE APPLICATION*************");
            Console.WriteLine("::LOGIN PAGE::");


            string userName = null,password = null;
            Console.WriteLine("Enter UserName:");
            userName = Console.ReadLine();
            if (userName != "")
            {
                Console.WriteLine("Enter Password:");
                password = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please Enter your Credentias to Login");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
                goto UserNameNotEntered;
            }

            if (userName == "system" && password == "manager")
            {
                int choice = -1;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Welcome {0}", userName);
                    Console.Clear();
                    Console.WriteLine(":::MAIN MENU:::");
                    Console.WriteLine("1. Customers");
                    Console.WriteLine("2. Accounts");
                    Console.WriteLine("3. Funds Transfer");
                    Console.WriteLine("4. Funds Transfer Statement");
                    Console.WriteLine("5. Account Statement");
                    Console.WriteLine("6. Exit");
                    Console.Write("Enter your choice = ");
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            CustomerOperations();
                            break;
                        case 2:
                            AccountsOperation();
                            break;
                        case 3:
                            Console.WriteLine("Funds Transfer");
                            break;
                        case 4:
                            Console.WriteLine("Funds Transfer Statement");
                            break;
                        case 5:
                            Console.WriteLine("Account Statement");
                            break;
                        case 6:
                            Console.WriteLine("Exit");
                            break;
                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                } while(choice != 6);
                
            
            }
            else
            {
                Console.WriteLine("Invalid Credentials");
                
            }

            Console.WriteLine("Thank you for using our application");
        }

        internal static void CustomerOperations()
        {
            int choice = 0;
            do
            {
                Console.Clear();
                Console.WriteLine(":::CUSTOMER OPERATIONS:::");
                Console.WriteLine("1. Add Customer");
                Console.WriteLine("2. Update Customer");
                Console.WriteLine("3. Delete Customer");
                Console.WriteLine("4. Search Customer");
                Console.WriteLine("5. List Customers");
                Console.WriteLine("6. Return to Main Menu");
                Console.Write("Enter your choice = ");

                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Add Customer");
                        break;
                    case 2:
                        Console.WriteLine("Update Customer");
                        break;
                    case 3:
                        Console.WriteLine("Delete Customer");
                        break;
                    case 4:
                        Console.WriteLine("Search Customer");
                        break;
                    case 5:
                        Console.WriteLine("List Customers");
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Invalid Choice");
                        Main(null);
                        break;
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            } while(choice != 6);
            
        }

        internal static void AccountsOperation()
        {
            int choice = 0;
            do
            {
                Console.Clear();
                Console.WriteLine(":::ACCOUNTS OPERATIONS:::");
                Console.WriteLine("1. Add Account");
                Console.WriteLine("2. Update Account");
                Console.WriteLine("3. Delete Account");
                Console.WriteLine("4. Search Account");
                Console.WriteLine("5. List Accounts");
                Console.WriteLine("6. Return to Main Menu");
                Console.Write("Enter your choice = ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Add Account");
                        break;
                    case 2:
                        Console.WriteLine("Update Account");
                        break;
                    case 3:
                        Console.WriteLine("Delete Account");
                        break;
                    case 4:
                        Console.WriteLine("Search Account");
                        break;
                    case 5:
                        Console.WriteLine("List Accounts");
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Invalid Choice");
                        Main(null);
                        break;
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            } while(choice!=6)
;            
        }
    }
}
