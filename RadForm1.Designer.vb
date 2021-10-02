<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RadForm1
    Inherits Telerik.WinControls.UI.RadForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RadForm1))
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.RadPictureBox6 = New Telerik.WinControls.UI.RadPictureBox()
        Me.RadPictureBox5 = New Telerik.WinControls.UI.RadPictureBox()
        Me.RadPictureBox4 = New Telerik.WinControls.UI.RadPictureBox()
        Me.RadPictureBox3 = New Telerik.WinControls.UI.RadPictureBox()
        Me.RadPictureBox2 = New Telerik.WinControls.UI.RadPictureBox()
        Me.RadPictureBox1 = New Telerik.WinControls.UI.RadPictureBox()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(61, 8)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(76, 21)
        Me.NumericUpDown1.TabIndex = 0
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown2.Location = New System.Drawing.Point(344, 68)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.NumericUpDown2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(58, 25)
        Me.NumericUpDown2.TabIndex = 1
        Me.NumericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown2.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(297, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "个数"
        '
        'RadButton1
        '
        Me.RadButton1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton1.Location = New System.Drawing.Point(301, 122)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(98, 40)
        Me.RadButton1.TabIndex = 8
        Me.RadButton1.Text = "掷骰!"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(289, 170)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(139, 17)
        Me.LinkLabel1.TabIndex = 9
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "关于RM DICE Mode..."
        '
        'RadPictureBox6
        '
        Me.RadPictureBox6.DefaultImage = CType(resources.GetObject("RadPictureBox6.DefaultImage"), System.Drawing.Image)
        Me.RadPictureBox6.DefaultSvgImageXml = resources.GetString("RadPictureBox6.DefaultSvgImageXml")
        Me.RadPictureBox6.Image = Global.TelerikWinFormsApp1.My.Resources.Resources.DICE1
        Me.RadPictureBox6.Location = New System.Drawing.Point(196, 105)
        Me.RadPictureBox6.Name = "RadPictureBox6"
        Me.RadPictureBox6.Size = New System.Drawing.Size(75, 73)
        Me.RadPictureBox6.TabIndex = 7
        '
        'RadPictureBox5
        '
        Me.RadPictureBox5.DefaultImage = CType(resources.GetObject("RadPictureBox5.DefaultImage"), System.Drawing.Image)
        Me.RadPictureBox5.DefaultSvgImageXml = resources.GetString("RadPictureBox5.DefaultSvgImageXml")
        Me.RadPictureBox5.Image = Global.TelerikWinFormsApp1.My.Resources.Resources.DICE1
        Me.RadPictureBox5.Location = New System.Drawing.Point(104, 105)
        Me.RadPictureBox5.Name = "RadPictureBox5"
        Me.RadPictureBox5.Size = New System.Drawing.Size(75, 73)
        Me.RadPictureBox5.TabIndex = 6
        '
        'RadPictureBox4
        '
        Me.RadPictureBox4.DefaultImage = CType(resources.GetObject("RadPictureBox4.DefaultImage"), System.Drawing.Image)
        Me.RadPictureBox4.DefaultSvgImageXml = resources.GetString("RadPictureBox4.DefaultSvgImageXml")
        Me.RadPictureBox4.Image = Global.TelerikWinFormsApp1.My.Resources.Resources.DICE1
        Me.RadPictureBox4.Location = New System.Drawing.Point(14, 105)
        Me.RadPictureBox4.Name = "RadPictureBox4"
        Me.RadPictureBox4.Size = New System.Drawing.Size(75, 73)
        Me.RadPictureBox4.TabIndex = 5
        '
        'RadPictureBox3
        '
        Me.RadPictureBox3.DefaultImage = CType(resources.GetObject("RadPictureBox3.DefaultImage"), System.Drawing.Image)
        Me.RadPictureBox3.DefaultSvgImageXml = resources.GetString("RadPictureBox3.DefaultSvgImageXml")
        Me.RadPictureBox3.Image = Global.TelerikWinFormsApp1.My.Resources.Resources.DICE1
        Me.RadPictureBox3.Location = New System.Drawing.Point(196, 15)
        Me.RadPictureBox3.Name = "RadPictureBox3"
        Me.RadPictureBox3.Size = New System.Drawing.Size(75, 73)
        Me.RadPictureBox3.TabIndex = 4
        '
        'RadPictureBox2
        '
        Me.RadPictureBox2.DefaultImage = CType(resources.GetObject("RadPictureBox2.DefaultImage"), System.Drawing.Image)
        Me.RadPictureBox2.DefaultSvgImageXml = resources.GetString("RadPictureBox2.DefaultSvgImageXml")
        Me.RadPictureBox2.Image = Global.TelerikWinFormsApp1.My.Resources.Resources.DICE1
        Me.RadPictureBox2.Location = New System.Drawing.Point(104, 15)
        Me.RadPictureBox2.Name = "RadPictureBox2"
        Me.RadPictureBox2.Size = New System.Drawing.Size(75, 73)
        Me.RadPictureBox2.TabIndex = 3
        '
        'RadPictureBox1
        '
        Me.RadPictureBox1.DefaultImage = CType(resources.GetObject("RadPictureBox1.DefaultImage"), System.Drawing.Image)
        Me.RadPictureBox1.DefaultSvgImageXml = resources.GetString("RadPictureBox1.DefaultSvgImageXml")
        Me.RadPictureBox1.Image = Global.TelerikWinFormsApp1.My.Resources.Resources.DICE1
        Me.RadPictureBox1.Location = New System.Drawing.Point(14, 15)
        Me.RadPictureBox1.Name = "RadPictureBox1"
        Me.RadPictureBox1.Size = New System.Drawing.Size(75, 73)
        Me.RadPictureBox1.TabIndex = 0
        '
        'RadForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(430, 196)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.RadButton1)
        Me.Controls.Add(Me.RadPictureBox6)
        Me.Controls.Add(Me.RadPictureBox5)
        Me.Controls.Add(Me.RadPictureBox4)
        Me.Controls.Add(Me.RadPictureBox3)
        Me.Controls.Add(Me.RadPictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NumericUpDown2)
        Me.Controls.Add(Me.RadPictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "RadForm1"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RandomMaker v5.2-DICE Mode"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents RadPictureBox1 As Telerik.WinControls.UI.RadPictureBox
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents RadPictureBox2 As Telerik.WinControls.UI.RadPictureBox
    Friend WithEvents RadPictureBox3 As Telerik.WinControls.UI.RadPictureBox
    Friend WithEvents RadPictureBox4 As Telerik.WinControls.UI.RadPictureBox
    Friend WithEvents RadPictureBox5 As Telerik.WinControls.UI.RadPictureBox
    Friend WithEvents RadPictureBox6 As Telerik.WinControls.UI.RadPictureBox
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
