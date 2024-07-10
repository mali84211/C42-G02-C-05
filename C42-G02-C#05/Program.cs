namespace C42_G02_C_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region V2
            //object O1;
            //O1 = "Ahmed"; //casting
            //O1 = 1;
            //O1 = "A";
            //O1 = new Employee();
            #region
            //int x = 10;
            //object obj = x;
            //obj= new object(10);
            //object obj2 = 10;
            //int y =(int)obj2;
            //Console.WriteLine(y);
            #endregion
            #endregion
            #region V3
            //int x = null;
            //int? y= null;
            //int x = 10;
            //int? z = y;
            //int? z = x;
            //int? number;
            //decimal num1 = 1.1m;
            //decimal? num2 = num1;
            //decimal? num1 = null;
            //Console.WriteLine(num1);

            //int x = 10;
            //int? y = (int?)x;

            //int? num1=null;
            //int num2=(int)num1;
            //Console.WriteLine(num2);

            int? k=null;
            int l;
            //l = k;
            if (k == null)
            {
                l = (int)k;
            }
            else { l = 0; }
            l=k.HasValue ? k.Value : 0; 
            l=k!=null ? (int)k: 0;   
            #endregion
        }
    }
}
