<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class W_Emissioni
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
        Dim ProgressivoLabel As System.Windows.Forms.Label
        Dim AnagraficaLabel As System.Windows.Forms.Label
        Dim GestioneLabel As System.Windows.Forms.Label
        Dim NumeroRataLabel As System.Windows.Forms.Label
        Dim DataScadenzaLabel As System.Windows.Forms.Label
        Dim ImportoRataLabel As System.Windows.Forms.Label
        Dim SpeseAvvisoLabel As System.Windows.Forms.Label
        Dim SpeseStornoLabel As System.Windows.Forms.Label
        Dim SaldoEsercizioPrecedenteLabel As System.Windows.Forms.Label
        Dim RataPreventivoLabel As System.Windows.Forms.Label
        Dim RateAddebitateLabel As System.Windows.Forms.Label
        Dim VersamentiLabel As System.Windows.Forms.Label
        Dim FondoLabel As System.Windows.Forms.Label
        Dim ContoLabel As System.Windows.Forms.Label
        Dim DataPagamentoLabel As System.Windows.Forms.Label
        Me.IMMOBILIDataSet = New Patrimonio2014.IMMOBILIDataSet()
        Me.W_EmissioniBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.W_EmissioniTableAdapter = New Patrimonio2014.IMMOBILIDataSetTableAdapters.W_EmissioniTableAdapter()
        Me.TableAdapterManager = New Patrimonio2014.IMMOBILIDataSetTableAdapters.TableAdapterManager()
        Me.W_EmissioniDettaglioTableAdapter = New Patrimonio2014.IMMOBILIDataSetTableAdapters.W_EmissioniDettaglioTableAdapter()
        Me.ImmobileComboBox = New System.Windows.Forms.ComboBox()
        Me.ProgressivoTextBox = New System.Windows.Forms.TextBox()
        Me.AnagraficaComboBox = New System.Windows.Forms.ComboBox()
        Me.GestioneComboBox = New System.Windows.Forms.ComboBox()
        Me.NumeroRataTextBox = New System.Windows.Forms.TextBox()
        Me.DataScadenzaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ImportoRataTextBox = New System.Windows.Forms.TextBox()
        Me.SpeseAvvisoTextBox = New System.Windows.Forms.TextBox()
        Me.SpeseStornoTextBox = New System.Windows.Forms.TextBox()
        Me.SaldoEsercizioPrecedenteTextBox = New System.Windows.Forms.TextBox()
        Me.RataPreventivoTextBox = New System.Windows.Forms.TextBox()
        Me.RateAddebitateTextBox = New System.Windows.Forms.TextBox()
        Me.VersamentiTextBox = New System.Windows.Forms.TextBox()
        Me.FondoTextBox = New System.Windows.Forms.TextBox()
        Me.ContoComboBox = New System.Windows.Forms.ComboBox()
        Me.DataPagamentoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.W_EmissioniDettaglioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.W_EmissioniDettaglioDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        ImmobileLabel = New System.Windows.Forms.Label()
        ProgressivoLabel = New System.Windows.Forms.Label()
        AnagraficaLabel = New System.Windows.Forms.Label()
        GestioneLabel = New System.Windows.Forms.Label()
        NumeroRataLabel = New System.Windows.Forms.Label()
        DataScadenzaLabel = New System.Windows.Forms.Label()
        ImportoRataLabel = New System.Windows.Forms.Label()
        SpeseAvvisoLabel = New System.Windows.Forms.Label()
        SpeseStornoLabel = New System.Windows.Forms.Label()
        SaldoEsercizioPrecedenteLabel = New System.Windows.Forms.Label()
        RataPreventivoLabel = New System.Windows.Forms.Label()
        RateAddebitateLabel = New System.Windows.Forms.Label()
        VersamentiLabel = New System.Windows.Forms.Label()
        FondoLabel = New System.Windows.Forms.Label()
        ContoLabel = New System.Windows.Forms.Label()
        DataPagamentoLabel = New System.Windows.Forms.Label()
        CType(Me.IMMOBILIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.W_EmissioniBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.W_EmissioniDettaglioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.W_EmissioniDettaglioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImmobileLabel
        '
        ImmobileLabel.AutoSize = True
        ImmobileLabel.Location = New System.Drawing.Point(12, 71)
        ImmobileLabel.Name = "ImmobileLabel"
        ImmobileLabel.Size = New System.Drawing.Size(51, 13)
        ImmobileLabel.TabIndex = 1
        ImmobileLabel.Text = "Immobile:"
        '
        'ProgressivoLabel
        '
        ProgressivoLabel.AutoSize = True
        ProgressivoLabel.Location = New System.Drawing.Point(287, 71)
        ProgressivoLabel.Name = "ProgressivoLabel"
        ProgressivoLabel.Size = New System.Drawing.Size(65, 13)
        ProgressivoLabel.TabIndex = 2
        ProgressivoLabel.Text = "Progressivo:"
        '
        'AnagraficaLabel
        '
        AnagraficaLabel.AutoSize = True
        AnagraficaLabel.Location = New System.Drawing.Point(375, 71)
        AnagraficaLabel.Name = "AnagraficaLabel"
        AnagraficaLabel.Size = New System.Drawing.Size(61, 13)
        AnagraficaLabel.TabIndex = 4
        AnagraficaLabel.Text = "Anagrafica:"
        '
        'GestioneLabel
        '
        GestioneLabel.AutoSize = True
        GestioneLabel.Location = New System.Drawing.Point(12, 111)
        GestioneLabel.Name = "GestioneLabel"
        GestioneLabel.Size = New System.Drawing.Size(52, 13)
        GestioneLabel.TabIndex = 6
        GestioneLabel.Text = "Gestione:"
        '
        'NumeroRataLabel
        '
        NumeroRataLabel.AutoSize = True
        NumeroRataLabel.Location = New System.Drawing.Point(291, 111)
        NumeroRataLabel.Name = "NumeroRataLabel"
        NumeroRataLabel.Size = New System.Drawing.Size(61, 13)
        NumeroRataLabel.TabIndex = 8
        NumeroRataLabel.Text = "Num. Rata:"
        '
        'DataScadenzaLabel
        '
        DataScadenzaLabel.AutoSize = True
        DataScadenzaLabel.Location = New System.Drawing.Point(375, 112)
        DataScadenzaLabel.Name = "DataScadenzaLabel"
        DataScadenzaLabel.Size = New System.Drawing.Size(84, 13)
        DataScadenzaLabel.TabIndex = 10
        DataScadenzaLabel.Text = "Data Scadenza:"
        '
        'ImportoRataLabel
        '
        ImportoRataLabel.AutoSize = True
        ImportoRataLabel.Location = New System.Drawing.Point(598, 112)
        ImportoRataLabel.Name = "ImportoRataLabel"
        ImportoRataLabel.Size = New System.Drawing.Size(71, 13)
        ImportoRataLabel.TabIndex = 12
        ImportoRataLabel.Text = "Importo Rata:"
        '
        'SpeseAvvisoLabel
        '
        SpeseAvvisoLabel.AutoSize = True
        SpeseAvvisoLabel.Location = New System.Drawing.Point(598, 151)
        SpeseAvvisoLabel.Name = "SpeseAvvisoLabel"
        SpeseAvvisoLabel.Size = New System.Drawing.Size(75, 13)
        SpeseAvvisoLabel.TabIndex = 14
        SpeseAvvisoLabel.Text = "Spese Avviso:"
        '
        'SpeseStornoLabel
        '
        SpeseStornoLabel.AutoSize = True
        SpeseStornoLabel.Location = New System.Drawing.Point(599, 190)
        SpeseStornoLabel.Name = "SpeseStornoLabel"
        SpeseStornoLabel.Size = New System.Drawing.Size(74, 13)
        SpeseStornoLabel.TabIndex = 16
        SpeseStornoLabel.Text = "Spese Storno:"
        '
        'SaldoEsercizioPrecedenteLabel
        '
        SaldoEsercizioPrecedenteLabel.AutoSize = True
        SaldoEsercizioPrecedenteLabel.Location = New System.Drawing.Point(598, 229)
        SaldoEsercizioPrecedenteLabel.Name = "SaldoEsercizioPrecedenteLabel"
        SaldoEsercizioPrecedenteLabel.Size = New System.Drawing.Size(99, 13)
        SaldoEsercizioPrecedenteLabel.TabIndex = 18
        SaldoEsercizioPrecedenteLabel.Text = "Sdo Eserc. Preced."
        '
        'RataPreventivoLabel
        '
        RataPreventivoLabel.AutoSize = True
        RataPreventivoLabel.Location = New System.Drawing.Point(598, 268)
        RataPreventivoLabel.Name = "RataPreventivoLabel"
        RataPreventivoLabel.Size = New System.Drawing.Size(87, 13)
        RataPreventivoLabel.TabIndex = 20
        RataPreventivoLabel.Text = "Rata Preventivo:"
        '
        'RateAddebitateLabel
        '
        RateAddebitateLabel.AutoSize = True
        RateAddebitateLabel.Location = New System.Drawing.Point(598, 307)
        RateAddebitateLabel.Name = "RateAddebitateLabel"
        RateAddebitateLabel.Size = New System.Drawing.Size(87, 13)
        RateAddebitateLabel.TabIndex = 22
        RateAddebitateLabel.Text = "Rate Addebitate:"
        '
        'VersamentiLabel
        '
        VersamentiLabel.AutoSize = True
        VersamentiLabel.Location = New System.Drawing.Point(601, 346)
        VersamentiLabel.Name = "VersamentiLabel"
        VersamentiLabel.Size = New System.Drawing.Size(62, 13)
        VersamentiLabel.TabIndex = 24
        VersamentiLabel.Text = "Versamenti:"
        '
        'FondoLabel
        '
        FondoLabel.AutoSize = True
        FondoLabel.Location = New System.Drawing.Point(601, 385)
        FondoLabel.Name = "FondoLabel"
        FondoLabel.Size = New System.Drawing.Size(40, 13)
        FondoLabel.TabIndex = 26
        FondoLabel.Text = "Fondo:"
        '
        'ContoLabel
        '
        ContoLabel.AutoSize = True
        ContoLabel.Location = New System.Drawing.Point(12, 151)
        ContoLabel.Name = "ContoLabel"
        ContoLabel.Size = New System.Drawing.Size(38, 13)
        ContoLabel.TabIndex = 28
        ContoLabel.Text = "Conto:"
        '
        'DataPagamentoLabel
        '
        DataPagamentoLabel.AutoSize = True
        DataPagamentoLabel.Location = New System.Drawing.Point(375, 151)
        DataPagamentoLabel.Name = "DataPagamentoLabel"
        DataPagamentoLabel.Size = New System.Drawing.Size(90, 13)
        DataPagamentoLabel.TabIndex = 30
        DataPagamentoLabel.Text = "Data Pagamento:"
        '
        'IMMOBILIDataSet
        '
        Me.IMMOBILIDataSet.DataSetName = "IMMOBILIDataSet"
        Me.IMMOBILIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'W_EmissioniBindingSource
        '
        Me.W_EmissioniBindingSource.DataMember = "W_Emissioni"
        Me.W_EmissioniBindingSource.DataSource = Me.IMMOBILIDataSet
        '
        'W_EmissioniTableAdapter
        '
        Me.W_EmissioniTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.W_EmissioniDettaglioTableAdapter = Me.W_EmissioniDettaglioTableAdapter
        Me.TableAdapterManager.W_EmissioniTableAdapter = Me.W_EmissioniTableAdapter
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
        'W_EmissioniDettaglioTableAdapter
        '
        Me.W_EmissioniDettaglioTableAdapter.ClearBeforeFill = True
        '
        'ImmobileComboBox
        '
        Me.ImmobileComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_EmissioniBindingSource, "Immobile", True))
        Me.ImmobileComboBox.FormattingEnabled = True
        Me.ImmobileComboBox.Location = New System.Drawing.Point(15, 87)
        Me.ImmobileComboBox.Name = "ImmobileComboBox"
        Me.ImmobileComboBox.Size = New System.Drawing.Size(269, 21)
        Me.ImmobileComboBox.TabIndex = 2
        '
        'ProgressivoTextBox
        '
        Me.ProgressivoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_EmissioniBindingSource, "Progressivo", True))
        Me.ProgressivoTextBox.Location = New System.Drawing.Point(290, 88)
        Me.ProgressivoTextBox.Name = "ProgressivoTextBox"
        Me.ProgressivoTextBox.Size = New System.Drawing.Size(79, 20)
        Me.ProgressivoTextBox.TabIndex = 3
        '
        'AnagraficaComboBox
        '
        Me.AnagraficaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_EmissioniBindingSource, "Anagrafica", True))
        Me.AnagraficaComboBox.FormattingEnabled = True
        Me.AnagraficaComboBox.Location = New System.Drawing.Point(378, 88)
        Me.AnagraficaComboBox.Name = "AnagraficaComboBox"
        Me.AnagraficaComboBox.Size = New System.Drawing.Size(258, 21)
        Me.AnagraficaComboBox.TabIndex = 5
        '
        'GestioneComboBox
        '
        Me.GestioneComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_EmissioniBindingSource, "Gestione", True))
        Me.GestioneComboBox.FormattingEnabled = True
        Me.GestioneComboBox.Location = New System.Drawing.Point(15, 127)
        Me.GestioneComboBox.Name = "GestioneComboBox"
        Me.GestioneComboBox.Size = New System.Drawing.Size(269, 21)
        Me.GestioneComboBox.TabIndex = 7
        '
        'NumeroRataTextBox
        '
        Me.NumeroRataTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_EmissioniBindingSource, "NumeroRata", True))
        Me.NumeroRataTextBox.Location = New System.Drawing.Point(290, 128)
        Me.NumeroRataTextBox.Name = "NumeroRataTextBox"
        Me.NumeroRataTextBox.Size = New System.Drawing.Size(79, 20)
        Me.NumeroRataTextBox.TabIndex = 9
        '
        'DataScadenzaDateTimePicker
        '
        Me.DataScadenzaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.W_EmissioniBindingSource, "DataScadenza", True))
        Me.DataScadenzaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataScadenzaDateTimePicker.Location = New System.Drawing.Point(378, 128)
        Me.DataScadenzaDateTimePicker.Name = "DataScadenzaDateTimePicker"
        Me.DataScadenzaDateTimePicker.Size = New System.Drawing.Size(97, 20)
        Me.DataScadenzaDateTimePicker.TabIndex = 11
        '
        'ImportoRataTextBox
        '
        Me.ImportoRataTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_EmissioniBindingSource, "ImportoRata", True))
        Me.ImportoRataTextBox.Location = New System.Drawing.Point(601, 128)
        Me.ImportoRataTextBox.Name = "ImportoRataTextBox"
        Me.ImportoRataTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ImportoRataTextBox.TabIndex = 13
        '
        'SpeseAvvisoTextBox
        '
        Me.SpeseAvvisoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_EmissioniBindingSource, "SpeseAvviso", True))
        Me.SpeseAvvisoTextBox.Location = New System.Drawing.Point(601, 167)
        Me.SpeseAvvisoTextBox.Name = "SpeseAvvisoTextBox"
        Me.SpeseAvvisoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SpeseAvvisoTextBox.TabIndex = 15
        '
        'SpeseStornoTextBox
        '
        Me.SpeseStornoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_EmissioniBindingSource, "SpeseStorno", True))
        Me.SpeseStornoTextBox.Location = New System.Drawing.Point(601, 206)
        Me.SpeseStornoTextBox.Name = "SpeseStornoTextBox"
        Me.SpeseStornoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SpeseStornoTextBox.TabIndex = 17
        '
        'SaldoEsercizioPrecedenteTextBox
        '
        Me.SaldoEsercizioPrecedenteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_EmissioniBindingSource, "SaldoEsercizioPrecedente", True))
        Me.SaldoEsercizioPrecedenteTextBox.Location = New System.Drawing.Point(601, 245)
        Me.SaldoEsercizioPrecedenteTextBox.Name = "SaldoEsercizioPrecedenteTextBox"
        Me.SaldoEsercizioPrecedenteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SaldoEsercizioPrecedenteTextBox.TabIndex = 19
        '
        'RataPreventivoTextBox
        '
        Me.RataPreventivoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_EmissioniBindingSource, "RataPreventivo", True))
        Me.RataPreventivoTextBox.Location = New System.Drawing.Point(602, 284)
        Me.RataPreventivoTextBox.Name = "RataPreventivoTextBox"
        Me.RataPreventivoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RataPreventivoTextBox.TabIndex = 21
        '
        'RateAddebitateTextBox
        '
        Me.RateAddebitateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_EmissioniBindingSource, "RateAddebitate", True))
        Me.RateAddebitateTextBox.Location = New System.Drawing.Point(602, 323)
        Me.RateAddebitateTextBox.Name = "RateAddebitateTextBox"
        Me.RateAddebitateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RateAddebitateTextBox.TabIndex = 23
        '
        'VersamentiTextBox
        '
        Me.VersamentiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_EmissioniBindingSource, "Versamenti", True))
        Me.VersamentiTextBox.Location = New System.Drawing.Point(604, 362)
        Me.VersamentiTextBox.Name = "VersamentiTextBox"
        Me.VersamentiTextBox.Size = New System.Drawing.Size(100, 20)
        Me.VersamentiTextBox.TabIndex = 25
        '
        'FondoTextBox
        '
        Me.FondoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_EmissioniBindingSource, "Fondo", True))
        Me.FondoTextBox.Location = New System.Drawing.Point(604, 401)
        Me.FondoTextBox.Name = "FondoTextBox"
        Me.FondoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FondoTextBox.TabIndex = 27
        '
        'ContoComboBox
        '
        Me.ContoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_EmissioniBindingSource, "Conto", True))
        Me.ContoComboBox.FormattingEnabled = True
        Me.ContoComboBox.Location = New System.Drawing.Point(12, 166)
        Me.ContoComboBox.Name = "ContoComboBox"
        Me.ContoComboBox.Size = New System.Drawing.Size(272, 21)
        Me.ContoComboBox.TabIndex = 29
        '
        'DataPagamentoDateTimePicker
        '
        Me.DataPagamentoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.W_EmissioniBindingSource, "DataPagamento", True))
        Me.DataPagamentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataPagamentoDateTimePicker.Location = New System.Drawing.Point(378, 163)
        Me.DataPagamentoDateTimePicker.Name = "DataPagamentoDateTimePicker"
        Me.DataPagamentoDateTimePicker.Size = New System.Drawing.Size(97, 20)
        Me.DataPagamentoDateTimePicker.TabIndex = 31
        '
        'W_EmissioniDettaglioBindingSource
        '
        Me.W_EmissioniDettaglioBindingSource.DataMember = "W_EmissioniDettaglio"
        Me.W_EmissioniDettaglioBindingSource.DataSource = Me.IMMOBILIDataSet
        '
        'W_EmissioniDettaglioDataGridView
        '
        Me.W_EmissioniDettaglioDataGridView.AutoGenerateColumns = False
        Me.W_EmissioniDettaglioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.W_EmissioniDettaglioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.W_EmissioniDettaglioDataGridView.DataSource = Me.W_EmissioniDettaglioBindingSource
        Me.W_EmissioniDettaglioDataGridView.Location = New System.Drawing.Point(17, 206)
        Me.W_EmissioniDettaglioDataGridView.Name = "W_EmissioniDettaglioDataGridView"
        Me.W_EmissioniDettaglioDataGridView.Size = New System.Drawing.Size(561, 215)
        Me.W_EmissioniDettaglioDataGridView.TabIndex = 32
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Riga"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Riga"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Unita"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Unita"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "SaldoEsercizioPrecedente"
        Me.DataGridViewTextBoxColumn5.HeaderText = "S.doEserc.Preced."
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "RataPreventivo"
        Me.DataGridViewTextBoxColumn6.HeaderText = "RataPreventivo"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Importo"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Importo"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'W_Emissioni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 459)
        Me.Controls.Add(Me.W_EmissioniDettaglioDataGridView)
        Me.Controls.Add(DataPagamentoLabel)
        Me.Controls.Add(Me.DataPagamentoDateTimePicker)
        Me.Controls.Add(ContoLabel)
        Me.Controls.Add(Me.ContoComboBox)
        Me.Controls.Add(FondoLabel)
        Me.Controls.Add(Me.FondoTextBox)
        Me.Controls.Add(VersamentiLabel)
        Me.Controls.Add(Me.VersamentiTextBox)
        Me.Controls.Add(RateAddebitateLabel)
        Me.Controls.Add(Me.RateAddebitateTextBox)
        Me.Controls.Add(RataPreventivoLabel)
        Me.Controls.Add(Me.RataPreventivoTextBox)
        Me.Controls.Add(SaldoEsercizioPrecedenteLabel)
        Me.Controls.Add(Me.SaldoEsercizioPrecedenteTextBox)
        Me.Controls.Add(SpeseStornoLabel)
        Me.Controls.Add(Me.SpeseStornoTextBox)
        Me.Controls.Add(SpeseAvvisoLabel)
        Me.Controls.Add(Me.SpeseAvvisoTextBox)
        Me.Controls.Add(ImportoRataLabel)
        Me.Controls.Add(Me.ImportoRataTextBox)
        Me.Controls.Add(DataScadenzaLabel)
        Me.Controls.Add(Me.DataScadenzaDateTimePicker)
        Me.Controls.Add(NumeroRataLabel)
        Me.Controls.Add(Me.NumeroRataTextBox)
        Me.Controls.Add(GestioneLabel)
        Me.Controls.Add(Me.GestioneComboBox)
        Me.Controls.Add(AnagraficaLabel)
        Me.Controls.Add(Me.AnagraficaComboBox)
        Me.Controls.Add(ProgressivoLabel)
        Me.Controls.Add(Me.ProgressivoTextBox)
        Me.Controls.Add(ImmobileLabel)
        Me.Controls.Add(Me.ImmobileComboBox)
        Me.Name = "W_Emissioni"
        Me.Text = "Archivio degli Avvisi"
        CType(Me.IMMOBILIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.W_EmissioniBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.W_EmissioniDettaglioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.W_EmissioniDettaglioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IMMOBILIDataSet As Patrimonio2014.IMMOBILIDataSet
    Friend WithEvents W_EmissioniBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents W_EmissioniTableAdapter As Patrimonio2014.IMMOBILIDataSetTableAdapters.W_EmissioniTableAdapter
    Friend WithEvents TableAdapterManager As Patrimonio2014.IMMOBILIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents W_EmissioniDettaglioTableAdapter As Patrimonio2014.IMMOBILIDataSetTableAdapters.W_EmissioniDettaglioTableAdapter
    Friend WithEvents ImmobileComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ProgressivoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AnagraficaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GestioneComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NumeroRataTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataScadenzaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ImportoRataTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SpeseAvvisoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SpeseStornoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SaldoEsercizioPrecedenteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RataPreventivoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RateAddebitateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VersamentiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FondoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DataPagamentoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents W_EmissioniDettaglioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents W_EmissioniDettaglioDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
