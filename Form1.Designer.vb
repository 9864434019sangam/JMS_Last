<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        txt_Username = New TextBox()
        Panel2 = New Panel()
        CheckBox_Upass = New CheckBox()
        txt_Upassword = New TextBox()
        btnLogin = New Button()
        btnregister1 = New Button()
        Button2 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(204, 239)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 28)
        Label1.TabIndex = 0
        Label1.Text = "Sign In"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(163, 67)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(156, 156)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Window
        Panel1.Controls.Add(txt_Username)
        Panel1.Location = New Point(79, 282)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(323, 58)
        Panel1.TabIndex = 2
        ' 
        ' txt_Username
        ' 
        txt_Username.BorderStyle = BorderStyle.None
        txt_Username.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        txt_Username.Location = New Point(58, 17)
        txt_Username.Name = "txt_Username"
        txt_Username.Size = New Size(263, 23)
        txt_Username.TabIndex = 4
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.Window
        Panel2.Controls.Add(CheckBox_Upass)
        Panel2.Controls.Add(txt_Upassword)
        Panel2.Location = New Point(79, 352)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(323, 58)
        Panel2.TabIndex = 3
        ' 
        ' CheckBox_Upass
        ' 
        CheckBox_Upass.AutoSize = True
        CheckBox_Upass.Location = New Point(298, 23)
        CheckBox_Upass.Name = "CheckBox_Upass"
        CheckBox_Upass.Size = New Size(18, 17)
        CheckBox_Upass.TabIndex = 1
        CheckBox_Upass.UseVisualStyleBackColor = True
        ' 
        ' txt_Upassword
        ' 
        txt_Upassword.BorderStyle = BorderStyle.None
        txt_Upassword.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        txt_Upassword.Location = New Point(60, 18)
        txt_Upassword.Name = "txt_Upassword"
        txt_Upassword.Size = New Size(261, 23)
        txt_Upassword.TabIndex = 4
        txt_Upassword.UseSystemPasswordChar = True
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        btnLogin.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        btnLogin.ForeColor = Color.WhiteSmoke
        btnLogin.Location = New Point(80, 454)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(323, 58)
        btnLogin.TabIndex = 4
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' btnregister1
        ' 
        btnregister1.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        btnregister1.ForeColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        btnregister1.Location = New Point(80, 516)
        btnregister1.Name = "btnregister1"
        btnregister1.Size = New Size(323, 50)
        btnregister1.TabIndex = 5
        btnregister1.Text = "Register"
        btnregister1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Red
        Button2.ForeColor = Color.Black
        Button2.Location = New Point(442, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(44, 37)
        Button2.TabIndex = 46
        Button2.Text = "X"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(489, 648)
        Controls.Add(Button2)
        Controls.Add(btnregister1)
        Controls.Add(btnLogin)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnregister1 As Button
    Friend WithEvents txt_Username As TextBox
    Friend WithEvents CheckBox_Upass As CheckBox
    Friend WithEvents txt_Upassword As TextBox
    Friend WithEvents Button2 As Button

End Class
