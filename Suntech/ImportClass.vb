Imports System.IO

Public Class ImportClass

    Public inLine As String

    Public Sub selectFile(ByVal TypeSelect As Integer)
        Dim selectedFile As String = String.Empty
        If FormHome.OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            selectedFile = FormHome.OpenFileDialog1.FileName
        End If

        Select Case TypeSelect
            Case 0
                importTech(selectedFile)
            Case 1
                importAct(selectedFile)
            Case 2
                importRec(selectedFile)
            Case 3
                importRecRet(selectedFile)
        End Select


    End Sub

    Private Sub importTech(ByVal selectedFile As String)

        Dim lineArray() As String
        Dim MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(selectedFile)
        MyReader.TextFieldType = FileIO.FieldType.Delimited
        MyReader.SetDelimiters(",")


        While Not MyReader.EndOfData
            lineArray = MyReader.ReadFields()

            'call function to add to database

        End While


    End Sub
    Private Sub importAct(ByVal selectedFile As String)

        Dim lineArray() As String
        Dim MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(selectedFile)
        MyReader.TextFieldType = FileIO.FieldType.Delimited
        MyReader.SetDelimiters(",")


        While Not MyReader.EndOfData
            lineArray = MyReader.ReadFields()

            'call function to add to database

        End While

    End Sub
    Private Sub importRec(ByVal selectedFile As String)

        Dim lineArray() As String
        Dim MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(selectedFile)
        MyReader.TextFieldType = FileIO.FieldType.Delimited
        MyReader.SetDelimiters(",")


        While Not MyReader.EndOfData
            lineArray = MyReader.ReadFields()

            'call function to add to database

        End While

    End Sub
    Private Sub importRecRet(ByVal selectedFile As String)


        Dim lineArray() As String
        Dim MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(selectedFile)
        MyReader.TextFieldType = FileIO.FieldType.Delimited
        MyReader.SetDelimiters(",")


        While Not MyReader.EndOfData
            lineArray = MyReader.ReadFields()

        End While

    End Sub

End Class
