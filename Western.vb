Public Class Western
    Dim adult As String = Nothing
    Dim child As String = Nothing
    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        pcBox = Nothing
        bdBox = Nothing
        fgBox = Nothing
    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Asian.Show()
        Me.Hide()
    End Sub

    Private Sub nextBtn_Click(sender As Object, e As EventArgs) Handles nextBtn.Click

        If Asian.PocongBtn.Checked() = False And Asian.PontianakBtn.Checked() = False And Asian.ZombieBtn.Checked() = False Then
            MsgBox("Please choose at least one ticket type!!")
        Else
            Calculation.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub pcBox_CheckedChanged(sender As Object, e As EventArgs) Handles pcBox.CheckedChanged
        PartyClownvb.Show()
        Me.Hide()
    End Sub

    Private Sub bdBox_CheckedChanged(sender As Object, e As EventArgs) Handles bdBox.CheckedChanged
        BloodDracula.Show()
        Me.Hide()
    End Sub

    Private Sub fgBox_CheckedChanged(sender As Object, e As EventArgs) Handles fgBox.CheckedChanged
        Frakenstien.Show()
        Me.Hide()
    End Sub
End Class