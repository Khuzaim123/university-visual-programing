using System;

public class Customer
{
    public int Id { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public Customer(int id, string last, string first, string street, string city, string state, string zip, string phone, string email, string pass)
    {
        Id = id;
        LastName = last;
        FirstName = first;
        Street = street;
        City = city;
        State = state;
        ZipCode = zip;
        Phone = phone;
        Email = email;
        Password = pass;
    }
}

public class RetailCustomer : Customer
{
    public string CardType { get; set; }
    public string CardNo { get; set; }

    public RetailCustomer(int id, string last, string first, string street, string city, string state, string zip, string phone, string email, string pass, string cardType, string cardNo)
        : base(id, last, first, street, city, state, zip, phone, email, pass)
    {
        CardType = cardType;
        CardNo = cardNo;
    }
}

public class CorporateCustomer : Customer
{
    public string Company { get; set; }
    public int FlyerPoints { get; set; }
    public string BillingNo { get; set; }

    public CorporateCustomer(int id, string last, string first, string street, string city, string state, string zip, string phone, string email, string pass, string company, int points, string billingNo)
        : base(id, last, first, street, city, state, zip, phone, email, pass)
    {
        Company = company;
        FlyerPoints = points;
        BillingNo = billingNo;
    }
}

public class Flight
{
    public string Id { get; set; }
    public string Origin { get; set; }
    public string Destination { get; set; }
    public DateTime Departure { get; set; }
    public DateTime Arrival { get; set; }

    public Flight(string id, string origin, string destination, DateTime departure, DateTime arrival)
    {
        Id = id;
        Origin = origin;
        Destination = destination;
        Departure = departure;
        Arrival = arrival;
    }
}

public class Seat
{
    public int Row { get; set; }
    public int No { get; set; }
    public decimal Price { get; set; }
    public string Status { get; set; }

    public Seat(int row, int no, decimal price, string status)
    {
        Row = row;
        No = no;
        Price = price;
        Status = status;
    }
}

public class Reservation
{
    public string No { get; set; }
    public DateTime Date { get; set; }
    public Flight Flight { get; set; }
    public Seat Seat { get; set; }

    public Reservation(string no, DateTime date, Flight flight, Seat seat)
    {
        No = no;
        Date = date;
        Flight = flight;
        Seat = seat;
    }
}

public class Program
{
    public static void Main()
    {
        var customer = new RetailCustomer(1, "Khan", "Ali", "456 Street", "Karachi", "Sindh", "75300", "0300-1234567", "ali@example.com", "pass123", "Visa", "1234-5678-9012-3456");
        var seat = new Seat(2, 5, 15000.0m, "Available");
        var flight = new Flight("PK123", "Karachi", "Lahore", DateTime.Today.AddHours(2), DateTime.Today.AddHours(4));
        var reservation = new Reservation("RES456", DateTime.Today, flight, seat);

        Console.WriteLine($"Customer: {customer.FirstName} {customer.LastName}, Flight: {flight.Id}, Reservation No: {reservation.No}, Seat: {seat.No}");
    }
}
