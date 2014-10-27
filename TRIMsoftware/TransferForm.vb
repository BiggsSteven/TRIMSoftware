Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Environment
Public Class TransferForm

    Dim Action(,) As String

    Private Sub TransferForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CmboTo.Text = String.Empty
        CmboFrom.Text = String.Empty
        TxtBoxAccessCard.Text = String.Empty
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
        Dim fieldString As String = "[ID], [FirstName], [MiddleInitial], [LastName],[Active]"
        Dim TechArray(,) As String
        data.RunDynamicSelect(table, fieldString, "", TechArray)

        'These are added as defaults
        CmboFrom.Items.Add("--------\------,----- -")
        CmboTo.Items.Add("--------\------,----- -")

        'Loop till all techs are added
        Dim counter As Integer = 0
        While (counter < TechArray.GetLength(0))
            CmboFrom.Items.Add(TechArray(counter, 0) & "\" & TechArray(counter, 3) & ", " & TechArray(counter, 1) & " " & TechArray(counter, 2))
            If TechArray(counter, 4) = True Then
                CmboTo.Items.Add(TechArray(counter, 0) & "\" & TechArray(counter, 3) & ", " & TechArray(counter, 1) & " " & TechArray(counter, 2))
            End If
            counter += 1
        End While

        'Set the starting select
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
            If CmboTo.SelectedIndex <> 0 And TxtBoxAccessCard.Text <> String.Empty Then
                Dim data As DatabaseClass = New DatabaseClass
                Dim CodeScanned As String = TxtBoxAccessCard.Text

                'Retrieve the Tech's name and ID that currently has the Receiver
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

                '---------------------------------------------------------------------------------------
                'If the accessCard is found then transfer it to the appropriate person
                'else add it to the receiver Inventory
                Dim last As Integer = ChkListTransfers.Items.Count
                If fields.Length <> 0 Then
                    'AccessCard is found
                    Dim placeholder As Integer = 1
                    Dim counter As Integer = 0
                    'Cycle through each item in the combobox, compare the retrieved owner to the text of that index before the \
                    For Each item In CmboFrom.Items
                        Dim tempBit() As String = item.split("\")
                        If tempBit(0) = fields(0, 1) Then
                            placeholder = counter
                        End If
                        counter += 1
                    Next
                    CmboFrom.SelectedIndex() = placeholder

                    'Add an item to the listbox and the array with tag Move
                    ChkListTransfers.Items.Add("Mov: " & TxtBoxAccessCard.Text & " from " & CmboFrom.SelectedItem & " to " & CmboTo.SelectedItem)
                    ChkListTransfers.SetItemChecked(ChkListTransfers.Items.Count - 1, True)
                    ReDim Preserve Action(3, last)
                    Action(0, last) = "Mov"
                    Action(1, last) = TxtBoxAccessCard.Text
                    Action(2, last) = CmboFrom.SelectedItem()
                    Action(3, last) = CmboTo.SelectedItem()


                Else
                    'Add an item to the listbox and the array with tag Add
                    CmboFrom.SelectedIndex = 1
                    ChkListTransfers.Items.Add("Add: " & TxtBoxAccessCard.Text & " from " & CmboFrom.SelectedItem & " to " & CmboTo.SelectedItem)
                    ChkListTransfers.SetItemChecked(ChkListTransfers.Items.Count - 1, True)
                    ReDim Preserve Action(3, last)
                    Action(0, last) = "Add"
                    Action(1, last) = TxtBoxAccessCard.Text
                    Action(2, last) = CmboFrom.SelectedItem()
                    Action(3, last) = CmboTo.SelectedItem()
                End If

                'reset the accessCard space
                TxtBoxAccessCard.Text = String.Empty
                TxtBoxAccessCard.Select()
                BtnTransfer.Enabled = True
            Else
                MessageBox.Show("Please check each field and ensure that each is correct.")
            End If
        End If
    End Sub

    Private Sub makeTransfer()
        Dim data As DatabaseClass = New DatabaseClass
        Dim table As String
        Dim fieldsString As String
        Dim Type As String = String.Empty
        Dim index As Integer = 0

        'Cycle through listbox
        For Each index In ChkListTransfers.CheckedIndices

            'Write new reciever into the inventory under Distributors name
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
        BtnTransfer.Enabled = False

    End Sub

    Private Sub CmboTo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmboTo.SelectedIndexChanged

        If CmboTo.SelectedIndex <> 0 Then
            TxtBoxAccessCard.Enabled = True
            ChkListTransfers.Enabled = True
        Else
            TxtBoxAccessCard.Enabled = False
            ChkListTransfers.Enabled = False
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