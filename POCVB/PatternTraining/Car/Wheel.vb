Imports POCVB.Visitor

Namespace Car
    Public Class Wheel : Inherits AbstractCarElement
        Private Property Name As String

        Public Sub New(name As String, price As Integer)
            MyBase.New(price)
            Me.Name = name
        End Sub

        Public Function GetName() As String
            Return Name
        End Function
    End Class
End Namespace