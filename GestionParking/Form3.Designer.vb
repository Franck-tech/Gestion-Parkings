<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim Id_CliLabel As System.Windows.Forms.Label
        Dim NomLabel As System.Windows.Forms.Label
        Dim PrénomsLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Dim SexeLabel As System.Windows.Forms.Label
        Dim TelLabel As System.Windows.Forms.Label
        Dim SérieLabel As System.Windows.Forms.Label
        Dim N_MatriculeLabel As System.Windows.Forms.Label
        Dim DéchargéLabel As System.Windows.Forms.Label
        Dim N_VérificationLabel As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Id_CliTextBox = New System.Windows.Forms.TextBox()
        Me.ClientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GestionsParkingsDataSet = New GestionParking.GestionsParkingsDataSet()
        Me.NomTextBox = New System.Windows.Forms.TextBox()
        Me.PrénomsTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.SexeTextBox = New System.Windows.Forms.TextBox()
        Me.TelTextBox = New System.Windows.Forms.TextBox()
        Me.SérieTextBox = New System.Windows.Forms.TextBox()
        Me.N_MatriculeTextBox = New System.Windows.Forms.TextBox()
        Me.DéchargéCheckBox = New System.Windows.Forms.CheckBox()
        Me.N_VérificationTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdCliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrénomsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SérieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NMatriculeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DéchargéDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.NVérificationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ClientsTableAdapter = New GestionParking.GestionsParkingsDataSetTableAdapters.ClientsTableAdapter()
        Me.TableAdapterManager = New GestionParking.GestionsParkingsDataSetTableAdapters.TableAdapterManager()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Id_CliLabel = New System.Windows.Forms.Label()
        NomLabel = New System.Windows.Forms.Label()
        PrénomsLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        SexeLabel = New System.Windows.Forms.Label()
        TelLabel = New System.Windows.Forms.Label()
        SérieLabel = New System.Windows.Forms.Label()
        N_MatriculeLabel = New System.Windows.Forms.Label()
        DéchargéLabel = New System.Windows.Forms.Label()
        N_VérificationLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ClientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GestionsParkingsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_CliLabel
        '
        Id_CliLabel.Location = New System.Drawing.Point(49, 58)
        Id_CliLabel.Name = "Id_CliLabel"
        Id_CliLabel.Size = New System.Drawing.Size(101, 21)
        Id_CliLabel.TabIndex = 0
        Id_CliLabel.Text = "Id Cli:"
        '
        'NomLabel
        '
        NomLabel.Location = New System.Drawing.Point(49, 88)
        NomLabel.Name = "NomLabel"
        NomLabel.Size = New System.Drawing.Size(96, 21)
        NomLabel.TabIndex = 2
        NomLabel.Text = "Nom:"
        '
        'PrénomsLabel
        '
        PrénomsLabel.Location = New System.Drawing.Point(49, 118)
        PrénomsLabel.Name = "PrénomsLabel"
        PrénomsLabel.Size = New System.Drawing.Size(123, 21)
        PrénomsLabel.TabIndex = 4
        PrénomsLabel.Text = "Prénoms:"
        '
        'AgeLabel
        '
        AgeLabel.Location = New System.Drawing.Point(49, 148)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(89, 21)
        AgeLabel.TabIndex = 6
        AgeLabel.Text = "Age:"
        '
        'SexeLabel
        '
        SexeLabel.Location = New System.Drawing.Point(49, 178)
        SexeLabel.Name = "SexeLabel"
        SexeLabel.Size = New System.Drawing.Size(95, 21)
        SexeLabel.TabIndex = 8
        SexeLabel.Text = "Sexe:"
        '
        'TelLabel
        '
        TelLabel.Location = New System.Drawing.Point(49, 208)
        TelLabel.Name = "TelLabel"
        TelLabel.Size = New System.Drawing.Size(86, 21)
        TelLabel.TabIndex = 10
        TelLabel.Text = "Tel:"
        '
        'SérieLabel
        '
        SérieLabel.Location = New System.Drawing.Point(49, 238)
        SérieLabel.Name = "SérieLabel"
        SérieLabel.Size = New System.Drawing.Size(99, 21)
        SérieLabel.TabIndex = 12
        SérieLabel.Text = "Série:"
        '
        'N_MatriculeLabel
        '
        N_MatriculeLabel.Location = New System.Drawing.Point(49, 268)
        N_MatriculeLabel.Name = "N_MatriculeLabel"
        N_MatriculeLabel.Size = New System.Drawing.Size(127, 21)
        N_MatriculeLabel.TabIndex = 14
        N_MatriculeLabel.Text = "N°Matricule:"
        '
        'DéchargéLabel
        '
        DéchargéLabel.Location = New System.Drawing.Point(49, 300)
        DéchargéLabel.Name = "DéchargéLabel"
        DéchargéLabel.Size = New System.Drawing.Size(127, 21)
        DéchargéLabel.TabIndex = 16
        DéchargéLabel.Text = "Déchargé:"
        '
        'N_VérificationLabel
        '
        N_VérificationLabel.Location = New System.Drawing.Point(49, 328)
        N_VérificationLabel.Name = "N_VérificationLabel"
        N_VérificationLabel.Size = New System.Drawing.Size(115, 21)
        N_VérificationLabel.TabIndex = 18
        N_VérificationLabel.Text = "N°Vérification:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Id_CliLabel)
        Me.GroupBox1.Controls.Add(Me.Id_CliTextBox)
        Me.GroupBox1.Controls.Add(NomLabel)
        Me.GroupBox1.Controls.Add(Me.NomTextBox)
        Me.GroupBox1.Controls.Add(PrénomsLabel)
        Me.GroupBox1.Controls.Add(Me.PrénomsTextBox)
        Me.GroupBox1.Controls.Add(AgeLabel)
        Me.GroupBox1.Controls.Add(Me.AgeTextBox)
        Me.GroupBox1.Controls.Add(SexeLabel)
        Me.GroupBox1.Controls.Add(Me.SexeTextBox)
        Me.GroupBox1.Controls.Add(TelLabel)
        Me.GroupBox1.Controls.Add(Me.TelTextBox)
        Me.GroupBox1.Controls.Add(SérieLabel)
        Me.GroupBox1.Controls.Add(Me.SérieTextBox)
        Me.GroupBox1.Controls.Add(N_MatriculeLabel)
        Me.GroupBox1.Controls.Add(Me.N_MatriculeTextBox)
        Me.GroupBox1.Controls.Add(DéchargéLabel)
        Me.GroupBox1.Controls.Add(Me.DéchargéCheckBox)
        Me.GroupBox1.Controls.Add(N_VérificationLabel)
        Me.GroupBox1.Controls.Add(Me.N_VérificationTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Elephant", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.GroupBox1.Location = New System.Drawing.Point(12, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(431, 392)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enregregistrement"
        '
        'Id_CliTextBox
        '
        Me.Id_CliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientsBindingSource, "Id_Cli", True))
        Me.Id_CliTextBox.Location = New System.Drawing.Point(184, 55)
        Me.Id_CliTextBox.Name = "Id_CliTextBox"
        Me.Id_CliTextBox.Size = New System.Drawing.Size(217, 24)
        Me.Id_CliTextBox.TabIndex = 1
        '
        'ClientsBindingSource
        '
        Me.ClientsBindingSource.DataMember = "Clients"
        Me.ClientsBindingSource.DataSource = Me.GestionsParkingsDataSet
        '
        'GestionsParkingsDataSet
        '
        Me.GestionsParkingsDataSet.DataSetName = "GestionsParkingsDataSet"
        Me.GestionsParkingsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NomTextBox
        '
        Me.NomTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientsBindingSource, "Nom", True))
        Me.NomTextBox.Location = New System.Drawing.Point(184, 85)
        Me.NomTextBox.Name = "NomTextBox"
        Me.NomTextBox.Size = New System.Drawing.Size(217, 24)
        Me.NomTextBox.TabIndex = 3
        '
        'PrénomsTextBox
        '
        Me.PrénomsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientsBindingSource, "Prénoms", True))
        Me.PrénomsTextBox.Location = New System.Drawing.Point(184, 115)
        Me.PrénomsTextBox.Name = "PrénomsTextBox"
        Me.PrénomsTextBox.Size = New System.Drawing.Size(217, 24)
        Me.PrénomsTextBox.TabIndex = 5
        '
        'AgeTextBox
        '
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientsBindingSource, "Age", True))
        Me.AgeTextBox.Location = New System.Drawing.Point(184, 145)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(217, 24)
        Me.AgeTextBox.TabIndex = 7
        '
        'SexeTextBox
        '
        Me.SexeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientsBindingSource, "Sexe", True))
        Me.SexeTextBox.Location = New System.Drawing.Point(184, 175)
        Me.SexeTextBox.Name = "SexeTextBox"
        Me.SexeTextBox.Size = New System.Drawing.Size(217, 24)
        Me.SexeTextBox.TabIndex = 9
        '
        'TelTextBox
        '
        Me.TelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientsBindingSource, "Tel", True))
        Me.TelTextBox.Location = New System.Drawing.Point(184, 205)
        Me.TelTextBox.Name = "TelTextBox"
        Me.TelTextBox.Size = New System.Drawing.Size(217, 24)
        Me.TelTextBox.TabIndex = 11
        '
        'SérieTextBox
        '
        Me.SérieTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientsBindingSource, "Série", True))
        Me.SérieTextBox.Location = New System.Drawing.Point(184, 235)
        Me.SérieTextBox.Name = "SérieTextBox"
        Me.SérieTextBox.Size = New System.Drawing.Size(217, 24)
        Me.SérieTextBox.TabIndex = 13
        '
        'N_MatriculeTextBox
        '
        Me.N_MatriculeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientsBindingSource, "N°Matricule", True))
        Me.N_MatriculeTextBox.Location = New System.Drawing.Point(184, 265)
        Me.N_MatriculeTextBox.Name = "N_MatriculeTextBox"
        Me.N_MatriculeTextBox.Size = New System.Drawing.Size(217, 24)
        Me.N_MatriculeTextBox.TabIndex = 15
        '
        'DéchargéCheckBox
        '
        Me.DéchargéCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ClientsBindingSource, "Déchargé", True))
        Me.DéchargéCheckBox.Location = New System.Drawing.Point(184, 295)
        Me.DéchargéCheckBox.Name = "DéchargéCheckBox"
        Me.DéchargéCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.DéchargéCheckBox.TabIndex = 17
        Me.DéchargéCheckBox.Text = "CheckBox1"
        Me.DéchargéCheckBox.UseVisualStyleBackColor = True
        '
        'N_VérificationTextBox
        '
        Me.N_VérificationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientsBindingSource, "N°Vérification", True))
        Me.N_VérificationTextBox.Location = New System.Drawing.Point(184, 325)
        Me.N_VérificationTextBox.Name = "N_VérificationTextBox"
        Me.N_VérificationTextBox.Size = New System.Drawing.Size(217, 24)
        Me.N_VérificationTextBox.TabIndex = 19
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Font = New System.Drawing.Font("Elephant", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.GroupBox2.Location = New System.Drawing.Point(443, 69)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(705, 392)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Liste Personnel"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCliDataGridViewTextBoxColumn, Me.NomDataGridViewTextBoxColumn, Me.PrénomsDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn, Me.SexeDataGridViewTextBoxColumn, Me.TelDataGridViewTextBoxColumn, Me.SérieDataGridViewTextBoxColumn, Me.NMatriculeDataGridViewTextBoxColumn, Me.DéchargéDataGridViewCheckBoxColumn, Me.NVérificationDataGridViewTextBoxColumn, Me.Column1})
        Me.DataGridView1.DataSource = Me.ClientsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(6, 58)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(693, 328)
        Me.DataGridView1.TabIndex = 0
        '
        'IdCliDataGridViewTextBoxColumn
        '
        Me.IdCliDataGridViewTextBoxColumn.DataPropertyName = "Id_Cli"
        Me.IdCliDataGridViewTextBoxColumn.HeaderText = "Id_Cli"
        Me.IdCliDataGridViewTextBoxColumn.Name = "IdCliDataGridViewTextBoxColumn"
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
        'AgeDataGridViewTextBoxColumn
        '
        Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "Age"
        Me.AgeDataGridViewTextBoxColumn.HeaderText = "Age"
        Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
        '
        'SexeDataGridViewTextBoxColumn
        '
        Me.SexeDataGridViewTextBoxColumn.DataPropertyName = "Sexe"
        Me.SexeDataGridViewTextBoxColumn.HeaderText = "Sexe"
        Me.SexeDataGridViewTextBoxColumn.Name = "SexeDataGridViewTextBoxColumn"
        '
        'TelDataGridViewTextBoxColumn
        '
        Me.TelDataGridViewTextBoxColumn.DataPropertyName = "Tel"
        Me.TelDataGridViewTextBoxColumn.HeaderText = "Tel"
        Me.TelDataGridViewTextBoxColumn.Name = "TelDataGridViewTextBoxColumn"
        '
        'SérieDataGridViewTextBoxColumn
        '
        Me.SérieDataGridViewTextBoxColumn.DataPropertyName = "Série"
        Me.SérieDataGridViewTextBoxColumn.HeaderText = "Série"
        Me.SérieDataGridViewTextBoxColumn.Name = "SérieDataGridViewTextBoxColumn"
        '
        'NMatriculeDataGridViewTextBoxColumn
        '
        Me.NMatriculeDataGridViewTextBoxColumn.DataPropertyName = "N°Matricule"
        Me.NMatriculeDataGridViewTextBoxColumn.HeaderText = "N°Matricule"
        Me.NMatriculeDataGridViewTextBoxColumn.Name = "NMatriculeDataGridViewTextBoxColumn"
        '
        'DéchargéDataGridViewCheckBoxColumn
        '
        Me.DéchargéDataGridViewCheckBoxColumn.DataPropertyName = "Déchargé"
        Me.DéchargéDataGridViewCheckBoxColumn.HeaderText = "Déchargé"
        Me.DéchargéDataGridViewCheckBoxColumn.Name = "DéchargéDataGridViewCheckBoxColumn"
        '
        'NVérificationDataGridViewTextBoxColumn
        '
        Me.NVérificationDataGridViewTextBoxColumn.DataPropertyName = "N°Vérification"
        Me.NVérificationDataGridViewTextBoxColumn.HeaderText = "N°Vérification"
        Me.NVérificationDataGridViewTextBoxColumn.Name = "NVérificationDataGridViewTextBoxColumn"
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Id"
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        Me.Column1.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Elephant", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(300, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(575, 34)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "AJOUT DES CLIENTS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(925, 42)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(205, 20)
        Me.TextBox9.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Elephant", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(833, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 19)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Filtrer"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ClientsTableAdapter
        '
        Me.ClientsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AutomobileTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientsTableAdapter = Me.ClientsTableAdapter
        Me.TableAdapterManager.PayementTableAdapter = Nothing
        Me.TableAdapterManager.PayerTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = GestionParking.GestionsParkingsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UtilisateursTableAdapter = Nothing
        '
        'Button8
        '
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Elephant", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Image = Global.GestionParking.My.Resources.Resources.bouton_actualiser
        Me.Button8.Location = New System.Drawing.Point(1103, 8)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(45, 28)
        Me.Button8.TabIndex = 8
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Elephant", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Image = Global.GestionParking.My.Resources.Resources.printer__1_
        Me.Button6.Location = New System.Drawing.Point(870, 516)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(104, 33)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "Imprimer"
        Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Elephant", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = Global.GestionParking.My.Resources.Resources.next_button
        Me.Button5.Location = New System.Drawing.Point(870, 477)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(104, 33)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Suivant"
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Elephant", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.GestionParking.My.Resources.Resources.delete
        Me.Button4.Location = New System.Drawing.Point(529, 516)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(115, 33)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Supprimer"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Elephant", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.GestionParking.My.Resources.Resources.previous
        Me.Button1.Location = New System.Drawing.Point(170, 477)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 33)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Précedent"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Elephant", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.GestionParking.My.Resources.Resources.diskette__2_
        Me.Button2.Location = New System.Drawing.Point(170, 516)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(121, 33)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Sauvegarder"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Elephant", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.GestionParking.My.Resources.Resources.follow__1_
        Me.Button3.Location = New System.Drawing.Point(529, 477)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(115, 33)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Nouveau"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Elephant", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Image = Global.GestionParking.My.Resources.Resources.funnel__1_
        Me.Button7.Location = New System.Drawing.Point(1109, 30)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(56, 45)
        Me.Button7.TabIndex = 8
        Me.Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(1177, 570)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ClientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GestionsParkingsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents GestionsParkingsDataSet As GestionsParkingsDataSet
    Friend WithEvents ClientsBindingSource As BindingSource
    Friend WithEvents ClientsTableAdapter As GestionsParkingsDataSetTableAdapters.ClientsTableAdapter
    Friend WithEvents IdCliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrénomsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SexeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SérieDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NMatriculeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DéchargéDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents NVérificationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Id_CliTextBox As TextBox
    Friend WithEvents NomTextBox As TextBox
    Friend WithEvents PrénomsTextBox As TextBox
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents SexeTextBox As TextBox
    Friend WithEvents TelTextBox As TextBox
    Friend WithEvents SérieTextBox As TextBox
    Friend WithEvents N_MatriculeTextBox As TextBox
    Friend WithEvents DéchargéCheckBox As CheckBox
    Friend WithEvents N_VérificationTextBox As TextBox
    Friend WithEvents TableAdapterManager As GestionsParkingsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button8 As Button
End Class
