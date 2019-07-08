Imports DesignPatterns.Characters

Namespace Decorator
    Public Class BuffedCharacter : Inherits AbstractDecorator
        Private HpBuff As Integer

        Public Sub New(character As ICharacter, hpBuff As Integer)
            MyBase.New(character)
            Me.HpBuff = hpBuff
        End Sub

        Public Overrides Function GetHp() As Integer
            Dim hp As Integer = DecoratedCharacter.GetHp()
            Return hp + HpBuff
        End Function
    End Class
End Namespace
