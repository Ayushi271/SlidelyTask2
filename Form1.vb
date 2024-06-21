Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json


Public Class Form1


    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        Dim viewForm As New ViewForm()
        viewForm.ShowDialog()
    End Sub

    Private Sub btnCreateSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateSubmission.Click
        Dim createForm As New CreateForm()
        createForm.ShowDialog()
    End Sub

    Private Sub MainForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            btnViewSubmissions_Click(Me, New EventArgs())
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnCreateSubmission_Click(Me, New EventArgs())
        End If
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True ' Ensure the form can capture key presses
    End Sub


'End Class'
    Private Async Sub SubmitFormData(name As String, email As String, phone As String, githubLink As String, stopwatchTime As String)
        Dim client As New HttpClient()
        Dim url As String = "http://localhost:3000/api/submit"

        ' Create the form data as a dictionary
        Dim formData As New Dictionary(Of String, String) From {
            {"name", name},
            {"email", email},
            {"phone", phone},
            {"github_link", githubLink},
            {"stopwatch_time", stopwatchTime}
        }

        ' Serialize the form data to JSON
        Dim json As String = JsonConvert.SerializeObject(formData)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")

        ' Make the POST request
        Dim response As HttpResponseMessage = Await client.PostAsync(url, content)

        If response.IsSuccessStatusCode Then
            MessageBox.Show("Form submitted successfully!")
        Else
            MessageBox.Show("Error submitting form: " & response.ReasonPhrase)
        End If
    End Sub

    Private Async Sub ReadFormData(index As Integer)
        Dim client As New HttpClient()
        Dim url As String = $"http://localhost:3000/api/read?index={index}"

        ' Make the GET request
        Dim response As HttpResponseMessage = Await client.GetAsync(url)

        If response.IsSuccessStatusCode Then
            Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()
            Dim formData As Dictionary(Of String, String) = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(jsonResponse)
            ' Display the form data
            MessageBox.Show("Name: " & formData("name") & vbCrLf &
                            "Email: " & formData("email") & vbCrLf &
                            "Phone: " & formData("phone") & vbCrLf &
                            "GitHub Link: " & formData("github_link") & vbCrLf &
                            "Stopwatch Time: " & formData("stopwatch_time"))
        Else
            MessageBox.Show("Error fetching form data: " & response.ReasonPhrase)
        End If
    End Sub


End Class

