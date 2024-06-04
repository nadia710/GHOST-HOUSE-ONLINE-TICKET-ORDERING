Public Class PartyClownvb

    Public adult As String = " "
    Public child As String = " "

    Private Sub BackBtnC_Click(sender As Object, e As EventArgs) Handles BackBtnC.Click
        Western.Show()
        Me.Hide()
    End Sub

    Private Sub ClearBtnC_Click(sender As Object, e As EventArgs) Handles ClearBtnC.Click
        QAdultCBox.Clear()
        QChildCBox.Clear()
        tAdultC.Checked() = False
        tChildC.Checked() = False
    End Sub

    Private Sub NextBtnC_Click(sender As Object, e As EventArgs) Handles NextBtnC.Click
        If tAdultC.Checked() = True And tChildC.Checked() = False Then
            adult = QAdultCBox.Text
            child = 0
        ElseIf tAdultC.Checked() = False And tChildC.Checked() = True Then
            adult = 0
            child = QChildCBox.Text
        ElseIf tAdultC.Checked() = True And tChildC.Checked() = True Then
            adult = QAdultCBox.Text
            child = QChildCBox.Text
        ElseIf tAdultC.Checked() = False And tChildC.Checked() = False Then
            adult = " "
            child = " "
        End If
        If IsNumeric(adult) And IsNumeric(child) Then
            Calculation.Show()
            Me.Hide()
        ElseIf adult = " " And child = " " Then
            MsgBox("Please choose at least one ticket type !!")
        Else
            QAdultCBox.Clear()
            QChildCBox.Clear()
            tAdultC.Checked() = False
            tChildC.Checked() = False
            MsgBox("Invalid Input !!! Please Enter Quantity in Numeric Value")
        End If
    End Sub

    Private Sub tAdultC_CheckedChanged(sender As Object, e As EventArgs) Handles tAdultC.CheckedChanged
        If tAdultC.Checked() = True Then
            QAdultC.Visible = True
            QAdultCBox.Visible = True
        Else
            QAdultC.Visible = False
            QAdultCBox.Visible = False
            QAdultCBox.Clear()
        End If
    End Sub

    Private Sub tChildC_CheckedChanged(sender As Object, e As EventArgs) Handles tChildC.CheckedChanged
        QChildC.Visible = True
        QChildCBox.Visible = True

        If tChildC.Checked() = False Then
            QChildC.Visible = False
            QChildCBox.Visible = False
            QChildCBox.Clear()
        End If
    End Sub
End Class