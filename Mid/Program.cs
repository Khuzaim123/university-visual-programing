using System;
using System.Collections.Generic;

internal class Mid
{
    public class User
    {
        protected string userid;
        protected string name;
        protected string phone;

        public void SetName()
        {
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
        }

        public void GetName()
        {
            Console.WriteLine($"User name: {name}");
        }

        public void SetUserId()
        {
            Console.Write("Enter user id: ");
            userid = Console.ReadLine();
        }

        public void GetUserId()
        {
            Console.WriteLine($"User id: {userid}");
        }

        public void SetPhone()
        {
            Console.Write("Enter your phone number: ");
            phone = Console.ReadLine();
        }

        public void GetPhone()
        {
            Console.WriteLine($"Phone number: {phone}");
        }

        public void Display()
        {
            GetUserId();
            GetName();
            GetPhone();
        }

        public void Register()
        {
            Console.WriteLine("Enter your details:");
            SetName();
            SetPhone();
            SetUserId();
        }

        public void Login()
        {
            string n;
            Console.Write("Enter your name: ");
            n = Console.ReadLine();
            if (n == name)
            {
                Console.WriteLine("Login Successful");
            }
            else
            {
                Console.WriteLine("Invalid user");
            }
        }
    }

    public class Rider : User
    {
        public List<Trip> trips = new List<Trip>();

        public void RequestRide()
        {
            string start;
            Console.Write("Enter start location: ");
            start = Console.ReadLine();
            string destination;
            Console.Write("Enter destination: ");
            destination = Console.ReadLine();
            Trip newTrip = new Trip();
            newTrip.SetStart(start);
            newTrip.SetDestination(destination);
            newTrip.CalculateFare();
            trips.Add(newTrip);
            Console.WriteLine("Ride requested successfully.");
        }

        public void DisplayTrips()
        {
            foreach (var trip in trips)
            {
                trip.DisplayTripDetails();
            }
        }

        public void RegisterRider()
        {
            Register();
        }
    }

    public class Driver : User
    {
        private string id;
        private string vehicle;
        public List<Trip> tripHistory = new List<Trip>();

        public void SetId()
        {
            Console.Write("Enter driver ID: ");
            id = Console.ReadLine();
        }

        public void SetVehicle()
        {
            Console.Write("Enter name of the vehicle: ");
            vehicle = Console.ReadLine();
        }

        public void GetVehicle()
        {
            Console.WriteLine("Vehicle: " + vehicle);
        }

        public void GetId()
        {
            Console.WriteLine("ID: " + id);
        }

        public void AcceptRide(Trip trip)
        {
            tripHistory.Add(trip);
            Console.WriteLine("Ride accepted.");
        }

        public void ViewTripHistory()
        {
            foreach (var trip in tripHistory)
            {
                trip.DisplayTripDetails();
            }
        }

        public void RegisterDriver()
        {
            Register();
            SetVehicle();
            SetId();
        }

        public void Details()
        {
            Display();
            GetId();
            GetVehicle();
        }

        public void CompleteTrip(Trip trip)
        {
            trip.EndTrip();
            Console.WriteLine("Trip has been completed.");
        }
    }

    public class Trip
    {
        private int tripId;
        private string startLocation;
        private string destination;
        private decimal fare;
        private bool status;

        public Trip()
        {
            tripId = new Random().Next(1, 99999);
        }

        public void SetStart(string start)
        {
            startLocation = start;
        }

        public void GetStart()
        {
            Console.WriteLine("Starting Location: " + startLocation);
        }

        public void SetDestination(string destination)
        {
            this.destination = destination;
        }

        public void GetDestination()
        {
            Console.WriteLine("Destination: " + destination);
        }

        public void CalculateFare()
        {
            fare = new Random().Next(100, 500);
        }

        public void GetFare()
        {
            Console.WriteLine("Fare: " + fare);
        }

        public void StartTrip()
        {
            status = true;
        }

        public void EndTrip()
        {
            status = false;
        }

        public void GetStatus()
        {
            Console.WriteLine("Trip status: " + (status ? "Started" : "Ended"));
        }

        public void GetId()
        {
            Console.WriteLine("Trip ID: " + tripId);
        }

        public void DisplayTripDetails()
        {
            Console.WriteLine("Trip Details:");
            GetId();
            GetStart();
            GetDestination();
            GetStatus();
            GetFare();
        }
    }

    public class RideSharingSystem
    {
        private List<Rider> riders = new List<Rider>();
        private List<Driver> drivers = new List<Driver>();
        private List<Trip> trips = new List<Trip>();
        private Rider rider;
        private Driver driver;
        private Trip trip;

        public RideSharingSystem()
        {
            rider = new Rider();
            driver = new Driver();
            trip = new Trip();
            bool exit = true;
            while (exit)
            {
                int choice;
                Console.WriteLine("1.Register a Rider");
                Console.WriteLine("2.Register a Driver");
                Console.WriteLine("3.Request a Ride");
                Console.WriteLine("4.Accept a Ride");
                Console.WriteLine("5.Complete a Trip");
                Console.WriteLine("6.View Ride History");
                Console.WriteLine("7.View Trip History");
                Console.WriteLine("8.Display All Trips");
                Console.WriteLine("9.Exit");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        rider.RegisterRider();
                        riders.Add(rider);
                        break;
                    case 2:
                        driver.RegisterDriver();
                        drivers.Add(driver);
                        break;
                    case 3:
                        rider.RequestRide();
                        break;
                    case 4:
                        if (rider.trips.Count > 0)
                        {
                            Trip lastTrip = rider.trips[rider.trips.Count - 1];
                            driver.AcceptRide(lastTrip);
                        }
                        break;
                    case 5:
                        if (driver.tripHistory.Count > 0)
                        {
                            Trip lastTrip = driver.tripHistory[driver.tripHistory.Count - 1];
                            lastTrip.DisplayTripDetails();
                            driver.CompleteTrip(lastTrip);
                        }
                        break;
                    case 6:
                        rider.DisplayTrips();
                        break;
                    case 7:
                        driver.ViewTripHistory();
                        break;
                    case 8:
                        foreach (var trip in trips)
                        {
                            trip.DisplayTripDetails();
                        }
                        break;
                    case 9:
                        exit = false;
                        break;
                }
            }
        }
    }

    static void Main()
    {
        RideSharingSystem rss = new RideSharingSystem();
    }
}