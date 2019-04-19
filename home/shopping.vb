Imports System.ComponentModel
Imports home.Modicare

Public Class shopping


    Private Sub Button1_GotFocus(sender As Object, e As EventArgs) Handles btnhc.GotFocus
        Label1.ForeColor = Color.Red
    End Sub

    Private Sub Button2_GotFocus(sender As Object, e As EventArgs) Handles Button2.GotFocus
        Label2.ForeColor = Color.Red
    End Sub

    Private Sub Button1_LostFocus(sender As Object, e As EventArgs) Handles btnhc.LostFocus
        Label1.ForeColor = Color.Black
    End Sub

    Private Sub Button2_LostFocus(sender As Object, e As EventArgs) Handles Button2.LostFocus
        Label2.ForeColor = Color.Black
    End Sub


    Private Sub shopping_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If MsgBox("Do You Want To Exit From Shopping Cart", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If Application.OpenForms().OfType(Of product_form).Any Then
                product_form.Close()
            End If
            e.Cancel = False

        Else

            e.Cancel = True
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Close()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        txt_search.Focus()
    End Sub

    Private Sub Shopping_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Btnhc_Click(sender As Object, e As EventArgs) Handles btnhc.Click
        ct.current_category("hs")
        If Application.OpenForms().OfType(Of product_form).Any Then
            product_form.Focus()
        End If

        product_form.MdiParent = Modicare
        product_form.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ct.current_category("sc")
        If Application.OpenForms().OfType(Of product_form).Any Then
            product_form.Focus()
        End If

        product_form.MdiParent = Modicare
        product_form.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        ct.current_category("uc")
        If Application.OpenForms().OfType(Of product_form).Any Then
            product_form.Focus()
        End If

        product_form.MdiParent = Modicare
        product_form.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        ct.current_category("pc")
        If Application.OpenForms().OfType(Of product_form).Any Then
            product_form.Focus()
        End If

        product_form.MdiParent = Modicare
        product_form.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        ct.current_category("hc")
        If Application.OpenForms().OfType(Of product_form).Any Then
            product_form.Focus()
        End If

        product_form.MdiParent = Modicare
        product_form.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        ct.current_category("lc")
        If Application.OpenForms().OfType(Of product_form).Any Then
            product_form.Focus()
        End If

        product_form.MdiParent = Modicare
        product_form.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        ct.current_category("fp")
        If Application.OpenForms().OfType(Of product_form).Any Then
            product_form.Focus()
        End If

        product_form.MdiParent = Modicare
        product_form.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        ct.current_category("ag")
        If Application.OpenForms().OfType(Of product_form).Any Then
            product_form.Focus()
        End If

        product_form.MdiParent = Modicare
        product_form.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        ct.current_category("ac")
        If Application.OpenForms().OfType(Of product_form).Any Then
            product_form.Focus()
        End If

        product_form.MdiParent = Modicare
        product_form.Show()
    End Sub

    Private Sub Cart_Click(sender As Object, e As EventArgs) Handles Cart.Click
        If Not objlist.Count = 0 Then
            FRMReview_Cart.Show()
        Else
            MsgBox("Cart Is empty")
        End If
    End Sub
End Class