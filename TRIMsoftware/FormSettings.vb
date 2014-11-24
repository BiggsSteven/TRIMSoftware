﻿Imports System.Configuration
Imports System.Data.SqlClient

Public Class FrmSettings

    Dim genFlag As Boolean = False
    Dim TechFlag As Boolean = False
    Dim passFlag As Boolean = False


    Private Sub FrmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'General Tab
        fillSettings()

        If ChkboxSvcPay.Checked Then
            TxtBoxSvcPay.Enabled = True
        Else
            TxtBoxSvcPay.Enabled = False
        End If

        'Add/Edit Tab
        CmboBoxTechs.Enabled = False
        RBAddTech.Checked = True

        'Password Change


    End Sub

    Private Sub BtnGenSave_Click(sender As Object, e As EventArgs) Handles BtnGenSave.Click
        If genFlag = True Then
            GeneralSave()
        End If
        If TxtboxID.Text <> String.Empty Then
            SaveEditTech()
        End If
        If passFlag = True Then
            PassOK()
        End If
        Me.Close()
    End Sub

    Private Sub BtnCncl_Click(sender As Object, e As EventArgs) Handles BtnGenCncl.Click
        FormHome.BuildTechList()
        Me.Close()
    End Sub

    '--------------------------------------------------------------------------------------------------------------------

    'General settings Section

    '--------------------------------------------------------------------------------------------------------------------

    Public Sub fillSettings()
        'Retrieve data from Options Database
        Dim data As DatabaseClass = New DatabaseClass
        Dim table As String = ConfigurationManager.AppSettings("Options")
        Dim fieldString As String = "[UseStaticSrvc],[SrvcPay]"
        Dim condition As String = ""
        Dim fields(,) As String
        data.RunDynamicSelect(table, fieldString, condition, fields)

        'Fill Options with values from database
        If fields.Length > 0 Then
            ChkboxSvcPay.Checked = fields(0, 0)
            TxtBoxSvcPay.Text = FormatCurrency(Convert.ToDouble(fields(0, 1)), 2)
        End If

        'Retrieve Distributor and Company from 
        table = ConfigurationManager.AppSettings("Tech")
        fieldString = "[ID],[LastName]"
        ReDim fields(0, 0)
        condition = "[ID] = '0000000001' or [ID] = '0000000002' "
        data.RunDynamicSelect(table, fieldString, condition, fields)

        If fields.Length > 1 Then
            If fields(0, 0) = "0000000001" Then
                TxtboxDistro.Text = fields(0, 1)
                TxtboxComp.Text = fields(1, 1)
            ElseIf fields(0, 0) = "0000000002" Then
                TxtboxComp.Text = fields(0, 1)
                TxtboxDistro.Text = fields(1, 1)
            End If
        End If
    End Sub

    Private Sub TxtboxDistro_TextChanged(sender As Object, e As EventArgs) Handles TxtboxDistro.TextChanged
        genFlag = True
    End Sub

    Private Sub TxtboxComp_TextChanged(sender As Object, e As EventArgs) Handles TxtboxComp.TextChanged
        genFlag = True
    End Sub

    Private Sub ChkboxSvcPay_CheckedChanged(sender As Object, e As EventArgs) Handles ChkboxSvcPay.CheckedChanged
        If ChkboxSvcPay.Checked Then
            TxtBoxSvcPay.Enabled = True
        Else
            TxtBoxSvcPay.Enabled = False
        End If
        genFlag = True
    End Sub

    Private Sub TxtBoxSvcPay_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxSvcPay.TextChanged
        genFlag = True
    End Sub

    Private Sub TxtBoxSvcPay_LostFocus(sender As Object, e As EventArgs) Handles TxtBoxSvcPay.LostFocus
        TxtBoxSvcPay.Text = FormatCurrency(TxtBoxSvcPay.Text)
    End Sub

    Public Sub GeneralSave()
        'Saves to the Options table
        Dim data As DatabaseClass = New DatabaseClass
        Dim table As String = ConfigurationManager.AppSettings("Options")
        Dim condition As String = ""
        Dim editfields() As String = {"[UseStaticSrvc]", "[SrvcPay]"}
        Dim svcPay As Double = TxtBoxSvcPay.Text
        Dim values() As String = {ChkboxSvcPay.Checked, svcPay}
        data.RunDynamicUpdate(table, condition, editfields, values)

        'saves to the Tech Table for Distro
        table = ConfigurationManager.AppSettings("Tech")
        condition = "[ID] = '0000000001' "
        ReDim editfields(0)
        editfields(0) = "[LastName]"
        ReDim values(0)
        values(0) = TxtboxDistro.Text
        data.RunDynamicUpdate(table, condition, editfields, values)

        'saves to the Tech Table for Company
        condition = "[ID] = '0000000002' "
        ReDim editfields(0)
        editfields(0) = "[LastName]"
        ReDim values(0)
        values(0) = TxtboxComp.Text
        data.RunDynamicUpdate(table, condition, editfields, values)

        FormHome.BuildTechList()
    End Sub

    '--------------------------------------------------------------------------------------------------------------------

    'Add/Edit Tech Section

    '--------------------------------------------------------------------------------------------------------------------

    Private Sub RBAddTech_CheckedChanged(sender As Object, e As EventArgs) Handles RBAddTech.CheckedChanged
        CmboBoxTechs.Enabled = False
        BtnPrevTech.Enabled = False
        BtnNextTech.Enabled = False
        BtnSaveTech.Enabled = True
        clearTxtBoxes()
    End Sub

    Private Sub RBEditTech_CheckedChanged(sender As Object, e As EventArgs) Handles RBEditTech.CheckedChanged
        CmboBoxTechs.Enabled = True
        BtnPrevTech.Enabled = True
        BtnNextTech.Enabled = True
        UpdateTechList()
    End Sub

    Private Sub UpdateTechList()
        If CmboBoxTechs.Enabled = True Then
            CmboBoxTechs.Enabled = True

            CmboBoxTechs.Items.Clear()

            Dim data As DatabaseClass = New DatabaseClass
            'runs a select Query to retrieve list of Techs
            Dim table As String = ConfigurationManager.AppSettings("Tech")
            Dim fieldString As String = "[ID], [FirstName], [MiddleInitial], [LastName],[Active]"
            Dim TechArray(,) As String
            data.RunDynamicSelect(table, fieldString, "", TechArray)


            CmboBoxTechs.Items.Add("--------\------,----- -")


            'Populate listbox with Technicians
            Dim counter As Integer = 0
            While (counter < TechArray.GetLength(0))
                'If (active and not 01 nor 02) or (showinactive and not 01 nor 02)
                If (TechArray(counter, 4) = True Or CBShowInactive.Checked = True) And TechArray(counter, 0) <> "0000000001" And TechArray(counter, 0) <> "0000000002" Then
                    CmboBoxTechs.Items.Add(TechArray(counter, 0) & "\" & TechArray(counter, 3) & ", " & TechArray(counter, 1) & " " & TechArray(counter, 2))
                End If
                counter += 1
            End While

            If CmboBoxTechs.Items.Count <> 0 Then
                CmboBoxTechs.SelectedItem = CmboBoxTechs.Items.Item(0)
            End If
        End If
    End Sub

    Private Sub clearTxtBoxes()
        For Each element As Control In PnlEditTech.Controls
            If TypeOf element Is TextBox Then
                element.Enabled = True
                element.Text = String.Empty
            End If
            CBActiveSet.Enabled = True
            CBActiveSet.Checked = False
        Next
    End Sub

    Private Sub CmboBoxTechs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmboBoxTechs.SelectedIndexChanged
        'Retrieve selection from database
        Dim TechSelected As String = CmboBoxTechs.SelectedItem
        TechSelected = TechSelected.Substring(0, TechSelected.IndexOf("\"))
        Dim data As DatabaseClass = New DatabaseClass
        Dim table As String = ConfigurationManager.AppSettings("Tech")
        Dim fieldString As String = "[ID], [FirstName], [MiddleInitial], [LastName], [SSN], [FedIDNum], [HomeAddress], [PhoneNum], [EmailAdd], [Location], [PayPercentage],[Active]"
        Dim condition As String = "[ID] = '" & TechSelected & "' "
        Dim TechArray(,) As String
        data.RunDynamicSelect(table, fieldString, condition, TechArray)

        'If the selection is Start, the Distributor, or the Company they should not be editable
        'Else fill the fields with the appropriate data
        If TechSelected = "----------" Then
            For Each element As Control In PnlEditTech.Controls
                If TypeOf element Is TextBox Then
                    element.Text = String.Empty
                    element.Enabled = False
                End If
                CBActiveSet.Checked = False
                CBActiveSet.Enabled = False
            Next
        ElseIf TechArray.Length <> 0 Then
            For Each element As Control In PnlEditTech.Controls
                If TypeOf element Is TextBox Then
                    element.Enabled = True
                End If
                CBActiveSet.Enabled = True
            Next
            TxtboxID.Text = TechArray(0, 0)
            txtBoxFirst.Text = TechArray(0, 1)
            TxtBoxMI.Text = TechArray(0, 2)
            TxtBoxLast.Text = TechArray(0, 3)
            TxtBoxSSN.Text = TechArray(0, 4)
            TxtBoxFedID.Text = TechArray(0, 5)
            TxtboxAddr.Text = TechArray(0, 6)
            TxtboxPhone.Text = TechArray(0, 7)
            TxtboxEmail.Text = TechArray(0, 8)
            TxtboxLoc.Text = TechArray(0, 9)
            TxtboxPayPerc.Text = TechArray(0, 10)
            CBActiveSet.Checked = TechArray(0, 11)
        End If

        TechSelected = CmboBoxTechs.SelectedItem
        BtnPrevTech.Enabled = True
        BtnNextTech.Enabled = True
        BtnSaveTech.Enabled = True

        'Disable buttons to prevent errors
        If CmboBoxTechs.Items.IndexOf(TechSelected) = 0 Then
            BtnPrevTech.Enabled = False
            BtnSaveTech.Enabled = False

        ElseIf CmboBoxTechs.Items.IndexOf(TechSelected) = CmboBoxTechs.Items.Count - 1 Then
            BtnNextTech.Enabled = False
        End If


    End Sub

    Private Sub SaveEditTech()

        Dim data As DatabaseClass = New DatabaseClass
        Dim table As String = ConfigurationManager.AppSettings("Tech")


        'If the tech is being editted
        If RBEditTech.Checked = True Then
            'get  the tech's record that is seleced
            Dim fieldString As String = "[ID], [FirstName], [MiddleInitial], [LastName], [SSN], [FedIDNum], [HomeAddress], [PhoneNum], [EmailAdd], [Location], [PayPercentage],[Active]"
            Dim TechSelected As String = CmboBoxTechs.SelectedItem
            TechSelected = TechSelected.Substring(0, TechSelected.IndexOf("\"))
            Dim condition As String = "[ID] = '" & TechSelected & "' "
            Dim TechArray(,) As String
            data.RunDynamicSelect(table, fieldString, condition, TechArray)

            'If the tech selected exist, this filters out the "----------\ ------- -
            If TechArray.Length <> 0 Then
                Dim fieldParts() As String = {"[ID]", "[FirstName]", "[MiddleInitial]", "[LastName]", "[SSN]", "[FedIDNum]", "[HomeAddress]", "[PhoneNum]", "[EmailAdd]", "[Location]", "[PayPercentage]"}
                Dim fields() As Control = {TxtboxID, txtBoxFirst, TxtBoxMI, TxtBoxLast, TxtBoxSSN, TxtBoxFedID, TxtboxAddr, TxtboxPhone, TxtboxEmail, TxtboxLoc, TxtboxPayPerc}

                'If the tech is present, cycle through the fields
                Dim counter As Integer = 0
                Do While counter < fields.Length
                    'If the textbox field does not match the field in the database
                    If fields(counter).Text <> TechArray(0, counter) Then
                        Dim editfields() As String = {fieldParts(counter)}
                        Dim values() As String = {fields(counter).Text}
                        data.RunDynamicUpdate(table, condition, editfields, values)
                        If counter = 0 Then
                            condition = "[ID] = '" & fields(counter).Text & "' "
                        End If
                    End If
                    counter += 1
                Loop
                'Update Active Status seperate because it is based of .checked instead of .text
                If CBActiveSet.Checked <> TechArray(0, 11) Then
                    Dim editfields() As String = {"[Active]"}
                    Dim values() As String = {CBActiveSet.Checked}
                    data.RunDynamicUpdate(table, condition, editfields, values)
                End If
            End If
        ElseIf RBAddTech.Checked = True Then

            'Checks if the Tech is already in the system
            Dim fieldString As String = "[ID], [FirstName], [MiddleInitial], [LastName], [SSN], [FedIDNum], [HomeAddress], [PhoneNum], [EmailAdd], [Location], [PayPercentage], [Active]"
            Dim condition As String = "[ID] = '" & TxtboxID.Text & "' "
            Dim TechArray(,) As String
            data.RunDynamicSelect(table, fieldString, condition, TechArray)

            If TechArray.Length = 0 Then
                'The Tech is not present so we add it now
                Dim values() As String = {TxtboxID.Text, txtBoxFirst.Text, TxtBoxMI.Text, TxtBoxLast.Text, TxtBoxSSN.Text, TxtBoxFedID.Text, TxtboxAddr.Text, TxtboxPhone.Text, TxtboxEmail.Text, TxtboxLoc.Text, TxtboxPayPerc.Text, CBActiveSet.Checked}
                data.RunDynamicInsert(table, fieldString, values)
            Else
                'notify the user that the tech is already present
                MessageBox.Show("The Technician ID you are trying to add is already in the system.")
            End If
        End If
        FormHome.BuildTechList()
    End Sub

    Private Sub BtnPrevTech_Click(sender As Object, e As EventArgs) Handles BtnPrevTech.Click
        SaveEditTech()
        'Save current selection - 1
        Dim TechSelectedName As String = CmboBoxTechs.SelectedItem
        Dim TechSelection As Integer = CmboBoxTechs.Items.IndexOf(TechSelectedName) - 1

        UpdateTechList()

        'Set current selection back after list is rebuilt
        If CmboBoxTechs.Items.Count > TechSelection And TechSelection >= 0 Then
            CmboBoxTechs.SelectedItem = CmboBoxTechs.Items.Item(TechSelection)
        End If
    End Sub

    Private Sub BtnNextTech_Click(sender As Object, e As EventArgs) Handles BtnNextTech.Click
        SaveEditTech()

        'Save current selection
        Dim TechSelectedName As String = CmboBoxTechs.SelectedItem
        Dim TechSelection As Integer = CmboBoxTechs.Items.IndexOf(TechSelectedName) + 1

        UpdateTechList()

        'Set current selection back after list is rebuilt
        If CmboBoxTechs.Items.Count > TechSelection Then
            CmboBoxTechs.SelectedItem = CmboBoxTechs.Items.Item(TechSelection)
        End If
    End Sub

    Private Sub BtnSaveTech_Click(sender As Object, e As EventArgs) Handles BtnSaveTech.Click
        If TxtboxID.Text <> String.Empty Then
            SaveEditTech()
        Else
            MessageBox.Show("Cannot add Technician with blank TechID")
        End If

        If RBEditTech.Checked = True Then
            'Save current selection
            Dim TechSelectedName As String = CmboBoxTechs.SelectedItem
            Dim TechSelection As Integer = CmboBoxTechs.Items.IndexOf(TechSelectedName)

            UpdateTechList()

            'Set current selection back after list is rebuilt
            If CmboBoxTechs.Items.Count > TechSelection Then
                CmboBoxTechs.SelectedItem = CmboBoxTechs.Items.Item(TechSelection)
            End If
        End If

    End Sub

    Private Sub CBShowInactive_CheckedChanged(sender As Object, e As EventArgs) Handles CBShowInactive.CheckedChanged
        UpdateTechList()
    End Sub

    '--------------------------------------------------------------------------------------------------------------------

    'Password Edit Section

    '--------------------------------------------------------------------------------------------------------------------

    Private Sub PassOK()

        Dim data As DatabaseClass = New DatabaseClass
        Dim table As String = ConfigurationManager.AppSettings("Login")
        Dim fieldsString As String = "[USERNAME],[PASSWORD]"
        Dim condition As String = " [USERNAME] = '" & FormHome.Permissions & "' AND [PASSWORD] = '" & TxtBoxCurrentPass.Text & "'"
        Dim fields(,) As String

        data.RunDynamicSelect(table, fieldsString, condition, fields)

        'Check Security
        If fields.Length <> 0 Then
            'Check new password is same
            If TxtBoxPass.Text = TxtBoxConfirmPass.Text And TxtBoxPass.Text <> String.Empty Then
                changePass()
                TxtBoxCurrentPass.Text = String.Empty
            ElseIf TxtBoxPass.Text <> String.Empty Then
                MessageBox.Show("Error! The password used is not valid because it contains no characters. Please enter a different password. Password Save cancelled.")
            Else
                MessageBox.Show("Error! The two new passwords do not match please re-enter each. Password change cancelled.")
            End If
            TxtBoxPass.Text = String.Empty
            TxtBoxConfirmPass.Text = String.Empty
        Else
            MessageBox.Show("Error! The current password entered was not recognized. Password change cancelled.")
        End If
    End Sub

    Private Sub changePass()
        Dim data As DatabaseClass = New DatabaseClass
        Dim tables As String = ConfigurationManager.AppSettings("Login")
        Dim editFields() As String = {"[PASSWORD]"}
        Dim values() As String = {TxtBoxPass.Text}
        Dim condition As String = " [USERNAME] = '" & FormHome.Permissions & "'"

        data.RunDynamicUpdate(tables, condition, editFields, values)
    End Sub

    Private Sub TxtBoxCurrentPass_LostFocus(sender As Object, e As EventArgs) Handles TxtBoxCurrentPass.LostFocus
        If (TxtBoxCurrentPass.Text <> String.Empty) And (TxtBoxPass.Text <> String.Empty) And (TxtBoxConfirmPass.Text <> String.Empty) Then
            passFlag = True
        Else
            passFlag = False
        End If
    End Sub

    Private Sub TxtBoxPass_LostFocus(sender As Object, e As EventArgs) Handles TxtBoxPass.LostFocus
        If (TxtBoxCurrentPass.Text <> String.Empty) And (TxtBoxPass.Text <> String.Empty) And (TxtBoxConfirmPass.Text <> String.Empty) Then
            passFlag = True
        Else
            passFlag = False
        End If
    End Sub

    Private Sub TxtBoxConfirmPass_LostFocus(sender As Object, e As EventArgs) Handles TxtBoxConfirmPass.LostFocus
        If (TxtBoxCurrentPass.Text <> String.Empty) And (TxtBoxPass.Text <> String.Empty) And (TxtBoxConfirmPass.Text <> String.Empty) Then
            passFlag = True
        Else
            passFlag = False
        End If
    End Sub

End Class