using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CustomList_AddOneInt() //can I add one int into the list, and is it at spot 0?
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
        public void CustomList_AddOneInt_Initializer() //can I add one int into the list using initializer?
        {
            //Arrange
            int number = 1;
            //Act
            CustomList<int> list = new CustomList<int>() { number };
            //Assert
            Assert.AreEqual(number, list[0]);
        }

        [TestMethod]
        public void CustomList_AddIntToIndexTwo_Initializer() //can I add two ints into the list, and each be in their own spot in order I pass them in using initializer?
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
        public void CustomList_AddOneIntAndOneString() //can I add a string into a list of int?
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
