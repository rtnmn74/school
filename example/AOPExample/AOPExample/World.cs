using System;


namespace AOPExample
{
    class World
    {
        [LogExecutionTimeAttribute]
        public static string writeWorld()
        {
            System.Threading.Thread.Sleep(2000);
            return "World";
        }
    }
}
