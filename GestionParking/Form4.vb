Imports System.Data.OleDb
Imports System.Data
Public Class Form4
    Dim connection As New OleDbConnection(My.Settings.GestionsParkingsConnectionString)
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'GestionsParkingsDataSet.Utilisateurs' table. You can move, or remove it, as needed.
        Me.UtilisateursTableAdapter.Fill(Me.GestionsParkingsDataSet.Utilisateurs)
        'TODO: This line of code loads data into the 'GestionsParkingsDataSet.Utilisateurs' table. You can move, or remove it, as needed.
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        connection.Open()
        Try
            If (SexeTextBox.Text = "M" Or SexeTextBox.Text = "F") Then
                UtilisateursBindingSource1.EndEdit()
                UtilisateursTableAdapter.Update(GestionsParkingsDataSet.Utilisateurs)
                MessageBox.Show("Sauvegarde reussie")
                IdTextBox.Clear()
                NomTextBox.Clear()
                PrénomsTextBox.Clear()
                SexeTextBox.Clear()
                EmailTextBox.Clear()
                Nom_UtilisateurTextBox.Clear()
                TéléphoneTextBox.Clear()
                Mot_de_passeTextBox.Clear()

            Else
                MsgBox("Soit M ou F a choisir au niveau du sexe", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Echec de sauvegarde")
        End Try
        connection.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Form4_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Dim Confirmation As DialogResult = MessageBox.Show("Voulez vous vraiment quitter ?", "Fermer", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Confirmation = DialogResult.No Then
            e.Cancel = True
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("Voulez vous vraiment supprimer ?", MsgBoxStyle.YesNo)
        If MsgBoxResult.Yes Then
            UtilisateursBindingSource1.RemoveCurrent()
        Else
            DataGridView1.Show()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UtilisateursBindingSource1.AddNew()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Dim ds As New OleDbDataAdapter
        Dim dt As New DataTable
        TextBox9.Focus()
        connection.Open()
        ds = New OleDb.OleDbDataAdapter("SELECT *FROM Utilisateurs WHERE Id ='" & IdTextBox.Text & "'" And " Nom ='" & NomTextBox.Text & "'" And "Prénoms ='" & PrénomsTextBox.Text & "'" And " Nom Utilisateur ='" & Nom_UtilisateurTextBox.Text & "'" And "Mot de passe ='" & Mot_de_passeTextBox.Text & "' ", connection)
        dt.Clear()
        ds.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub

    Private Sub SexeTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TéléphoneTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub NomLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PrénomsLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub IdLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SexeLabel_Click(sender As Object, e As EventArgs)

    End Sub
End Class