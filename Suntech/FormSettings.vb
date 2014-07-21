Imports System.Configuration
Imports System.Data.SqlClient

Public Class FrmSettings

    Private Sub FrmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmboBoxTechs.Enabled = False
        RBAddTech.Checked = True
        fillSettings()
        If ChkboxSvcPay.Checked Then
            TxtBoxSvcPay.Enabled = True
        Else
            TxtBoxSvcPay.Enabled = False
        End If
    End Sub

    'Add/Edit Tech Section
    Private Sub RBAddTech_CheckedChanged(sender As Object, e As EventArgs) Handles RBAddTech.CheckedChanged
        CmboBoxTechs.Enabled = False
        clearTxtBoxes()

    End Sub

    Private Sub RBEditTech_CheckedChanged(sender As Object, e As EventArgs) Handles RBEditTech.CheckedChanged
        CmboBoxTechs.Enabled = True
        UpdateTechList()



    End Sub

    Private Sub UpdateTechList()
        CmboBoxTechs.Enabled = True
        CmboBoxTechs.Items.Clear()

        Dim data As DatabaseClass = New DatabaseClass
        'runs a select Query to retrieve list of Techs
        Dim table As String = ConfigurationManager.AppSettings("Tech")
        Dim fieldString As String = "[ID], [FirstName], [MiddleInitial], [LastName]"
        Dim TechArray(,) As String
        data.RunDynamicSelect(table, fieldString, "", TechArray)


        CmboBoxTechs.Items.Add("--------\------,----- -")


        'Populate listbox with Technicians
        Dim counter As Integer = 0
        While (counter < TechArray.GetLength(0))
            CmboBoxTechs.Items.Add(TechArray(counter, 0) & "\" & TechArray(counter, 3) & ", " & TechArray(counter, 1) & " " & TechArray(counter, 2))
            counter += 1
        End While

        If CmboBoxTechs.Items.Count <> 0 Then
            CmboBoxTechs.SelectedItem = CmboBoxTechs.Items.Item(0)
        End If
    End Sub

    Private Sub clearTxtBoxes()
        For Each element As Control In PnlEditTech.Controls
            If TypeOf element Is TextBox Then
                element.Text = String.Empty
            End If
        Next
    End Sub

    Private Sub CmboBoxTechs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmboBoxTechs.SelectedIndexChanged
        Dim TechSelected As String = CmboBoxTechs.SelectedItem
        TechSelected = TechSelected.Substring(0, TechSelected.IndexOf("\"))

        Dim data As DatabaseClass = New DatabaseClass
        Dim table As String = ConfigurationManager.AppSettings("Tech")
        Dim fieldString As String = "[ID], [FirstName], [MiddleInitial], [LastName], [SSN], [FedIDNum], [HomeAddress], [PhoneNum], [EmailAdd], [Location], [PayPercentage]"
        Dim condition As String = "[ID] = '" & TechSelected & "' "
        Dim TechArray(,) As String
        data.RunDynamicSelect(table, fieldString, condition, TechArray)

        If TechArray.Length <> 0 Then
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
        End If

    End Sub

    Private Sub BtnEditTechSave_Click(sender As Object, e As EventArgs) Handles BtnEditTechSave.Click

        Dim data As DatabaseClass = New DatabaseClass
        Dim table As String = ConfigurationManager.AppSettings("Tech")

        'If the tech is being editted
        If RBEditTech.Checked = True Then
            'get  the tech's record that is seleced
            Dim fieldString As String = "[ID], [FirstName], [MiddleInitial], [LastName], [SSN], [FedIDNum], [HomeAddress], [PhoneNum], [EmailAdd], [Location], [PayPercentage]"
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
            End If
        ElseIf RBAddTech.Checked = True Then

            Dim fieldString As String = "[ID], [FirstName], [MiddleInitial], [LastName], [SSN], [FedIDNum], [HomeAddress], [PhoneNum], [EmailAdd], [Location], [PayPercentage]"
            Dim condition As String = "[ID] = '" & TxtboxID.Text & "' "
            Dim TechArray(,) As String
            data.RunDynamicSelect(table, fieldString, condition, TechArray)

            If TechArray.Length = 0 Then
                Dim values() As String = {TxtboxID.Text, txtBoxFirst.Text, TxtBoxMI.Text, TxtBoxLast.Text, TxtBoxSSN.Text, TxtBoxFedID.Text, TxtboxAddr.Text, TxtboxPhone.Text, TxtboxEmail.Text, TxtboxLoc.Text, TxtboxPayPerc.Text}
                data.RunDynamicInsert(table, fieldString, values)
            Else
                MessageBox.Show("The Technician ID you are trying to add is already in the system.")
            End If
        End If
        UpdateTechList()
        clearTxtBoxes()
    End Sub

    Private Sub BtnEditTechCncl_Click(sender As Object, e As EventArgs) Handles BtnEditTechCncl.Click
        Me.Close()
    End Sub

    'Password Edit Section
    Private Sub changePass()
        Dim data As DatabaseClass = New DatabaseClass
        Dim tables As String = ConfigurationManager.AppSettings("Login")
        Dim editFields() As String = {"[PASSWORD]"}
        Dim values() As String = {TxtBoxPass.Text}
        Dim condition As String = " [USERNAME] = '" & FormHome.Permissions & "'"

        data.RunDynamicUpdate(tables, condition, editFields, values)
    End Sub

    Private Sub BtnEditPassOK_Click(sender As Object, e As EventArgs) Handles BtnEditPassOK.Click

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
                MessageBox.Show("Your password has been successfully changed.")
                changePass()
                TxtBoxCurrentPass.Text = String.Empty
            ElseIf TxtBoxPass.Text <> String.Empty Then
                MessageBox.Show("The password used is not valid because it contains no characters. Please enter a different password.")
            Else
                MessageBox.Show("The two new passwords do not match please re-enter each.")
            End If
            TxtBoxPass.Text = String.Empty
            TxtBoxConfirmPass.Text = String.Empty
        Else
            MessageBox.Show("The current password entered was not recognized.")
        End If
    End Sub

    Private Sub BtnEditPassCncl_Click(sender As Object, e As EventArgs) Handles BtnEditPassCncl.Click
        Me.Close()
    End Sub

    'General settings Section
    Public Sub fillSettings()
        Dim data As DatabaseClass = New DatabaseClass
        Dim table As String = ConfigurationManager.AppSettings("Options")
        Dim fieldString As String = "[UseStaticSrvc],[SrvcPay]"
        Dim condition As String = ""
        Dim fields(,) As String
        data.RunDynamicSelect(table, fieldString, condition, fields)

        If fields.Length > 0 Then
            ChkboxSvcPay.Checked = fields(0, 0)
            Dim svcPay As Double = fields(0, 1)
            TxtBoxSvcPay.Text = svcPay
        End If

    End Sub

    Private Sub ChkboxSvcPay_CheckedChanged(sender As Object, e As EventArgs) Handles ChkboxSvcPay.CheckedChanged
        If ChkboxSvcPay.Checked Then
            TxtBoxSvcPay.Enabled = True
        Else
            TxtBoxSvcPay.Enabled = False
        End If
    End Sub

    Private Sub BtnGenSave_Click(sender As Object, e As EventArgs) Handles BtnGenSave.Click

        Dim data As DatabaseClass = New DatabaseClass
        Dim table As String = ConfigurationManager.AppSettings("Options")
        Dim condition As String = ""
        Dim editfields() As String = {"[UseStaticSrvc]", "[SrvcPay]"}
        Dim values() As String = {ChkboxSvcPay.Checked, TxtBoxSvcPay.Text}
        data.RunDynamicUpdate(table, condition, editfields, values)
        MessageBox.Show("Settings successfully saved.")

    End Sub

    Private Sub BtnCncl_Click(sender As Object, e As EventArgs) Handles BtnGenCncl.Click
        Me.Close()
    End Sub

End Class