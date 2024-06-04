Public Class BloodDracula
    Public adult As String = " "
    Public child As String = " "
    Private Sub NextBtnBD_Click(sender As Object, e As EventArgs) Handles NextBtnBD.Click
        If tAdultBD.Checked() = True And tChildBD.Checked() = False Then
            adult = QAdultBDBox.Text
            child = 0
        ElseIf tAdultBD.Checked() = False And tChildBD.Checked() = True Then
            adult = 0
            child = QChildBDBox.Text
        ElseIf tAdultBD.Checked() = True And tChildBD.Checked() = True Then
            adult = QAdultBDBox.Text
            child = QChildBDBox.Text
        ElseIf tAdultBD.Checked() = False And tChildBD.Checked() = False Then
            adult = " "
            child = " "
        End If
        If IsNumeric(adult) And IsNumeric(child) Then
            Calculation.Show()
            Me.Hide()
        ElseIf adult = " " And child = " " Then
            MsgBox("Please choose at least one ticket type !!")
        Else
            QAdultBDBox.Clear()
            QChildBDBox.Clear()
            tAdultBD.Checked() = False
            tChildBD.Checked() = False
            MsgBox("Invalid Input !!! Please Enter Quantity in Numeric Value")
        End If
    End Sub

    Private Sub ClearBtnBD_Click(sender As Object, e As EventArgs) Handles ClearBtnBD.Click
        QAdultBDBox.Clear()
        QChildBDBox.Clear()
        tAdultBD.Checked() = False
        tChildBD.Checked() = False
    End Sub

    Private Sub BackBtnBD_Click(sender As Object, e As EventArgs) Handles BackBtnBD.Click
        Western.Show()
        Me.Hide()
    End Sub

    Private Sub tAdultBD_CheckedChanged(sender As Object, e As EventArgs) Handles tAdultBD.CheckedChanged
        If tAdultBD.Checked() = True Then
            QAdultBD.Visible = True
            QAdultBDBox.Visible = True
        Else
            QAdultBD.Visible = False
            QAdultBDBox.Visible = False
            QAdultBDBox.Clear()
        End If
    End Sub

    Private Sub tChildBD_CheckedChanged(sender As Object, e As EventArgs) Handles tChildBD.CheckedChanged
        If tChildBD.Checked() = True Then
            QChildBD.Visible = True
            QChildBDBox.Visible = True
        Else
            QChildBD.Visible = False
            QChildBDBox.Visible = False
            QChildBDBox.Clear()
        End If
    End Sub
End Class