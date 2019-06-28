Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports DesignPatterns.Car
Imports DesignPatterns.Visitor

Namespace PocUnitTesting
    <TestClass>
    Public Class VisitorTest
        Private Property carFixture As Car

        <TestInitialize>
        Public Sub SetUp()
            carFixture = New Car()
        End Sub

        <TestCleanup>
        Public Sub TearDown()
            carFixture = Nothing
        End Sub

        <TestMethod>
        Public Sub TestReduction()
            Assert.AreEqual(2000, carFixture.GetTotalPrice)
            Dim visitor As New ReductionVisitor(0.8)
            carFixture.Accept(visitor)
            Assert.AreEqual(1600, carFixture.GetTotalPrice)
        End Sub

        <TestMethod>
        Public Sub TestAdd()
            Assert.AreEqual(2000, carFixture.GetTotalPrice)
            Dim visitor As New AddPriceVisitor(100)
            carFixture.Accept(visitor)
            Assert.AreEqual(2600, carFixture.GetTotalPrice)
        End Sub

        <TestMethod>
        Public Sub TestFree()
            Assert.AreEqual(2000, carFixture.GetTotalPrice)
            Dim visitor As New FreeCarVisitor()
            carFixture.Accept(visitor)
            Assert.AreEqual(0, carFixture.GetTotalPrice)
        End Sub
    End Class
End Namespace