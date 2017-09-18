Imports System.IO

Module filelistbuilder
    Function main(ByVal folder)
        Dim filename As String() = Directory.GetFiles(folder)
        Return filename
    End Function
End Module
