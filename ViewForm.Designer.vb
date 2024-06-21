<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewForm
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
        btnNext = New Button()
        btnPrevious = New Button()
        txtPhone = New TextBox()
        txtGithubLink = New TextBox()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtStopwatchTime = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.LightBlue
        btnNext.Location = New Point(443, 372)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(284, 29)
        btnNext.TabIndex = 0
        btnNext.Text = "Next (Ctrl + N)"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.Khaki
        btnPrevious.Location = New Point(72, 372)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(280, 29)
        btnPrevious.TabIndex = 1
        btnPrevious.Text = "Previous (Ctrl + P)"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' txtPhone
        ' 
        txtPhone.BackColor = Color.Gainsboro
        txtPhone.Location = New Point(227, 188)
        txtPhone.Name = "txtPhone"
        txtPhone.PlaceholderText = "Phone No."
        txtPhone.ReadOnly = True
        txtPhone.Size = New Size(277, 27)
        txtPhone.TabIndex = 2
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.BackColor = Color.Gainsboro
        txtGithubLink.Location = New Point(227, 225)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.PlaceholderText = "Github Repo Link"
        txtGithubLink.ReadOnly = True
        txtGithubLink.Size = New Size(277, 27)
        txtGithubLink.TabIndex = 3
        ' 
        ' txtName
        ' 
        txtName.BackColor = Color.Gainsboro
        txtName.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtName.ForeColor = Color.WhiteSmoke
        txtName.Location = New Point(227, 122)
        txtName.Name = "txtName"
        txtName.PlaceholderText = "Name"
        txtName.ReadOnly = True
        txtName.Size = New Size(277, 27)
        txtName.TabIndex = 4
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.Gainsboro
        txtEmail.Location = New Point(227, 155)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Email"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(277, 27)
        txtEmail.TabIndex = 5
        ' 
        ' txtStopwatchTime
        ' 
        txtStopwatchTime.BackColor = Color.Gainsboro
        txtStopwatchTime.Location = New Point(227, 258)
        txtStopwatchTime.Name = "txtStopwatchTime"
        txtStopwatchTime.PlaceholderText = "StopWatch Time"
        txtStopwatchTime.ReadOnly = True
        txtStopwatchTime.Size = New Size(277, 27)
        txtStopwatchTime.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(227, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(325, 20)
        Label1.TabIndex = 7
        Label1.Text = "Ayushi Sinha, Slidely Task 2  -  View Submissions"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(129, 132)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 8
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(129, 163)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 20)
        Label3.TabIndex = 9
        Label3.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(129, 195)
        Label4.Name = "Label4"
        Label4.Size = New Size(77, 20)
        Label4.TabIndex = 10
        Label4.Text = "Phone No."
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(129, 232)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 20)
        Label5.TabIndex = 11
        Label5.Text = "Github "
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(129, 265)
        Label6.Name = "Label6"
        Label6.Size = New Size(79, 20)
        Label6.TabIndex = 12
        Label6.Text = "Stopwatch"
        ' 
        ' ViewForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtStopwatchTime)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(txtGithubLink)
        Controls.Add(txtPhone)
        Controls.Add(btnPrevious)
        Controls.Add(btnNext)
        KeyPreview = True
        Name = "ViewForm"
        Text = "ViewForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtStopwatchTime As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
