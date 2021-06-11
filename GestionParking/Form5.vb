Imports System.Data.OleDb
Imports System.Data

Public Class Form5
    Dim connection As New OleDbConnection(My.Settings.GestionsParkingsConnectionString)
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GestionsParkingsDataSet.Payement_R' table. You can move, or remove it, as needed.
        Me.Payement_RTableAdapter.Fill(Me.GestionsParkingsDataSet.Payement_R)

    End Sub
End Class