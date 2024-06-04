Public Class Calculation
    Dim asia As String = " "
    Dim w As String = " "
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        Dim name, phoneNum, totalAsia, totalWestern, qty As String
        Dim qtyAsiaA, qtyAsiaC, qtyWesternA, qtyWesternC As Integer

        lblTotal.Text() = "RM " & (CalcTotalAdult() + CalcTotalChild() + CalcAdultW() + CalcChildW())
        name = "Name : " & Opening.nametxt.Text()
        phoneNum = "Phone Number : " & Opening.phonetxt.Text()

        If Asian.PocongBtn.Checked() Then
            asia = "Package Asia : Pocong Village"
        ElseIf Asian.PontianakBtn.Checked() Then
            asia = "Package Asia : Pontianak Beranak"
        ElseIf Asian.ZombieBtn.Checked() Then
            asia = "Package Asia : Zombie Kampung Pisang"
        End If

        If Western.pcBox.Checked() Then
            w = "Package Western : Party Clown"
        ElseIf Western.bdBox.Checked() Then
            w = "Package Western : Blood Dracula"
        ElseIf Western.fgBox.Checked() Then
            w = "Package Western : Frankestein Grave"
        End If

        qty = "Total Quantity for "

        totalAsia = "Total for Package Asia : RM " & (CalcTotalAdult() + CalcTotalChild())
        totalWestern = "Total for Package Western : RM " & (CalcAdultW() + CalcChildW())

        lstDisplay.Items.Add(name)
        lstDisplay.Items.Add(phoneNum)
        lstDisplay.Items.Add("-----------------------------------")
        lstDisplay.Items.Add(asia)

        If Asian.PocongBtn.Checked() Then
            If PocongVillage.tAdultPV.Checked() Then
                qtyAsiaA = PocongVillage.QAdultPVBox.Text()
                lstDisplay.Items.Add(qty & "Adult : " & qtyAsiaA)
            End If
        ElseIf Asian.PontianakBtn.Checked() Then
            If PontianakBeranak.AdultP.Checked() Then
                qtyAsiaA = PontianakBeranak.QAdultPBBox.Text()
                lstDisplay.Items.Add(qty & "Adult : " & qtyAsiaA)
            End If
        ElseIf Asian.ZombieBtn.Checked() Then
            If ZombieKampungPisang.AdultZ.Checked() Then
                qtyAsiaA = ZombieKampungPisang.QAdultZBoxs.Text()
                lstDisplay.Items.Add(qty & "Adult : " & qtyAsiaA)
            End If
        End If

        If Asian.PocongBtn.Checked() Then
            If PocongVillage.tChildPV.Checked() Then
                qtyAsiaC = PocongVillage.QChildPVBox.Text()
                lstDisplay.Items.Add(qty & "Child : " & qtyAsiaC)
            End If
        ElseIf Asian.PontianakBtn.Checked() Then
            If PontianakBeranak.ChildP.Checked() Then
                qtyAsiaC = PontianakBeranak.QChildPBBox.Text()
                lstDisplay.Items.Add(qty & "Child : " & qtyAsiaC)
            End If
        ElseIf Asian.ZombieBtn.Checked() Then
            If ZombieKampungPisang.ChildZ.Checked() Then
                qtyAsiaC = ZombieKampungPisang.QChildZBoxs.Text()
                lstDisplay.Items.Add(qty & "Child : " & qtyAsiaC)
            End If
        End If

        If Asian.PocongBtn.Checked() = True Or Asian.PontianakBtn.Checked() = True Or Asian.ZombieBtn.Checked() = True Then
            lstDisplay.Items.Add(totalAsia)
            lstDisplay.Items.Add("-----------------------------------")
        End If
        lstDisplay.Items.Add(w)

        If Western.pcBox.Checked() Then
            If PartyClownvb.tAdultC.Checked() Then
                qtyWesternA = PartyClownvb.QAdultCBox.Text()
                lstDisplay.Items.Add(qty & "Adult : " & qtyWesternA)
            End If
        ElseIf Western.bdBox.Checked() Then
            If BloodDracula.tAdultBD.Checked() Then
                qtyWesternA = BloodDracula.QAdultBDBox.Text()
                lstDisplay.Items.Add(qty & "Adult : " & qtyWesternA)
            End If
        ElseIf Western.fgBox.Checked() Then
            If Frakenstien.AdultFG.Checked() Then
                qtyWesternA = Frakenstien.QAdultFGBox.Text()
                lstDisplay.Items.Add(qty & "Adult : " & qtyWesternA)
            End If
        End If

        If Western.pcBox.Checked() Then
            If PartyClownvb.tChildC.Checked() Then
                qtyWesternC = PartyClownvb.QChildCBox.Text()
                lstDisplay.Items.Add(qty & "Child : " & qtyWesternC)
            End If
        ElseIf Western.bdBox.Checked() Then
            If BloodDracula.tChildBD.Checked() Then
                qtyWesternC = BloodDracula.QChildBDBox.Text()
                lstDisplay.Items.Add(qty & "Adult : " & qtyWesternC)
            End If
        ElseIf Western.fgBox.Checked() Then
            If Frakenstien.ChildFG.Checked() Then
                qtyWesternC = Frakenstien.QChildFGBox.Text()
                lstDisplay.Items.Add(qty & "Adult : " & qtyWesternC)
            End If
        End If

        If Western.pcBox.Checked() = True Or Western.bdBox.Checked() = True Or Western.fgBox.Checked() = True Then
            lstDisplay.Items.Add(totalWestern)
        End If
    End Sub

    Private Function CalcTotalAdult() As Double
        Dim totA As Double

        If Asian.PocongBtn.Checked() Then
            If PocongVillage.tAdultPV.Checked() Then
                totA = 10.0 * PocongVillage.QAdultPVBox.Text()
            End If
        ElseIf Asian.PontianakBtn.Checked() Then
            If PontianakBeranak.AdultP.Checked() Then
                totA = 13.0 * PontianakBeranak.QAdultPBBox.Text()
            End If
        ElseIf Asian.ZombieBtn.Checked() Then
            If ZombieKampungPisang.AdultZ.Checked() Then
                totA = 15.0 * ZombieKampungPisang.QAdultZBoxs.Text()
            End If
        Else
            totA = 0
        End If

        Return totA
    End Function

    Private Function CalcTotalChild() As Double
        Dim totC As Double

        If Asian.PocongBtn.Checked() Then
            If PocongVillage.tChildPV.Checked() Then
                totC = 8.0 * PocongVillage.QChildPVBox.Text()
            End If
        ElseIf Asian.PontianakBtn.Checked() Then
            If PontianakBeranak.ChildP.Checked() Then
                totC = 10.0 * PontianakBeranak.QChildPBBox.Text()
            End If
        ElseIf Asian.ZombieBtn.Checked() Then
            If ZombieKampungPisang.ChildZ.Checked() Then
                totC = 10.0 * ZombieKampungPisang.QChildZBoxs.Text()
            End If
        Else
            totC = 0
        End If

        Return totC
    End Function

    Private Function CalcAdultW() As Double
        Dim totalA As Double

        If Western.pcBox.Checked() Then
            If PartyClownvb.tAdultC.Checked() Then
                totalA = 25.0 * PartyClownvb.QAdultCBox.Text()
            End If
        ElseIf Western.bdBox.Checked() Then
            If BloodDracula.tAdultBD.Checked() Then
                totalA = 18.0 * BloodDracula.QAdultBDBox.Text()
            End If
        ElseIf Western.fgBox.Checked() Then
            If Frakenstien.AdultFG.Checked() Then
                totalA = 15.0 * Frakenstien.QAdultFGBox.Text()
            End If
        End If

        Return totalA
    End Function

    Private Function CalcChildW() As Double
        Dim totalC As Double

        If Western.pcBox.Checked() Then
            If PartyClownvb.tChildC.Checked() Then
                totalC = 18.0 * PartyClownvb.QChildCBox.Text()
            End If
        ElseIf Western.bdBox.Checked() Then
            If BloodDracula.tChildBD.Checked() Then
                totalC = 15.0 * BloodDracula.QChildBDBox.Text()
            End If
        ElseIf Western.fgBox.Checked() Then
            If Frakenstien.ChildFG.Checked() Then
                totalC = 12.0 * Frakenstien.QChildFGBox.Text()
            End If
        End If

        Return totalC
    End Function

    Private Sub pdPrint_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pdPrint.PrintPage
        e.Graphics.DrawString("NIGHT AT EVIL'S", New Font("Times New Roman", 24, FontStyle.Bold), Brushes.Black, 260, 80)
        e.Graphics.DrawString("RECEIPT", New Font("Times New Roman", 16, FontStyle.Bold), Brushes.Black, 360, 120)

        Dim startY As Integer = 180

        For count As Integer = 0 To lstDisplay.Items.Count - 1
            e.Graphics.DrawString(lstDisplay.Items(count).ToString, New Font("Times New Roman", 12), Brushes.Black, 260, startY)
            startY += 20
        Next

        e.Graphics.DrawString("----------------------------------------------------------------------------", New Font("Times New Roman", 18), Brushes.Black, 80, startY)
        e.Graphics.DrawString("Total All : RM " & lblTotal.Text(), New Font("Times New Roman", 18), Brushes.Black, 260, startY + 40)
    End Sub

    Private Sub print_Click(sender As Object, e As EventArgs) Handles print.Click
        pdPrint.Print()
    End Sub

    Private Sub printPrev_Click(sender As Object, e As EventArgs) Handles printPrev.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub
End Class