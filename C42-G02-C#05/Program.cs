namespace C42_G02_C_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            //Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
            int valueType = 10;
            ModifyValueType(valueType);
            Console.WriteLine("After ModifyValueType: " + valueType); // Output: 10

            ModifyValueTypeByRef(ref valueType);
            Console.WriteLine("After ModifyValueTypeByRef: " + valueType); // Output: 20

            // Passing by value
            static void ModifyValueType(int value)
            {
                value = 20;
            }

            // Passing by reference
            static void ModifyValueTypeByRef(ref int value)
            {
                value = 20;
            }
            #endregion
        }
    }
}
