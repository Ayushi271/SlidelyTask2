Imports System.Net.Http
Imports Newtonsoft.Json

Public Class ViewForm
    Private currentIndex As Integer = 0
    Private totalSubmissions As Integer = 0
    Private submissions As List(Of Submission)

    Private Class Submission
        Public Property name As String
        Public Property email As String
        Public Property phone As String
        Public Property github_link As String
        Public Property stopwatch_time As Double
    End Class

    Private Async Sub ViewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True ' Ensure the form can capture key presses

        Dim client As New HttpClient()
        Dim response = Await client.GetStringAsync("http://localhost:3000/read?index=0")
        submissions = JsonConvert.DeserializeObject(Of List(Of Submission))(response)
        totalSubmissions = submissions.Count

        If totalSubmissions > 0 Then
            DisplaySubmission(0)
        End If
    End Sub

    Private Sub DisplaySubmission(index As Integer)
        If index >= 0 And index < totalSubmissions Then
            txtName.Text = submissions(index).name
            txtEmail.Text = submissions(index).email
            txtPhone.Text = submissions(index).phone
            txtGithubLink.Text = submissions(index).github_link
            txtStopwatchTime.Text = TimeSpan.FromSeconds(submissions(index).stopwatch_time).ToString("hh\:mm\:ss")
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission(currentIndex)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < totalSubmissions - 1 Then
            currentIndex += 1
            DisplaySubmission(currentIndex)
        End If
    End Sub

    Private Sub ViewForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious_Click(Me, New EventArgs())
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext_Click(Me, New EventArgs())
        End If
    End Sub
End Class
