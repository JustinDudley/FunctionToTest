using FunctionToTestLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FunctionToTestTestProject {

    [TestClass]     // "Attributes" [the things in brackets]  They are, in fact, classes.  They have a special purpose . They are classes about OUR classes. Data about the data.  Meta-data
    public class UnitTest1 {


        ForecastingFunction ff = null;  //hasn't been instantiated yet

        // if all tests are inside one method, it's hard to tell which one failed. 
        // All test methods look like this:  public, void, take no parameters. And, by convention, they start with the word "Test..")
        // TestInitialize acts somewhat like a constructor: Instantiate once, use over and over for multiple test methods
        // "If you attach the TestInitialize attribute, it is always called first.   Then all other ?methods? can use it 
        


        [TestInitialize]   
        public void TestInit() {                
            ff = new ForecastingFunction();     // now it's instantiated
        }


        [TestMethod]                 // this is an annotation --  the thing in the brackets
        [ExpectedException(typeof(Exception))]
        public void TestParmsOutsideDomain() {      // parms is short for parameters?
            ff.Multiplier = 0;
            Assert.AreEqual(0, ff.Forecast(100, 100));
        }


        [TestMethod]
        public void TestValidInputsWithMultiplierZero() {           // this is where we put in the tests that we DON't think are going to blow up.
            // Multiplier is zero
            ff.Multiplier = 0;      // should put this in, don't assume the Multiplier is currently set to zero, even though it shoud be
            Assert.AreEqual(0, ff.Forecast(0, 0), "Result should be zero");
            Assert.AreEqual(0, ff.Forecast(1, 1), "Result should be zero");
            Assert.AreEqual(0, ff.Forecast(-1, -1), "Result should be zero");
        }
        [TestMethod]
        public void TestValidInputsWithMultiplierOne() {
            // Multiplier is zero
            ff.Multiplier = 1;
            Assert.AreEqual(0, ff.Forecast(0, 0), "Result should be zero");
            Assert.AreEqual(2, ff.Forecast(1, 1), "Result should be 2");
            Assert.AreEqual(0, ff.Forecast(-1, -1), "Result should be zero");
        }

        [TestMethod]
        public void TestValidInputsWithMultiplierFive() {
            ff.Multiplier = 5;
            Assert.AreEqual(0, ff.Forecast(0, 0), "Result should be zero");
            Assert.AreEqual(10, ff.Forecast(1, 1), "Result should be 10");
            Assert.AreEqual(0, ff.Forecast(-1, -1), "Result should be zero");
            Assert.AreEqual(60, ff.Forecast(2, 2), "Result should be zero");
            Assert.AreEqual(-20, ff.Forecast(-2, -2), "Result should be zero");
            Assert.IsTrue(ff.Multiplier % 5 == 0);
        }



        public void Test() {        //Here, there is no annotation, nothing in brackets

        }
    }
}

// you have some freedome about how to organize your tests.
        //You have to write the tests.  YOU have to dream up the tests