Namespace Prototype
    Public Class Liquid : Implements ICloneable
        Public Name As String

        Public Sub New(name As String)
            Me.Name = name
        End Sub

        Public Function Clone() As Object Implements ICloneable.Clone
            Return MemberwiseClone()
        End Function
    End Class

    Public Class Bottle : Implements ICloneable
        Public Content As Liquid

        Public Sub New(liquid As Liquid)
            Content = liquid
        End Sub

        Public Function Clone() As Object Implements ICloneable.Clone
            Return New Bottle(CType(Content.Clone(), Liquid))
        End Function
    End Class
End Namespace