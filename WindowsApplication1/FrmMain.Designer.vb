<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
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
        Me.AddDir = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.AddOther = New System.Windows.Forms.Timer(Me.components)
        Me.MiniTimer_ThemeContainer1 = New WindowsApplication1.MiniTimer_ThemeContainer()
        Me.Info = New WindowsApplication1.MiniTimer_Label()
        Me.ClickName = New System.Windows.Forms.Label()
        Me.BackButton = New WindowsApplication1.MiniTimer_Button_1()
        Me.LocationURL = New WindowsApplication1.TxtBox()
        Me.DirList = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.NewMenu = New WindowsApplication1.PanelBox()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.RRightMenu = New WindowsApplication1.PanelBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.RightMenu = New WindowsApplication1.PanelBox()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.FileList = New System.Windows.Forms.ListBox()
        Me.VLA = New System.Windows.Forms.Label()
        Me.VLI = New System.Windows.Forms.Label()
        Me.MiniTimer_ControlBox1 = New WindowsApplication1.MiniTimer_ControlBox()
        Me.MiniTimer_ThemeContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.NewMenu.SuspendLayout()
        Me.RRightMenu.SuspendLayout()
        Me.RightMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'AddDir
        '
        Me.AddDir.Interval = 1
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'AddOther
        '
        Me.AddOther.Interval = 1
        '
        'MiniTimer_ThemeContainer1
        '
        Me.MiniTimer_ThemeContainer1.BackColor = System.Drawing.Color.White
        Me.MiniTimer_ThemeContainer1.Controls.Add(Me.Info)
        Me.MiniTimer_ThemeContainer1.Controls.Add(Me.ClickName)
        Me.MiniTimer_ThemeContainer1.Controls.Add(Me.BackButton)
        Me.MiniTimer_ThemeContainer1.Controls.Add(Me.LocationURL)
        Me.MiniTimer_ThemeContainer1.Controls.Add(Me.DirList)
        Me.MiniTimer_ThemeContainer1.Controls.Add(Me.Panel1)
        Me.MiniTimer_ThemeContainer1.Controls.Add(Me.FileList)
        Me.MiniTimer_ThemeContainer1.Controls.Add(Me.VLA)
        Me.MiniTimer_ThemeContainer1.Controls.Add(Me.VLI)
        Me.MiniTimer_ThemeContainer1.Controls.Add(Me.MiniTimer_ControlBox1)
        Me.MiniTimer_ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MiniTimer_ThemeContainer1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MiniTimer_ThemeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.MiniTimer_ThemeContainer1.MinimumSize = New System.Drawing.Size(261, 65)
        Me.MiniTimer_ThemeContainer1.Name = "MiniTimer_ThemeContainer1"
        Me.MiniTimer_ThemeContainer1.Padding = New System.Windows.Forms.Padding(20, 56, 20, 16)
        Me.MiniTimer_ThemeContainer1.RoundCorners = False
        Me.MiniTimer_ThemeContainer1.Sizable = True
        Me.MiniTimer_ThemeContainer1.Size = New System.Drawing.Size(700, 500)
        Me.MiniTimer_ThemeContainer1.SmartBounds = True
        Me.MiniTimer_ThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MiniTimer_ThemeContainer1.TabIndex = 0
        Me.MiniTimer_ThemeContainer1.Text = "File Manager"
        '
        'Info
        '
        Me.Info.AutoSize = True
        Me.Info.BackColor = System.Drawing.Color.Transparent
        Me.Info.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Info.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Info.Location = New System.Drawing.Point(12, 464)
        Me.Info.Name = "Info"
        Me.Info.Size = New System.Drawing.Size(33, 16)
        Me.Info.TabIndex = 9
        Me.Info.Text = "-----"
        Me.Info.Visible = False
        '
        'ClickName
        '
        Me.ClickName.AutoSize = True
        Me.ClickName.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClickName.Font = New System.Drawing.Font("Roboto Cn", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ClickName.ForeColor = System.Drawing.Color.Black
        Me.ClickName.Location = New System.Drawing.Point(583, 480)
        Me.ClickName.Name = "ClickName"
        Me.ClickName.Size = New System.Drawing.Size(41, 15)
        Me.ClickName.TabIndex = 8
        Me.ClickName.Text = "Label1"
        Me.ClickName.Visible = False
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.Transparent
        Me.BackButton.Image = Nothing
        Me.BackButton.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BackButton.Location = New System.Drawing.Point(7, 44)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(27, 27)
        Me.BackButton.TabIndex = 0
        '
        'LocationURL
        '
        Me.LocationURL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LocationURL.BackColor = System.Drawing.Color.White
        Me.LocationURL.Image = Nothing
        Me.LocationURL.Location = New System.Drawing.Point(40, 44)
        Me.LocationURL.MaxLength = 32767
        Me.LocationURL.Name = "LocationURL"
        Me.LocationURL.NoRounding = False
        Me.LocationURL.Size = New System.Drawing.Size(660, 31)
        Me.LocationURL.TabIndex = 0
        Me.LocationURL.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.LocationURL.UseSystemPasswordChar = False
        '
        'DirList
        '
        Me.DirList.FormattingEnabled = True
        Me.DirList.ItemHeight = 15
        Me.DirList.Location = New System.Drawing.Point(630, 476)
        Me.DirList.Name = "DirList"
        Me.DirList.Size = New System.Drawing.Size(26, 19)
        Me.DirList.TabIndex = 5
        Me.DirList.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.NewMenu)
        Me.Panel1.Controls.Add(Me.RRightMenu)
        Me.Panel1.Controls.Add(Me.RightMenu)
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(0, 77)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(700, 378)
        Me.Panel1.TabIndex = 7
        '
        'NewMenu
        '
        Me.NewMenu.Controls.Add(Me.Button16)
        Me.NewMenu.Controls.Add(Me.Button11)
        Me.NewMenu.Controls.Add(Me.Button12)
        Me.NewMenu.Controls.Add(Me.Button13)
        Me.NewMenu.Controls.Add(Me.Button14)
        Me.NewMenu.Controls.Add(Me.Button15)
        Me.NewMenu.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.NewMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.NewMenu.Location = New System.Drawing.Point(464, 181)
        Me.NewMenu.Name = "NewMenu"
        Me.NewMenu.NoRounding = False
        Me.NewMenu.Size = New System.Drawing.Size(220, 180)
        Me.NewMenu.TabIndex = 6
        Me.NewMenu.Visible = False
        '
        'Button16
        '
        Me.Button16.BackColor = System.Drawing.Color.Transparent
        Me.Button16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button16.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown
        Me.Button16.FlatAppearance.BorderSize = 0
        Me.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button16.ForeColor = System.Drawing.Color.Black
        Me.Button16.Location = New System.Drawing.Point(0, 150)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(220, 30)
        Me.Button16.TabIndex = 6
        Me.Button16.Text = "Terminal File(*.Ter)"
        Me.Button16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button16.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.Transparent
        Me.Button11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button11.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown
        Me.Button11.FlatAppearance.BorderSize = 0
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.ForeColor = System.Drawing.Color.Black
        Me.Button11.Location = New System.Drawing.Point(0, 120)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(220, 30)
        Me.Button11.TabIndex = 5
        Me.Button11.Text = "LanLang File(*.ll)"
        Me.Button11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.Transparent
        Me.Button12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button12.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown
        Me.Button12.FlatAppearance.BorderSize = 0
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.ForeColor = System.Drawing.Color.Black
        Me.Button12.Location = New System.Drawing.Point(0, 90)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(220, 30)
        Me.Button12.TabIndex = 4
        Me.Button12.Text = "TXT File(*.txt)"
        Me.Button12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.Transparent
        Me.Button13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button13.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown
        Me.Button13.FlatAppearance.BorderSize = 0
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.ForeColor = System.Drawing.Color.Black
        Me.Button13.Location = New System.Drawing.Point(0, 60)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(220, 30)
        Me.Button13.TabIndex = 3
        Me.Button13.Text = "PHP File(*.php)"
        Me.Button13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.Transparent
        Me.Button14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button14.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown
        Me.Button14.FlatAppearance.BorderSize = 0
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.ForeColor = System.Drawing.Color.Black
        Me.Button14.Location = New System.Drawing.Point(0, 30)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(220, 30)
        Me.Button14.TabIndex = 2
        Me.Button14.Text = "HTML File(*.html)"
        Me.Button14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button14.UseVisualStyleBackColor = False
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.Transparent
        Me.Button15.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button15.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown
        Me.Button15.FlatAppearance.BorderSize = 0
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button15.ForeColor = System.Drawing.Color.Black
        Me.Button15.Location = New System.Drawing.Point(0, 0)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(220, 30)
        Me.Button15.TabIndex = 1
        Me.Button15.Text = "Directory"
        Me.Button15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button15.UseVisualStyleBackColor = False
        '
        'RRightMenu
        '
        Me.RRightMenu.Controls.Add(Me.Button1)
        Me.RRightMenu.Controls.Add(Me.Button7)
        Me.RRightMenu.Controls.Add(Me.Button9)
        Me.RRightMenu.Controls.Add(Me.Button10)
        Me.RRightMenu.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.RRightMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.RRightMenu.Location = New System.Drawing.Point(12, 241)
        Me.RRightMenu.Name = "RRightMenu"
        Me.RRightMenu.NoRounding = False
        Me.RRightMenu.Size = New System.Drawing.Size(220, 120)
        Me.RRightMenu.TabIndex = 1
        Me.RRightMenu.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(0, 90)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(220, 30)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Properties"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Transparent
        Me.Button7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.ForeColor = System.Drawing.Color.Black
        Me.Button7.Location = New System.Drawing.Point(0, 60)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(220, 30)
        Me.Button7.TabIndex = 4
        Me.Button7.Text = "Terminal"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Transparent
        Me.Button9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button9.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.ForeColor = System.Drawing.Color.Black
        Me.Button9.Location = New System.Drawing.Point(0, 30)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(220, 30)
        Me.Button9.TabIndex = 2
        Me.Button9.Text = "New"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.Transparent
        Me.Button10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button10.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.ForeColor = System.Drawing.Color.Black
        Me.Button10.Location = New System.Drawing.Point(0, 0)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(220, 30)
        Me.Button10.TabIndex = 1
        Me.Button10.Text = "Refresh"
        Me.Button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button10.UseVisualStyleBackColor = False
        '
        'RightMenu
        '
        Me.RightMenu.Controls.Add(Me.Button18)
        Me.RightMenu.Controls.Add(Me.Button6)
        Me.RightMenu.Controls.Add(Me.Button5)
        Me.RightMenu.Controls.Add(Me.Button3)
        Me.RightMenu.Controls.Add(Me.Button2)
        Me.RightMenu.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.RightMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.RightMenu.Location = New System.Drawing.Point(238, 206)
        Me.RightMenu.Name = "RightMenu"
        Me.RightMenu.NoRounding = False
        Me.RightMenu.Size = New System.Drawing.Size(220, 155)
        Me.RightMenu.TabIndex = 0
        Me.RightMenu.Visible = False
        '
        'Button18
        '
        Me.Button18.BackColor = System.Drawing.Color.Transparent
        Me.Button18.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button18.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown
        Me.Button18.FlatAppearance.BorderSize = 0
        Me.Button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button18.ForeColor = System.Drawing.Color.Black
        Me.Button18.Location = New System.Drawing.Point(0, 120)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(220, 30)
        Me.Button18.TabIndex = 6
        Me.Button18.Text = "Properties"
        Me.Button18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button18.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.Location = New System.Drawing.Point(0, 90)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(220, 30)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Delete"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Location = New System.Drawing.Point(0, 60)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(220, 30)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Rename"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(0, 30)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(220, 30)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Open New Window"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(0, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(220, 30)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Open"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = False
        '
        'FileList
        '
        Me.FileList.FormattingEnabled = True
        Me.FileList.ItemHeight = 15
        Me.FileList.Location = New System.Drawing.Point(662, 476)
        Me.FileList.Name = "FileList"
        Me.FileList.Size = New System.Drawing.Size(26, 19)
        Me.FileList.TabIndex = 6
        Me.FileList.Visible = False
        '
        'VLA
        '
        Me.VLA.AutoSize = True
        Me.VLA.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.VLA.Font = New System.Drawing.Font("Roboto Cn", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.VLA.ForeColor = System.Drawing.Color.Black
        Me.VLA.Location = New System.Drawing.Point(583, 465)
        Me.VLA.Name = "VLA"
        Me.VLA.Size = New System.Drawing.Size(41, 15)
        Me.VLA.TabIndex = 4
        Me.VLA.Text = "Label1"
        Me.VLA.Visible = False
        '
        'VLI
        '
        Me.VLI.AutoSize = True
        Me.VLI.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.VLI.Font = New System.Drawing.Font("Roboto Cn", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.VLI.ForeColor = System.Drawing.Color.Black
        Me.VLI.Location = New System.Drawing.Point(627, 465)
        Me.VLI.Name = "VLI"
        Me.VLI.Size = New System.Drawing.Size(41, 15)
        Me.VLI.TabIndex = 1
        Me.VLI.Text = "Label1"
        Me.VLI.Visible = False
        '
        'MiniTimer_ControlBox1
        '
        Me.MiniTimer_ControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.MiniTimer_ControlBox1.EnableMaximize = False
        Me.MiniTimer_ControlBox1.Font = New System.Drawing.Font("Marlett", 7.0!)
        Me.MiniTimer_ControlBox1.Location = New System.Drawing.Point(15, 13)
        Me.MiniTimer_ControlBox1.Name = "MiniTimer_ControlBox1"
        Me.MiniTimer_ControlBox1.Size = New System.Drawing.Size(40, 16)
        Me.MiniTimer_ControlBox1.TabIndex = 0
        Me.MiniTimer_ControlBox1.Text = "MiniTimer_ControlBox1"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 500)
        Me.ControlBox = False
        Me.Controls.Add(Me.MiniTimer_ThemeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(261, 65)
        Me.Name = "FrmMain"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "File Manager"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.MiniTimer_ThemeContainer1.ResumeLayout(False)
        Me.MiniTimer_ThemeContainer1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.NewMenu.ResumeLayout(False)
        Me.RRightMenu.ResumeLayout(False)
        Me.RightMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MiniTimer_ThemeContainer1 As MiniTimer_ThemeContainer
    Friend WithEvents MiniTimer_ControlBox1 As MiniTimer_ControlBox
    Friend WithEvents VLI As Label
    Friend WithEvents VLA As Label
    Friend WithEvents FileList As ListBox
    Friend WithEvents DirList As ListBox
    Friend WithEvents AddDir As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LocationURL As TxtBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BackButton As MiniTimer_Button_1
    Friend WithEvents RightMenu As PanelBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents ClickName As Label
    Friend WithEvents Info As MiniTimer_Label
    Friend WithEvents NewMenu As PanelBox
    Friend WithEvents Button16 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents RRightMenu As PanelBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents AddOther As Timer
End Class
