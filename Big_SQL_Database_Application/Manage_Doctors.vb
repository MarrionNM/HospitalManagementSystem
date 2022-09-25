Public Class Manage_Doctors

    Dim Object1 As New clsDbConnection

    Private Sub Manage_Hospitals_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GrbDocDetails.Enabled = False
      
        Object1 = New clsDbConnection
        Object1.ExecuteQuery("SELECT * FROM Manage_Doctors")

        Object1.table = DgvEmp.DataSource

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DgvEmp.Refresh()
        For Each i As Control In GrbDocDetails.Controls
            If TypeOf i Is TextBox Then
                i.Text = String.Empty
            ElseIf TypeOf i Is LinkLabel Then
                i.Text = String.Empty
            ElseIf TypeOf i Is RichTextBox Then
                i.Text = String.Empty
            End If
        Next
    End Sub

    Sub UpdateData()
        Dim UpdateQuery As New clsDbConnection
        Dim Object1 As String

        Object1 = "UPDATE Manage_Doctors SET(Doc_Hospital_Id=@hosid, Doc_Field@field, Doc_Office_No@office, Doc_Contact=@contact, Doc_Email=@email, Doc_Physical_Address=@address WHERE Doc_Id=@docid)"

        UpdateQuery.AddParameters("@docid", TxtDocId.Text)
        UpdateQuery.AddParameters("@hosid", LblDocHospitalId.Text)
        UpdateQuery.AddParameters("@field", TxtDocField.Text)
        UpdateQuery.AddParameters("@office", TxtOfficeNo.Text)
        UpdateQuery.AddParameters("@contact", TxtDocContact.Text)
        UpdateQuery.AddParameters("@email", LnkDocEmailDocEmail.Text)
        UpdateQuery.AddParameters("@address", RxtDocAddress.Text)

        UpdateQuery.ExecuteQuery(Object1)
        DgvEmp.DataSource = UpdateQuery.table
        MsgBox("Updated")
    End Sub

    Sub DeletaData()

        Dim DeleteQuery As New clsDbConnection
        Dim SQLStatment As String

        SQLStatment = "DELETE FROM Manage_Doctors WHERE Doc_Id = @docid"

        DeleteQuery.AddParameters("@docid", TxtDocId.Text)

        DeleteQuery.ExecuteQuery(SQLStatment)

        MsgBox("Deleted")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GrbDocDetails.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        New_Doctor.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub DgvEmp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvEmp.CellContentClick
        Dim row As DataGridViewRow
        Dim index As Integer

        Try
            index = e.RowIndex
            row = DgvEmp.Rows(index)

            TxtDocName.Text = row.Cells(2).Value.ToString
            TxtDocSurname.Text = row.Cells(3).Value.ToString
            TxtDocGender.Text = row.Cells(4).Value.ToString
            TxtDocField.Text = row.Cells(5).Value.ToString
            TxtOfficeNo.Text = row.Cells(6).Value.ToString
            TxtDocNoOfPatients.Text = row.Cells(7).Value.ToString
            TxtDocContact.Text = row.Cells(8).Value.ToString
            LnkDocEmailDocEmail.Text = row.Cells(9).Value.ToString
            RxtDocAddress.Text = row.Cells(10).Value.ToString
            PicDoc.Image = row.Cells(11).Value
            TxtDocId.Text = row.Cells(1).Value.ToString
            LblDocHospitalId.Text = row.Cells(0).Value.ToString

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        UpdateData()
        GrbDocDetails.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call DeletaData()
    End Sub
End Class
