Imports System.Net
Imports System.Net.Mail

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim mail As New MailMessage()

        mail.From = New MailAddress("[Your gmail email here]")
        mail.To.Add("[Your gmail email here]")
        mail.Subject = "Test"
        Dim htmlBody As String = "<h1 style='color:blue;'>Hello!</h1>" &
                                 "<p>This is a test email with <b>HTML formatting</b>.</p>" &
                                 "<p>You can use <a href='https://www.priestley.ac.uk/'>links</a>, " &
                                 "style text, and format it in many ways!</p>"

        mail.Body = htmlBody
        mail.IsBodyHtml = True

        Dim smtp As New SmtpClient("smtp.gmail.com")
        smtp.Port = 587
        smtp.Credentials = New Net.NetworkCredential("[Your gmail email here]", "[App Password here]")

        smtp.EnableSsl = True
        Try
            smtp.Send(mail)
            MessageBox.Show("Email sent successfully!")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try



    End Sub

End Class
