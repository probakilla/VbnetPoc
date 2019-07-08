Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports POCVB.ShadowKeyWord

Namespace PocUnitTesting
    <TestClass>
    Public Class ShadowTest
        <TestMethod>
        Public Sub TestShadowClasses()
            Dim derived = New DerivedClass()
            Dim base = New BaseClass()
            Assert.AreEqual(1, derived.ShadowedMember)
            Assert.AreEqual(0, base.ShadowedMember)
        End Sub
    End Class
End Namespace
