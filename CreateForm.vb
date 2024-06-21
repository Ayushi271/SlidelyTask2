Imports System.Diagnostics
Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json


Public Class CreateForm
    Private stopwatch As Stopwatch = New Stopwatch()

    Private Sub btnStartStopwatch_Click(sender As Object, e As EventArgs) Handles btnStartStopwatch.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            btnStartStopwatch.Text = "Resume Stopwatch"
        Else
            stopwatch.Start()
            btnStartStopwatch.Text = "Pause Stopwatch"
        End If
        UpdateStopwatchLabel()
    End Sub

    Private Sub UpdateStopwatchLabel()
        lblStopwatchTime.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim client As New HttpClient()
        Dim submission = New With {
            .name = txtName.Text,
            .email = txtEmail.Text,
            .phone = txtPhone.Text,
            .github_link = txtGithubLink.Text,
            .stopwatch_time = stopwatch.Elapsed.TotalSeconds
        }
        Dim json = JsonConvert.SerializeObject(submission)
        Dim content = New StringContent(json, Encoding.UTF8, "application/json")
        Dim response = Await client.PostAsync("http://localhost:3000/submit", content)
        If response.IsSuccessStatusCode Then
            MessageBox.Show("Submission successful!")
            Me.Close()
        Else
            MessageBox.Show("Submission failed!")
        End If
    End Sub

    Private Sub CreateForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit_Click(Me, New EventArgs())
        ElseIf e.Control AndAlso e.KeyCode = Keys.T Then
            btnStartStopwatch_Click(Me, New EventArgs())
        End If
    End Sub

    Private Sub CreateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True ' Ensure the form can capture key presses
    End Sub


End Class
