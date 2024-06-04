Public Class ZombieKampungPisang
    Public adult As String = " "
    Public child As String = " "

    Private Sub AdultZ_CheckedChanged(sender As Object, e As EventArgs) Handles AdultZ.CheckedChanged
        QAdultZs.Visible = True
        QAdultZBoxs.Visible = True

        If AdultZ.Checked() = False Then
            QAdultZs.Visible = False
            QAdultZBoxs.Visible = False
            QAdultZBoxs.Clear()
        End If
    End Sub

    Private Sub ChildZ_CheckedChanged(sender As Object, e As EventArgs) Handles ChildZ.CheckedChanged
        QChildZs.Visible = True
        QChildZBoxs.Visible = True

        If ChildZ.Checked() = False Then
            QChildZs.Visible = False
            QChildZBoxs.Visible = False
            QChildZBoxs.Clear()
        End If
    End Sub

    Private Sub BackBtnZ_Click(sender As Object, e As EventArgs) Handles BackBtnZ.Click
        Asian.Show()
        Me.Hide()
    End Sub

    Private Sub NextBtnZ_Click(sender As Object, e As EventArgs) Handles NextBtnZ.Click
        If AdultZ.Checked() = True And ChildZ.Checked() = False Then
            adult = QAdultZBoxs.Text
            child = 0
        ElseIf AdultZ.Checked() = False And ChildZ.Checked() = True Then
            adult = 0
            child = QChildZBoxs.Text
        ElseIf AdultZ.Checked() = True And ChildZ.Checked() = True Then
            adult = QAdultZBoxs.Text
            child = QChildZBoxs.Text
        ElseIf AdultZ.Checked() = False And ChildZ.Checked() = False Then
            adult = " "
            child = " "
        End If
        If IsNumeric(adult) And IsNumeric(child) Then
            Western.Show()
            Me.Hide()
        ElseIf adult = " " And child = " " Then
            MsgBox("Please choose at least one ticket type !!")
        Else
            QAdultZBoxs.Clear()
            QChildZBoxs.Clear()
            AdultZ.Checked() = False
            ChildZ.Checked() = False
            MsgBox("Invalid Input !!! Please Enter Quantity in Numeric Value")
        End If
    End Sub

    Private Sub ClearBtnZ_Click(sender As Object, e As EventArgs) Handles ClearBtnZ.Click
        QAdultZBoxs.Clear()
        QChildZBoxs.Clear()
        AdultZ.Checked() = False
        ChildZ.Checked() = False
    End Sub
End Class