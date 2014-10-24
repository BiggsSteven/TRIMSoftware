Imports System.Configuration
Imports System.Data.SqlClient

Public Class FormHome
    Dim mRow As Integer = 0
    Dim newpage As Boolean = True
    Public Permissions As String

    Private Sub FrmHome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoginForm.ShowDialog()
        LoginForm.Dispose()
        ChkBoxPrint.Checked = True

        'Sub to Initialize the Technician list
        BuildTechList()
        RBStrucSearch.Checked = True

    End Sub

    Public Sub BuildTechList()
        Dim data As DatabaseClass = New DatabaseClass
        LstBoxTech.Items.Clear()

        'runs a select Query to retrieve list of Techs
        Dim table As String = ConfigurationManager.AppSettings("Tech")
        Dim fieldString As String = "[ID], [FirstName], [MiddleInitial], [LastName],[Active]"
        Dim TechArray(,) As String
        data.RunDynamicSelect(table, fieldString, "", TechArray)

        'Populate listbox with Technicians
        Dim counter As Integer = 0
        While (counter < TechArray.GetLength(0))
            'Only show active technicians
            If TechArray(counter, 4) = True Then
                LstBoxTech.Items.Add(TechArray(counter, 0) & "\" & TechArray(counter, 3) & ", " & TechArray(counter, 1) & " " & TechArray(counter, 2))
            End If
            counter += 1
        End While

        If LstBoxTech.Items.Count <> 0 Then
            LstBoxTech.SelectedItem = LstBoxTech.Items.Item(0)
        End If
    End Sub

    '--------------------------------------------------------------------------------------------------------------------

    'This section sets the fields for the different search types

    '--------------------------------------------------------------------------------------------------------------------

    Private Sub RBStrucSearch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBStrucSearch.CheckedChanged
        'This is the basic Tech + dateRange search
        If RBStrucSearch.Checked = True Then
            TxtBoxSearch.Enabled = False
            TxtBoxSearch.Text = String.Empty
            LstBoxTech.Enabled = True
            DTPkrFrom.Enabled = True
            DTPkrEnd.Enabled = True
            LblDtFrm.Enabled = True
            LblDtEnd.Enabled = True
            BtnPayTch.Enabled = True
        End If
    End Sub

    Private Sub RBAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBAll.CheckedChanged
        'This is the search that searches just by date range
        If RBAll.Checked = True Then
            TxtBoxSearch.Enabled = False
            TxtBoxSearch.Text = String.Empty
            LstBoxTech.Enabled = False
            DTPkrFrom.Enabled = True
            DTPkrEnd.Enabled = True
            LblDtFrm.Enabled = True
            LblDtEnd.Enabled = True
            BtnPayTch.Enabled = False
        End If
    End Sub

    Private Sub RBTextSearch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBTextSearch.CheckedChanged
        'This searches the whole log for the prescense of the entered string
        If RBTextSearch.Checked = True Then
            TxtBoxSearch.Enabled = True
            TxtBoxSearch.Select()
            LstBoxTech.Enabled = False
            DTPkrFrom.Enabled = False
            DTPkrEnd.Enabled = False
            LblDtFrm.Enabled = False
            LblDtEnd.Enabled = False
            BtnPayTch.Enabled = False
        End If
    End Sub


    '--------------------------------------------------------------------------------------------------------------------

    'This section runs a query based off the type selected

    '--------------------------------------------------------------------------------------------------------------------
    Private Sub BtnGtInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGtInfo.Click
        'Determines the type of Query being run
        If RBStrucSearch.Checked = True Then
            BuildStrucQuery()
        ElseIf RBAll.Checked = True Then
            BuildUnfilteredQuery()
        ElseIf RBTextSearch.Checked = True Then
            BuildTextQuery()
        End If
    End Sub

    Private Sub BuildStrucQuery()
        'This is the basic search type Tech + datarange
        Dim data As DatabaseClass = New DatabaseClass
        Dim tables() As String = {ConfigurationManager.AppSettings("Act"), ConfigurationManager.AppSettings("RecInv"), _
                         ConfigurationManager.AppSettings("RecTrans"), ConfigurationManager.AppSettings("Pay")}

        'get tech from selection
        Dim TechSelected As String = LstBoxTech.SelectedItem
        TechSelected = TechSelected.Substring(0, 10)

        'get date range from selection
        Dim bgnDate As String = DTPkrFrom.Value.Date
        Dim duration As TimeSpan = New System.TimeSpan(23, 59, 59)
        Dim endDate As String = DTPkrEnd.Value.Date.Add(duration)

        'declare Query pieces
        Dim fieldsString As String = "*"
        Dim LiveTable As Integer = TabCtrlDGV.SelectedIndex()
        Dim fields(,) As String
        Dim condition As String

        'Based off the table selected the Query is different.
        If LiveTable = 0 Then
            'Searches for the Activities of a tech and calculates the total
            condition = "[TECHID] = '" & TechSelected & "' AND [DATE] BETWEEN '" & bgnDate & "' AND '" & endDate & "'"
            data.RunDynamicSelect(tables(LiveTable), fieldsString, condition, fields)
            ActivitiesDataGridView.DataSource = data.dt 'resets the datagridview
            Dim rowsCount As Integer = 0
            Dim total As Double = 0
            While rowsCount < ActivitiesDataGridView.Rows.Count
                If ActivitiesDataGridView.Rows(rowsCount).Cells(6).Value = 0 Then
                    total += ActivitiesDataGridView.Rows(rowsCount).Cells(5).Value
                End If
                rowsCount += 1
            End While
            LblBalanceField.Text = Format(total, "c2")

        ElseIf LiveTable = 1 Then
            'Searches for Inventory of a technician
            condition = "[TECHID] = '" & TechSelected & "' AND ([DATEIN] BETWEEN '" & bgnDate & "' AND '" _
            & endDate & "' OR [DATEOUT] BETWEEN '" & bgnDate & "' AND '" & endDate & "')"
            data.RunDynamicSelect(tables(LiveTable), fieldsString, condition, fields)
            ReceiverInvDataGridView.DataSource = data.dt

        ElseIf LiveTable = 2 Then
            'Searches transfer logs that contain a technicians id
            condition = "([FROMTECHID] = '" & TechSelected & "' OR [TOTECHID] = '" & TechSelected _
                        & "') AND [DATE] BETWEEN '" & bgnDate & "' AND '" & endDate & "'"
            data.RunDynamicSelect(tables(LiveTable), fieldsString, condition, fields)
            ReceiverTransferDataGridView.DataSource = data.dt

        ElseIf LiveTable = 3 Then
            'Searches the payment log for a tech's id
            condition = "[TECHID] = '" & TechSelected & "' AND [DATE] BETWEEN '" & bgnDate & "' AND '" & endDate & "'"
            data.RunDynamicSelect(tables(LiveTable), fieldsString, condition, fields)
            PayStubsDataGridView.DataSource = data.dt
        End If


    End Sub

    Private Sub BuildUnfilteredQuery()
        'This is the search for all techs
        Dim data As DatabaseClass = New DatabaseClass
        Dim tables() As String = {ConfigurationManager.AppSettings("Act"), ConfigurationManager.AppSettings("RecInv"), _
                         ConfigurationManager.AppSettings("RecTrans"), ConfigurationManager.AppSettings("Pay")}

        'Sets the range
        Dim bgnDate As String = DTPkrFrom.Value.Date
        Dim duration As TimeSpan = New System.TimeSpan(23, 59, 59)
        Dim endDate As String = DTPkrEnd.Value.Date.Add(duration)

        'Declare Query Pieces
        Dim fieldsString As String = "*"
        Dim LiveTable As Integer = TabCtrlDGV.SelectedIndex()
        Dim fields(,) As String
        Dim condition As String

        '
        If LiveTable = 0 Then
            'Searches for the Activities of a tech and calculates the total
            condition = "[DATE] BETWEEN '" & bgnDate & "' AND '" & endDate & "'"
            data.RunDynamicSelect(tables(LiveTable), fieldsString, condition, fields)
            ActivitiesDataGridView.DataSource = data.dt
            Dim rowsCount As Integer = 0
            Dim total As Double = 0
            While rowsCount < ActivitiesDataGridView.Rows.Count
                If ActivitiesDataGridView.Rows(rowsCount).Cells(6).Value = 0 Then
                    total += ActivitiesDataGridView.Rows(rowsCount).Cells(5).Value
                End If
                rowsCount += 1
            End While
            LblBalanceField.Text = Format(total, "c2")

        ElseIf LiveTable = 1 Then
            'Searches for Inventory of all techs in that date range
            condition = "([DATEIN] BETWEEN '" & bgnDate & "' AND '" _
            & endDate & "' OR [DATEOUT] BETWEEN '" & bgnDate & "' AND '" & endDate & "')"
            data.RunDynamicSelect(tables(LiveTable), fieldsString, condition, fields)
            ReceiverInvDataGridView.DataSource = data.dt

        ElseIf LiveTable = 2 Then
            'Searches transfer logs for all in that date range
            condition = "[DATE] BETWEEN '" & bgnDate & "' AND '" & endDate & "'"
            data.RunDynamicSelect(tables(LiveTable), fieldsString, condition, fields)
            ReceiverTransferDataGridView.DataSource = data.dt

        ElseIf LiveTable = 3 Then
            'Searches the payment log for all in the date range
            condition = "[DATE] BETWEEN '" & bgnDate & "' AND '" & endDate & "'"
            data.RunDynamicSelect(tables(LiveTable), fieldsString, condition, fields)
            PayStubsDataGridView.DataSource = data.dt
        End If


    End Sub

    Private Sub BuildTextQuery()
        'This Query searches the table for the instance of a string in particular columns
        Dim data As DatabaseClass = New DatabaseClass
        Dim tables() As String = {ConfigurationManager.AppSettings("Act"), ConfigurationManager.AppSettings("RecInv"), _
                                 ConfigurationManager.AppSettings("RecTrans"), ConfigurationManager.AppSettings("Pay")}
        'set the searched for string
        Dim fieldsString As String = "*"
        Dim FieldInput As String = TxtBoxSearch.Text

        'set the parts of the string
        Dim LiveTable As Integer = TabCtrlDGV.SelectedIndex()
        Dim fields(,) As String
        Dim condition As String

        If LiveTable = 0 Then
            'Searches the Activity log for the appearance of a string
            condition = "[ID] = '" & FieldInput & "' OR [TECHID] = '" & FieldInput & "'"
            data.RunDynamicSelect(tables(LiveTable), fieldsString, condition, fields)
            ActivitiesDataGridView.DataSource = data.dt
            Dim rowsCount As Integer = 0
            Dim total As Double = 0
            While rowsCount < ActivitiesDataGridView.Rows.Count
                If ActivitiesDataGridView.Rows(rowsCount).Cells(6).Value = 0 Then
                    total += ActivitiesDataGridView.Rows(rowsCount).Cells(5).Value
                End If
                rowsCount += 1
            End While
            LblBalanceField.Text = Format(total, "c2")

        ElseIf LiveTable = 1 Then
            'Searches the Inventory for the appearance of a string
            condition = "[ACCESSCARD] = '" & FieldInput _
                        & "' OR [TECHID] = '" & FieldInput & "'"
            data.RunDynamicSelect(tables(LiveTable), fieldsString, condition, fields)
            ReceiverInvDataGridView.DataSource = data.dt

        ElseIf LiveTable = 2 Then
            'Searches the transfer log for the appearance of a string
            condition = "[ACCESSCARD] = '" & FieldInput & "' OR [FROMTECHID] = '" & FieldInput _
                        & "' OR [TOTECHID] = '" & FieldInput & "'"
            data.RunDynamicSelect(tables(LiveTable), fieldsString, condition, fields)
            ReceiverTransferDataGridView.DataSource = data.dt

        ElseIf LiveTable = 3 Then
            'Searches the payment log for the appearance of a string
            condition = "[CHECKNUMBER] = '" & FieldInput & "' OR [TECHID] = '" & FieldInput & "'"
            data.RunDynamicSelect(tables(LiveTable), fieldsString, condition, fields)
            PayStubsDataGridView.DataSource = data.dt
        End If

    End Sub

    Private Sub TxtBoxSearch_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TxtBoxSearch.KeyUp
        'Barcode Scanner is set to press "ENTER" after scanning
        'This will run after scanning
        If e.KeyCode = Keys.Enter Then
            BuildTextQuery()
        End If
    End Sub
    '--------------------------------------------------------------------------------------------------------------------

    'This section sets the menu actions

    '--------------------------------------------------------------------------------------------------------------------

    Private Sub TSMLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMLogin.Click
        LoginForm.ShowDialog()
        LoginForm.Dispose()
    End Sub

    Private Sub TSMItmActive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMItmActive.Click
        Dim ImportItem As ImportClass = New ImportClass
        ImportItem.selectFile(1, "Import Activity")
    End Sub

    Private Sub ReceiverToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReceiverToolStripMenuItem.Click
        TransferForm.ShowDialog()
    End Sub

    Private Sub TSMSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMSettings.Click
        FrmSettings.ShowDialog()
        FrmSettings.Dispose()
    End Sub

    '--------------------------------------------------------------------------------------------------------------------

    'This section handles the tech payment process

    '--------------------------------------------------------------------------------------------------------------------
    Private Sub BtnPayTch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPayTch.Click
        Dim data As DatabaseClass = New DatabaseClass
        Dim CheckNumber As String = txtboxChkNum.Text

        'If done write and has a checknumber and a non-zero balance
        If CheckNumber <> String.Empty And Format(CDbl(LblBalanceField.Text), "c2") <> Format(0, "c2") Then

            'Write transaction to logs
            Dim tables As String = ConfigurationManager.AppSettings("Pay")
            Dim fieldString As String = "[CHECKNUMBER], [DATE], [TECHID], [AMOUNT]"
            Dim fields() As String = {CheckNumber, DateTime.Now.Date, ActivitiesDataGridView.Rows(0).Cells(0).Value, CDbl(LblBalanceField.Text)}
            data.RunDynamicInsert(tables, fieldString, fields)

            'PrintDocument1.Print()
            If ChkBoxPrint.Checked = True Then
                PrintDocument1.DefaultPageSettings.Landscape = True
                PrintDialog1.Document = PrintDocument1

                Dim result As DialogResult = PrintDialog1.ShowDialog()
                If result = DialogResult.OK Then
                    PrintDocument1.Print()
                End If
            End If

            'setup for the update to the activities
            'This is where the paid gets checked
            tables = ConfigurationManager.AppSettings("Act")
            fieldString = "[ID],[DATE],[TECHID],[TYPE],[TOTAL],[TECHPAY],[PAID]"
            Dim condition As String
            'Calculate pay for Tech
            Dim rowsCount As Integer = 0
            Dim total As Double = 0


            While rowsCount < ActivitiesDataGridView.Rows.Count
                Dim editFields() As String = {"[PAID]"}
                Dim values() As String = {1}
                condition = " [ID] = '" & ActivitiesDataGridView.Rows(rowsCount).Cells(3).Value & "' " _
                    & "AND [TECHID] = '" & ActivitiesDataGridView.Rows(rowsCount).Cells(0).Value & "'"
                data.RunDynamicUpdate(tables, condition, editFields, values)
                ActivitiesDataGridView.Rows(rowsCount).Cells(6).Value = 1
                rowsCount += 1
            End While


            LblBalanceField.Text = Format(total, "c2")


        ElseIf Format(CDbl(LblBalanceField.Text), "c2") = Format(0, "c2") Then
            MessageBox.Show("The current balance is for" & Format(0, "c2") & Environment.NewLine _
                            & "Please Search for a Technician with live activities " & Environment.NewLine _
                            & " before attemping to settle the balance.")

        ElseIf CheckNumber = String.Empty Then
            MessageBox.Show("The check number field was left blank." & Environment.NewLine _
                            & "Please enter the check number into the textbox and try again.")

        End If

    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        With ActivitiesDataGridView


            Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
            fmt.LineAlignment = StringAlignment.Near

            Dim y As Single = e.MarginBounds.Top

            newpage = True
            'Cycle through rows in the data grid view rows
            Do While mRow < .RowCount
                Dim row As DataGridViewRow = .Rows(mRow)
                Dim x As Single = e.MarginBounds.Left
                Dim h As Single = 0

                'If the column has been paid do not include it in the pay stub
                If row.Cells.Item("Paid").Value = False Then

                    'Cycle through columns in each row skipping Total and the Paid Column
                    For Each cell As DataGridViewCell In row.Cells
                        If cell.ColumnIndex <> 4 And cell.ColumnIndex <> 6 Then
                            Dim rc As RectangleF = New RectangleF(x, y, cell.Size.Width, cell.Size.Height)
                            e.Graphics.DrawRectangle(Pens.Black, rc.Left, rc.Top, rc.Width, rc.Height)
                            If (newpage) Then
                                e.Graphics.DrawString(ActivitiesDataGridView.Columns(cell.ColumnIndex).HeaderText, .Font, Brushes.Black, rc, fmt)
                            Else
                                e.Graphics.DrawString(ActivitiesDataGridView.Rows(cell.RowIndex).Cells(cell.ColumnIndex).FormattedValue.ToString(), .Font, Brushes.Black, rc, fmt)
                            End If
                            x += rc.Width
                            h = Math.Max(h, rc.Height)
                        End If
                    Next
                End If
                If mRow = 0 And newpage = True Then
                    mRow -= 1
                End If
                newpage = False
                y += h
                mRow += 1
                If y + h > e.MarginBounds.Bottom Then
                    e.HasMorePages = True
                    mRow -= 1
                    newpage = True
                    Exit Sub
                End If
            Loop
            mRow = 0
            Dim Bottom As String = Environment.NewLine & "Technician:   " & ActivitiesDataGridView.Rows(0).Cells(0).FormattedValue.ToString() _
                                    & "                                      Total: " & LblBalanceField.Text

            Dim rcp As RectangleF = New RectangleF(e.MarginBounds.Left, y, ActivitiesDataGridView.Size.Width(), ActivitiesDataGridView.Rows(0).Cells(0).Size.Height * 3)
            e.Graphics.DrawString(Bottom, .Font, Brushes.Black, rcp, fmt)
        End With
    End Sub

    Private Sub ChkBoxPrint_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkBoxPrint.CheckedChanged
        If ChkBoxPrint.Checked = False Then
            MessageBox.Show("Are you sure you do not want to print an invoice for this payment?" & Environment.NewLine() _
                            & "This will be your only chance to print one.")
        End If
    End Sub
End Class
