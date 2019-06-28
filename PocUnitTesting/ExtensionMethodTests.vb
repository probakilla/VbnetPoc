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
    End Class
End Namespace
