Imports System.Text

Namespace Computer
    Public MustInherit Class AbstractComputerParts : Implements IComputerPart
        Protected Const AMD_BRAND As String = "AMD"
        Protected Const INTEL_BRAND As String = "Intel"
        Protected Const MSI_BRAND = "MSI"
        Protected Const ASUS_BRAND = "ASUS"

        Private _brand As String
        Private _price As Integer

        Public Property BrandName As String
            Get
                Return _brand
            End Get
            Protected Set(value As String)
                _brand = value
            End Set
        End Property

        Public Property Price As Integer
            Get
                Return _price
            End Get
            Protected Set(value As Integer)
                _price = value
            End Set
        End Property

        Public Sub New(brand As String, price As Integer)
            BrandName = brand
            Me.Price = price
        End Sub

        Public Overridable Function GetDescription() As String Implements IComputerPart.GetDescription
            Dim strBuilder As New StringBuilder()
            strBuilder.Append("Brand: ").Append(BrandName).AppendLine()
            strBuilder.Append("Price: ").Append(Price.ToString).AppendLine()
            Return strBuilder.ToString
        End Function
    End Class
End Namespace
