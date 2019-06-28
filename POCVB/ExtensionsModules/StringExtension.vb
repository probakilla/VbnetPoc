Imports System.Runtime.CompilerServices

Namespace ExtensionModules
    Public Module StringExtension
        Private Const ConstString = "TEST"

        <Extension()>
        Function AddTest(ByVal stringToConcat As String) As String
            Return String.Concat(stringToConcat, ConstString)
        End Function
    End Module
End Namespace