using System;
using FunctionToTestLibrary;

namespace FunctionToTestConsole {
    class Program {
        static void Main(string[] args) {
            var ff = new ForecastingFunction(); //create instance of our class

            // TEST 1
            try {
                // Multiplier is zero
                ff.Forecast(-11, 11); // expect:  Exception!
                Console.WriteLine("Test failed!");  // this happens if test fails, and we DON'T get an exception
            } catch (Exception ex) {
                Console.WriteLine("Test passed!");
            }

            // TEST 2
            // Multiplier is 2, x is 25, y is 5, result
            try {
                ff.Multiplier = 2;
                var result = ff.Forecast(25, 5);
            } catch (Exception ex) {
                Console.WriteLine("Test passed!");
            }


            // loose pair (or any pair) of curly braces defines a scope.  We can keep re-defining "var result", because it gets destroyed after each time  
            {
                ff.Multiplier = 2;
                var result = ff.Forecast(2, 2);
                if(result == 24) {
                    Console.WriteLine("Test passed!");
                }  else {
                    Console.WriteLine("Test failed!");
                }
            }


            // Would we like to do 500 of these?  No, we wouldn't. 

        }
    }
}
