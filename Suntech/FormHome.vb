Public Class FormHome

    Private data As DatabaseClass

    Private Sub FrmHome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        data = New DatabaseClass

        'Sub to Initialize the Technician list
        BuildTechList()


    End Sub

    Private Sub BuildTechList()
        Dim TechArray() As String
        LstBoxTech.Items.Clear()

        'RetrieveTechList Queries database Technician Table and returns all technicians in an array of strings
        data.RetrieveTechList(TechArray)

        'Populate listbox with Technicians
        Dim counter As Integer = 0
        While (counter < TechArray.Length)
            LstBoxTech.Items.Add(TechArray(counter))
            counter += 1
        End While
    End Sub

    Private Sub BuildQuery()

        Dim TechSelected As String = LstBoxTech.SelectedItem
        Dim bgnDate As Date = DTPkrFrom.Value
        Dim endDate As Date = DTPkrEnd.Value

    End Sub

    Private Sub BtnGtInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGtInfo.Click
        BuildQuery()

    End Sub
End Class
