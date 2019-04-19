Imports home.Modicare

Public Class FormHs

    Private Sub ADD_FS5051_Click(sender As Object, e As EventArgs) Handles ADD_FS5051.Click
        addproduct(CODE_FS5051.Text, NAME_FS5051.Text, BV_FS5051.Text, DP_FS5051.Text, QTY_FS5051.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ADD_FS5052.Click
        addproduct(CODE_FS5052.Text, NAME_FS5052.Text, BV_FS5052.Text, DP_FS5052.Text, QTY_FS5052.Text)
    End Sub

    Private Sub ADD_HL0001_Click(sender As Object, e As EventArgs) Handles ADD_HL0001.Click
        addproduct(CODE_HL0001.Text, NAME_HL0001.Text, BV_HL0001.Text, DP_HL0001.Text, QTY_HL0001.Text)
    End Sub

    Private Sub ADD_HL0002_Click(sender As Object, e As EventArgs) Handles ADD_HL0002.Click
        addproduct(CODE_HL0002.Text, NAME_HL0002.Text, BV_HL0002.Text, DP_HL0002.Text, QTY_HL0002.Text)
    End Sub

    Private Sub ADD_HL0003_Click(sender As Object, e As EventArgs) Handles ADD_HL0003.Click
        addproduct(CODE_HL0003.Text, NAME_HL0003.Text, BV_HL0003.Text, DP_HL0003.Text, QTY_HL0003.Text)
    End Sub

    Private Sub QTY_FS5051_KeyPress(sender As Object, e As KeyPressEventArgs) Handles QTY_FS5051.KeyPress
        onlynum(e)
    End Sub

    Private Sub QTY_FS5052_KeyPress(sender As Object, e As KeyPressEventArgs) Handles QTY_FS5052.KeyPress
        onlynum(e)
    End Sub

    Private Sub QTY_HL0001_KeyPress(sender As Object, e As KeyPressEventArgs) Handles QTY_HL0001.KeyPress
        onlynum(e)
    End Sub

    Private Sub QTY_HL0002_KeyPress(sender As Object, e As KeyPressEventArgs) Handles QTY_HL0002.KeyPress
        onlynum(e)
    End Sub

    Private Sub QTY_HL0003_KeyPress(sender As Object, e As KeyPressEventArgs) Handles QTY_HL0003.KeyPress
        onlynum(e)
    End Sub

End Class