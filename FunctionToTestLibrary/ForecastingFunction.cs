using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionToTestLibrary {
    public class ForecastingFunction {

        //PROPERTY
        public int Multiplier { get; set; } = 0;

        //METHODS
        public int Forecast(int x, int y) {
            return ((x * x * x) + (y * y)) * Multiplier;
        }
    }
}
