Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Environment
Public Class TransferForm
    Private Sub TransferForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CmboFrom.Text = String.Empty
        TxtBoxSerial.Text = String.Empty
        CmboTo.Text = String.Empty
        FillTechCmboBox()

        TxtBoxSerial.Select()
    End Sub

    Private Sub FillTechCmboBox()
        Dim data As DatabaseClass = New DatabaseClass
        CmboFrom.Items.Clear()
        CmboTo.Items.Clear()

        'runs a select Query to retrieve list of Techs
        Dim table As String = ConfigurationSettings.AppSettings("Tech")
        Dim fieldString As String = "[ID], [NAME]"
        Dim TechArray(,) As String
        data.RunDynamicSelect(table, fieldString, "", TechArray)

        'Populate listbox with Technicians
        Dim counter As Integer = 0
        While (counter < TechArray.GetLength(0))
            CmboFrom.Items.Add(TechArray(counter, 0) & "\" & TechArray(counter, 1))
            CmboTo.Items.Add(TechArray(counter, 0) & "\" & TechArray(counter, 1))
            counter += 1
        End While
    End Sub

    Private Sub TxtBoxSerial_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TxtBoxSerial.KeyUp
        'Barcode Scanner is set to press "ENTER" after scanning
        'This will run after scanning
        If e.KeyCode = Keys.Enter Then
            Dim data As DatabaseClass = New DatabaseClass
            Dim CodeScanned As String = TxtBoxSerial.Text

            'Retrieve Tech's name and number
            '_____________________________________________________________________________________________________
            '
            Dim fieldsString As String = ConfigurationSettings.AppSettings("RecInv") & ".[SERIALNUM]" _
                                        & " , " & ConfigurationSettings.AppSettings("RecInv") & ".[TECHID] " _
                                        & " , " & ConfigurationSettings.AppSettings("Tech") & ".[NAME] "

            Dim tables As String = ConfigurationSettings.AppSettings("RecInv") _
                        & " INNER JOIN " & ConfigurationSettings.AppSettings("Tech") _
                        & " ON " & ConfigurationSettings.AppSettings("RecInv") & ".[TECHID]=" _
                        & ConfigurationSettings.AppSettings("Tech") & ".[ID]"

            Dim condition As String = ConfigurationSettings.AppSettings("RecInv") & ".[SERIALNUM] = '" & CodeScanned & "'"
            Dim fields(,) As String
            data.RunDynamicSelect(tables, fieldsString, condition, fields)

            '_____________________________________________________________________________________________________

            If fields.Length <> 0 Then
                CmboFrom.SelectedItem = (fields(0, 1) & "\" & fields(0, 2))
            End If

        End If
    End Sub

    Private Sub BtnTransfer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTransfer.Click
        Dim data As DatabaseClass = New DatabaseClass
        Dim techFrom As String = CmboFrom.SelectedItem.substring(0, 10)
        Dim techFromName As String = CmboFrom.SelectedItem.substring(11)

        Dim serial As String = TxtBoxSerial.Text
        Dim techTo As String = CmboTo.SelectedItem.Substring(0, 10)
        Dim techToName As String = CmboTo.SelectedItem.Substring(11)

        'Write update to RecInv table
        'Write Insert to REcTransfer table










        LblOutput.Text = "Receiver: " & serial & Environment.NewLine _
                        & "Has Been moved from " & techFromName & Environment.NewLine _
                        & "to " & techToName & " Successfully."


        CmboFrom.Text = String.Empty
        TxtBoxSerial.Text = String.Empty

    End Sub

End Class