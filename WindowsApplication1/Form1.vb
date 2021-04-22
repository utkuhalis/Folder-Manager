Public Class Form1

    Private Sub Form1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If IsNumeric(e.KeyChar) Or e.KeyChar = "*" Or e.KeyChar = "/" Or e.KeyChar = "+" Or e.KeyChar = "-" Or e.KeyChar = "." Then
            TxtBox1.Text &= e.KeyChar
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each buttons As Control In MiniTimer_ThemeContainer1.Controls
            If IsNumeric(buttons.Text) = True Or buttons.Text = "." Or buttons.Text = "+" Or buttons.Text = "*" Or buttons.Text = "/" Then
                DFN(buttons)
            End If
        Next
    End Sub

    Private Sub DFN(ByVal Control As Control)
        AddHandler Control.Click, Sub(sender As Object, e As MouseEventArgs) add(Control)
    End Sub

    Sub add(ByVal control As Control)
        TxtBox1.Text &= control.Text
    End Sub
End Class
