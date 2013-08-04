<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class X_Spese
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
        Dim ProgressivoLabel As System.Windows.Forms.Label
        Dim ImmobileLabel As System.Windows.Forms.Label
        Dim GestioneLabel As System.Windows.Forms.Label
        Dim FabbricatoLabel As System.Windows.Forms.Label
        Dim ScalaLabel As System.Windows.Forms.Label
        Dim GruppoLabel As System.Windows.Forms.Label
        Dim SpesaLabel As System.Windows.Forms.Label
        Dim UnitaLabel As System.Windows.Forms.Label
        Dim DocumentoLabel As System.Windows.Forms.Label
        Dim FornitoreLabel As System.Windows.Forms.Label
        Dim QuantitaLabel As System.Windows.Forms.Label
        Dim ImportoSpesaLabel As System.Windows.Forms.Label
        Dim DataDocumentoLabel As System.Windows.Forms.Label
        Dim CausaleLabel As System.Windows.Forms.Label
        Dim CompensoLabel As System.Windows.Forms.Label
        Dim EsenteLabel As System.Windows.Forms.Label
        Dim PrevidenzaLabel As System.Windows.Forms.Label
        Dim IvaLabel As System.Windows.Forms.Label
        Dim ImponibileLabel As System.Windows.Forms.Label
        Dim RitenutaLabel As System.Windows.Forms.Label
        Dim NettoLabel As System.Windows.Forms.Label
        Dim DataPagamentoLabel As System.Windows.Forms.Label
        Dim QuadroACLabel As System.Windows.Forms.Label
        Dim CodiceTributoLabel As System.Windows.Forms.Label
        Dim TrattamentoLabel As System.Windows.Forms.Label
        Dim FatturaSaldataLabel As System.Windows.Forms.Label
        Me.IMMOBILIDataSet = New Patrimonio2014.IMMOBILIDataSet()
        Me.X_SpeseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.X_SpeseTableAdapter = New Patrimonio2014.IMMOBILIDataSetTableAdapters.X_SpeseTableAdapter()
        Me.TableAdapterManager = New Patrimonio2014.IMMOBILIDataSetTableAdapters.TableAdapterManager()
        Me.ProgressivoTextBox = New System.Windows.Forms.TextBox()
        Me.ImmobileComboBox = New System.Windows.Forms.ComboBox()
        Me.GestioneComboBox = New System.Windows.Forms.ComboBox()
        Me.FabbricatoComboBox = New System.Windows.Forms.ComboBox()
        Me.ScalaComboBox = New System.Windows.Forms.ComboBox()
        Me.GruppoComboBox = New System.Windows.Forms.ComboBox()
        Me.SpesaComboBox = New System.Windows.Forms.ComboBox()
        Me.UnitaComboBox = New System.Windows.Forms.ComboBox()
        Me.DocumentoTextBox = New System.Windows.Forms.TextBox()
        Me.FornitoreComboBox = New System.Windows.Forms.ComboBox()
        Me.QuantitaTextBox = New System.Windows.Forms.TextBox()
        Me.ImportoSpesaTextBox = New System.Windows.Forms.TextBox()
        Me.DataDocumentoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TrattamentoComboBox = New System.Windows.Forms.ComboBox()
        Me.CodiceTributoTextBox = New System.Windows.Forms.TextBox()
        Me.QuadroACTextBox = New System.Windows.Forms.TextBox()
        Me.DataPagamentoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NettoTextBox = New System.Windows.Forms.TextBox()
        Me.RitenutaTextBox = New System.Windows.Forms.TextBox()
        Me.ImponibileTextBox = New System.Windows.Forms.TextBox()
        Me.IvaTextBox = New System.Windows.Forms.TextBox()
        Me.PrevidenzaTextBox = New System.Windows.Forms.TextBox()
        Me.EsenteTextBox = New System.Windows.Forms.TextBox()
        Me.CompensoTextBox = New System.Windows.Forms.TextBox()
        Me.CausaleTextBox = New System.Windows.Forms.TextBox()
        Me.X_SpeseDescrizioniBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.X_SpeseDescrizioniTableAdapter = New Patrimonio2014.IMMOBILIDataSetTableAdapters.X_SpeseDescrizioniTableAdapter()
        Me.FatturaSaldataComboBox = New System.Windows.Forms.ComboBox()
        Me.X_SpeseDescrizioniDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        ProgressivoLabel = New System.Windows.Forms.Label()
        ImmobileLabel = New System.Windows.Forms.Label()
        GestioneLabel = New System.Windows.Forms.Label()
        FabbricatoLabel = New System.Windows.Forms.Label()
        ScalaLabel = New System.Windows.Forms.Label()
        GruppoLabel = New System.Windows.Forms.Label()
        SpesaLabel = New System.Windows.Forms.Label()
        UnitaLabel = New System.Windows.Forms.Label()
        DocumentoLabel = New System.Windows.Forms.Label()
        FornitoreLabel = New System.Windows.Forms.Label()
        QuantitaLabel = New System.Windows.Forms.Label()
        ImportoSpesaLabel = New System.Windows.Forms.Label()
        DataDocumentoLabel = New System.Windows.Forms.Label()
        CausaleLabel = New System.Windows.Forms.Label()
        CompensoLabel = New System.Windows.Forms.Label()
        EsenteLabel = New System.Windows.Forms.Label()
        PrevidenzaLabel = New System.Windows.Forms.Label()
        IvaLabel = New System.Windows.Forms.Label()
        ImponibileLabel = New System.Windows.Forms.Label()
        RitenutaLabel = New System.Windows.Forms.Label()
        NettoLabel = New System.Windows.Forms.Label()
        DataPagamentoLabel = New System.Windows.Forms.Label()
        QuadroACLabel = New System.Windows.Forms.Label()
        CodiceTributoLabel = New System.Windows.Forms.Label()
        TrattamentoLabel = New System.Windows.Forms.Label()
        FatturaSaldataLabel = New System.Windows.Forms.Label()
        CType(Me.IMMOBILIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X_SpeseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.X_SpeseDescrizioniBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X_SpeseDescrizioniDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgressivoLabel
        '
        ProgressivoLabel.AutoSize = True
        ProgressivoLabel.Location = New System.Drawing.Point(12, 66)
        ProgressivoLabel.Name = "ProgressivoLabel"
        ProgressivoLabel.Size = New System.Drawing.Size(65, 13)
        ProgressivoLabel.TabIndex = 1
        ProgressivoLabel.Text = "Progressivo:"
        '
        'ImmobileLabel
        '
        ImmobileLabel.AutoSize = True
        ImmobileLabel.Location = New System.Drawing.Point(111, 66)
        ImmobileLabel.Name = "ImmobileLabel"
        ImmobileLabel.Size = New System.Drawing.Size(51, 13)
        ImmobileLabel.TabIndex = 2
        ImmobileLabel.Text = "Immobile:"
        '
        'GestioneLabel
        '
        GestioneLabel.AutoSize = True
        GestioneLabel.Location = New System.Drawing.Point(427, 66)
        GestioneLabel.Name = "GestioneLabel"
        GestioneLabel.Size = New System.Drawing.Size(52, 13)
        GestioneLabel.TabIndex = 4
        GestioneLabel.Text = "Gestione:"
        '
        'FabbricatoLabel
        '
        FabbricatoLabel.AutoSize = True
        FabbricatoLabel.Location = New System.Drawing.Point(111, 106)
        FabbricatoLabel.Name = "FabbricatoLabel"
        FabbricatoLabel.Size = New System.Drawing.Size(60, 13)
        FabbricatoLabel.TabIndex = 6
        FabbricatoLabel.Text = "Fabbricato:"
        '
        'ScalaLabel
        '
        ScalaLabel.AutoSize = True
        ScalaLabel.Location = New System.Drawing.Point(427, 106)
        ScalaLabel.Name = "ScalaLabel"
        ScalaLabel.Size = New System.Drawing.Size(37, 13)
        ScalaLabel.TabIndex = 8
        ScalaLabel.Text = "Scala:"
        '
        'GruppoLabel
        '
        GruppoLabel.AutoSize = True
        GruppoLabel.Location = New System.Drawing.Point(111, 146)
        GruppoLabel.Name = "GruppoLabel"
        GruppoLabel.Size = New System.Drawing.Size(45, 13)
        GruppoLabel.TabIndex = 10
        GruppoLabel.Text = "Gruppo:"
        '
        'SpesaLabel
        '
        SpesaLabel.AutoSize = True
        SpesaLabel.Location = New System.Drawing.Point(241, 146)
        SpesaLabel.Name = "SpesaLabel"
        SpesaLabel.Size = New System.Drawing.Size(40, 13)
        SpesaLabel.TabIndex = 12
        SpesaLabel.Text = "Spesa:"
        '
        'UnitaLabel
        '
        UnitaLabel.AutoSize = True
        UnitaLabel.Location = New System.Drawing.Point(427, 146)
        UnitaLabel.Name = "UnitaLabel"
        UnitaLabel.Size = New System.Drawing.Size(35, 13)
        UnitaLabel.TabIndex = 14
        UnitaLabel.Text = "Unita:"
        '
        'DocumentoLabel
        '
        DocumentoLabel.AutoSize = True
        DocumentoLabel.Location = New System.Drawing.Point(111, 186)
        DocumentoLabel.Name = "DocumentoLabel"
        DocumentoLabel.Size = New System.Drawing.Size(65, 13)
        DocumentoLabel.TabIndex = 16
        DocumentoLabel.Text = "Documento:"
        '
        'FornitoreLabel
        '
        FornitoreLabel.AutoSize = True
        FornitoreLabel.Location = New System.Drawing.Point(241, 186)
        FornitoreLabel.Name = "FornitoreLabel"
        FornitoreLabel.Size = New System.Drawing.Size(51, 13)
        FornitoreLabel.TabIndex = 18
        FornitoreLabel.Text = "Fornitore:"
        '
        'QuantitaLabel
        '
        QuantitaLabel.AutoSize = True
        QuantitaLabel.Location = New System.Drawing.Point(429, 186)
        QuantitaLabel.Name = "QuantitaLabel"
        QuantitaLabel.Size = New System.Drawing.Size(30, 13)
        QuantitaLabel.TabIndex = 20
        QuantitaLabel.Text = "Q.ta:"
        '
        'ImportoSpesaLabel
        '
        ImportoSpesaLabel.AutoSize = True
        ImportoSpesaLabel.Location = New System.Drawing.Point(465, 186)
        ImportoSpesaLabel.Name = "ImportoSpesaLabel"
        ImportoSpesaLabel.Size = New System.Drawing.Size(78, 13)
        ImportoSpesaLabel.TabIndex = 22
        ImportoSpesaLabel.Text = "Importo Spesa:"
        '
        'DataDocumentoLabel
        '
        DataDocumentoLabel.AutoSize = True
        DataDocumentoLabel.Location = New System.Drawing.Point(559, 185)
        DataDocumentoLabel.Name = "DataDocumentoLabel"
        DataDocumentoLabel.Size = New System.Drawing.Size(91, 13)
        DataDocumentoLabel.TabIndex = 24
        DataDocumentoLabel.Text = "Data Documento:"
        '
        'CausaleLabel
        '
        CausaleLabel.AutoSize = True
        CausaleLabel.Location = New System.Drawing.Point(336, 23)
        CausaleLabel.Name = "CausaleLabel"
        CausaleLabel.Size = New System.Drawing.Size(48, 13)
        CausaleLabel.TabIndex = 2
        CausaleLabel.Text = "Causale:"
        '
        'CompensoLabel
        '
        CompensoLabel.AutoSize = True
        CompensoLabel.Location = New System.Drawing.Point(6, 62)
        CompensoLabel.Name = "CompensoLabel"
        CompensoLabel.Size = New System.Drawing.Size(60, 13)
        CompensoLabel.TabIndex = 4
        CompensoLabel.Text = "Compenso:"
        '
        'EsenteLabel
        '
        EsenteLabel.AutoSize = True
        EsenteLabel.Location = New System.Drawing.Point(115, 62)
        EsenteLabel.Name = "EsenteLabel"
        EsenteLabel.Size = New System.Drawing.Size(43, 13)
        EsenteLabel.TabIndex = 6
        EsenteLabel.Text = "Esente:"
        '
        'PrevidenzaLabel
        '
        PrevidenzaLabel.AutoSize = True
        PrevidenzaLabel.Location = New System.Drawing.Point(224, 62)
        PrevidenzaLabel.Name = "PrevidenzaLabel"
        PrevidenzaLabel.Size = New System.Drawing.Size(63, 13)
        PrevidenzaLabel.TabIndex = 8
        PrevidenzaLabel.Text = "Previdenza:"
        '
        'IvaLabel
        '
        IvaLabel.AutoSize = True
        IvaLabel.Location = New System.Drawing.Point(336, 62)
        IvaLabel.Name = "IvaLabel"
        IvaLabel.Size = New System.Drawing.Size(25, 13)
        IvaLabel.TabIndex = 10
        IvaLabel.Text = "Iva:"
        '
        'ImponibileLabel
        '
        ImponibileLabel.AutoSize = True
        ImponibileLabel.Location = New System.Drawing.Point(445, 62)
        ImponibileLabel.Name = "ImponibileLabel"
        ImponibileLabel.Size = New System.Drawing.Size(57, 13)
        ImponibileLabel.TabIndex = 12
        ImponibileLabel.Text = "Imponibile:"
        '
        'RitenutaLabel
        '
        RitenutaLabel.AutoSize = True
        RitenutaLabel.Location = New System.Drawing.Point(554, 62)
        RitenutaLabel.Name = "RitenutaLabel"
        RitenutaLabel.Size = New System.Drawing.Size(50, 13)
        RitenutaLabel.TabIndex = 14
        RitenutaLabel.Text = "Ritenuta:"
        '
        'NettoLabel
        '
        NettoLabel.AutoSize = True
        NettoLabel.Location = New System.Drawing.Point(554, 101)
        NettoLabel.Name = "NettoLabel"
        NettoLabel.Size = New System.Drawing.Size(36, 13)
        NettoLabel.TabIndex = 16
        NettoLabel.Text = "Netto:"
        '
        'DataPagamentoLabel
        '
        DataPagamentoLabel.AutoSize = True
        DataPagamentoLabel.Location = New System.Drawing.Point(336, 101)
        DataPagamentoLabel.Name = "DataPagamentoLabel"
        DataPagamentoLabel.Size = New System.Drawing.Size(90, 13)
        DataPagamentoLabel.TabIndex = 18
        DataPagamentoLabel.Text = "Data Pagamento:"
        '
        'QuadroACLabel
        '
        QuadroACLabel.AutoSize = True
        QuadroACLabel.Location = New System.Drawing.Point(6, 101)
        QuadroACLabel.Name = "QuadroACLabel"
        QuadroACLabel.Size = New System.Drawing.Size(62, 13)
        QuadroACLabel.TabIndex = 20
        QuadroACLabel.Text = "Quadro AC:"
        '
        'CodiceTributoLabel
        '
        CodiceTributoLabel.AutoSize = True
        CodiceTributoLabel.Location = New System.Drawing.Point(224, 23)
        CodiceTributoLabel.Name = "CodiceTributoLabel"
        CodiceTributoLabel.Size = New System.Drawing.Size(79, 13)
        CodiceTributoLabel.TabIndex = 29
        CodiceTributoLabel.Text = "Codice Tributo:"
        '
        'TrattamentoLabel
        '
        TrattamentoLabel.AutoSize = True
        TrattamentoLabel.Location = New System.Drawing.Point(6, 22)
        TrattamentoLabel.Name = "TrattamentoLabel"
        TrattamentoLabel.Size = New System.Drawing.Size(43, 13)
        TrattamentoLabel.TabIndex = 30
        TrattamentoLabel.Text = "Codice:"
        '
        'FatturaSaldataLabel
        '
        FatturaSaldataLabel.AutoSize = True
        FatturaSaldataLabel.Location = New System.Drawing.Point(429, 225)
        FatturaSaldataLabel.Name = "FatturaSaldataLabel"
        FatturaSaldataLabel.Size = New System.Drawing.Size(64, 13)
        FatturaSaldataLabel.TabIndex = 31
        FatturaSaldataLabel.Text = "Pagamento:"
        '
        'IMMOBILIDataSet
        '
        Me.IMMOBILIDataSet.DataSetName = "IMMOBILIDataSet"
        Me.IMMOBILIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'X_SpeseBindingSource
        '
        Me.X_SpeseBindingSource.DataMember = "X_Spese"
        Me.X_SpeseBindingSource.DataSource = Me.IMMOBILIDataSet
        '
        'X_SpeseTableAdapter
        '
        Me.X_SpeseTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.X_SpeseTableAdapter = Me.X_SpeseTableAdapter
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
        'ProgressivoTextBox
        '
        Me.ProgressivoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_SpeseBindingSource, "Progressivo", True))
        Me.ProgressivoTextBox.Location = New System.Drawing.Point(12, 82)
        Me.ProgressivoTextBox.Name = "ProgressivoTextBox"
        Me.ProgressivoTextBox.Size = New System.Drawing.Size(85, 20)
        Me.ProgressivoTextBox.TabIndex = 2
        '
        'ImmobileComboBox
        '
        Me.ImmobileComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_SpeseBindingSource, "Immobile", True))
        Me.ImmobileComboBox.FormattingEnabled = True
        Me.ImmobileComboBox.Location = New System.Drawing.Point(114, 82)
        Me.ImmobileComboBox.Name = "ImmobileComboBox"
        Me.ImmobileComboBox.Size = New System.Drawing.Size(307, 21)
        Me.ImmobileComboBox.TabIndex = 3
        '
        'GestioneComboBox
        '
        Me.GestioneComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_SpeseBindingSource, "Gestione", True))
        Me.GestioneComboBox.FormattingEnabled = True
        Me.GestioneComboBox.Location = New System.Drawing.Point(430, 82)
        Me.GestioneComboBox.Name = "GestioneComboBox"
        Me.GestioneComboBox.Size = New System.Drawing.Size(332, 21)
        Me.GestioneComboBox.TabIndex = 5
        '
        'FabbricatoComboBox
        '
        Me.FabbricatoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_SpeseBindingSource, "Fabbricato", True))
        Me.FabbricatoComboBox.FormattingEnabled = True
        Me.FabbricatoComboBox.Location = New System.Drawing.Point(114, 122)
        Me.FabbricatoComboBox.Name = "FabbricatoComboBox"
        Me.FabbricatoComboBox.Size = New System.Drawing.Size(307, 21)
        Me.FabbricatoComboBox.TabIndex = 7
        '
        'ScalaComboBox
        '
        Me.ScalaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_SpeseBindingSource, "Scala", True))
        Me.ScalaComboBox.FormattingEnabled = True
        Me.ScalaComboBox.Location = New System.Drawing.Point(430, 122)
        Me.ScalaComboBox.Name = "ScalaComboBox"
        Me.ScalaComboBox.Size = New System.Drawing.Size(332, 21)
        Me.ScalaComboBox.TabIndex = 9
        '
        'GruppoComboBox
        '
        Me.GruppoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_SpeseBindingSource, "Gruppo", True))
        Me.GruppoComboBox.FormattingEnabled = True
        Me.GruppoComboBox.Location = New System.Drawing.Point(114, 162)
        Me.GruppoComboBox.Name = "GruppoComboBox"
        Me.GruppoComboBox.Size = New System.Drawing.Size(121, 21)
        Me.GruppoComboBox.TabIndex = 11
        '
        'SpesaComboBox
        '
        Me.SpesaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_SpeseBindingSource, "Spesa", True))
        Me.SpesaComboBox.FormattingEnabled = True
        Me.SpesaComboBox.Location = New System.Drawing.Point(244, 162)
        Me.SpesaComboBox.Name = "SpesaComboBox"
        Me.SpesaComboBox.Size = New System.Drawing.Size(177, 21)
        Me.SpesaComboBox.TabIndex = 13
        '
        'UnitaComboBox
        '
        Me.UnitaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_SpeseBindingSource, "Unita", True))
        Me.UnitaComboBox.FormattingEnabled = True
        Me.UnitaComboBox.Location = New System.Drawing.Point(430, 162)
        Me.UnitaComboBox.Name = "UnitaComboBox"
        Me.UnitaComboBox.Size = New System.Drawing.Size(332, 21)
        Me.UnitaComboBox.TabIndex = 15
        '
        'DocumentoTextBox
        '
        Me.DocumentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_SpeseBindingSource, "Documento", True))
        Me.DocumentoTextBox.Location = New System.Drawing.Point(114, 202)
        Me.DocumentoTextBox.Name = "DocumentoTextBox"
        Me.DocumentoTextBox.Size = New System.Drawing.Size(121, 20)
        Me.DocumentoTextBox.TabIndex = 17
        '
        'FornitoreComboBox
        '
        Me.FornitoreComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_SpeseBindingSource, "Fornitore", True))
        Me.FornitoreComboBox.FormattingEnabled = True
        Me.FornitoreComboBox.Location = New System.Drawing.Point(244, 201)
        Me.FornitoreComboBox.Name = "FornitoreComboBox"
        Me.FornitoreComboBox.Size = New System.Drawing.Size(177, 21)
        Me.FornitoreComboBox.TabIndex = 19
        '
        'QuantitaTextBox
        '
        Me.QuantitaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_SpeseBindingSource, "Quantita", True))
        Me.QuantitaTextBox.Location = New System.Drawing.Point(432, 202)
        Me.QuantitaTextBox.Name = "QuantitaTextBox"
        Me.QuantitaTextBox.Size = New System.Drawing.Size(30, 20)
        Me.QuantitaTextBox.TabIndex = 21
        '
        'ImportoSpesaTextBox
        '
        Me.ImportoSpesaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_SpeseBindingSource, "ImportoSpesa", True))
        Me.ImportoSpesaTextBox.Location = New System.Drawing.Point(467, 202)
        Me.ImportoSpesaTextBox.Name = "ImportoSpesaTextBox"
        Me.ImportoSpesaTextBox.Size = New System.Drawing.Size(86, 20)
        Me.ImportoSpesaTextBox.TabIndex = 23
        '
        'DataDocumentoDateTimePicker
        '
        Me.DataDocumentoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.X_SpeseBindingSource, "DataDocumento", True))
        Me.DataDocumentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataDocumentoDateTimePicker.Location = New System.Drawing.Point(562, 201)
        Me.DataDocumentoDateTimePicker.Name = "DataDocumentoDateTimePicker"
        Me.DataDocumentoDateTimePicker.Size = New System.Drawing.Size(100, 20)
        Me.DataDocumentoDateTimePicker.TabIndex = 25
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(TrattamentoLabel)
        Me.GroupBox1.Controls.Add(Me.TrattamentoComboBox)
        Me.GroupBox1.Controls.Add(CodiceTributoLabel)
        Me.GroupBox1.Controls.Add(Me.CodiceTributoTextBox)
        Me.GroupBox1.Controls.Add(QuadroACLabel)
        Me.GroupBox1.Controls.Add(Me.QuadroACTextBox)
        Me.GroupBox1.Controls.Add(DataPagamentoLabel)
        Me.GroupBox1.Controls.Add(Me.DataPagamentoDateTimePicker)
        Me.GroupBox1.Controls.Add(NettoLabel)
        Me.GroupBox1.Controls.Add(Me.NettoTextBox)
        Me.GroupBox1.Controls.Add(RitenutaLabel)
        Me.GroupBox1.Controls.Add(Me.RitenutaTextBox)
        Me.GroupBox1.Controls.Add(ImponibileLabel)
        Me.GroupBox1.Controls.Add(Me.ImponibileTextBox)
        Me.GroupBox1.Controls.Add(IvaLabel)
        Me.GroupBox1.Controls.Add(Me.IvaTextBox)
        Me.GroupBox1.Controls.Add(PrevidenzaLabel)
        Me.GroupBox1.Controls.Add(Me.PrevidenzaTextBox)
        Me.GroupBox1.Controls.Add(EsenteLabel)
        Me.GroupBox1.Controls.Add(Me.EsenteTextBox)
        Me.GroupBox1.Controls.Add(CompensoLabel)
        Me.GroupBox1.Controls.Add(Me.CompensoTextBox)
        Me.GroupBox1.Controls.Add(CausaleLabel)
        Me.GroupBox1.Controls.Add(Me.CausaleTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(114, 264)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(677, 149)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Trattamento Ritenuta Acconto"
        '
        'TrattamentoComboBox
        '
        Me.TrattamentoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_SpeseBindingSource, "Trattamento", True))
        Me.TrattamentoComboBox.FormattingEnabled = True
        Me.TrattamentoComboBox.Location = New System.Drawing.Point(9, 38)
        Me.TrattamentoComboBox.Name = "TrattamentoComboBox"
        Me.TrattamentoComboBox.Size = New System.Drawing.Size(209, 21)
        Me.TrattamentoComboBox.TabIndex = 31
        '
        'CodiceTributoTextBox
        '
        Me.CodiceTributoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_SpeseBindingSource, "CodiceTributo", True))
        Me.CodiceTributoTextBox.Location = New System.Drawing.Point(227, 39)
        Me.CodiceTributoTextBox.Name = "CodiceTributoTextBox"
        Me.CodiceTributoTextBox.Size = New System.Drawing.Size(80, 20)
        Me.CodiceTributoTextBox.TabIndex = 30
        '
        'QuadroACTextBox
        '
        Me.QuadroACTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_SpeseBindingSource, "QuadroAC", True))
        Me.QuadroACTextBox.Location = New System.Drawing.Point(9, 117)
        Me.QuadroACTextBox.Name = "QuadroACTextBox"
        Me.QuadroACTextBox.Size = New System.Drawing.Size(59, 20)
        Me.QuadroACTextBox.TabIndex = 21
        '
        'DataPagamentoDateTimePicker
        '
        Me.DataPagamentoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.X_SpeseBindingSource, "DataPagamento", True))
        Me.DataPagamentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataPagamentoDateTimePicker.Location = New System.Drawing.Point(339, 117)
        Me.DataPagamentoDateTimePicker.Name = "DataPagamentoDateTimePicker"
        Me.DataPagamentoDateTimePicker.Size = New System.Drawing.Size(100, 20)
        Me.DataPagamentoDateTimePicker.TabIndex = 19
        '
        'NettoTextBox
        '
        Me.NettoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_SpeseBindingSource, "Netto", True))
        Me.NettoTextBox.Location = New System.Drawing.Point(557, 117)
        Me.NettoTextBox.Name = "NettoTextBox"
        Me.NettoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NettoTextBox.TabIndex = 17
        '
        'RitenutaTextBox
        '
        Me.RitenutaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_SpeseBindingSource, "Ritenuta", True))
        Me.RitenutaTextBox.Location = New System.Drawing.Point(557, 78)
        Me.RitenutaTextBox.Name = "RitenutaTextBox"
        Me.RitenutaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RitenutaTextBox.TabIndex = 15
        '
        'ImponibileTextBox
        '
        Me.ImponibileTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_SpeseBindingSource, "Imponibile", True))
        Me.ImponibileTextBox.Location = New System.Drawing.Point(448, 78)
        Me.ImponibileTextBox.Name = "ImponibileTextBox"
        Me.ImponibileTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ImponibileTextBox.TabIndex = 13
        '
        'IvaTextBox
        '
        Me.IvaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_SpeseBindingSource, "Iva", True))
        Me.IvaTextBox.Location = New System.Drawing.Point(339, 78)
        Me.IvaTextBox.Name = "IvaTextBox"
        Me.IvaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IvaTextBox.TabIndex = 11
        '
        'PrevidenzaTextBox
        '
        Me.PrevidenzaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_SpeseBindingSource, "Previdenza", True))
        Me.PrevidenzaTextBox.Location = New System.Drawing.Point(227, 78)
        Me.PrevidenzaTextBox.Name = "PrevidenzaTextBox"
        Me.PrevidenzaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PrevidenzaTextBox.TabIndex = 9
        '
        'EsenteTextBox
        '
        Me.EsenteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_SpeseBindingSource, "Esente", True))
        Me.EsenteTextBox.Location = New System.Drawing.Point(118, 78)
        Me.EsenteTextBox.Name = "EsenteTextBox"
        Me.EsenteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EsenteTextBox.TabIndex = 7
        '
        'CompensoTextBox
        '
        Me.CompensoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_SpeseBindingSource, "Compenso", True))
        Me.CompensoTextBox.Location = New System.Drawing.Point(9, 78)
        Me.CompensoTextBox.Name = "CompensoTextBox"
        Me.CompensoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CompensoTextBox.TabIndex = 5
        '
        'CausaleTextBox
        '
        Me.CausaleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_SpeseBindingSource, "Causale", True))
        Me.CausaleTextBox.Location = New System.Drawing.Point(339, 39)
        Me.CausaleTextBox.Name = "CausaleTextBox"
        Me.CausaleTextBox.Size = New System.Drawing.Size(318, 20)
        Me.CausaleTextBox.TabIndex = 3
        '
        'X_SpeseDescrizioniBindingSource
        '
        Me.X_SpeseDescrizioniBindingSource.DataMember = "X_SpeseX_SpeseDescrizioni"
        Me.X_SpeseDescrizioniBindingSource.DataSource = Me.X_SpeseBindingSource
        '
        'X_SpeseDescrizioniTableAdapter
        '
        Me.X_SpeseDescrizioniTableAdapter.ClearBeforeFill = True
        '
        'FatturaSaldataComboBox
        '
        Me.FatturaSaldataComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_SpeseBindingSource, "FatturaSaldata", True))
        Me.FatturaSaldataComboBox.FormattingEnabled = True
        Me.FatturaSaldataComboBox.Location = New System.Drawing.Point(430, 241)
        Me.FatturaSaldataComboBox.Name = "FatturaSaldataComboBox"
        Me.FatturaSaldataComboBox.Size = New System.Drawing.Size(332, 21)
        Me.FatturaSaldataComboBox.TabIndex = 32
        '
        'X_SpeseDescrizioniDataGridView
        '
        Me.X_SpeseDescrizioniDataGridView.AutoGenerateColumns = False
        Me.X_SpeseDescrizioniDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.X_SpeseDescrizioniDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.X_SpeseDescrizioniDataGridView.DataSource = Me.X_SpeseDescrizioniBindingSource
        Me.X_SpeseDescrizioniDataGridView.Location = New System.Drawing.Point(121, 433)
        Me.X_SpeseDescrizioniDataGridView.Name = "X_SpeseDescrizioniDataGridView"
        Me.X_SpeseDescrizioniDataGridView.Size = New System.Drawing.Size(670, 127)
        Me.X_SpeseDescrizioniDataGridView.TabIndex = 32
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Riga"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Riga"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Descrizione"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Descrizione"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 400
        '
        'X_Spese
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 572)
        Me.Controls.Add(Me.X_SpeseDescrizioniDataGridView)
        Me.Controls.Add(FatturaSaldataLabel)
        Me.Controls.Add(Me.FatturaSaldataComboBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(DataDocumentoLabel)
        Me.Controls.Add(Me.DataDocumentoDateTimePicker)
        Me.Controls.Add(ImportoSpesaLabel)
        Me.Controls.Add(Me.ImportoSpesaTextBox)
        Me.Controls.Add(QuantitaLabel)
        Me.Controls.Add(Me.QuantitaTextBox)
        Me.Controls.Add(FornitoreLabel)
        Me.Controls.Add(Me.FornitoreComboBox)
        Me.Controls.Add(UnitaLabel)
        Me.Controls.Add(Me.UnitaComboBox)
        Me.Controls.Add(SpesaLabel)
        Me.Controls.Add(Me.SpesaComboBox)
        Me.Controls.Add(GruppoLabel)
        Me.Controls.Add(Me.GruppoComboBox)
        Me.Controls.Add(ScalaLabel)
        Me.Controls.Add(Me.ScalaComboBox)
        Me.Controls.Add(FabbricatoLabel)
        Me.Controls.Add(Me.FabbricatoComboBox)
        Me.Controls.Add(GestioneLabel)
        Me.Controls.Add(Me.GestioneComboBox)
        Me.Controls.Add(ImmobileLabel)
        Me.Controls.Add(Me.ImmobileComboBox)
        Me.Controls.Add(ProgressivoLabel)
        Me.Controls.Add(Me.ProgressivoTextBox)
        Me.Controls.Add(DocumentoLabel)
        Me.Controls.Add(Me.DocumentoTextBox)
        Me.Name = "X_Spese"
        Me.Text = "Archivio delle Spese"
        CType(Me.IMMOBILIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X_SpeseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.X_SpeseDescrizioniBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X_SpeseDescrizioniDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IMMOBILIDataSet As Patrimonio2014.IMMOBILIDataSet
    Friend WithEvents X_SpeseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents X_SpeseTableAdapter As Patrimonio2014.IMMOBILIDataSetTableAdapters.X_SpeseTableAdapter
    Friend WithEvents TableAdapterManager As Patrimonio2014.IMMOBILIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProgressivoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ImmobileComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GestioneComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FabbricatoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ScalaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GruppoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SpesaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents UnitaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DocumentoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FornitoreComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents QuantitaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ImportoSpesaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataDocumentoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents QuadroACTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataPagamentoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents NettoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RitenutaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ImponibileTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IvaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrevidenzaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EsenteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CompensoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CausaleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents X_SpeseDescrizioniBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents X_SpeseDescrizioniTableAdapter As Patrimonio2014.IMMOBILIDataSetTableAdapters.X_SpeseDescrizioniTableAdapter
    Friend WithEvents TrattamentoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CodiceTributoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FatturaSaldataComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents X_SpeseDescrizioniDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
