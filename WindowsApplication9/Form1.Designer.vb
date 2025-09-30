<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.BurlyWood
        Me.Button1.Font = New System.Drawing.Font("Mudir MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button1.Location = New System.Drawing.Point(292, 200)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 36)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "تنفيذ العملية"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.BurlyWood
        Me.Button2.Font = New System.Drawing.Font("Mudir MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button2.Location = New System.Drawing.Point(283, 265)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 36)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "آلة حاسبة متقدمة"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.BurlyWood
        Me.Button3.Font = New System.Drawing.Font("Mudir MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button3.Location = New System.Drawing.Point(162, 230)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(92, 36)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "الخروج"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Bisque
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Font = New System.Drawing.Font("Mudir MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(27, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(122, 190)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "العمليات الحسابية"
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(26, 143)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(80, 29)
        Me.RadioButton4.TabIndex = 7
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "القسمة  (/)"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(24, 108)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(82, 29)
        Me.RadioButton3.TabIndex = 6
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "الضرب  (*)"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(26, 73)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(80, 29)
        Me.RadioButton2.TabIndex = 5
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "الطرح  (-)"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(24, 35)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(82, 29)
        Me.RadioButton1.TabIndex = 4
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "الجمع  (+)"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Sienna
        Me.Label1.Font = New System.Drawing.Font("Mudir MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(335, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "العدد الأول"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Sienna
        Me.Label2.Font = New System.Drawing.Font("Mudir MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(341, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "العدد الثاني"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.SaddleBrown
        Me.Label3.Font = New System.Drawing.Font("Mudir MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(341, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 30)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "الناتج"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(209, 56)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 8
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(209, 100)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 9
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(209, 154)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ClientSize = New System.Drawing.Size(436, 312)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "آلة حاسبة بسيطة"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
End Class
