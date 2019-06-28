Imports DesignPatterns.State

Namespace Characters
    Public MustInherit Class AbstractCharacter : Implements Character
        Protected Const BaseDamages As Integer = 1

        Protected Property Name As String
        Protected Property Hp As Integer
        Protected Property Weapon As WeaponState = Nothing

        Public Sub New(name As String, hp As Integer)
            Me.Name = name
            Me.Hp = hp
        End Sub

        Public Function GetHp() As Integer Implements Character.GetHp
            Return Hp
        End Function

        Public Function GetName() As String
            Return Name
        End Function

        Public Function Attack() As Integer Implements Character.Attack
            Return If(Weapon Is Nothing, BaseDamages, Weapon.Attack)
        End Function

        Public Sub EquipWeapon(weapon As WeaponState) Implements Character.EquipWeapon
            Me.Weapon = weapon
        End Sub

        Public Sub UnequipWeapon() Implements Character.UnequipWeapon
            Weapon = Nothing
        End Sub
    End Class
End Namespace