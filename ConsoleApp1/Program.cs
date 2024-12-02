using Microsoft.Win32.SafeHandles;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

class Program
{
   static void Main()
    {

        //smallBNB sBnb1 = new smallBNB("Mowinski Residence", 30000, ow1.name, "london");
        //Console.WriteLine(sBnb1.displayPropertyInformation());
        //sBnb1.reserveBnb("Anna Czochara");
        //Console.WriteLine("    ");
        //Console.WriteLine(sBnb1.displayPropertyInformation());
        //Console.WriteLine(sBnb1.setPrice(10000));
        //Console.WriteLine(sBnb1.getOwnerName());
        //Console.WriteLine(sBnb1.unreserve());
        //Console.WriteLine("    ");
        //Console.WriteLine(sBnb1.displayPropertyInformation());
        //Console.WriteLine("     ");

        //instanciating owner and customer
      
        Bnb bnb = Bnb.getInstance();
        List<Owner> owners = new List<Owner>();
        List<Customer> customers = new List<Customer>();

        Owner ow3 = new Owner("krystian", "Mowinski", 19, "London", 40000);
        Customer cus3 = new Customer("Anna", "Czochara", 20, "Przemysl", 80000);
        Owner ow4 = new Owner("Szymon", "Mickiewicz", 20, "London", 21000);
        Customer cus4 = new Customer("Gregory", "House", 46, "New York", 45000);
        customers.Add(cus3);
        owners.Add(ow3);
        owners.Add(ow4);
        customers.Add(cus4);
        //Owner ow1 = new Owner("krystian", "Mowinski", 19, "London", 40000);
        //Customer cus1 = new Customer("Anna", "Czochara", 20, "Przemysl", 80000);
        //smallBNB sBnb1 = new smallBNB("Mowinski Residence", 30000, ow1.fullName, "london");
        //List<IBnb> bnbs = new List<IBnb>();
        //bnbs.Add(sBnb1);
        //calling methods from owner and customer for the 2 instanciated classes 
        //Console.WriteLine(ow1.printName());
        //Console.WriteLine(ow1.getOwnerDetails());
        //Console.WriteLine(cus1.printName());
        //Console.WriteLine(cus1.getCustomerDetails());
        //Console.WriteLine("    ");

        //creating a new small bnb with the name from a class 
        //was testing so that i can later use it when we will be creating IBNBFACTORY

        //displaying information of property and printing it
        //Console.WriteLine(sBnb1.displayPropertyInformation());
        //reserving using 
        //sBnb1.reserveBnb(cus1.fullName);
        //Console.WriteLine("    ");
        //Console.WriteLine(sBnb1.displayPropertyInformation());
        //Console.WriteLine(sBnb1.setPrice(10000));
        //Console.WriteLine(sBnb1.getOwnerName());
        //Console.WriteLine(sBnb1.unreserve());
        //Console.WriteLine("    ");
        //Console.WriteLine(sBnb1.displayPropertyInformation());
        //Console.WriteLine("     ");
        //IBnbBuilder bb = new bigBuilder();
        //BnbDirector bd = new BnbDirector(bb);
        //List<string> bnb = bd.makeBigBnb();
        //Console.WriteLine("the big bnb has....");
        //foreach(string feature in bnb)
        //{
        //    Console.WriteLine($"{feature}");
        //}
        while (true)
        { 
            Console.WriteLine("===================MENU=================");
            Thread.Sleep(100);
            Console.WriteLine("=   1)View Bnb's                       =");
            Thread.Sleep(100);
            Console.WriteLine("=   2)Register a Bnb                   =");
            Thread.Sleep(100);
            Console.WriteLine("=   3)Reserve A Bnb                    =");
            Thread.Sleep(100);
            Console.WriteLine("=   4)Unreserve A Bnb                  =");
            Thread.Sleep(100);
            Console.WriteLine("=   5)Modify a Bnb                     =");
            Thread.Sleep(100);
            Console.WriteLine("=   6)Create a Owner account           =");
            Thread.Sleep(100);
            Console.WriteLine("=   7)Create a customer Account        =");
            Thread.Sleep(100);
            Console.WriteLine("=   8)Show Functions of Bnb's          =");
            Thread.Sleep(100);
            Console.WriteLine("=   9Show Customers/Owners             =");
            Thread.Sleep(100);
            Console.WriteLine("=  write 0 to end program              =");
            Thread.Sleep(100);
            Console.WriteLine("========================================");



            Console.WriteLine("What Would You Like to do?     ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                bnb.viewBnb();
            }
            else if (choice == 2)
            {
                Console.WriteLine("What type of bnb do you wish to create?\n 1)Small\n 2)Medium\n 3)Big\n 4)Villa");
                int choice2 = Convert.ToInt32(Console.ReadLine());
                if( choice2 == 1)
                {
                    Console.WriteLine("Enter The name of your Bnb : ");
                    string name = Console.ReadLine();
                    Console.WriteLine("enter the price of the Bnb: ");
                    int Price = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the owners name: ");
                    string nameowner = Console.ReadLine();
                    Console.WriteLine("Enter the Location of the Bnb: ");
                    string Location = Console.ReadLine();

                    bnb.addBnb("Small",name,Price, nameowner, Location);

                }
                else if (choice2 == 2)
                {
                    Console.WriteLine("Enter The name of your Bnb : ");
                    string name = Console.ReadLine();
                    Console.WriteLine("enter the price of the Bnb: ");
                    int Price = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the owners name: ");
                    string nameowner = Console.ReadLine();
                    Console.WriteLine("Enter the Location of the Bnb: ");
                    string Location = Console.ReadLine();

                    bnb.addBnb("Medium", name, Price, nameowner, Location);
                }
                else if (choice2 == 3)
                {
                    Console.WriteLine("Enter The name of your Bnb : ");
                    string name = Console.ReadLine();
                    Console.WriteLine("enter the price of the Bnb: ");
                    int Price = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the owners name: ");
                    string nameowner = Console.ReadLine();
                    Console.WriteLine("Enter the Location of the Bnb: ");
                    string Location = Console.ReadLine();

                    bnb.addBnb("Big", name, Price, nameowner, Location);

                }
                else if (choice2 == 4)
                {
                    Console.WriteLine("Enter The name of your Bnb : ");
                    string name = Console.ReadLine();
                    Console.WriteLine("enter the price of the Bnb: ");
                    int Price = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the owners name: ");
                    string nameowner = Console.ReadLine();
                    Console.WriteLine("Enter the Location of the Bnb: ");
                    string Location = Console.ReadLine();

                    bnb.addBnb("Villa", name, Price, nameowner, Location);
                }
                else
                {
                    Console.WriteLine("does not exist sorry :(");
                }
            }
            else if (choice == 3)
            {
                bnb.viewBnb();
                Console.WriteLine("which item would you like to reserve: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter your name: ");
                string name = Console.ReadLine();
                bnb.reservebnb(num, name);
            }
            else if(choice == 4)
            {
                bnb.viewBnb();
                Console.WriteLine("which item would you like to Unreserve: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                bnb.unreservebnb(num2);

            }
            else if(choice == 5)
            {
                bnb.viewBnb();
                Console.WriteLine("Which Bnb would you like to modifiy? ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What would you like to modify?\n 1)Price\n 2)Property Name\n 3)Owner Name\n 4)Location ");
                int modchoice = Convert.ToInt32(Console.ReadLine());
                if (modchoice == 1)
                {
                    Console.WriteLine("please enter the price you would like to give the BNB: ");
                    string price = Console.ReadLine();
                    bnb.modifyBnb(modchoice, price, num1);
                }
                else if(modchoice == 2)
                {
                    Console.WriteLine("please enter the Name you would like to give the BNB: ");
                    string name = Console.ReadLine();
                    bnb.modifyBnb(modchoice, name, num1);
                }
                else if(modchoice == 3)
                {
                    Console.WriteLine("please enter the Owner of the Bnb: ");
                    string Owner = Console.ReadLine();
                    bnb.modifyBnb(modchoice, Owner, num1);
                }
                else if(modchoice == 4)
                {
                    Console.WriteLine("Please enter the location of the Bnb: ");
                    string Location = Console.ReadLine();
                    bnb.modifyBnb(modchoice, Location, num1);
                }
                else
                {
                    Console.WriteLine("please enter a proper choice!");
                }
            }
            else if(choice == 6)
            {
                //owner
                Console.WriteLine("Please enter your first name: ");
                string fname = Console.ReadLine();
                Console.WriteLine("Please enter your last name: ");
                string lname = Console.ReadLine();
                Console.WriteLine("please enter your Age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("please enter what city youre from: ");
                string city = Console.ReadLine();
                Console.Write("please enter what your salary is: ");
                int salary = Convert.ToInt32(Console.ReadLine());
                owners.Add(new Owner(fname, lname, age, city, salary));

            }
            else if (choice == 7)
            {
                //customer
                Console.WriteLine("Please enter your first name: ");
                string fname = Console.ReadLine();
                Console.WriteLine("Please enter your last name: ");
                string lname = Console.ReadLine();
                Console.WriteLine("please enter your Age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("please enter what city youre from: ");
                string city = Console.ReadLine();
                Console.Write("please enter what your salary is: ");
                int salary = Convert.ToInt32(Console.ReadLine());
                customers.Add(new Customer(fname, lname, age, city, salary));
            }
            else if (choice == 8)
            {
                Console.WriteLine("what features do you want to see\n 1)SmallBnb\n 2)MediumBnb\n 3)BigBnb\n 4)VillaBnb");
                int choi1 = Convert.ToInt32(Console.ReadLine());
                if (choi1 == 1)
                {
                    IBnbBuilder sb = new smallBnbBuilder();
                    BnbDirector sd = new BnbDirector(sb);
                    List<string> features = sd.makeSmallBnb();
                    Console.WriteLine("The Small bnb has....");
                    foreach (string feature in features)
                    {
                        Console.WriteLine($"{feature}");
                    }
                }
                else if (choi1 == 2)
                {
                    IBnbBuilder mb = new midBuilder();
                    BnbDirector md = new BnbDirector(mb);
                    List<string> features = md.makeMidBnb();
                    Console.WriteLine("The Medium bnb has....");
                    foreach (string feature in features)
                    {
                        Console.WriteLine($"{feature}");
                    }
                }
                else if (choi1 == 3)
                {
                    IBnbBuilder bb = new bigBuilder();
                    BnbDirector bd = new BnbDirector(bb);
                    List<string> features = bd.makeBigBnb();
                    Console.WriteLine("The Big bnb has....");
                    foreach (string feature in features)
                    {
                        Console.WriteLine($"{feature}");
                    }
                }
                else if(choi1 == 4)
                {
                    IBnbBuilder vb = new VillaBuilder();
                    BnbDirector vd = new BnbDirector(vb);
                    List<string> features = vd.makeVillaBnb();
                    Console.WriteLine("The Big bnb has....");
                    foreach (string feature in features)
                    {
                        Console.WriteLine($"{feature}");
                    }
                }

            }
            else if (choice == 9)
            {
                Console.WriteLine("what would you like to view\n 1)Customer\n 2)Owners: ");
                int choice3 = Convert.ToInt32(Console.ReadLine());
                if (choice3 == 1)
                {
                    int i = 0;
                    foreach (var item in customers)
                    {
                        i++;
                        Console.WriteLine($"{i}){item.getCustomerDetails()}");
                    }
                }
                else if(choice3 == 2)
                {
                    int i = 0;
                    foreach (var item in owners)
                    {
                        i++;
                        Console.WriteLine($"{i}){item.getOwnerDetails()}");
                    }
                }
                else
                {
                    Console.WriteLine("choice doesnt exist!");
                }
            }
            else if (choice == 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Please enter an option on screen!");
            }



        }
        
    }

}