Imports home.Modicare
Public Class product_form

    Sub default_color()
        HealthCareToolStripMenuItem.BackColor = Color.Aqua
        SkinCareToolStripMenuItem.BackColor = Color.Aqua
    End Sub

    Sub closeSubForm()
        If Application.OpenForms().OfType(Of FormHs).Any Then
            FormHs.Close()
        End If
        If Application.OpenForms().OfType(Of FormSc).Any Then
            FormSc.Close()
        End If
        If Application.OpenForms().OfType(Of FRMReview_Cart).Any Then
            FRMReview_Cart.Close()
        End If

    End Sub

    Private Sub Product_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        If ct.current_category = "hs" Then
            HealthCareToolStripMenuItem_Click(sender, e)
        End If
        If ct.current_category = "sc" Then
            SkinCareToolStripMenuItem_Click(sender, e)
        End If


    End Sub

    Private Sub HealthCareToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HealthCareToolStripMenuItem.Click

        closeSubForm()
        default_color()

        ct.current_category("hs")
        HealthCareToolStripMenuItem.BackColor = Color.Silver

        FormHs.TopLevel = False
        Me.Panel1.Controls.Add(FormHs)
        FormHs.Show()

    End Sub



    Private Sub SkinCareToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SkinCareToolStripMenuItem.Click
        closeSubForm()
        default_color()

        ct.current_category("sc")
        SkinCareToolStripMenuItem.BackColor = Color.Silver
        FormSc.TopLevel = False
        Me.Panel1.Controls.Add(FormSc)
        FormSc.Show()

    End Sub



    Private Sub OpenCartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenCartToolStripMenuItem.Click
        If Not objlist.Count = 0 Then
            'FRMReview_Cart.TopMost = True
            FRMReview_Cart.Show()

        Else
            MsgBox("Cart Is empty")
        End If
    End Sub
End Class