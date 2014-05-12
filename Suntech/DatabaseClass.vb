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

    Public Sub RetrieveTechList(ByRef TechArray() As String)

        sqlText = "SELECT COUNT(*) From " & ConfigurationSettings.AppSettings("Tech")
        sqlCmd = New SqlCommand(sqlText, sqlCon)
        Dim rowCount As Integer = sqlCmd.ExecuteScalar()
        ReDim TechArray(rowCount - 1)


        Dim Query As String = "SELECT [ID],[Name] FROM [ReceiverInstallation].[dbo].[Technicians]"

        sqlText = "SELECT [ID], [NAME] FROM " & ConfigurationSettings.AppSettings("Tech")
        sqlDa = New SqlDataAdapter(sqlText, sqlCon)
        dt.Clear()
        sqlDa.Fill(dt)

        Do While (rowCount > 0)
            TechArray(rowCount - 1) = dt.Rows(rowCount - 1).Item(0) & "  \  " & dt.Rows(rowCount - 1).Item(1)
            rowCount -= 1
        Loop





    End Sub

End Class
