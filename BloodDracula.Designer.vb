<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BloodDracula
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BloodDracula))
        Me.ClearBtnBD = New System.Windows.Forms.Button()
        Me.NextBtnBD = New System.Windows.Forms.Button()
        Me.BackBtnBD = New System.Windows.Forms.Button()
        Me.QChildBDBox = New System.Windows.Forms.TextBox()
        Me.QChildBD = New System.Windows.Forms.Label()
        Me.QAdultBDBox = New System.Windows.Forms.TextBox()
        Me.QAdultBD = New System.Windows.Forms.Label()
        Me.tBD = New System.Windows.Forms.GroupBox()
        Me.tAdultBD = New System.Windows.Forms.CheckBox()
        Me.tChildBD = New System.Windows.Forms.CheckBox()
        Me.tBD.SuspendLayout()
        Me.SuspendLayout()
        '
        'ClearBtnBD
        '
        Me.ClearBtnBD.BackColor = System.Drawing.Color.Black
        Me.ClearBtnBD.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearBtnBD.ForeColor = System.Drawing.Color.LightBlue
        Me.ClearBtnBD.Location = New System.Drawing.Point(986, 647)
        Me.ClearBtnBD.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ClearBtnBD.Name = "ClearBtnBD"
        Me.ClearBtnBD.Size = New System.Drawing.Size(172, 64)
        Me.ClearBtnBD.TabIndex = 33
        Me.ClearBtnBD.Text = "CLEAR"
        Me.ClearBtnBD.UseVisualStyleBackColor = False
        '
        'NextBtnBD
        '
        Me.NextBtnBD.BackColor = System.Drawing.Color.Black
        Me.NextBtnBD.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextBtnBD.ForeColor = System.Drawing.Color.LightBlue
        Me.NextBtnBD.Location = New System.Drawing.Point(1187, 647)
        Me.NextBtnBD.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NextBtnBD.Name = "NextBtnBD"
        Me.NextBtnBD.Size = New System.Drawing.Size(172, 64)
        Me.NextBtnBD.TabIndex = 32
        Me.NextBtnBD.Text = "NEXT"
        Me.NextBtnBD.UseVisualStyleBackColor = False
        '
        'BackBtnBD
        '
        Me.BackBtnBD.BackColor = System.Drawing.Color.Black
        Me.BackBtnBD.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackBtnBD.ForeColor = System.Drawing.Color.LightBlue
        Me.BackBtnBD.Location = New System.Drawing.Point(780, 647)
        Me.BackBtnBD.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BackBtnBD.Name = "BackBtnBD"
        Me.BackBtnBD.Size = New System.Drawing.Size(172, 64)
        Me.BackBtnBD.TabIndex = 31
        Me.BackBtnBD.Text = "BACK"
        Me.BackBtnBD.UseVisualStyleBackColor = False
        '
        'QChildBDBox
        '
        Me.QChildBDBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.QChildBDBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QChildBDBox.ForeColor = System.Drawing.Color.LightCyan
        Me.QChildBDBox.Location = New System.Drawing.Point(1171, 570)
        Me.QChildBDBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.QChildBDBox.Name = "QChildBDBox"
        Me.QChildBDBox.Size = New System.Drawing.Size(124, 41)
        Me.QChildBDBox.TabIndex = 30
        Me.QChildBDBox.Visible = False
        '
        'QChildBD
        '
        Me.QChildBD.AutoSize = True
        Me.QChildBD.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.QChildBD.Font = New System.Drawing.Font("Stencil", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QChildBD.ForeColor = System.Drawing.Color.LightCyan
        Me.QChildBD.Location = New System.Drawing.Point(848, 563)
        Me.QChildBD.Name = "QChildBD"
        Me.QChildBD.Size = New System.Drawing.Size(281, 35)
        Me.QChildBD.TabIndex = 29
        Me.QChildBD.Text = "QUANTITY CHILD  :"
        Me.QChildBD.Visible = False
        '
        'QAdultBDBox
        '
        Me.QAdultBDBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.QAdultBDBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QAdultBDBox.ForeColor = System.Drawing.Color.LightCyan
        Me.QAdultBDBox.Location = New System.Drawing.Point(1171, 503)
        Me.QAdultBDBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.QAdultBDBox.Name = "QAdultBDBox"
        Me.QAdultBDBox.Size = New System.Drawing.Size(124, 41)
        Me.QAdultBDBox.TabIndex = 28
        Me.QAdultBDBox.Visible = False
        '
        'QAdultBD
        '
        Me.QAdultBD.AutoSize = True
        Me.QAdultBD.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.QAdultBD.Font = New System.Drawing.Font("Stencil", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QAdultBD.ForeColor = System.Drawing.Color.LightCyan
        Me.QAdultBD.Location = New System.Drawing.Point(848, 503)
        Me.QAdultBD.Name = "QAdultBD"
        Me.QAdultBD.Size = New System.Drawing.Size(277, 35)
        Me.QAdultBD.TabIndex = 27
        Me.QAdultBD.Text = "QUANTITY ADULT :"
        Me.QAdultBD.Visible = False
        '
        'tBD
        '
        Me.tBD.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tBD.Controls.Add(Me.tAdultBD)
        Me.tBD.Controls.Add(Me.tChildBD)
        Me.tBD.Font = New System.Drawing.Font("Stencil", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tBD.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tBD.Location = New System.Drawing.Point(780, 218)
        Me.tBD.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tBD.Name = "tBD"
        Me.tBD.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tBD.Size = New System.Drawing.Size(579, 244)
        Me.tBD.TabIndex = 26
        Me.tBD.TabStop = False
        Me.tBD.Text = "BLOOD DRACULA TYPE"
        '
        'tAdultBD
        '
        Me.tAdultBD.AutoSize = True
        Me.tAdultBD.Font = New System.Drawing.Font("Palatino Linotype", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tAdultBD.ForeColor = System.Drawing.Color.Azure
        Me.tAdultBD.Location = New System.Drawing.Point(102, 89)
        Me.tAdultBD.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tAdultBD.Name = "tAdultBD"
        Me.tAdultBD.Size = New System.Drawing.Size(374, 50)
        Me.tAdultBD.TabIndex = 0
        Me.tAdultBD.Text = "ADULT           | RM18"
        Me.tAdultBD.UseVisualStyleBackColor = True
        '
        'tChildBD
        '
        Me.tChildBD.AutoSize = True
        Me.tChildBD.Font = New System.Drawing.Font("Palatino Linotype", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tChildBD.ForeColor = System.Drawing.Color.LightCyan
        Me.tChildBD.Location = New System.Drawing.Point(102, 162)
        Me.tChildBD.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tChildBD.Name = "tChildBD"
        Me.tChildBD.Size = New System.Drawing.Size(375, 50)
        Me.tChildBD.TabIndex = 1
        Me.tChildBD.Text = "CHILD            | RM15"
        Me.tChildBD.UseVisualStyleBackColor = True
        '
        'BloodDracula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1707, 819)
        Me.Controls.Add(Me.ClearBtnBD)
        Me.Controls.Add(Me.NextBtnBD)
        Me.Controls.Add(Me.BackBtnBD)
        Me.Controls.Add(Me.QChildBDBox)
        Me.Controls.Add(Me.QChildBD)
        Me.Controls.Add(Me.QAdultBDBox)
        Me.Controls.Add(Me.QAdultBD)
        Me.Controls.Add(Me.tBD)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "BloodDracula"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BloodDracula"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tBD.ResumeLayout(False)
        Me.tBD.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ClearBtnBD As Button
    Friend WithEvents NextBtnBD As Button
    Friend WithEvents BackBtnBD As Button
    Friend WithEvents QChildBDBox As TextBox
    Friend WithEvents QChildBD As Label
    Friend WithEvents QAdultBDBox As TextBox
    Friend WithEvents QAdultBD As Label
    Friend WithEvents tBD As GroupBox
    Friend WithEvents tAdultBD As CheckBox
    Friend WithEvents tChildBD As CheckBox
End Class
