Namespace State
    Public Class Sword : Inherits AbstractWeapon
        Private Const AttackPower As Integer = 10

        Public Sub New()
            MyBase.New(AttackPower)
        End Sub
    End Class
End Namespace
