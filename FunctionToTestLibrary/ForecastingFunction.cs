using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionToTestLibrary {
    public class ForecastingFunction {

        //PROPERTY
        public int Multiplier { get; set; } = 0;

        //METHODS
        public int Forecast(int x, int y) {
            if(x < -10 || x > 10 || y < -10 || y > 10) {
                throw new Exception("X or Y are outside the domain.");
            }

            return ((x * x * x) + (y * y)) * Multiplier;
        }
    }
}


//   -10 <= x,y <= 10