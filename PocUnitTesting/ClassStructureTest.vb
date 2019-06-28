Imports ClassVsStructure
Imports Microsoft.VisualStudio.TestTools.UnitTesting

Namespace PocUnitTesting
    ' Class AND Structure members are also set tu Public when no visibility modifier is set
    <TestClass>
    Public Class ClassStructureTest
        <TestMethod>
        Public Sub TestClassDefaultConstructor()
            Dim testClass As New ClassTest()
            Assert.AreEqual(0, testClass.Member)
        End Sub

        <TestMethod>
        Public Sub TestStructureDefaultConstructor()
            Dim testStructure As New StructureTest()
            Assert.AreEqual(0, testStructure.Member)
        End Sub

        <TestMethod>
        Public Sub TestClassEqualOperator()
            ' Class are allocated on heap
            Dim classTest As New ClassTest()
            Dim classCopy = classTest
            ' Change the value of the Member because classCopy is only a reference
            classCopy.Member = 1
            Assert.AreEqual(1, classTest.Member)
        End Sub

        <TestMethod>
        Public Sub TestStructureEqualOperator()
            ' Structures are allocated on stack
            Dim structureTest As New StructureTest()
            Dim structureCopy = structureTest
            ' Don't change the value of Member because structureCopy is a real copy of original object
            structureCopy.Member = 1
            Assert.AreEqual(0, structureTest.Member)
        End Sub
    End Class
End Namespace
