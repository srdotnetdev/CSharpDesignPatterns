namespace GoF.DesignPatterns.Facade;

internal static class Program
{
    private static void Main(string[] args)
    {
        var travelProvider = new TravelFacade();
        travelProvider.BookTravel("New York", "Los Angeles");
    }
}