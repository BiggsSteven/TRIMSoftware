Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Environment
Public Class TransferForm

    Dim Action(,) As String

    Private Sub TransferForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CmboFrom.Text = String.Empty
        TxtBoxAccessCard.Text = String.Empty
        CmboTo.Text = String.Empty
        FillTechCmboBox()
        TxtBoxAccessCard.Enabled = False
        ReDim Action(3, 0)
    End Sub

    Private Sub FillTechCmboBox()
        CmboFrom.Items.Clear()
        CmboTo.Items.Clear()
        Dim data As DatabaseClass = New DatabaseClass
        'runs a select Query to retrieve list of Techs
        Dim table As String = ConfigurationManager.AppSettings("Tech")
        Dim fieldString As String = "[ID], [FirstName], [MiddleInitial], [LastName]"
        Dim TechArray(,) As String
        data.RunDynamicSelect(table, fieldString, "", TechArray)


        CmboFrom.Items.Add("--------\------,----- -")
        CmboTo.Items.Add("--------\------,----- -")

        'Populate listbox with Technicians
        Dim counter As Integer = 0
        While (counter < TechArray.GetLength(0))
            CmboFrom.Items.Add(TechArray(counter, 0) & "\" & TechArray(counter, 3) & ", " & TechArray(counter, 1) & " " & TechArray(counter, 2))
            CmboTo.Items.Add(TechArray(counter, 0) & "\" & TechArray(counter, 3) & ", " & TechArray(counter, 1) & " " & TechArray(counter, 2))

            counter += 1
        End While

        If CmboFrom.Items.Count <> 0 Then
            CmboFrom.SelectedItem = CmboFrom.Items.Item(0)
        End If
        If CmboTo.Items.Count <> 0 Then
            CmboTo.SelectedItem = CmboTo.Items.Item(0)
        End If
    End Sub

    Private Sub TxtBoxAccess_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TxtBoxAccessCard.KeyUp
        'Barcode Scanner is set to press "ENTER" after scanning
        'This will run after scanning
        If e.KeyCode = Keys.Enter Then
            Dim data As DatabaseClass = New DatabaseClass
            Dim CodeScanned As String = TxtBoxAccessCard.Text

            'Retrieve the Tech's name and number that currently has the Receiver
            '
            '_____________________________________________________________________________________________________
            '
            Dim tables As String = ConfigurationManager.AppSettings("RecInv") _
                        & " INNER JOIN " & ConfigurationManager.AppSettings("Tech") _
                        & " ON " & ConfigurationManager.AppSettings("RecInv") & ".[TECHID]=" _
                        & ConfigurationManager.AppSettings("Tech") & ".[ID]"

            Dim fieldsString As String = ConfigurationManager.AppSettings("RecInv") & ".[ACCESSCARD]" _
                            & " , " & ConfigurationManager.AppSettings("RecInv") & ".[TECHID] " _
                            & " , " & ConfigurationManager.AppSettings("Tech") & ".[LastName] " _
                            & " , " & ConfigurationManager.AppSettings("Tech") & ".[FirstName] " _
                            & " , " & ConfigurationManager.AppSettings("Tech") & ".[MiddleInitial] "




            Dim condition As String = ConfigurationManager.AppSettings("RecInv") & ".[ACCESSCARD] = '" & CodeScanned & "'"
            Dim fields(,) As String
            data.RunDynamicSelect(tables, fieldsString, condition, fields)

            '_____________________________________________________________________________________________________

            'If the accessCard is found then transfer it to the appropriate person
            'else add it to the receiver Inventory
            Dim last As Integer = ChkListTransfers.Items.Count
            If fields.Length <> 0 Then
                Dim placeholder As Integer = 1
                Dim counter As Integer = 0
                For Each item In CmboFrom.Items
                    Dim tempBit() As String = item.split("\")
                    If tempBit(0) = fields(0, 1) Then
                        placeholder = counter
                    End If
                    counter += 1
                Next


                CmboFrom.SelectedIndex() = placeholder
                ChkListTransfers.Items.Add("Mov: " & TxtBoxAccessCard.Text & " from " & CmboFrom.SelectedItem & " to " & CmboTo.SelectedItem)
                ChkListTransfers.SetItemChecked(ChkListTransfers.Items.Count - 1, True)
                ReDim Preserve Action(3, last)
                Action(0, last) = "Mov"
                Action(1, last) = TxtBoxAccessCard.Text
                Action(2, last) = CmboFrom.SelectedItem()
                Action(3, last) = CmboTo.SelectedItem()


            Else
                CmboFrom.SelectedIndex = 1
                ChkListTransfers.Items.Add("Add: " & TxtBoxAccessCard.Text & " from " & CmboFrom.SelectedItem & " to " & CmboTo.SelectedItem)
                ChkListTransfers.SetItemChecked(ChkListTransfers.Items.Count - 1, True)
                ReDim Preserve Action(3, last)
                Action(0, last) = "Add"
                Action(1, last) = TxtBoxAccessCard.Text
                Action(2, last) = CmboFrom.SelectedItem()
                Action(3, last) = CmboTo.SelectedItem()
            End If

            TxtBoxAccessCard.Text = String.Empty
            TxtBoxAccessCard.Select()
        End If
    End Sub

    Private Sub addRec()
        Dim data As DatabaseClass = New DatabaseClass
        Dim table As String = ConfigurationManager.AppSettings("RecInv")
        Dim fieldsString As String = "[ACCESSCARD],[DATEIN],[DATEOUT],[FILEIMPORTED]"
        Dim Values() As String = {TxtBoxAccessCard.Text, DateTime.Now, DateAdd(DateInterval.Day, 13, CDate(DateTime.Now)), "SCANNED"}
        data.RunDynamicInsert(table, fieldsString, Values)
    End Sub

    Private Sub makeTransfer()
        Dim data As DatabaseClass = New DatabaseClass
        Dim table As String
        Dim fieldsString As String


        Dim Type As String = String.Empty
        Dim index As Integer = 0
        For Each index In ChkListTransfers.CheckedIndices
            'Write Insert of receiver
            If Action(0, index) = "Add" Then
                table = ConfigurationManager.AppSettings("RecInv")
                fieldsString = "[ACCESSCARD],[TECHID],[DATEIN],[DATEOUT],[FILEIMPORTED]"
                Dim Values() As String = {Action(1, index), Action(2, index).Substring(0, 10), DateTime.Now, DateAdd(DateInterval.Day, 13, CDate(DateTime.Now)), "SCANNED"}
                data.RunDynamicInsert(table, fieldsString, Values)
            End If

            'Write Update of techid
            table = ConfigurationManager.AppSettings("RecInv")
            Dim setFields() As String = {"[TECHID]"}
            Dim fields() As String = {Action(3, index).Substring(0, 10)}
            Dim Condition As String = "[ACCESSCARD] = '" & Action(1, index) & "'"
            data.RunDynamicUpdate(table, Condition, setFields, fields)

            'Write Insert to RecTransfer table
            table = ConfigurationManager.AppSettings("RecTrans")
            fieldsString = "[ACCESSCARD],[FROMTECHID], [TOTECHID], [DATE]"
            Dim ValueList() As String = {Action(1, index), Action(2, index).Substring(0, 10), Action(3, index).Substring(0, 10), DateTime.Now}
            data.RunDynamicInsert(table, fieldsString, ValueList)
        Next
    End Sub

    Private Sub CmboTo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmboTo.SelectedIndexChanged
        If CmboTo.SelectedIndex <> 0 Then
            TxtBoxAccessCard.Enabled = True
            ChkListTransfers.Enabled = True
            BtnTransfer.Enabled = True
        Else
            TxtBoxAccessCard.Enabled = False
            ChkListTransfers.Enabled = False
            BtnTransfer.Enabled = False
        End If
    End Sub

    Private Sub BtnTransfer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTransfer.Click
        makeTransfer()
        ChkListTransfers.Items.Clear()
        ReDim Action(3, 0)
        MessageBox.Show("All actions where processed successfully")

    End Sub

    Private Sub ChkListTransfers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkListTransfers.SelectedIndexChanged
        BtnTransfer.Enabled = True
    End Sub
End Class