Imports System.IO
Public Class New_Doctor

    Sub ClearControls()
        For Each i As Control In GroupBox1.Controls
            If TypeOf i Is TextBox Then
                i.Text = String.Empty
            ElseIf TypeOf i Is LinkLabel Then
                i.Text = String.Empty
            ElseIf TypeOf i Is RichTextBox Then
                i.Text = String.Empty
            End If
        Next
    End Sub

    Sub Validation()

        If TxtDocName.Text = String.Empty Then
            TxtDocName.Clear()
            TxtDocName.Focus()
            MsgBox("Invalid Name")
        ElseIf TxtDocSurname.Text = String.Empty Then
            TxtDocSurname.Clear()
            TxtDocSurname.Focus()
            MsgBox("Invalid Surname")
        ElseIf TxtDocContact.Text = String.Empty Then
            TxtDocContact.Clear()
            TxtDocContact.Focus()

        ElseIf LnkDocEmailDocEmail.Text = String.Empty Then
            LnkDocEmailDocEmail.Clear()
            LnkDocEmailDocEmail.Focus()
            MsgBox("Invalid Email")

        ElseIf TxtDocField.Text = String.Empty Then
            TxtDocField.Clear()
            TxtDocField.Focus()
            MsgBox("Invalid Field")
        ElseIf TxtOfficeNo.Text = String.Empty Then
            MsgBox("Invalid Office")

        ElseIf TxtDocId.Text = String.Empty Then
            TxtDocId.Clear()
            TxtDocId.Focus()
            MsgBox("Invalid Id")

        ElseIf RxtDocAddress.Text = String.Empty Then
            RxtDocAddress.Clear()
            RxtDocAddress.Focus()
            MsgBox("Invalid Address")
        Else
            Dim SQLStatment As String
            Dim Employees As New clsDbConnection

            Dim ms As New MemoryStream
            PicDoc.Image.Save(ms, PicDoc.Image.RawFormat)

            Try

                Employees.OpenConnection()
                SQLStatment = "INSERT INTO Manage_Doctors(Doc_Hospital_Id, Doc_Id, Doc_Name, Doc_Surname, Doc_Gender, Doc_Field, Doc_Office_No, Doc_Contact, Doc_Email, Doc_Physical_Address, Doc_Image) VALUES(@hospital_id, @doc_id, @name, @surname, @gender, @field, @office_no, @contact, @email, @physical_address, @pic)"

                Employees.AddParameters("@hospital_id", ComboBox1.SelectedText)
                Employees.AddParameters("@doc_id", TxtDocId.Text)
                Employees.AddParameters("@name", TxtDocName.Text)
                Employees.AddParameters("@surname", TxtDocSurname.Text)
                Employees.AddParameters("@gender", CmbDocGender.Text)
                Employees.AddParameters("@field", TxtDocField.Text)
                Employees.AddParameters("@office_no", TxtOfficeNo.Text)
                Employees.AddParameters("@contact", TxtDocContact.Text)
                Employees.AddParameters("@email", LnkDocEmailDocEmail.Text)
                Employees.AddParameters("@physical_address", RxtDocAddress.Text)
                Employees.AddParameters("@pic", ms.ToArray)

                Employees.ExecuteQuery(SQLStatment)
                MsgBox("Saved")

                ClearControls()

            Catch ex As Exception
                MsgBox(Employees.ErrorMessage)
            End Try
        End If

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Call Validation()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Choose an image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            PicDoc.Image = Image.FromFile(opf.FileName)
        End If
    End Sub

    Private Sub New_Doctor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Hospital 2254")
        ComboBox1.Items.Add("Hospital 7846")
        ComboBox1.Items.Add("Hospital 2431")
        ComboBox1.Items.Add("Hospital 4251")
        ComboBox1.Items.Add("Hospital 3620")
    End Sub

End Class