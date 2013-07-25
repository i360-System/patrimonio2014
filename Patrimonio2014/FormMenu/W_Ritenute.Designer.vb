<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class W_Ritenute
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
        Dim DocumentoLabel As System.Windows.Forms.Label
        Dim DataDocumentoLabel As System.Windows.Forms.Label
        Dim FornitoreLabel As System.Windows.Forms.Label
        Dim TrattamentoLabel As System.Windows.Forms.Label
        Dim TributoLabel As System.Windows.Forms.Label
        Dim CausaleLabel As System.Windows.Forms.Label
        Dim CompensoLabel As System.Windows.Forms.Label
        Dim EsenteLabel As System.Windows.Forms.Label
        Dim PrevidenzaLabel As System.Windows.Forms.Label
        Dim IvaLabel As System.Windows.Forms.Label
        Dim ImponibileLabel As System.Windows.Forms.Label
        Dim RitenutaLabel As System.Windows.Forms.Label
        Dim NettoLabel As System.Windows.Forms.Label
        Dim DataPagamentoLabel As System.Windows.Forms.Label
        Dim AnnoLabel As System.Windows.Forms.Label
        Me.IMMOBILIDataSet = New Patrimonio2014.IMMOBILIDataSet()
        Me.W_RitenuteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.W_RitenuteTableAdapter = New Patrimonio2014.IMMOBILIDataSetTableAdapters.W_RitenuteTableAdapter()
        Me.TableAdapterManager = New Patrimonio2014.IMMOBILIDataSetTableAdapters.TableAdapterManager()
        Me.ProgressivoTextBox = New System.Windows.Forms.TextBox()
        Me.ImmobileComboBox = New System.Windows.Forms.ComboBox()
        Me.DocumentoTextBox = New System.Windows.Forms.TextBox()
        Me.DataDocumentoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FornitoreComboBox = New System.Windows.Forms.ComboBox()
        Me.TrattamentoComboBox = New System.Windows.Forms.ComboBox()
        Me.TributoTextBox = New System.Windows.Forms.TextBox()
        Me.CausaleTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CompensoTextBox = New System.Windows.Forms.TextBox()
        Me.EsenteTextBox = New System.Windows.Forms.TextBox()
        Me.PrevidenzaTextBox = New System.Windows.Forms.TextBox()
        Me.IvaTextBox = New System.Windows.Forms.TextBox()
        Me.ImponibileTextBox = New System.Windows.Forms.TextBox()
        Me.RitenutaTextBox = New System.Windows.Forms.TextBox()
        Me.NettoTextBox = New System.Windows.Forms.TextBox()
        Me.DataPagamentoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AnnoTextBox = New System.Windows.Forms.TextBox()
        ProgressivoLabel = New System.Windows.Forms.Label()
        ImmobileLabel = New System.Windows.Forms.Label()
        DocumentoLabel = New System.Windows.Forms.Label()
        DataDocumentoLabel = New System.Windows.Forms.Label()
        FornitoreLabel = New System.Windows.Forms.Label()
        TrattamentoLabel = New System.Windows.Forms.Label()
        TributoLabel = New System.Windows.Forms.Label()
        CausaleLabel = New System.Windows.Forms.Label()
        CompensoLabel = New System.Windows.Forms.Label()
        EsenteLabel = New System.Windows.Forms.Label()
        PrevidenzaLabel = New System.Windows.Forms.Label()
        IvaLabel = New System.Windows.Forms.Label()
        ImponibileLabel = New System.Windows.Forms.Label()
        RitenutaLabel = New System.Windows.Forms.Label()
        NettoLabel = New System.Windows.Forms.Label()
        DataPagamentoLabel = New System.Windows.Forms.Label()
        AnnoLabel = New System.Windows.Forms.Label()
        CType(Me.IMMOBILIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.W_RitenuteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IMMOBILIDataSet
        '
        Me.IMMOBILIDataSet.DataSetName = "IMMOBILIDataSet"
        Me.IMMOBILIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'W_RitenuteBindingSource
        '
        Me.W_RitenuteBindingSource.DataMember = "W_Ritenute"
        Me.W_RitenuteBindingSource.DataSource = Me.IMMOBILIDataSet
        '
        'W_RitenuteTableAdapter
        '
        Me.W_RitenuteTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.W_RitenuteTableAdapter = Me.W_RitenuteTableAdapter
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
        'ProgressivoLabel
        '
        ProgressivoLabel.AutoSize = True
        ProgressivoLabel.Location = New System.Drawing.Point(17, 58)
        ProgressivoLabel.Name = "ProgressivoLabel"
        ProgressivoLabel.Size = New System.Drawing.Size(65, 13)
        ProgressivoLabel.TabIndex = 1
        ProgressivoLabel.Text = "Progressivo:"
        '
        'ProgressivoTextBox
        '
        Me.ProgressivoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_RitenuteBindingSource, "Progressivo", True))
        Me.ProgressivoTextBox.Location = New System.Drawing.Point(20, 74)
        Me.ProgressivoTextBox.Name = "ProgressivoTextBox"
        Me.ProgressivoTextBox.Size = New System.Drawing.Size(85, 20)
        Me.ProgressivoTextBox.TabIndex = 2
        '
        'ImmobileLabel
        '
        ImmobileLabel.AutoSize = True
        ImmobileLabel.Location = New System.Drawing.Point(111, 58)
        ImmobileLabel.Name = "ImmobileLabel"
        ImmobileLabel.Size = New System.Drawing.Size(51, 13)
        ImmobileLabel.TabIndex = 2
        ImmobileLabel.Text = "Immobile:"
        '
        'ImmobileComboBox
        '
        Me.ImmobileComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_RitenuteBindingSource, "Immobile", True))
        Me.ImmobileComboBox.FormattingEnabled = True
        Me.ImmobileComboBox.Location = New System.Drawing.Point(114, 73)
        Me.ImmobileComboBox.Name = "ImmobileComboBox"
        Me.ImmobileComboBox.Size = New System.Drawing.Size(274, 21)
        Me.ImmobileComboBox.TabIndex = 3
        '
        'DocumentoLabel
        '
        DocumentoLabel.AutoSize = True
        DocumentoLabel.Location = New System.Drawing.Point(394, 58)
        DocumentoLabel.Name = "DocumentoLabel"
        DocumentoLabel.Size = New System.Drawing.Size(65, 13)
        DocumentoLabel.TabIndex = 4
        DocumentoLabel.Text = "Documento:"
        '
        'DocumentoTextBox
        '
        Me.DocumentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_RitenuteBindingSource, "Documento", True))
        Me.DocumentoTextBox.Location = New System.Drawing.Point(394, 73)
        Me.DocumentoTextBox.Name = "DocumentoTextBox"
        Me.DocumentoTextBox.Size = New System.Drawing.Size(108, 20)
        Me.DocumentoTextBox.TabIndex = 5
        '
        'DataDocumentoLabel
        '
        DataDocumentoLabel.AutoSize = True
        DataDocumentoLabel.Location = New System.Drawing.Point(508, 58)
        DataDocumentoLabel.Name = "DataDocumentoLabel"
        DataDocumentoLabel.Size = New System.Drawing.Size(91, 13)
        DataDocumentoLabel.TabIndex = 6
        DataDocumentoLabel.Text = "Data Documento:"
        '
        'DataDocumentoDateTimePicker
        '
        Me.DataDocumentoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.W_RitenuteBindingSource, "DataDocumento", True))
        Me.DataDocumentoDateTimePicker.Location = New System.Drawing.Point(511, 74)
        Me.DataDocumentoDateTimePicker.Name = "DataDocumentoDateTimePicker"
        Me.DataDocumentoDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DataDocumentoDateTimePicker.TabIndex = 7
        '
        'FornitoreLabel
        '
        FornitoreLabel.AutoSize = True
        FornitoreLabel.Location = New System.Drawing.Point(111, 97)
        FornitoreLabel.Name = "FornitoreLabel"
        FornitoreLabel.Size = New System.Drawing.Size(51, 13)
        FornitoreLabel.TabIndex = 8
        FornitoreLabel.Text = "Fornitore:"
        '
        'FornitoreComboBox
        '
        Me.FornitoreComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_RitenuteBindingSource, "Fornitore", True))
        Me.FornitoreComboBox.FormattingEnabled = True
        Me.FornitoreComboBox.Location = New System.Drawing.Point(114, 113)
        Me.FornitoreComboBox.Name = "FornitoreComboBox"
        Me.FornitoreComboBox.Size = New System.Drawing.Size(264, 21)
        Me.FornitoreComboBox.TabIndex = 9
        '
        'TrattamentoLabel
        '
        TrattamentoLabel.AutoSize = True
        TrattamentoLabel.Location = New System.Drawing.Point(394, 97)
        TrattamentoLabel.Name = "TrattamentoLabel"
        TrattamentoLabel.Size = New System.Drawing.Size(67, 13)
        TrattamentoLabel.TabIndex = 10
        TrattamentoLabel.Text = "Trattamento:"
        '
        'TrattamentoComboBox
        '
        Me.TrattamentoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_RitenuteBindingSource, "Trattamento", True))
        Me.TrattamentoComboBox.FormattingEnabled = True
        Me.TrattamentoComboBox.Location = New System.Drawing.Point(394, 113)
        Me.TrattamentoComboBox.Name = "TrattamentoComboBox"
        Me.TrattamentoComboBox.Size = New System.Drawing.Size(317, 21)
        Me.TrattamentoComboBox.TabIndex = 11
        '
        'TributoLabel
        '
        TributoLabel.AutoSize = True
        TributoLabel.Location = New System.Drawing.Point(111, 137)
        TributoLabel.Name = "TributoLabel"
        TributoLabel.Size = New System.Drawing.Size(43, 13)
        TributoLabel.TabIndex = 12
        TributoLabel.Text = "Tributo:"
        '
        'TributoTextBox
        '
        Me.TributoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_RitenuteBindingSource, "Tributo", True))
        Me.TributoTextBox.Location = New System.Drawing.Point(114, 153)
        Me.TributoTextBox.Name = "TributoTextBox"
        Me.TributoTextBox.Size = New System.Drawing.Size(48, 20)
        Me.TributoTextBox.TabIndex = 13
        '
        'CausaleLabel
        '
        CausaleLabel.AutoSize = True
        CausaleLabel.Location = New System.Drawing.Point(165, 137)
        CausaleLabel.Name = "CausaleLabel"
        CausaleLabel.Size = New System.Drawing.Size(48, 13)
        CausaleLabel.TabIndex = 14
        CausaleLabel.Text = "Causale:"
        '
        'CausaleTextBox
        '
        Me.CausaleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_RitenuteBindingSource, "Causale", True))
        Me.CausaleTextBox.Location = New System.Drawing.Point(168, 153)
        Me.CausaleTextBox.Name = "CausaleTextBox"
        Me.CausaleTextBox.Size = New System.Drawing.Size(210, 20)
        Me.CausaleTextBox.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(AnnoLabel)
        Me.GroupBox1.Controls.Add(Me.AnnoTextBox)
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
        Me.GroupBox1.Location = New System.Drawing.Point(114, 196)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(635, 121)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Importi e Ritenute"
        '
        'CompensoLabel
        '
        CompensoLabel.AutoSize = True
        CompensoLabel.Location = New System.Drawing.Point(6, 16)
        CompensoLabel.Name = "CompensoLabel"
        CompensoLabel.Size = New System.Drawing.Size(60, 13)
        CompensoLabel.TabIndex = 0
        CompensoLabel.Text = "Compenso:"
        '
        'CompensoTextBox
        '
        Me.CompensoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_RitenuteBindingSource, "Compenso", True))
        Me.CompensoTextBox.Location = New System.Drawing.Point(6, 32)
        Me.CompensoTextBox.Name = "CompensoTextBox"
        Me.CompensoTextBox.Size = New System.Drawing.Size(82, 20)
        Me.CompensoTextBox.TabIndex = 1
        '
        'EsenteLabel
        '
        EsenteLabel.AutoSize = True
        EsenteLabel.Location = New System.Drawing.Point(91, 16)
        EsenteLabel.Name = "EsenteLabel"
        EsenteLabel.Size = New System.Drawing.Size(43, 13)
        EsenteLabel.TabIndex = 2
        EsenteLabel.Text = "Esente:"
        '
        'EsenteTextBox
        '
        Me.EsenteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_RitenuteBindingSource, "Esente", True))
        Me.EsenteTextBox.Location = New System.Drawing.Point(94, 32)
        Me.EsenteTextBox.Name = "EsenteTextBox"
        Me.EsenteTextBox.Size = New System.Drawing.Size(81, 20)
        Me.EsenteTextBox.TabIndex = 3
        '
        'PrevidenzaLabel
        '
        PrevidenzaLabel.AutoSize = True
        PrevidenzaLabel.Location = New System.Drawing.Point(181, 16)
        PrevidenzaLabel.Name = "PrevidenzaLabel"
        PrevidenzaLabel.Size = New System.Drawing.Size(63, 13)
        PrevidenzaLabel.TabIndex = 4
        PrevidenzaLabel.Text = "Previdenza:"
        '
        'PrevidenzaTextBox
        '
        Me.PrevidenzaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_RitenuteBindingSource, "Previdenza", True))
        Me.PrevidenzaTextBox.Location = New System.Drawing.Point(184, 32)
        Me.PrevidenzaTextBox.Name = "PrevidenzaTextBox"
        Me.PrevidenzaTextBox.Size = New System.Drawing.Size(80, 20)
        Me.PrevidenzaTextBox.TabIndex = 5
        '
        'IvaLabel
        '
        IvaLabel.AutoSize = True
        IvaLabel.Location = New System.Drawing.Point(270, 16)
        IvaLabel.Name = "IvaLabel"
        IvaLabel.Size = New System.Drawing.Size(25, 13)
        IvaLabel.TabIndex = 6
        IvaLabel.Text = "Iva:"
        '
        'IvaTextBox
        '
        Me.IvaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_RitenuteBindingSource, "Iva", True))
        Me.IvaTextBox.Location = New System.Drawing.Point(270, 32)
        Me.IvaTextBox.Name = "IvaTextBox"
        Me.IvaTextBox.Size = New System.Drawing.Size(82, 20)
        Me.IvaTextBox.TabIndex = 7
        '
        'ImponibileLabel
        '
        ImponibileLabel.AutoSize = True
        ImponibileLabel.Location = New System.Drawing.Point(358, 16)
        ImponibileLabel.Name = "ImponibileLabel"
        ImponibileLabel.Size = New System.Drawing.Size(57, 13)
        ImponibileLabel.TabIndex = 8
        ImponibileLabel.Text = "Imponibile:"
        '
        'ImponibileTextBox
        '
        Me.ImponibileTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_RitenuteBindingSource, "Imponibile", True))
        Me.ImponibileTextBox.Location = New System.Drawing.Point(361, 32)
        Me.ImponibileTextBox.Name = "ImponibileTextBox"
        Me.ImponibileTextBox.Size = New System.Drawing.Size(80, 20)
        Me.ImponibileTextBox.TabIndex = 9
        '
        'RitenutaLabel
        '
        RitenutaLabel.AutoSize = True
        RitenutaLabel.Location = New System.Drawing.Point(447, 16)
        RitenutaLabel.Name = "RitenutaLabel"
        RitenutaLabel.Size = New System.Drawing.Size(50, 13)
        RitenutaLabel.TabIndex = 10
        RitenutaLabel.Text = "Ritenuta:"
        '
        'RitenutaTextBox
        '
        Me.RitenutaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_RitenuteBindingSource, "Ritenuta", True))
        Me.RitenutaTextBox.Location = New System.Drawing.Point(450, 32)
        Me.RitenutaTextBox.Name = "RitenutaTextBox"
        Me.RitenutaTextBox.Size = New System.Drawing.Size(77, 20)
        Me.RitenutaTextBox.TabIndex = 11
        '
        'NettoLabel
        '
        NettoLabel.AutoSize = True
        NettoLabel.Location = New System.Drawing.Point(533, 16)
        NettoLabel.Name = "NettoLabel"
        NettoLabel.Size = New System.Drawing.Size(36, 13)
        NettoLabel.TabIndex = 12
        NettoLabel.Text = "Netto:"
        '
        'NettoTextBox
        '
        Me.NettoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_RitenuteBindingSource, "Netto", True))
        Me.NettoTextBox.Location = New System.Drawing.Point(536, 32)
        Me.NettoTextBox.Name = "NettoTextBox"
        Me.NettoTextBox.Size = New System.Drawing.Size(86, 20)
        Me.NettoTextBox.TabIndex = 13
        '
        'DataPagamentoLabel
        '
        DataPagamentoLabel.AutoSize = True
        DataPagamentoLabel.Location = New System.Drawing.Point(6, 65)
        DataPagamentoLabel.Name = "DataPagamentoLabel"
        DataPagamentoLabel.Size = New System.Drawing.Size(90, 13)
        DataPagamentoLabel.TabIndex = 14
        DataPagamentoLabel.Text = "Data Pagamento:"
        '
        'DataPagamentoDateTimePicker
        '
        Me.DataPagamentoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.W_RitenuteBindingSource, "DataPagamento", True))
        Me.DataPagamentoDateTimePicker.Location = New System.Drawing.Point(9, 81)
        Me.DataPagamentoDateTimePicker.Name = "DataPagamentoDateTimePicker"
        Me.DataPagamentoDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DataPagamentoDateTimePicker.TabIndex = 15
        '
        'AnnoLabel
        '
        AnnoLabel.AutoSize = True
        AnnoLabel.Location = New System.Drawing.Point(215, 65)
        AnnoLabel.Name = "AnnoLabel"
        AnnoLabel.Size = New System.Drawing.Size(35, 13)
        AnnoLabel.TabIndex = 16
        AnnoLabel.Text = "Anno:"
        '
        'AnnoTextBox
        '
        Me.AnnoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_RitenuteBindingSource, "Anno", True))
        Me.AnnoTextBox.Location = New System.Drawing.Point(218, 81)
        Me.AnnoTextBox.Name = "AnnoTextBox"
        Me.AnnoTextBox.Size = New System.Drawing.Size(46, 20)
        Me.AnnoTextBox.TabIndex = 17
        '
        'W_Ritenute
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 318)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(CausaleLabel)
        Me.Controls.Add(Me.CausaleTextBox)
        Me.Controls.Add(TributoLabel)
        Me.Controls.Add(Me.TributoTextBox)
        Me.Controls.Add(TrattamentoLabel)
        Me.Controls.Add(Me.TrattamentoComboBox)
        Me.Controls.Add(FornitoreLabel)
        Me.Controls.Add(Me.FornitoreComboBox)
        Me.Controls.Add(DataDocumentoLabel)
        Me.Controls.Add(Me.DataDocumentoDateTimePicker)
        Me.Controls.Add(DocumentoLabel)
        Me.Controls.Add(Me.DocumentoTextBox)
        Me.Controls.Add(ImmobileLabel)
        Me.Controls.Add(Me.ImmobileComboBox)
        Me.Controls.Add(ProgressivoLabel)
        Me.Controls.Add(Me.ProgressivoTextBox)
        Me.Name = "W_Ritenute"
        Me.Text = "Archivio Ritenute"
        CType(Me.IMMOBILIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.W_RitenuteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IMMOBILIDataSet As Patrimonio2014.IMMOBILIDataSet
    Friend WithEvents W_RitenuteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents W_RitenuteTableAdapter As Patrimonio2014.IMMOBILIDataSetTableAdapters.W_RitenuteTableAdapter
    Friend WithEvents TableAdapterManager As Patrimonio2014.IMMOBILIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProgressivoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ImmobileComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DocumentoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataDocumentoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents FornitoreComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TrattamentoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TributoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CausaleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents AnnoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataPagamentoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents NettoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RitenutaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ImponibileTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IvaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrevidenzaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EsenteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CompensoTextBox As System.Windows.Forms.TextBox
End Class
