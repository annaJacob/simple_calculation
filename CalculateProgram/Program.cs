using System;

namespace CalculateProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations operations = new Operations();
          
             {
                operations.enterNumbers();
                operations.operationToPerform();
                operations.chooseToContinue();
             }
         }
    }
}
