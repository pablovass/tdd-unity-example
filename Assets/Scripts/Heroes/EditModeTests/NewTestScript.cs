using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using TDDProject.Assets.Scripts.Heroes;
using UnityEngine;
using UnityEngine.TestTools;

public class NewTestScript
{
    [SetUp]
    public void SetUp()
    {
        Debug.Log("SetUp");
    }

    [TearDown]
    public void TearDown()
    {
        Debug.Log("TearDown");
    }

    // A Test behaves as an ordinary method
    [Test]
    public void NewTestScriptSimplePasses()
    {
        // Use the Assert class to test conditions
        Debug.Log("1");
    }

    // A Test behaves as an ordinary method
    [Test]
    public void NewTestScriptSimplePasses2()
    {
        // Use the Assert class to test conditions
        Debug.Log("2");
    }
    [Test]
    public void Sume_dos_numeros_Cuando_el_numero_correcto()
    {
        // nombre del metodo 
        //MethodName_WhenTheseCondition_DoesWhat

        //Arrenge 
        var a = 10;
        var b = 20;
        //Act
        var resultado = a + b;
        //assert
        Assert.AreEqual(30,resultado);

    }
    //un solo caso 
    [Test]
    public void Sum_The_ParametersArePositives_ReturnsTheCorrectResult(){
        //arrage
        var calculator= new Calculator();
        //act 
        var result =calculator.Sum(10,20);
       //assert
        Assert.AreEqual(30,result,"mesaje");
    }
    //varios casos
    [TestCase(10,20,30)]
    [TestCase(30,20,50)]
    [TestCase(0,0,0)]
    
    public void Sum_The_ParametersArePositives_ReturnsTheCorrectResult_varios(int value1,int value2,int expected){
        //arrage
        var calculator= new Calculator();
        //act 
        var result =calculator.Sum( value1, value2);
       //assert
        Assert.AreEqual(expected,result,"mesaje");
    }
    //una forma 
    [Test]
    public void Sum_AnyParameterIsNegative_ThowsException(){
       //arrage
        var calculator= new Calculator();

        Assert.Throws<Exception>(
            ()=>
        {
            //
            var result=calculator.Sum(-10,20);
        });
    }
    //segunda forma  
    [TestCase(10,-20)]
    [TestCase(-10,20)]
    public void Sum_AnyParameterIsNegative_ThowsException1(int value1,int value2){
       //arrage
        var calculator= new Calculator();

        Assert.Throws<Exception>(
            ()=>
        {
            //
            var result=calculator.Sum(value1,value2);
        });
    }
}
