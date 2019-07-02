Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports POCVB.ExtensionModules

Namespace PocUnitTesting
    <TestClass>
    Public Class ExtensionMethodTests
        Private Const TestString = "TEST"
        <TestMethod>
        Sub TestContatTest()
            Dim str As String = "hello"
            Assert.AreEqual(str & TestString, str.AddTest())
        End Sub

        <TestMethod>
        Public Sub TestStringBuilder()
            Dim strBuilder As New StringBuilder(TestString)
            Assert.AreEqual(4, strBuilder.Length)
            strBuilder.ClearContent
            Assert.AreEqual(0, strBuilder.Length)
        End Sub
    End Class
End Namespace
