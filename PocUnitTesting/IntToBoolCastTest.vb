Imports Microsoft.VisualStudio.TestTools.UnitTesting

Namespace PocUnitTesting
    <TestClass>
    Public Class IntToBoolCastTest
        <TestMethod>
        Public Sub TestZero()
            Dim int As Integer = 0
            Assert.IsFalse(CBool(int))
        End Sub

        Public Sub TestOne()
            Dim int As Integer = 1
            Assert.IsTrue(CBool(int))
        End Sub

        Public Sub TestPositive()
            Dim int As Integer = 6
            Assert.IsTrue(CBool(int))
        End Sub

        Public Sub TestNegative()
            Dim int As Integer = -6
            Assert.IsFalse(CBool(int))
        End Sub
    End Class
End Namespace
