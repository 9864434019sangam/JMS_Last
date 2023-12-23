<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class register
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Button2 = New Button()
        CheckBox_Mpass = New CheckBox()
        CheckBox_Upass = New CheckBox()
        dob_picker = New DateTimePicker()
        Button1 = New Button()
        btn_register = New Button()
        RadioButton_female = New RadioButton()
        RadioButton_male = New RadioButton()
        txt_email = New TextBox()
        txt_phoneno = New TextBox()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        txt_Upassword = New TextBox()
        txt_maskedpass = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        txt_address = New TextBox()
        Label5 = New Label()
        txt_username = New TextBox()
        Label4 = New Label()
        txt_lastname = New TextBox()
        txt_firstname = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(CheckBox_Mpass)
        Panel1.Controls.Add(CheckBox_Upass)
        Panel1.Controls.Add(dob_picker)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(btn_register)
        Panel1.Controls.Add(RadioButton_female)
        Panel1.Controls.Add(RadioButton_male)
        Panel1.Controls.Add(txt_email)
        Panel1.Controls.Add(txt_phoneno)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(txt_Upassword)
        Panel1.Controls.Add(txt_maskedpass)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(txt_address)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(txt_username)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(txt_lastname)
        Panel1.Controls.Add(txt_firstname)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(507, 695)
        Panel1.TabIndex = 0
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Red
        Button2.ForeColor = Color.Black
        Button2.Location = New Point(461, 3)
        Button2.Name = "Button2"
        Button2.Size = New Size(44, 37)
        Button2.TabIndex = 45
        Button2.Text = "X"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' CheckBox_Mpass
        ' 
        CheckBox_Mpass.AutoSize = True
        CheckBox_Mpass.Location = New Point(416, 424)
        CheckBox_Mpass.Name = "CheckBox_Mpass"
        CheckBox_Mpass.Size = New Size(18, 17)
        CheckBox_Mpass.TabIndex = 44
        CheckBox_Mpass.UseVisualStyleBackColor = True
        ' 
        ' CheckBox_Upass
        ' 
        CheckBox_Upass.AutoSize = True
        CheckBox_Upass.Location = New Point(225, 425)
        CheckBox_Upass.Name = "CheckBox_Upass"
        CheckBox_Upass.Size = New Size(18, 17)
        CheckBox_Upass.TabIndex = 43
        CheckBox_Upass.UseVisualStyleBackColor = True
        ' 
        ' dob_picker
        ' 
        dob_picker.Location = New Point(259, 482)
        dob_picker.Name = "dob_picker"
        dob_picker.Size = New Size(180, 27)
        dob_picker.TabIndex = 42
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(181, 626)
        Button1.Name = "Button1"
        Button1.Size = New Size(110, 39)
        Button1.TabIndex = 25
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btn_register
        ' 
        btn_register.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        btn_register.ForeColor = Color.White
        btn_register.Location = New Point(180, 592)
        btn_register.Name = "btn_register"
        btn_register.Size = New Size(110, 39)
        btn_register.TabIndex = 24
        btn_register.Text = "Register"
        btn_register.UseVisualStyleBackColor = False
        ' 
        ' RadioButton_female
        ' 
        RadioButton_female.AutoSize = True
        RadioButton_female.Location = New Point(137, 485)
        RadioButton_female.Name = "RadioButton_female"
        RadioButton_female.Size = New Size(78, 24)
        RadioButton_female.TabIndex = 41
        RadioButton_female.TabStop = True
        RadioButton_female.Text = "Female"
        RadioButton_female.UseVisualStyleBackColor = True
        ' 
        ' RadioButton_male
        ' 
        RadioButton_male.AutoSize = True
        RadioButton_male.Location = New Point(68, 485)
        RadioButton_male.Name = "RadioButton_male"
        RadioButton_male.Size = New Size(63, 24)
        RadioButton_male.TabIndex = 40
        RadioButton_male.TabStop = True
        RadioButton_male.Text = "Male"
        RadioButton_male.UseVisualStyleBackColor = True
        ' 
        ' txt_email
        ' 
        txt_email.Location = New Point(259, 550)
        txt_email.Name = "txt_email"
        txt_email.Size = New Size(180, 27)
        txt_email.TabIndex = 39
        ' 
        ' txt_phoneno
        ' 
        txt_phoneno.Location = New Point(67, 551)
        txt_phoneno.Name = "txt_phoneno"
        txt_phoneno.Size = New Size(180, 27)
        txt_phoneno.TabIndex = 38
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(260, 515)
        Label11.Name = "Label11"
        Label11.Size = New Size(67, 28)
        Label11.TabIndex = 37
        Label11.Text = "E-mail"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(65, 517)
        Label10.Name = "Label10"
        Label10.Size = New Size(99, 28)
        Label10.TabIndex = 36
        Label10.Text = "Phone No"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(260, 450)
        Label9.Name = "Label9"
        Label9.Size = New Size(125, 28)
        Label9.TabIndex = 35
        Label9.Text = "Date Of Birth"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(68, 450)
        Label8.Name = "Label8"
        Label8.Size = New Size(76, 28)
        Label8.TabIndex = 34
        Label8.Text = "Gender"
        ' 
        ' txt_Upassword
        ' 
        txt_Upassword.Location = New Point(68, 420)
        txt_Upassword.Name = "txt_Upassword"
        txt_Upassword.Size = New Size(180, 27)
        txt_Upassword.TabIndex = 33
        txt_Upassword.UseSystemPasswordChar = True
        ' 
        ' txt_maskedpass
        ' 
        txt_maskedpass.Location = New Point(259, 419)
        txt_maskedpass.Name = "txt_maskedpass"
        txt_maskedpass.Size = New Size(180, 27)
        txt_maskedpass.TabIndex = 32
        txt_maskedpass.UseSystemPasswordChar = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(260, 386)
        Label7.Name = "Label7"
        Label7.Size = New Size(168, 28)
        Label7.TabIndex = 31
        Label7.Text = "Confirm Password"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(68, 385)
        Label6.Name = "Label6"
        Label6.Size = New Size(93, 28)
        Label6.TabIndex = 30
        Label6.Text = "Password"
        ' 
        ' txt_address
        ' 
        txt_address.Location = New Point(260, 350)
        txt_address.Name = "txt_address"
        txt_address.Size = New Size(180, 27)
        txt_address.TabIndex = 29
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(259, 317)
        Label5.Name = "Label5"
        Label5.Size = New Size(82, 28)
        Label5.TabIndex = 28
        Label5.Text = "Address"
        ' 
        ' txt_username
        ' 
        txt_username.Location = New Point(68, 353)
        txt_username.Name = "txt_username"
        txt_username.Size = New Size(180, 27)
        txt_username.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(68, 317)
        Label4.Name = "Label4"
        Label4.Size = New Size(99, 28)
        Label4.TabIndex = 5
        Label4.Text = "Username"
        ' 
        ' txt_lastname
        ' 
        txt_lastname.Location = New Point(260, 287)
        txt_lastname.Name = "txt_lastname"
        txt_lastname.Size = New Size(180, 27)
        txt_lastname.TabIndex = 4
        ' 
        ' txt_firstname
        ' 
        txt_firstname.Location = New Point(68, 287)
        txt_firstname.Name = "txt_firstname"
        txt_firstname.Size = New Size(180, 27)
        txt_firstname.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(260, 259)
        Label3.Name = "Label3"
        Label3.Size = New Size(103, 28)
        Label3.TabIndex = 2
        Label3.Text = "Last Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(68, 259)
        Label2.Name = "Label2"
        Label2.Size = New Size(106, 28)
        Label2.TabIndex = 0
        Label2.Text = "First Name"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(166, 81)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(156, 156)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(101, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(308, 46)
        Label1.TabIndex = 0
        Label1.Text = "Registration Form"
        ' 
        ' register
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(507, 695)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "register"
        StartPosition = FormStartPosition.CenterScreen
        Text = "register"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_address As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_username As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_lastname As TextBox
    Friend WithEvents txt_firstname As TextBox
    Friend WithEvents btn_register As Button
    Friend WithEvents RadioButton_female As RadioButton
    Friend WithEvents RadioButton_male As RadioButton
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_phoneno As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_Upassword As TextBox
    Friend WithEvents txt_maskedpass As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents dob_picker As DateTimePicker
    Friend WithEvents CheckBox_Upass As CheckBox
    Friend WithEvents CheckBox_Mpass As CheckBox
    Friend WithEvents Button2 As Button
End Class
