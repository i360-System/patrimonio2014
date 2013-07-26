<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class X_MovimentiCondomini
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
        Dim AnagraficaLabel As System.Windows.Forms.Label
        Dim UnitaLabel As System.Windows.Forms.Label
        Dim RataLabel As System.Windows.Forms.Label
        Dim OperazioneLabel As System.Windows.Forms.Label
        Dim DescrizioneLabel As System.Windows.Forms.Label
        Dim DataOperazioneLabel As System.Windows.Forms.Label
        Dim ImportoLabel As System.Windows.Forms.Label
        Dim DataRiferimentoLabel As System.Windows.Forms.Label
        Dim RiferimentoContoFinanziarioLabel As System.Windows.Forms.Label
        Dim RiferimentoContoAnticipiLabel As System.Windows.Forms.Label
        Dim ContoLabel As System.Windows.Forms.Label
        Me.IMMOBILIDataSet = New Patrimonio2014.IMMOBILIDataSet()
        Me.X_MovimentiCondominiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.X_MovimentiCondominiTableAdapter = New Patrimonio2014.IMMOBILIDataSetTableAdapters.X_MovimentiCondominiTableAdapter()
        Me.TableAdapterManager = New Patrimonio2014.IMMOBILIDataSetTableAdapters.TableAdapterManager()
        Me.ProgressivoTextBox = New System.Windows.Forms.TextBox()
        Me.ImmobileComboBox = New System.Windows.Forms.ComboBox()
        Me.GestioneComboBox = New System.Windows.Forms.ComboBox()
        Me.AnagraficaComboBox = New System.Windows.Forms.ComboBox()
        Me.UnitaComboBox = New System.Windows.Forms.ComboBox()
        Me.RataTextBox = New System.Windows.Forms.TextBox()
        Me.OperazioneTextBox = New System.Windows.Forms.TextBox()
        Me.DescrizioneTextBox = New System.Windows.Forms.TextBox()
        Me.DataOperazioneDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ImportoTextBox = New System.Windows.Forms.TextBox()
        Me.DataRiferimentoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.RiferimentoContoFinanziarioComboBox = New System.Windows.Forms.ComboBox()
        Me.RiferimentoContoAnticipiComboBox = New System.Windows.Forms.ComboBox()
        Me.ContoComboBox = New System.Windows.Forms.ComboBox()
        ProgressivoLabel = New System.Windows.Forms.Label()
        ImmobileLabel = New System.Windows.Forms.Label()
        GestioneLabel = New System.Windows.Forms.Label()
        AnagraficaLabel = New System.Windows.Forms.Label()
        UnitaLabel = New System.Windows.Forms.Label()
        RataLabel = New System.Windows.Forms.Label()
        OperazioneLabel = New System.Windows.Forms.Label()
        DescrizioneLabel = New System.Windows.Forms.Label()
        DataOperazioneLabel = New System.Windows.Forms.Label()
        ImportoLabel = New System.Windows.Forms.Label()
        DataRiferimentoLabel = New System.Windows.Forms.Label()
        RiferimentoContoFinanziarioLabel = New System.Windows.Forms.Label()
        RiferimentoContoAnticipiLabel = New System.Windows.Forms.Label()
        ContoLabel = New System.Windows.Forms.Label()
        CType(Me.IMMOBILIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X_MovimentiCondominiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IMMOBILIDataSet
        '
        Me.IMMOBILIDataSet.DataSetName = "IMMOBILIDataSet"
        Me.IMMOBILIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'X_MovimentiCondominiBindingSource
        '
        Me.X_MovimentiCondominiBindingSource.DataMember = "X_MovimentiCondomini"
        Me.X_MovimentiCondominiBindingSource.DataSource = Me.IMMOBILIDataSet
        '
        'X_MovimentiCondominiTableAdapter
        '
        Me.X_MovimentiCondominiTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.X_MovimentiCondominiTableAdapter = Me.X_MovimentiCondominiTableAdapter
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
        ProgressivoLabel.Location = New System.Drawing.Point(12, 65)
        ProgressivoLabel.Name = "ProgressivoLabel"
        ProgressivoLabel.Size = New System.Drawing.Size(65, 13)
        ProgressivoLabel.TabIndex = 1
        ProgressivoLabel.Text = "Progressivo:"
        '
        'ProgressivoTextBox
        '
        Me.ProgressivoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_MovimentiCondominiBindingSource, "Progressivo", True))
        Me.ProgressivoTextBox.Location = New System.Drawing.Point(15, 81)
        Me.ProgressivoTextBox.Name = "ProgressivoTextBox"
        Me.ProgressivoTextBox.Size = New System.Drawing.Size(73, 20)
        Me.ProgressivoTextBox.TabIndex = 2
        '
        'ImmobileLabel
        '
        ImmobileLabel.AutoSize = True
        ImmobileLabel.Location = New System.Drawing.Point(128, 64)
        ImmobileLabel.Name = "ImmobileLabel"
        ImmobileLabel.Size = New System.Drawing.Size(51, 13)
        ImmobileLabel.TabIndex = 2
        ImmobileLabel.Text = "Immobile:"
        '
        'ImmobileComboBox
        '
        Me.ImmobileComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_MovimentiCondominiBindingSource, "Immobile", True))
        Me.ImmobileComboBox.FormattingEnabled = True
        Me.ImmobileComboBox.Location = New System.Drawing.Point(131, 80)
        Me.ImmobileComboBox.Name = "ImmobileComboBox"
        Me.ImmobileComboBox.Size = New System.Drawing.Size(286, 21)
        Me.ImmobileComboBox.TabIndex = 3
        '
        'GestioneLabel
        '
        GestioneLabel.AutoSize = True
        GestioneLabel.Location = New System.Drawing.Point(420, 65)
        GestioneLabel.Name = "GestioneLabel"
        GestioneLabel.Size = New System.Drawing.Size(52, 13)
        GestioneLabel.TabIndex = 4
        GestioneLabel.Text = "Gestione:"
        '
        'GestioneComboBox
        '
        Me.GestioneComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_MovimentiCondominiBindingSource, "Gestione", True))
        Me.GestioneComboBox.FormattingEnabled = True
        Me.GestioneComboBox.Location = New System.Drawing.Point(423, 81)
        Me.GestioneComboBox.Name = "GestioneComboBox"
        Me.GestioneComboBox.Size = New System.Drawing.Size(301, 21)
        Me.GestioneComboBox.TabIndex = 5
        '
        'AnagraficaLabel
        '
        AnagraficaLabel.AutoSize = True
        AnagraficaLabel.Location = New System.Drawing.Point(128, 105)
        AnagraficaLabel.Name = "AnagraficaLabel"
        AnagraficaLabel.Size = New System.Drawing.Size(61, 13)
        AnagraficaLabel.TabIndex = 6
        AnagraficaLabel.Text = "Anagrafica:"
        '
        'AnagraficaComboBox
        '
        Me.AnagraficaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_MovimentiCondominiBindingSource, "Anagrafica", True))
        Me.AnagraficaComboBox.FormattingEnabled = True
        Me.AnagraficaComboBox.Location = New System.Drawing.Point(131, 121)
        Me.AnagraficaComboBox.Name = "AnagraficaComboBox"
        Me.AnagraficaComboBox.Size = New System.Drawing.Size(286, 21)
        Me.AnagraficaComboBox.TabIndex = 7
        '
        'UnitaLabel
        '
        UnitaLabel.AutoSize = True
        UnitaLabel.Location = New System.Drawing.Point(420, 105)
        UnitaLabel.Name = "UnitaLabel"
        UnitaLabel.Size = New System.Drawing.Size(35, 13)
        UnitaLabel.TabIndex = 8
        UnitaLabel.Text = "Unita:"
        '
        'UnitaComboBox
        '
        Me.UnitaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_MovimentiCondominiBindingSource, "Unita", True))
        Me.UnitaComboBox.FormattingEnabled = True
        Me.UnitaComboBox.Location = New System.Drawing.Point(423, 121)
        Me.UnitaComboBox.Name = "UnitaComboBox"
        Me.UnitaComboBox.Size = New System.Drawing.Size(301, 21)
        Me.UnitaComboBox.TabIndex = 9
        '
        'RataLabel
        '
        RataLabel.AutoSize = True
        RataLabel.Location = New System.Drawing.Point(12, 153)
        RataLabel.Name = "RataLabel"
        RataLabel.Size = New System.Drawing.Size(33, 13)
        RataLabel.TabIndex = 10
        RataLabel.Text = "Rata:"
        '
        'RataTextBox
        '
        Me.RataTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_MovimentiCondominiBindingSource, "Rata", True))
        Me.RataTextBox.Location = New System.Drawing.Point(15, 169)
        Me.RataTextBox.Name = "RataTextBox"
        Me.RataTextBox.Size = New System.Drawing.Size(41, 20)
        Me.RataTextBox.TabIndex = 11
        '
        'OperazioneLabel
        '
        OperazioneLabel.AutoSize = True
        OperazioneLabel.Location = New System.Drawing.Point(62, 153)
        OperazioneLabel.Name = "OperazioneLabel"
        OperazioneLabel.Size = New System.Drawing.Size(64, 13)
        OperazioneLabel.TabIndex = 12
        OperazioneLabel.Text = "Operazione:"
        '
        'OperazioneTextBox
        '
        Me.OperazioneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_MovimentiCondominiBindingSource, "Operazione", True))
        Me.OperazioneTextBox.Location = New System.Drawing.Point(65, 169)
        Me.OperazioneTextBox.Name = "OperazioneTextBox"
        Me.OperazioneTextBox.Size = New System.Drawing.Size(46, 20)
        Me.OperazioneTextBox.TabIndex = 13
        '
        'DescrizioneLabel
        '
        DescrizioneLabel.AutoSize = True
        DescrizioneLabel.Location = New System.Drawing.Point(128, 153)
        DescrizioneLabel.Name = "DescrizioneLabel"
        DescrizioneLabel.Size = New System.Drawing.Size(65, 13)
        DescrizioneLabel.TabIndex = 14
        DescrizioneLabel.Text = "Descrizione:"
        '
        'DescrizioneTextBox
        '
        Me.DescrizioneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_MovimentiCondominiBindingSource, "Descrizione", True))
        Me.DescrizioneTextBox.Location = New System.Drawing.Point(131, 169)
        Me.DescrizioneTextBox.Name = "DescrizioneTextBox"
        Me.DescrizioneTextBox.Size = New System.Drawing.Size(286, 20)
        Me.DescrizioneTextBox.TabIndex = 15
        '
        'DataOperazioneLabel
        '
        DataOperazioneLabel.AutoSize = True
        DataOperazioneLabel.Location = New System.Drawing.Point(430, 153)
        DataOperazioneLabel.Name = "DataOperazioneLabel"
        DataOperazioneLabel.Size = New System.Drawing.Size(90, 13)
        DataOperazioneLabel.TabIndex = 16
        DataOperazioneLabel.Text = "Data Operazione:"
        '
        'DataOperazioneDateTimePicker
        '
        Me.DataOperazioneDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.X_MovimentiCondominiBindingSource, "DataOperazione", True))
        Me.DataOperazioneDateTimePicker.Location = New System.Drawing.Point(423, 169)
        Me.DataOperazioneDateTimePicker.Name = "DataOperazioneDateTimePicker"
        Me.DataOperazioneDateTimePicker.Size = New System.Drawing.Size(196, 20)
        Me.DataOperazioneDateTimePicker.TabIndex = 17
        '
        'ImportoLabel
        '
        ImportoLabel.AutoSize = True
        ImportoLabel.Location = New System.Drawing.Point(627, 153)
        ImportoLabel.Name = "ImportoLabel"
        ImportoLabel.Size = New System.Drawing.Size(45, 13)
        ImportoLabel.TabIndex = 18
        ImportoLabel.Text = "Importo:"
        '
        'ImportoTextBox
        '
        Me.ImportoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_MovimentiCondominiBindingSource, "Importo", True))
        Me.ImportoTextBox.Location = New System.Drawing.Point(630, 169)
        Me.ImportoTextBox.Name = "ImportoTextBox"
        Me.ImportoTextBox.Size = New System.Drawing.Size(94, 20)
        Me.ImportoTextBox.TabIndex = 19
        '
        'DataRiferimentoLabel
        '
        DataRiferimentoLabel.AutoSize = True
        DataRiferimentoLabel.Location = New System.Drawing.Point(12, 204)
        DataRiferimentoLabel.Name = "DataRiferimentoLabel"
        DataRiferimentoLabel.Size = New System.Drawing.Size(89, 13)
        DataRiferimentoLabel.TabIndex = 20
        DataRiferimentoLabel.Text = "Data Riferimento:"
        '
        'DataRiferimentoDateTimePicker
        '
        Me.DataRiferimentoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.X_MovimentiCondominiBindingSource, "DataRiferimento", True))
        Me.DataRiferimentoDateTimePicker.Location = New System.Drawing.Point(15, 220)
        Me.DataRiferimentoDateTimePicker.Name = "DataRiferimentoDateTimePicker"
        Me.DataRiferimentoDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DataRiferimentoDateTimePicker.TabIndex = 21
        '
        'RiferimentoContoFinanziarioLabel
        '
        RiferimentoContoFinanziarioLabel.AutoSize = True
        RiferimentoContoFinanziarioLabel.Location = New System.Drawing.Point(221, 204)
        RiferimentoContoFinanziarioLabel.Name = "RiferimentoContoFinanziarioLabel"
        RiferimentoContoFinanziarioLabel.Size = New System.Drawing.Size(147, 13)
        RiferimentoContoFinanziarioLabel.TabIndex = 22
        RiferimentoContoFinanziarioLabel.Text = "Riferimento Conto Finanziario:"
        '
        'RiferimentoContoFinanziarioComboBox
        '
        Me.RiferimentoContoFinanziarioComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_MovimentiCondominiBindingSource, "RiferimentoContoFinanziario", True))
        Me.RiferimentoContoFinanziarioComboBox.FormattingEnabled = True
        Me.RiferimentoContoFinanziarioComboBox.Location = New System.Drawing.Point(224, 219)
        Me.RiferimentoContoFinanziarioComboBox.Name = "RiferimentoContoFinanziarioComboBox"
        Me.RiferimentoContoFinanziarioComboBox.Size = New System.Drawing.Size(193, 21)
        Me.RiferimentoContoFinanziarioComboBox.TabIndex = 23
        '
        'RiferimentoContoAnticipiLabel
        '
        RiferimentoContoAnticipiLabel.AutoSize = True
        RiferimentoContoAnticipiLabel.Location = New System.Drawing.Point(423, 204)
        RiferimentoContoAnticipiLabel.Name = "RiferimentoContoAnticipiLabel"
        RiferimentoContoAnticipiLabel.Size = New System.Drawing.Size(131, 13)
        RiferimentoContoAnticipiLabel.TabIndex = 24
        RiferimentoContoAnticipiLabel.Text = "Riferimento Conto Anticipi:"
        '
        'RiferimentoContoAnticipiComboBox
        '
        Me.RiferimentoContoAnticipiComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_MovimentiCondominiBindingSource, "RiferimentoContoAnticipi", True))
        Me.RiferimentoContoAnticipiComboBox.FormattingEnabled = True
        Me.RiferimentoContoAnticipiComboBox.Location = New System.Drawing.Point(423, 219)
        Me.RiferimentoContoAnticipiComboBox.Name = "RiferimentoContoAnticipiComboBox"
        Me.RiferimentoContoAnticipiComboBox.Size = New System.Drawing.Size(196, 21)
        Me.RiferimentoContoAnticipiComboBox.TabIndex = 25
        '
        'ContoLabel
        '
        ContoLabel.AutoSize = True
        ContoLabel.Location = New System.Drawing.Point(627, 204)
        ContoLabel.Name = "ContoLabel"
        ContoLabel.Size = New System.Drawing.Size(38, 13)
        ContoLabel.TabIndex = 26
        ContoLabel.Text = "Conto:"
        '
        'ContoComboBox
        '
        Me.ContoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_MovimentiCondominiBindingSource, "Conto", True))
        Me.ContoComboBox.FormattingEnabled = True
        Me.ContoComboBox.Location = New System.Drawing.Point(630, 219)
        Me.ContoComboBox.Name = "ContoComboBox"
        Me.ContoComboBox.Size = New System.Drawing.Size(94, 21)
        Me.ContoComboBox.TabIndex = 27
        '
        'X_MovimentiCondomini
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 262)
        Me.Controls.Add(ContoLabel)
        Me.Controls.Add(Me.ContoComboBox)
        Me.Controls.Add(RiferimentoContoAnticipiLabel)
        Me.Controls.Add(Me.RiferimentoContoAnticipiComboBox)
        Me.Controls.Add(RiferimentoContoFinanziarioLabel)
        Me.Controls.Add(Me.RiferimentoContoFinanziarioComboBox)
        Me.Controls.Add(DataRiferimentoLabel)
        Me.Controls.Add(Me.DataRiferimentoDateTimePicker)
        Me.Controls.Add(ImportoLabel)
        Me.Controls.Add(Me.ImportoTextBox)
        Me.Controls.Add(DataOperazioneLabel)
        Me.Controls.Add(Me.DataOperazioneDateTimePicker)
        Me.Controls.Add(DescrizioneLabel)
        Me.Controls.Add(Me.DescrizioneTextBox)
        Me.Controls.Add(OperazioneLabel)
        Me.Controls.Add(Me.OperazioneTextBox)
        Me.Controls.Add(RataLabel)
        Me.Controls.Add(Me.RataTextBox)
        Me.Controls.Add(UnitaLabel)
        Me.Controls.Add(Me.UnitaComboBox)
        Me.Controls.Add(AnagraficaLabel)
        Me.Controls.Add(Me.AnagraficaComboBox)
        Me.Controls.Add(GestioneLabel)
        Me.Controls.Add(Me.GestioneComboBox)
        Me.Controls.Add(ImmobileLabel)
        Me.Controls.Add(Me.ImmobileComboBox)
        Me.Controls.Add(ProgressivoLabel)
        Me.Controls.Add(Me.ProgressivoTextBox)
        Me.Name = "X_MovimentiCondomini"
        Me.Text = "Movimenti dei Condomini"
        CType(Me.IMMOBILIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X_MovimentiCondominiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IMMOBILIDataSet As Patrimonio2014.IMMOBILIDataSet
    Friend WithEvents X_MovimentiCondominiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents X_MovimentiCondominiTableAdapter As Patrimonio2014.IMMOBILIDataSetTableAdapters.X_MovimentiCondominiTableAdapter
    Friend WithEvents TableAdapterManager As Patrimonio2014.IMMOBILIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProgressivoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ImmobileComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GestioneComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AnagraficaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents UnitaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents RataTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OperazioneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescrizioneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataOperazioneDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ImportoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataRiferimentoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents RiferimentoContoFinanziarioComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents RiferimentoContoAnticipiComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ContoComboBox As System.Windows.Forms.ComboBox
End Class
