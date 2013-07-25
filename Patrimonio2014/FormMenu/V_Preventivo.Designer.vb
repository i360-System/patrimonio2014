<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class V_Preventivo
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
        Dim GruppoLabel As System.Windows.Forms.Label
        Dim SpesaLabel As System.Windows.Forms.Label
        Dim PianoContiLabel As System.Windows.Forms.Label
        Dim ImportoLabel As System.Windows.Forms.Label
        Me.IMMOBILIDataSet = New Patrimonio2014.IMMOBILIDataSet()
        Me.V_PreventivoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.V_PreventivoTableAdapter = New Patrimonio2014.IMMOBILIDataSetTableAdapters.V_PreventivoTableAdapter()
        Me.TableAdapterManager = New Patrimonio2014.IMMOBILIDataSetTableAdapters.TableAdapterManager()
        Me.ImmobileComboBox = New System.Windows.Forms.ComboBox()
        Me.GestioneComboBox = New System.Windows.Forms.ComboBox()
        Me.GruppoComboBox = New System.Windows.Forms.ComboBox()
        Me.SpesaComboBox = New System.Windows.Forms.ComboBox()
        Me.PianoContiComboBox = New System.Windows.Forms.ComboBox()
        Me.ImportoTextBox = New System.Windows.Forms.TextBox()
        Me.V_PreventivoDettaglioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.V_PreventivoDettaglioTableAdapter = New Patrimonio2014.IMMOBILIDataSetTableAdapters.V_PreventivoDettaglioTableAdapter()
        Me.V_PreventivoDettaglioDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        ImmobileLabel = New System.Windows.Forms.Label()
        GestioneLabel = New System.Windows.Forms.Label()
        GruppoLabel = New System.Windows.Forms.Label()
        SpesaLabel = New System.Windows.Forms.Label()
        PianoContiLabel = New System.Windows.Forms.Label()
        ImportoLabel = New System.Windows.Forms.Label()
        CType(Me.IMMOBILIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.V_PreventivoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.V_PreventivoDettaglioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.V_PreventivoDettaglioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IMMOBILIDataSet
        '
        Me.IMMOBILIDataSet.DataSetName = "IMMOBILIDataSet"
        Me.IMMOBILIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'V_PreventivoBindingSource
        '
        Me.V_PreventivoBindingSource.DataMember = "V_Preventivo"
        Me.V_PreventivoBindingSource.DataSource = Me.IMMOBILIDataSet
        '
        'V_PreventivoTableAdapter
        '
        Me.V_PreventivoTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.V_PreventivoDettaglioTableAdapter = Me.V_PreventivoDettaglioTableAdapter
        Me.TableAdapterManager.V_PreventivoTableAdapter = Me.V_PreventivoTableAdapter
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
        Me.TableAdapterManager.Y_GestioniUnitaDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.Y_GestioniUnitaTableAdapter = Nothing
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
        ImmobileLabel.Location = New System.Drawing.Point(12, 55)
        ImmobileLabel.Name = "ImmobileLabel"
        ImmobileLabel.Size = New System.Drawing.Size(51, 13)
        ImmobileLabel.TabIndex = 0
        ImmobileLabel.Text = "Immobile:"
        '
        'ImmobileComboBox
        '
        Me.ImmobileComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.V_PreventivoBindingSource, "Immobile", True))
        Me.ImmobileComboBox.FormattingEnabled = True
        Me.ImmobileComboBox.Location = New System.Drawing.Point(15, 71)
        Me.ImmobileComboBox.Name = "ImmobileComboBox"
        Me.ImmobileComboBox.Size = New System.Drawing.Size(274, 21)
        Me.ImmobileComboBox.TabIndex = 1
        '
        'GestioneLabel
        '
        GestioneLabel.AutoSize = True
        GestioneLabel.Location = New System.Drawing.Point(304, 55)
        GestioneLabel.Name = "GestioneLabel"
        GestioneLabel.Size = New System.Drawing.Size(52, 13)
        GestioneLabel.TabIndex = 2
        GestioneLabel.Text = "Gestione:"
        '
        'GestioneComboBox
        '
        Me.GestioneComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.V_PreventivoBindingSource, "Gestione", True))
        Me.GestioneComboBox.FormattingEnabled = True
        Me.GestioneComboBox.Location = New System.Drawing.Point(307, 71)
        Me.GestioneComboBox.Name = "GestioneComboBox"
        Me.GestioneComboBox.Size = New System.Drawing.Size(261, 21)
        Me.GestioneComboBox.TabIndex = 3
        '
        'GruppoLabel
        '
        GruppoLabel.AutoSize = True
        GruppoLabel.Location = New System.Drawing.Point(12, 105)
        GruppoLabel.Name = "GruppoLabel"
        GruppoLabel.Size = New System.Drawing.Size(45, 13)
        GruppoLabel.TabIndex = 4
        GruppoLabel.Text = "Gruppo:"
        '
        'GruppoComboBox
        '
        Me.GruppoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.V_PreventivoBindingSource, "Gruppo", True))
        Me.GruppoComboBox.FormattingEnabled = True
        Me.GruppoComboBox.Location = New System.Drawing.Point(15, 121)
        Me.GruppoComboBox.Name = "GruppoComboBox"
        Me.GruppoComboBox.Size = New System.Drawing.Size(274, 21)
        Me.GruppoComboBox.TabIndex = 5
        '
        'SpesaLabel
        '
        SpesaLabel.AutoSize = True
        SpesaLabel.Location = New System.Drawing.Point(304, 105)
        SpesaLabel.Name = "SpesaLabel"
        SpesaLabel.Size = New System.Drawing.Size(40, 13)
        SpesaLabel.TabIndex = 6
        SpesaLabel.Text = "Spesa:"
        '
        'SpesaComboBox
        '
        Me.SpesaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.V_PreventivoBindingSource, "Spesa", True))
        Me.SpesaComboBox.FormattingEnabled = True
        Me.SpesaComboBox.Location = New System.Drawing.Point(307, 121)
        Me.SpesaComboBox.Name = "SpesaComboBox"
        Me.SpesaComboBox.Size = New System.Drawing.Size(261, 21)
        Me.SpesaComboBox.TabIndex = 7
        '
        'PianoContiLabel
        '
        PianoContiLabel.AutoSize = True
        PianoContiLabel.Location = New System.Drawing.Point(583, 55)
        PianoContiLabel.Name = "PianoContiLabel"
        PianoContiLabel.Size = New System.Drawing.Size(64, 13)
        PianoContiLabel.TabIndex = 8
        PianoContiLabel.Text = "Piano Conti:"
        '
        'PianoContiComboBox
        '
        Me.PianoContiComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.V_PreventivoBindingSource, "PianoConti", True))
        Me.PianoContiComboBox.FormattingEnabled = True
        Me.PianoContiComboBox.Location = New System.Drawing.Point(586, 71)
        Me.PianoContiComboBox.Name = "PianoContiComboBox"
        Me.PianoContiComboBox.Size = New System.Drawing.Size(211, 21)
        Me.PianoContiComboBox.TabIndex = 9
        '
        'ImportoLabel
        '
        ImportoLabel.AutoSize = True
        ImportoLabel.Location = New System.Drawing.Point(583, 105)
        ImportoLabel.Name = "ImportoLabel"
        ImportoLabel.Size = New System.Drawing.Size(45, 13)
        ImportoLabel.TabIndex = 10
        ImportoLabel.Text = "Importo:"
        '
        'ImportoTextBox
        '
        Me.ImportoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.V_PreventivoBindingSource, "Importo", True))
        Me.ImportoTextBox.Location = New System.Drawing.Point(586, 121)
        Me.ImportoTextBox.Name = "ImportoTextBox"
        Me.ImportoTextBox.Size = New System.Drawing.Size(123, 20)
        Me.ImportoTextBox.TabIndex = 11
        '
        'V_PreventivoDettaglioBindingSource
        '
        Me.V_PreventivoDettaglioBindingSource.DataMember = "V_PreventivoDettaglio"
        Me.V_PreventivoDettaglioBindingSource.DataSource = Me.IMMOBILIDataSet
        '
        'V_PreventivoDettaglioTableAdapter
        '
        Me.V_PreventivoDettaglioTableAdapter.ClearBeforeFill = True
        '
        'V_PreventivoDettaglioDataGridView
        '
        Me.V_PreventivoDettaglioDataGridView.AutoGenerateColumns = False
        Me.V_PreventivoDettaglioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.V_PreventivoDettaglioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.V_PreventivoDettaglioDataGridView.DataSource = Me.V_PreventivoDettaglioBindingSource
        Me.V_PreventivoDettaglioDataGridView.Location = New System.Drawing.Point(17, 168)
        Me.V_PreventivoDettaglioDataGridView.Name = "V_PreventivoDettaglioDataGridView"
        Me.V_PreventivoDettaglioDataGridView.Size = New System.Drawing.Size(570, 220)
        Me.V_PreventivoDettaglioDataGridView.TabIndex = 12
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Fabbricato"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Fabbricato"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 200
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Scala"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Scala"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 200
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Importo"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Importo"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'V_Preventivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 427)
        Me.Controls.Add(Me.V_PreventivoDettaglioDataGridView)
        Me.Controls.Add(ImportoLabel)
        Me.Controls.Add(Me.ImportoTextBox)
        Me.Controls.Add(PianoContiLabel)
        Me.Controls.Add(Me.PianoContiComboBox)
        Me.Controls.Add(SpesaLabel)
        Me.Controls.Add(Me.SpesaComboBox)
        Me.Controls.Add(GruppoLabel)
        Me.Controls.Add(Me.GruppoComboBox)
        Me.Controls.Add(GestioneLabel)
        Me.Controls.Add(Me.GestioneComboBox)
        Me.Controls.Add(ImmobileLabel)
        Me.Controls.Add(Me.ImmobileComboBox)
        Me.Name = "V_Preventivo"
        Me.Text = "Dati del Preventivo"
        CType(Me.IMMOBILIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.V_PreventivoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.V_PreventivoDettaglioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.V_PreventivoDettaglioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IMMOBILIDataSet As Patrimonio2014.IMMOBILIDataSet
    Friend WithEvents V_PreventivoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents V_PreventivoTableAdapter As Patrimonio2014.IMMOBILIDataSetTableAdapters.V_PreventivoTableAdapter
    Friend WithEvents TableAdapterManager As Patrimonio2014.IMMOBILIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents V_PreventivoDettaglioTableAdapter As Patrimonio2014.IMMOBILIDataSetTableAdapters.V_PreventivoDettaglioTableAdapter
    Friend WithEvents ImmobileComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GestioneComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GruppoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SpesaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PianoContiComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ImportoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents V_PreventivoDettaglioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents V_PreventivoDettaglioDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
