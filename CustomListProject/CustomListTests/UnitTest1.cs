using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CustomList_AddInto_Int()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int number = 1;
            //Act
            list.AddInto(number);
            //Assert
            Assert.AreEqual(number, list[0]);
        }
    }
}
