// See https://aka.ms/new-console-template for more information
using DesignPatterns.CreationalDesignPattern;
namespace DesignPatterns {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Parallel.Invoke(
                () => GetGaurav(),
                () => GetSwati()
                ); 
            
        }

        private static void GetSwati()
        {
            Singleton s2 = Singleton.GetInstance;
            s2.NewMethod("Swati");
        }


        private static void GetGaurav()
        {
            Singleton s1 = Singleton.GetInstance;
            s1.NewMethod("Gaurav");
        }

    }
}
