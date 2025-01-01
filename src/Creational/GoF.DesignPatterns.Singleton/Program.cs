namespace GoF.DesignPatterns.Singleton
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            //Basic Singleton
            var instance1 = BasicSingleton.Instance;
            var instance2 = BasicSingleton.Instance;
            Console.WriteLine($"Are both instances equal? {instance1 == instance2}");
            
            //Thread Safe Singleton
            var instance3 = ThreadSafeSingleton.Instance;
            var instance4 = ThreadSafeSingleton.Instance;
            Console.WriteLine($"Are both instances equal? {instance3 == instance4}");
            
            //More Thread Safe Singleton
            var instance5 = MoreThreadSafeSingleton.Instance;
            var instance6 = MoreThreadSafeSingleton.Instance;
            Console.WriteLine($"Are both instances equal? {instance5 == instance6}");
            
            //Lazy Singleton
            var instance7 = LazySingleton.Instance;
            var instance8 = LazySingleton.Instance;
            Console.WriteLine($"Are both instances equal? {instance7 == instance8}");
            
            //Eager Singleton
            var instance9 = EagerSingleton.Instance;
            var instance10 = EagerSingleton.Instance;
            Console.WriteLine($"Are both instances equal? {instance9 == instance10}");
        }
    }
}
