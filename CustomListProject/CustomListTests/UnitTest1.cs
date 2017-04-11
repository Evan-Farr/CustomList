using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_Int() 
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int number = 1;
            int expected = 1;
            //Act
            list.Add(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }

        [TestMethod]
        public void Add_Int2() 
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 5;
            int expected = 5;
            //Act
            list.Add(number);
            //Assert
            Assert.AreEqual(expected, list[4]);
        }

        [TestMethod]
        public void Add_Int_Initializer() 
        {
            //Arrange
            int number = 1;
            int expected = 1;
            //Act
            CustomList<int> list = new CustomList<int>() { number };
            //Assert
            Assert.AreEqual(expected, list[0]);
        }

        [TestMethod]
        public void Add_Int_ToIndexTwo_Initializer() 
        {
            //Arrange
            int number1 = 1;
            int number2 = 2;
            int expected = 2;
            //Act
            CustomList<int> list = new CustomList<int>() { number1, number2 };
            //Assert
            Assert.AreEqual(expected, list[1]);
        }

        [TestMethod]
        public void Add_String() 
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            string team = "packers";
            string expected = "packers";
            //Act
            list.Add(team);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }

        public void Add_string2() 
        {
            //Arrange
            CustomList<string> list = new CustomList<string>() { "vikings", "bears", "lions", "seahawks" };
            string team = "packers";
            string expected = "packers";
            //Act
            list.Add(team);
            //Assert
            Assert.AreEqual(expected, list[4]);
        }

        [TestMethod]
        public void Add_String_Initializer() 
        {
            //Arrange
            string team = "packers";
            string expected = "packers";
            //Act
            CustomList<int> list = new CustomList<int>() { team };
            //Assert
            Assert.AreEqual(expected, list[0]);
        }

        [TestMethod]
        public void Add_String_ToIndexTwo_Initializer()
        {
            //Arrange
            string team1 = "seahawks";
            string team2 = "packers";
            string expected = "packers";
            //Act
            CustomList<int> list = new CustomList<int>() { team1, team2 };
            //Assert
            Assert.AreEqual(expected, list[1]);
        }

        [TestMethod]
        public void Remove_Int()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1 };
            int number = 1;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }

        [TestMethod]
        public void Add_Object()
        {
            //Arrange
            CustomList<CustomObject> list = new CustomList<CustomObject>();
            CustomObject shoe = new CustomObject();
            int expected = 1;
            //Act
            list.Add(shoe);
            //Assert
            Assert.AreEqual(expected, list.Count);
        }

        public void Add_Object2()
        {
            //Arrange
            CustomList<CustomObject> list = new CustomList<CustomObject>();
            CustomObject shoe = new CustomObject();
            //Act
            list.Add(shoe);
            //Assert
            Assert.AreEqual(shoe, list[0]);
        }

        [TestMethod]
        public void IntToString() 
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            
            //Act
            
            //Assert
            Assert.AreEqual();
        }
    }
}
