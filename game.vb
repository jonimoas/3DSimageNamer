Public Class game
    Dim nam, img, reg As String
    Sub New(ByVal name, ByVal image, ByVal region)
        nam = name
        img = image
        reg = region
    End Sub
    Function getname()
        Return nam
    End Function
    Function getimg()
        Return img
    End Function
    Function getreg()
        Return reg
    End Function
End Class
