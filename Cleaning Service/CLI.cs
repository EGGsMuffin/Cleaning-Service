using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharprompt;
using static Cleaning_Service.Enums;

namespace Cleaning_Service
{
    public static class CLI
    {
        static List<StaffMember> StaffMemberList = new List<StaffMember>();

        

        static void Main(string[] args)
        {

            List<Commercial> CommercialList = new List<Commercial>();
            List<Domestic> DomesticList = new List<Domestic>();
            List<Customer> CustomerList = new List<Customer>();
            List<MajorCleaning> MajorCleaningList = new List<MajorCleaning>();
            List<MinorCleaning> MinorCleaningList = new List<MinorCleaning>();
            List<Purchase> PurchaseList = new List<Purchase>();
            List<TimeLog> TimeLogList = new List<TimeLog>();
            StaffMemberList = new List<StaffMember>();

            StaffMemberList.Add(new StaffMember("Jack", "Carter", "jackcarter.contact@gmail.com", "0770963102", "Bazinga", "Test"));

            MainMenu(CommercialList, DomesticList, CustomerList, MajorCleaningList, MinorCleaningList, PurchaseList, StaffMemberList, TimeLogList);
        }

        static void MainMenu(List<Commercial> CommercialList, List<Domestic> DomesticList, List<Customer> CustomerList, List<MajorCleaning> MajorCleaningList, List<MinorCleaning> MinorCleaningList, List<Purchase> PurchaseList, List<StaffMember> StaffMemberList, List<TimeLog> TimeLogList)
        {
            string[] menuOptions = {
                "Add Booking",
                "View Booking",
                "Update Booking",
                "View Time Log",
                "Add Staff",
                "Add Purchase",
                "Add Commercial",
                "Add Domestic",
                "Exit"
            };

            string options = Prompt.Select("Welcome to Shauns Cleaning Service", menuOptions);

            switch (options)
            {
                case ("Add Booking"):
                    AddBooking(CommercialList, DomesticList, CustomerList, MajorCleaningList, MinorCleaningList, PurchaseList, StaffMemberList, TimeLogList);
                    MainMenu(CommercialList, DomesticList, CustomerList, MajorCleaningList, MinorCleaningList, PurchaseList, StaffMemberList, TimeLogList);
                    break;
                case ("View Booking"):
                    ViewBooking();
                    MainMenu(CommercialList, DomesticList, CustomerList, MajorCleaningList, MinorCleaningList, PurchaseList, StaffMemberList, TimeLogList);
                    break;
                case ("Update Booking"):
                    UpdateBooking();
                    MainMenu(CommercialList, DomesticList, CustomerList, MajorCleaningList, MinorCleaningList, PurchaseList, StaffMemberList, TimeLogList);
                    break;
                case ("View Time Log"):
                    ViewTimeLog();
                    MainMenu(CommercialList, DomesticList, CustomerList, MajorCleaningList, MinorCleaningList, PurchaseList, StaffMemberList, TimeLogList);
                    break;
                case ("Add Staff"):
                    AddStaff();
                    MainMenu(CommercialList, DomesticList, CustomerList, MajorCleaningList, MinorCleaningList, PurchaseList, StaffMemberList, TimeLogList);
                    break;
                case ("Add Purchase"):
                    AddPurchase();
                    MainMenu(CommercialList, DomesticList, CustomerList, MajorCleaningList, MinorCleaningList, PurchaseList, StaffMemberList, TimeLogList);
                    break;
                case ("Add Commercial"):
                    AddCommercialBuilding(CommercialList, CustomerList);
                    MainMenu(CommercialList, DomesticList, CustomerList, MajorCleaningList, MinorCleaningList, PurchaseList, StaffMemberList, TimeLogList);
                    break;
                case ("Add Domestic"):
                    AddDomesticBuilding(DomesticList, CustomerList);
                    MainMenu(CommercialList, DomesticList, CustomerList, MajorCleaningList, MinorCleaningList, PurchaseList, StaffMemberList, TimeLogList);
                    break;
                case ("Exit"):
                    break;
            }
        }

