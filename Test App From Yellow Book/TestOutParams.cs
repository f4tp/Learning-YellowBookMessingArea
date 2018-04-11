using System;

namespace Test_App_From_Yellow_Book
{
    class TestOutParams
    {

    
        public TestOutParams()
        {

        }

        public static void RunTestOutParams(out string namer)
        {
            namer = Console.ReadLine();
        }
    }
}
