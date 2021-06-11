<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NMatriculeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrénomsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LibelléDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontantDépartDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PayementRBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GestionsParkingsDataSet = New GestionParking.GestionsParkingsDataSet()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Payement_RTableAdapter = New GestionParking.GestionsParkingsDataSetTableAdapters.Payement_RTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayementRBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GestionsParkingsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Elephant", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(426, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(413, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PAYEMENT"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.GroupBox1.Location = New System.Drawing.Point(23, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1132, 472)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payement"
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Image = Global.GestionParking.My.Resources.Resources.account
        Me.Button1.Location = New System.Drawing.Point(985, 404)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 38)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Reçu"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(916, 347)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(179, 22)
        Me.TextBox6.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(772, 346)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 22)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "TotalPaye"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NMatriculeDataGridViewTextBoxColumn, Me.NomDataGridViewTextBoxColumn, Me.PrénomsDataGridViewTextBoxColumn, Me.LibelléDataGridViewTextBoxColumn, Me.MontantDépartDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PayementRBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(482, 47)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(644, 284)
        Me.DataGridView1.TabIndex = 10
        '
        'NMatriculeDataGridViewTextBoxColumn
        '
        Me.NMatriculeDataGridViewTextBoxColumn.DataPropertyName = "N°Matricule"
        Me.NMatriculeDataGridViewTextBoxColumn.HeaderText = "N°Matricule"
        Me.NMatriculeDataGridViewTextBoxColumn.Name = "NMatriculeDataGridViewTextBoxColumn"
        '
        'NomDataGridViewTextBoxColumn
        '
        Me.NomDataGridViewTextBoxColumn.DataPropertyName = "Nom"
        Me.NomDataGridViewTextBoxColumn.HeaderText = "Nom"
        Me.NomDataGridViewTextBoxColumn.Name = "NomDataGridViewTextBoxColumn"
        '
        'PrénomsDataGridViewTextBoxColumn
        '
        Me.PrénomsDataGridViewTextBoxColumn.DataPropertyName = "Prénoms"
        Me.PrénomsDataGridViewTextBoxColumn.HeaderText = "Prénoms"
        Me.PrénomsDataGridViewTextBoxColumn.Name = "PrénomsDataGridViewTextBoxColumn"
        '
        'LibelléDataGridViewTextBoxColumn
        '
        Me.LibelléDataGridViewTextBoxColumn.DataPropertyName = "Libellé"
        Me.LibelléDataGridViewTextBoxColumn.HeaderText = "Libellé"
        Me.LibelléDataGridViewTextBoxColumn.Name = "LibelléDataGridViewTextBoxColumn"
        '
        'MontantDépartDataGridViewTextBoxColumn
        '
        Me.MontantDépartDataGridViewTextBoxColumn.DataPropertyName = "Montant/Départ"
        Me.MontantDépartDataGridViewTextBoxColumn.HeaderText = "Montant/Départ"
        Me.MontantDépartDataGridViewTextBoxColumn.Name = "MontantDépartDataGridViewTextBoxColumn"
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        '
        'PayementRBindingSource
        '
        Me.PayementRBindingSource.DataMember = "Payement_R"
        Me.PayementRBindingSource.DataSource = Me.GestionsParkingsDataSet
        '
        'GestionsParkingsDataSet
        '
        Me.GestionsParkingsDataSet.DataSetName = "GestionsParkingsDataSet"
        Me.GestionsParkingsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(148, 297)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(302, 22)
        Me.TextBox5.TabIndex = 9
        Me.TextBox5.Text = "500"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(40, 296)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 22)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Montant/Départ"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(148, 240)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(302, 22)
        Me.TextBox4.TabIndex = 7
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(40, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 22)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Automobile"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(148, 181)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(302, 22)
        Me.TextBox3.TabIndex = 5
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(40, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 22)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Prénoms"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(148, 123)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(302, 22)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(40, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nom"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(148, 69)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(302, 22)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(40, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "N°Vérification"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Payement_RTableAdapter
        '
        Me.Payement_RTableAdapter.ClearBeforeFill = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(1180, 610)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form5"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayementRBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GestionsParkingsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents GestionsParkingsDataSet As GestionsParkingsDataSet
    Friend WithEvents PayementRBindingSource As BindingSource
    Friend WithEvents Payement_RTableAdapter As GestionsParkingsDataSetTableAdapters.Payement_RTableAdapter
    Friend WithEvents NMatriculeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrénomsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LibelléDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MontantDépartDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
