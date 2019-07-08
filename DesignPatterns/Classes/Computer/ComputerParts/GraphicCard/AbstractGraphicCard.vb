Namespace Computer
    Public MustInherit Class AbstractGraphicCard : Inherits AbstractComputerParts
        Public Sub New(brand As String, price As Integer)
            MyBase.New(brand, price)
        End Sub

        Public Overrides Function GetDescription() As String
            Return "Graphic Card" & vbCrLf & MyBase.GetDescription()
        End Function
    End Class
End Namespace
