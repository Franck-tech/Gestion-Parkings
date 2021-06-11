Public Class Form2
    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GestionsParkingsDataSet.Personnels' table. You can move, or remove it, as needed.
        Timer1.Enabled = True
    End Sub

    Sub SwitchPanel(ByVal panel As Form)

        Panel4.Controls.Clear()
        panel.TopLevel = False
        Panel4.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SwitchPanel(Form3)
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Dim Confirmation As DialogResult = MessageBox.Show("Voulez vous vraiment quitter ?", "Fermer", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Confirmation = DialogResult.No Then
            e.Cancel = True
        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label4.Text = Date.Now.ToString("dd-MM-yyyy")
        Label5.Text = Date.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SwitchPanel(Form4)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        SwitchPanel(Form5)
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Label8_Click_1(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class