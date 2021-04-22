using System;

namespace ArrayOfDeli
{
    class Program
    {
        delegate void DelOp(int x, int y);

        static void Main(string[] args)
        {
            //Delegate Instantiation
            DelOp[] obj =
            {
                new DelOp(Operation.Add),
                new DelOp(Operation.Multiple)
            };

            for(int i = 0; i < obj.Length; i++)
            {
                obj[i](2, 5);
                obj[i](20, 5);
                obj[i](5, 5);
                obj[i](25, 5);
            }

        }
    }
}
