<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.FbookBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Flight_registrationDataSet = New final_strs.flight_registrationDataSet()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.ORI = New System.Windows.Forms.TextBox()
        Me.DES = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.clas = New System.Windows.Forms.TextBox()
        Me.fare = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.FbookTableAdapter = New final_strs.flight_registrationDataSetTableAdapters.fbookTableAdapter()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        CType(Me.FbookBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Flight_registrationDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FbookBindingSource, "Customerf Name", True))
        Me.TextBox1.Location = New System.Drawing.Point(97, 62)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(229, 20)
        Me.TextBox1.TabIndex = 0
        '
        'FbookBindingSource
        '
        Me.FbookBindingSource.DataMember = "fbook"
        Me.FbookBindingSource.DataSource = Me.Flight_registrationDataSet
        '
        'Flight_registrationDataSet
        '
        Me.Flight_registrationDataSet.DataSetName = "flight_registrationDataSet"
        Me.Flight_registrationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FbookBindingSource, "Customer last name", True))
        Me.TextBox2.Location = New System.Drawing.Point(498, 62)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(143, 20)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FbookBindingSource, "dob date", True))
        Me.TextBox3.Location = New System.Drawing.Point(97, 102)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(64, 20)
        Me.TextBox3.TabIndex = 2
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FbookBindingSource, "monthe", True))
        Me.TextBox4.Location = New System.Drawing.Point(226, 102)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(55, 20)
        Me.TextBox4.TabIndex = 3
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FbookBindingSource, "years", True))
        Me.TextBox5.Location = New System.Drawing.Point(328, 102)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(77, 20)
        Me.TextBox5.TabIndex = 4
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FbookBindingSource, "addrsss", True))
        Me.TextBox6.Location = New System.Drawing.Point(97, 139)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(368, 20)
        Me.TextBox6.TabIndex = 5
        '
        'ORI
        '
        Me.ORI.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FbookBindingSource, "origin", True))
        Me.ORI.Location = New System.Drawing.Point(97, 178)
        Me.ORI.Name = "ORI"
        Me.ORI.Size = New System.Drawing.Size(368, 20)
        Me.ORI.TabIndex = 6
        '
        'DES
        '
        Me.DES.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FbookBindingSource, "destintion", True))
        Me.DES.Location = New System.Drawing.Point(97, 204)
        Me.DES.Name = "DES"
        Me.DES.Size = New System.Drawing.Size(368, 20)
        Me.DES.TabIndex = 10
        '
        'TextBox12
        '
        Me.TextBox12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FbookBindingSource, "yearss", True))
        Me.TextBox12.Location = New System.Drawing.Point(333, 258)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(77, 20)
        Me.TextBox12.TabIndex = 13
        '
        'TextBox13
        '
        Me.TextBox13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FbookBindingSource, "mo", True))
        Me.TextBox13.Location = New System.Drawing.Point(226, 255)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(55, 20)
        Me.TextBox13.TabIndex = 12
        '
        'TextBox14
        '
        Me.TextBox14.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FbookBindingSource, "startd", True))
        Me.TextBox14.Location = New System.Drawing.Point(97, 255)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(64, 20)
        Me.TextBox14.TabIndex = 11
        '
        'TextBox8
        '
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FbookBindingSource, "flight id", True))
        Me.TextBox8.Location = New System.Drawing.Point(547, 259)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(115, 20)
        Me.TextBox8.TabIndex = 17
        '
        'TextBox9
        '
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FbookBindingSource, "candidate id", True))
        Me.TextBox9.Location = New System.Drawing.Point(548, 319)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(115, 20)
        Me.TextBox9.TabIndex = 18
        '
        'clas
        '
        Me.clas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FbookBindingSource, "class", True))
        Me.clas.Location = New System.Drawing.Point(97, 375)
        Me.clas.Name = "clas"
        Me.clas.Size = New System.Drawing.Size(115, 20)
        Me.clas.TabIndex = 19
        '
        'fare
        '
        Me.fare.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FbookBindingSource, "fare", True))
        Me.fare.Location = New System.Drawing.Point(97, 401)
        Me.fare.Name = "fare"
        Me.fare.Size = New System.Drawing.Size(115, 20)
        Me.fare.TabIndex = 20
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(97, 440)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.FbookBindingSource, "male", True))
        Me.RadioButton1.Location = New System.Drawing.Point(512, 104)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(48, 17)
        Me.RadioButton1.TabIndex = 22
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Male"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton2.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.FbookBindingSource, "female", True))
        Me.RadioButton2.Location = New System.Drawing.Point(575, 102)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(59, 17)
        Me.RadioButton2.TabIndex = 23
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Female"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton3.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.FbookBindingSource, "other", True))
        Me.RadioButton3.Location = New System.Drawing.Point(640, 102)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(51, 17)
        Me.RadioButton3.TabIndex = 24
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Other"
        Me.RadioButton3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 16)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "FirstName"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(413, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 16)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "LastName"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(413, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 16)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Sex"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 16)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "D.O.B."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(43, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 16)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(167, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 16)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Month"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(285, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 16)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Year"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 140)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 16)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Address"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(43, 178)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 16)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Origin"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 205)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 16)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Destination"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 229)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 16)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Start Date"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(31, 259)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 16)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Date"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(171, 259)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 16)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Month"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(286, 256)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 16)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "Year"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(285, 323)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 16)
        Me.Label15.TabIndex = 45
        Me.Label15.Text = "Year"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(167, 325)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 16)
        Me.Label16.TabIndex = 44
        Me.Label16.Text = "Month"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(26, 328)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(41, 16)
        Me.Label17.TabIndex = 43
        Me.Label17.Text = "Date"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(8, 293)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(94, 16)
        Me.Label18.TabIndex = 42
        Me.Label18.Text = "Return Date "
        '
        'TextBox15
        '
        Me.TextBox15.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FbookBindingSource, "ryear", True))
        Me.TextBox15.Location = New System.Drawing.Point(333, 319)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(77, 20)
        Me.TextBox15.TabIndex = 41
        '
        'TextBox16
        '
        Me.TextBox16.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FbookBindingSource, "rmonth", True))
        Me.TextBox16.Location = New System.Drawing.Point(226, 323)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(55, 20)
        Me.TextBox16.TabIndex = 40
        '
        'TextBox17
        '
        Me.TextBox17.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FbookBindingSource, "rdate", True))
        Me.TextBox17.Location = New System.Drawing.Point(87, 324)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(64, 20)
        Me.TextBox17.TabIndex = 39
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(545, 229)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(63, 16)
        Me.Label19.TabIndex = 46
        Me.Label19.Text = "Flight id"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(545, 293)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(90, 16)
        Me.Label20.TabIndex = 47
        Me.Label20.Text = "Customer Id"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(25, 375)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(47, 16)
        Me.Label21.TabIndex = 48
        Me.Label21.Text = "Class"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(26, 405)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(40, 16)
        Me.Label22.TabIndex = 49
        Me.Label22.Text = "Fare"
        '
        'FbookTableAdapter
        '
        Me.FbookTableAdapter.ClearBeforeFill = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Location = New System.Drawing.Point(328, 62)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(11, 13)
        Me.Label23.TabIndex = 50
        Me.Label23.Text = "*"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Location = New System.Drawing.Point(647, 62)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(11, 13)
        Me.Label24.TabIndex = 51
        Me.Label24.Text = "*"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Location = New System.Drawing.Point(83, 309)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(11, 13)
        Me.Label25.TabIndex = 52
        Me.Label25.Text = "*"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Location = New System.Drawing.Point(84, 330)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(11, 13)
        Me.Label26.TabIndex = 53
        Me.Label26.Text = "*"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Location = New System.Drawing.Point(480, 509)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(79, 13)
        Me.Label27.TabIndex = 54
        Me.Label27.Text = "* Required field"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(739, 531)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TextBox15)
        Me.Controls.Add(Me.TextBox16)
        Me.Controls.Add(Me.TextBox17)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.fare)
        Me.Controls.Add(Me.clas)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.TextBox13)
        Me.Controls.Add(Me.TextBox14)
        Me.Controls.Add(Me.DES)
        Me.Controls.Add(Me.ORI)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form3"
        Me.Text = "Book"
        CType(Me.FbookBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Flight_registrationDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents ORI As System.Windows.Forms.TextBox
    Friend WithEvents DES As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents clas As System.Windows.Forms.TextBox
    Friend WithEvents fare As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Flight_registrationDataSet As final_strs.flight_registrationDataSet
    Friend WithEvents FbookBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FbookTableAdapter As final_strs.flight_registrationDataSetTableAdapters.fbookTableAdapter
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
End Class
