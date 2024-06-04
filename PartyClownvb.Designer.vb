<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PartyClownvb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PartyClownvb))
        Me.tClown = New System.Windows.Forms.GroupBox()
        Me.tAdultC = New System.Windows.Forms.CheckBox()
        Me.tChildC = New System.Windows.Forms.CheckBox()
        Me.QChildCBox = New System.Windows.Forms.TextBox()
        Me.QChildC = New System.Windows.Forms.Label()
        Me.QAdultCBox = New System.Windows.Forms.TextBox()
        Me.QAdultC = New System.Windows.Forms.Label()
        Me.ClearBtnC = New System.Windows.Forms.Button()
        Me.NextBtnC = New System.Windows.Forms.Button()
        Me.BackBtnC = New System.Windows.Forms.Button()
        Me.tClown.SuspendLayout()
        Me.SuspendLayout()
        '
        'tClown
        '
        Me.tClown.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tClown.Controls.Add(Me.tAdultC)
        Me.tClown.Controls.Add(Me.tChildC)
        Me.tClown.Font = New System.Drawing.Font("Stencil", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tClown.ForeColor = System.Drawing.Color.White
        Me.tClown.Location = New System.Drawing.Point(715, 216)
        Me.tClown.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tClown.Name = "tClown"
        Me.tClown.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tClown.Size = New System.Drawing.Size(563, 275)
        Me.tClown.TabIndex = 19
        Me.tClown.TabStop = False
        Me.tClown.Text = "PARTY CLOWN TYPE"
        '
        'tAdultC
        '
        Me.tAdultC.AutoSize = True
        Me.tAdultC.Font = New System.Drawing.Font("Palatino Linotype", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tAdultC.ForeColor = System.Drawing.Color.IndianRed
        Me.tAdultC.Location = New System.Drawing.Point(105, 84)
        Me.tAdultC.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tAdultC.Name = "tAdultC"
        Me.tAdultC.Size = New System.Drawing.Size(374, 50)
        Me.tAdultC.TabIndex = 0
        Me.tAdultC.Text = "ADULT           | RM25"
        Me.tAdultC.UseVisualStyleBackColor = True
        '
        'tChildC
        '
        Me.tChildC.AutoSize = True
        Me.tChildC.Font = New System.Drawing.Font("Palatino Linotype", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tChildC.ForeColor = System.Drawing.Color.IndianRed
        Me.tChildC.Location = New System.Drawing.Point(105, 160)
        Me.tChildC.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tChildC.Name = "tChildC"
        Me.tChildC.Size = New System.Drawing.Size(375, 50)
        Me.tChildC.TabIndex = 1
        Me.tChildC.Text = "CHILD            | RM18"
        Me.tChildC.UseVisualStyleBackColor = True
        '
        'QChildCBox
        '
        Me.QChildCBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.QChildCBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QChildCBox.ForeColor = System.Drawing.Color.IndianRed
        Me.QChildCBox.Location = New System.Drawing.Point(1080, 614)
        Me.QChildCBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.QChildCBox.Name = "QChildCBox"
        Me.QChildCBox.Size = New System.Drawing.Size(124, 41)
        Me.QChildCBox.TabIndex = 30
        Me.QChildCBox.Visible = False
        '
        'QChildC
        '
        Me.QChildC.AutoSize = True
        Me.QChildC.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.QChildC.Font = New System.Drawing.Font("Stencil", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QChildC.ForeColor = System.Drawing.Color.IndianRed
        Me.QChildC.Location = New System.Drawing.Point(774, 614)
        Me.QChildC.Name = "QChildC"
        Me.QChildC.Size = New System.Drawing.Size(281, 35)
        Me.QChildC.TabIndex = 29
        Me.QChildC.Text = "QUANTITY CHILD  :"
        Me.QChildC.Visible = False
        '
        'QAdultCBox
        '
        Me.QAdultCBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.QAdultCBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QAdultCBox.ForeColor = System.Drawing.Color.IndianRed
        Me.QAdultCBox.Location = New System.Drawing.Point(1080, 548)
        Me.QAdultCBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.QAdultCBox.Name = "QAdultCBox"
        Me.QAdultCBox.Size = New System.Drawing.Size(124, 41)
        Me.QAdultCBox.TabIndex = 28
        Me.QAdultCBox.Visible = False
        '
        'QAdultC
        '
        Me.QAdultC.AutoSize = True
        Me.QAdultC.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.QAdultC.Font = New System.Drawing.Font("Stencil", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QAdultC.ForeColor = System.Drawing.Color.IndianRed
        Me.QAdultC.Location = New System.Drawing.Point(775, 557)
        Me.QAdultC.Name = "QAdultC"
        Me.QAdultC.Size = New System.Drawing.Size(277, 35)
        Me.QAdultC.TabIndex = 27
        Me.QAdultC.Text = "QUANTITY ADULT :"
        Me.QAdultC.Visible = False
        '
        'ClearBtnC
        '
        Me.ClearBtnC.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClearBtnC.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearBtnC.ForeColor = System.Drawing.Color.IndianRed
        Me.ClearBtnC.Location = New System.Drawing.Point(913, 703)
        Me.ClearBtnC.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ClearBtnC.Name = "ClearBtnC"
        Me.ClearBtnC.Size = New System.Drawing.Size(174, 59)
        Me.ClearBtnC.TabIndex = 33
        Me.ClearBtnC.Text = "CLEAR"
        Me.ClearBtnC.UseVisualStyleBackColor = False
        '
        'NextBtnC
        '
        Me.NextBtnC.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.NextBtnC.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextBtnC.ForeColor = System.Drawing.Color.IndianRed
        Me.NextBtnC.Location = New System.Drawing.Point(1125, 703)
        Me.NextBtnC.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NextBtnC.Name = "NextBtnC"
        Me.NextBtnC.Size = New System.Drawing.Size(174, 59)
        Me.NextBtnC.TabIndex = 32
        Me.NextBtnC.Text = "NEXT"
        Me.NextBtnC.UseVisualStyleBackColor = False
        '
        'BackBtnC
        '
        Me.BackBtnC.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackBtnC.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackBtnC.ForeColor = System.Drawing.Color.IndianRed
        Me.BackBtnC.Location = New System.Drawing.Point(699, 703)
        Me.BackBtnC.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BackBtnC.Name = "BackBtnC"
        Me.BackBtnC.Size = New System.Drawing.Size(174, 59)
        Me.BackBtnC.TabIndex = 31
        Me.BackBtnC.Text = "BACK"
        Me.BackBtnC.UseVisualStyleBackColor = False
        '
        'PartyClownvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1621, 1033)
        Me.Controls.Add(Me.QChildCBox)
        Me.Controls.Add(Me.ClearBtnC)
        Me.Controls.Add(Me.NextBtnC)
        Me.Controls.Add(Me.BackBtnC)
        Me.Controls.Add(Me.QChildC)
        Me.Controls.Add(Me.QAdultCBox)
        Me.Controls.Add(Me.QAdultC)
        Me.Controls.Add(Me.tClown)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "PartyClownvb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PartyClownvb"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tClown.ResumeLayout(False)
        Me.tClown.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tClown As GroupBox
    Friend WithEvents tAdultC As CheckBox
    Friend WithEvents tChildC As CheckBox
    Friend WithEvents QChildCBox As TextBox
    Friend WithEvents QChildC As Label
    Friend WithEvents QAdultCBox As TextBox
    Friend WithEvents QAdultC As Label
    Friend WithEvents ClearBtnC As Button
    Friend WithEvents NextBtnC As Button
    Friend WithEvents BackBtnC As Button
End Class
