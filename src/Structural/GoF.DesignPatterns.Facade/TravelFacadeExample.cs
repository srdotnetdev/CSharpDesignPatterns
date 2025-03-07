namespace GoF.DesignPatterns.Facade;

public class FlightBooking
{
    public void BookFlight(string origin, string destination)
    {
        Console.WriteLine($"Flight booked from {origin} to {destination}");
    }
}

public class HotelBooking
{
    public void BookHotel(string city)
    {
        Console.WriteLine($"Hotel booked in {city}");
    }
}

public class RentalCarBooking
{
    public void BookRentalCar(string city)
    {
        Console.WriteLine($"Rental car booked in {city}");
    }
}

public class TravelFacade
{
    private readonly FlightBooking _flightBooking = new();
    private readonly HotelBooking _hotelBooking = new();
    private readonly RentalCarBooking _rentalCarBooking = new();

    public void BookTravel(string origin, string destination)
    {
        _flightBooking.BookFlight(origin, destination);
        _hotelBooking.BookHotel(destination);
        _rentalCarBooking.BookRentalCar(destination);
    }
}