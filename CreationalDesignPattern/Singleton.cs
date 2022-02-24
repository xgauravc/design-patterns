using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalDesignPattern
{
    //Singleton is used when we need to ensure that only single object of a particual class needs to be created.
    //All further references to the objects are referred to the same underlying instance created.
    //

    //Advantages - 
    //          1.Singleton controls concurrent access to the resource .
    //          2.It ensures there is only one object available across the application in a controlled state.


    //Implementation guidelines -  
    //               1.Ensure that only one instance of the class exists.
    //               2.Provide global access to the instance by:
    //                          a) Declaring all the constructors of the class as private.
    //                          b) Providing static method that returns a reference to the instance.
    //                          c) The instance is stored as private static variable.

    public sealed class Singleton
        //Singleton class is sealed because nested class can inherit the siongleton class and thus violates the Singleton principle.

    {
        private static int  count=0;
        //Eager loading
        private static readonly Singleton instance = new Singleton();
        private static  readonly object obj = new object();
        private Singleton()
        {
            count++;
            Console.WriteLine("Counter value " + count.ToString()); ;
        }
        public static Singleton GetInstance {
            get 
            {
                //as lock is costly we need to enter the lock scope only if instace is null. 
                //This is Double check locking
                //if (instance == null) {
                //    lock (obj)
                //    {
                //        if (instance == null)
                //            instance = new Singleton();
                //    }
                //}
                
                
                return instance; 
            }
        }
        public void  NewMethod(string name) {
            Console.WriteLine("This is message from "+ name.ToString());
        }
        


    }

    
}
