<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Western
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Western))
        Me.nextBtn = New System.Windows.Forms.Button()
        Me.backBtn = New System.Windows.Forms.Button()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.bdBox = New System.Windows.Forms.RadioButton()
        Me.fgBox = New System.Windows.Forms.RadioButton()
        Me.pcBox = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'nextBtn
        '
        Me.nextBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.nextBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nextBtn.ForeColor = System.Drawing.Color.Black
        Me.nextBtn.Location = New System.Drawing.Point(1239, 596)
        Me.nextBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nextBtn.Name = "nextBtn"
        Me.nextBtn.Size = New System.Drawing.Size(172, 67)
        Me.nextBtn.TabIndex = 71
        Me.nextBtn.Text = "NEXT"
        Me.nextBtn.UseVisualStyleBackColor = False
        '
        'backBtn
        '
        Me.backBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.backBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backBtn.ForeColor = System.Drawing.Color.Black
        Me.backBtn.Location = New System.Drawing.Point(997, 596)
        Me.backBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(172, 67)
        Me.backBtn.TabIndex = 69
        Me.backBtn.Text = "BACK"
        Me.backBtn.UseVisualStyleBackColor = False
        '
        'clearBtn
        '
        Me.clearBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.clearBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearBtn.ForeColor = System.Drawing.Color.Black
        Me.clearBtn.Location = New System.Drawing.Point(756, 596)
        Me.clearBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(172, 67)
        Me.clearBtn.TabIndex = 70
        Me.clearBtn.Text = "CLEAR"
        Me.clearBtn.UseVisualStyleBackColor = False
        '
        'bdBox
        '
        Me.bdBox.AutoSize = True
        Me.bdBox.Font = New System.Drawing.Font("Palatino Linotype", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bdBox.ForeColor = System.Drawing.Color.OrangeRed
        Me.bdBox.Location = New System.Drawing.Point(121, 117)
        Me.bdBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bdBox.Name = "bdBox"
        Me.bdBox.Size = New System.Drawing.Size(344, 50)
        Me.bdBox.TabIndex = 2
        Me.bdBox.TabStop = True
        Me.bdBox.Text = "BLOOD DRACULA"
        Me.bdBox.UseVisualStyleBackColor = True
        '
        'fgBox
        '
        Me.fgBox.AutoSize = True
        Me.fgBox.Font = New System.Drawing.Font("Palatino Linotype", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fgBox.ForeColor = System.Drawing.Color.OrangeRed
        Me.fgBox.Location = New System.Drawing.Point(121, 182)
        Me.fgBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.fgBox.Name = "fgBox"
        Me.fgBox.Size = New System.Drawing.Size(420, 50)
        Me.fgBox.TabIndex = 1
        Me.fgBox.TabStop = True
        Me.fgBox.Text = "FRANKEISTEIN GRAVE"
        Me.fgBox.UseVisualStyleBackColor = True
        '
        'pcBox
        '
        Me.pcBox.AutoSize = True
        Me.pcBox.Font = New System.Drawing.Font("Palatino Linotype", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pcBox.ForeColor = System.Drawing.Color.OrangeRed
        Me.pcBox.Location = New System.Drawing.Point(121, 63)
        Me.pcBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pcBox.Name = "pcBox"
        Me.pcBox.Size = New System.Drawing.Size(305, 50)
        Me.pcBox.TabIndex = 0
        Me.pcBox.TabStop = True
        Me.pcBox.Text = "PARTY CLOWN " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.pcBox.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Red
        Me.Label4.Font = New System.Drawing.Font("Snap ITC", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label4.Location = New System.Drawing.Point(593, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(840, 77)
        Me.Label4.TabIndex = 83
        Me.Label4.Text = "PACKAGE (WESTERN)"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.Controls.Add(Me.bdBox)
        Me.GroupBox2.Controls.Add(Me.fgBox)
        Me.GroupBox2.Controls.Add(Me.pcBox)
        Me.GroupBox2.Font = New System.Drawing.Font("Stencil", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(756, 220)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(645, 293)
        Me.GroupBox2.TabIndex = 84
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "WESTERN:"
        '
        'Western
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1707, 819)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.nextBtn)
        Me.Controls.Add(Me.backBtn)
        Me.Controls.Add(Me.clearBtn)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Western"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Western"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nextBtn As Button
    Friend WithEvents backBtn As Button
    Friend WithEvents clearBtn As Button
    Friend WithEvents bdBox As RadioButton
    Friend WithEvents fgBox As RadioButton
    Friend WithEvents pcBox As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
End Class
