<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Opening
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Opening))
        Me.nextBtn = New System.Windows.Forms.Button()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.phonetxt = New System.Windows.Forms.TextBox()
        Me.nametxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'nextBtn
        '
        Me.nextBtn.BackColor = System.Drawing.Color.DarkRed
        Me.nextBtn.BackgroundImage = CType(resources.GetObject("nextBtn.BackgroundImage"), System.Drawing.Image)
        Me.nextBtn.Font = New System.Drawing.Font("Showcard Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nextBtn.ForeColor = System.Drawing.Color.White
        Me.nextBtn.Image = CType(resources.GetObject("nextBtn.Image"), System.Drawing.Image)
        Me.nextBtn.Location = New System.Drawing.Point(1183, 572)
        Me.nextBtn.Name = "nextBtn"
        Me.nextBtn.Size = New System.Drawing.Size(317, 64)
        Me.nextBtn.TabIndex = 35
        Me.nextBtn.Text = "NEXT"
        Me.nextBtn.UseVisualStyleBackColor = False
        '
        'clearBtn
        '
        Me.clearBtn.BackColor = System.Drawing.Color.LightGray
        Me.clearBtn.Font = New System.Drawing.Font("Showcard Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearBtn.ForeColor = System.Drawing.Color.White
        Me.clearBtn.Image = CType(resources.GetObject("clearBtn.Image"), System.Drawing.Image)
        Me.clearBtn.Location = New System.Drawing.Point(1189, 656)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.clearBtn.Size = New System.Drawing.Size(311, 68)
        Me.clearBtn.TabIndex = 34
        Me.clearBtn.Text = "CLEAR"
        Me.clearBtn.UseVisualStyleBackColor = False
        '
        'phonetxt
        '
        Me.phonetxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phonetxt.Location = New System.Drawing.Point(1207, 444)
        Me.phonetxt.Name = "phonetxt"
        Me.phonetxt.Size = New System.Drawing.Size(304, 45)
        Me.phonetxt.TabIndex = 33
        '
        'nametxt
        '
        Me.nametxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nametxt.Location = New System.Drawing.Point(1207, 375)
        Me.nametxt.Name = "nametxt"
        Me.nametxt.Size = New System.Drawing.Size(304, 45)
        Me.nametxt.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Viner Hand ITC", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(954, 444)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(214, 55)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "NO PHONE :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Viner Hand ITC", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(1018, 375)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 55)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "NAME :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Perpetua Titling MT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(1036, 228)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(577, 48)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Ticket Booking System"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Constantia", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(1346, 285)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(267, 49)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "LOGIN PAGE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Chiller", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(935, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(740, 139)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "NIGHT AT EVIL'S"
        '
        'Opening
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1707, 819)
        Me.Controls.Add(Me.nextBtn)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.phonetxt)
        Me.Controls.Add(Me.nametxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Opening"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Opening"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nextBtn As Button
    Friend WithEvents clearBtn As Button
    Friend WithEvents phonetxt As TextBox
    Friend WithEvents nametxt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
