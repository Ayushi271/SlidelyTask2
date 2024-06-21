<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateForm
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
        txtName = New TextBox()
        txtGithubLink = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        lblStopwatchTime = New Label()
        btnStartStopwatch = New Button()
        btnSubmit = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.AccessibleName = "txtName"
        txtName.Location = New Point(176, 69)
        txtName.Name = "txtName"
        txtName.PlaceholderText = "Enter Name"
        txtName.Size = New Size(338, 27)
        txtName.TabIndex = 0
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.AccessibleName = "txtGithubLink"
        txtGithubLink.Location = New Point(176, 230)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.PlaceholderText = "Enter Github Repo Link"
        txtGithubLink.Size = New Size(338, 27)
        txtGithubLink.TabIndex = 2
        ' 
        ' txtEmail
        ' 
        txtEmail.AccessibleName = "txtMail"
        txtEmail.Location = New Point(176, 121)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Enter Email"
        txtEmail.Size = New Size(338, 27)
        txtEmail.TabIndex = 3
        ' 
        ' txtPhone
        ' 
        txtPhone.AccessibleName = "txtPhone"
        txtPhone.Location = New Point(176, 171)
        txtPhone.Name = "txtPhone"
        txtPhone.PlaceholderText = "Enter Phone No"
        txtPhone.Size = New Size(338, 27)
        txtPhone.TabIndex = 4
        ' 
        ' lblStopwatchTime
        ' 
        lblStopwatchTime.AccessibleName = "lblStopwatchTime"
        lblStopwatchTime.AutoSize = True
        lblStopwatchTime.Location = New Point(393, 343)
        lblStopwatchTime.Name = "lblStopwatchTime"
        lblStopwatchTime.Size = New Size(63, 20)
        lblStopwatchTime.TabIndex = 5
        lblStopwatchTime.Text = "00:00:00"
        ' 
        ' btnStartStopwatch
        ' 
        btnStartStopwatch.AccessibleName = "btnStartStopwatch"
        btnStartStopwatch.BackColor = Color.Khaki
        btnStartStopwatch.Location = New Point(65, 339)
        btnStartStopwatch.Name = "btnStartStopwatch"
        btnStartStopwatch.Size = New Size(265, 29)
        btnStartStopwatch.TabIndex = 6
        btnStartStopwatch.Text = "Toggle Stopwatch (Ctrl+T)"
        btnStartStopwatch.UseVisualStyleBackColor = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.AccessibleName = "btnSubmit"
        btnSubmit.BackColor = Color.LightBlue
        btnSubmit.ForeColor = Color.Black
        btnSubmit.Location = New Point(85, 401)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(393, 29)
        btnSubmit.TabIndex = 7
        btnSubmit.Text = "Submit (Ctrl+S)"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(65, 72)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 8
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(65, 128)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 20)
        Label2.TabIndex = 9
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(65, 178)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 20)
        Label3.TabIndex = 10
        Label3.Text = "Phone No."
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(65, 237)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 20)
        Label4.TabIndex = 11
        Label4.Text = "Github"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(165, 20)
        Label5.Name = "Label5"
        Label5.Size = New Size(326, 20)
        Label5.TabIndex = 12
        Label5.Text = "Ayushi Sinha, Slidely Task 2 -  Create Submission"
        ' 
        ' CreateForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(613, 442)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnSubmit)
        Controls.Add(btnStartStopwatch)
        Controls.Add(lblStopwatchTime)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtGithubLink)
        Controls.Add(txtName)
        Name = "CreateForm"
        Text = "CreateForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents lblStopwatchTime As Label
    Friend WithEvents btnStartStopwatch As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
