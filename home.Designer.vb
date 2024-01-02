<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home))
        Panel1 = New Panel()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem1 = New ToolStripMenuItem()
        NewToolStripMenuItem = New ToolStripMenuItem()
        OpenToolStripMenuItem = New ToolStripMenuItem()
        toolStripSeparator = New ToolStripSeparator()
        SaveToolStripMenuItem = New ToolStripMenuItem()
        SaveAsToolStripMenuItem = New ToolStripMenuItem()
        toolStripSeparator1 = New ToolStripSeparator()
        PrintToolStripMenuItem = New ToolStripMenuItem()
        PrintPreviewToolStripMenuItem = New ToolStripMenuItem()
        toolStripSeparator2 = New ToolStripSeparator()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        EditToolStripMenuItem = New ToolStripMenuItem()
        UndoToolStripMenuItem = New ToolStripMenuItem()
        RedoToolStripMenuItem = New ToolStripMenuItem()
        toolStripSeparator3 = New ToolStripSeparator()
        CutToolStripMenuItem = New ToolStripMenuItem()
        CopyToolStripMenuItem = New ToolStripMenuItem()
        PasteToolStripMenuItem = New ToolStripMenuItem()
        toolStripSeparator4 = New ToolStripSeparator()
        SelectAllToolStripMenuItem = New ToolStripMenuItem()
        ToolsToolStripMenuItem = New ToolStripMenuItem()
        CustomizeToolStripMenuItem = New ToolStripMenuItem()
        OptionsToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        ContentsToolStripMenuItem = New ToolStripMenuItem()
        IndexToolStripMenuItem = New ToolStripMenuItem()
        SearchToolStripMenuItem = New ToolStripMenuItem()
        toolStripSeparator5 = New ToolStripSeparator()
        AboutToolStripMenuItem1 = New ToolStripMenuItem()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        GroupBox1 = New GroupBox()
        Button2 = New Button()
        Button1 = New Button()
        TextBox1 = New TextBox()
        Label9 = New Label()
        txt_itemrate = New TextBox()
        Label8 = New Label()
        txt_itemquantity = New TextBox()
        Label7 = New Label()
        txt_itemname = New TextBox()
        txt_supplierphone = New TextBox()
        txt_supplieraddress = New TextBox()
        txt_suppliername = New TextBox()
        itembuydate = New DateTimePicker()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        TabPage2 = New TabPage()
        Label18 = New Label()
        GroupBox2 = New GroupBox()
        Button3 = New Button()
        Button4 = New Button()
        TextBox2 = New TextBox()
        Label10 = New Label()
        TextBox3 = New TextBox()
        Label11 = New Label()
        TextBox4 = New TextBox()
        Label12 = New Label()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        DataGridView2 = New DataGridView()
        TabPage3 = New TabPage()
        Label27 = New Label()
        GroupBox3 = New GroupBox()
        Button5 = New Button()
        Button6 = New Button()
        TextBox9 = New TextBox()
        Label19 = New Label()
        TextBox10 = New TextBox()
        Label20 = New Label()
        TextBox11 = New TextBox()
        Label21 = New Label()
        TextBox12 = New TextBox()
        TextBox13 = New TextBox()
        TextBox14 = New TextBox()
        TextBox15 = New TextBox()
        DateTimePicker2 = New DateTimePicker()
        Label22 = New Label()
        Label23 = New Label()
        Label24 = New Label()
        Label25 = New Label()
        Label26 = New Label()
        DataGridView3 = New DataGridView()
        TabPage4 = New TabPage()
        TabPage5 = New TabPage()
        TabPage6 = New TabPage()
        Panel1.SuspendLayout()
        MenuStrip1.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        TabPage3.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(DataGridView3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(MenuStrip1)
        Panel1.Controls.Add(TabControl1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1924, 953)
        Panel1.TabIndex = 1
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = SystemColors.ActiveCaption
        MenuStrip1.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem1, EditToolStripMenuItem, ToolsToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.RenderMode = ToolStripRenderMode.Professional
        MenuStrip1.Size = New Size(1924, 31)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem1
        ' 
        FileToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {NewToolStripMenuItem, OpenToolStripMenuItem, toolStripSeparator, SaveToolStripMenuItem, SaveAsToolStripMenuItem, toolStripSeparator1, PrintToolStripMenuItem, PrintPreviewToolStripMenuItem, toolStripSeparator2, ExitToolStripMenuItem})
        FileToolStripMenuItem1.Name = "FileToolStripMenuItem1"
        FileToolStripMenuItem1.Size = New Size(49, 27)
        FileToolStripMenuItem1.Text = "File"
        ' 
        ' NewToolStripMenuItem
        ' 
        NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), Image)
        NewToolStripMenuItem.ImageTransparentColor = Color.Magenta
        NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        NewToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.N
        NewToolStripMenuItem.Size = New Size(198, 28)
        NewToolStripMenuItem.Text = "&New"
        ' 
        ' OpenToolStripMenuItem
        ' 
        OpenToolStripMenuItem.Image = CType(resources.GetObject("OpenToolStripMenuItem.Image"), Image)
        OpenToolStripMenuItem.ImageTransparentColor = Color.Magenta
        OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        OpenToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.O
        OpenToolStripMenuItem.Size = New Size(198, 28)
        OpenToolStripMenuItem.Text = "&Open"
        ' 
        ' toolStripSeparator
        ' 
        toolStripSeparator.Name = "toolStripSeparator"
        toolStripSeparator.Size = New Size(195, 6)
        ' 
        ' SaveToolStripMenuItem
        ' 
        SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), Image)
        SaveToolStripMenuItem.ImageTransparentColor = Color.Magenta
        SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        SaveToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.S
        SaveToolStripMenuItem.Size = New Size(198, 28)
        SaveToolStripMenuItem.Text = "&Save"
        ' 
        ' SaveAsToolStripMenuItem
        ' 
        SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        SaveAsToolStripMenuItem.Size = New Size(198, 28)
        SaveAsToolStripMenuItem.Text = "Save &As"
        ' 
        ' toolStripSeparator1
        ' 
        toolStripSeparator1.Name = "toolStripSeparator1"
        toolStripSeparator1.Size = New Size(195, 6)
        ' 
        ' PrintToolStripMenuItem
        ' 
        PrintToolStripMenuItem.Image = CType(resources.GetObject("PrintToolStripMenuItem.Image"), Image)
        PrintToolStripMenuItem.ImageTransparentColor = Color.Magenta
        PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        PrintToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.P
        PrintToolStripMenuItem.Size = New Size(198, 28)
        PrintToolStripMenuItem.Text = "&Print"
        ' 
        ' PrintPreviewToolStripMenuItem
        ' 
        PrintPreviewToolStripMenuItem.Image = CType(resources.GetObject("PrintPreviewToolStripMenuItem.Image"), Image)
        PrintPreviewToolStripMenuItem.ImageTransparentColor = Color.Magenta
        PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        PrintPreviewToolStripMenuItem.Size = New Size(198, 28)
        PrintPreviewToolStripMenuItem.Text = "Print Pre&view"
        ' 
        ' toolStripSeparator2
        ' 
        toolStripSeparator2.Name = "toolStripSeparator2"
        toolStripSeparator2.Size = New Size(195, 6)
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(198, 28)
        ExitToolStripMenuItem.Text = "E&xit"
        ' 
        ' EditToolStripMenuItem
        ' 
        EditToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {UndoToolStripMenuItem, RedoToolStripMenuItem, toolStripSeparator3, CutToolStripMenuItem, CopyToolStripMenuItem, PasteToolStripMenuItem, toolStripSeparator4, SelectAllToolStripMenuItem})
        EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        EditToolStripMenuItem.Size = New Size(53, 27)
        EditToolStripMenuItem.Text = "Edit"
        ' 
        ' UndoToolStripMenuItem
        ' 
        UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        UndoToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.Z
        UndoToolStripMenuItem.Size = New Size(195, 28)
        UndoToolStripMenuItem.Text = "&Undo"
        ' 
        ' RedoToolStripMenuItem
        ' 
        RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        RedoToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.Y
        RedoToolStripMenuItem.Size = New Size(195, 28)
        RedoToolStripMenuItem.Text = "&Redo"
        ' 
        ' toolStripSeparator3
        ' 
        toolStripSeparator3.Name = "toolStripSeparator3"
        toolStripSeparator3.Size = New Size(192, 6)
        ' 
        ' CutToolStripMenuItem
        ' 
        CutToolStripMenuItem.Image = CType(resources.GetObject("CutToolStripMenuItem.Image"), Image)
        CutToolStripMenuItem.ImageTransparentColor = Color.Magenta
        CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        CutToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.X
        CutToolStripMenuItem.Size = New Size(195, 28)
        CutToolStripMenuItem.Text = "Cu&t"
        ' 
        ' CopyToolStripMenuItem
        ' 
        CopyToolStripMenuItem.Image = CType(resources.GetObject("CopyToolStripMenuItem.Image"), Image)
        CopyToolStripMenuItem.ImageTransparentColor = Color.Magenta
        CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        CopyToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.C
        CopyToolStripMenuItem.Size = New Size(195, 28)
        CopyToolStripMenuItem.Text = "&Copy"
        ' 
        ' PasteToolStripMenuItem
        ' 
        PasteToolStripMenuItem.Image = CType(resources.GetObject("PasteToolStripMenuItem.Image"), Image)
        PasteToolStripMenuItem.ImageTransparentColor = Color.Magenta
        PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        PasteToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.V
        PasteToolStripMenuItem.Size = New Size(195, 28)
        PasteToolStripMenuItem.Text = "&Paste"
        ' 
        ' toolStripSeparator4
        ' 
        toolStripSeparator4.Name = "toolStripSeparator4"
        toolStripSeparator4.Size = New Size(192, 6)
        ' 
        ' SelectAllToolStripMenuItem
        ' 
        SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        SelectAllToolStripMenuItem.Size = New Size(195, 28)
        SelectAllToolStripMenuItem.Text = "Select &All"
        ' 
        ' ToolsToolStripMenuItem
        ' 
        ToolsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CustomizeToolStripMenuItem, OptionsToolStripMenuItem})
        ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        ToolsToolStripMenuItem.Size = New Size(62, 27)
        ToolsToolStripMenuItem.Text = "Tools"
        ' 
        ' CustomizeToolStripMenuItem
        ' 
        CustomizeToolStripMenuItem.Name = "CustomizeToolStripMenuItem"
        CustomizeToolStripMenuItem.Size = New Size(174, 28)
        CustomizeToolStripMenuItem.Text = "&Customize"
        ' 
        ' OptionsToolStripMenuItem
        ' 
        OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        OptionsToolStripMenuItem.Size = New Size(174, 28)
        OptionsToolStripMenuItem.Text = "&Options"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ContentsToolStripMenuItem, IndexToolStripMenuItem, SearchToolStripMenuItem, toolStripSeparator5, AboutToolStripMenuItem1})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(59, 27)
        HelpToolStripMenuItem.Text = "Help"
        ' 
        ' ContentsToolStripMenuItem
        ' 
        ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        ContentsToolStripMenuItem.Size = New Size(163, 28)
        ContentsToolStripMenuItem.Text = "&Contents"
        ' 
        ' IndexToolStripMenuItem
        ' 
        IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        IndexToolStripMenuItem.Size = New Size(163, 28)
        IndexToolStripMenuItem.Text = "&Index"
        ' 
        ' SearchToolStripMenuItem
        ' 
        SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        SearchToolStripMenuItem.Size = New Size(163, 28)
        SearchToolStripMenuItem.Text = "&Search"
        ' 
        ' toolStripSeparator5
        ' 
        toolStripSeparator5.Name = "toolStripSeparator5"
        toolStripSeparator5.Size = New Size(160, 6)
        ' 
        ' AboutToolStripMenuItem1
        ' 
        AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        AboutToolStripMenuItem1.Size = New Size(163, 28)
        AboutToolStripMenuItem1.Text = "&About..."
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Controls.Add(TabPage4)
        TabControl1.Controls.Add(TabPage5)
        TabControl1.Controls.Add(TabPage6)
        TabControl1.Cursor = Cursors.Hand
        TabControl1.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        TabControl1.Location = New Point(7, 29)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1918, 924)
        TabControl1.TabIndex = 1
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = SystemColors.Info
        TabPage1.Controls.Add(GroupBox1)
        TabPage1.Controls.Add(Label1)
        TabPage1.Controls.Add(DataGridView1)
        TabPage1.Location = New Point(4, 32)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1910, 888)
        TabPage1.TabIndex = 0
        TabPage1.Text = "ADD"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.GradientActiveCaption
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(txt_itemrate)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(txt_itemquantity)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(txt_itemname)
        GroupBox1.Controls.Add(txt_supplierphone)
        GroupBox1.Controls.Add(txt_supplieraddress)
        GroupBox1.Controls.Add(txt_suppliername)
        GroupBox1.Controls.Add(itembuydate)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox1.Location = New Point(108, 300)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1349, 348)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "ADD ITEMS"
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.InactiveCaption
        Button2.Location = New Point(1048, 162)
        Button2.Name = "Button2"
        Button2.Size = New Size(111, 44)
        Button2.TabIndex = 17
        Button2.Text = "Refresh"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.InactiveCaption
        Button1.Location = New Point(1048, 75)
        Button1.Name = "Button1"
        Button1.Size = New Size(111, 44)
        Button1.TabIndex = 16
        Button1.Text = "Save"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox1.Location = New Point(649, 228)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(250, 30)
        TextBox1.TabIndex = 15
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(504, 230)
        Label9.Name = "Label9"
        Label9.Size = New Size(135, 28)
        Label9.TabIndex = 14
        Label9.Text = "Total Amount"
        ' 
        ' txt_itemrate
        ' 
        txt_itemrate.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txt_itemrate.Location = New Point(649, 168)
        txt_itemrate.Name = "txt_itemrate"
        txt_itemrate.Size = New Size(250, 30)
        txt_itemrate.TabIndex = 13
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(504, 170)
        Label8.Name = "Label8"
        Label8.Size = New Size(52, 28)
        Label8.TabIndex = 12
        Label8.Text = "Rate"
        ' 
        ' txt_itemquantity
        ' 
        txt_itemquantity.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txt_itemquantity.Location = New Point(649, 108)
        txt_itemquantity.Name = "txt_itemquantity"
        txt_itemquantity.Size = New Size(250, 30)
        txt_itemquantity.TabIndex = 11
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(504, 110)
        Label7.Name = "Label7"
        Label7.Size = New Size(90, 28)
        Label7.TabIndex = 10
        Label7.Text = "Quantity"
        ' 
        ' txt_itemname
        ' 
        txt_itemname.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txt_itemname.Location = New Point(649, 47)
        txt_itemname.Name = "txt_itemname"
        txt_itemname.Size = New Size(250, 30)
        txt_itemname.TabIndex = 9
        ' 
        ' txt_supplierphone
        ' 
        txt_supplierphone.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txt_supplierphone.Location = New Point(189, 168)
        txt_supplierphone.Name = "txt_supplierphone"
        txt_supplierphone.Size = New Size(250, 30)
        txt_supplierphone.TabIndex = 8
        ' 
        ' txt_supplieraddress
        ' 
        txt_supplieraddress.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txt_supplieraddress.Location = New Point(189, 108)
        txt_supplieraddress.Name = "txt_supplieraddress"
        txt_supplieraddress.Size = New Size(250, 30)
        txt_supplieraddress.TabIndex = 7
        ' 
        ' txt_suppliername
        ' 
        txt_suppliername.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txt_suppliername.Location = New Point(189, 47)
        txt_suppliername.Name = "txt_suppliername"
        txt_suppliername.Size = New Size(250, 30)
        txt_suppliername.TabIndex = 6
        ' 
        ' itembuydate
        ' 
        itembuydate.Location = New Point(189, 228)
        itembuydate.Name = "itembuydate"
        itembuydate.Size = New Size(250, 34)
        itembuydate.TabIndex = 3
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(26, 170)
        Label6.Name = "Label6"
        Label6.Size = New Size(109, 28)
        Label6.TabIndex = 4
        Label6.Text = "Phone No."
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(504, 50)
        Label5.Name = "Label5"
        Label5.Size = New Size(114, 28)
        Label5.TabIndex = 3
        Label5.Text = "Item Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(26, 230)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 28)
        Label4.TabIndex = 2
        Label4.Text = "Date"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(26, 110)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 28)
        Label3.TabIndex = 1
        Label3.Text = "Address"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(26, 50)
        Label2.Name = "Label2"
        Label2.Size = New Size(147, 28)
        Label2.TabIndex = 0
        Label2.Text = "Supplier Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(597, 262)
        Label1.Name = "Label1"
        Label1.Size = New Size(323, 35)
        Label1.TabIndex = 1
        Label1.Text = "ITEM ADDING FORM"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Dock = DockStyle.Top
        DataGridView1.Location = New Point(3, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(1904, 256)
        DataGridView1.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = SystemColors.Info
        TabPage2.Controls.Add(Label18)
        TabPage2.Controls.Add(GroupBox2)
        TabPage2.Controls.Add(DataGridView2)
        TabPage2.Location = New Point(4, 32)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1910, 888)
        TabPage2.TabIndex = 1
        TabPage2.Text = "VIEW"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label18.Location = New Point(597, 262)
        Label18.Name = "Label18"
        Label18.Size = New Size(289, 41)
        Label18.TabIndex = 7
        Label18.Text = "VIEW ITEMS FORM"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = SystemColors.GradientActiveCaption
        GroupBox2.Controls.Add(Button3)
        GroupBox2.Controls.Add(Button4)
        GroupBox2.Controls.Add(TextBox2)
        GroupBox2.Controls.Add(Label10)
        GroupBox2.Controls.Add(TextBox3)
        GroupBox2.Controls.Add(Label11)
        GroupBox2.Controls.Add(TextBox4)
        GroupBox2.Controls.Add(Label12)
        GroupBox2.Controls.Add(TextBox5)
        GroupBox2.Controls.Add(TextBox6)
        GroupBox2.Controls.Add(TextBox7)
        GroupBox2.Controls.Add(TextBox8)
        GroupBox2.Controls.Add(DateTimePicker1)
        GroupBox2.Controls.Add(Label13)
        GroupBox2.Controls.Add(Label14)
        GroupBox2.Controls.Add(Label15)
        GroupBox2.Controls.Add(Label16)
        GroupBox2.Controls.Add(Label17)
        GroupBox2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox2.Location = New Point(109, 304)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(1349, 348)
        GroupBox2.TabIndex = 6
        GroupBox2.TabStop = False
        GroupBox2.Text = "ADD ITEMS"
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.InactiveCaption
        Button3.Location = New Point(1048, 162)
        Button3.Name = "Button3"
        Button3.Size = New Size(111, 44)
        Button3.TabIndex = 17
        Button3.Text = "Refresh"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.InactiveCaption
        Button4.Location = New Point(1048, 75)
        Button4.Name = "Button4"
        Button4.Size = New Size(111, 44)
        Button4.TabIndex = 16
        Button4.Text = "Save"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox2.Location = New Point(649, 228)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(250, 30)
        TextBox2.TabIndex = 15
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(504, 230)
        Label10.Name = "Label10"
        Label10.Size = New Size(135, 28)
        Label10.TabIndex = 14
        Label10.Text = "Total Amount"
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox3.Location = New Point(649, 168)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(250, 30)
        TextBox3.TabIndex = 13
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(504, 170)
        Label11.Name = "Label11"
        Label11.Size = New Size(52, 28)
        Label11.TabIndex = 12
        Label11.Text = "Rate"
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox4.Location = New Point(649, 108)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(250, 30)
        TextBox4.TabIndex = 11
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(504, 110)
        Label12.Name = "Label12"
        Label12.Size = New Size(90, 28)
        Label12.TabIndex = 10
        Label12.Text = "Quantity"
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox5.Location = New Point(649, 47)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(250, 30)
        TextBox5.TabIndex = 9
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox6.Location = New Point(189, 168)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(250, 30)
        TextBox6.TabIndex = 8
        ' 
        ' TextBox7
        ' 
        TextBox7.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox7.Location = New Point(189, 108)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(250, 30)
        TextBox7.TabIndex = 7
        ' 
        ' TextBox8
        ' 
        TextBox8.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox8.Location = New Point(189, 47)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(250, 30)
        TextBox8.TabIndex = 6
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(189, 228)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(250, 34)
        DateTimePicker1.TabIndex = 3
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(26, 170)
        Label13.Name = "Label13"
        Label13.Size = New Size(109, 28)
        Label13.TabIndex = 4
        Label13.Text = "Phone No."
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(504, 50)
        Label14.Name = "Label14"
        Label14.Size = New Size(114, 28)
        Label14.TabIndex = 3
        Label14.Text = "Item Name"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(26, 230)
        Label15.Name = "Label15"
        Label15.Size = New Size(54, 28)
        Label15.TabIndex = 2
        Label15.Text = "Date"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(26, 110)
        Label16.Name = "Label16"
        Label16.Size = New Size(85, 28)
        Label16.TabIndex = 1
        Label16.Text = "Address"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(26, 50)
        Label17.Name = "Label17"
        Label17.Size = New Size(147, 28)
        Label17.TabIndex = 0
        Label17.Text = "Supplier Name"
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Dock = DockStyle.Top
        DataGridView2.Location = New Point(3, 3)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.RowTemplate.Height = 29
        DataGridView2.Size = New Size(1904, 257)
        DataGridView2.TabIndex = 1
        ' 
        ' TabPage3
        ' 
        TabPage3.BackColor = SystemColors.Info
        TabPage3.Controls.Add(Label27)
        TabPage3.Controls.Add(GroupBox3)
        TabPage3.Controls.Add(DataGridView3)
        TabPage3.Location = New Point(4, 32)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(1910, 888)
        TabPage3.TabIndex = 2
        TabPage3.Text = "UPDATE"
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label27.Location = New Point(597, 262)
        Label27.Name = "Label27"
        Label27.Size = New Size(327, 41)
        Label27.TabIndex = 8
        Label27.Text = "UPDATE ITEMS FORM"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = SystemColors.GradientActiveCaption
        GroupBox3.Controls.Add(Button5)
        GroupBox3.Controls.Add(Button6)
        GroupBox3.Controls.Add(TextBox9)
        GroupBox3.Controls.Add(Label19)
        GroupBox3.Controls.Add(TextBox10)
        GroupBox3.Controls.Add(Label20)
        GroupBox3.Controls.Add(TextBox11)
        GroupBox3.Controls.Add(Label21)
        GroupBox3.Controls.Add(TextBox12)
        GroupBox3.Controls.Add(TextBox13)
        GroupBox3.Controls.Add(TextBox14)
        GroupBox3.Controls.Add(TextBox15)
        GroupBox3.Controls.Add(DateTimePicker2)
        GroupBox3.Controls.Add(Label22)
        GroupBox3.Controls.Add(Label23)
        GroupBox3.Controls.Add(Label24)
        GroupBox3.Controls.Add(Label25)
        GroupBox3.Controls.Add(Label26)
        GroupBox3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox3.Location = New Point(127, 303)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(1349, 348)
        GroupBox3.TabIndex = 7
        GroupBox3.TabStop = False
        GroupBox3.Text = "UPADATE ITEMS"
        ' 
        ' Button5
        ' 
        Button5.BackColor = SystemColors.InactiveCaption
        Button5.Location = New Point(1048, 162)
        Button5.Name = "Button5"
        Button5.Size = New Size(111, 44)
        Button5.TabIndex = 17
        Button5.Text = "Refresh"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = SystemColors.InactiveCaption
        Button6.Location = New Point(1048, 75)
        Button6.Name = "Button6"
        Button6.Size = New Size(111, 44)
        Button6.TabIndex = 16
        Button6.Text = "Save"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' TextBox9
        ' 
        TextBox9.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox9.Location = New Point(649, 228)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(250, 30)
        TextBox9.TabIndex = 15
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(504, 230)
        Label19.Name = "Label19"
        Label19.Size = New Size(135, 28)
        Label19.TabIndex = 14
        Label19.Text = "Total Amount"
        ' 
        ' TextBox10
        ' 
        TextBox10.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox10.Location = New Point(649, 168)
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(250, 30)
        TextBox10.TabIndex = 13
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(504, 170)
        Label20.Name = "Label20"
        Label20.Size = New Size(52, 28)
        Label20.TabIndex = 12
        Label20.Text = "Rate"
        ' 
        ' TextBox11
        ' 
        TextBox11.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox11.Location = New Point(649, 108)
        TextBox11.Name = "TextBox11"
        TextBox11.Size = New Size(250, 30)
        TextBox11.TabIndex = 11
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Location = New Point(504, 110)
        Label21.Name = "Label21"
        Label21.Size = New Size(90, 28)
        Label21.TabIndex = 10
        Label21.Text = "Quantity"
        ' 
        ' TextBox12
        ' 
        TextBox12.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox12.Location = New Point(649, 47)
        TextBox12.Name = "TextBox12"
        TextBox12.Size = New Size(250, 30)
        TextBox12.TabIndex = 9
        ' 
        ' TextBox13
        ' 
        TextBox13.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox13.Location = New Point(189, 168)
        TextBox13.Name = "TextBox13"
        TextBox13.Size = New Size(250, 30)
        TextBox13.TabIndex = 8
        ' 
        ' TextBox14
        ' 
        TextBox14.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox14.Location = New Point(189, 108)
        TextBox14.Name = "TextBox14"
        TextBox14.Size = New Size(250, 30)
        TextBox14.TabIndex = 7
        ' 
        ' TextBox15
        ' 
        TextBox15.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox15.Location = New Point(189, 47)
        TextBox15.Name = "TextBox15"
        TextBox15.Size = New Size(250, 30)
        TextBox15.TabIndex = 6
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Location = New Point(189, 228)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(250, 34)
        DateTimePicker2.TabIndex = 3
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Location = New Point(26, 170)
        Label22.Name = "Label22"
        Label22.Size = New Size(109, 28)
        Label22.TabIndex = 4
        Label22.Text = "Phone No."
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Location = New Point(504, 50)
        Label23.Name = "Label23"
        Label23.Size = New Size(114, 28)
        Label23.TabIndex = 3
        Label23.Text = "Item Name"
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Location = New Point(26, 230)
        Label24.Name = "Label24"
        Label24.Size = New Size(54, 28)
        Label24.TabIndex = 2
        Label24.Text = "Date"
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Location = New Point(26, 110)
        Label25.Name = "Label25"
        Label25.Size = New Size(85, 28)
        Label25.TabIndex = 1
        Label25.Text = "Address"
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Location = New Point(26, 50)
        Label26.Name = "Label26"
        Label26.Size = New Size(147, 28)
        Label26.TabIndex = 0
        Label26.Text = "Supplier Name"
        ' 
        ' DataGridView3
        ' 
        DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView3.Dock = DockStyle.Top
        DataGridView3.Location = New Point(3, 3)
        DataGridView3.Name = "DataGridView3"
        DataGridView3.RowHeadersWidth = 51
        DataGridView3.RowTemplate.Height = 29
        DataGridView3.Size = New Size(1904, 257)
        DataGridView3.TabIndex = 2
        ' 
        ' TabPage4
        ' 
        TabPage4.BackColor = SystemColors.Info
        TabPage4.Location = New Point(4, 32)
        TabPage4.Name = "TabPage4"
        TabPage4.Size = New Size(1649, 763)
        TabPage4.TabIndex = 3
        TabPage4.Text = "DELETE"
        ' 
        ' TabPage5
        ' 
        TabPage5.BackColor = SystemColors.Info
        TabPage5.Location = New Point(4, 32)
        TabPage5.Name = "TabPage5"
        TabPage5.Size = New Size(1649, 763)
        TabPage5.TabIndex = 4
        TabPage5.Text = "SELL"
        ' 
        ' TabPage6
        ' 
        TabPage6.BackColor = SystemColors.Info
        TabPage6.Location = New Point(4, 32)
        TabPage6.Name = "TabPage6"
        TabPage6.Size = New Size(1649, 763)
        TabPage6.TabIndex = 5
        TabPage6.Text = "BUY"
        ' 
        ' home
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(1924, 953)
        Controls.Add(Panel1)
        Name = "home"
        StartPosition = FormStartPosition.CenterScreen
        Text = "home"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(DataGridView3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FILEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FORMToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RECORDSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ABOUTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents FileToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintPreviewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As ToolStripSeparator
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator4 As ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_suppliername As TextBox
    Friend WithEvents itembuydate As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_itemname As TextBox
    Friend WithEvents txt_supplierphone As TextBox
    Friend WithEvents txt_supplieraddress As TextBox
    Friend WithEvents txt_itemquantity As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_itemrate As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents DataGridView3 As DataGridView
End Class
