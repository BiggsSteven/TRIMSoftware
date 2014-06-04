Imports System.Data.SqlClient
Imports System.Configuration
Imports System
Imports System.IO

Public Class DatabaseClass
    Dim connectionStr As String
    Dim sqlCon As SqlConnection
    Public dt As New DataTable
    Dim sqlDa As SqlDataAdapter
    Dim sqlCmd As SqlCommand
    Dim sqlText As String


    Public Sub New()
        Dim server As String = ConfigurationManager.AppSettings("Server")
        Dim netLib As String = ConfigurationManager.AppSettings("NetLib")
        Dim database As String = ConfigurationManager.AppSettings("InitialCat")
        Dim User As String = ConfigurationManager.AppSettings("User")
        Dim Password As String = ConfigurationManager.AppSettings("Password")

        Dim SR As New StreamReader("C:\Constring.txt")
        Dim ConLine As String = SR.ReadToEnd()



        '"Server = 192.168.30.4\SQLEXPRESS,1433; Network Library = DBMSSOCN; Initial Catalog = ReceiverInstallation; User Id = sa; Password = Password123;"

        sqlCon = New SqlConnection(ConLine)
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
        'Builds Query String
        Dim values As String = String.Empty
        For counter As Integer = 0 To (field.Length() - 1)
            If counter = 0 Then
                values += "'" & field(counter) & "'"
            Else
                values += ",'" & field(counter) & "'"
            End If

        Next

        'Executes insert Query
        sqlText = "INSERT INTO " & table & "(" & fieldString & ") VALUES (" & values & ")"
        sqlCmd = New SqlCommand(sqlText, sqlCon)
        sqlCmd.ExecuteNonQuery()

    End Sub

    Public Sub RunDynamicUpdate(ByVal table As String, ByVal condition As String, ByVal EditFields() As String, ByRef field() As String)

        'Constructs the update
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
