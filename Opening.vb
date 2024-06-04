Public Class Opening
    Public names As String
    Public phone As Integer
    Private Sub nextBtn_Click(sender As Object, e As EventArgs) Handles nextBtn.Click
        Asian.PocongBtn.Checked() = False
        Asian.PontianakBtn.Checked() = False
        Asian.ZombieBtn.Checked() = False
        phone = Val(phonetxt.Text)
        names = Val(nametxt.Text.Trim)

        If nametxt.Text = String.Empty Then
            MsgBox("Please Enter Your Name !")
            nametxt.Focus()
        ElseIf phonetxt.Text = String.Empty Then
            MsgBox("Please Enter Your Phone Number !")
            phonetxt.Focus()
        Else
            If Integer.TryParse(phonetxt.Text, phone) Then

                Asian.Show()
                Me.Hide()
            Else
                MsgBox("The number phone is not a numeric !!")
            End If
        End If


    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        nametxt.Text = Nothing
        phonetxt.Text = Nothing
        nametxt.Focus()
    End Sub
End Class