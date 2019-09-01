using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]//class encompassing all tests for 8 cat.
    public class UnitTest1
    {
        [TestMethod]//method
        public void Adult_Before_5_Test()
        {
            //Arrange data to test
            int quantity = 2;
            double actual_price = 14.5;
            string person = "adult";
            int time = 0500;
            double expected = 29.0;
            string day = "daily"; //except tuesday??

            //Act creating the class
            Tickets Cin = new Tickets(); //initiate 'one' object of the ticket, this is object orientated design. Cinema is ONE object.
            Cin.Adult_Before_5(quantity, person, day, time);

            //Assert
            double total_price = quantity * actual_price;
            Assert.AreEqual(expected, total_price, 14.5, "Passed");

        }

        [TestMethod]
        public void Adult_After_5_Test()
        {
            //Arrange data to test
            int quantity = 2;
            double actual_price = 17.5;
            string person = "adult";
            int time = 0500;
            double expected = 35.0;
            string day = "tuesday"; 

            //Act creating the class
            Tickets Cin = new Tickets(); 
            Cin.Adult_After_5(quantity, person, day, time);

            //Assert
            double total_price = quantity * actual_price;
            Assert.AreEqual(expected, total_price, 17.5, "Passed");

        }

        [TestMethod]//method
        public void Adult_Tuesday_Test()
        {
            //Arrange data to test
            int quantity = 2;
            double actual_price = 13;
            string person = "adult";
            double expected = 26.0;
            string day = "Tuesday";

            //Act creating the class
            Tickets Cin = new Tickets();
            Cin.Adult_Tuesday(quantity, person, day);

            //Assert
            double total_price = quantity * actual_price;
            Assert.AreEqual(expected, total_price, 13, "Passed");

        }

        
        [TestMethod]
        public void Child_Test()
        {
            //Arrange data to test
            int quantity = 2;
            double actual_price = 12;
            string person = "child";
            double expected = 24;
            string day = "daily";

            //Act creating the class
            Tickets Cin = new Tickets();
            Cin.Child(quantity, person, day); 

            //Assert
            double total_price = quantity * actual_price;
            Assert.AreEqual(expected, total_price, 12, "Passed");

        }

        [TestMethod]//method
        public void Senior()
        {
            //Arrange data to test
            int quantity = 2;
            double actual_price = 12.5;
            string person = "senior";
            double expected = 25;
            string day = "daily";

            //Act creating the class
            Tickets Cin = new Tickets(); 
            Cin.Senior(quantity, person, day);

            //Assert
            double total_price = quantity * actual_price;
            Assert.AreEqual(expected, total_price, 12.5, "Passed");

        }
        [TestMethod]//method
        public void Student()
        {
            //Arrange data to test
            int quantity = 2;
            double actual_price = 14;
            string person = "student";
            double expected = 28;
            string day = "daily";

            //Act creating the class
            Tickets Cin = new Tickets(); 
            Cin.Student(quantity, person, day);  

            //Assert
            var total_price = quantity * actual_price;
            Assert.AreEqual(expected, total_price, 14, "Passed");

        }
        
        [TestMethod]
        public void Family_Pass()
        {
            //Arrange data to test
            int quantity = 2;
            int quantity2 = 3;
            double actual_price = 46;
            double expected = 92;
            string day = "daily";

            //Act creating the class
            Tickets Cin = new Tickets(); 
            Cin.Family_Pass(quantity, quantity2, day); 

            //Assert
            double total_price = quantity * actual_price;
            Assert.AreEqual(expected, total_price, 14, "Passed");

        }

        [TestMethod]
        public void Chick_Flick_Thursday()
        {
            //Arrange data to test
            int quantity = 2;
            double actual_price = 21.5;
            string person = "chickflick";
            double expected = 43;
            string day = "thursday";

            //Act creating the class
            Tickets Cin = new Tickets();
            Cin.Chick_Flick_Thursday(quantity, person, day); 

            //Assert
            double total_price = quantity * actual_price;
            Assert.AreEqual(expected, total_price, 21.5, "Passed");

        }

        [TestMethod]
        public void Kids_Carers_Wednesday()
        {
            //Arrange data to test
            int quantity = 2;
            double actual_price = 21;
            string person = "adult";
            double expected = 42;
            string day = "wednesday";

            //Act creating the class
            Tickets Cin = new Tickets(); 
            Cin.Kids_Carers_Wednesday(quantity, person, day); 

            //Assert
            double total_price = quantity * actual_price;
            Assert.AreEqual(expected, total_price, 21, "Passed");

        }
    }

}
