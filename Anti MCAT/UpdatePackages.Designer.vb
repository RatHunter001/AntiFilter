<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdatePackages
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdatePackages))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.FastColoredTextBox1 = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.FastColoredTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(350, 173)
        Me.ListBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 192)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(169, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Download"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(193, 192)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(169, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Refresh"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FastColoredTextBox1
        '
        Me.FastColoredTextBox1.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.FastColoredTextBox1.AutoScrollMinSize = New System.Drawing.Size(27, 14)
        Me.FastColoredTextBox1.BackBrush = Nothing
        Me.FastColoredTextBox1.CharHeight = 14
        Me.FastColoredTextBox1.CharWidth = 8
        Me.FastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.FastColoredTextBox1.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.FastColoredTextBox1.IsReplaceMode = False
        Me.FastColoredTextBox1.Location = New System.Drawing.Point(13, 238)
        Me.FastColoredTextBox1.Name = "FastColoredTextBox1"
        Me.FastColoredTextBox1.Paddings = New System.Windows.Forms.Padding(0)
        Me.FastColoredTextBox1.ReadOnly = True
        Me.FastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FastColoredTextBox1.ServiceColors = CType(resources.GetObject("FastColoredTextBox1.ServiceColors"), FastColoredTextBoxNS.ServiceColors)
        Me.FastColoredTextBox1.Size = New System.Drawing.Size(349, 187)
        Me.FastColoredTextBox1.TabIndex = 3
        Me.FastColoredTextBox1.Zoom = 100
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(13, 431)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(349, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Install"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 222)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "JSON Preview*:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 489)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(250, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "*Preview might show results wrong due to encoding"
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(12, 460)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(49, 23)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Back"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'UpdatePackages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 511)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.FastColoredTextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(390, 550)
        Me.MinimumSize = New System.Drawing.Size(390, 550)
        Me.Name = "UpdatePackages"
        Me.Text = "Update Packages"
        CType(Me.FastColoredTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents FastColoredTextBox1 As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button4 As Button
End Class
