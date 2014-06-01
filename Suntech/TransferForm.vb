Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Environment
Public Class TransferForm
    Private Sub TransferForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CmboFrom.Text = String.Empty
        TxtBoxAccessCard.Text = String.Empty
        CmboTo.Text = String.Empty
        FillTechCmboBox()
        TxtBoxAccessCard.Enabled = False
    End Sub

    Private Sub FillTechCmboBox()
        Dim data As DatabaseClass = New DatabaseClass
        CmboFrom.Items.Clear()
        CmboTo.Items.Clear()

        'runs a select Query to retrieve list of Techs
        Dim table As String = ConfigurationManager.AppSettings("Tech")
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

    Private Sub TxtBoxSerial_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TxtBoxAccessCard.KeyUp
        'Barcode Scanner is set to press "ENTER" after scanning
        'This will run after scanning
        If e.KeyCode = Keys.Enter Then
            Dim data As DatabaseClass = New DatabaseClass
            Dim CodeScanned As String = TxtBoxAccessCard.Text

            'Retrieve Tech's name and number
            '_____________________________________________________________________________________________________
            '
            Dim fieldsString As String = ConfigurationManager.AppSettings("RecInv") & ".[ACCESSCARD]" _
                                        & " , " & ConfigurationManager.AppSettings("RecInv") & ".[TECHID] " _
                                        & " , " & ConfigurationManager.AppSettings("Tech") & ".[NAME] "

            Dim tables As String = ConfigurationManager.AppSettings("RecInv") _
                        & " INNER JOIN " & ConfigurationManager.AppSettings("Tech") _
                        & " ON " & ConfigurationManager.AppSettings("RecInv") & ".[TECHID]=" _
                        & ConfigurationManager.AppSettings("Tech") & ".[ID]"

            Dim condition As String = ConfigurationManager.AppSettings("RecInv") & ".[ACCESSCARD] = '" & CodeScanned & "'"
            Dim fields(,) As String
            data.RunDynamicSelect(tables, fieldsString, condition, fields)

            '_____________________________________________________________________________________________________

            If fields.Length <> 0 Then
                CmboFrom.SelectedItem = (fields(0, 1) & "\" & fields(0, 2))
            End If

            makeTransfer()
            TxtBoxAccessCard.Text = String.Empty
            TxtBoxAccessCard.Select()

        End If
    End Sub

    Private Sub makeTransfer()
        Dim data As DatabaseClass = New DatabaseClass
        Dim techFrom As String = CmboFrom.SelectedItem.substring(0, 10)
        Dim techFromName As String = CmboFrom.SelectedItem.substring(11)

        Dim accessCard As String = TxtBoxAccessCard.Text
        Dim techTo As String = CmboTo.SelectedItem.Substring(0, 10)
        Dim techToName As String = CmboTo.SelectedItem.Substring(11)

        Dim table As String = ConfigurationManager.AppSettings("RecInv")
        Dim fieldsString As String = "[ACCESSCARD]"
        Dim condition As String = " [ACCESSCARD] = '" & accessCard & "'"
        Dim Fieldreturn(,) As String

        data.RunDynamicSelect(table, fieldsString, condition, Fieldreturn)
        If Fieldreturn.Length <> 0 Then

            'Write update to RecInv table
            Dim setFields() As String = {"[TECHID]"}
            Dim fields() As String = {techTo}
            data.RunDynamicUpdate(table, condition, setFields, fields)

            'Write Insert to RecTransfer table
            table = ConfigurationManager.AppSettings("RecTrans")
            fieldsString = "[ACCESSCARD],[FROMTECHID], [TOTECHID], [DATE]"
            Dim Values() As String = {accessCard, techFrom, techTo, DateTime.Now.Date}
            data.RunDynamicInsert(table, fieldsString, Values)

            LblOutput.Text = "Receiver: " & accessCard & Environment.NewLine _
                            & "Has Been moved from " & techFromName & Environment.NewLine _
                            & "to " & techToName & " Successfully."

        Else
            LblOutput.Text = "Receiver: " & accessCard & " was not found. Transfer cancelled."

        End If

        CmboFrom.Text = String.Empty
        TxtBoxAccessCard.Text = String.Empty



    End Sub

    Private Sub CmboTo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmboTo.SelectedIndexChanged
        If CmboTo.SelectedItem <> String.Empty Then
            TxtBoxAccessCard.Enabled = True
            TxtBoxAccessCard.Select()
        End If

    End Sub

    Private Sub BtnTransfer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTransfer.Click
        makeTransfer()
    End Sub
End Class