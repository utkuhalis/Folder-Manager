<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MsgForm
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
        Me.MsgFormTheme = New WindowsApplication1.MiniTimer_ThemeContainer()
        Me.MsgText = New WindowsApplication1.MiniTimer_Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MsgFormTheme.SuspendLayout()
        Me.SuspendLayout()
        '
        'MsgFormTheme
        '
        Me.MsgFormTheme.BackColor = System.Drawing.Color.White
        Me.MsgFormTheme.Controls.Add(Me.Button2)
        Me.MsgFormTheme.Controls.Add(Me.Button1)
        Me.MsgFormTheme.Controls.Add(Me.MsgText)
        Me.MsgFormTheme.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MsgFormTheme.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MsgFormTheme.Location = New System.Drawing.Point(0, 0)
        Me.MsgFormTheme.Name = "MsgFormTheme"
        Me.MsgFormTheme.Padding = New System.Windows.Forms.Padding(20, 56, 20, 16)
        Me.MsgFormTheme.RoundCorners = False
        Me.MsgFormTheme.Sizable = False
        Me.MsgFormTheme.Size = New System.Drawing.Size(416, 153)
        Me.MsgFormTheme.SmartBounds = True
        Me.MsgFormTheme.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MsgFormTheme.TabIndex = 0
        Me.MsgFormTheme.Text = "Message"
        '
        'MsgText
        '
        Me.MsgText.AutoSize = True
        Me.MsgText.BackColor = System.Drawing.Color.Transparent
        Me.MsgText.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.MsgText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.MsgText.Location = New System.Drawing.Point(12, 56)
        Me.MsgText.Name = "MsgText"
        Me.MsgText.Size = New System.Drawing.Size(90, 16)
        Me.MsgText.TabIndex = 0
        Me.MsgText.Text = "Message_Text"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(12, 118)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(329, 118)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Confirm"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MsgForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 153)
        Me.Controls.Add(Me.MsgFormTheme)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(261, 65)
        Me.Name = "MsgForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Message"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.MsgFormTheme.ResumeLayout(False)
        Me.MsgFormTheme.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MsgFormTheme As MiniTimer_ThemeContainer
    Friend WithEvents MsgText As MiniTimer_Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
