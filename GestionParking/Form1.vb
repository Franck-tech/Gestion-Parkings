Imports System.Data.OleDb
Imports System.Data

Public Class Form1
    Dim connection As New OleDbConnection(My.Settings.GestionsParkingsConnectionString)
    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If TextBox2.UseSystemPasswordChar = True Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.UseSystemPasswordChar = True

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Dim Confirmation As DialogResult = MessageBox.Show("Voulez vous vraiment quitter ?", "Fermer", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Confirmation = DialogResult.No Then
            e.Cancel = True
        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        connection.Open()
        If TextBox1.Text = Nothing Or TextBox2.Text = Nothing Then
            MsgBox("Veilliez remplir les informations", MsgBoxStyle.Exclamation)
            Me.Show()
        Else
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            Dim cmd As New OleDbCommand("select *from Utilisateurs where (([Nom Utilisateur]=?) and ([Mot de passe]=?))", connection)
            cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = TextBox1.Text
            cmd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = TextBox2.Text
            Dim count = Convert.ToInt32(cmd.ExecuteScalar())

            If (count > 0) Then
                Form2.Show()
                TextBox1.Clear()
                TextBox2.Clear()

            Else
                MsgBox("Connection échoué", MsgBoxStyle.Critical)
            End If
        End If
        connection.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Form4.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Confirmation As DialogResult = MessageBox.Show("Voulez vous quittez le programme ?", "Fermeture du programme", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Confirmation = DialogResult.No Then
            Me.Show()
        Else
            End
        End If
    End Sub
End Class
