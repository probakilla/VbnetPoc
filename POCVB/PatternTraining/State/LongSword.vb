Namespace State
    Public Class LongSword : Inherits AbstractWeapon
        Private Const AttackPower As Integer = 25

        Public Sub New()
            MyBase.New(AttackPower)
        End Sub
    End Class
End Namespace
