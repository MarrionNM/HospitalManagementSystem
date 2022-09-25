Imports System.Data.SqlClient
Public Class clsDbConnection

    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Public table As Data.DataTable
    Dim da As SqlDataAdapter
    Dim parms As New List(Of SqlParameter)

    Public ErrorMessage As String

    Public Sub OpenConnection()
        Try
            con = New SqlConnection
            con.ConnectionString = "Data Source=DESKTOP-3ACQSAS;Initial Catalog=Hospital_Management_System;Integrated Security=True"
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub ExecuteQuery(ByVal sqlQuery As String)

        Call OpenConnection()
        Try
            cmd = New SqlCommand(sqlQuery, con)             'sqlcommand

            parms.ForEach(Sub(p) cmd.Parameters.Add(p))    'add available parameters into command
            'For Each para As SqlParameter In parms
            '    cmd.Parameters.Add(para)
            'Next

            parms.Clear()                                   'clear parameters for new parameters

            table = New DataTable
            da = New SqlDataAdapter(cmd)                    'load command into adapter
            da.Fill(table)                                  'fill table into adapter

            ErrorMessage = ""
            con.Close()
        Catch ex As Exception
            ErrorMessage = ex.Message
        End Try

    End Sub

    Public Sub AddParameters(ByVal ParmName As String, ByVal Value As Object)
        Dim NewParm As New SqlParameter(ParmName, Value)    'Load parametername and its value into parameter
        parms.Add(NewParm)                                  'Add Parameter
    End Sub

End Class
