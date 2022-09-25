<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manage_Doctors
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
        Me.DgvEmp = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PicDoc = New System.Windows.Forms.PictureBox()
        Me.GrbDocDetails = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.LnkDocEmailDocEmail = New System.Windows.Forms.TextBox()
        Me.TxtDocContact = New System.Windows.Forms.TextBox()
        Me.LblDocHospitalId = New System.Windows.Forms.TextBox()
        Me.TxtDocNoOfPatients = New System.Windows.Forms.TextBox()
        Me.TxtOfficeNo = New System.Windows.Forms.TextBox()
        Me.TxtDocField = New System.Windows.Forms.TextBox()
        Me.TxtDocId = New System.Windows.Forms.TextBox()
        Me.TxtDocGender = New System.Windows.Forms.TextBox()
        Me.TxtDocSurname = New System.Windows.Forms.TextBox()
        Me.TxtDocName = New System.Windows.Forms.TextBox()
        Me.RxtDocAddress = New System.Windows.Forms.RichTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.DgvEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrbDocDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvEmp
        '
        Me.DgvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEmp.Location = New System.Drawing.Point(12, 231)
        Me.DgvEmp.Name = "DgvEmp"
        Me.DgvEmp.ReadOnly = True
        Me.DgvEmp.Size = New System.Drawing.Size(894, 311)
        Me.DgvEmp.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(917, 290)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 56)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "New Doctor"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(912, 355)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 48)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Update Doctor"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(917, 412)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(71, 28)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Delete Doctor"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(917, 244)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(69, 37)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Refresh"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'PicDoc
        '
        Me.PicDoc.Location = New System.Drawing.Point(6, 19)
        Me.PicDoc.Name = "PicDoc"
        Me.PicDoc.Size = New System.Drawing.Size(175, 180)
        Me.PicDoc.TabIndex = 5
        Me.PicDoc.TabStop = False
        '
        'GrbDocDetails
        '
        Me.GrbDocDetails.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.GrbDocDetails.Controls.Add(Me.Button6)
        Me.GrbDocDetails.Controls.Add(Me.LnkDocEmailDocEmail)
        Me.GrbDocDetails.Controls.Add(Me.TxtDocContact)
        Me.GrbDocDetails.Controls.Add(Me.LblDocHospitalId)
        Me.GrbDocDetails.Controls.Add(Me.TxtDocNoOfPatients)
        Me.GrbDocDetails.Controls.Add(Me.TxtOfficeNo)
        Me.GrbDocDetails.Controls.Add(Me.TxtDocField)
        Me.GrbDocDetails.Controls.Add(Me.TxtDocId)
        Me.GrbDocDetails.Controls.Add(Me.TxtDocGender)
        Me.GrbDocDetails.Controls.Add(Me.TxtDocSurname)
        Me.GrbDocDetails.Controls.Add(Me.TxtDocName)
        Me.GrbDocDetails.Controls.Add(Me.RxtDocAddress)
        Me.GrbDocDetails.Controls.Add(Me.Label7)
        Me.GrbDocDetails.Controls.Add(Me.Label6)
        Me.GrbDocDetails.Controls.Add(Me.Label4)
        Me.GrbDocDetails.Controls.Add(Me.Label10)
        Me.GrbDocDetails.Controls.Add(Me.Label12)
        Me.GrbDocDetails.Controls.Add(Me.Label9)
        Me.GrbDocDetails.Controls.Add(Me.Label8)
        Me.GrbDocDetails.Controls.Add(Me.Label5)
        Me.GrbDocDetails.Controls.Add(Me.Label3)
        Me.GrbDocDetails.Controls.Add(Me.Label2)
        Me.GrbDocDetails.Controls.Add(Me.Label1)
        Me.GrbDocDetails.Controls.Add(Me.PicDoc)
        Me.GrbDocDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrbDocDetails.Location = New System.Drawing.Point(12, 12)
        Me.GrbDocDetails.Name = "GrbDocDetails"
        Me.GrbDocDetails.Size = New System.Drawing.Size(984, 213)
        Me.GrbDocDetails.TabIndex = 6
        Me.GrbDocDetails.TabStop = False
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(687, 157)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(84, 48)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "Update Doctor"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'LnkDocEmailDocEmail
        '
        Me.LnkDocEmailDocEmail.Location = New System.Drawing.Point(832, 55)
        Me.LnkDocEmailDocEmail.Name = "LnkDocEmailDocEmail"
        Me.LnkDocEmailDocEmail.Size = New System.Drawing.Size(133, 26)
        Me.LnkDocEmailDocEmail.TabIndex = 38
        '
        'TxtDocContact
        '
        Me.TxtDocContact.Location = New System.Drawing.Point(830, 20)
        Me.TxtDocContact.Name = "TxtDocContact"
        Me.TxtDocContact.Size = New System.Drawing.Size(133, 26)
        Me.TxtDocContact.TabIndex = 37
        '
        'LblDocHospitalId
        '
        Me.LblDocHospitalId.Location = New System.Drawing.Point(508, 168)
        Me.LblDocHospitalId.Name = "LblDocHospitalId"
        Me.LblDocHospitalId.Size = New System.Drawing.Size(148, 26)
        Me.LblDocHospitalId.TabIndex = 36
        '
        'TxtDocNoOfPatients
        '
        Me.TxtDocNoOfPatients.Location = New System.Drawing.Point(536, 108)
        Me.TxtDocNoOfPatients.Name = "TxtDocNoOfPatients"
        Me.TxtDocNoOfPatients.Size = New System.Drawing.Size(120, 26)
        Me.TxtDocNoOfPatients.TabIndex = 35
        '
        'TxtOfficeNo
        '
        Me.TxtOfficeNo.Location = New System.Drawing.Point(508, 64)
        Me.TxtOfficeNo.Name = "TxtOfficeNo"
        Me.TxtOfficeNo.Size = New System.Drawing.Size(148, 26)
        Me.TxtOfficeNo.TabIndex = 34
        '
        'TxtDocField
        '
        Me.TxtDocField.Location = New System.Drawing.Point(508, 25)
        Me.TxtDocField.Name = "TxtDocField"
        Me.TxtDocField.Size = New System.Drawing.Size(148, 26)
        Me.TxtDocField.TabIndex = 33
        '
        'TxtDocId
        '
        Me.TxtDocId.Location = New System.Drawing.Point(267, 168)
        Me.TxtDocId.Name = "TxtDocId"
        Me.TxtDocId.Size = New System.Drawing.Size(148, 26)
        Me.TxtDocId.TabIndex = 32
        '
        'TxtDocGender
        '
        Me.TxtDocGender.Location = New System.Drawing.Point(267, 103)
        Me.TxtDocGender.Name = "TxtDocGender"
        Me.TxtDocGender.Size = New System.Drawing.Size(148, 26)
        Me.TxtDocGender.TabIndex = 31
        '
        'TxtDocSurname
        '
        Me.TxtDocSurname.Location = New System.Drawing.Point(267, 66)
        Me.TxtDocSurname.Name = "TxtDocSurname"
        Me.TxtDocSurname.Size = New System.Drawing.Size(148, 26)
        Me.TxtDocSurname.TabIndex = 30
        '
        'TxtDocName
        '
        Me.TxtDocName.Location = New System.Drawing.Point(267, 25)
        Me.TxtDocName.Name = "TxtDocName"
        Me.TxtDocName.Size = New System.Drawing.Size(148, 26)
        Me.TxtDocName.TabIndex = 29
        '
        'RxtDocAddress
        '
        Me.RxtDocAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RxtDocAddress.Location = New System.Drawing.Point(805, 87)
        Me.RxtDocAddress.Name = "RxtDocAddress"
        Me.RxtDocAddress.Size = New System.Drawing.Size(160, 114)
        Me.RxtDocAddress.TabIndex = 28
        Me.RxtDocAddress.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(670, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 20)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Physical Address"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(772, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 20)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Email"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(759, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 20)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Contact"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(459, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 20)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Field"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(421, 111)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(109, 20)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "No of Patients"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(421, 171)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 20)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Hospital Id"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(429, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 20)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Office no"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(243, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "ID"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(198, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Gender"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(187, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Surname"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(210, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(925, 514)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(71, 28)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Exit"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Manage_Doctors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1008, 554)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.GrbDocDetails)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DgvEmp)
        Me.Name = "Manage_Doctors"
        Me.Text = "Manage Doctors"
        CType(Me.DgvEmp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrbDocDetails.ResumeLayout(False)
        Me.GrbDocDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DgvEmp As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents PicDoc As System.Windows.Forms.PictureBox
    Friend WithEvents GrbDocDetails As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RxtDocAddress As System.Windows.Forms.RichTextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents LnkDocEmailDocEmail As System.Windows.Forms.TextBox
    Friend WithEvents TxtDocContact As System.Windows.Forms.TextBox
    Friend WithEvents LblDocHospitalId As System.Windows.Forms.TextBox
    Friend WithEvents TxtDocNoOfPatients As System.Windows.Forms.TextBox
    Friend WithEvents TxtOfficeNo As System.Windows.Forms.TextBox
    Friend WithEvents TxtDocField As System.Windows.Forms.TextBox
    Friend WithEvents TxtDocId As System.Windows.Forms.TextBox
    Friend WithEvents TxtDocGender As System.Windows.Forms.TextBox
    Friend WithEvents TxtDocSurname As System.Windows.Forms.TextBox
    Friend WithEvents TxtDocName As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
End Class
