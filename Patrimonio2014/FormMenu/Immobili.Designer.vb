<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Immobili
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
        Dim DenominazioneLabel As System.Windows.Forms.Label
        Dim IndirizzoLabel As System.Windows.Forms.Label
        Dim CapLabel As System.Windows.Forms.Label
        Dim LocalitaLabel As System.Windows.Forms.Label
        Dim ProvinciaLabel As System.Windows.Forms.Label
        Dim CodiceFiscaleLabel As System.Windows.Forms.Label
        Dim GruppoSpesaLabel As System.Windows.Forms.Label
        Dim PdcPreventivoLabel As System.Windows.Forms.Label
        Dim PdcConsuntivoLabel As System.Windows.Forms.Label
        Dim ContoBancaLabel As System.Windows.Forms.Label
        Dim ContoCassaLabel As System.Windows.Forms.Label
        Dim ContoAnticipiLabel As System.Windows.Forms.Label
        Dim ModuloCorrispondenzaLabel As System.Windows.Forms.Label
        Dim PercentoInteressiLabel As System.Windows.Forms.Label
        Dim GiorniScadenzaAvvisoLabel As System.Windows.Forms.Label
        Dim ArrotondamentoRateLabel As System.Windows.Forms.Label
        Dim SpeseIncassoLabel As System.Windows.Forms.Label
        Dim SaldoSuAvvisoLabel As System.Windows.Forms.Label
        Dim RiportiSuAvvisoLabel As System.Windows.Forms.Label
        Dim GruppoMillesimiLabel As System.Windows.Forms.Label
        Dim StudioLabel As System.Windows.Forms.Label
        Dim NoteLabel As System.Windows.Forms.Label
        Me.IMMOBILIDataSet = New Patrimonio2014.IMMOBILIDataSet()
        Me.ImmobiliBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImmobiliTableAdapter = New Patrimonio2014.IMMOBILIDataSetTableAdapters.ImmobiliTableAdapter()
        Me.TableAdapterManager = New Patrimonio2014.IMMOBILIDataSetTableAdapters.TableAdapterManager()
        Me.ImmobileTextBox = New System.Windows.Forms.TextBox()
        Me.DenominazioneTextBox = New System.Windows.Forms.TextBox()
        Me.IndirizzoTextBox = New System.Windows.Forms.TextBox()
        Me.CapTextBox = New System.Windows.Forms.TextBox()
        Me.LocalitaTextBox = New System.Windows.Forms.TextBox()
        Me.ProvinciaTextBox = New System.Windows.Forms.TextBox()
        Me.CodiceFiscaleTextBox = New System.Windows.Forms.TextBox()
        Me.GruppoSpesaComboBox = New System.Windows.Forms.ComboBox()
        Me.PdcPreventivoComboBox = New System.Windows.Forms.ComboBox()
        Me.PdcConsuntivoComboBox = New System.Windows.Forms.ComboBox()
        Me.ContoBancaComboBox = New System.Windows.Forms.ComboBox()
        Me.ContoCassaComboBox = New System.Windows.Forms.ComboBox()
        Me.ContoAnticipiComboBox = New System.Windows.Forms.ComboBox()
        Me.ModuloCorrispondenzaTextBox = New System.Windows.Forms.TextBox()
        Me.PercentoInteressiTextBox = New System.Windows.Forms.TextBox()
        Me.GiorniScadenzaAvvisoTextBox = New System.Windows.Forms.TextBox()
        Me.ArrotondamentoRateTextBox = New System.Windows.Forms.TextBox()
        Me.SpeseIncassoTextBox = New System.Windows.Forms.TextBox()
        Me.SaldoSuAvvisoTextBox = New System.Windows.Forms.TextBox()
        Me.RiportiSuAvvisoTextBox = New System.Windows.Forms.TextBox()
        Me.GruppoMillesimiTextBox = New System.Windows.Forms.TextBox()
        Me.StudioComboBox = New System.Windows.Forms.ComboBox()
        Me.NoteTextBox = New System.Windows.Forms.TextBox()
        ImmobileLabel = New System.Windows.Forms.Label()
        DenominazioneLabel = New System.Windows.Forms.Label()
        IndirizzoLabel = New System.Windows.Forms.Label()
        CapLabel = New System.Windows.Forms.Label()
        LocalitaLabel = New System.Windows.Forms.Label()
        ProvinciaLabel = New System.Windows.Forms.Label()
        CodiceFiscaleLabel = New System.Windows.Forms.Label()
        GruppoSpesaLabel = New System.Windows.Forms.Label()
        PdcPreventivoLabel = New System.Windows.Forms.Label()
        PdcConsuntivoLabel = New System.Windows.Forms.Label()
        ContoBancaLabel = New System.Windows.Forms.Label()
        ContoCassaLabel = New System.Windows.Forms.Label()
        ContoAnticipiLabel = New System.Windows.Forms.Label()
        ModuloCorrispondenzaLabel = New System.Windows.Forms.Label()
        PercentoInteressiLabel = New System.Windows.Forms.Label()
        GiorniScadenzaAvvisoLabel = New System.Windows.Forms.Label()
        ArrotondamentoRateLabel = New System.Windows.Forms.Label()
        SpeseIncassoLabel = New System.Windows.Forms.Label()
        SaldoSuAvvisoLabel = New System.Windows.Forms.Label()
        RiportiSuAvvisoLabel = New System.Windows.Forms.Label()
        GruppoMillesimiLabel = New System.Windows.Forms.Label()
        StudioLabel = New System.Windows.Forms.Label()
        NoteLabel = New System.Windows.Forms.Label()
        CType(Me.IMMOBILIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImmobiliBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IMMOBILIDataSet
        '
        Me.IMMOBILIDataSet.DataSetName = "IMMOBILIDataSet"
        Me.IMMOBILIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ImmobiliBindingSource
        '
        Me.ImmobiliBindingSource.DataMember = "Immobili"
        Me.ImmobiliBindingSource.DataSource = Me.IMMOBILIDataSet
        '
        'ImmobiliTableAdapter
        '
        Me.ImmobiliTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.ImmobiliTableAdapter = Me.ImmobiliTableAdapter
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
        ImmobileLabel.Location = New System.Drawing.Point(20, 63)
        ImmobileLabel.Name = "ImmobileLabel"
        ImmobileLabel.Size = New System.Drawing.Size(51, 13)
        ImmobileLabel.TabIndex = 1
        ImmobileLabel.Text = "Immobile:"
        '
        'ImmobileTextBox
        '
        Me.ImmobileTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImmobiliBindingSource, "Immobile", True))
        Me.ImmobileTextBox.Location = New System.Drawing.Point(23, 79)
        Me.ImmobileTextBox.Name = "ImmobileTextBox"
        Me.ImmobileTextBox.Size = New System.Drawing.Size(57, 20)
        Me.ImmobileTextBox.TabIndex = 2
        '
        'DenominazioneLabel
        '
        DenominazioneLabel.AutoSize = True
        DenominazioneLabel.Location = New System.Drawing.Point(88, 63)
        DenominazioneLabel.Name = "DenominazioneLabel"
        DenominazioneLabel.Size = New System.Drawing.Size(83, 13)
        DenominazioneLabel.TabIndex = 2
        DenominazioneLabel.Text = "Denominazione:"
        '
        'DenominazioneTextBox
        '
        Me.DenominazioneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImmobiliBindingSource, "Denominazione", True))
        Me.DenominazioneTextBox.Location = New System.Drawing.Point(91, 79)
        Me.DenominazioneTextBox.Name = "DenominazioneTextBox"
        Me.DenominazioneTextBox.Size = New System.Drawing.Size(217, 20)
        Me.DenominazioneTextBox.TabIndex = 3
        '
        'IndirizzoLabel
        '
        IndirizzoLabel.AutoSize = True
        IndirizzoLabel.Location = New System.Drawing.Point(88, 102)
        IndirizzoLabel.Name = "IndirizzoLabel"
        IndirizzoLabel.Size = New System.Drawing.Size(48, 13)
        IndirizzoLabel.TabIndex = 4
        IndirizzoLabel.Text = "Indirizzo:"
        '
        'IndirizzoTextBox
        '
        Me.IndirizzoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImmobiliBindingSource, "Indirizzo", True))
        Me.IndirizzoTextBox.Location = New System.Drawing.Point(91, 118)
        Me.IndirizzoTextBox.Name = "IndirizzoTextBox"
        Me.IndirizzoTextBox.Size = New System.Drawing.Size(217, 20)
        Me.IndirizzoTextBox.TabIndex = 5
        '
        'CapLabel
        '
        CapLabel.AutoSize = True
        CapLabel.Location = New System.Drawing.Point(20, 141)
        CapLabel.Name = "CapLabel"
        CapLabel.Size = New System.Drawing.Size(29, 13)
        CapLabel.TabIndex = 6
        CapLabel.Text = "Cap:"
        '
        'CapTextBox
        '
        Me.CapTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImmobiliBindingSource, "Cap", True))
        Me.CapTextBox.Location = New System.Drawing.Point(23, 157)
        Me.CapTextBox.Name = "CapTextBox"
        Me.CapTextBox.Size = New System.Drawing.Size(64, 20)
        Me.CapTextBox.TabIndex = 7
        '
        'LocalitaLabel
        '
        LocalitaLabel.AutoSize = True
        LocalitaLabel.Location = New System.Drawing.Point(89, 141)
        LocalitaLabel.Name = "LocalitaLabel"
        LocalitaLabel.Size = New System.Drawing.Size(47, 13)
        LocalitaLabel.TabIndex = 8
        LocalitaLabel.Text = "Localita:"
        '
        'LocalitaTextBox
        '
        Me.LocalitaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImmobiliBindingSource, "Localita", True))
        Me.LocalitaTextBox.Location = New System.Drawing.Point(93, 157)
        Me.LocalitaTextBox.Name = "LocalitaTextBox"
        Me.LocalitaTextBox.Size = New System.Drawing.Size(215, 20)
        Me.LocalitaTextBox.TabIndex = 9
        '
        'ProvinciaLabel
        '
        ProvinciaLabel.AutoSize = True
        ProvinciaLabel.Location = New System.Drawing.Point(323, 141)
        ProvinciaLabel.Name = "ProvinciaLabel"
        ProvinciaLabel.Size = New System.Drawing.Size(54, 13)
        ProvinciaLabel.TabIndex = 10
        ProvinciaLabel.Text = "Provincia:"
        '
        'ProvinciaTextBox
        '
        Me.ProvinciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImmobiliBindingSource, "Provincia", True))
        Me.ProvinciaTextBox.Location = New System.Drawing.Point(326, 157)
        Me.ProvinciaTextBox.Name = "ProvinciaTextBox"
        Me.ProvinciaTextBox.Size = New System.Drawing.Size(51, 20)
        Me.ProvinciaTextBox.TabIndex = 11
        '
        'CodiceFiscaleLabel
        '
        CodiceFiscaleLabel.AutoSize = True
        CodiceFiscaleLabel.Location = New System.Drawing.Point(323, 63)
        CodiceFiscaleLabel.Name = "CodiceFiscaleLabel"
        CodiceFiscaleLabel.Size = New System.Drawing.Size(79, 13)
        CodiceFiscaleLabel.TabIndex = 12
        CodiceFiscaleLabel.Text = "Codice Fiscale:"
        '
        'CodiceFiscaleTextBox
        '
        Me.CodiceFiscaleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImmobiliBindingSource, "CodiceFiscale", True))
        Me.CodiceFiscaleTextBox.Location = New System.Drawing.Point(326, 79)
        Me.CodiceFiscaleTextBox.Name = "CodiceFiscaleTextBox"
        Me.CodiceFiscaleTextBox.Size = New System.Drawing.Size(198, 20)
        Me.CodiceFiscaleTextBox.TabIndex = 13
        '
        'GruppoSpesaLabel
        '
        GruppoSpesaLabel.AutoSize = True
        GruppoSpesaLabel.Location = New System.Drawing.Point(88, 191)
        GruppoSpesaLabel.Name = "GruppoSpesaLabel"
        GruppoSpesaLabel.Size = New System.Drawing.Size(78, 13)
        GruppoSpesaLabel.TabIndex = 14
        GruppoSpesaLabel.Text = "Gruppo Spesa:"
        '
        'GruppoSpesaComboBox
        '
        Me.GruppoSpesaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImmobiliBindingSource, "GruppoSpesa", True))
        Me.GruppoSpesaComboBox.FormattingEnabled = True
        Me.GruppoSpesaComboBox.Location = New System.Drawing.Point(91, 207)
        Me.GruppoSpesaComboBox.Name = "GruppoSpesaComboBox"
        Me.GruppoSpesaComboBox.Size = New System.Drawing.Size(217, 21)
        Me.GruppoSpesaComboBox.TabIndex = 15
        '
        'PdcPreventivoLabel
        '
        PdcPreventivoLabel.AutoSize = True
        PdcPreventivoLabel.Location = New System.Drawing.Point(319, 191)
        PdcPreventivoLabel.Name = "PdcPreventivoLabel"
        PdcPreventivoLabel.Size = New System.Drawing.Size(135, 13)
        PdcPreventivoLabel.TabIndex = 16
        PdcPreventivoLabel.Text = "Piano Conti del Preventivo:"
        '
        'PdcPreventivoComboBox
        '
        Me.PdcPreventivoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImmobiliBindingSource, "PdcPreventivo", True))
        Me.PdcPreventivoComboBox.FormattingEnabled = True
        Me.PdcPreventivoComboBox.Location = New System.Drawing.Point(322, 207)
        Me.PdcPreventivoComboBox.Name = "PdcPreventivoComboBox"
        Me.PdcPreventivoComboBox.Size = New System.Drawing.Size(202, 21)
        Me.PdcPreventivoComboBox.TabIndex = 17
        '
        'PdcConsuntivoLabel
        '
        PdcConsuntivoLabel.AutoSize = True
        PdcConsuntivoLabel.Location = New System.Drawing.Point(539, 191)
        PdcConsuntivoLabel.Name = "PdcConsuntivoLabel"
        PdcConsuntivoLabel.Size = New System.Drawing.Size(120, 13)
        PdcConsuntivoLabel.TabIndex = 18
        PdcConsuntivoLabel.Text = "Piano Conti Consuntivo:"
        '
        'PdcConsuntivoComboBox
        '
        Me.PdcConsuntivoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImmobiliBindingSource, "PdcConsuntivo", True))
        Me.PdcConsuntivoComboBox.FormattingEnabled = True
        Me.PdcConsuntivoComboBox.Location = New System.Drawing.Point(542, 207)
        Me.PdcConsuntivoComboBox.Name = "PdcConsuntivoComboBox"
        Me.PdcConsuntivoComboBox.Size = New System.Drawing.Size(202, 21)
        Me.PdcConsuntivoComboBox.TabIndex = 19
        '
        'ContoBancaLabel
        '
        ContoBancaLabel.AutoSize = True
        ContoBancaLabel.Location = New System.Drawing.Point(90, 231)
        ContoBancaLabel.Name = "ContoBancaLabel"
        ContoBancaLabel.Size = New System.Drawing.Size(72, 13)
        ContoBancaLabel.TabIndex = 20
        ContoBancaLabel.Text = "Conto Banca:"
        '
        'ContoBancaComboBox
        '
        Me.ContoBancaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImmobiliBindingSource, "ContoBanca", True))
        Me.ContoBancaComboBox.FormattingEnabled = True
        Me.ContoBancaComboBox.Location = New System.Drawing.Point(93, 247)
        Me.ContoBancaComboBox.Name = "ContoBancaComboBox"
        Me.ContoBancaComboBox.Size = New System.Drawing.Size(215, 21)
        Me.ContoBancaComboBox.TabIndex = 21
        '
        'ContoCassaLabel
        '
        ContoCassaLabel.AutoSize = True
        ContoCassaLabel.Location = New System.Drawing.Point(319, 231)
        ContoCassaLabel.Name = "ContoCassaLabel"
        ContoCassaLabel.Size = New System.Drawing.Size(70, 13)
        ContoCassaLabel.TabIndex = 22
        ContoCassaLabel.Text = "Conto Cassa:"
        '
        'ContoCassaComboBox
        '
        Me.ContoCassaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImmobiliBindingSource, "ContoCassa", True))
        Me.ContoCassaComboBox.FormattingEnabled = True
        Me.ContoCassaComboBox.Location = New System.Drawing.Point(322, 247)
        Me.ContoCassaComboBox.Name = "ContoCassaComboBox"
        Me.ContoCassaComboBox.Size = New System.Drawing.Size(202, 21)
        Me.ContoCassaComboBox.TabIndex = 23
        '
        'ContoAnticipiLabel
        '
        ContoAnticipiLabel.AutoSize = True
        ContoAnticipiLabel.Location = New System.Drawing.Point(539, 231)
        ContoAnticipiLabel.Name = "ContoAnticipiLabel"
        ContoAnticipiLabel.Size = New System.Drawing.Size(75, 13)
        ContoAnticipiLabel.TabIndex = 24
        ContoAnticipiLabel.Text = "Conto Anticipi:"
        '
        'ContoAnticipiComboBox
        '
        Me.ContoAnticipiComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImmobiliBindingSource, "ContoAnticipi", True))
        Me.ContoAnticipiComboBox.FormattingEnabled = True
        Me.ContoAnticipiComboBox.Location = New System.Drawing.Point(542, 247)
        Me.ContoAnticipiComboBox.Name = "ContoAnticipiComboBox"
        Me.ContoAnticipiComboBox.Size = New System.Drawing.Size(202, 21)
        Me.ContoAnticipiComboBox.TabIndex = 25
        '
        'ModuloCorrispondenzaLabel
        '
        ModuloCorrispondenzaLabel.AutoSize = True
        ModuloCorrispondenzaLabel.Location = New System.Drawing.Point(90, 282)
        ModuloCorrispondenzaLabel.Name = "ModuloCorrispondenzaLabel"
        ModuloCorrispondenzaLabel.Size = New System.Drawing.Size(178, 13)
        ModuloCorrispondenzaLabel.TabIndex = 26
        ModuloCorrispondenzaLabel.Text = "Indirizzamento Archiviazione Digitale"
        '
        'ModuloCorrispondenzaTextBox
        '
        Me.ModuloCorrispondenzaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImmobiliBindingSource, "ModuloCorrispondenza", True))
        Me.ModuloCorrispondenzaTextBox.Location = New System.Drawing.Point(91, 298)
        Me.ModuloCorrispondenzaTextBox.Name = "ModuloCorrispondenzaTextBox"
        Me.ModuloCorrispondenzaTextBox.Size = New System.Drawing.Size(217, 20)
        Me.ModuloCorrispondenzaTextBox.TabIndex = 27
        '
        'PercentoInteressiLabel
        '
        PercentoInteressiLabel.AutoSize = True
        PercentoInteressiLabel.Location = New System.Drawing.Point(323, 282)
        PercentoInteressiLabel.Name = "PercentoInteressiLabel"
        PercentoInteressiLabel.Size = New System.Drawing.Size(95, 13)
        PercentoInteressiLabel.TabIndex = 28
        PercentoInteressiLabel.Text = "Percento Interessi:"
        '
        'PercentoInteressiTextBox
        '
        Me.PercentoInteressiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImmobiliBindingSource, "PercentoInteressi", True))
        Me.PercentoInteressiTextBox.Location = New System.Drawing.Point(326, 298)
        Me.PercentoInteressiTextBox.Name = "PercentoInteressiTextBox"
        Me.PercentoInteressiTextBox.Size = New System.Drawing.Size(92, 20)
        Me.PercentoInteressiTextBox.TabIndex = 29
        '
        'GiorniScadenzaAvvisoLabel
        '
        GiorniScadenzaAvvisoLabel.AutoSize = True
        GiorniScadenzaAvvisoLabel.Location = New System.Drawing.Point(424, 282)
        GiorniScadenzaAvvisoLabel.Name = "GiorniScadenzaAvvisoLabel"
        GiorniScadenzaAvvisoLabel.Size = New System.Drawing.Size(103, 13)
        GiorniScadenzaAvvisoLabel.TabIndex = 30
        GiorniScadenzaAvvisoLabel.Text = "GG Scad.za Avviso:"
        '
        'GiorniScadenzaAvvisoTextBox
        '
        Me.GiorniScadenzaAvvisoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImmobiliBindingSource, "GiorniScadenzaAvviso", True))
        Me.GiorniScadenzaAvvisoTextBox.Location = New System.Drawing.Point(427, 298)
        Me.GiorniScadenzaAvvisoTextBox.Name = "GiorniScadenzaAvvisoTextBox"
        Me.GiorniScadenzaAvvisoTextBox.Size = New System.Drawing.Size(97, 20)
        Me.GiorniScadenzaAvvisoTextBox.TabIndex = 31
        '
        'ArrotondamentoRateLabel
        '
        ArrotondamentoRateLabel.AutoSize = True
        ArrotondamentoRateLabel.Location = New System.Drawing.Point(539, 282)
        ArrotondamentoRateLabel.Name = "ArrotondamentoRateLabel"
        ArrotondamentoRateLabel.Size = New System.Drawing.Size(111, 13)
        ArrotondamentoRateLabel.TabIndex = 32
        ArrotondamentoRateLabel.Text = "Arrotondamento Rate:"
        '
        'ArrotondamentoRateTextBox
        '
        Me.ArrotondamentoRateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImmobiliBindingSource, "ArrotondamentoRate", True))
        Me.ArrotondamentoRateTextBox.Location = New System.Drawing.Point(542, 298)
        Me.ArrotondamentoRateTextBox.Name = "ArrotondamentoRateTextBox"
        Me.ArrotondamentoRateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ArrotondamentoRateTextBox.TabIndex = 33
        '
        'SpeseIncassoLabel
        '
        SpeseIncassoLabel.AutoSize = True
        SpeseIncassoLabel.Location = New System.Drawing.Point(656, 282)
        SpeseIncassoLabel.Name = "SpeseIncassoLabel"
        SpeseIncassoLabel.Size = New System.Drawing.Size(80, 13)
        SpeseIncassoLabel.TabIndex = 34
        SpeseIncassoLabel.Text = "Spese Incasso:"
        '
        'SpeseIncassoTextBox
        '
        Me.SpeseIncassoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImmobiliBindingSource, "SpeseIncasso", True))
        Me.SpeseIncassoTextBox.Location = New System.Drawing.Point(659, 298)
        Me.SpeseIncassoTextBox.Name = "SpeseIncassoTextBox"
        Me.SpeseIncassoTextBox.Size = New System.Drawing.Size(85, 20)
        Me.SpeseIncassoTextBox.TabIndex = 35
        '
        'SaldoSuAvvisoLabel
        '
        SaldoSuAvvisoLabel.AutoSize = True
        SaldoSuAvvisoLabel.Location = New System.Drawing.Point(90, 321)
        SaldoSuAvvisoLabel.Name = "SaldoSuAvvisoLabel"
        SaldoSuAvvisoLabel.Size = New System.Drawing.Size(88, 13)
        SaldoSuAvvisoLabel.TabIndex = 36
        SaldoSuAvvisoLabel.Text = "Saldo Su Avviso:"
        '
        'SaldoSuAvvisoTextBox
        '
        Me.SaldoSuAvvisoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImmobiliBindingSource, "SaldoSuAvviso", True))
        Me.SaldoSuAvvisoTextBox.Location = New System.Drawing.Point(93, 337)
        Me.SaldoSuAvvisoTextBox.Name = "SaldoSuAvvisoTextBox"
        Me.SaldoSuAvvisoTextBox.Size = New System.Drawing.Size(94, 20)
        Me.SaldoSuAvvisoTextBox.TabIndex = 37
        '
        'RiportiSuAvvisoLabel
        '
        RiportiSuAvvisoLabel.AutoSize = True
        RiportiSuAvvisoLabel.Location = New System.Drawing.Point(211, 321)
        RiportiSuAvvisoLabel.Name = "RiportiSuAvvisoLabel"
        RiportiSuAvvisoLabel.Size = New System.Drawing.Size(91, 13)
        RiportiSuAvvisoLabel.TabIndex = 38
        RiportiSuAvvisoLabel.Text = "Riporti Su Avviso:"
        '
        'RiportiSuAvvisoTextBox
        '
        Me.RiportiSuAvvisoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImmobiliBindingSource, "RiportiSuAvviso", True))
        Me.RiportiSuAvvisoTextBox.Location = New System.Drawing.Point(214, 337)
        Me.RiportiSuAvvisoTextBox.Name = "RiportiSuAvvisoTextBox"
        Me.RiportiSuAvvisoTextBox.Size = New System.Drawing.Size(94, 20)
        Me.RiportiSuAvvisoTextBox.TabIndex = 39
        '
        'GruppoMillesimiLabel
        '
        GruppoMillesimiLabel.AutoSize = True
        GruppoMillesimiLabel.Location = New System.Drawing.Point(323, 321)
        GruppoMillesimiLabel.Name = "GruppoMillesimiLabel"
        GruppoMillesimiLabel.Size = New System.Drawing.Size(86, 13)
        GruppoMillesimiLabel.TabIndex = 40
        GruppoMillesimiLabel.Text = "Gruppo Millesimi:"
        '
        'GruppoMillesimiTextBox
        '
        Me.GruppoMillesimiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImmobiliBindingSource, "GruppoMillesimi", True))
        Me.GruppoMillesimiTextBox.Location = New System.Drawing.Point(326, 337)
        Me.GruppoMillesimiTextBox.Name = "GruppoMillesimiTextBox"
        Me.GruppoMillesimiTextBox.Size = New System.Drawing.Size(92, 20)
        Me.GruppoMillesimiTextBox.TabIndex = 41
        '
        'StudioLabel
        '
        StudioLabel.AutoSize = True
        StudioLabel.Location = New System.Drawing.Point(539, 63)
        StudioLabel.Name = "StudioLabel"
        StudioLabel.Size = New System.Drawing.Size(40, 13)
        StudioLabel.TabIndex = 42
        StudioLabel.Text = "Studio:"
        '
        'StudioComboBox
        '
        Me.StudioComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImmobiliBindingSource, "Studio", True))
        Me.StudioComboBox.FormattingEnabled = True
        Me.StudioComboBox.Location = New System.Drawing.Point(542, 79)
        Me.StudioComboBox.Name = "StudioComboBox"
        Me.StudioComboBox.Size = New System.Drawing.Size(202, 21)
        Me.StudioComboBox.TabIndex = 43
        '
        'NoteLabel
        '
        NoteLabel.AutoSize = True
        NoteLabel.Location = New System.Drawing.Point(90, 380)
        NoteLabel.Name = "NoteLabel"
        NoteLabel.Size = New System.Drawing.Size(33, 13)
        NoteLabel.TabIndex = 44
        NoteLabel.Text = "Note:"
        '
        'NoteTextBox
        '
        Me.NoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImmobiliBindingSource, "Note", True))
        Me.NoteTextBox.Location = New System.Drawing.Point(93, 396)
        Me.NoteTextBox.Name = "NoteTextBox"
        Me.NoteTextBox.Size = New System.Drawing.Size(651, 20)
        Me.NoteTextBox.TabIndex = 45
        '
        'Immobili
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 428)
        Me.Controls.Add(NoteLabel)
        Me.Controls.Add(Me.NoteTextBox)
        Me.Controls.Add(StudioLabel)
        Me.Controls.Add(Me.StudioComboBox)
        Me.Controls.Add(GruppoMillesimiLabel)
        Me.Controls.Add(Me.GruppoMillesimiTextBox)
        Me.Controls.Add(RiportiSuAvvisoLabel)
        Me.Controls.Add(Me.RiportiSuAvvisoTextBox)
        Me.Controls.Add(SaldoSuAvvisoLabel)
        Me.Controls.Add(Me.SaldoSuAvvisoTextBox)
        Me.Controls.Add(SpeseIncassoLabel)
        Me.Controls.Add(Me.SpeseIncassoTextBox)
        Me.Controls.Add(ArrotondamentoRateLabel)
        Me.Controls.Add(Me.ArrotondamentoRateTextBox)
        Me.Controls.Add(GiorniScadenzaAvvisoLabel)
        Me.Controls.Add(Me.GiorniScadenzaAvvisoTextBox)
        Me.Controls.Add(PercentoInteressiLabel)
        Me.Controls.Add(Me.PercentoInteressiTextBox)
        Me.Controls.Add(ModuloCorrispondenzaLabel)
        Me.Controls.Add(Me.ModuloCorrispondenzaTextBox)
        Me.Controls.Add(ContoAnticipiLabel)
        Me.Controls.Add(Me.ContoAnticipiComboBox)
        Me.Controls.Add(ContoCassaLabel)
        Me.Controls.Add(Me.ContoCassaComboBox)
        Me.Controls.Add(ContoBancaLabel)
        Me.Controls.Add(Me.ContoBancaComboBox)
        Me.Controls.Add(PdcConsuntivoLabel)
        Me.Controls.Add(Me.PdcConsuntivoComboBox)
        Me.Controls.Add(PdcPreventivoLabel)
        Me.Controls.Add(Me.PdcPreventivoComboBox)
        Me.Controls.Add(GruppoSpesaLabel)
        Me.Controls.Add(Me.GruppoSpesaComboBox)
        Me.Controls.Add(CodiceFiscaleLabel)
        Me.Controls.Add(Me.CodiceFiscaleTextBox)
        Me.Controls.Add(ProvinciaLabel)
        Me.Controls.Add(Me.ProvinciaTextBox)
        Me.Controls.Add(LocalitaLabel)
        Me.Controls.Add(Me.LocalitaTextBox)
        Me.Controls.Add(CapLabel)
        Me.Controls.Add(Me.CapTextBox)
        Me.Controls.Add(IndirizzoLabel)
        Me.Controls.Add(Me.IndirizzoTextBox)
        Me.Controls.Add(DenominazioneLabel)
        Me.Controls.Add(Me.DenominazioneTextBox)
        Me.Controls.Add(ImmobileLabel)
        Me.Controls.Add(Me.ImmobileTextBox)
        Me.Name = "Immobili"
        Me.Text = "Anagrafica Immobile"
        CType(Me.IMMOBILIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImmobiliBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IMMOBILIDataSet As Patrimonio2014.IMMOBILIDataSet
    Friend WithEvents ImmobiliBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ImmobiliTableAdapter As Patrimonio2014.IMMOBILIDataSetTableAdapters.ImmobiliTableAdapter
    Friend WithEvents TableAdapterManager As Patrimonio2014.IMMOBILIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ImmobileTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DenominazioneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IndirizzoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CapTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LocalitaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProvinciaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CodiceFiscaleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GruppoSpesaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PdcPreventivoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PdcConsuntivoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ContoBancaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ContoCassaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ContoAnticipiComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ModuloCorrispondenzaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PercentoInteressiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GiorniScadenzaAvvisoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ArrotondamentoRateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SpeseIncassoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SaldoSuAvvisoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RiportiSuAvvisoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GruppoMillesimiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StudioComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NoteTextBox As System.Windows.Forms.TextBox
End Class
