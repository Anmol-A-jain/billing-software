Public  Class control_class
    Private category_name As String
    Public Function current_category()
        Return category_name
    End Function
    Public Sub current_category(ByVal name As String)
        Me.category_name = name
    End Sub
End Class

Public Class cart
    Public code, name As String
    Public bv, dp, qty, total As Integer

End Class