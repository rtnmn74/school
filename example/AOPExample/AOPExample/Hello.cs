using System;


namespace AOPExample
{
    class Hello
    {
        [LogExecutionTimeAttribute]
        public static string writeHello()
        {
            System.Threading.Thread.Sleep(2000);
            return "Hello";
        }
    }
}
