Public Class Frakenstien
    Public adult As String = " "
    Public child As String = " "
    Private Sub BackBtnFG_Click(sender As Object, e As EventArgs) Handles BackBtnFG.Click
        Western.Show()
        Me.Hide()
    End Sub

    Private Sub NextBtnFG_Click(sender As Object, e As EventArgs) Handles NextBtnFG.Click
        If AdultFG.Checked() = True And ChildFG.Checked() = False Then
            adult = QAdultFGBox.Text
            child = 0
        ElseIf AdultFG.Checked() = False And ChildFG.Checked() = True Then
            adult = 0
            child = QChildFGBox.Text
        ElseIf AdultFG.Checked() = True And ChildFG.Checked() = True Then
            adult = QAdultFGBox.Text
            child = QChildFGBox.Text
        ElseIf AdultFG.Checked() = False And ChildFG.Checked() = False Then
            adult = " "
            child = " "
        End If
        If IsNumeric(adult) And IsNumeric(child) Then
            Calculation.Show()
            Me.Hide()
        ElseIf adult = " " And child = " " Then
            MsgBox("Please choose at least one ticket type !!")
        Else
            QAdultFGBox.Clear()
            QChildFGBox.Clear()
            AdultFG.Checked() = False
            ChildFG.Checked() = False
            MsgBox("Invalid Input !!! Please Enter Quantity in Numeric Value")
        End If
    End Sub

    Private Sub ClearBtnFG_Click(sender As Object, e As EventArgs) Handles ClearBtnFG.Click
        QAdultFGBox.Clear()
        QChildFGBox.Clear()
        AdultFG.Checked() = False
        ChildFG.Checked() = False
    End Sub



    Private Sub AdultFG_CheckedChanged(sender As Object, e As EventArgs) Handles AdultFG.CheckedChanged
        If AdultFG.Checked() = True Then
            QAdultFG.Visible = True
            QAdultFGBox.Visible = True
        Else
            QAdultFG.Visible = False
            QAdultFGBox.Visible = False
            QAdultFGBox.Clear()
        End If
    End Sub

    Private Sub ChildFG_CheckedChanged(sender As Object, e As EventArgs) Handles ChildFG.CheckedChanged

        If ChildFG.Checked() = True Then
            QChildFG.Visible = True
            QChildFGBox.Visible = True
        Else
            QChildFG.Visible = False
            QChildFGBox.Visible = False
            QChildFGBox.Clear()
        End If
    End Sub
End Class