Public Class Form1
    Public time As Integer = 15

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Seconds()
        Label1.Text = "Enter your password within " + time.ToString() + " seconds"
    End Sub

    Private Sub Seconds()
        If time > 0 Then
            time = time - 1
        End If
        If time = 0 Then
            Timer1.Enabled = False
            MsgBox("Sorry, your time is up.")
            Environment.Exit(1)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "secret" Then
            Timer1.Enabled = False
            MsgBox("Welcome to the system!")
            End
        Else
            MsgBox("Sorry, friend, I don’t know you.")
        End If
    End Sub
End Class
