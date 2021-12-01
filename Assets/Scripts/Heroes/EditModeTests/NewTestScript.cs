using Heroes;
using NUnit.Framework;
using UnityEngine;
using System;
using  UnityEngine.TestTools;

namespace Test
{
    public class NewTestScript
    {
        [SetUp]
        public void Setup()
        {
            Debug.Log("SetUP");
        }

        [TearDown]
        public void TearDown()
        {
            Debug.Log("TearDown");
        }

        [Test]
        public void Sum_TheParametersArePositives_ReturnsTheCorrectResult()
        {
            //Arrange
            var calculator = new Calculator();
            //Act
            var result = calculator.Sum(10, 20);
            // Assert 
            Assert.AreEqual(30, result);

        }
        
        [TestCase(10,20,30)]
        [TestCase(30,20,50)]
        [TestCase(0,0,0)]
        public void Sum_TheParametersArePositives_ReturnsTheCorrectResult1(int value1,int value2,int expected)
        {
            //Arrange
            var calculator = new Calculator();
            //Act
            var result = calculator.Sum(value1,value2);
            // Assert 
            Assert.AreEqual(expected, result);

        }
        [TestCase(-10,20)]
        [TestCase(10,-20)]
        public void Sum_AnyParameterIsNegative_ThowsException(int value1, int value2)
        {
            //Arrange
            var calculator = new Calculator();
            
            // Assert 
            Assert
                .Throws<Exception>(() =>
                {
                    //Act
                    var result = calculator.Sum(value1,value2);
                });
        }

        [Test]
        public void NewTestScriptSimplePasses2()
        {

            Debug.Log("2");
        }
       
    }
}