Imports home.Modicare

Public Class FRMReview_Cart

    Sub closeSubForm()
        If Application.OpenForms().OfType(Of FormHs).Any Then
            FormHs.Close()
        End If
        If Application.OpenForms().OfType(Of FormSc).Any Then
            FormSc.Close()
        End If

    End Sub
    Private Sub TxtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNo.KeyPress
        onlynum(e)
        If txtNo.TextLength > 10 Then
            e.Handled = True
        End If
    End Sub

    Private Sub FRMReview_Cart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Modicare
        Dim Gtotal As Integer = 0
        Dim TotalBV As Integer = 0
        For Each objtemp As cart In objlist
            DataGridView1.Rows.Add(objtemp.code, objtemp.name, objtemp.dp, objtemp.qty, objtemp.bv, (objtemp.bv * objtemp.qty), objtemp.total)
            Gtotal += objtemp.total
            TotalBV += (objtemp.bv * objtemp.qty)
        Next
        Grand_Total.Text = Gtotal.ToString
        Total_BV.Text = TotalBV
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If txtName.TextLength = 0 Or txtNo.TextLength = 0 Then
            MsgBox("Please Fill Name and Phone Number Field")
        Else
            MsgBox("Bill Saved")
            Me.Close()

            closeSubForm()
            product_form.Close()
            objlist.Clear()

            If MsgBox("Make a new bill?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                shopping.Show()
            Else
                shopping.Close()

            End If
            End If

    End Sub
End Class