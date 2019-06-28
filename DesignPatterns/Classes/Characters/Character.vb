Imports DesignPatterns.State

Namespace Characters
    Public Interface Character
        Function GetHp() As Integer
        Function Attack() As Integer
        Sub EquipWeapon(weapon As WeaponState)
        Sub UnequipWeapon()
    End Interface
End Namespace
