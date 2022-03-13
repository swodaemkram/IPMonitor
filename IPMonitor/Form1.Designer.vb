<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartTestingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopTestingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.StartTestingToolStripMenuItem, Me.StopTestingToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(797, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuitToolStripMenuItem, Me.QuitToolStripMenuItem1})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.QuitToolStripMenuItem.Text = "Save Current Settings"
        '
        'QuitToolStripMenuItem1
        '
        Me.QuitToolStripMenuItem1.Name = "QuitToolStripMenuItem1"
        Me.QuitToolStripMenuItem1.Size = New System.Drawing.Size(186, 22)
        Me.QuitToolStripMenuItem1.Text = "Quit"
        '
        'StartTestingToolStripMenuItem
        '
        Me.StartTestingToolStripMenuItem.Name = "StartTestingToolStripMenuItem"
        Me.StartTestingToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.StartTestingToolStripMenuItem.Text = "Start Testing"
        '
        'StopTestingToolStripMenuItem
        '
        Me.StopTestingToolStripMenuItem.Enabled = False
        Me.StopTestingToolStripMenuItem.Name = "StopTestingToolStripMenuItem"
        Me.StopTestingToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.StopTestingToolStripMenuItem.Text = "Stop Testing"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 39)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.Size = New System.Drawing.Size(537, 522)
        Me.DataGridView1.TabIndex = 1
        '
        'Column5
        '
        Me.Column5.HeaderText = "Host Name"
        Me.Column5.Name = "Column5"
        '
        'Column1
        '
        Me.Column1.HeaderText = "I.P. Address"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Total Pings"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Failed Pings"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "% Loss"
        Me.Column4.Name = "Column4"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox11)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.TextBox10)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.TextBox9)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.TextBox8)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.CheckBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(555, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(233, 522)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Settings"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(89, 219)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(138, 20)
        Me.TextBox9.TabIndex = 25
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(11, 219)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 13)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "To Address :"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(89, 281)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(138, 20)
        Me.TextBox8.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(7, 284)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "System Name :"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(116, 73)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 23)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Send Test Email"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.Location = New System.Drawing.Point(10, 73)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(99, 17)
        Me.CheckBox3.TabIndex = 20
        Me.CheckBox3.Text = "Enable Email"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(6, 373)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(221, 20)
        Me.TextBox7.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(7, 351)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(220, 19)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "WebHook URL :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(10, 331)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(136, 17)
        Me.CheckBox2.TabIndex = 17
        Me.CheckBox2.Text = "Enabled WebHook "
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(0, 305)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(233, 23)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Web Hook"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(10, 91)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(78, 17)
        Me.CheckBox1.TabIndex = 15
        Me.CheckBox1.Text = "TLS/SSL"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(6, 257)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(221, 20)
        Me.TextBox6.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(63, 241)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Senders Address :"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(89, 190)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox5.Size = New System.Drawing.Size(138, 20)
        Me.TextBox5.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(21, 197)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Password :"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(89, 160)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(138, 20)
        Me.TextBox4.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 163)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "User Name :"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(89, 130)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(53, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Port :"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(89, 104)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(138, 20)
        Me.TextBox2.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Server URL :"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Green
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(0, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(233, 23)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Email Setup:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Testing Host :"
        Me.Label3.Visible = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(96, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(50, 20)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(177, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Log :"
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 564)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(797, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 409)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(105, 13)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Web Hook User :"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(116, 409)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(111, 20)
        Me.TextBox10.TabIndex = 27
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(3, 445)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(125, 13)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Web Hook Channel :"
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(127, 442)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(100, 20)
        Me.TextBox11.TabIndex = 29
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 586)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IPMonitor By Mark Meadows V2.00"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartTestingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StopTestingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents QuitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label14 As Label
End Class