        static void AddBooking(List<Commercial> CommercialList, List<Domestic> DomesticList, List<Customer> CustomerList, List<MajorCleaning> MajorCleaningList, List<MinorCleaning> MinorCleaningList, List<Purchase> PurchaseList, List<StaffMember> StaffMemberList, List<TimeLog> TimeLogList)
        {

            string Type = Prompt.Select("What type of building is it", new[] { "DomesticType", "CommercialType" });


        }

        static void AddCommercialBuilding(List<Commercial> CommercialList, List<Customer> CustomerList)
        {
            string firstName = Prompt.Input<string>("What is your first name");
            string lastName = Prompt.Input<string>("What is your last name");
            string emailAddress = Prompt.Input<string>("What is your email address");
            string phone = Prompt.Input<string>("What is your phone number");

            Customer customer = new Customer(firstName, lastName, emailAddress, phone);

            string address = Prompt.Input<string>("What is your address");
            string businessName = Prompt.Input<string>("What is your business name");

            CommericalType type = Prompt.Select<CommericalType>("Select enum value");

            double size = Prompt.Input<double>("What the size of your building");

            Commercial commercialBuilding = new Commercial(address, businessName, type, size, customer);
            CommercialList.Add(commercialBuilding);
        }

        static void AddDomesticBuilding(List<Domestic> DomesticList, List<Customer> CustomerList)
        {
            string firstName = Prompt.Input<string>("What is your first name");
            string lastName = Prompt.Input<string>("What is your last name");
            string emailAddress = Prompt.Input<string>("What is your email address");
            string phone = Prompt.Input<string>("What is your phone number");

            Customer customer = new Customer(firstName, lastName, emailAddress, phone);

            string address = Prompt.Input<string>("What is your address");
            DomesticType type = Prompt.Select<DomesticType>("Select enum value");
            int rooms = Prompt.Input<int>("How many rooms do you have");

            Domestic domesticbuilding = new Domestic(address, type, rooms, customer);
            DomesticList.Add(domesticbuilding);
        }

        static void ViewBooking()
        {

        }

        static void UpdateBooking()
        {

        }

        static void ViewTimeLog()
        {

        }

        static void AddStaff(List<StaffMember>StaffMemberList)
        {
            string firstName = Prompt.Input<string>("What is your first name");
            string lastName = Prompt.Input<string>("What is your last name");
            string emailAddress = Prompt.Input<string>("What is your email address");
            string phone = Prompt.Input<string>("What is your phone number");
            string username = Prompt.Input<string>("What is your username");
            string password = Prompt.Input<string>("What is your password");


            StaffMember staff = new StaffMember(firstName, lastName, emailAddress, phone, username, password);
            StaffMemberList.Add(staff);
        }

        static void AddPurchase(List<Purchase> PurchaseList)
        {
            string descrip = Prompt.Input<string>("What are you buying");
            double cost = Prompt.Input<double>("What is the cost");

            Console.WriteLine("Available staff members that Josh paying below minimum wage:");

            for (int i = 0;i< StaffMemberList.Count; i++)
            {
                Console.WriteLine($"> {StaffMemberList[i].Id}: {StaffMemberList[i].Fname} {StaffMemberList[i].Sname}");
            }

            StaffMember staff = null;

            string input = Prompt.Input<string>("What is the staff member's ID?");
            foreach (var staffMember in StaffMemberList)
            {
                if (staffMember.Id.ToString() == input)
                {
                    staff = staffMember;
                }
            }

            foreach(var staffMember in StaffMemberList)
            {
                if (staffMember.Id.ToString() == input)
                {
                    Console.WriteLine($"New order made for £{cost} by staff member {staffMember.Fname} {staffMember.Sname} for {descrip}.");
                }
            }

            Purchase newPurchase = new Purchase(descrip, cost, staff);
            PurchaseList.Add(newPurchase);
        }
    }
}

