<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frakenstien
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frakenstien))
        Me.tFG = New System.Windows.Forms.GroupBox()
        Me.AdultFG = New System.Windows.Forms.CheckBox()
        Me.ChildFG = New System.Windows.Forms.CheckBox()
        Me.QChildFGBox = New System.Windows.Forms.TextBox()
        Me.BackBtnFG = New System.Windows.Forms.Button()
        Me.QChildFG = New System.Windows.Forms.Label()
        Me.ClearBtnFG = New System.Windows.Forms.Button()
        Me.QAdultFGBox = New System.Windows.Forms.TextBox()
        Me.NextBtnFG = New System.Windows.Forms.Button()
        Me.QAdultFG = New System.Windows.Forms.Label()
        Me.tFG.SuspendLayout()
        Me.SuspendLayout()
        '
        'tFG
        '
        Me.tFG.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tFG.Controls.Add(Me.AdultFG)
        Me.tFG.Controls.Add(Me.ChildFG)
        Me.tFG.Font = New System.Drawing.Font("Stencil", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tFG.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tFG.Location = New System.Drawing.Point(744, 157)
        Me.tFG.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tFG.Name = "tFG"
        Me.tFG.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tFG.Size = New System.Drawing.Size(573, 231)
        Me.tFG.TabIndex = 22
        Me.tFG.TabStop = False
        Me.tFG.Text = "FRANKESTIEN GRAVE TYPE"
        '
        'AdultFG
        '
        Me.AdultFG.AutoSize = True
        Me.AdultFG.Font = New System.Drawing.Font("Palatino Linotype", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdultFG.ForeColor = System.Drawing.Color.YellowGreen
        Me.AdultFG.Location = New System.Drawing.Point(125, 71)
        Me.AdultFG.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AdultFG.Name = "AdultFG"
        Me.AdultFG.Size = New System.Drawing.Size(374, 50)
        Me.AdultFG.TabIndex = 0
        Me.AdultFG.Text = "ADULT           | RM15"
        Me.AdultFG.UseVisualStyleBackColor = True
        '
        'ChildFG
        '
        Me.ChildFG.AutoSize = True
        Me.ChildFG.Font = New System.Drawing.Font("Palatino Linotype", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChildFG.ForeColor = System.Drawing.Color.YellowGreen
        Me.ChildFG.Location = New System.Drawing.Point(125, 142)
        Me.ChildFG.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChildFG.Name = "ChildFG"
        Me.ChildFG.Size = New System.Drawing.Size(375, 50)
        Me.ChildFG.TabIndex = 1
        Me.ChildFG.Text = "CHILD            | RM12"
        Me.ChildFG.UseVisualStyleBackColor = True
        '
        'QChildFGBox
        '
        Me.QChildFGBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.QChildFGBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QChildFGBox.ForeColor = System.Drawing.Color.GreenYellow
        Me.QChildFGBox.Location = New System.Drawing.Point(1119, 476)
        Me.QChildFGBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.QChildFGBox.Name = "QChildFGBox"
        Me.QChildFGBox.Size = New System.Drawing.Size(124, 41)
        Me.QChildFGBox.TabIndex = 26
        Me.QChildFGBox.Visible = False
        '
        'BackBtnFG
        '
        Me.BackBtnFG.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackBtnFG.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackBtnFG.ForeColor = System.Drawing.Color.YellowGreen
        Me.BackBtnFG.Location = New System.Drawing.Point(709, 597)
        Me.BackBtnFG.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BackBtnFG.Name = "BackBtnFG"
        Me.BackBtnFG.Size = New System.Drawing.Size(180, 63)
        Me.BackBtnFG.TabIndex = 29
        Me.BackBtnFG.Text = "BACK"
        Me.BackBtnFG.UseVisualStyleBackColor = False
        '
        'QChildFG
        '
        Me.QChildFG.AutoSize = True
        Me.QChildFG.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.QChildFG.Font = New System.Drawing.Font("Stencil", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QChildFG.ForeColor = System.Drawing.Color.YellowGreen
        Me.QChildFG.Location = New System.Drawing.Point(807, 476)
        Me.QChildFG.Name = "QChildFG"
        Me.QChildFG.Size = New System.Drawing.Size(281, 35)
        Me.QChildFG.TabIndex = 25
        Me.QChildFG.Text = "QUANTITY CHILD  :"
        Me.QChildFG.Visible = False
        '
        'ClearBtnFG
        '
        Me.ClearBtnFG.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClearBtnFG.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearBtnFG.ForeColor = System.Drawing.Color.YellowGreen
        Me.ClearBtnFG.Location = New System.Drawing.Point(938, 597)
        Me.ClearBtnFG.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ClearBtnFG.Name = "ClearBtnFG"
        Me.ClearBtnFG.Size = New System.Drawing.Size(180, 63)
        Me.ClearBtnFG.TabIndex = 28
        Me.ClearBtnFG.Text = "CLEAR"
        Me.ClearBtnFG.UseVisualStyleBackColor = False
        '
        'QAdultFGBox
        '
        Me.QAdultFGBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.QAdultFGBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QAdultFGBox.ForeColor = System.Drawing.Color.GreenYellow
        Me.QAdultFGBox.Location = New System.Drawing.Point(1119, 419)
        Me.QAdultFGBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.QAdultFGBox.Name = "QAdultFGBox"
        Me.QAdultFGBox.Size = New System.Drawing.Size(124, 41)
        Me.QAdultFGBox.TabIndex = 24
        Me.QAdultFGBox.Visible = False
        '
        'NextBtnFG
        '
        Me.NextBtnFG.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.NextBtnFG.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextBtnFG.ForeColor = System.Drawing.Color.YellowGreen
        Me.NextBtnFG.Location = New System.Drawing.Point(1157, 597)
        Me.NextBtnFG.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NextBtnFG.Name = "NextBtnFG"
        Me.NextBtnFG.Size = New System.Drawing.Size(180, 63)
        Me.NextBtnFG.TabIndex = 27
        Me.NextBtnFG.Text = "NEXT"
        Me.NextBtnFG.UseVisualStyleBackColor = False
        '
        'QAdultFG
        '
        Me.QAdultFG.AutoSize = True
        Me.QAdultFG.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.QAdultFG.Font = New System.Drawing.Font("Stencil", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QAdultFG.ForeColor = System.Drawing.Color.YellowGreen
        Me.QAdultFG.Location = New System.Drawing.Point(807, 419)
        Me.QAdultFG.Name = "QAdultFG"
        Me.QAdultFG.Size = New System.Drawing.Size(277, 35)
        Me.QAdultFG.TabIndex = 23
        Me.QAdultFG.Text = "QUANTITY ADULT :"
        Me.QAdultFG.Visible = False
        '
        'Frakenstien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1707, 819)
        Me.Controls.Add(Me.tFG)
        Me.Controls.Add(Me.QChildFGBox)
        Me.Controls.Add(Me.BackBtnFG)
        Me.Controls.Add(Me.QChildFG)
        Me.Controls.Add(Me.ClearBtnFG)
        Me.Controls.Add(Me.QAdultFGBox)
        Me.Controls.Add(Me.NextBtnFG)
        Me.Controls.Add(Me.QAdultFG)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Frakenstien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frakenstien"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tFG.ResumeLayout(False)
        Me.tFG.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tFG As GroupBox
    Friend WithEvents AdultFG As CheckBox
    Friend WithEvents ChildFG As CheckBox
    Friend WithEvents QChildFGBox As TextBox
    Friend WithEvents BackBtnFG As Button
    Friend WithEvents QChildFG As Label
    Friend WithEvents ClearBtnFG As Button
    Friend WithEvents QAdultFGBox As TextBox
    Friend WithEvents NextBtnFG As Button
    Friend WithEvents QAdultFG As Label
End Class
