Namespace Computer
    Public Class AbstractMotherboard : Inherits AbstractComputerParts
        Public Sub New(brand As String, price As Integer)
            MyBase.New(brand, price)
        End Sub

        Public Overrides Function GetDescription() As String
            Return "Motherboard" & vbCrLf & MyBase.GetDescription()
        End Function
    End Class
End Namespace
