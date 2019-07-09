Imports System.Text
Imports DesignPatterns.Observer
Imports Microsoft.VisualStudio.TestTools.UnitTesting

Namespace DesignPattern.BehaviouralTest
    <TestClass>
    Public Class ObserverTest
        Private Const NUMBER As Integer = 12345
        Private ReadOnly BIN_NUM As String = Convert.ToString(NUMBER, 2).PadLeft(32, "0"c)
        Private ReadOnly OCT_NUM As String = Convert.ToString(NUMBER, 8)
        Private ReadOnly HEX_NUM As String = Convert.ToString(NUMBER, 16)

        <TestMethod>
        Public Sub ObserverTest()
            Dim subject = New Subject
            Dim binary = New BinaryObserver(subject)
            Dim octal = New OctalObserver(subject)
            Dim hexa = New HexaObserver(subject)
            Dim result = subject.SetState(NUMBER)
            Dim strBuilder = New StringBuilder
            strBuilder.Append(String.Format("Bin: {0}", BIN_NUM)).AppendLine _
                .Append(String.Format("Oct: {0}", OCT_NUM)).AppendLine _
                .Append(String.Format("Hex: {0}", HEX_NUM)).AppendLine()
            Assert.AreEqual(result, strBuilder.ToString)
        End Sub
    End Class
End Namespace
