Public Class Form1

    Private Sub DoctorsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DoctorsToolStripMenuItem.Click
        Manage_Doctors.Show()
    End Sub

    Private Sub NewDoctorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewDoctorToolStripMenuItem.Click
        New_Doctor.Show()
    End Sub

    Private Sub ViewAllToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ViewAllToolStripMenuItem1.Click
        New_Employee.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PatientsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PatientsToolStripMenuItem.Click

    End Sub
End Class
