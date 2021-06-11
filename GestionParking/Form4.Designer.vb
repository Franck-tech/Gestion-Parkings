<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim IdLabel As System.Windows.Forms.Label
        Dim NomLabel As System.Windows.Forms.Label
        Dim PrénomsLabel As System.Windows.Forms.Label
        Dim SexeLabel As System.Windows.Forms.Label
        Dim TéléphoneLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim Nom_UtilisateurLabel As System.Windows.Forms.Label
        Dim Mot_de_passeLabel As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.UtilisateursBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GestionsParkingsDataSet = New GestionParking.GestionsParkingsDataSet()
        Me.NomTextBox = New System.Windows.Forms.TextBox()
        Me.PrénomsTextBox = New System.Windows.Forms.TextBox()
        Me.SexeTextBox = New System.Windows.Forms.TextBox()
        Me.TéléphoneTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Nom_UtilisateurTextBox = New System.Windows.Forms.TextBox()
        Me.Mot_de_passeTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrénomsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TéléphoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomUtilisateurDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MotDePasseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.UtilisateursTableAdapter = New GestionParking.GestionsParkingsDataSetTableAdapters.UtilisateursTableAdapter()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.TableAdapterManager = New GestionParking.GestionsParkingsDataSetTableAdapters.TableAdapterManager()
        IdLabel = New System.Windows.Forms.Label()
        NomLabel = New System.Windows.Forms.Label()
        PrénomsLabel = New System.Windows.Forms.Label()
        SexeLabel = New System.Windows.Forms.Label()
        TéléphoneLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        Nom_UtilisateurLabel = New System.Windows.Forms.Label()
        Mot_de_passeLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.UtilisateursBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GestionsParkingsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.Location = New System.Drawing.Point(61, 70)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(27, 17)
        IdLabel.TabIndex = 16
        IdLabel.Text = "Id:"
        '
        'NomLabel
        '
        NomLabel.Location = New System.Drawing.Point(61, 100)
        NomLabel.Name = "NomLabel"
        NomLabel.Size = New System.Drawing.Size(43, 17)
        NomLabel.TabIndex = 18
        NomLabel.Text = "Nom:"
        '
        'PrénomsLabel
        '
        PrénomsLabel.Location = New System.Drawing.Point(61, 130)
        PrénomsLabel.Name = "PrénomsLabel"
        PrénomsLabel.Size = New System.Drawing.Size(70, 17)
        PrénomsLabel.TabIndex = 20
        PrénomsLabel.Text = "Prénoms:"
        '
        'SexeLabel
        '
        SexeLabel.Location = New System.Drawing.Point(61, 160)
        SexeLabel.Name = "SexeLabel"
        SexeLabel.Size = New System.Drawing.Size(42, 17)
        SexeLabel.TabIndex = 22
        SexeLabel.Text = "Sexe:"
        '
        'TéléphoneLabel
        '
        TéléphoneLabel.Location = New System.Drawing.Point(61, 190)
        TéléphoneLabel.Name = "TéléphoneLabel"
        TéléphoneLabel.Size = New System.Drawing.Size(78, 17)
        TéléphoneLabel.TabIndex = 24
        TéléphoneLabel.Text = "Téléphone:"
        '
        'EmailLabel
        '
        EmailLabel.Location = New System.Drawing.Point(61, 220)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(50, 17)
        EmailLabel.TabIndex = 26
        EmailLabel.Text = "Email:"
        '
        'Nom_UtilisateurLabel
        '
        Nom_UtilisateurLabel.Location = New System.Drawing.Point(61, 250)
        Nom_UtilisateurLabel.Name = "Nom_UtilisateurLabel"
        Nom_UtilisateurLabel.Size = New System.Drawing.Size(114, 17)
        Nom_UtilisateurLabel.TabIndex = 28
        Nom_UtilisateurLabel.Text = "Nom Utilisateur:"
        '
        'Mot_de_passeLabel
        '
        Mot_de_passeLabel.Location = New System.Drawing.Point(61, 280)
        Mot_de_passeLabel.Name = "Mot_de_passeLabel"
        Mot_de_passeLabel.Size = New System.Drawing.Size(93, 17)
        Mot_de_passeLabel.TabIndex = 30
        Mot_de_passeLabel.Text = "Mot de passe:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(IdLabel)
        Me.GroupBox1.Controls.Add(Me.IdTextBox)
        Me.GroupBox1.Controls.Add(NomLabel)
        Me.GroupBox1.Controls.Add(Me.NomTextBox)
        Me.GroupBox1.Controls.Add(PrénomsLabel)
        Me.GroupBox1.Controls.Add(Me.PrénomsTextBox)
        Me.GroupBox1.Controls.Add(SexeLabel)
        Me.GroupBox1.Controls.Add(Me.SexeTextBox)
        Me.GroupBox1.Controls.Add(TéléphoneLabel)
        Me.GroupBox1.Controls.Add(Me.TéléphoneTextBox)
        Me.GroupBox1.Controls.Add(EmailLabel)
        Me.GroupBox1.Controls.Add(Me.EmailTextBox)
        Me.GroupBox1.Controls.Add(Nom_UtilisateurLabel)
        Me.GroupBox1.Controls.Add(Me.Nom_UtilisateurTextBox)
        Me.GroupBox1.Controls.Add(Mot_de_passeLabel)
        Me.GroupBox1.Controls.Add(Me.Mot_de_passeTextBox)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Font = New System.Drawing.Font("Elephant", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.GroupBox1.Location = New System.Drawing.Point(12, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(531, 430)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enregistrement Utilisateur"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtilisateursBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(211, 67)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(289, 24)
        Me.IdTextBox.TabIndex = 17
        Me.IdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'UtilisateursBindingSource
        '
        Me.UtilisateursBindingSource.DataMember = "Utilisateurs"
        Me.UtilisateursBindingSource.DataSource = Me.GestionsParkingsDataSet
        '
        'GestionsParkingsDataSet
        '
        Me.GestionsParkingsDataSet.DataSetName = "GestionsParkingsDataSet"
        Me.GestionsParkingsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NomTextBox
        '
        Me.NomTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtilisateursBindingSource, "Nom", True))
        Me.NomTextBox.Location = New System.Drawing.Point(211, 97)
        Me.NomTextBox.Name = "NomTextBox"
        Me.NomTextBox.Size = New System.Drawing.Size(289, 24)
        Me.NomTextBox.TabIndex = 19
        Me.NomTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PrénomsTextBox
        '
        Me.PrénomsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtilisateursBindingSource, "Prénoms", True))
        Me.PrénomsTextBox.Location = New System.Drawing.Point(211, 127)
        Me.PrénomsTextBox.Name = "PrénomsTextBox"
        Me.PrénomsTextBox.Size = New System.Drawing.Size(289, 24)
        Me.PrénomsTextBox.TabIndex = 21
        Me.PrénomsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SexeTextBox
        '
        Me.SexeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtilisateursBindingSource, "Sexe", True))
        Me.SexeTextBox.Location = New System.Drawing.Point(211, 157)
        Me.SexeTextBox.Name = "SexeTextBox"
        Me.SexeTextBox.Size = New System.Drawing.Size(289, 24)
        Me.SexeTextBox.TabIndex = 23
        Me.SexeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TéléphoneTextBox
        '
        Me.TéléphoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtilisateursBindingSource, "Téléphone", True))
        Me.TéléphoneTextBox.Location = New System.Drawing.Point(211, 187)
        Me.TéléphoneTextBox.Name = "TéléphoneTextBox"
        Me.TéléphoneTextBox.Size = New System.Drawing.Size(289, 24)
        Me.TéléphoneTextBox.TabIndex = 25
        Me.TéléphoneTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtilisateursBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(211, 217)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(289, 24)
        Me.EmailTextBox.TabIndex = 27
        Me.EmailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Nom_UtilisateurTextBox
        '
        Me.Nom_UtilisateurTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtilisateursBindingSource, "Nom Utilisateur", True))
        Me.Nom_UtilisateurTextBox.Location = New System.Drawing.Point(211, 247)
        Me.Nom_UtilisateurTextBox.Name = "Nom_UtilisateurTextBox"
        Me.Nom_UtilisateurTextBox.Size = New System.Drawing.Size(289, 24)
        Me.Nom_UtilisateurTextBox.TabIndex = 29
        Me.Nom_UtilisateurTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Mot_de_passeTextBox
        '
        Me.Mot_de_passeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtilisateursBindingSource, "Mot de passe", True))
        Me.Mot_de_passeTextBox.Location = New System.Drawing.Point(211, 277)
        Me.Mot_de_passeTextBox.Name = "Mot_de_passeTextBox"
        Me.Mot_de_passeTextBox.Size = New System.Drawing.Size(289, 24)
        Me.Mot_de_passeTextBox.TabIndex = 31
        Me.Mot_de_passeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Image = Global.GestionParking.My.Resources.Resources.follow__1_
        Me.Button1.Location = New System.Drawing.Point(10, 374)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 31)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Ajouter"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button5.Image = Global.GestionParking.My.Resources.Resources.diskette__1_
        Me.Button5.Location = New System.Drawing.Point(151, 374)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(124, 31)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "Sauvegarder"
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button4.Image = Global.GestionParking.My.Resources.Resources.delete
        Me.Button4.Location = New System.Drawing.Point(406, 374)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(105, 31)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Supprimer"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Location = New System.Drawing.Point(295, 374)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 32)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Modifier"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Font = New System.Drawing.Font("Elephant", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.GroupBox2.Location = New System.Drawing.Point(529, 76)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(618, 430)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Liste Utilisateur"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NomDataGridViewTextBoxColumn, Me.PrénomsDataGridViewTextBoxColumn, Me.SexeDataGridViewTextBoxColumn, Me.TéléphoneDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.NomUtilisateurDataGridViewTextBoxColumn, Me.MotDePasseDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.UtilisateursBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(6, 51)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(608, 373)
        Me.DataGridView1.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
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
        'SexeDataGridViewTextBoxColumn
        '
        Me.SexeDataGridViewTextBoxColumn.DataPropertyName = "Sexe"
        Me.SexeDataGridViewTextBoxColumn.HeaderText = "Sexe"
        Me.SexeDataGridViewTextBoxColumn.Name = "SexeDataGridViewTextBoxColumn"
        '
        'TéléphoneDataGridViewTextBoxColumn
        '
        Me.TéléphoneDataGridViewTextBoxColumn.DataPropertyName = "Téléphone"
        Me.TéléphoneDataGridViewTextBoxColumn.HeaderText = "Téléphone"
        Me.TéléphoneDataGridViewTextBoxColumn.Name = "TéléphoneDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'NomUtilisateurDataGridViewTextBoxColumn
        '
        Me.NomUtilisateurDataGridViewTextBoxColumn.DataPropertyName = "Nom Utilisateur"
        Me.NomUtilisateurDataGridViewTextBoxColumn.HeaderText = "Nom Utilisateur"
        Me.NomUtilisateurDataGridViewTextBoxColumn.Name = "NomUtilisateurDataGridViewTextBoxColumn"
        '
        'MotDePasseDataGridViewTextBoxColumn
        '
        Me.MotDePasseDataGridViewTextBoxColumn.DataPropertyName = "Mot de passe"
        Me.MotDePasseDataGridViewTextBoxColumn.HeaderText = "Mot de passe"
        Me.MotDePasseDataGridViewTextBoxColumn.Name = "MotDePasseDataGridViewTextBoxColumn"
        '
        'Button3
        '
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button3.Image = Global.GestionParking.My.Resources.Resources.printer__1_
        Me.Button3.Location = New System.Drawing.Point(508, 13)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 32)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Imprimer"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Elephant", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(217, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(676, 38)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "COMPTE UTILISATEUR"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(918, 39)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(205, 20)
        Me.TextBox9.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Elephant", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(826, 39)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 19)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Filtrer"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UtilisateursTableAdapter
        '
        Me.UtilisateursTableAdapter.ClearBeforeFill = True
        '
        'Button7
        '
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Elephant", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Image = Global.GestionParking.My.Resources.Resources.funnel__1_
        Me.Button7.Location = New System.Drawing.Point(1106, 28)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(56, 45)
        Me.Button7.TabIndex = 11
        Me.Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button7.UseVisualStyleBackColor = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AutomobileTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientsTableAdapter = Nothing
        Me.TableAdapterManager.PayementTableAdapter = Nothing
        Me.TableAdapterManager.PayerTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = GestionParking.GestionsParkingsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UtilisateursTableAdapter = Me.UtilisateursTableAdapter
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(1174, 573)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.UtilisateursBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GestionsParkingsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents GestionsParkingsDataSet As GestionsParkingsDataSet
    Friend WithEvents UtilisateursBindingSource As BindingSource
    Friend WithEvents UtilisateursTableAdapter As GestionsParkingsDataSetTableAdapters.UtilisateursTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrénomsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SexeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TéléphoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomUtilisateurDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MotDePasseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents NomTextBox As TextBox
    Friend WithEvents PrénomsTextBox As TextBox
    Friend WithEvents SexeTextBox As TextBox
    Friend WithEvents TéléphoneTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents Nom_UtilisateurTextBox As TextBox
    Friend WithEvents Mot_de_passeTextBox As TextBox
    Friend WithEvents TableAdapterManager As GestionsParkingsDataSetTableAdapters.TableAdapterManager
End Class
