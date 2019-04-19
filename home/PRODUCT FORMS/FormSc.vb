Imports home.Modicare

Public Class FormSc

    Private Sub ADD_SC3021_Click(sender As Object, e As EventArgs) Handles ADD_SC3021.Click
        addproduct(CODE_SC3021.Text, NAME_SC3021.Text, BV_SC3021.Text, DP_SC3021.Text, QTY_SC3021.Text)
    End Sub

    Private Sub QTY_SC3021_KeyPress(sender As Object, e As KeyPressEventArgs) Handles QTY_SC3021.KeyPress
        onlynum(e)
    End Sub

    Private Sub ADD_PC1001_Click(sender As Object, e As EventArgs) Handles ADD_PC1001.Click
        addproduct(CODE_PC1001.Text, NAME_PC1001.Text, BV_PC1001.Text, DP_PC1001.Text, QTY_PC1001.Text)
    End Sub

    Private Sub QTY_PC1001_KeyPress(sender As Object, e As KeyPressEventArgs) Handles QTY_PC1001.KeyPress
        onlynum(e)
    End Sub
End Class