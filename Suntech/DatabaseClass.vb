Imports System.Data.SqlClient
Imports System.Configuration

Public Class DatabaseClass
    Dim connectionStr As String
    Dim sqlCon As SqlConnection
    Dim dt As New DataTable
    Dim sqlDa As SqlDataAdapter
    Dim sqlCmd As SqlCommand
    Dim sqlText As String


    Public Sub New()
        Dim server As String = ConfigurationSettings.AppSettings("Server")
        Dim database As String = ConfigurationSettings.AppSettings("Database")
        Dim User As String = ConfigurationSettings.AppSettings("User")
        Dim Password As String = ConfigurationSettings.AppSettings("Password")

        connectionStr = "Server = " & server & "; Database = " & database & "; User Id= " & User & "; Password= " & Password & ";"
        sqlCon = New SqlConnection(connectionStr)
        sqlCon.Open()
    End Sub

    Public Sub RunDynamicSelect(ByVal table As String, ByVal fieldString As String, ByVal condition As String, ByRef field(,) As String)


        'build query with optional condition statement
        sqlText = "SELECT " & fieldString & " FROM " & table

        If condition <> String.Empty Then
            sqlText = sqlText & " WHERE " & condition
        End If


        'runs query and returns it to the program
        sqlDa = New SqlDataAdapter(sqlText, sqlCon)
        dt.Clear()
        sqlDa.Fill(dt)

        'passes data to a 2 diminsional array
        ReDim field(dt.Rows.Count() - 1, dt.Columns.Count() - 1)
        Dim rowCount As Integer = 0
        Do While (rowCount < dt.Rows.Count())
            Dim columnCount As Integer = 0
            Do While (columnCount < dt.Columns.Count())
                field(rowCount, columnCount) = dt.Rows(rowCount).Item(columnCount)
                columnCount += 1
            Loop
            rowCount += 1
        Loop


    End Sub

    Public Sub RunDynamicInsert(ByVal table As String, ByVal fieldString As String, ByRef field() As String)

        Dim values As String = String.Empty
        For counter As Integer = 0 To (field.Length() - 1)
            If counter = 0 Then
                values += "'" & field(counter) & "'"
            Else
                values += ",'" & field(counter) & "'"
            End If

        Next

        sqlText = "INSERT INTO " & table & "(" & fieldString & ") VALUES (" & values & ")"
        sqlCmd = New SqlCommand(sqlText, sqlCon)
        sqlCmd.ExecuteNonQuery()

    End Sub

    Public Sub RunDynamicUpdate(ByVal table As String, ByVal condition As String, ByVal EditFields() As String, ByRef field() As String)

        Dim counter As Integer = 0
        sqlText = "UPDATE " & table & " SET "
        While counter < EditFields.Length()
            If counter = 0 Then
                EditFields(counter) += " = '" & field(counter) & "'"
            Else
                EditFields(counter) = ", " & EditFields(counter) & " = '" & field(counter) & "'"
            End If
            sqlText += EditFields(counter)
            counter += 1
        End While


        If condition <> String.Empty Then
            sqlText = sqlText & " WHERE " & condition
        End If

        sqlCmd = New SqlCommand(sqlText, sqlCon)
        sqlCmd.ExecuteNonQuery()

    End Sub

End Class
