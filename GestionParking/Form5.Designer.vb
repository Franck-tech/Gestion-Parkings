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
        Dim N_MatriculeLabel As System.Windows.Forms.Label
        Dim NomLabel As System.Windows.Forms.Label
        Dim PrénomsLabel As System.Windows.Forms.Label
        Dim LibelléLabel As System.Windows.Forms.Label
        Dim MontantLabel As System.Windows.Forms.Label
        Dim TotalLabel1 As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.N_MatriculeTextBox = New System.Windows.Forms.TextBox()
        Me.PayementRBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GestionsParkingsDataSet = New GestionParking.GestionsParkingsDataSet()
        Me.NomTextBox = New System.Windows.Forms.TextBox()
        Me.PrénomsTextBox = New System.Windows.Forms.TextBox()
        Me.LibelléTextBox = New System.Windows.Forms.TextBox()
        Me.MontantTextBox = New System.Windows.Forms.TextBox()
        Me.TotalTextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NMatriculeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrénomsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LibelléDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Payement_RTableAdapter = New GestionParking.GestionsParkingsDataSetTableAdapters.Payement_RTableAdapter()
        Me.TableAdapterManager = New GestionParking.GestionsParkingsDataSetTableAdapters.TableAdapterManager()
        N_MatriculeLabel = New System.Windows.Forms.Label()
        NomLabel = New System.Windows.Forms.Label()
        PrénomsLabel = New System.Windows.Forms.Label()
        LibelléLabel = New System.Windows.Forms.Label()
        MontantLabel = New System.Windows.Forms.Label()
        TotalLabel1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PayementRBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GestionsParkingsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'N_MatriculeLabel
        '
        N_MatriculeLabel.AutoSize = True
        N_MatriculeLabel.Location = New System.Drawing.Point(18, 32)
        N_MatriculeLabel.Name = "N_MatriculeLabel"
        N_MatriculeLabel.Size = New System.Drawing.Size(79, 14)
        N_MatriculeLabel.TabIndex = 24
        N_MatriculeLabel.Text = "N°Matricule:"
        AddHandler N_MatriculeLabel.Click, AddressOf Me.N_MatriculeLabel_Click
        '
        'NomLabel
        '
        NomLabel.AutoSize = True
        NomLabel.Location = New System.Drawing.Point(18, 92)
        NomLabel.Name = "NomLabel"
        NomLabel.Size = New System.Drawing.Size(36, 14)
        NomLabel.TabIndex = 26
        NomLabel.Text = "Nom:"
        AddHandler NomLabel.Click, AddressOf Me.NomLabel_Click
        '
        'PrénomsLabel
        '
        PrénomsLabel.AutoSize = True
        PrénomsLabel.Location = New System.Drawing.Point(18, 147)
        PrénomsLabel.Name = "PrénomsLabel"
        PrénomsLabel.Size = New System.Drawing.Size(59, 14)
        PrénomsLabel.TabIndex = 28
        PrénomsLabel.Text = "Prénoms:"
        '
        'LibelléLabel
        '
        LibelléLabel.AutoSize = True
        LibelléLabel.Location = New System.Drawing.Point(18, 203)
        LibelléLabel.Name = "LibelléLabel"
        LibelléLabel.Size = New System.Drawing.Size(50, 14)
        LibelléLabel.TabIndex = 30
        LibelléLabel.Text = "Libellé:"
        '
        'MontantLabel
        '
        MontantLabel.AutoSize = True
        MontantLabel.Location = New System.Drawing.Point(18, 265)
        MontantLabel.Name = "MontantLabel"
        MontantLabel.Size = New System.Drawing.Size(56, 14)
        MontantLabel.TabIndex = 32
        MontantLabel.Text = "Montant:"
        '
        'TotalLabel1
        '
        TotalLabel1.AutoSize = True
        TotalLabel1.Location = New System.Drawing.Point(572, 317)
        TotalLabel1.Name = "TotalLabel1"
        TotalLabel1.Size = New System.Drawing.Size(39, 14)
        TotalLabel1.TabIndex = 34
        TotalLabel1.Text = "Total:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Elephant", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(203, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(413, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PAYEMENT"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(N_MatriculeLabel)
        Me.GroupBox1.Controls.Add(Me.N_MatriculeTextBox)
        Me.GroupBox1.Controls.Add(NomLabel)
        Me.GroupBox1.Controls.Add(Me.NomTextBox)
        Me.GroupBox1.Controls.Add(PrénomsLabel)
        Me.GroupBox1.Controls.Add(Me.PrénomsTextBox)
        Me.GroupBox1.Controls.Add(LibelléLabel)
        Me.GroupBox1.Controls.Add(Me.LibelléTextBox)
        Me.GroupBox1.Controls.Add(MontantLabel)
        Me.GroupBox1.Controls.Add(Me.MontantTextBox)
        Me.GroupBox1.Controls.Add(TotalLabel1)
        Me.GroupBox1.Controls.Add(Me.TotalTextBox1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.GroupBox1.Location = New System.Drawing.Point(12, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(925, 398)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payement"
        '
        'N_MatriculeTextBox
        '
        Me.N_MatriculeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PayementRBindingSource1, "N°Matricule", True))
        Me.N_MatriculeTextBox.Location = New System.Drawing.Point(103, 29)
        Me.N_MatriculeTextBox.Name = "N_MatriculeTextBox"
        Me.N_MatriculeTextBox.Size = New System.Drawing.Size(275, 22)
        Me.N_MatriculeTextBox.TabIndex = 25
        Me.N_MatriculeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PayementRBindingSource1
        '
        Me.PayementRBindingSource1.DataMember = "Payement_R"
        Me.PayementRBindingSource1.DataSource = Me.GestionsParkingsDataSet
        '
        'GestionsParkingsDataSet
        '
        Me.GestionsParkingsDataSet.DataSetName = "GestionsParkingsDataSet"
        Me.GestionsParkingsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NomTextBox
        '
        Me.NomTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PayementRBindingSource1, "Nom", True))
        Me.NomTextBox.Location = New System.Drawing.Point(103, 89)
        Me.NomTextBox.Name = "NomTextBox"
        Me.NomTextBox.Size = New System.Drawing.Size(275, 22)
        Me.NomTextBox.TabIndex = 27
        Me.NomTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PrénomsTextBox
        '
        Me.PrénomsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PayementRBindingSource1, "Prénoms", True))
        Me.PrénomsTextBox.Location = New System.Drawing.Point(103, 144)
        Me.PrénomsTextBox.Name = "PrénomsTextBox"
        Me.PrénomsTextBox.Size = New System.Drawing.Size(275, 22)
        Me.PrénomsTextBox.TabIndex = 29
        Me.PrénomsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LibelléTextBox
        '
        Me.LibelléTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PayementRBindingSource1, "Libellé", True))
        Me.LibelléTextBox.Location = New System.Drawing.Point(103, 200)
        Me.LibelléTextBox.Name = "LibelléTextBox"
        Me.LibelléTextBox.Size = New System.Drawing.Size(275, 22)
        Me.LibelléTextBox.TabIndex = 31
        Me.LibelléTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MontantTextBox
        '
        Me.MontantTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PayementRBindingSource1, "Montant", True))
        Me.MontantTextBox.Location = New System.Drawing.Point(103, 262)
        Me.MontantTextBox.Name = "MontantTextBox"
        Me.MontantTextBox.Size = New System.Drawing.Size(275, 22)
        Me.MontantTextBox.TabIndex = 33
        Me.MontantTextBox.Text = " 500 "
        Me.MontantTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TotalTextBox1
        '
        Me.TotalTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PayementRBindingSource1, "Total", True))
        Me.TotalTextBox1.Location = New System.Drawing.Point(644, 314)
        Me.TotalTextBox1.Name = "TotalTextBox1"
        Me.TotalTextBox1.Size = New System.Drawing.Size(255, 22)
        Me.TotalTextBox1.TabIndex = 35
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Image = Global.GestionParking.My.Resources.Resources.account
        Me.Button1.Location = New System.Drawing.Point(789, 342)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 38)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Reçu"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NMatriculeDataGridViewTextBoxColumn, Me.NomDataGridViewTextBoxColumn, Me.PrénomsDataGridViewTextBoxColumn, Me.LibelléDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PayementRBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(396, 21)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(523, 284)
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
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        '
        'Payement_RTableAdapter
        '
        Me.Payement_RTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AutomobileTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientsTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.PayementTableAdapter = Nothing
        Me.TableAdapterManager.PayerTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = GestionParking.GestionsParkingsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UtilisateursTableAdapter = Nothing
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(945, 498)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form5"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PayementRBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GestionsParkingsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents GestionsParkingsDataSet As GestionsParkingsDataSet
    Friend WithEvents Payement_RTableAdapter As GestionsParkingsDataSetTableAdapters.Payement_RTableAdapter
    Friend WithEvents NMatriculeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrénomsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LibelléDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MontantDépartDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TableAdapterManager As GestionsParkingsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents N_MatriculeTextBox As TextBox
    Friend WithEvents PayementRBindingSource1 As BindingSource
    Friend WithEvents NomTextBox As TextBox
    Friend WithEvents PrénomsTextBox As TextBox
    Friend WithEvents LibelléTextBox As TextBox
    Friend WithEvents MontantTextBox As TextBox
    Friend WithEvents TotalTextBox1 As TextBox
End Class
