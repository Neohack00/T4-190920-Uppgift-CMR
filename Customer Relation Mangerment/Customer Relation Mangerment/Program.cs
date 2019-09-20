using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Relation_Mangerment
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Run = true;
            bool New = false;
            bool Current = false;
            System.Collections.ArrayList Contactlist = new System.Collections.ArrayList();
            Contactlist.Add(new Contact() { Name = "SOS", PhoneNumber = "112", Email = "112.Alarm@Sverige.se" , Favorite = false});
            Contactlist.Add(new Contact() { Name = "Taxi Stockholm", PhoneNumber = "08150000", Email = "kund@taxistockholm.se", Favorite = false });
            Contactlist.Add(new Contact() { Name = "Pizza", PhoneNumber = "086600119", Email = "hamid.ramazani93@gmail.com" , Favorite = false});
            Contactlist.Add(new Contact() { Name = "Neo Bylock", PhoneNumber = "0707785450", Email = "neo@bylock.se", Favorite = true });
            Contactlist.Add(new Contact() { Name = "God", PhoneNumber = "3331", Email = "God.Allah@AllMighty.sky", Favorite = true });
            Contactlist.Add(new Contact() { Name = "The Devil", PhoneNumber = "666", Email = "Lucifer@Morningstar.hell" , Favorite = false});
            Contactlist.Add(new Contact() { Name = "Stevie Griffen", PhoneNumber = "075568359", Email ="Stevie.Griffen@familyguy.com", Favorite = true });
            Console.WriteLine("Welcome to your personal Custmer Relation Management! ");
            Console.WriteLine("Do you wish to use your current Contact or do you wish to add a new contact?  ");
            Console.WriteLine("Write in 'new' for creating a new one and 'current' check the current contacts");
            string Userchoice = Console.ReadLine();
            bool option = false;
            do
            {
                if(Userchoice == "current" || Userchoice == "Current")
                {
                    Console.WriteLine("You have selected Current contact");
                    Current = true;
                    option = true;
                }
                else if (Userchoice == "new" || Userchoice == "New")
                {
                    Console.WriteLine("You have selected New contact");
                    New = true;
                    option = true;
                }
                else
                {
                    Console.WriteLine("Input data is incorrect! Please check your spelling and select one of the option listed below:");
                    Console.WriteLine("For Creating an new contact write in following keywords into the Console: 'New' or 'new'");
                    Console.WriteLine("For Checking the current contact list write in following keywords into the console: 'Current' or 'current' \n");
                    Userchoice = Console.ReadLine();
                }
            } while (option == false);
            int FavoriteCount = 0;
            while (Run == true)
            {
                if(New == true)
                {
                    Console.WriteLine("Här kommer du kunna skapa en ny kontakt");
                    
                }

                if (Current == true)
                {


                    Console.WriteLine("------------------");
                    Console.WriteLine("All Contacts: ");
                    Console.WriteLine("------------------");
                    foreach (Contact ListedContact in Contactlist)
                    {
                        Console.WriteLine(ListedContact.Name);
                    }



                    Console.WriteLine("------------------");
                    Console.WriteLine("Favorite Contacts: ");
                    Console.WriteLine("------------------");
                    foreach (Contact state in Contactlist)
                    {
                        if (state.Favorite == true)
                        {
                            Console.WriteLine(state.Name);
                            FavoriteCount++;
                        }
                    }
                    Console.WriteLine("------------------");;
                    Console.WriteLine("You have total {0} contacts and {1} as marked favorite ", Contactlist.Count, FavoriteCount);
                    Console.WriteLine("For more infamtion of contact, write in there name. Obs make sure you spell it right");
                    
                }
                    Run = false;

             
            }


            Console.ReadLine();
            
            
                   
        }

    }

}
