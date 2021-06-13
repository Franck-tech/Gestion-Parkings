Imports System.Data.OleDb
Imports System.Data

Public Class Form5
    Dim connection As New OleDbConnection(My.Settings.GestionsParkingsConnectionString)
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GestionsParkingsDataSet.Payement_R' table. You can move, or remove it, as needed.
        Me.Payement_RTableAdapter.Fill(Me.GestionsParkingsDataSet.Payement_R)

    End Sub

    Private Sub TotalTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub N_MatriculeLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub N_MatriculeTextBox_TextChanged(sender As Object, e As EventArgs) Handles N_MatriculeTextBox.TextChanged

    End Sub

    Private Sub NomLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub NomTextBox_TextChanged(sender As Object, e As EventArgs) Handles NomTextBox.TextChanged

    End Sub
End Class