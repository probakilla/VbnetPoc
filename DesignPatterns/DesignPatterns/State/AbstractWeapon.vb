Namespace State
    Public MustInherit Class AbstractWeapon : Implements WeaponState
        Private AttackPower As Integer

        Public Sub New(power As Integer)
            AttackPower = power
        End Sub

        Public Function Attack() As Integer Implements WeaponState.Attack
            Return AttackPower
        End Function
    End Class
End Namespace
