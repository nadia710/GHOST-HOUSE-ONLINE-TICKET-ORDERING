Public Class Asian
    Public adult As String = Nothing
    Public child As String = Nothing

    Private Sub ClearBtn_Click_1(sender As Object, e As EventArgs) Handles ClearBtn.Click

        PocongBtn.Checked() = False
        PontianakBtn.Checked() = False
        ZombieBtn.Checked() = False


    End Sub

    Private Sub NextBtn_Click_1(sender As Object, e As EventArgs) Handles NextBtn.Click
        Western.Show()
        Me.Hide()

    End Sub
    Private Sub PocongBtn_CheckedChanged(sender As Object, e As EventArgs) Handles PocongBtn.CheckedChanged
        If PocongBtn.Checked() Then

            PocongVillage.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        PocongBtn.Checked() = False
        PontianakBtn.Checked() = False
        ZombieBtn.Checked() = False
    End Sub

    Private Sub AsiaGrpBox_Enter(sender As Object, e As EventArgs) Handles AsiaGrpBox.Enter
        PocongBtn.Checked() = False
        PontianakBtn.Checked() = False
        ZombieBtn.Checked() = False
    End Sub

    Private Sub PontianakBtn_CheckedChanged(sender As Object, e As EventArgs) Handles PontianakBtn.CheckedChanged
        PontianakBeranak.Show()
        Me.Hide()
    End Sub

    Private Sub ZombieBtn_CheckedChanged(sender As Object, e As EventArgs) Handles ZombieBtn.CheckedChanged
        ZombieKampungPisang.Show()
        Me.Hide()
    End Sub
End Class