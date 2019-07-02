Imports System.Runtime.CompilerServices
Imports System.Text

Namespace ExtensionModules
    Public Module StringBuilderExtension
        <Extension()>
        Public Sub ClearContent(ByVal strBuilder As StringBuilder)
            strBuilder.Length = 0
        End Sub
    End Module
End Namespace
