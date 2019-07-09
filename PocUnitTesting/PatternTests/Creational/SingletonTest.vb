Imports DesignPatterns.Singleton
Imports Microsoft.VisualStudio.TestTools.UnitTesting

Namespace DesignPattern.CreationalTest
    <TestClass>
    Public Class SingletonTest
        Private calculator As CalculatorSingleton

        <TestInitialize>
        Public Sub SetUp()
            calculator = CalculatorSingleton.GetInstance
        End Sub

        <TestCleanup>
        Public Sub TearDown()
            calculator = Nothing
        End Sub

        <TestMethod>
        Public Sub TestAddition()
            Dim added = calculator.Addition(1, 1)
            Assert.AreEqual(2, added)
        End Sub

        <TestMethod>
        Public Sub TestSubstraction()
            Dim substracted = calculator.Substraction(1, 1)
            Assert.AreEqual(0, substracted)
        End Sub

        <TestMethod>
        Public Sub TestMultiplication()
            Dim multiplied = calculator.Multiplication(2, 2)
            Assert.AreEqual(4, multiplied)
        End Sub

        <TestMethod>
        Public Sub TestDivision()
            Dim divided = calculator.Division(2, 1)
            Assert.AreEqual(2.0, divided)
        End Sub
    End Class
End Namespace
