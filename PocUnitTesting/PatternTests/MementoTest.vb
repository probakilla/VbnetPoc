Imports DesignPatterns.Memento
Imports Microsoft.VisualStudio.TestTools.UnitTesting

Namespace PocUnitTesting
    <TestClass>
    Public Class MementoTest
        Private Const FIRST = "#1"
        Private Const SECOND = "#2"

        Private Container As StringContainer

        <TestInitialize>
        Public Sub SetUp()
            Container = New StringContainer
        End Sub

        <TestCleanup>
        Public Sub TearDown()
            Container = Nothing
        End Sub

        <TestMethod>
        Public Sub MementoTest()
            Container.State = FIRST
            Assert.AreEqual(Container.State, FIRST)
            Dim firstState = Container.SaveState
            Container.State = SECOND
            Assert.AreEqual(Container.State, SECOND)
            Container.RestoreState(firstState)
            Assert.AreEqual(Container.State, FIRST)
        End Sub
    End Class
End Namespace
