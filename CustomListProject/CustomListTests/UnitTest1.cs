using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class UnitTest1
    {
        //Here Down are all the add and remove tests.

        [TestMethod]
        public void Add_Int_Count()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int number = 1;
            int expected = 1;
            //Act
            list.Add(number);
            //Assert
            Assert.AreEqual(expected, list.Count);
        }

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
        public void Add_Int3()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 5;
            int expected = 1;
            //Act
            list.Add(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }

        [TestMethod]
        public void Add_Int4()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 5;
            int expected = 4;
            //Act
            list.Add(number);
            //Assert
            Assert.AreEqual(expected, list[3]);
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
        public void Add_Int_Initializer_Count()
        {
            //Arrange
            int number = 1;
            int expected = 1;
            //Act
            CustomList<int> list = new CustomList<int>() { number };
            //Assert
            Assert.AreEqual(expected, list.Count);
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
        public void Add_Int_ToIndexTwo_Initializer_Count()
        {
            //Arrange
            int number1 = 1;
            int number2 = 2;
            int expected = 2;
            //Act
            CustomList<int> list = new CustomList<int>() { number1, number2 };
            //Assert
            Assert.AreEqual(expected, list.Count);
        }

        [TestMethod]
        public void Add_Int_ToIndexTwo_Initializer2()
        {
            //Arrange
            int number1 = 1;
            int number2 = 2;
            int expected = 1;
            //Act
            CustomList<int> list = new CustomList<int>() { number1, number2 };
            //Assert
            Assert.AreEqual(expected, list[0]);
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

        [TestMethod]
        public void Add_String_Count()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            string team = "packers";
            int expected = 1;
            //Act
            list.Add(team);
            //Assert
            Assert.AreEqual(expected, list.Count);
        }

        [TestMethod]
        public void Add_String2()
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
        public void Add_String3()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>() { "vikings", "bears", "lions", "seahawks" };
            string team = "packers";
            string expected = "vikings";
            //Act
            list.Add(team);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }

        [TestMethod]
        public void Add_String4()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>() { "vikings", "bears", "lions", "seahawks" };
            string team = "packers";
            string expected = "seahawks";
            //Act
            list.Add(team);
            //Assert
            Assert.AreEqual(expected, list[3]);
        }

        [TestMethod]
        public void Add_String_Initializer_Count()
        {
            //Arrange
            string team = "packers";
            int expected = 1;
            //Act
            CustomList<string> list = new CustomList<string>() { team };
            //Assert
            Assert.AreEqual(expected, list.Count);
        }

        [TestMethod]
        public void Add_String_Initializer()
        {
            //Arrange
            string team = "packers";
            string expected = "packers";
            //Act
            CustomList<string> list = new CustomList<string>() { team };
            //Assert
            Assert.AreEqual(expected, list[0]);
        }

        [TestMethod]
        public void Add_String_ToIndexTwo_Initializer_Count()
        {
            //Arrange
            string team1 = "seahawks";
            string team2 = "packers";
            int expected = 2;
            //Act
            CustomList<string> list = new CustomList<string>() { team1, team2 };
            //Assert
            Assert.AreEqual(expected, list.Count);
        }

        [TestMethod]
        public void Add_String_ToIndexTwo_Initializer()
        {
            //Arrange
            string team1 = "seahawks";
            string team2 = "packers";
            string expected = "packers";
            //Act
            CustomList<string> list = new CustomList<string>() { team1, team2 };
            //Assert
            Assert.AreEqual(expected, list[1]);
        }

        [TestMethod]
        public void Add_String_ToIndexTwo_Initializer2()
        {
            //Arrange
            string team1 = "seahawks";
            string team2 = "packers";
            string expected = "seahawks";
            //Act
            CustomList<string> list = new CustomList<string>() { team1, team2 };
            //Assert
            Assert.AreEqual(expected, list[0]);
        }

        [TestMethod]
        public void Add_Object_Count()
        {
            //Arrange
            CustomList<CustomObject> list = new CustomList<CustomObject>();
            CustomObject object1 = new CustomObject();
            int expected = 1;
            //Act
            list.Add(object1);
            //Assert
            Assert.AreEqual(expected, list.Count);
        }

        [TestMethod]
        public void Add_Object()
        {
            //Arrange
            CustomList<CustomObject> list = new CustomList<CustomObject>();
            CustomObject object1 = new CustomObject();
            //Act
            list.Add(object1);
            //Assert
            Assert.AreEqual(object1, list[0]);
        }

        [TestMethod]
        public void Add_Object1()
        {
            //Arrange
            CustomObject object1 = new CustomObject();
            CustomObject object2 = new CustomObject();
            CustomObject object3 = new CustomObject();
            CustomList<CustomObject> list = new CustomList<CustomObject>() { object1, object2 };
            //Act
            list.Add(object3);
            //Assert
            Assert.AreEqual(object1, list[0]);
        }

        [TestMethod]
        public void Add_Object2()
        {
            //Arrange
            CustomObject object1 = new CustomObject();
            CustomObject object2 = new CustomObject();
            CustomObject object3 = new CustomObject();
            CustomList<CustomObject> list = new CustomList<CustomObject>() { object1, object2 };
            //Act
            list.Add(object3);
            //Assert
            Assert.AreEqual(object3, list[2]);
        }

        [TestMethod]
        public void Add_Object3()
        {
            //Arrange
            CustomObject object1 = new CustomObject();
            CustomObject object2 = new CustomObject();
            CustomObject object3 = new CustomObject();
            CustomList<CustomObject> list = new CustomList<CustomObject>() { object1, object2 };
            //Act
            list.Add(object3);
            //Assert
            Assert.AreEqual(object2, list[1]);
        }

        [TestMethod]
        public void Remove_Int_Count()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1 };
            int number = 1;
            int expected = 0;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list.Count);
        }

        [TestMethod]
        public void Remove_Int_Count2()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 1;
            int expected = 3;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list.Count);
        }

        [TestMethod]
        public void Remove_Int2()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 1;
            int expected = 2;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }

        [TestMethod]
        public void Remove_Int3()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 1;
            int expected = 4;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[2]);
        }

        [TestMethod]
        public void Remove_Int4()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 3;
            int expected = 4;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[2]);
        }

        [TestMethod]
        public void Remove_Int5()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 3;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }

        [TestMethod]
        public void Remove_String_Count()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>() { "packers" };
            string team = "packers";
            int expected = 0;
            //Act
            list.Remove(team);
            //Assert
            Assert.AreEqual(expected, list.Count);
        }

        [TestMethod]
        public void Remove_String_Count2()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>() { "vikings", "bears", "lions", "packers" };
            string team = "packers";
            int expected = 3;
            //Act
            list.Remove(team);
            //Assert
            Assert.AreEqual(expected, list.Count);
        }

        [TestMethod]
        public void Remove_String()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>() { "vikings", "packers", "lions", "seahawks" };
            string team = "packers";
            string expected = "vikings";
            //Act
            list.Remove(team);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }

        [TestMethod]
        public void Remove_String2()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>() { "vikings", "packers", "lions", "seahawks" };
            string team = "packers";
            string expected = "lions";
            //Act
            list.Remove(team);
            //Assert
            Assert.AreEqual(expected, list[1]);
        }

        [TestMethod]
        public void Remove_String3()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>() { "vikings", "packers", "lions", "seahawks" };
            string team = "packers";
            string expected = "seahawks";
            //Act
            list.Remove(team);
            //Assert
            Assert.AreEqual(expected, list[2]);
        }

        [TestMethod]
        public void Remove_Object_Count()
        {
            //Arrange
            CustomObject object1 = new CustomObject();
            CustomList<CustomObject> list = new CustomList<CustomObject>() { object1 };
            int expected = 0;
            //Act
            list.Remove(object1);
            //Assert
            Assert.AreEqual(expected, list.Count);
        }

        [TestMethod]
        public void Remove_Object_Count2()
        {
            //Arrange
            CustomObject object1 = new CustomObject();
            CustomObject object2 = new CustomObject();
            CustomObject object3 = new CustomObject();
            CustomList<CustomObject> list = new CustomList<CustomObject>() { object1, object2, object3 };
            int expected = 2;
            //Act
            list.Remove(object2);
            //Assert
            Assert.AreEqual(expected, list.Count);
        }

        [TestMethod]
        public void Remove_Object()
        {
            //Arrange
            CustomObject object1 = new CustomObject();
            CustomObject object2 = new CustomObject();
            CustomObject object3 = new CustomObject();
            CustomList<CustomObject> list = new CustomList<CustomObject>() { object1, object2, object3 };
            //Act
            list.Remove(object2);
            //Assert
            Assert.AreEqual(object3, list[1]);
        }

        [TestMethod]
        public void Remove_Object2()
        {
            //Arrange
            CustomObject object1 = new CustomObject();
            CustomObject object2 = new CustomObject();
            CustomObject object3 = new CustomObject();
            CustomList<CustomObject> list = new CustomList<CustomObject>() { object1, object2, object3 };
            //Act
            list.Remove(object1);
            //Assert
            Assert.AreEqual(object2, list[0]);
        }

        [TestMethod]
        public void Remove_Object3()
        {
            //Arrange
            CustomObject object1 = new CustomObject();
            CustomObject object2 = new CustomObject();
            CustomObject object3 = new CustomObject();
            CustomList<CustomObject> list = new CustomList<CustomObject>() { object1, object2, object3 };
            //Act
            list.Remove(object1);
            //Assert
            Assert.AreEqual(object3, list[1]);
        }

        [TestMethod]
        public void Remove_Object4()
        {
            //Arrange
            CustomObject object1 = new CustomObject();
            CustomObject object2 = new CustomObject();
            CustomObject object3 = new CustomObject();
            CustomList<CustomObject> list = new CustomList<CustomObject>() { object1, object2, object3 };
            //Act
            list.Remove(object3);
            //Assert
            Assert.AreEqual(object2, list[1]);
        }

        [TestMethod]
        public void Remove_Object5()
        {
            //Arrange
            CustomObject object1 = new CustomObject();
            CustomObject object2 = new CustomObject();
            CustomObject object3 = new CustomObject();
            CustomList<CustomObject> list = new CustomList<CustomObject>() { object1, object2, object3 };
            //Act
            list.Remove(object3);
            //Assert
            Assert.AreEqual(object1, list[0]);
        }

        //// Here Down are Count Tests (they have nothing to do with add or remove).

        [TestMethod]
        public void Count_CustomObject()
        {
            //Arrange
            CustomObject object1 = new CustomObject();
            CustomObject object2 = new CustomObject();
            CustomObject object3 = new CustomObject();
            CustomList<CustomObject> list = new CustomList<CustomObject>() { object1, object2, object3 };
            int expected = 3;
            //Act

            //Assert
            Assert.AreEqual(expected, list.Count);
        }

        [TestMethod]
        public void Count_Int()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);
            int expected = 7;
            //Act

            //Assert
            Assert.AreEqual(expected, list.Count);
        }

        [TestMethod]
        public void Count_String()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>() { "hello", "goodbye", "shalome", "adios" };
            int expected = 4;
            //Act

            //Assert
            Assert.AreEqual(expected, list.Count);
        }

        ////Here Down are ToString Tests.

        [TestMethod]
        public void Override_ToString_String()
        {
            //Arrange
            CustomList<string> greetings = new CustomList<string>() { "hello", "goodbye", "shalome", "adios" };
            string expected = "hello\ngoodbye\nshalome\nadios\n";
            //Act
            string result = greetings.ToString();
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Override_ToString_Int()
        {
            //Arrange
            CustomList<int> numbers = new CustomList<int>() { 1, 3, 5, 3, 2, 5, 2 };
            string expected = "1\n3\n5\n3\n2\n5\n2\n";
            //Act
            string result = numbers.ToString();
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Override_ToString_Objects()
        {
            //Arrange
            CustomObject object1 = new CustomObject();
            CustomObject object2 = new CustomObject();
            CustomObject object3 = new CustomObject();
            CustomObject object4 = new CustomObject();
            CustomList<CustomObject> objects = new CustomList<CustomObject>() { object1, object2, object3, object4 };
            string expected = $"{object1}\n{object2}\n{object3}\n{object4}\n";
            //Act
            string result = objects.ToString();
            //Assert
            Assert.AreEqual(expected, result);
        }

        //Here Down are zip tests.

        [TestMethod]
        public void Zip_Objects()
        {
            //Arrange
            CustomObject object1 = new CustomObject();
            CustomObject object2 = new CustomObject();
            CustomObject object3 = new CustomObject();
            CustomObject object4 = new CustomObject();
            CustomList<CustomObject> objectsOdd = new CustomList<CustomObject>() { object1, object3, };
            CustomList<CustomObject> objectsEven = new CustomList<CustomObject>() { object2, object4 };
            CustomList<CustomObject> expected = new CustomList<CustomObject>() { object1, object2, object3, object4 };
            //Act
            CustomList<CustomObject> result = objectsOdd.ZipTo(objectsEven);
            //Assert
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod]
        public void Zip_Int()
        {
            //Arrange
            CustomList<int> odds = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> evens = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> expected = new CustomList<int>() { 1, 2, 3, 4, 5, 6 };
            //Act
            CustomList<int> result = odds.ZipTo(evens);
            //Assert
            for(int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod]
        public void Zip_Int2()
        {
            //Arrange
            CustomList<int> odds = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> evens = new CustomList<int>() { };
            CustomList<int> expected = new CustomList<int>() { };
            //Act
            CustomList<int> result = odds.ZipTo(evens);
            //Assert
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod]
        public void Zip_Int3()
        {
            //Arrange
            CustomList<int> odds = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> evens = new CustomList<int>() { 1, 3, 5, 1, 3, 5, 1, 3, 5, 1, 3, 5 };
            CustomList<int> expected = new CustomList<int>() { 1, 1, 3, 3, 5, 5 };
            //Act
            CustomList<int> result = evens.ZipTo(odds);
            //Assert
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod]
        public void Zip_String()
        {
            //Arrange
            CustomList<string> greetings = new CustomList<string>() { "Hello", "Hola", "Sup" };
            CustomList<string> goodbyes = new CustomList<string>() { "GoodBye", "Adios", "Cya" };
            CustomList<string> expected = new CustomList<string>() { "Hello", "GoodBye", "Hola", "Adios", "Sup", "Cya" };
            //Act
            CustomList<string> result = greetings.ZipTo(goodbyes);
            //Assert
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        ////Here Down are Overloading + operator tests

        [TestMethod]
        public void OverLoad_Plus_Int()
        {
            //Arrange
            CustomList<int> firstList = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> secondList = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> expected = new CustomList<int>() { 1, 3, 5, 2, 4, 6 };
            //Act
            CustomList<int> result = firstList + secondList;
            //Assert
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod]
        public void OverLoad_Plus_String()
        {
            //Arrange
            CustomList<string> firstList = new CustomList<string>() { "Hello", "Hola", "Sup" };
            CustomList<string> secondList = new CustomList<string>() { "GoodBye", "Adios", "Cya" };
            CustomList<string> expected = new CustomList<string>() { "Hello", "Hola", "Sup", "GoodBye", "Adios", "Cya" };
            //Act
            CustomList<string> result = firstList + secondList;
            //Assert
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod]
        public void OverLoad_Plus_Object()
        {
            //Arrange
            CustomObject object1 = new CustomObject();
            CustomObject object2 = new CustomObject();
            CustomObject object3 = new CustomObject();
            CustomObject object4 = new CustomObject();
            CustomList<CustomObject> firstList = new CustomList<CustomObject>() { object1, object3, };
            CustomList<CustomObject> secondList = new CustomList<CustomObject>() { object2, object4 };
            CustomList<CustomObject> expected = new CustomList<CustomObject>() { object1, object3, object2, object4 };
            //Act
            CustomList<CustomObject> result = firstList + secondList;
            //Assert
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        //Here Down are Overloading - operator tests

        [TestMethod]
        public void OverLoad_Minus_Int()
        {
            //Arrange
            CustomList<int> firstList = new CustomList<int>() { 1, 2, 4 };
            CustomList<int> secondList = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> expected = new CustomList<int>() { 1 };
            //Act
            CustomList<int> result = firstList - secondList;
            //Assert
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod]
        public void OverLoad_Minus_String()
        {
            //Arrange
            CustomList<string> firstList = new CustomList<string>() { "Hello", "Hola", "Cya" };
            CustomList<string> secondList = new CustomList<string>() { "Hello", "Cya" };
            CustomList<string> expected = new CustomList<string>() { "Hola" };
            //Act
            CustomList<string> result = firstList - secondList;
            //Assert
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod]
        public void OverLoad_Minus_Object()
        {
            //Arrange
            CustomObject object1 = new CustomObject();
            CustomObject object2 = new CustomObject();
            CustomObject object3 = new CustomObject();
            CustomObject object4 = new CustomObject();
            CustomList<CustomObject> firstList = new CustomList<CustomObject>() { object1, object3, object2 };
            CustomList<CustomObject> secondList = new CustomList<CustomObject>() { object2, object4 };
            CustomList<CustomObject> expected = new CustomList<CustomObject>() { object1, object3 };
            //Act
            CustomList<CustomObject> result = firstList - secondList;
            //Assert
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        //Here Down are indexer tests.

        //[TestMethod]
        //public void Indexer()
        //{
        //    //Arrange
        //    CustomObject object1 = new CustomObject();
        //    CustomObject object2 = new CustomObject();
        //    CustomObject object3 = new CustomObject();
        //    CustomList<CustomObject> list = new CustomList<CustomObject>() { object1, object2 };
        //    //Act

        //    //Assert
        //    Assert.;
        //}
    }
}