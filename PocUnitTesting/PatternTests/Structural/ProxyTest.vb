Imports DesignPatterns.Connection
Imports DesignPatterns.Proxy
Imports Microsoft.VisualStudio.TestTools.UnitTesting

Namespace DesignPattern.StructuralTest
    <TestClass>
    Public Class ProxyTest
        Private Proxy As IConnection

        <TestInitialize>
        Public Sub SetUp()
            Proxy = New ProxyConnection()
        End Sub

        <TestCleanup>
        Public Sub TearDown()
            Proxy = Nothing
        End Sub

        <TestMethod>
        Public Sub TestAuthorizedConnection()
            Dim result = Proxy.ConnectTo("yes.com")
            Assert.AreEqual("Connecting to: yes.com", result)
        End Sub

        <TestMethod>
        Public Sub TestUnauthorizedConnection()
            Dim result = Proxy.ConnectTo("banned.com")
            Assert.AreEqual("DENIED", result)
        End Sub
    End Class
End Namespace
