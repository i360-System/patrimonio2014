<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Y_Gestioni
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
        Dim Descrizione1Label As System.Windows.Forms.Label
        Dim TipoLabel As System.Windows.Forms.Label
        Dim DataInizioLabel As System.Windows.Forms.Label
        Dim DataTermineLabel As System.Windows.Forms.Label
        Dim TabellaLabel As System.Windows.Forms.Label
        Dim ImportoMinimoLabel As System.Windows.Forms.Label
        Dim ImportoMassimoLabel As System.Windows.Forms.Label
        Dim StoricoLabel As System.Windows.Forms.Label
        Dim GruppoAccontoLabel As System.Windows.Forms.Label
        Dim PercentoAccontoLabel As System.Windows.Forms.Label
        Dim GestioneSuccessivaLabel As System.Windows.Forms.Label
        Dim GestioneCollegataLabel As System.Windows.Forms.Label
        Dim PreventivoConfermatoLabel As System.Windows.Forms.Label
        Me.IMMOBILIDataSet = New Patrimonio2014.IMMOBILIDataSet()
        Me.Y_GestioniBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Y_GestioniTableAdapter = New Patrimonio2014.IMMOBILIDataSetTableAdapters.Y_GestioniTableAdapter()
        Me.TableAdapterManager = New Patrimonio2014.IMMOBILIDataSetTableAdapters.TableAdapterManager()
        Me.Y_GestioniDettaglioTableAdapter = New Patrimonio2014.IMMOBILIDataSetTableAdapters.Y_GestioniDettaglioTableAdapter()
        Me.ImmobileComboBox = New System.Windows.Forms.ComboBox()
        Me.GestioneComboBox = New System.Windows.Forms.ComboBox()
        Me.Descrizione1TextBox = New System.Windows.Forms.TextBox()
        Me.Descrizione2TextBox = New System.Windows.Forms.TextBox()
        Me.TipoTextBox = New System.Windows.Forms.TextBox()
        Me.DataInizioDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DataTermineDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TabellaComboBox = New System.Windows.Forms.ComboBox()
        Me.ImportoMinimoTextBox = New System.Windows.Forms.TextBox()
        Me.ImportoMassimoTextBox = New System.Windows.Forms.TextBox()
        Me.StoricoTextBox = New System.Windows.Forms.TextBox()
        Me.GruppoAccontoTextBox = New System.Windows.Forms.TextBox()
        Me.PercentoAccontoTextBox = New System.Windows.Forms.TextBox()
        Me.GestioneSuccessivaTextBox = New System.Windows.Forms.TextBox()
        Me.GestioneCollegataTextBox = New System.Windows.Forms.TextBox()
        Me.PreventivoConfermatoTextBox = New System.Windows.Forms.TextBox()
        Me.Y_GestioniDettaglioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Y_GestioniDettaglioDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        ImmobileLabel = New System.Windows.Forms.Label()
        GestioneLabel = New System.Windows.Forms.Label()
        Descrizione1Label = New System.Windows.Forms.Label()
        TipoLabel = New System.Windows.Forms.Label()
        DataInizioLabel = New System.Windows.Forms.Label()
        DataTermineLabel = New System.Windows.Forms.Label()
        TabellaLabel = New System.Windows.Forms.Label()
        ImportoMinimoLabel = New System.Windows.Forms.Label()
        ImportoMassimoLabel = New System.Windows.Forms.Label()
        StoricoLabel = New System.Windows.Forms.Label()
        GruppoAccontoLabel = New System.Windows.Forms.Label()
        PercentoAccontoLabel = New System.Windows.Forms.Label()
        GestioneSuccessivaLabel = New System.Windows.Forms.Label()
        GestioneCollegataLabel = New System.Windows.Forms.Label()
        PreventivoConfermatoLabel = New System.Windows.Forms.Label()
        CType(Me.IMMOBILIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Y_GestioniBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Y_GestioniDettaglioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Y_GestioniDettaglioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImmobileLabel
        '
        ImmobileLabel.AutoSize = True
        ImmobileLabel.Location = New System.Drawing.Point(12, 59)
        ImmobileLabel.Name = "ImmobileLabel"
        ImmobileLabel.Size = New System.Drawing.Size(51, 13)
        ImmobileLabel.TabIndex = 1
        ImmobileLabel.Text = "Immobile:"
        '
        'GestioneLabel
        '
        GestioneLabel.AutoSize = True
        GestioneLabel.Location = New System.Drawing.Point(396, 59)
        GestioneLabel.Name = "GestioneLabel"
        GestioneLabel.Size = New System.Drawing.Size(52, 13)
        GestioneLabel.TabIndex = 2
        GestioneLabel.Text = "Gestione:"
        '
        'Descrizione1Label
        '
        Descrizione1Label.AutoSize = True
        Descrizione1Label.Location = New System.Drawing.Point(12, 99)
        Descrizione1Label.Name = "Descrizione1Label"
        Descrizione1Label.Size = New System.Drawing.Size(65, 13)
        Descrizione1Label.TabIndex = 4
        Descrizione1Label.Text = "Descrizione:"
        '
        'TipoLabel
        '
        TipoLabel.AutoSize = True
        TipoLabel.Location = New System.Drawing.Point(396, 99)
        TipoLabel.Name = "TipoLabel"
        TipoLabel.Size = New System.Drawing.Size(31, 13)
        TipoLabel.TabIndex = 7
        TipoLabel.Text = "Tipo:"
        '
        'DataInizioLabel
        '
        DataInizioLabel.AutoSize = True
        DataInizioLabel.Location = New System.Drawing.Point(444, 99)
        DataInizioLabel.Name = "DataInizioLabel"
        DataInizioLabel.Size = New System.Drawing.Size(60, 13)
        DataInizioLabel.TabIndex = 9
        DataInizioLabel.Text = "Data Inizio:"
        '
        'DataTermineLabel
        '
        DataTermineLabel.AutoSize = True
        DataTermineLabel.Location = New System.Drawing.Point(554, 99)
        DataTermineLabel.Name = "DataTermineLabel"
        DataTermineLabel.Size = New System.Drawing.Size(74, 13)
        DataTermineLabel.TabIndex = 11
        DataTermineLabel.Text = "Data Termine:"
        '
        'TabellaLabel
        '
        TabellaLabel.AutoSize = True
        TabellaLabel.Location = New System.Drawing.Point(653, 99)
        TabellaLabel.Name = "TabellaLabel"
        TabellaLabel.Size = New System.Drawing.Size(48, 13)
        TabellaLabel.TabIndex = 13
        TabellaLabel.Text = "Costanti:"
        '
        'ImportoMinimoLabel
        '
        ImportoMinimoLabel.AutoSize = True
        ImportoMinimoLabel.Location = New System.Drawing.Point(12, 190)
        ImportoMinimoLabel.Name = "ImportoMinimoLabel"
        ImportoMinimoLabel.Size = New System.Drawing.Size(81, 13)
        ImportoMinimoLabel.TabIndex = 15
        ImportoMinimoLabel.Text = "Importo Minimo:"
        '
        'ImportoMassimoLabel
        '
        ImportoMassimoLabel.AutoSize = True
        ImportoMassimoLabel.Location = New System.Drawing.Point(121, 190)
        ImportoMassimoLabel.Name = "ImportoMassimoLabel"
        ImportoMassimoLabel.Size = New System.Drawing.Size(89, 13)
        ImportoMassimoLabel.TabIndex = 17
        ImportoMassimoLabel.Text = "Importo Massimo:"
        '
        'StoricoLabel
        '
        StoricoLabel.AutoSize = True
        StoricoLabel.Location = New System.Drawing.Point(230, 190)
        StoricoLabel.Name = "StoricoLabel"
        StoricoLabel.Size = New System.Drawing.Size(43, 13)
        StoricoLabel.TabIndex = 19
        StoricoLabel.Text = "Storico:"
        '
        'GruppoAccontoLabel
        '
        GruppoAccontoLabel.AutoSize = True
        GruppoAccontoLabel.Location = New System.Drawing.Point(284, 190)
        GruppoAccontoLabel.Name = "GruppoAccontoLabel"
        GruppoAccontoLabel.Size = New System.Drawing.Size(88, 13)
        GruppoAccontoLabel.TabIndex = 21
        GruppoAccontoLabel.Text = "Gruppo Acconto:"
        '
        'PercentoAccontoLabel
        '
        PercentoAccontoLabel.AutoSize = True
        PercentoAccontoLabel.Location = New System.Drawing.Point(378, 190)
        PercentoAccontoLabel.Name = "PercentoAccontoLabel"
        PercentoAccontoLabel.Size = New System.Drawing.Size(61, 13)
        PercentoAccontoLabel.TabIndex = 23
        PercentoAccontoLabel.Text = "% Acconto:"
        '
        'GestioneSuccessivaLabel
        '
        GestioneSuccessivaLabel.AutoSize = True
        GestioneSuccessivaLabel.Location = New System.Drawing.Point(445, 190)
        GestioneSuccessivaLabel.Name = "GestioneSuccessivaLabel"
        GestioneSuccessivaLabel.Size = New System.Drawing.Size(110, 13)
        GestioneSuccessivaLabel.TabIndex = 25
        GestioneSuccessivaLabel.Text = "Gestione Successiva:"
        '
        'GestioneCollegataLabel
        '
        GestioneCollegataLabel.AutoSize = True
        GestioneCollegataLabel.Location = New System.Drawing.Point(561, 190)
        GestioneCollegataLabel.Name = "GestioneCollegataLabel"
        GestioneCollegataLabel.Size = New System.Drawing.Size(99, 13)
        GestioneCollegataLabel.TabIndex = 27
        GestioneCollegataLabel.Text = "Gestione Collegata:"
        '
        'PreventivoConfermatoLabel
        '
        PreventivoConfermatoLabel.AutoSize = True
        PreventivoConfermatoLabel.Location = New System.Drawing.Point(666, 190)
        PreventivoConfermatoLabel.Name = "PreventivoConfermatoLabel"
        PreventivoConfermatoLabel.Size = New System.Drawing.Size(118, 13)
        PreventivoConfermatoLabel.TabIndex = 29
        PreventivoConfermatoLabel.Text = "Preventivo Confermato:"
        '
        'IMMOBILIDataSet
        '
        Me.IMMOBILIDataSet.DataSetName = "IMMOBILIDataSet"
        Me.IMMOBILIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Y_GestioniBindingSource
        '
        Me.Y_GestioniBindingSource.DataMember = "Y_Gestioni"
        Me.Y_GestioniBindingSource.DataSource = Me.IMMOBILIDataSet
        '
        'Y_GestioniTableAdapter
        '
        Me.Y_GestioniTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Y_GestioniDettaglioTableAdapter = Me.Y_GestioniDettaglioTableAdapter
        Me.TableAdapterManager.Y_GestioniTableAdapter = Me.Y_GestioniTableAdapter
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
        'Y_GestioniDettaglioTableAdapter
        '
        Me.Y_GestioniDettaglioTableAdapter.ClearBeforeFill = True
        '
        'ImmobileComboBox
        '
        Me.ImmobileComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Y_GestioniBindingSource, "Immobile", True))
        Me.ImmobileComboBox.FormattingEnabled = True
        Me.ImmobileComboBox.Location = New System.Drawing.Point(15, 75)
        Me.ImmobileComboBox.Name = "ImmobileComboBox"
        Me.ImmobileComboBox.Size = New System.Drawing.Size(368, 21)
        Me.ImmobileComboBox.TabIndex = 2
        '
        'GestioneComboBox
        '
        Me.GestioneComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Y_GestioniBindingSource, "Gestione", True))
        Me.GestioneComboBox.FormattingEnabled = True
        Me.GestioneComboBox.Location = New System.Drawing.Point(399, 75)
        Me.GestioneComboBox.Name = "GestioneComboBox"
        Me.GestioneComboBox.Size = New System.Drawing.Size(385, 21)
        Me.GestioneComboBox.TabIndex = 3
        '
        'Descrizione1TextBox
        '
        Me.Descrizione1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Y_GestioniBindingSource, "Descrizione1", True))
        Me.Descrizione1TextBox.Location = New System.Drawing.Point(15, 115)
        Me.Descrizione1TextBox.Name = "Descrizione1TextBox"
        Me.Descrizione1TextBox.Size = New System.Drawing.Size(368, 20)
        Me.Descrizione1TextBox.TabIndex = 5
        '
        'Descrizione2TextBox
        '
        Me.Descrizione2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Y_GestioniBindingSource, "Descrizione2", True))
        Me.Descrizione2TextBox.Location = New System.Drawing.Point(15, 157)
        Me.Descrizione2TextBox.Name = "Descrizione2TextBox"
        Me.Descrizione2TextBox.Size = New System.Drawing.Size(368, 20)
        Me.Descrizione2TextBox.TabIndex = 7
        '
        'TipoTextBox
        '
        Me.TipoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Y_GestioniBindingSource, "Tipo", True))
        Me.TipoTextBox.Location = New System.Drawing.Point(399, 115)
        Me.TipoTextBox.Name = "TipoTextBox"
        Me.TipoTextBox.Size = New System.Drawing.Size(39, 20)
        Me.TipoTextBox.TabIndex = 8
        '
        'DataInizioDateTimePicker
        '
        Me.DataInizioDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Y_GestioniBindingSource, "DataInizio", True))
        Me.DataInizioDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataInizioDateTimePicker.Location = New System.Drawing.Point(447, 115)
        Me.DataInizioDateTimePicker.Name = "DataInizioDateTimePicker"
        Me.DataInizioDateTimePicker.Size = New System.Drawing.Size(101, 20)
        Me.DataInizioDateTimePicker.TabIndex = 10
        '
        'DataTermineDateTimePicker
        '
        Me.DataTermineDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Y_GestioniBindingSource, "DataTermine", True))
        Me.DataTermineDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataTermineDateTimePicker.Location = New System.Drawing.Point(554, 115)
        Me.DataTermineDateTimePicker.Name = "DataTermineDateTimePicker"
        Me.DataTermineDateTimePicker.Size = New System.Drawing.Size(97, 20)
        Me.DataTermineDateTimePicker.TabIndex = 12
        '
        'TabellaComboBox
        '
        Me.TabellaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Y_GestioniBindingSource, "Tabella", True))
        Me.TabellaComboBox.FormattingEnabled = True
        Me.TabellaComboBox.Location = New System.Drawing.Point(656, 114)
        Me.TabellaComboBox.Name = "TabellaComboBox"
        Me.TabellaComboBox.Size = New System.Drawing.Size(128, 21)
        Me.TabellaComboBox.TabIndex = 14
        '
        'ImportoMinimoTextBox
        '
        Me.ImportoMinimoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Y_GestioniBindingSource, "ImportoMinimo", True))
        Me.ImportoMinimoTextBox.Location = New System.Drawing.Point(15, 206)
        Me.ImportoMinimoTextBox.Name = "ImportoMinimoTextBox"
        Me.ImportoMinimoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ImportoMinimoTextBox.TabIndex = 16
        '
        'ImportoMassimoTextBox
        '
        Me.ImportoMassimoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Y_GestioniBindingSource, "ImportoMassimo", True))
        Me.ImportoMassimoTextBox.Location = New System.Drawing.Point(124, 206)
        Me.ImportoMassimoTextBox.Name = "ImportoMassimoTextBox"
        Me.ImportoMassimoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ImportoMassimoTextBox.TabIndex = 18
        '
        'StoricoTextBox
        '
        Me.StoricoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Y_GestioniBindingSource, "Storico", True))
        Me.StoricoTextBox.Location = New System.Drawing.Point(233, 206)
        Me.StoricoTextBox.Name = "StoricoTextBox"
        Me.StoricoTextBox.Size = New System.Drawing.Size(30, 20)
        Me.StoricoTextBox.TabIndex = 20
        '
        'GruppoAccontoTextBox
        '
        Me.GruppoAccontoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Y_GestioniBindingSource, "GruppoAcconto", True))
        Me.GruppoAccontoTextBox.Location = New System.Drawing.Point(305, 206)
        Me.GruppoAccontoTextBox.Name = "GruppoAccontoTextBox"
        Me.GruppoAccontoTextBox.Size = New System.Drawing.Size(36, 20)
        Me.GruppoAccontoTextBox.TabIndex = 22
        '
        'PercentoAccontoTextBox
        '
        Me.PercentoAccontoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Y_GestioniBindingSource, "PercentoAcconto", True))
        Me.PercentoAccontoTextBox.Location = New System.Drawing.Point(381, 206)
        Me.PercentoAccontoTextBox.Name = "PercentoAccontoTextBox"
        Me.PercentoAccontoTextBox.Size = New System.Drawing.Size(58, 20)
        Me.PercentoAccontoTextBox.TabIndex = 24
        '
        'GestioneSuccessivaTextBox
        '
        Me.GestioneSuccessivaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Y_GestioniBindingSource, "GestioneSuccessiva", True))
        Me.GestioneSuccessivaTextBox.Location = New System.Drawing.Point(448, 206)
        Me.GestioneSuccessivaTextBox.Name = "GestioneSuccessivaTextBox"
        Me.GestioneSuccessivaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.GestioneSuccessivaTextBox.TabIndex = 26
        '
        'GestioneCollegataTextBox
        '
        Me.GestioneCollegataTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Y_GestioniBindingSource, "GestioneCollegata", True))
        Me.GestioneCollegataTextBox.Location = New System.Drawing.Point(564, 206)
        Me.GestioneCollegataTextBox.Name = "GestioneCollegataTextBox"
        Me.GestioneCollegataTextBox.Size = New System.Drawing.Size(100, 20)
        Me.GestioneCollegataTextBox.TabIndex = 28
        '
        'PreventivoConfermatoTextBox
        '
        Me.PreventivoConfermatoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Y_GestioniBindingSource, "PreventivoConfermato", True))
        Me.PreventivoConfermatoTextBox.Location = New System.Drawing.Point(698, 206)
        Me.PreventivoConfermatoTextBox.Name = "PreventivoConfermatoTextBox"
        Me.PreventivoConfermatoTextBox.Size = New System.Drawing.Size(48, 20)
        Me.PreventivoConfermatoTextBox.TabIndex = 30
        '
        'Y_GestioniDettaglioBindingSource
        '
        Me.Y_GestioniDettaglioBindingSource.DataMember = "Y_GestioniDettaglio"
        Me.Y_GestioniDettaglioBindingSource.DataSource = Me.IMMOBILIDataSet
        '
        'Y_GestioniDettaglioDataGridView
        '
        Me.Y_GestioniDettaglioDataGridView.AutoGenerateColumns = False
        Me.Y_GestioniDettaglioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Y_GestioniDettaglioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.Y_GestioniDettaglioDataGridView.DataSource = Me.Y_GestioniDettaglioBindingSource
        Me.Y_GestioniDettaglioDataGridView.Location = New System.Drawing.Point(15, 232)
        Me.Y_GestioniDettaglioDataGridView.Name = "Y_GestioniDettaglioDataGridView"
        Me.Y_GestioniDettaglioDataGridView.Size = New System.Drawing.Size(717, 191)
        Me.Y_GestioniDettaglioDataGridView.TabIndex = 31
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Riga"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Riga"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 50
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PercentoRata"
        Me.DataGridViewTextBoxColumn4.HeaderText = "PercentoRata"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DataRata"
        Me.DataGridViewTextBoxColumn5.HeaderText = "DataRata"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "RataGenerata"
        Me.DataGridViewTextBoxColumn6.HeaderText = "RataGenerata"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "RataEmessa"
        Me.DataGridViewTextBoxColumn7.HeaderText = "RataEmessa"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'Y_Gestioni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 471)
        Me.Controls.Add(Me.Y_GestioniDettaglioDataGridView)
        Me.Controls.Add(PreventivoConfermatoLabel)
        Me.Controls.Add(Me.PreventivoConfermatoTextBox)
        Me.Controls.Add(GestioneCollegataLabel)
        Me.Controls.Add(Me.GestioneCollegataTextBox)
        Me.Controls.Add(GestioneSuccessivaLabel)
        Me.Controls.Add(Me.GestioneSuccessivaTextBox)
        Me.Controls.Add(PercentoAccontoLabel)
        Me.Controls.Add(Me.PercentoAccontoTextBox)
        Me.Controls.Add(GruppoAccontoLabel)
        Me.Controls.Add(Me.GruppoAccontoTextBox)
        Me.Controls.Add(StoricoLabel)
        Me.Controls.Add(Me.StoricoTextBox)
        Me.Controls.Add(ImportoMassimoLabel)
        Me.Controls.Add(Me.ImportoMassimoTextBox)
        Me.Controls.Add(ImportoMinimoLabel)
        Me.Controls.Add(Me.ImportoMinimoTextBox)
        Me.Controls.Add(TabellaLabel)
        Me.Controls.Add(Me.TabellaComboBox)
        Me.Controls.Add(DataTermineLabel)
        Me.Controls.Add(Me.DataTermineDateTimePicker)
        Me.Controls.Add(DataInizioLabel)
        Me.Controls.Add(Me.DataInizioDateTimePicker)
        Me.Controls.Add(TipoLabel)
        Me.Controls.Add(Me.TipoTextBox)
        Me.Controls.Add(Me.Descrizione2TextBox)
        Me.Controls.Add(Descrizione1Label)
        Me.Controls.Add(Me.Descrizione1TextBox)
        Me.Controls.Add(GestioneLabel)
        Me.Controls.Add(Me.GestioneComboBox)
        Me.Controls.Add(ImmobileLabel)
        Me.Controls.Add(Me.ImmobileComboBox)
        Me.Name = "Y_Gestioni"
        Me.Text = "Archivio delle Gestioni"
        CType(Me.IMMOBILIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Y_GestioniBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Y_GestioniDettaglioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Y_GestioniDettaglioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IMMOBILIDataSet As Patrimonio2014.IMMOBILIDataSet
    Friend WithEvents Y_GestioniBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Y_GestioniTableAdapter As Patrimonio2014.IMMOBILIDataSetTableAdapters.Y_GestioniTableAdapter
    Friend WithEvents TableAdapterManager As Patrimonio2014.IMMOBILIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Y_GestioniDettaglioTableAdapter As Patrimonio2014.IMMOBILIDataSetTableAdapters.Y_GestioniDettaglioTableAdapter
    Friend WithEvents ImmobileComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GestioneComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Descrizione1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Descrizione2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents TipoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataInizioDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataTermineDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TabellaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ImportoMinimoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ImportoMassimoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StoricoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GruppoAccontoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PercentoAccontoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GestioneSuccessivaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GestioneCollegataTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PreventivoConfermatoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Y_GestioniDettaglioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Y_GestioniDettaglioDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
