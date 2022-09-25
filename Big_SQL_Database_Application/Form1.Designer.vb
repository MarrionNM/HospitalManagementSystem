<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ManageHospitalsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HospitalsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageDoctorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewDoctorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DoctorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewLlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewAllToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PatientsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ByHospitalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ByDoctorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ByConditionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DarkGray
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageHospitalsToolStripMenuItem, Me.ManageDoctorsToolStripMenuItem, Me.EmployeesToolStripMenuItem, Me.PatientsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(813, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ManageHospitalsToolStripMenuItem
        '
        Me.ManageHospitalsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HospitalsToolStripMenuItem})
        Me.ManageHospitalsToolStripMenuItem.Name = "ManageHospitalsToolStripMenuItem"
        Me.ManageHospitalsToolStripMenuItem.Size = New System.Drawing.Size(114, 20)
        Me.ManageHospitalsToolStripMenuItem.Text = "Manage Hospitals"
        '
        'HospitalsToolStripMenuItem
        '
        Me.HospitalsToolStripMenuItem.Name = "HospitalsToolStripMenuItem"
        Me.HospitalsToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.HospitalsToolStripMenuItem.Text = "View All"
        '
        'ManageDoctorsToolStripMenuItem
        '
        Me.ManageDoctorsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewDoctorToolStripMenuItem, Me.DoctorsToolStripMenuItem})
        Me.ManageDoctorsToolStripMenuItem.Name = "ManageDoctorsToolStripMenuItem"
        Me.ManageDoctorsToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.ManageDoctorsToolStripMenuItem.Text = "Manage Doctors"
        '
        'NewDoctorToolStripMenuItem
        '
        Me.NewDoctorToolStripMenuItem.Name = "NewDoctorToolStripMenuItem"
        Me.NewDoctorToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.NewDoctorToolStripMenuItem.Text = "New Doctor"
        '
        'DoctorsToolStripMenuItem
        '
        Me.DoctorsToolStripMenuItem.Name = "DoctorsToolStripMenuItem"
        Me.DoctorsToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.DoctorsToolStripMenuItem.Text = "View All"
        '
        'EmployeesToolStripMenuItem
        '
        Me.EmployeesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewLlToolStripMenuItem, Me.ViewAllToolStripMenuItem1})
        Me.EmployeesToolStripMenuItem.Name = "EmployeesToolStripMenuItem"
        Me.EmployeesToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.EmployeesToolStripMenuItem.Text = "Employees"
        '
        'ViewLlToolStripMenuItem
        '
        Me.ViewLlToolStripMenuItem.Name = "ViewLlToolStripMenuItem"
        Me.ViewLlToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ViewLlToolStripMenuItem.Text = "New Employee"
        '
        'ViewAllToolStripMenuItem1
        '
        Me.ViewAllToolStripMenuItem1.Name = "ViewAllToolStripMenuItem1"
        Me.ViewAllToolStripMenuItem1.Size = New System.Drawing.Size(153, 22)
        Me.ViewAllToolStripMenuItem1.Text = "View All"
        '
        'PatientsToolStripMenuItem
        '
        Me.PatientsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ByHospitalToolStripMenuItem, Me.ByDoctorToolStripMenuItem, Me.ByConditionToolStripMenuItem, Me.ViewAllToolStripMenuItem})
        Me.PatientsToolStripMenuItem.Name = "PatientsToolStripMenuItem"
        Me.PatientsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.PatientsToolStripMenuItem.Text = "Patients"
        '
        'ByHospitalToolStripMenuItem
        '
        Me.ByHospitalToolStripMenuItem.Name = "ByHospitalToolStripMenuItem"
        Me.ByHospitalToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ByHospitalToolStripMenuItem.Text = "By Hospital"
        '
        'ByDoctorToolStripMenuItem
        '
        Me.ByDoctorToolStripMenuItem.Name = "ByDoctorToolStripMenuItem"
        Me.ByDoctorToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ByDoctorToolStripMenuItem.Text = "By Doctor"
        '
        'ByConditionToolStripMenuItem
        '
        Me.ByConditionToolStripMenuItem.Name = "ByConditionToolStripMenuItem"
        Me.ByConditionToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ByConditionToolStripMenuItem.Text = "By Condition"
        '
        'ViewAllToolStripMenuItem
        '
        Me.ViewAllToolStripMenuItem.Name = "ViewAllToolStripMenuItem"
        Me.ViewAllToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ViewAllToolStripMenuItem.Text = "View All"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 72.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(266, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(240, 117)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "HMS"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(813, 437)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Hospital Managment System"
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ManageHospitalsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HospitalsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageDoctorsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewDoctorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DoctorsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewLlToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PatientsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ByHospitalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ByDoctorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ByConditionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewAllToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As Label
End Class
