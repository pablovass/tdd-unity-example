using Heroes;
using NUnit.Framework;
using UnityEngine;
using System;
using NSubstitute;
using  UnityEngine.TestTools;

namespace Test
{
    public class NewTestScript
    {
        private ILog logSubstitute;
        private Calculator calculator;
        [SetUp]
        public void Setup()
        {
            logSubstitute = Substitute.For<ILog>();
            calculator = new Calculator(logSubstitute);
        }

        [TearDown]
        public void TearDown() {}

        
        [TestCase(10,20,30)]
        [TestCase(30,20,50)]
        [TestCase(0,0,0)]
        public void Sum_TheParametersArePositives_ReturnsTheCorrectResult1(int value1,int value2,int expected)
        {
            //Arrange
            
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
            
            // Assert 
            Assert
                .Throws<Exception>(() =>
                {
                    //Act
                    var result = calculator.Sum(value1,value2);
                });
        }

      
        [TestCase(10,20,30)]
        [TestCase(2,1,3)]
        [TestCase(0,0,0)]
        public void Sum_theParameterPositive_WriteTheResultOnLog(int value1,int value2, int result)
        {
            //arrange
            
            //Act
            calculator.Sum(value1, value2);
            //Assert
           //logSubstitute.Received().Log($"{value1} + {value2} = {result} ");
           logSubstitute.Received().Log(Arg.Is<string>(s => s.Contains(result.ToString())));
        }

        [Test]
        public void TestCount()
        {
            //logSubstitute.Count().Returns(33);
            logSubstitute.Count().Returns(info =>
            {
                //toda la logica 
                Debug.Log("logica");
                return 123;
            } );
            Debug.Log(logSubstitute.Count());
        }
    }
}