Imports control_class
Public Class Modicare
    Public Shared ct As New control_class
    Public Shared objlist As New List(Of cart)
    Shared Sub onlynum(ByRef e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Shared Sub addproduct(code As String, name As String, bv As String, dp As String, ByRef qty As String)
        Try
            Dim objcart As cart = objlist.Find(Function(p) p.name = name)
            If Not objcart Is Nothing Then
                If MsgBox("Old Quantity is " + objcart.qty.ToString + " click yes to plus in old quantity .  click no to replace it", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    objcart.qty += qty
                    qty = objcart.qty
                Else
                    objcart.qty = qty
                End If
            Else
                Dim newobjcart As New cart
                newobjcart.code = code
                newobjcart.name = name
                newobjcart.bv = bv
                newobjcart.dp = dp
                newobjcart.qty += qty
                newobjcart.total = dp * qty
                objlist.Add(newobjcart)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ShoppingCartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShoppingCartToolStripMenuItem.Click
        If Application.OpenForms().OfType(Of product_form).Any Then
            product_form.Close()
        End If
        If Application.OpenForms().OfType(Of shopping).Any Then
            shopping.Focus()
        Else
            shopping.MdiParent = Me
            shopping.Show()
        End If
    End Sub
End Class
