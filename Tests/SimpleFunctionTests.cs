using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpUnitTest.Tests
{
    public class SimpleFunctionTests
    {
        public static void SimpleFunction_ReturnsDogIfOne_ReturnString() 
        {
            try
            {
                //Arrange - declare the variable and other related stuffs
                int num = 1;
                SimpleFunction simpleFunction = new SimpleFunction();

                //Act - Execute the function
                 string result = simpleFunction.returnsDogIfOne(num);

                //Assert - Verify the returned result against expectation
                if (result == "DOG")
                {
                    Console.WriteLine("PASSED: SimpleFunction.returnsDogIfOne");
                }
                else
                {
                    Console.WriteLine("FAILED: SimpleFunction.returnsDogIfOne");
                }
            } 
            catch (Exception ex) 
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
