<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class startUp
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(startUp))
        Label1 = New Label()
        Label2 = New Label()
        pbar = New ProgressBar()
        Timer1 = New Timer(components)
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.MenuBar
        Label1.Font = New Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(95, 91)
        Label1.Name = "Label1"
        Label1.Size = New Size(226, 138)
        Label1.TabIndex = 0
        Label1.Text = "JUNKYARD " & vbCrLf & "MANAMENT " & vbCrLf & "SYSTEM"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(95, 243)
        Label2.Name = "Label2"
        Label2.Size = New Size(370, 28)
        Label2.TabIndex = 1
        Label2.Text = "Developed && Design By: HashTech Hub"
        ' 
        ' pbar
        ' 
        pbar.BackColor = Color.FromArgb(CByte(240), CByte(244), CByte(247))
        pbar.ForeColor = Color.White
        pbar.Location = New Point(95, 284)
        pbar.Name = "pbar"
        pbar.Size = New Size(626, 33)
        pbar.TabIndex = 2
        ' 
        ' Timer1
        ' 
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(391, 91)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(147, 141)
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' startUp
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(802, 452)
        Controls.Add(PictureBox1)
        Controls.Add(pbar)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "startUp"
        StartPosition = FormStartPosition.CenterScreen
        Text = "startUp"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pbar As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
End Class
