Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports POCVB.Characters
Imports POCVB.State

Namespace PocUnitTesting
    <TestClass>
    Public Class StateTest
        Private Const BaseAtk As Integer = 1
        Private Const SwordAtk As Integer = 10
        Private Const LgSwordAtk As Integer = 25
        Private Const HammerAtk As Integer = 50

        Private Property CharacterFixture As Character
        <TestInitialize>
        Public Sub SetUp()
            CharacterFixture = New Human("Bobby", 90)
        End Sub

        <TestCleanup>
        Public Sub TearDown()
            CharacterFixture = Nothing
        End Sub

        <TestMethod>
        Public Sub TestNoWeaponAtk()
            Assert.AreEqual(BaseAtk, CharacterFixture.Attack)
        End Sub

        <TestMethod>
        Public Sub TestSwordState()
            Dim sword As New Sword()
            CharacterFixture.EquipWeapon(sword)
            Assert.AreEqual(SwordAtk, CharacterFixture.Attack)
        End Sub

        <TestMethod>
        Public Sub TestLgSwordState()
            Dim lgSword As New LongSword()
            CharacterFixture.EquipWeapon(lgSword)
            Assert.AreEqual(LgSwordAtk, CharacterFixture.Attack)
        End Sub

        <TestMethod>
        Public Sub TestHammerState()
            Dim hammer As New Warhammer()
            CharacterFixture.EquipWeapon(hammer)
            Assert.AreEqual(HammerAtk, CharacterFixture.Attack)
        End Sub

        <TestMethod>
        Public Sub TestMultipleChangeState()
            Dim sword As New Sword()
            Dim lgSword As New LongSword()
            Dim hammer As New Warhammer()
            CharacterFixture.EquipWeapon(hammer)
            Assert.AreEqual(HammerAtk, CharacterFixture.Attack)
            CharacterFixture.EquipWeapon(lgSword)
            Assert.AreEqual(LgSwordAtk, CharacterFixture.Attack)
            CharacterFixture.EquipWeapon(sword)
            Assert.AreEqual(SwordAtk, CharacterFixture.Attack)
            CharacterFixture.UnequipWeapon()
            Assert.AreEqual(BaseAtk, CharacterFixture.Attack)
        End Sub
    End Class
End Namespace
