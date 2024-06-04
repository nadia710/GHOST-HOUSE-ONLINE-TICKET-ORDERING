<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PontianakBeranak
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PontianakBeranak))
        Me.NextBtnPB = New System.Windows.Forms.Button()
        Me.ClearBtnPB = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BackBtnPB = New System.Windows.Forms.Button()
        Me.QChildPBBox = New System.Windows.Forms.TextBox()
        Me.QChildPB = New System.Windows.Forms.Label()
        Me.QAdultPBBox = New System.Windows.Forms.TextBox()
        Me.QAdultPB = New System.Windows.Forms.Label()
        Me.tPontianak = New System.Windows.Forms.GroupBox()
        Me.AdultP = New System.Windows.Forms.CheckBox()
        Me.ChildP = New System.Windows.Forms.CheckBox()
        Me.tPontianak.SuspendLayout()
        Me.SuspendLayout()
        '
        'NextBtnPB
        '
        Me.NextBtnPB.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.NextBtnPB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextBtnPB.ForeColor = System.Drawing.Color.Red
        Me.NextBtnPB.Location = New System.Drawing.Point(1091, 586)
        Me.NextBtnPB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NextBtnPB.Name = "NextBtnPB"
        Me.NextBtnPB.Size = New System.Drawing.Size(137, 43)
        Me.NextBtnPB.TabIndex = 19
        Me.NextBtnPB.Text = "NEXT"
        Me.NextBtnPB.UseVisualStyleBackColor = False
        '
        'ClearBtnPB
        '
        Me.ClearBtnPB.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClearBtnPB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearBtnPB.ForeColor = System.Drawing.Color.Red
        Me.ClearBtnPB.Location = New System.Drawing.Point(934, 586)
        Me.ClearBtnPB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ClearBtnPB.Name = "ClearBtnPB"
        Me.ClearBtnPB.Size = New System.Drawing.Size(137, 43)
        Me.ClearBtnPB.TabIndex = 20
        Me.ClearBtnPB.Text = "CLEAR"
        Me.ClearBtnPB.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(711, 500)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(154, 54)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "CLEAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BackBtnPB
        '
        Me.BackBtnPB.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackBtnPB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackBtnPB.ForeColor = System.Drawing.Color.Red
        Me.BackBtnPB.Location = New System.Drawing.Point(779, 586)
        Me.BackBtnPB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BackBtnPB.Name = "BackBtnPB"
        Me.BackBtnPB.Size = New System.Drawing.Size(137, 43)
        Me.BackBtnPB.TabIndex = 21
        Me.BackBtnPB.Text = "BACK"
        Me.BackBtnPB.UseVisualStyleBackColor = False
        '
        'QChildPBBox
        '
        Me.QChildPBBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.QChildPBBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QChildPBBox.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.QChildPBBox.Location = New System.Drawing.Point(1091, 490)
        Me.QChildPBBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.QChildPBBox.Name = "QChildPBBox"
        Me.QChildPBBox.Size = New System.Drawing.Size(124, 41)
        Me.QChildPBBox.TabIndex = 19
        Me.QChildPBBox.Visible = False
        '
        'QChildPB
        '
        Me.QChildPB.AutoSize = True
        Me.QChildPB.BackColor = System.Drawing.SystemColors.ControlText
        Me.QChildPB.Font = New System.Drawing.Font("Stencil", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QChildPB.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.QChildPB.Location = New System.Drawing.Point(776, 490)
        Me.QChildPB.Name = "QChildPB"
        Me.QChildPB.Size = New System.Drawing.Size(281, 35)
        Me.QChildPB.TabIndex = 18
        Me.QChildPB.Text = "QUANTITY CHILD  :"
        Me.QChildPB.Visible = False
        '
        'QAdultPBBox
        '
        Me.QAdultPBBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.QAdultPBBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QAdultPBBox.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.QAdultPBBox.Location = New System.Drawing.Point(1091, 428)
        Me.QAdultPBBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.QAdultPBBox.Name = "QAdultPBBox"
        Me.QAdultPBBox.Size = New System.Drawing.Size(124, 41)
        Me.QAdultPBBox.TabIndex = 17
        Me.QAdultPBBox.Visible = False
        '
        'QAdultPB
        '
        Me.QAdultPB.AutoSize = True
        Me.QAdultPB.BackColor = System.Drawing.SystemColors.ControlText
        Me.QAdultPB.Font = New System.Drawing.Font("Stencil", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QAdultPB.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.QAdultPB.Location = New System.Drawing.Point(776, 428)
        Me.QAdultPB.Name = "QAdultPB"
        Me.QAdultPB.Size = New System.Drawing.Size(277, 35)
        Me.QAdultPB.TabIndex = 16
        Me.QAdultPB.Text = "QUANTITY ADULT :"
        Me.QAdultPB.Visible = False
        '
        'tPontianak
        '
        Me.tPontianak.BackColor = System.Drawing.SystemColors.ControlText
        Me.tPontianak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tPontianak.Controls.Add(Me.AdultP)
        Me.tPontianak.Controls.Add(Me.ChildP)
        Me.tPontianak.Font = New System.Drawing.Font("Stencil", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPontianak.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.tPontianak.Location = New System.Drawing.Point(659, 96)
        Me.tPontianak.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tPontianak.Name = "tPontianak"
        Me.tPontianak.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tPontianak.Size = New System.Drawing.Size(746, 283)
        Me.tPontianak.TabIndex = 11
        Me.tPontianak.TabStop = False
        Me.tPontianak.Text = "PONTIANAK BERANAK TYPE"
        '
        'AdultP
        '
        Me.AdultP.AutoSize = True
        Me.AdultP.Font = New System.Drawing.Font("Palatino Linotype", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdultP.ForeColor = System.Drawing.Color.Red
        Me.AdultP.Location = New System.Drawing.Point(144, 79)
        Me.AdultP.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AdultP.Name = "AdultP"
        Me.AdultP.Size = New System.Drawing.Size(359, 49)
        Me.AdultP.TabIndex = 0
        Me.AdultP.Text = "ADULT           | RM13"
        Me.AdultP.UseVisualStyleBackColor = True
        '
        'ChildP
        '
        Me.ChildP.AutoSize = True
        Me.ChildP.Font = New System.Drawing.Font("Palatino Linotype", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChildP.ForeColor = System.Drawing.Color.Red
        Me.ChildP.Location = New System.Drawing.Point(143, 149)
        Me.ChildP.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChildP.Name = "ChildP"
        Me.ChildP.Size = New System.Drawing.Size(358, 49)
        Me.ChildP.TabIndex = 1
        Me.ChildP.Text = "CHILD            | RM10"
        Me.ChildP.UseVisualStyleBackColor = True
        '
        'PontianakBeranak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1707, 819)
        Me.Controls.Add(Me.tPontianak)
        Me.Controls.Add(Me.QChildPBBox)
        Me.Controls.Add(Me.BackBtnPB)
        Me.Controls.Add(Me.QChildPB)
        Me.Controls.Add(Me.ClearBtnPB)
        Me.Controls.Add(Me.QAdultPBBox)
        Me.Controls.Add(Me.NextBtnPB)
        Me.Controls.Add(Me.QAdultPB)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "PontianakBeranak"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PontianakBeranak"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tPontianak.ResumeLayout(False)
        Me.tPontianak.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents o As Button
    Friend WithEvents BackBtnPB As Button
    Friend WithEvents QChildPBBox As TextBox
    Friend WithEvents QChildPB As Label
    Friend WithEvents QAdultPBBox As TextBox
    Friend WithEvents QAdultPB As Label
    Friend WithEvents tPontianak As GroupBox
    Friend WithEvents tAdultPB As CheckBox
    Friend WithEvents tChildPB As CheckBox
    Friend WithEvents NextBtnPB As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ClearBtnPB As Button
    Friend WithEvents AdultP As CheckBox
    Friend WithEvents ChildP As CheckBox
End Class
