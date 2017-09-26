Imports System.IO
Imports System.Text.RegularExpressions

Public Class Form1
    Dim gamelist As ArrayList
    Dim folder As String
    Dim files As String()
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpenFileDialog1.ShowDialog()
        folder = FolderBrowserDialog1.SelectedPath
        files = filelistbuilder.main(folder)
        rename()
        Close()
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        gamelist = gamelistbuilder.Main(OpenFileDialog1.FileName)
        FolderBrowserDialog1.ShowDialog()
    End Sub
    Private Sub rename()
        For Each g In gamelist
            For Each f In files
                If g.getimg().ToString.ToLower & ".3ds" = Path.GetFileName(f).ToLower Then
                    Try
                        Dim gamename As String = Regex.Replace(g.getname(), "[^A-Za-z0-9]", " - ")
                        My.Computer.FileSystem.RenameFile(f, gamename & " (" & g.getreg() & ")" & ".3ds")
                    Catch e As Exception
                        MsgBox(e.ToString)
                    End Try
                End If
            Next
        Next
    End Sub
End Class
