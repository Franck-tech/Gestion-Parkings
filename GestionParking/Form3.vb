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
            ClientsBindingSource.EndEdit()
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
        connection.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ClientsBindingSource.MovePrevious()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        ClientsBindingSource.AddNew()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ClientsBindingSource.MoveNext()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("Voulez vous vraiment supprimer ?", MsgBoxStyle.YesNo)
        If MsgBoxResult.Yes Then
            ClientsBindingSource.RemoveCurrent()
        Else
            DataGridView1.Show()
        End If
    End Sub

    Private Sub Id_CliTextBox_TextChanged(sender As Object, e As EventArgs) Handles Id_CliTextBox.TextChanged

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

        If ClientsBindingSource.Count <> 0 Then
            With DataGridView1
                .DataSource = ClientsBindingSource.Filter
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

        index = e.RowIndex

        Dim selectedrow As DataGridViewRow

        selectedrow = DataGridView1.Rows(index)
        Id_CliTextBox.text = selectedrow.Cells(0).Value.ToString
        NomTextBox.text = selectedrow.Cells(1).Value.ToString
        PrénomsTextBox.text = selectedrow.Cells(2).Value.ToString
        AgeTextBox.text = selectedrow.Cells(3).Value.ToString
        SexeTextBox.text = selectedrow.Cells(4).Value.ToString
        SérieTextBox.text = selectedrow.Cells(5).Value.ToString
        N_MatriculeTextBox.text = selectedrow.Cells(6).Value.ToString
        N_VérificationTextBox.text = selectedrow.Cells(7).Value.ToString



    End Sub
End Class