Imports System.Data.OleDb
Imports System.Data

Public Class Form3
    Dim connection As New OleDbConnection(My.Settings.GestionsParkingsConnectionString)
    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GestionsParkingsDataSet.Clients' table. You can move, or remove it, as needed.
        Me.ClientsTableAdapter.Fill(Me.GestionsParkingsDataSet.Clients)
        'TODO: This line of code loads data into the 'GestionsParkingsDataSet.Personnels' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'GestionsParkingsDataSet.Utilisateurs' table. You can move, or remove it, as needed.


    End Sub


    Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Dim Confirmation As DialogResult = MessageBox.Show("Voulez vous vraiment quitter ?", "Fermer", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Confirmation = DialogResult.No Then
            e.Cancel = True
        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        connection.Open()
        Try
            ClientsBindingSource1.EndEdit()
            ClientsTableAdapter.Update(GestionsParkingsDataSet.Clients)
            MessageBox.Show("Sauvegarde reussie")
            Id_CliTextBox.Clear()
            NomTextBox.Clear()
            PrénomsTextBox.Clear()
            AgeTextBox.Clear()
            SexeTextBox.Clear()
            SérieTextBox.Clear()
            N_MatriculeTextBox.Clear()
            TelTextBox.Clear()
            N_VérificationTextBox.Clear()

        Catch ex As Exception
            MessageBox.Show("Echec de sauvegarde")
        End Try

        If (DéchargéCheckBox().Checked And MessageBox.Show("Sauvegarde reussie")) Then
            Form5.Show()
        End If
        connection.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ClientsBindingSource1.MovePrevious()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        ClientsBindingSource1.AddNew()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ClientsBindingSource1.MoveNext()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("Voulez vous vraiment supprimer ?", MsgBoxStyle.YesNo)
        If MsgBoxResult.Yes Then
            ClientsBindingSource1.RemoveCurrent()
        Else
            DataGridView1.Show()
        End If
    End Sub

    Private Sub Id_CliTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

        If ClientsBindingSource1.Count <> 0 Then
            With DataGridView1
                .DataSource = ClientsBindingSource1.Filter
            End With

        Else
            MsgBox("Cette information n'est pas dans la base de donnée", MsgBoxStyle.Information, "Hey Boss")
        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Dim ds As New OleDbDataAdapter
        Dim dt As New DataTable
        connection.Open()
        ds = New OleDb.OleDbDataAdapter("SELECT *FROM Clients WHERE N°Vérification='" & TextBox9.Text & "'", connection)
        dt.Clear()
        ds.Fill(dt)
        DataGridView1.DataSource = dt
        connection.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick



        Dim selectedrow As DataGridViewRow





    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        Dim newData As DataGridViewRow
        Dim index = e.ToString

        newData = DataGridView1.Rows(index)

        newData.Cells(0).Value = Id_CliTextBox.Text
        newData.Cells(1).Value = NomTextBox.Text
        newData.Cells(2).Value = PrénomsTextBox.Text
        newData.Cells(3).Value = AgeTextBox.Text
        newData.Cells(4).Value.Text
        newData.Cells(0).Value = TelTextBox.Text
        newData.Cells(5).Value = SérieTextBox.Text
        newData.Cells(6).Value = N_MatriculeTextBox.Text
        newData.Cells(7).Value = N_VérificationTextBox.Text

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class