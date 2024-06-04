<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PocongVillage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PocongVillage))
        Me.tAdultPV = New System.Windows.Forms.CheckBox()
        Me.tChildPV = New System.Windows.Forms.CheckBox()
        Me.tPocong = New System.Windows.Forms.GroupBox()
        Me.QAdultPV = New System.Windows.Forms.Label()
        Me.QAdultPVBox = New System.Windows.Forms.TextBox()
        Me.QChildPV = New System.Windows.Forms.Label()
        Me.QChildPVBox = New System.Windows.Forms.TextBox()
        Me.BackBtnPV = New System.Windows.Forms.Button()
        Me.NextBtnPV = New System.Windows.Forms.Button()
        Me.ClearBtnPV = New System.Windows.Forms.Button()
        Me.tPocong.SuspendLayout()
        Me.SuspendLayout()
        '
        'tAdultPV
        '
        Me.tAdultPV.AutoSize = True
        Me.tAdultPV.Font = New System.Drawing.Font("Palatino Linotype", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tAdultPV.ForeColor = System.Drawing.Color.SlateGray
        Me.tAdultPV.Location = New System.Drawing.Point(167, 81)
        Me.tAdultPV.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tAdultPV.Name = "tAdultPV"
        Me.tAdultPV.Size = New System.Drawing.Size(374, 50)
        Me.tAdultPV.TabIndex = 0
        Me.tAdultPV.Text = "ADULT           | RM10"
        Me.tAdultPV.UseVisualStyleBackColor = True
        '
        'tChildPV
        '
        Me.tChildPV.AutoSize = True
        Me.tChildPV.Font = New System.Drawing.Font("Palatino Linotype", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tChildPV.ForeColor = System.Drawing.Color.SlateGray
        Me.tChildPV.Location = New System.Drawing.Point(167, 166)
        Me.tChildPV.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tChildPV.Name = "tChildPV"
        Me.tChildPV.Size = New System.Drawing.Size(358, 50)
        Me.tChildPV.TabIndex = 1
        Me.tChildPV.Text = "CHILD            | RM8"
        Me.tChildPV.UseVisualStyleBackColor = True
        '
        'tPocong
        '
        Me.tPocong.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tPocong.Controls.Add(Me.tAdultPV)
        Me.tPocong.Controls.Add(Me.tChildPV)
        Me.tPocong.Font = New System.Drawing.Font("Stencil", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPocong.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tPocong.Location = New System.Drawing.Point(700, 235)
        Me.tPocong.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tPocong.Name = "tPocong"
        Me.tPocong.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tPocong.Size = New System.Drawing.Size(704, 273)
        Me.tPocong.TabIndex = 2
        Me.tPocong.TabStop = False
        Me.tPocong.Text = "POCONG VILLAGE TYPE"
        '
        'QAdultPV
        '
        Me.QAdultPV.AutoSize = True
        Me.QAdultPV.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.QAdultPV.Font = New System.Drawing.Font("Stencil", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QAdultPV.ForeColor = System.Drawing.Color.SlateGray
        Me.QAdultPV.Location = New System.Drawing.Point(861, 579)
        Me.QAdultPV.Name = "QAdultPV"
        Me.QAdultPV.Size = New System.Drawing.Size(277, 35)
        Me.QAdultPV.TabIndex = 3
        Me.QAdultPV.Text = "QUANTITY ADULT :"
        Me.QAdultPV.Visible = False
        '
        'QAdultPVBox
        '
        Me.QAdultPVBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.QAdultPVBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QAdultPVBox.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.QAdultPVBox.Location = New System.Drawing.Point(1195, 579)
        Me.QAdultPVBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.QAdultPVBox.Name = "QAdultPVBox"
        Me.QAdultPVBox.Size = New System.Drawing.Size(89, 41)
        Me.QAdultPVBox.TabIndex = 4
        Me.QAdultPVBox.Visible = False
        '
        'QChildPV
        '
        Me.QChildPV.AutoSize = True
        Me.QChildPV.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.QChildPV.Font = New System.Drawing.Font("Stencil", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QChildPV.ForeColor = System.Drawing.Color.SlateGray
        Me.QChildPV.Location = New System.Drawing.Point(861, 650)
        Me.QChildPV.Name = "QChildPV"
        Me.QChildPV.Size = New System.Drawing.Size(281, 35)
        Me.QChildPV.TabIndex = 5
        Me.QChildPV.Text = "QUANTITY CHILD  :"
        Me.QChildPV.Visible = False
        '
        'QChildPVBox
        '
        Me.QChildPVBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.QChildPVBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QChildPVBox.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.QChildPVBox.Location = New System.Drawing.Point(1195, 645)
        Me.QChildPVBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.QChildPVBox.Name = "QChildPVBox"
        Me.QChildPVBox.Size = New System.Drawing.Size(89, 41)
        Me.QChildPVBox.TabIndex = 6
        Me.QChildPVBox.Visible = False
        '
        'BackBtnPV
        '
        Me.BackBtnPV.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackBtnPV.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackBtnPV.ForeColor = System.Drawing.Color.SlateGray
        Me.BackBtnPV.Location = New System.Drawing.Point(700, 727)
        Me.BackBtnPV.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BackBtnPV.Name = "BackBtnPV"
        Me.BackBtnPV.Size = New System.Drawing.Size(155, 60)
        Me.BackBtnPV.TabIndex = 7
        Me.BackBtnPV.Text = "BACK"
        Me.BackBtnPV.UseVisualStyleBackColor = False
        '
        'NextBtnPV
        '
        Me.NextBtnPV.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.NextBtnPV.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextBtnPV.ForeColor = System.Drawing.Color.SlateGray
        Me.NextBtnPV.Location = New System.Drawing.Point(1249, 727)
        Me.NextBtnPV.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NextBtnPV.Name = "NextBtnPV"
        Me.NextBtnPV.Size = New System.Drawing.Size(155, 60)
        Me.NextBtnPV.TabIndex = 8
        Me.NextBtnPV.Text = "NEXT"
        Me.NextBtnPV.UseVisualStyleBackColor = False
        '
        'ClearBtnPV
        '
        Me.ClearBtnPV.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClearBtnPV.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearBtnPV.ForeColor = System.Drawing.Color.SlateGray
        Me.ClearBtnPV.Location = New System.Drawing.Point(987, 727)
        Me.ClearBtnPV.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ClearBtnPV.Name = "ClearBtnPV"
        Me.ClearBtnPV.Size = New System.Drawing.Size(155, 60)
        Me.ClearBtnPV.TabIndex = 9
        Me.ClearBtnPV.Text = "CLEAR"
        Me.ClearBtnPV.UseVisualStyleBackColor = False
        '
        'PocongVillage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1707, 819)
        Me.Controls.Add(Me.ClearBtnPV)
        Me.Controls.Add(Me.NextBtnPV)
        Me.Controls.Add(Me.BackBtnPV)
        Me.Controls.Add(Me.QChildPVBox)
        Me.Controls.Add(Me.QChildPV)
        Me.Controls.Add(Me.QAdultPVBox)
        Me.Controls.Add(Me.QAdultPV)
        Me.Controls.Add(Me.tPocong)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "PocongVillage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PocongVillage"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tPocong.ResumeLayout(False)
        Me.tPocong.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tAdultPV As CheckBox
    Friend WithEvents tChildPV As CheckBox
    Friend WithEvents tPocong As GroupBox
    Friend WithEvents QAdultPV As Label
    Friend WithEvents QAdultPVBox As TextBox
    Friend WithEvents QChildPV As Label
    Friend WithEvents QChildPVBox As TextBox
    Friend WithEvents BackBtnPV As Button
    Friend WithEvents NextBtnPV As Button
    Friend WithEvents ClearBtnPV As Button
End Class
