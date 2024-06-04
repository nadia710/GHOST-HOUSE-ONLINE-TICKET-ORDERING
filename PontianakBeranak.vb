Public Class PontianakBeranak
    Public adult As String = " "
    Public child As String = " "
    Private Sub ChildP_CheckedChanged(sender As Object, e As EventArgs) Handles ChildP.CheckedChanged
        QChildPB.Visible = True
        QChildPBBox.Visible = True

        If ChildP.Checked() = False Then
            QChildPB.Visible = False
            QChildPBBox.Visible = False
            QChildPBBox.Clear()
        End If
    End Sub

    Private Sub AdultP_CheckedChanged(sender As Object, e As EventArgs) Handles AdultP.CheckedChanged
        QAdultPB.Visible = True
        QAdultPBBox.Visible = True

        If AdultP.Checked() = False Then
            QAdultPB.Visible = False
            QAdultPBBox.Visible = False
            QAdultPBBox.Clear()
        End If
    End Sub

    Private Sub NextBtnPB_Click_1(sender As Object, e As EventArgs) Handles NextBtnPB.Click
        If AdultP.Checked() = True And ChildP.Checked() = False Then
            adult = QAdultPBBox.Text
            child = 0
        ElseIf AdultP.Checked() = False And ChildP.Checked() = True Then
            adult = 0
            child = QChildPBBox.Text
        ElseIf AdultP.Checked() = True And ChildP.Checked() = True Then
            adult = QAdultPBBox.Text
            child = QChildPBBox.Text
        ElseIf AdultP.Checked() = False And ChildP.Checked() = False Then
            adult = " "
            child = " "
        End If

        If IsNumeric(adult) = False Or IsNumeric(child) = False Then
            QAdultPBBox.Clear()
            QChildPBBox.Clear()
            AdultP.Checked() = False
            ChildP.Checked() = False
            MsgBox("Invalid Input !!! Please Enter Quantity in Numeric Value")
        ElseIf adult = " " And child = " " Then
            MsgBox("Please choose at least one ticket type !!")
        End If

        If IsNumeric(adult) And IsNumeric(child) Then
            Western.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub BackBtnPB_Click(sender As Object, e As EventArgs) Handles BackBtnPB.Click
        Me.Hide()
        Asian.Show()
    End Sub

    Private Sub ClearBtnPB_Click(sender As Object, e As EventArgs) Handles ClearBtnPB.Click
        QAdultPBBox.Clear()
        QChildPBBox.Clear()
        tAdultPB.Checked() = False
        tChildPB.Checked() = False
    End Sub
End Class