﻿Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports POCVB.Characters
Imports POCVB.Decorator

Namespace PocUnitTesting
    <TestClass>
    Public Class DecoratorTest
        Private Property CharacterFixture As Character
        Private Const BaseHp As Integer = 100

        <TestInitialize>
        Public Sub SetUp()
            CharacterFixture = New Orc("Billy", BaseHp)
        End Sub

        <TestCleanup>
        Public Sub TearDown()
            CharacterFixture = Nothing
        End Sub

        <TestMethod>
        Public Sub TestBuffOneTime()
            Assert.AreEqual(BaseHp, CharacterFixture.GetHp)
            Dim buffAmount As Integer = 50
            CharacterFixture = New BuffedCharacter(CharacterFixture, buffAmount)
            Assert.AreEqual(BaseHp + buffAmount, CharacterFixture.GetHp)
        End Sub

        <TestMethod>
        Public Sub TestBuffMultipleTimes()
            Assert.AreEqual(BaseHp, CharacterFixture.GetHp)
            Dim buffAmount As Integer = 60
            CharacterFixture = New BuffedCharacter(CharacterFixture, buffAmount)
            CharacterFixture = New BuffedCharacter(CharacterFixture, buffAmount)
            CharacterFixture = New BuffedCharacter(CharacterFixture, buffAmount)
            CharacterFixture = New BuffedCharacter(CharacterFixture, buffAmount)
            Dim expectedTotalHp = BaseHp + (60 * 4)
            Assert.AreEqual(CharacterFixture.GetHp, expectedTotalHp)
        End Sub
    End Class
End Namespace
