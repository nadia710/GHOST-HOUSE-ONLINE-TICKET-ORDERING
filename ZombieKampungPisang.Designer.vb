<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ZombieKampungPisang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ZombieKampungPisang))
        Me.tZombie = New System.Windows.Forms.GroupBox()
        Me.AdultZ = New System.Windows.Forms.CheckBox()
        Me.ChildZ = New System.Windows.Forms.CheckBox()
        Me.QChildZBoxs = New System.Windows.Forms.TextBox()
        Me.QChildZs = New System.Windows.Forms.Label()
        Me.QAdultZBoxs = New System.Windows.Forms.TextBox()
        Me.QAdultZs = New System.Windows.Forms.Label()
        Me.ClearBtnZ = New System.Windows.Forms.Button()
        Me.NextBtnZ = New System.Windows.Forms.Button()
        Me.BackBtnZ = New System.Windows.Forms.Button()
        Me.tZombie.SuspendLayout()
        Me.SuspendLayout()
        '
        'tZombie
        '
        Me.tZombie.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tZombie.Controls.Add(Me.AdultZ)
        Me.tZombie.Controls.Add(Me.ChildZ)
        Me.tZombie.Font = New System.Drawing.Font("Stencil", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tZombie.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tZombie.Location = New System.Drawing.Point(711, 200)
        Me.tZombie.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tZombie.Name = "tZombie"
        Me.tZombie.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tZombie.Size = New System.Drawing.Size(694, 297)
        Me.tZombie.TabIndex = 19
        Me.tZombie.TabStop = False
        Me.tZombie.Text = "ZOMBIE KAMPUNG PISANG TYPE"
        '
        'AdultZ
        '
        Me.AdultZ.AutoSize = True
        Me.AdultZ.Font = New System.Drawing.Font("Palatino Linotype", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdultZ.ForeColor = System.Drawing.Color.SandyBrown
        Me.AdultZ.Location = New System.Drawing.Point(165, 99)
        Me.AdultZ.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AdultZ.Name = "AdultZ"
        Me.AdultZ.Size = New System.Drawing.Size(374, 50)
        Me.AdultZ.TabIndex = 0
        Me.AdultZ.Text = "ADULT           | RM15"
        Me.AdultZ.UseVisualStyleBackColor = True
        '
        'ChildZ
        '
        Me.ChildZ.AutoSize = True
        Me.ChildZ.Font = New System.Drawing.Font("Palatino Linotype", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChildZ.ForeColor = System.Drawing.Color.SandyBrown
        Me.ChildZ.Location = New System.Drawing.Point(165, 173)
        Me.ChildZ.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChildZ.Name = "ChildZ"
        Me.ChildZ.Size = New System.Drawing.Size(375, 50)
        Me.ChildZ.TabIndex = 1
        Me.ChildZ.Text = "CHILD            | RM10"
        Me.ChildZ.UseVisualStyleBackColor = True
        '
        'QChildZBoxs
        '
        Me.QChildZBoxs.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.QChildZBoxs.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QChildZBoxs.ForeColor = System.Drawing.Color.SandyBrown
        Me.QChildZBoxs.Location = New System.Drawing.Point(1143, 616)
        Me.QChildZBoxs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.QChildZBoxs.Name = "QChildZBoxs"
        Me.QChildZBoxs.Size = New System.Drawing.Size(124, 41)
        Me.QChildZBoxs.TabIndex = 30
        Me.QChildZBoxs.Visible = False
        '
        'QChildZs
        '
        Me.QChildZs.AutoSize = True
        Me.QChildZs.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.QChildZs.Font = New System.Drawing.Font("Stencil", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QChildZs.ForeColor = System.Drawing.Color.SandyBrown
        Me.QChildZs.Location = New System.Drawing.Point(829, 622)
        Me.QChildZs.Name = "QChildZs"
        Me.QChildZs.Size = New System.Drawing.Size(281, 35)
        Me.QChildZs.TabIndex = 29
        Me.QChildZs.Text = "QUANTITY CHILD  :"
        Me.QChildZs.Visible = False
        '
        'QAdultZBoxs
        '
        Me.QAdultZBoxs.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.QAdultZBoxs.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QAdultZBoxs.ForeColor = System.Drawing.Color.SandyBrown
        Me.QAdultZBoxs.Location = New System.Drawing.Point(1143, 554)
        Me.QAdultZBoxs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.QAdultZBoxs.Name = "QAdultZBoxs"
        Me.QAdultZBoxs.Size = New System.Drawing.Size(124, 41)
        Me.QAdultZBoxs.TabIndex = 28
        Me.QAdultZBoxs.Visible = False
        '
        'QAdultZs
        '
        Me.QAdultZs.AutoSize = True
        Me.QAdultZs.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.QAdultZs.Font = New System.Drawing.Font("Stencil", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QAdultZs.ForeColor = System.Drawing.Color.SandyBrown
        Me.QAdultZs.Location = New System.Drawing.Point(829, 559)
        Me.QAdultZs.Name = "QAdultZs"
        Me.QAdultZs.Size = New System.Drawing.Size(277, 35)
        Me.QAdultZs.TabIndex = 27
        Me.QAdultZs.Text = "QUANTITY ADULT :"
        Me.QAdultZs.Visible = False
        '
        'ClearBtnZ
        '
        Me.ClearBtnZ.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClearBtnZ.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearBtnZ.ForeColor = System.Drawing.Color.SandyBrown
        Me.ClearBtnZ.Location = New System.Drawing.Point(973, 728)
        Me.ClearBtnZ.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ClearBtnZ.Name = "ClearBtnZ"
        Me.ClearBtnZ.Size = New System.Drawing.Size(175, 56)
        Me.ClearBtnZ.TabIndex = 33
        Me.ClearBtnZ.Text = "CLEAR"
        Me.ClearBtnZ.UseVisualStyleBackColor = False
        '
        'NextBtnZ
        '
        Me.NextBtnZ.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.NextBtnZ.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextBtnZ.ForeColor = System.Drawing.Color.SandyBrown
        Me.NextBtnZ.Location = New System.Drawing.Point(1206, 728)
        Me.NextBtnZ.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NextBtnZ.Name = "NextBtnZ"
        Me.NextBtnZ.Size = New System.Drawing.Size(175, 56)
        Me.NextBtnZ.TabIndex = 32
        Me.NextBtnZ.Text = "NEXT"
        Me.NextBtnZ.UseVisualStyleBackColor = False
        '
        'BackBtnZ
        '
        Me.BackBtnZ.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackBtnZ.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackBtnZ.ForeColor = System.Drawing.Color.SandyBrown
        Me.BackBtnZ.Location = New System.Drawing.Point(734, 728)
        Me.BackBtnZ.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BackBtnZ.Name = "BackBtnZ"
        Me.BackBtnZ.Size = New System.Drawing.Size(175, 56)
        Me.BackBtnZ.TabIndex = 31
        Me.BackBtnZ.Text = "BACK"
        Me.BackBtnZ.UseVisualStyleBackColor = False
        '
        'ZombieKampungPisang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1906, 1033)
        Me.Controls.Add(Me.ClearBtnZ)
        Me.Controls.Add(Me.NextBtnZ)
        Me.Controls.Add(Me.BackBtnZ)
        Me.Controls.Add(Me.QChildZBoxs)
        Me.Controls.Add(Me.QChildZs)
        Me.Controls.Add(Me.QAdultZBoxs)
        Me.Controls.Add(Me.QAdultZs)
        Me.Controls.Add(Me.tZombie)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "ZombieKampungPisang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ZombieKampungPisang"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tZombie.ResumeLayout(False)
        Me.tZombie.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tZombie As GroupBox
    Friend WithEvents AdultZ As CheckBox
    Friend WithEvents ChildZ As CheckBox
    Friend WithEvents QChildZBoxs As TextBox
    Friend WithEvents QChildZs As Label
    Friend WithEvents QAdultZBoxs As TextBox
    Friend WithEvents QAdultZs As Label
    Friend WithEvents ClearBtnZ As Button
    Friend WithEvents NextBtnZ As Button
    Friend WithEvents BackBtnZ As Button
End Class
