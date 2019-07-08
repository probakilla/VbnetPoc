Namespace Computer
    Public MustInherit Class AbstractProcessor : Inherits AbstractComputerParts
        Public Sub New(brand As String, price As Integer)
            MyBase.New(brand, price)
        End Sub

        Public Overrides Function GetDescription() As String
            Return "Processor" & vbCrLf & MyBase.GetDescription()
        End Function
    End Class
End Namespace
