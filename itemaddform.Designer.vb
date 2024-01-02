<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class itemaddform
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
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToOrderColumns = True
        DataGridView1.BackgroundColor = SystemColors.Info
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Dock = DockStyle.Top
        DataGridView1.Location = New Point(0, 0)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(1649, 266)
        DataGridView1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 18F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label1.Location = New Point(643, 311)
        Label1.Name = "Label1"
        Label1.Size = New Size(323, 35)
        Label1.TabIndex = 1
        Label1.Text = "ITEM ADDING FORM"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox1.ForeColor = Color.Black
        GroupBox1.Location = New Point(158, 349)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1192, 356)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "ADD ITEMS"
        ' 
        ' itemaddform
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.InactiveCaption
        ClientSize = New Size(1649, 763)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        FormBorderStyle = FormBorderStyle.None
        Name = "itemaddform"
        Text = "itemaddform"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
