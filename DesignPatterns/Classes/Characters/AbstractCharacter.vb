Imports DesignPatterns.State

Namespace Characters
    Public MustInherit Class AbstractCharacter : Implements ICharacter
        Protected Const BaseDamages As Integer = 1

        Protected Name As String
        Protected Hp As Integer
        Protected Weapon As WeaponState = Nothing

        Public Sub New(name As String, hp As Integer)
            Me.Name = name
            Me.Hp = hp
        End Sub

        Public Function GetHp() As Integer Implements ICharacter.GetHp
            Return Hp
        End Function

        Public Function GetName() As String
            Return Name
        End Function

        Public Function Attack() As Integer Implements ICharacter.Attack
            Return If(Weapon Is Nothing, BaseDamages, Weapon.Attack)
        End Function

        Public Sub EquipWeapon(weapon As WeaponState) Implements ICharacter.EquipWeapon
            Me.Weapon = weapon
        End Sub

        Public Sub UnequipWeapon() Implements ICharacter.UnequipWeapon
            Weapon = Nothing
        End Sub
    End Class
End Namespace