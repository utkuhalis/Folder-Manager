Imports System.IO
Imports System.Text
Public Class FrmMain

    Const CS_DROPSHADOW As Integer = &H20000
    Friend WithEvents Opacity1 As New Timer
    Friend WithEvents Opacity2 As New Timer

    Sub New()
        InitializeComponent()

        Opacity1.Enabled = True
        Opacity1.Interval = 1
        Opacity2.Enabled = False
        Opacity2.Interval = 1

        AddHandler Opacity1.Tick, AddressOf Opacity1_Tick
        AddHandler Opacity2.Tick, AddressOf Opacity2_Tick
    End Sub

    Private Sub Opacity1_Tick(sender As Object, e As EventArgs)
        Opacity += 0.03
        If Opacity = 100 Then
            Opacity2.Enabled = False
        End If
    End Sub

    Private Sub Opacity2_Tick(sender As Object, e As EventArgs)
        Opacity -= 0.03
        If Opacity = 0 Then
            Me.Close()
        End If
    End Sub

    Private Sub FrmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        RemoveHandler Opacity1.Tick, AddressOf Opacity1_Tick
        RemoveHandler Opacity2.Tick, AddressOf Opacity2_Tick
    End Sub

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim parameters As CreateParams = MyBase.CreateParams
            If OSFeature.IsPresent(SystemParameter.DropShadow) Then
                parameters.ClassStyle = parameters.ClassStyle Or CS_DROPSHADOW
            End If
            Return parameters
        End Get
    End Property

    Dim StartX As Integer
    Dim StartY As Integer
    Dim LineCount As Integer = 0
    Dim inputName As String = ""
    Dim inputName2 As String = ""

    Private Sub PostControl()
        Dim inputArgument As String = "/data="
        Dim inputArgument2 As String = "/dir="

        For Each s As String In My.Application.CommandLineArgs
            If s.ToLower.StartsWith(inputArgument) Then
                inputName = s.Remove(0, inputArgument.Length)
            End If
        Next

        For Each s As String In My.Application.CommandLineArgs
            If s.ToLower.StartsWith(inputArgument2) Then
                inputName2 = s.Remove(0, inputArgument2.Length)
            End If
        Next

        If Not inputName = "" Then
            VLA.Text = inputName
            VLI.Text = VLA.Text
            ListItems()
        ElseIf Not VLI.Text = "" Then
            ListItems()
        End If
    End Sub

    Private Sub ListItems()
        Panel1.Controls.Clear()
        DirList.Items.Clear()
        FileList.Items.Clear()
        LineCount = 0
        StartX = 15
        StartY = 20
        Panel1.Controls.Add(RightMenu)
        Panel1.Controls.Add(RRightMenu)
        Panel1.Controls.Add(NewMenu)

        For Each folder As String In Directory.GetDirectories(VLI.Text)
            DirList.Items.Add(Path.GetFileName(folder))
            DirList.SelectedIndex = 0
        Next

        For Each folder As String In Directory.GetFiles(VLI.Text)
            FileList.Items.Add(Path.GetFileName(folder))
            FileList.SelectedIndex = 0
        Next

        AddDir.Start()
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackButton.Image = Image.FromFile(Application.StartupPath & "\back.png")
        VLI.Text = Application.StartupPath & "\System\"
        VLA.Text = VLI.Text
        PostControl()
    End Sub
    Dim count As Integer = 0
    Private Sub AddDir_Tick(sender As Object, e As EventArgs) Handles AddDir.Tick
        Dim Limit As Integer = DirList.Items.Count
        Dim hesaplacanısı As Integer = Panel1.Size.Width / 125
        Dim sonuc As String = hesaplacanısı

        sonuc = sonuc.Split(",")(0) - 2

        If LineCount = sonuc Then
            LineCount = 0
            StartY = StartY + 155
            StartX = 15
            LineCount += 1
        Else
            LineCount += 1
        End If

        If count = Limit Or Limit = 0 Then
            count = 0
            AddDir.Stop()
            AddOther.Start()
        Else
            DirList.SelectedIndex = count
            Dim BackPanel As New Panel
            Dim ImagePanel As New Panel
            Dim Name As New Label

            BackPanel.Size = New Size(125, 110)
            BackPanel.Location = New Point(StartX, StartY)

            ImagePanel.BackgroundImage = Image.FromFile(Application.StartupPath & "\Dir.png")
            ImagePanel.BackgroundImageLayout = ImageLayout.Zoom
            ImagePanel.Name = DirList.Text

            Name.AutoSize = False
            Name.TextAlign = ContentAlignment.MiddleCenter
            Name.Font = New Font("Poor Richard", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Name.Size = New Size(125, 15)
            Name.Text = DirList.Text
            Name.Name = DirList.Text

            Name.Dock = DockStyle.Bottom
            ImagePanel.Dock = DockStyle.Fill

            BackPanel.Controls.Add(Name)
            BackPanel.Controls.Add(ImagePanel)

            MouseEvent(ImagePanel)
            MouseEvent(Name)

            If Not DirList.Text = "" Then
                Panel1.Controls.Add(BackPanel)
            End If

            StartX = StartX + 170
            count += 1
        End If
    End Sub

    Private Sub MouseEvent(ByVal Control As Control)
        AddHandler Control.MouseDoubleClick, Sub(sender As Object, e As MouseEventArgs) Open(Control)
        AddHandler Control.MouseClick, Sub(sender As Object, e As MouseEventArgs) OpenRM(Control, e)
    End Sub

    Private Sub OpenRM(ByVal Control As Control, e As MouseEventArgs)
        RRightMenu.Visible = False
        NewMenu.Visible = False
        ClickName.Text = Control.Name

        If e.Button = MouseButtons.Right Then
            RightMenu.Location = New Point((MousePosition.X - Location.X) - 20, (MousePosition.Y - Location.Y) - 100)
            RightMenu.Visible = True
        End If
    End Sub

    Private Sub Open(ByVal Control As Control)
        VLA.Text &= Control.Name & "\"
        VLI.Text = VLA.Text
        ListItems()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim visibletext As String = VLA.Text
        LocationURL.Text = visibletext.Replace(inputName2, "\")
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        If Not LocationURL.Text = "\" Then
            Dim slashhesapla As Integer = VLA.Text.Split("\").Count
            VLA.Text = VLA.Text.Replace(VLA.Text.Split("\")(slashhesapla - 2) & "\", "")
            VLI.Text = VLA.Text
            ListItems()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RightMenu.Visible = False
        VLA.Text &= ClickName.Text & "\"
        VLI.Text = VLA.Text
        ListItems()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RightMenu.Visible = False
        Process.Start(Application.StartupPath & "\WindowsApplication1.exe", "/data=" & VLA.Text & ClickName.Text & "\")
    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        RightMenu.Visible = False
        RRightMenu.Visible = False
        NewMenu.Visible = False
        Info.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        RightMenu.Visible = False
        Dim RName As New Rename
        Dim LastName As String = ClickName.Text
        RName.TxtBox1.Text = ClickName.Text
        RName.TopMost = True
        If RName.ShowDialog = DialogResult.OK Then
            If My.Computer.FileSystem.DirectoryExists(VLA.Text & LastName) = True Then
                My.Computer.FileSystem.RenameDirectory(VLA.Text & LastName, RName.TxtBox1.Text)
                ListItems()
            End If
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        RightMenu.Visible = False
        If My.Computer.FileSystem.DirectoryExists(VLA.Text & ClickName.Text) = True Then
            If MsgBox("Delete ?", MsgBoxStyle.YesNo, "LAdmin") = MsgBoxResult.Yes Then
                My.Computer.FileSystem.DeleteDirectory(VLA.Text & ClickName.Text, FileIO.DeleteDirectoryOption.DeleteAllContents)
                ListItems()
            End If
        End If
    End Sub

    Private Sub Panel1_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel1.MouseClick
        If e.Button = MouseButtons.Right Then
            RightMenu.Visible = False
            RRightMenu.Location = New Point((MousePosition.X - Location.X) - 20, (MousePosition.Y - Location.Y) - 100)
            RRightMenu.Visible = True
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        RRightMenu.Visible = False
        ListItems()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        RRightMenu.Visible = False
        NewMenu.Location = New Point((MousePosition.X - Location.X) - 20, (MousePosition.Y - Location.Y) - 100)
        NewMenu.Visible = True
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        RightMenu.Visible = False
        Dim y As DirectoryInfo = New DirectoryInfo(VLA.Text & ClickName.Text)
        Info.Text = "Created Time: " & y.CreationTime & vbNewLine & "Root: " & y.FullName.Replace(Application.StartupPath & "\System\", "\").Replace(ClickName.Text, "")
        Info.Visible = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        RRightMenu.Visible = False
        Process.Start(Application.StartupPath & "\Terminal.exe")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RightMenu.Visible = False
        Dim y As DirectoryInfo = New DirectoryInfo(VLA.Text & ClickName.Text)
        Info.Text = "Created Time: " & y.CreationTime & vbNewLine & "Root: " & y.FullName.Replace(Application.StartupPath & "\System\", "\").Replace(ClickName.Text, "")
        Info.Visible = True
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        NewMenu.Visible = False
        Dim x As New Rename
        x.MiniTimer_ThemeContainer1.Text = "Create Directory"
        x.Button1.Text = "Create"
        x.TopMost = True
        If x.ShowDialog() = DialogResult.OK Then
            If Not My.Computer.FileSystem.DirectoryExists(VLI.Text & x.TxtBox1.Text) = True Then
                My.Computer.FileSystem.CreateDirectory(VLI.Text & x.TxtBox1.Text)
                ListItems()
            Else
                Dim z As New MsgForm
                z.MsgFormTheme.Text = "Existing"
                z.MsgText.Text = "File already exists..."
                z.TopMost = True
                z.ShowDialog()
            End If
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        NewMenu.Visible = False
        Dim x As New Rename
        x.MiniTimer_ThemeContainer1.Text = "Create HTML File"
        x.Button1.Text = "Create"
        x.TopMost = True
        If x.ShowDialog() = DialogResult.OK Then
            If Not My.Computer.FileSystem.FileExists(VLI.Text & x.TxtBox1.Text & ".html") = True Then

                Dim htmlfile As FileStream = File.Create(VLI.Text & x.TxtBox1.Text & ".html")
                Dim htmlemptystring As String
                htmlemptystring = "<!DOCTYPE HTML>" &
                    vbNewLine & "<html lang='en-US'>" &
                    vbNewLine & "	<head>" &
                    vbNewLine & "		<meta charset='UTF-8'>" &
                    vbNewLine & "		<title>Launcher HTML File</title>" &
                    vbNewLine & "	</head>" &
                    vbNewLine &
                    vbNewLine & "	<body>" &
                    vbNewLine & "		<p>Launcher Default HTML5 File</p>" &
                    vbNewLine & "	</body>" &
                    vbNewLine & "</html>"
                Dim info As Byte() = New UTF8Encoding(True).GetBytes(htmlemptystring)
                htmlfile.Write(info, 0, info.Length)
                htmlfile.Close()
                ListItems()
            Else
                Dim z As New MsgForm
                z.MsgFormTheme.Text = "Existing"
                z.MsgText.Text = "File already exists..."
                z.TopMost = True
                z.ShowDialog()
            End If
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        NewMenu.Visible = False
        Dim x As New Rename
        x.MiniTimer_ThemeContainer1.Text = "Create PHP File"
        x.Button1.Text = "Create"
        x.TopMost = True
        If x.ShowDialog() = DialogResult.OK Then
            If Not My.Computer.FileSystem.FileExists(VLI.Text & x.TxtBox1.Text & ".php") = True Then

                Dim phpfile As FileStream = File.Create(VLI.Text & x.TxtBox1.Text & ".php")
                Dim phpemptystring As String
                phpemptystring = "<!DOCTYPE HTML>" &
                    vbNewLine & "<html lang='en-US'>" &
                    vbNewLine & "	<head>" &
                    vbNewLine & "		<meta charset='UTF-8'>" &
                    vbNewLine & "		<title>Launcher PHP File</title>" &
                    vbNewLine & "	</head>" &
                    vbNewLine &
                    vbNewLine & "	<body>" &
                    vbNewLine & "		<?php" &
                    vbNewLine & "			echo'<p>Launcher Default PHP File</p>';" &
                    vbNewLine & "		?>" &
                    vbNewLine & "	</body>" &
                    vbNewLine & "</html>"
                Dim info As Byte() = New UTF8Encoding(True).GetBytes(phpemptystring)
                phpfile.Write(info, 0, info.Length)
                phpfile.Close()
                ListItems()
            Else
                Dim z As New MsgForm
                z.MsgFormTheme.Text = "Existing"
                z.MsgText.Text = "File already exists..."
                z.TopMost = True
                z.ShowDialog()
            End If
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        NewMenu.Visible = False
        Dim x As New Rename
        x.MiniTimer_ThemeContainer1.Text = "Create Text File"
        x.Button1.Text = "Create"
        x.TopMost = True
        If x.ShowDialog() = DialogResult.OK Then
            If Not My.Computer.FileSystem.FileExists(VLI.Text & x.TxtBox1.Text & ".txt") = True Then

                Dim phpfile As FileStream = File.Create(VLI.Text & x.TxtBox1.Text & ".txt")
                Dim phpemptystring As String
                phpemptystring = "Launcher Default Text File..."
                Dim info As Byte() = New UTF8Encoding(True).GetBytes(phpemptystring)
                phpfile.Write(info, 0, info.Length)
                phpfile.Close()
                ListItems()
            Else
                Dim z As New MsgForm
                z.MsgFormTheme.Text = "Existing"
                z.MsgText.Text = "File already exists..."
                z.TopMost = True
                z.ShowDialog()
            End If
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        NewMenu.Visible = False
        Dim x As New Rename
        x.MiniTimer_ThemeContainer1.Text = "Create Launcher Language File"
        x.Button1.Text = "Create"
        x.TopMost = True
        If x.ShowDialog() = DialogResult.OK Then
            If Not My.Computer.FileSystem.FileExists(VLI.Text & x.TxtBox1.Text & ".ll") = True Then

                Dim phpfile As FileStream = File.Create(VLI.Text & x.TxtBox1.Text & ".ll")
                Dim phpemptystring As String
                phpemptystring = "Program->Açılış(Yükleme)" &
                    vbNewLine & "-->Mesaj(Bilgi, Başlık)->Merhaba, Dünya..." &
                    vbNewLine & "Program->Kapanış"
                Dim info As Byte() = New UTF8Encoding(True).GetBytes(phpemptystring)
                phpfile.Write(info, 0, info.Length)
                phpfile.Close()
                ListItems()
            Else
                Dim z As New MsgForm
                z.MsgFormTheme.Text = "Existing"
                z.MsgText.Text = "File already exists..."
                z.TopMost = True
                z.ShowDialog()
            End If
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        NewMenu.Visible = False
        Dim x As New Rename
        x.MiniTimer_ThemeContainer1.Text = "Create Terminal File"
        x.Button1.Text = "Create"
        x.TopMost = True
        If x.ShowDialog() = DialogResult.OK Then
            If Not My.Computer.FileSystem.FileExists(VLI.Text & x.TxtBox1.Text & ".Ter") = True Then

                Dim phpfile As FileStream = File.Create(VLI.Text & x.TxtBox1.Text & ".Ter")
                Dim phpemptystring As String
                phpemptystring = "Hesapla(5+5)"
                Dim info As Byte() = New UTF8Encoding(True).GetBytes(phpemptystring)
                phpfile.Write(info, 0, info.Length)
                phpfile.Close()
                ListItems()
            Else
                Dim z As New MsgForm
                z.MsgFormTheme.Text = "Existing"
                z.MsgText.Text = "File already exists..."
                z.TopMost = True
                z.ShowDialog()
            End If
        End If
    End Sub

    Private Sub AddOther_Tick(sender As Object, e As EventArgs) Handles AddOther.Tick
        Dim Limit As Integer = FileList.Items.Count
        Dim hesaplacanısı As Integer = Panel1.Size.Width / 125
        Dim sonuc As String = hesaplacanısı
        sonuc = sonuc.Split(",")(0) - 1

        If LineCount = sonuc Then
            LineCount = 0
            StartY = StartY + 155
            StartX = 15
            LineCount += 1
        Else
            LineCount += 1
        End If

        If count = Limit Or Limit = 0 Then
            AddOther.Stop()
            Panel1.Enabled = True
            count = 0
        Else
            FileList.SelectedIndex = count
            Dim BackPanel As New Panel
            Dim ImagePanel As New Panel
            Dim Name As New Label

            BackPanel.Size = New Size(125, 110)
            BackPanel.Location = New Point(StartX, StartY)

            If FileList.Text.Contains(".php") Then
                ImagePanel.BackgroundImage = Image.FromFile(Application.StartupPath & "\php.png")
            ElseIf FileList.Text.Contains(".html") Then
                ImagePanel.BackgroundImage = Image.FromFile(Application.StartupPath & "\html.png")
            ElseIf FileList.Text.Contains(".txt") Then
                ImagePanel.BackgroundImage = Image.FromFile(Application.StartupPath & "\txt.png")
            ElseIf FileList.Text.Contains(".ll") Then
                ImagePanel.BackgroundImage = Image.FromFile(Application.StartupPath & "\LL.png")
            ElseIf FileList.Text.Contains(".Ter") Then
                ImagePanel.BackgroundImage = Image.FromFile(Application.StartupPath & "\Ter.png")
            Else
                ImagePanel.BackgroundImage = Image.FromFile(Application.StartupPath & "\Dir.png")
            End If

            ImagePanel.BackgroundImageLayout = ImageLayout.Zoom
            ImagePanel.Name = FileList.Text

            Name.AutoSize = False
            Name.TextAlign = ContentAlignment.MiddleCenter
            Name.Font = New Font("Poor Richard", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Name.Size = New Size(125, 15)
            Name.Text = FileList.Text
            Name.Name = FileList.Text

            Name.Dock = DockStyle.Bottom
            ImagePanel.Dock = DockStyle.Fill

            BackPanel.Controls.Add(Name)
            BackPanel.Controls.Add(ImagePanel)

            MouseEvent(ImagePanel)
            MouseEvent(Name)

            If Not FileList.Text = "" Then
                Panel1.Controls.Add(BackPanel)
            End If

            StartX = StartX + 170
            count += 1
        End If
    End Sub
End Class