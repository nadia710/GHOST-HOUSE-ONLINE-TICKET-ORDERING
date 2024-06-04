Public Class Intro
    Private Sub StartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartToolStripMenuItem.Click
        Opening.Show()
        Me.Hide()
    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        lbl1Text.ForeColor = ColorDialog1.Color
        lbl2Text.ForeColor = ColorDialog1.Color
        lbl3Text.ForeColor = ColorDialog1.Color
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        FontDialog1.ShowDialog()
        lbl1Text.Font = FontDialog1.Font
        lbl2Text.Font = FontDialog1.Font
        lbl3Text.Font = FontDialog1.Font
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class