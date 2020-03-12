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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.namebox = New System.Windows.Forms.TextBox()
        Me.agebox = New System.Windows.Forms.TextBox()
        Me.addressbox = New System.Windows.Forms.TextBox()
        Me.jsonbutton = New System.Windows.Forms.Button()
        Me.txtbutton = New System.Windows.Forms.Button()
        Me.xmlbutton = New System.Windows.Forms.Button()
        Me.clearbutton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-48, -47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(859, 502)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(130, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(130, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 34)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "AGE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(130, 223)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 34)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ADDRESS"
        '
        'namebox
        '
        Me.namebox.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.namebox.Font = New System.Drawing.Font("Bodoni MT", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namebox.Location = New System.Drawing.Point(295, 88)
        Me.namebox.Name = "namebox"
        Me.namebox.Size = New System.Drawing.Size(434, 37)
        Me.namebox.TabIndex = 3
        '
        'agebox
        '
        Me.agebox.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.agebox.Font = New System.Drawing.Font("Bodoni MT", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agebox.Location = New System.Drawing.Point(295, 155)
        Me.agebox.Name = "agebox"
        Me.agebox.Size = New System.Drawing.Size(434, 37)
        Me.agebox.TabIndex = 4
        '
        'addressbox
        '
        Me.addressbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.addressbox.Font = New System.Drawing.Font("Bodoni MT", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addressbox.Location = New System.Drawing.Point(295, 221)
        Me.addressbox.Name = "addressbox"
        Me.addressbox.Size = New System.Drawing.Size(434, 37)
        Me.addressbox.TabIndex = 5
        '
        'jsonbutton
        '
        Me.jsonbutton.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.jsonbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.jsonbutton.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jsonbutton.Location = New System.Drawing.Point(444, 316)
        Me.jsonbutton.Name = "jsonbutton"
        Me.jsonbutton.Size = New System.Drawing.Size(125, 42)
        Me.jsonbutton.TabIndex = 8
        Me.jsonbutton.Text = "JSON"
        Me.jsonbutton.UseVisualStyleBackColor = False
        '
        'txtbutton
        '
        Me.txtbutton.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.txtbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtbutton.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtbutton.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbutton.Location = New System.Drawing.Point(135, 316)
        Me.txtbutton.Name = "txtbutton"
        Me.txtbutton.Size = New System.Drawing.Size(125, 42)
        Me.txtbutton.TabIndex = 6
        Me.txtbutton.Text = "TXT"
        Me.txtbutton.UseVisualStyleBackColor = False
        '
        'xmlbutton
        '
        Me.xmlbutton.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.xmlbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.xmlbutton.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xmlbutton.Location = New System.Drawing.Point(292, 316)
        Me.xmlbutton.Name = "xmlbutton"
        Me.xmlbutton.Size = New System.Drawing.Size(125, 42)
        Me.xmlbutton.TabIndex = 7
        Me.xmlbutton.Text = "XML"
        Me.xmlbutton.UseVisualStyleBackColor = False
        '
        'clearbutton
        '
        Me.clearbutton.BackColor = System.Drawing.Color.Gray
        Me.clearbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.clearbutton.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearbutton.Location = New System.Drawing.Point(604, 316)
        Me.clearbutton.Name = "clearbutton"
        Me.clearbutton.Size = New System.Drawing.Size(125, 42)
        Me.clearbutton.TabIndex = 9
        Me.clearbutton.Text = "CLEAR"
        Me.clearbutton.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 445)
        Me.Controls.Add(Me.clearbutton)
        Me.Controls.Add(Me.xmlbutton)
        Me.Controls.Add(Me.txtbutton)
        Me.Controls.Add(Me.jsonbutton)
        Me.Controls.Add(Me.addressbox)
        Me.Controls.Add(Me.agebox)
        Me.Controls.Add(Me.namebox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.Text = "EXERCISE 4: TXT / XML / JSON"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents namebox As TextBox
    Friend WithEvents agebox As TextBox
    Friend WithEvents addressbox As TextBox
    Friend WithEvents jsonbutton As Button
    Friend WithEvents txtbutton As Button
    Friend WithEvents xmlbutton As Button
    Friend WithEvents clearbutton As Button
End Class
