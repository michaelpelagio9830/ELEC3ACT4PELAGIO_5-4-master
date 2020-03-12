Imports System.IO

Public Class Form1
    Private Sub clearbutton_Click(sender As Object, e As EventArgs) Handles clearbutton.Click
        namebox.Text = ""
        agebox.Text = ""
        addressbox.Text = ""
    End Sub

    Private Sub txtbutton_Click(sender As Object, e As EventArgs) Handles txtbutton.Click
        Dim desktop_path As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Dim file_path As String = desktop_path + "\out.txt"
        Dim objWriter As New StreamWriter(file_path)

        objWriter.Write("NAME: " + namebox.Text + Environment.NewLine + "AGE: " + agebox.Text + " years old" + Environment.NewLine + "ADDRESS: " + addressbox.Text)
        objWriter.Close()
        MessageBox.Show("NEW FILE ON DESKTOP: out.txt")
    End Sub

    Private Sub xmlbutton_Click(sender As Object, e As EventArgs) Handles xmlbutton.Click
        Dim desktop_path As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Dim file_path As String = desktop_path + "\out.xml"
        Dim objWriter As New StreamWriter(file_path)

        objWriter.Write("NAME: " + namebox.Text + Environment.NewLine + "AGE: " + agebox.Text + " years old" + Environment.NewLine + "ADDRESS: " + addressbox.Text)
        objWriter.Close()
        MessageBox.Show("NEW FILE ON DESKTOP: out.xml")
    End Sub

    Private Sub jsonbutton_Click(sender As Object, e As EventArgs) Handles jsonbutton.Click
        Dim desktop_path As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Dim file_path As String = desktop_path + "\out.json"
        Dim objWriter As New StreamWriter(file_path)

        objWriter.Write("NAME: " + namebox.Text + Environment.NewLine + "AGE: " + agebox.Text + " years old" + Environment.NewLine + "ADDRESS: " + addressbox.Text)
        objWriter.Close()
        MessageBox.Show("NEW FILE ON DESKTOP: out.json")
    End Sub
End Class
