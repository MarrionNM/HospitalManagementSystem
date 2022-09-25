<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class New_Doctor
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PicDoc = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LnkDocEmailDocEmail = New System.Windows.Forms.TextBox()
        Me.TxtDocContact = New System.Windows.Forms.TextBox()
        Me.TxtOfficeNo = New System.Windows.Forms.TextBox()
        Me.TxtDocField = New System.Windows.Forms.TextBox()
        Me.TxtDocId = New System.Windows.Forms.TextBox()
        Me.TxtDocSurname = New System.Windows.Forms.TextBox()
        Me.TxtDocName = New System.Windows.Forms.TextBox()
        Me.RxtDocAddress = New System.Windows.Forms.RichTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbDocGender = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PicDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmbDocGender)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.PicDoc)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.LnkDocEmailDocEmail)
        Me.GroupBox1.Controls.Add(Me.TxtDocContact)
        Me.GroupBox1.Controls.Add(Me.TxtOfficeNo)
        Me.GroupBox1.Controls.Add(Me.TxtDocField)
        Me.GroupBox1.Controls.Add(Me.TxtDocId)
        Me.GroupBox1.Controls.Add(Me.TxtDocSurname)
        Me.GroupBox1.Controls.Add(Me.TxtDocName)
        Me.GroupBox1.Controls.Add(Me.RxtDocAddress)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(572, 408)
        Me.GroupBox1.TabIndex = 66
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Details"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(14, 309)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 18)
        Me.Label11.TabIndex = 88
        Me.Label11.Text = "Hospital Id"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(100, 306)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(148, 26)
        Me.ComboBox1.TabIndex = 87
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(480, 367)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(65, 35)
        Me.Button2.TabIndex = 86
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PicDoc
        '
        Me.PicDoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PicDoc.Location = New System.Drawing.Point(370, 181)
        Me.PicDoc.Name = "PicDoc"
        Me.PicDoc.Size = New System.Drawing.Size(175, 180)
        Me.PicDoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicDoc.TabIndex = 85
        Me.PicDoc.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(283, 309)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 52)
        Me.Button1.TabIndex = 74
        Me.Button1.Text = "Capture Picture"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LnkDocEmailDocEmail
        '
        Me.LnkDocEmailDocEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnkDocEmailDocEmail.Location = New System.Drawing.Point(100, 186)
        Me.LnkDocEmailDocEmail.Name = "LnkDocEmailDocEmail"
        Me.LnkDocEmailDocEmail.Size = New System.Drawing.Size(148, 26)
        Me.LnkDocEmailDocEmail.TabIndex = 70
        '
        'TxtDocContact
        '
        Me.TxtDocContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDocContact.Location = New System.Drawing.Point(100, 146)
        Me.TxtDocContact.Name = "TxtDocContact"
        Me.TxtDocContact.Size = New System.Drawing.Size(148, 26)
        Me.TxtDocContact.TabIndex = 69
        '
        'TxtOfficeNo
        '
        Me.TxtOfficeNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOfficeNo.Location = New System.Drawing.Point(100, 266)
        Me.TxtOfficeNo.Name = "TxtOfficeNo"
        Me.TxtOfficeNo.Size = New System.Drawing.Size(148, 26)
        Me.TxtOfficeNo.TabIndex = 73
        '
        'TxtDocField
        '
        Me.TxtDocField.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDocField.Location = New System.Drawing.Point(100, 226)
        Me.TxtDocField.Name = "TxtDocField"
        Me.TxtDocField.Size = New System.Drawing.Size(148, 26)
        Me.TxtDocField.TabIndex = 72
        '
        'TxtDocId
        '
        Me.TxtDocId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDocId.Location = New System.Drawing.Point(100, 346)
        Me.TxtDocId.Name = "TxtDocId"
        Me.TxtDocId.Size = New System.Drawing.Size(148, 26)
        Me.TxtDocId.TabIndex = 84
        '
        'TxtDocSurname
        '
        Me.TxtDocSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDocSurname.Location = New System.Drawing.Point(100, 66)
        Me.TxtDocSurname.Name = "TxtDocSurname"
        Me.TxtDocSurname.Size = New System.Drawing.Size(148, 26)
        Me.TxtDocSurname.TabIndex = 67
        '
        'TxtDocName
        '
        Me.TxtDocName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDocName.Location = New System.Drawing.Point(100, 26)
        Me.TxtDocName.Name = "TxtDocName"
        Me.TxtDocName.Size = New System.Drawing.Size(148, 26)
        Me.TxtDocName.TabIndex = 66
        '
        'RxtDocAddress
        '
        Me.RxtDocAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RxtDocAddress.Location = New System.Drawing.Point(385, 26)
        Me.RxtDocAddress.Name = "RxtDocAddress"
        Me.RxtDocAddress.Size = New System.Drawing.Size(160, 149)
        Me.RxtDocAddress.TabIndex = 71
        Me.RxtDocAddress.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(258, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 18)
        Me.Label7.TabIndex = 83
        Me.Label7.Text = "Physical Address"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(46, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 18)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "Email"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 18)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "Contact"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(52, 230)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 18)
        Me.Label10.TabIndex = 79
        Me.Label10.Text = "Field"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 270)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 18)
        Me.Label8.TabIndex = 80
        Me.Label8.Text = "Office no"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(69, 350)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 18)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "ID"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 18)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Gender"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 18)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Surname"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 18)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbDocGender
        '
        Me.CmbDocGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDocGender.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmbDocGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbDocGender.FormattingEnabled = True
        Me.CmbDocGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.CmbDocGender.Location = New System.Drawing.Point(100, 106)
        Me.CmbDocGender.Name = "CmbDocGender"
        Me.CmbDocGender.Size = New System.Drawing.Size(148, 26)
        Me.CmbDocGender.TabIndex = 89
        '
        'New_Doctor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 431)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "New_Doctor"
        Me.Text = "New_Doctor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PicDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PicDoc As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LnkDocEmailDocEmail As System.Windows.Forms.TextBox
    Friend WithEvents TxtDocContact As System.Windows.Forms.TextBox
    Friend WithEvents TxtOfficeNo As System.Windows.Forms.TextBox
    Friend WithEvents TxtDocField As System.Windows.Forms.TextBox
    Friend WithEvents TxtDocId As System.Windows.Forms.TextBox
    Friend WithEvents TxtDocSurname As System.Windows.Forms.TextBox
    Friend WithEvents TxtDocName As System.Windows.Forms.TextBox
    Friend WithEvents RxtDocAddress As System.Windows.Forms.RichTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbDocGender As ComboBox
End Class
