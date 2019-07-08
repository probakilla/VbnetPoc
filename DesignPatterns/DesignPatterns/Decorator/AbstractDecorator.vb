Imports DesignPatterns.Characters
Imports DesignPatterns.State

Namespace Decorator
    Public MustInherit Class AbstractDecorator : Implements ICharacter
        Protected DecoratedCharacter As ICharacter

        Public Sub New(character As ICharacter)
            DecoratedCharacter = character
        End Sub

        Public MustOverride Function GetHp() As Integer Implements ICharacter.GetHp

        Public Function Attack() As Integer Implements ICharacter.Attack
            Return DecoratedCharacter.Attack()
        End Function

        Public Sub EquipWeapon(weapon As WeaponState) Implements ICharacter.EquipWeapon
            DecoratedCharacter.EquipWeapon(weapon)
        End Sub

        Public Sub UnequipWeapon() Implements ICharacter.UnequipWeapon
            DecoratedCharacter.UnequipWeapon()
        End Sub
    End Class
End Namespace
