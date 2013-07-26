<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Y_GestioniUnita
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ImmobileLabel As System.Windows.Forms.Label
        Dim GestioneLabel As System.Windows.Forms.Label
        Dim UnitaLabel As System.Windows.Forms.Label
        Dim SaldoGestionePrecedenteLabel As System.Windows.Forms.Label
        Dim SpeseAddebitateLabel As System.Windows.Forms.Label
        Dim InteressiLabel As System.Windows.Forms.Label
        Dim SpesePersonaliLabel As System.Windows.Forms.Label
        Dim VersamentiLabel As System.Windows.Forms.Label
        Dim PreventivoAccontoLabel As System.Windows.Forms.Label
        Dim PreventivoProvvisorioLabel As System.Windows.Forms.Label
        Dim PreventivoSpesePersonaliLabel As System.Windows.Forms.Label
        Me.IMMOBILIDataSet = New Patrimonio2014.IMMOBILIDataSet()
        Me.Y_GestioniUnitaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Y_GestioniUnitaTableAdapter = New Patrimonio2014.IMMOBILIDataSetTableAdapters.Y_GestioniUnitaTableAdapter()
        Me.TableAdapterManager = New Patrimonio2014.IMMOBILIDataSetTableAdapters.TableAdapterManager()
        Me.ImmobileComboBox = New System.Windows.Forms.ComboBox()
        Me.GestioneComboBox = New System.Windows.Forms.ComboBox()
        Me.UnitaComboBox = New System.Windows.Forms.ComboBox()
        Me.SaldoGestionePrecedenteTextBox = New System.Windows.Forms.TextBox()
        Me.SpeseAddebitateTextBox = New System.Windows.Forms.TextBox()
        Me.InteressiTextBox = New System.Windows.Forms.TextBox()
        Me.SpesePersonaliTextBox = New System.Windows.Forms.TextBox()
        Me.VersamentiTextBox = New System.Windows.Forms.TextBox()
        Me.PreventivoAccontoTextBox = New System.Windows.Forms.TextBox()
        Me.PreventivoProvvisorioTextBox = New System.Windows.Forms.TextBox()
        Me.PreventivoSpesePersonaliTextBox = New System.Windows.Forms.TextBox()
        Me.Y_GestioniUnitaDettaglioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Y_GestioniUnitaDettaglioTableAdapter = New Patrimonio2014.IMMOBILIDataSetTableAdapters.Y_GestioniUnitaDettaglioTableAdapter()
        Me.Y_GestioniUnitaDettaglioDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        ImmobileLabel = New System.Windows.Forms.Label()
        GestioneLabel = New System.Windows.Forms.Label()
        UnitaLabel = New System.Windows.Forms.Label()
        SaldoGestionePrecedenteLabel = New System.Windows.Forms.Label()
        SpeseAddebitateLabel = New System.Windows.Forms.Label()
        InteressiLabel = New System.Windows.Forms.Label()
        SpesePersonaliLabel = New System.Windows.Forms.Label()
        VersamentiLabel = New System.Windows.Forms.Label()
        PreventivoAccontoLabel = New System.Windows.Forms.Label()
        PreventivoProvvisorioLabel = New System.Windows.Forms.Label()
        PreventivoSpesePersonaliLabel = New System.Windows.Forms.Label()
        CType(Me.IMMOBILIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Y_GestioniUnitaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Y_GestioniUnitaDettaglioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Y_GestioniUnitaDettaglioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IMMOBILIDataSet
        '
        Me.IMMOBILIDataSet.DataSetName = "IMMOBILIDataSet"
        Me.IMMOBILIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Y_GestioniUnitaBindingSource
        '
        Me.Y_GestioniUnitaBindingSource.DataMember = "Y_GestioniUnita"
        Me.Y_GestioniUnitaBindingSource.DataSource = Me.IMMOBILIDataSet
        '
        'Y_GestioniUnitaTableAdapter
        '
        Me.Y_GestioniUnitaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AnagraficaStudioTableAdapter = Nothing
        Me.TableAdapterManager.AnagraficheTableAdapter = Nothing
        Me.TableAdapterManager.AssembleaDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.AssembleaTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ContiFinanziariTableAdapter = Nothing
        Me.TableAdapterManager.CostantiDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.CostantiTableAdapter = Nothing
        Me.TableAdapterManager.FabbricatiTableAdapter = Nothing
        Me.TableAdapterManager.FondiTableAdapter = Nothing
        Me.TableAdapterManager.FornitoriTableAdapter = Nothing
        Me.TableAdapterManager.GruppiDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.GruppiTableAdapter = Nothing
        Me.TableAdapterManager.ImmobiliTableAdapter = Nothing
        Me.TableAdapterManager.OperatoriTableAdapter = Nothing
        Me.TableAdapterManager.PianoContiConsuntivoDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.PianoContiConsuntivoTableAdapter = Nothing
        Me.TableAdapterManager.PianoContiPreventivoDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.PianoContiPreventivoTableAdapter = Nothing
        Me.TableAdapterManager.ScaleTableAdapter = Nothing
        Me.TableAdapterManager.TabellaDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.TabellaTableAdapter = Nothing
        Me.TableAdapterManager.UnitaDettaglioAnagraficaTableAdapter = Nothing
        Me.TableAdapterManager.UnitaDettaglioLettureTableAdapter = Nothing
        Me.TableAdapterManager.UnitaDettaglioMillesimiTableAdapter = Nothing
        Me.TableAdapterManager.UnitaDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.UnitaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Patrimonio2014.IMMOBILIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.V_ConsuntivoDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.V_ConsuntivoTableAdapter = Nothing
        Me.TableAdapterManager.V_PreventivoDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.V_PreventivoTableAdapter = Nothing
        Me.TableAdapterManager.W_EmissioniDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.W_EmissioniTableAdapter = Nothing
        Me.TableAdapterManager.W_RitenuteTableAdapter = Nothing
        Me.TableAdapterManager.W_TributiTableAdapter = Nothing
        Me.TableAdapterManager.X_CausaliTableAdapter = Nothing
        Me.TableAdapterManager.X_FattureDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.X_FattureTableAdapter = Nothing
        Me.TableAdapterManager.X_MovimentiCondominiTableAdapter = Nothing
        Me.TableAdapterManager.X_MovimentiFinanziariTableAdapter = Nothing
        Me.TableAdapterManager.X_MovimentiFondiTableAdapter = Nothing
        Me.TableAdapterManager.X_SpeseDescrizioniTableAdapter = Nothing
        Me.TableAdapterManager.X_SpeseTableAdapter = Nothing
        Me.TableAdapterManager.Y_GestioniDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.Y_GestioniTableAdapter = Nothing
        Me.TableAdapterManager.Y_GestioniUnitaDettaglioTableAdapter = Me.Y_GestioniUnitaDettaglioTableAdapter
        Me.TableAdapterManager.Y_GestioniUnitaTableAdapter = Me.Y_GestioniUnitaTableAdapter
        Me.TableAdapterManager.Z_AvvisiDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.Z_AvvisiTableAdapter = Nothing
        Me.TableAdapterManager.Z_BilancioTableAdapter = Nothing
        Me.TableAdapterManager.Z_ConsuntivoDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.Z_ConsuntivoRipartoDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.Z_ConsuntivoRipartoTableAdapter = Nothing
        Me.TableAdapterManager.Z_ConsuntivoTableAdapter = Nothing
        Me.TableAdapterManager.Z_ConvocazioniDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.Z_ConvocazioniTableAdapter = Nothing
        Me.TableAdapterManager.Z_EmissioniTableAdapter = Nothing
        Me.TableAdapterManager.Z_EtichetteTableAdapter = Nothing
        Me.TableAdapterManager.Z_InteressiTableAdapter = Nothing
        Me.TableAdapterManager.Z_PreventivoRipartoDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.Z_PreventivoRipartoTableAdapter = Nothing
        Me.TableAdapterManager.Z_RaffrontoTableAdapter = Nothing
        Me.TableAdapterManager.Z_SaldoTableAdapter = Nothing
        Me.TableAdapterManager.Z_TestoSollecitoTableAdapter = Nothing
        Me.TableAdapterManager.ZZ_RipartoDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.ZZ_RipartoTableAdapter = Nothing
        '
        'ImmobileLabel
        '
        ImmobileLabel.AutoSize = True
        ImmobileLabel.Location = New System.Drawing.Point(12, 69)
        ImmobileLabel.Name = "ImmobileLabel"
        ImmobileLabel.Size = New System.Drawing.Size(51, 13)
        ImmobileLabel.TabIndex = 1
        ImmobileLabel.Text = "Immobile:"
        '
        'ImmobileComboBox
        '
        Me.ImmobileComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Y_GestioniUnitaBindingSource, "Immobile", True))
        Me.ImmobileComboBox.FormattingEnabled = True
        Me.ImmobileComboBox.Location = New System.Drawing.Point(12, 85)
        Me.ImmobileComboBox.Name = "ImmobileComboBox"
        Me.ImmobileComboBox.Size = New System.Drawing.Size(277, 21)
        Me.ImmobileComboBox.TabIndex = 2
        '
        'GestioneLabel
        '
        GestioneLabel.AutoSize = True
        GestioneLabel.Location = New System.Drawing.Point(292, 69)
        GestioneLabel.Name = "GestioneLabel"
        GestioneLabel.Size = New System.Drawing.Size(52, 13)
        GestioneLabel.TabIndex = 2
        GestioneLabel.Text = "Gestione:"
        '
        'GestioneComboBox
        '
        Me.GestioneComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Y_GestioniUnitaBindingSource, "Gestione", True))
        Me.GestioneComboBox.FormattingEnabled = True
        Me.GestioneComboBox.Location = New System.Drawing.Point(295, 85)
        Me.GestioneComboBox.Name = "GestioneComboBox"
        Me.GestioneComboBox.Size = New System.Drawing.Size(256, 21)
        Me.GestioneComboBox.TabIndex = 3
        '
        'UnitaLabel
        '
        UnitaLabel.AutoSize = True
        UnitaLabel.Location = New System.Drawing.Point(554, 69)
        UnitaLabel.Name = "UnitaLabel"
        UnitaLabel.Size = New System.Drawing.Size(35, 13)
        UnitaLabel.TabIndex = 4
        UnitaLabel.Text = "Unita:"
        '
        'UnitaComboBox
        '
        Me.UnitaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Y_GestioniUnitaBindingSource, "Unita", True))
        Me.UnitaComboBox.FormattingEnabled = True
        Me.UnitaComboBox.Location = New System.Drawing.Point(557, 85)
        Me.UnitaComboBox.Name = "UnitaComboBox"
        Me.UnitaComboBox.Size = New System.Drawing.Size(212, 21)
        Me.UnitaComboBox.TabIndex = 5
        '
        'SaldoGestionePrecedenteLabel
        '
        SaldoGestionePrecedenteLabel.AutoSize = True
        SaldoGestionePrecedenteLabel.Location = New System.Drawing.Point(12, 109)
        SaldoGestionePrecedenteLabel.Name = "SaldoGestionePrecedenteLabel"
        SaldoGestionePrecedenteLabel.Size = New System.Drawing.Size(122, 13)
        SaldoGestionePrecedenteLabel.TabIndex = 6
        SaldoGestionePrecedenteLabel.Text = "Saldo Gestione Preced.:"
        '
        'SaldoGestionePrecedenteTextBox
        '
        Me.SaldoGestionePrecedenteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Y_GestioniUnitaBindingSource, "SaldoGestionePrecedente", True))
        Me.SaldoGestionePrecedenteTextBox.Location = New System.Drawing.Point(15, 125)
        Me.SaldoGestionePrecedenteTextBox.Name = "SaldoGestionePrecedenteTextBox"
        Me.SaldoGestionePrecedenteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SaldoGestionePrecedenteTextBox.TabIndex = 7
        '
        'SpeseAddebitateLabel
        '
        SpeseAddebitateLabel.AutoSize = True
        SpeseAddebitateLabel.Location = New System.Drawing.Point(140, 109)
        SpeseAddebitateLabel.Name = "SpeseAddebitateLabel"
        SpeseAddebitateLabel.Size = New System.Drawing.Size(94, 13)
        SpeseAddebitateLabel.TabIndex = 8
        SpeseAddebitateLabel.Text = "Spese Addebitate:"
        '
        'SpeseAddebitateTextBox
        '
        Me.SpeseAddebitateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Y_GestioniUnitaBindingSource, "SpeseAddebitate", True))
        Me.SpeseAddebitateTextBox.Location = New System.Drawing.Point(143, 125)
        Me.SpeseAddebitateTextBox.Name = "SpeseAddebitateTextBox"
        Me.SpeseAddebitateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SpeseAddebitateTextBox.TabIndex = 9
        '
        'InteressiLabel
        '
        InteressiLabel.AutoSize = True
        InteressiLabel.Location = New System.Drawing.Point(264, 110)
        InteressiLabel.Name = "InteressiLabel"
        InteressiLabel.Size = New System.Drawing.Size(49, 13)
        InteressiLabel.TabIndex = 10
        InteressiLabel.Text = "Interessi:"
        '
        'InteressiTextBox
        '
        Me.InteressiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Y_GestioniUnitaBindingSource, "Interessi", True))
        Me.InteressiTextBox.Location = New System.Drawing.Point(267, 125)
        Me.InteressiTextBox.Name = "InteressiTextBox"
        Me.InteressiTextBox.Size = New System.Drawing.Size(100, 20)
        Me.InteressiTextBox.TabIndex = 11
        '
        'SpesePersonaliLabel
        '
        SpesePersonaliLabel.AutoSize = True
        SpesePersonaliLabel.Location = New System.Drawing.Point(381, 110)
        SpesePersonaliLabel.Name = "SpesePersonaliLabel"
        SpesePersonaliLabel.Size = New System.Drawing.Size(86, 13)
        SpesePersonaliLabel.TabIndex = 12
        SpesePersonaliLabel.Text = "Spese Personali:"
        '
        'SpesePersonaliTextBox
        '
        Me.SpesePersonaliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Y_GestioniUnitaBindingSource, "SpesePersonali", True))
        Me.SpesePersonaliTextBox.Location = New System.Drawing.Point(384, 126)
        Me.SpesePersonaliTextBox.Name = "SpesePersonaliTextBox"
        Me.SpesePersonaliTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SpesePersonaliTextBox.TabIndex = 13
        '
        'VersamentiLabel
        '
        VersamentiLabel.AutoSize = True
        VersamentiLabel.Location = New System.Drawing.Point(489, 109)
        VersamentiLabel.Name = "VersamentiLabel"
        VersamentiLabel.Size = New System.Drawing.Size(62, 13)
        VersamentiLabel.TabIndex = 14
        VersamentiLabel.Text = "Versamenti:"
        '
        'VersamentiTextBox
        '
        Me.VersamentiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Y_GestioniUnitaBindingSource, "Versamenti", True))
        Me.VersamentiTextBox.Location = New System.Drawing.Point(492, 125)
        Me.VersamentiTextBox.Name = "VersamentiTextBox"
        Me.VersamentiTextBox.Size = New System.Drawing.Size(100, 20)
        Me.VersamentiTextBox.TabIndex = 15
        '
        'PreventivoAccontoLabel
        '
        PreventivoAccontoLabel.AutoSize = True
        PreventivoAccontoLabel.Location = New System.Drawing.Point(12, 150)
        PreventivoAccontoLabel.Name = "PreventivoAccontoLabel"
        PreventivoAccontoLabel.Size = New System.Drawing.Size(104, 13)
        PreventivoAccontoLabel.TabIndex = 16
        PreventivoAccontoLabel.Text = "Preventivo Acconto:"
        '
        'PreventivoAccontoTextBox
        '
        Me.PreventivoAccontoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Y_GestioniUnitaBindingSource, "PreventivoAcconto", True))
        Me.PreventivoAccontoTextBox.Location = New System.Drawing.Point(15, 166)
        Me.PreventivoAccontoTextBox.Name = "PreventivoAccontoTextBox"
        Me.PreventivoAccontoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PreventivoAccontoTextBox.TabIndex = 17
        '
        'PreventivoProvvisorioLabel
        '
        PreventivoProvvisorioLabel.AutoSize = True
        PreventivoProvvisorioLabel.Location = New System.Drawing.Point(140, 148)
        PreventivoProvvisorioLabel.Name = "PreventivoProvvisorioLabel"
        PreventivoProvvisorioLabel.Size = New System.Drawing.Size(116, 13)
        PreventivoProvvisorioLabel.TabIndex = 18
        PreventivoProvvisorioLabel.Text = "Preventivo Provvisorio:"
        '
        'PreventivoProvvisorioTextBox
        '
        Me.PreventivoProvvisorioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Y_GestioniUnitaBindingSource, "PreventivoProvvisorio", True))
        Me.PreventivoProvvisorioTextBox.Location = New System.Drawing.Point(143, 164)
        Me.PreventivoProvvisorioTextBox.Name = "PreventivoProvvisorioTextBox"
        Me.PreventivoProvvisorioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PreventivoProvvisorioTextBox.TabIndex = 19
        '
        'PreventivoSpesePersonaliLabel
        '
        PreventivoSpesePersonaliLabel.AutoSize = True
        PreventivoSpesePersonaliLabel.Location = New System.Drawing.Point(264, 150)
        PreventivoSpesePersonaliLabel.Name = "PreventivoSpesePersonaliLabel"
        PreventivoSpesePersonaliLabel.Size = New System.Drawing.Size(140, 13)
        PreventivoSpesePersonaliLabel.TabIndex = 20
        PreventivoSpesePersonaliLabel.Text = "Preventivo Spese Personali:"
        '
        'PreventivoSpesePersonaliTextBox
        '
        Me.PreventivoSpesePersonaliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Y_GestioniUnitaBindingSource, "PreventivoSpesePersonali", True))
        Me.PreventivoSpesePersonaliTextBox.Location = New System.Drawing.Point(267, 166)
        Me.PreventivoSpesePersonaliTextBox.Name = "PreventivoSpesePersonaliTextBox"
        Me.PreventivoSpesePersonaliTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PreventivoSpesePersonaliTextBox.TabIndex = 21
        '
        'Y_GestioniUnitaDettaglioBindingSource
        '
        Me.Y_GestioniUnitaDettaglioBindingSource.DataMember = "Y_GestioniUnitaDettaglio"
        Me.Y_GestioniUnitaDettaglioBindingSource.DataSource = Me.IMMOBILIDataSet
        '
        'Y_GestioniUnitaDettaglioTableAdapter
        '
        Me.Y_GestioniUnitaDettaglioTableAdapter.ClearBeforeFill = True
        '
        'Y_GestioniUnitaDettaglioDataGridView
        '
        Me.Y_GestioniUnitaDettaglioDataGridView.AutoGenerateColumns = False
        Me.Y_GestioniUnitaDettaglioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Y_GestioniUnitaDettaglioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.Y_GestioniUnitaDettaglioDataGridView.DataSource = Me.Y_GestioniUnitaDettaglioBindingSource
        Me.Y_GestioniUnitaDettaglioDataGridView.Location = New System.Drawing.Point(12, 202)
        Me.Y_GestioniUnitaDettaglioDataGridView.Name = "Y_GestioniUnitaDettaglioDataGridView"
        Me.Y_GestioniUnitaDettaglioDataGridView.Size = New System.Drawing.Size(638, 220)
        Me.Y_GestioniUnitaDettaglioDataGridView.TabIndex = 22
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Unita"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Unita"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 200
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Riga"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Riga"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Rata"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Rata"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Y_GestioniUnita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(842, 468)
        Me.Controls.Add(Me.Y_GestioniUnitaDettaglioDataGridView)
        Me.Controls.Add(PreventivoSpesePersonaliLabel)
        Me.Controls.Add(Me.PreventivoSpesePersonaliTextBox)
        Me.Controls.Add(PreventivoProvvisorioLabel)
        Me.Controls.Add(Me.PreventivoProvvisorioTextBox)
        Me.Controls.Add(PreventivoAccontoLabel)
        Me.Controls.Add(Me.PreventivoAccontoTextBox)
        Me.Controls.Add(VersamentiLabel)
        Me.Controls.Add(Me.VersamentiTextBox)
        Me.Controls.Add(SpesePersonaliLabel)
        Me.Controls.Add(Me.SpesePersonaliTextBox)
        Me.Controls.Add(InteressiLabel)
        Me.Controls.Add(Me.InteressiTextBox)
        Me.Controls.Add(SpeseAddebitateLabel)
        Me.Controls.Add(Me.SpeseAddebitateTextBox)
        Me.Controls.Add(SaldoGestionePrecedenteLabel)
        Me.Controls.Add(Me.SaldoGestionePrecedenteTextBox)
        Me.Controls.Add(UnitaLabel)
        Me.Controls.Add(Me.UnitaComboBox)
        Me.Controls.Add(GestioneLabel)
        Me.Controls.Add(Me.GestioneComboBox)
        Me.Controls.Add(ImmobileLabel)
        Me.Controls.Add(Me.ImmobileComboBox)
        Me.Name = "Y_GestioniUnita"
        Me.Text = "Storico Gestioni Unita' Immobiliari"
        CType(Me.IMMOBILIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Y_GestioniUnitaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Y_GestioniUnitaDettaglioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Y_GestioniUnitaDettaglioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IMMOBILIDataSet As Patrimonio2014.IMMOBILIDataSet
    Friend WithEvents Y_GestioniUnitaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Y_GestioniUnitaTableAdapter As Patrimonio2014.IMMOBILIDataSetTableAdapters.Y_GestioniUnitaTableAdapter
    Friend WithEvents TableAdapterManager As Patrimonio2014.IMMOBILIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Y_GestioniUnitaDettaglioTableAdapter As Patrimonio2014.IMMOBILIDataSetTableAdapters.Y_GestioniUnitaDettaglioTableAdapter
    Friend WithEvents ImmobileComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GestioneComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents UnitaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SaldoGestionePrecedenteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SpeseAddebitateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InteressiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SpesePersonaliTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VersamentiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PreventivoAccontoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PreventivoProvvisorioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PreventivoSpesePersonaliTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Y_GestioniUnitaDettaglioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Y_GestioniUnitaDettaglioDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
