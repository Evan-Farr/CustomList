using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddOneInt() //can I add one int into the list, and is it at spot 0?
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int number = 1;
            //Act
            list.Add(number);
            //Assert
            Assert.AreEqual(number, list[0]);
        }

        [TestMethod]
        public void AddOneInt2() //can I add one int into already populated list, and is it at last index?
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 5;
            //Act
            list.Add(number);
            //Assert
            Assert.AreEqual(number, list[4]);
        }

        [TestMethod]
        public void AddOneInt_Initializer() //can I add one int into the list using initializer?
        {
            //Arrange
            int number = 1;
            //Act
            CustomList<int> list = new CustomList<int>() { number };
            //Assert
            Assert.AreEqual(number, list[0]);
        }

        [TestMethod]
        public void AddIntToIndexTwo_Initializer() //can I add two ints into the list, and each be in their own spot in order I pass them in using initializer?
        {
            //Arrange
            int number1 = 1;
            int number2 = 2;
            //Act
            CustomList<int> list = new CustomList<int>() { number1, number2 };
            //Assert
            Assert.AreEqual(number2, list[1]);
        }

        [TestMethod]
        public void IntToString() //can I convert int to string?
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int number = 1;
            //Act
            list.Add(number);
            //Assert
            Assert.AreEqual(number, list[0]);
        }
    }
}
