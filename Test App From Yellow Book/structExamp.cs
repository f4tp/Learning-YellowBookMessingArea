namespace Test_App_From_Yellow_Book
{
    public struct structExample
    {
        public int testInt;
        public int testIntTwo;

        public structExample(int intonein, int inttwoin)
        {
            testInt = intonein;
            testIntTwo = inttwoin;
        }

        public int GetIntOne()
        {
            return this.testInt;
        }

        public int GetIntTwo()
        {
            return this.testIntTwo;
        }
    }




}
