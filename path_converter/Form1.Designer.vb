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
    	Me.TextBox1 = New System.Windows.Forms.TextBox()
    	Me.TextBox2 = New System.Windows.Forms.TextBox()
    	Me.Label1 = New System.Windows.Forms.Label()
    	Me.Label2 = New System.Windows.Forms.Label()
    	Me.Button1 = New System.Windows.Forms.Button()
    	Me.Button2 = New System.Windows.Forms.Button()
    	Me.Button3 = New System.Windows.Forms.Button()
    	Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    	Me.RadioButton3 = New System.Windows.Forms.RadioButton()
    	Me.RadioButton2 = New System.Windows.Forms.RadioButton()
    	Me.RadioButton1 = New System.Windows.Forms.RadioButton()
    	Me.TabControl1 = New System.Windows.Forms.TabControl()
    	Me.TabPage1 = New System.Windows.Forms.TabPage()
    	Me.Button5 = New System.Windows.Forms.Button()
    	Me.Button4 = New System.Windows.Forms.Button()
    	Me.GroupBox1.SuspendLayout
    	Me.TabControl1.SuspendLayout
    	Me.TabPage1.SuspendLayout
    	Me.SuspendLayout
    	'
    	'TextBox1
    	'
    	Me.TextBox1.Location = New System.Drawing.Point(110, 25)
    	Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    	Me.TextBox1.Name = "TextBox1"
    	Me.TextBox1.Size = New System.Drawing.Size(748, 26)
    	Me.TextBox1.TabIndex = 0
    	'
    	'TextBox2
    	'
    	Me.TextBox2.Enabled = false
    	Me.TextBox2.Location = New System.Drawing.Point(110, 202)
    	Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    	Me.TextBox2.Name = "TextBox2"
    	Me.TextBox2.Size = New System.Drawing.Size(748, 26)
    	Me.TextBox2.TabIndex = 0
    	'
    	'Label1
    	'
    	Me.Label1.AutoSize = true
    	Me.Label1.Location = New System.Drawing.Point(20, 29)
    	Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    	Me.Label1.Name = "Label1"
    	Me.Label1.Size = New System.Drawing.Size(79, 20)
    	Me.Label1.TabIndex = 1
    	Me.Label1.Text = "Real Path"
    	'
    	'Label2
    	'
    	Me.Label2.AutoSize = true
    	Me.Label2.Location = New System.Drawing.Point(20, 206)
    	Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    	Me.Label2.Name = "Label2"
    	Me.Label2.Size = New System.Drawing.Size(77, 20)
    	Me.Label2.TabIndex = 1
    	Me.Label2.Text = "New Path"
    	'
    	'Button1
    	'
    	Me.Button1.Location = New System.Drawing.Point(892, 18)
    	Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    	Me.Button1.Name = "Button1"
    	Me.Button1.Size = New System.Drawing.Size(176, 35)
    	Me.Button1.TabIndex = 2
    	Me.Button1.Text = "&Paste from ClipBoard"
    	Me.Button1.UseVisualStyleBackColor = true
    	'
    	'Button2
    	'
    	Me.Button2.Location = New System.Drawing.Point(278, 302)
    	Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    	Me.Button2.Name = "Button2"
    	Me.Button2.Size = New System.Drawing.Size(284, 35)
    	Me.Button2.TabIndex = 2
    	Me.Button2.Text = "Copy To &ClipBoard"
    	Me.Button2.UseVisualStyleBackColor = true
    	'
    	'Button3
    	'
    	Me.Button3.Location = New System.Drawing.Point(278, 257)
    	Me.Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    	Me.Button3.Name = "Button3"
    	Me.Button3.Size = New System.Drawing.Size(582, 35)
    	Me.Button3.TabIndex = 2
    	Me.Button3.Text = "Copy To ClipBoard And E&xit"
    	Me.Button3.UseVisualStyleBackColor = true
    	'
    	'GroupBox1
    	'
    	Me.GroupBox1.Controls.Add(Me.RadioButton3)
    	Me.GroupBox1.Controls.Add(Me.RadioButton2)
    	Me.GroupBox1.Controls.Add(Me.RadioButton1)
    	Me.GroupBox1.Location = New System.Drawing.Point(326, 88)
    	Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    	Me.GroupBox1.Name = "GroupBox1"
    	Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
    	Me.GroupBox1.Size = New System.Drawing.Size(340, 83)
    	Me.GroupBox1.TabIndex = 3
    	Me.GroupBox1.TabStop = false
    	Me.GroupBox1.Text = "Format"
    	'
    	'RadioButton3
    	'
    	Me.RadioButton3.AutoSize = true
    	Me.RadioButton3.Checked = true
    	Me.RadioButton3.Location = New System.Drawing.Point(22, 29)
    	Me.RadioButton3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    	Me.RadioButton3.Name = "RadioButton3"
    	Me.RadioButton3.Size = New System.Drawing.Size(82, 24)
    	Me.RadioButton3.TabIndex = 2
    	Me.RadioButton3.TabStop = true
    	Me.RadioButton3.Text = "&Detect"
    	Me.RadioButton3.UseVisualStyleBackColor = true
    	'
    	'RadioButton2
    	'
    	Me.RadioButton2.AutoSize = true
    	Me.RadioButton2.Location = New System.Drawing.Point(226, 31)
    	Me.RadioButton2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    	Me.RadioButton2.Name = "RadioButton2"
    	Me.RadioButton2.Size = New System.Drawing.Size(81, 24)
    	Me.RadioButton2.TabIndex = 1
    	Me.RadioButton2.Text = "&2. / to \"
    	Me.RadioButton2.UseVisualStyleBackColor = true
    	'
    	'RadioButton1
    	'
    	Me.RadioButton1.AutoSize = true
    	Me.RadioButton1.Location = New System.Drawing.Point(124, 31)
    	Me.RadioButton1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    	Me.RadioButton1.Name = "RadioButton1"
    	Me.RadioButton1.Size = New System.Drawing.Size(81, 24)
    	Me.RadioButton1.TabIndex = 0
    	Me.RadioButton1.Text = "&1. \ to /"
    	Me.RadioButton1.UseVisualStyleBackColor = true
    	'
    	'TabControl1
    	'
    	Me.TabControl1.Controls.Add(Me.TabPage1)
    	Me.TabControl1.Location = New System.Drawing.Point(18, 18)
    	Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    	Me.TabControl1.Name = "TabControl1"
    	Me.TabControl1.SelectedIndex = 0
    	Me.TabControl1.Size = New System.Drawing.Size(1110, 398)
    	Me.TabControl1.TabIndex = 4
    	'
    	'TabPage1
    	'
    	Me.TabPage1.Controls.Add(Me.Button5)
    	Me.TabPage1.Controls.Add(Me.Button4)
    	Me.TabPage1.Controls.Add(Me.TextBox1)
    	Me.TabPage1.Controls.Add(Me.GroupBox1)
    	Me.TabPage1.Controls.Add(Me.TextBox2)
    	Me.TabPage1.Controls.Add(Me.Button3)
    	Me.TabPage1.Controls.Add(Me.Label1)
    	Me.TabPage1.Controls.Add(Me.Button2)
    	Me.TabPage1.Controls.Add(Me.Label2)
    	Me.TabPage1.Controls.Add(Me.Button1)
    	Me.TabPage1.Location = New System.Drawing.Point(4, 29)
    	Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    	Me.TabPage1.Name = "TabPage1"
    	Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
    	Me.TabPage1.Size = New System.Drawing.Size(1102, 365)
    	Me.TabPage1.TabIndex = 0
    	Me.TabPage1.Text = "Path Converter"
    	Me.TabPage1.UseVisualStyleBackColor = true
    	'
    	'Button5
    	'
    	Me.Button5.Location = New System.Drawing.Point(570, 302)
    	Me.Button5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    	Me.Button5.Name = "Button5"
    	Me.Button5.Size = New System.Drawing.Size(290, 35)
    	Me.Button5.TabIndex = 5
    	Me.Button5.Text = "Copy Parent Directory to ClipBoard"
    	Me.Button5.UseVisualStyleBackColor = true
    	'
    	'Button4
    	'
    	Me.Button4.Location = New System.Drawing.Point(892, 198)
    	Me.Button4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    	Me.Button4.Name = "Button4"
    	Me.Button4.Size = New System.Drawing.Size(176, 35)
    	Me.Button4.TabIndex = 4
    	Me.Button4.Text = "Open in Explorer"
    	Me.Button4.UseVisualStyleBackColor = true
    	'
    	'Form1
    	'
    	Me.AutoScaleDimensions = New System.Drawing.SizeF(9!, 20!)
    	Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    	Me.ClientSize = New System.Drawing.Size(1149, 442)
    	Me.Controls.Add(Me.TabControl1)
    	Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
    	Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    	Me.Name = "Form1"
    	Me.Text = "Path Converter"
    	Me.GroupBox1.ResumeLayout(false)
    	Me.GroupBox1.PerformLayout
    	Me.TabControl1.ResumeLayout(false)
    	Me.TabPage1.ResumeLayout(false)
    	Me.TabPage1.PerformLayout
    	Me.ResumeLayout(false)
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents RadioButton3 As RadioButton
End Class
