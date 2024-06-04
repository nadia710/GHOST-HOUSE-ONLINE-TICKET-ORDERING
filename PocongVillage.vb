Public Class PocongVillage
    Public adult As String = " "
    Public child As String = " "

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles tPocong.Enter

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles QAdultPV.Click

    End Sub

    Private Sub adultCheck_CheckedChanged(sender As Object, e As EventArgs) Handles tAdultPV.CheckedChanged
        If tAdultPV.Checked() = True Then
            QAdultPV.Visible = True
            QAdultPVBox.Visible = True
        Else
            QAdultPV.Visible = False
            QAdultPVBox.Visible = False
            QAdultPVBox.Clear()
        End If
    End Sub

    Private Sub tChild_CheckedChanged(sender As Object, e As EventArgs) Handles tChildPV.CheckedChanged
        If tChildPV.Checked() = True Then
            QChildPV.Visible = True
            QChildPVBox.Visible = True
        Else
            QChildPV.Visible = False
            QChildPVBox.Visible = False
            QChildPVBox.Clear()
        End If
    End Sub

    Private Sub BackBtnPV_Click(sender As Object, e As EventArgs) Handles BackBtnPV.Click
        Asian.Show()
        Me.Hide()
    End Sub

    Private Sub ClearBtnPV_Click(sender As Object, e As EventArgs) Handles ClearBtnPV.Click
        QAdultPVBox.Clear()
        QChildPVBox.Clear()
        tAdultPV.Checked() = False
        tChildPV.Checked() = False
    End Sub

    Private Sub NextBtnPV_Click(sender As Object, e As EventArgs) Handles NextBtnPV.Click

        If tAdultPV.Checked() = True And tChildPV.Checked() = False Then
            adult = QAdultPVBox.Text
            child = 0
        ElseIf tAdultPV.Checked() = False And tChildPV.Checked() = True Then
            adult = 0
            child = QChildPVBox.Text
        ElseIf tAdultPV.Checked() = True And tChildPV.Checked() = True Then
            adult = QAdultPVBox.Text
            child = QChildPVBox.Text
        ElseIf tAdultPV.Checked() = False And tChildPV.Checked() = False Then
            adult = " "
            child = " "
        End If
        If IsNumeric(adult) And IsNumeric(child) Then
            Western.Show()
            Me.Hide()
        ElseIf adult = " " And child = " " Then
            MsgBox("Please choose at least one ticket type !!")
        Else
            QAdultPVBox.Clear()
            QChildPVBox.Clear()
            tAdultPV.Checked() = False
            tChildPV.Checked() = False
            MsgBox("Invalid Input !!! Please Enter Quantity in Numeric Value")
        End If
    End Sub


End Class