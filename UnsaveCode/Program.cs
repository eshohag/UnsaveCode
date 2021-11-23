using System;

namespace UnsaveCode
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  
             C# allows using pointer variables in a function of code block when it is marked by the unsafe modifier.
             The unsafe code or the unmanaged code is a code block that uses a pointer variable.
             */
            unsafe
            {
                int var = 20;
                int* p = &var;

                Console.WriteLine("Data is: {0} ", var);
                Console.WriteLine("Data is: {0} ", p->ToString());
                Console.WriteLine("Address is: {0} ", (int)p);
            }

            Console.ReadKey();
        }
    }
}
