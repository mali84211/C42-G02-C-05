namespace C42_G02_C_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region V2
            object O1;
            O1 = "Ahmed"; //casting
            O1 = 1;
            O1 = "A";
            O1 = new Employee();
            #region
            int x = 10;
            object obj = x;
            obj= new object(10);
            object obj2 = 10;
            int y =(int)obj2;
            Console.WriteLine(y);
            #endregion
            #endregion
        }
    }
}
