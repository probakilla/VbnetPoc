﻿Imports POCVB.Characters
Imports POCVB.State

Namespace Decorator
    Public MustInherit Class AbstractDecorator : Implements Character
        Protected Property DecoratedCharacter As Character

        Public Sub New(character As Character)
            DecoratedCharacter = character
        End Sub

        Public MustOverride Function GetHp() As Integer Implements Character.GetHp

        Public Function Attack() As Integer Implements Character.Attack
            DecoratedCharacter.Attack()
        End Function

        Public Sub EquipWeapon(weapon As WeaponState) Implements Character.EquipWeapon
            DecoratedCharacter.EquipWeapon(weapon)
        End Sub

        Public Sub UnequipWeapon() Implements Character.UnequipWeapon
            DecoratedCharacter.UnequipWeapon()
        End Sub
    End Class
End Namespace
