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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Immobili))
        Me.IMMOBILIDataSet = New Patrimonio2014.IMMOBILIDataSet()
        Me.ImmobiliBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImmobiliTableAdapter = New Patrimonio2014.IMMOBILIDataSetTableAdapters.ImmobiliTableAdapter()
        Me.TableAdapterManager = New Patrimonio2014.IMMOBILIDataSetTableAdapters.TableAdapterManager()
        Me.ImmobiliBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ImmobiliBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Immobile = New System.Windows.Forms.TextBox()
        Me.Denominazione = New System.Windows.Forms.TextBox()
        Me.Indirizzo = New System.Windows.Forms.TextBox()
        Me.Cap = New System.Windows.Forms.TextBox()
        Me.Localita = New System.Windows.Forms.TextBox()
        Me.Provincia = New System.Windows.Forms.TextBox()
        Me.CodiceFiscale = New System.Windows.Forms.TextBox()
        Me.GruppoSpesa = New System.Windows.Forms.ComboBox()
        Me.PdcPreventivo = New System.Windows.Forms.ComboBox()
        Me.PdcConsuntivo = New System.Windows.Forms.ComboBox()
        Me.ContoBanca = New System.Windows.Forms.ComboBox()
        Me.ContoCassa = New System.Windows.Forms.ComboBox()
        Me.ContoAnticipi = New System.Windows.Forms.ComboBox()
        Me.ModuloCorrispondenza = New System.Windows.Forms.TextBox()
        Me.PercentoInteressi = New System.Windows.Forms.TextBox()
        Me.GiorniScadenzaAvviso = New System.Windows.Forms.TextBox()
        Me.ArrotondamentoRate = New System.Windows.Forms.TextBox()
        Me.SpeseIncasso = New System.Windows.Forms.TextBox()
        Me.SaldoSuAvviso = New System.Windows.Forms.TextBox()
        Me.RiportiSuAvviso = New System.Windows.Forms.TextBox()
        Me.GruppoMillesimi = New System.Windows.Forms.TextBox()
        Me.Note = New System.Windows.Forms.TextBox()
        Me.Studio = New System.Windows.Forms.ComboBox()
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
        CType(Me.ImmobiliBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ImmobiliBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
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
        'DenominazioneLabel
        '
        DenominazioneLabel.AutoSize = True
        DenominazioneLabel.Location = New System.Drawing.Point(88, 63)
        DenominazioneLabel.Name = "DenominazioneLabel"
        DenominazioneLabel.Size = New System.Drawing.Size(83, 13)
        DenominazioneLabel.TabIndex = 2
        DenominazioneLabel.Text = "Denominazione:"
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
        'CapLabel
        '
        CapLabel.AutoSize = True
        CapLabel.Location = New System.Drawing.Point(20, 141)
        CapLabel.Name = "CapLabel"
        CapLabel.Size = New System.Drawing.Size(29, 13)
        CapLabel.TabIndex = 6
        CapLabel.Text = "Cap:"
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
        'ProvinciaLabel
        '
        ProvinciaLabel.AutoSize = True
        ProvinciaLabel.Location = New System.Drawing.Point(323, 141)
        ProvinciaLabel.Name = "ProvinciaLabel"
        ProvinciaLabel.Size = New System.Drawing.Size(54, 13)
        ProvinciaLabel.TabIndex = 10
        ProvinciaLabel.Text = "Provincia:"
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
        'GruppoSpesaLabel
        '
        GruppoSpesaLabel.AutoSize = True
        GruppoSpesaLabel.Location = New System.Drawing.Point(88, 191)
        GruppoSpesaLabel.Name = "GruppoSpesaLabel"
        GruppoSpesaLabel.Size = New System.Drawing.Size(78, 13)
        GruppoSpesaLabel.TabIndex = 14
        GruppoSpesaLabel.Text = "Gruppo Spesa:"
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
        'PdcConsuntivoLabel
        '
        PdcConsuntivoLabel.AutoSize = True
        PdcConsuntivoLabel.Location = New System.Drawing.Point(539, 191)
        PdcConsuntivoLabel.Name = "PdcConsuntivoLabel"
        PdcConsuntivoLabel.Size = New System.Drawing.Size(120, 13)
        PdcConsuntivoLabel.TabIndex = 18
        PdcConsuntivoLabel.Text = "Piano Conti Consuntivo:"
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
        'ContoCassaLabel
        '
        ContoCassaLabel.AutoSize = True
        ContoCassaLabel.Location = New System.Drawing.Point(319, 231)
        ContoCassaLabel.Name = "ContoCassaLabel"
        ContoCassaLabel.Size = New System.Drawing.Size(70, 13)
        ContoCassaLabel.TabIndex = 22
        ContoCassaLabel.Text = "Conto Cassa:"
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
        'ModuloCorrispondenzaLabel
        '
        ModuloCorrispondenzaLabel.AutoSize = True
        ModuloCorrispondenzaLabel.Location = New System.Drawing.Point(90, 282)
        ModuloCorrispondenzaLabel.Name = "ModuloCorrispondenzaLabel"
        ModuloCorrispondenzaLabel.Size = New System.Drawing.Size(178, 13)
        ModuloCorrispondenzaLabel.TabIndex = 26
        ModuloCorrispondenzaLabel.Text = "Indirizzamento Archiviazione Digitale"
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
        'GiorniScadenzaAvvisoLabel
        '
        GiorniScadenzaAvvisoLabel.AutoSize = True
        GiorniScadenzaAvvisoLabel.Location = New System.Drawing.Point(424, 282)
        GiorniScadenzaAvvisoLabel.Name = "GiorniScadenzaAvvisoLabel"
        GiorniScadenzaAvvisoLabel.Size = New System.Drawing.Size(103, 13)
        GiorniScadenzaAvvisoLabel.TabIndex = 30
        GiorniScadenzaAvvisoLabel.Text = "GG Scad.za Avviso:"
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
        'SpeseIncassoLabel
        '
        SpeseIncassoLabel.AutoSize = True
        SpeseIncassoLabel.Location = New System.Drawing.Point(656, 282)
        SpeseIncassoLabel.Name = "SpeseIncassoLabel"
        SpeseIncassoLabel.Size = New System.Drawing.Size(80, 13)
        SpeseIncassoLabel.TabIndex = 34
        SpeseIncassoLabel.Text = "Spese Incasso:"
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
        'RiportiSuAvvisoLabel
        '
        RiportiSuAvvisoLabel.AutoSize = True
        RiportiSuAvvisoLabel.Location = New System.Drawing.Point(211, 321)
        RiportiSuAvvisoLabel.Name = "RiportiSuAvvisoLabel"
        RiportiSuAvvisoLabel.Size = New System.Drawing.Size(91, 13)
        RiportiSuAvvisoLabel.TabIndex = 38
        RiportiSuAvvisoLabel.Text = "Riporti Su Avviso:"
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
        'StudioLabel
        '
        StudioLabel.AutoSize = True
        StudioLabel.Location = New System.Drawing.Point(539, 63)
        StudioLabel.Name = "StudioLabel"
        StudioLabel.Size = New System.Drawing.Size(40, 13)
        StudioLabel.TabIndex = 42
        StudioLabel.Text = "Studio:"
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
        'ImmobiliBindingNavigator
        '
        Me.ImmobiliBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ImmobiliBindingNavigator.BindingSource = Me.ImmobiliBindingSource
        Me.ImmobiliBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ImmobiliBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ImmobiliBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ImmobiliBindingNavigatorSaveItem})
        Me.ImmobiliBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ImmobiliBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ImmobiliBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ImmobiliBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ImmobiliBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ImmobiliBindingNavigator.Name = "ImmobiliBindingNavigator"
        Me.ImmobiliBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ImmobiliBindingNavigator.Size = New System.Drawing.Size(873, 25)
        Me.ImmobiliBindingNavigator.TabIndex = 46
        Me.ImmobiliBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Aggiungi nuovo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(34, 22)
        Me.BindingNavigatorCountItem.Text = "di {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Numero totale di elementi"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Elimina"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Sposta in prima posizione"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Sposta indietro"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posizione"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posizione corrente"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Sposta avanti"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Sposta in ultima posizione"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ImmobiliBindingNavigatorSaveItem
        '
        Me.ImmobiliBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ImmobiliBindingNavigatorSaveItem.Image = CType(resources.GetObject("ImmobiliBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ImmobiliBindingNavigatorSaveItem.Name = "ImmobiliBindingNavigatorSaveItem"
        Me.ImmobiliBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ImmobiliBindingNavigatorSaveItem.Text = "Salva dati"
        '
        'Immobile
        '
        Me.Immobile.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImmobiliBindingSource, "Immobile", True))
        Me.Immobile.Location = New System.Drawing.Point(23, 80)
        Me.Immobile.Name = "Immobile"
        Me.Immobile.Size = New System.Drawing.Size(48, 20)
        Me.Immobile.TabIndex = 47
        '
        'Denominazione
        '
        Me.Denominazione.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImmobiliBindingSource, "Denominazione", True))
        Me.Denominazione.Location = New System.Drawing.Point(93, 80)
        Me.Denominazione.Name = "Denominazione"
        Me.Denominazione.Size = New System.Drawing.Size(215, 20)
        Me.Denominazione.TabIndex = 48
        '
        'Indirizzo
        '
        Me.Indirizzo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImmobiliBindingSource, "Indirizzo", True))
        Me.Indirizzo.Location = New System.Drawing.Point(93, 118)
        Me.Indirizzo.Name = "Indirizzo"
        Me.Indirizzo.Size = New System.Drawing.Size(215, 20)
        Me.Indirizzo.TabIndex = 49
        '
        'Cap
        '
        Me.Cap.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImmobiliBindingSource, "Cap", True))
        Me.Cap.Location = New System.Drawing.Point(23, 157)
        Me.Cap.Name = "Cap"
        Me.Cap.Size = New System.Drawing.Size(48, 20)
        Me.Cap.TabIndex = 50
        '
        'Localita
        '
        Me.Localita.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImmobiliBindingSource, "Localita", True))
        Me.Localita.Location = New System.Drawing.Point(93, 157)
        Me.Localita.Name = "Localita"
        Me.Localita.Size = New System.Drawing.Size(215, 20)
        Me.Localita.TabIndex = 51
        '
        'Provincia
        '
        Me.Provincia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImmobiliBindingSource, "Provincia", True))
        Me.Provincia.Location = New System.Drawing.Point(326, 157)
        Me.Provincia.Name = "Provincia"
        Me.Provincia.Size = New System.Drawing.Size(51, 20)
        Me.Provincia.TabIndex = 52
        '
        'CodiceFiscale
        '
        Me.CodiceFiscale.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImmobiliBindingSource, "CodiceFiscale", True))
        Me.CodiceFiscale.Location = New System.Drawing.Point(326, 80)
        Me.CodiceFiscale.Name = "CodiceFiscale"
        Me.CodiceFiscale.Size = New System.Drawing.Size(198, 20)
        Me.CodiceFiscale.TabIndex = 53
        '
        'GruppoSpesa
        '
        Me.GruppoSpesa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImmobiliBindingSource, "GruppoSpesa", True))
        Me.GruppoSpesa.FormattingEnabled = True
        Me.GruppoSpesa.Location = New System.Drawing.Point(93, 207)
        Me.GruppoSpesa.Name = "GruppoSpesa"
        Me.GruppoSpesa.Size = New System.Drawing.Size(215, 21)
        Me.GruppoSpesa.TabIndex = 54
        '
        'PdcPreventivo
        '
        Me.PdcPreventivo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImmobiliBindingSource, "PdcPreventivo", True))
        Me.PdcPreventivo.FormattingEnabled = True
        Me.PdcPreventivo.Location = New System.Drawing.Point(322, 207)
        Me.PdcPreventivo.Name = "PdcPreventivo"
        Me.PdcPreventivo.Size = New System.Drawing.Size(202, 21)
        Me.PdcPreventivo.TabIndex = 55
        '
        'PdcConsuntivo
        '
        Me.PdcConsuntivo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImmobiliBindingSource, "PdcConsuntivo", True))
        Me.PdcConsuntivo.FormattingEnabled = True
        Me.PdcConsuntivo.Location = New System.Drawing.Point(542, 207)
        Me.PdcConsuntivo.Name = "PdcConsuntivo"
        Me.PdcConsuntivo.Size = New System.Drawing.Size(202, 21)
        Me.PdcConsuntivo.TabIndex = 56
        '
        'ContoBanca
        '
        Me.ContoBanca.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImmobiliBindingSource, "ContoBanca", True))
        Me.ContoBanca.FormattingEnabled = True
        Me.ContoBanca.Location = New System.Drawing.Point(93, 247)
        Me.ContoBanca.Name = "ContoBanca"
        Me.ContoBanca.Size = New System.Drawing.Size(215, 21)
        Me.ContoBanca.TabIndex = 57
        '
        'ContoCassa
        '
        Me.ContoCassa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImmobiliBindingSource, "ContoCassa", True))
        Me.ContoCassa.FormattingEnabled = True
        Me.ContoCassa.Location = New System.Drawing.Point(322, 247)
        Me.ContoCassa.Name = "ContoCassa"
        Me.ContoCassa.Size = New System.Drawing.Size(202, 21)
        Me.ContoCassa.TabIndex = 58
        '
        'ContoAnticipi
        '
        Me.ContoAnticipi.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImmobiliBindingSource, "ContoAnticipi", True))
        Me.ContoAnticipi.FormattingEnabled = True
        Me.ContoAnticipi.Location = New System.Drawing.Point(542, 247)
        Me.ContoAnticipi.Name = "ContoAnticipi"
        Me.ContoAnticipi.Size = New System.Drawing.Size(202, 21)
        Me.ContoAnticipi.TabIndex = 59
        '
        'ModuloCorrispondenza
        '
        Me.ModuloCorrispondenza.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImmobiliBindingSource, "ModuloCorrispondenza", True))
        Me.ModuloCorrispondenza.Location = New System.Drawing.Point(93, 298)
        Me.ModuloCorrispondenza.Name = "ModuloCorrispondenza"
        Me.ModuloCorrispondenza.Size = New System.Drawing.Size(215, 20)
        Me.ModuloCorrispondenza.TabIndex = 60
        '
        'PercentoInteressi
        '
        Me.PercentoInteressi.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImmobiliBindingSource, "PercentoInteressi", True))
        Me.PercentoInteressi.Location = New System.Drawing.Point(326, 298)
        Me.PercentoInteressi.Name = "PercentoInteressi"
        Me.PercentoInteressi.Size = New System.Drawing.Size(92, 20)
        Me.PercentoInteressi.TabIndex = 61
        '
        'GiorniScadenzaAvviso
        '
        Me.GiorniScadenzaAvviso.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImmobiliBindingSource, "GiorniScadenzaAvviso", True))
        Me.GiorniScadenzaAvviso.Location = New System.Drawing.Point(427, 298)
        Me.GiorniScadenzaAvviso.Name = "GiorniScadenzaAvviso"
        Me.GiorniScadenzaAvviso.Size = New System.Drawing.Size(100, 20)
        Me.GiorniScadenzaAvviso.TabIndex = 62
        '
        'ArrotondamentoRate
        '
        Me.ArrotondamentoRate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImmobiliBindingSource, "ArrotondamentoRate", True))
        Me.ArrotondamentoRate.Location = New System.Drawing.Point(542, 298)
        Me.ArrotondamentoRate.Name = "ArrotondamentoRate"
        Me.ArrotondamentoRate.Size = New System.Drawing.Size(100, 20)
        Me.ArrotondamentoRate.TabIndex = 63
        '
        'SpeseIncasso
        '
        Me.SpeseIncasso.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImmobiliBindingSource, "SpeseIncasso", True))
        Me.SpeseIncasso.Location = New System.Drawing.Point(659, 298)
        Me.SpeseIncasso.Name = "SpeseIncasso"
        Me.SpeseIncasso.Size = New System.Drawing.Size(85, 20)
        Me.SpeseIncasso.TabIndex = 64
        '
        'SaldoSuAvviso
        '
        Me.SaldoSuAvviso.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImmobiliBindingSource, "SaldoSuAvviso", True))
        Me.SaldoSuAvviso.Location = New System.Drawing.Point(93, 337)
        Me.SaldoSuAvviso.Name = "SaldoSuAvviso"
        Me.SaldoSuAvviso.Size = New System.Drawing.Size(100, 20)
        Me.SaldoSuAvviso.TabIndex = 65
        '
        'RiportiSuAvviso
        '
        Me.RiportiSuAvviso.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImmobiliBindingSource, "RiportiSuAvviso", True))
        Me.RiportiSuAvviso.Location = New System.Drawing.Point(214, 337)
        Me.RiportiSuAvviso.Name = "RiportiSuAvviso"
        Me.RiportiSuAvviso.Size = New System.Drawing.Size(94, 20)
        Me.RiportiSuAvviso.TabIndex = 66
        '
        'GruppoMillesimi
        '
        Me.GruppoMillesimi.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImmobiliBindingSource, "GruppoMillesimi", True))
        Me.GruppoMillesimi.Location = New System.Drawing.Point(326, 337)
        Me.GruppoMillesimi.Name = "GruppoMillesimi"
        Me.GruppoMillesimi.Size = New System.Drawing.Size(92, 20)
        Me.GruppoMillesimi.TabIndex = 67
        '
        'Note
        '
        Me.Note.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImmobiliBindingSource, "Note", True))
        Me.Note.Location = New System.Drawing.Point(93, 396)
        Me.Note.Name = "Note"
        Me.Note.Size = New System.Drawing.Size(651, 20)
        Me.Note.TabIndex = 68
        '
        'Studio
        '
        Me.Studio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImmobiliBindingSource, "Studio", True))
        Me.Studio.FormattingEnabled = True
        Me.Studio.Location = New System.Drawing.Point(542, 80)
        Me.Studio.Name = "Studio"
        Me.Studio.Size = New System.Drawing.Size(202, 21)
        Me.Studio.TabIndex = 69
        '
        'Immobili
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 445)
        Me.Controls.Add(Me.Studio)
        Me.Controls.Add(Me.Note)
        Me.Controls.Add(Me.GruppoMillesimi)
        Me.Controls.Add(Me.RiportiSuAvviso)
        Me.Controls.Add(Me.SaldoSuAvviso)
        Me.Controls.Add(Me.SpeseIncasso)
        Me.Controls.Add(Me.ArrotondamentoRate)
        Me.Controls.Add(Me.GiorniScadenzaAvviso)
        Me.Controls.Add(Me.PercentoInteressi)
        Me.Controls.Add(Me.ModuloCorrispondenza)
        Me.Controls.Add(Me.ContoAnticipi)
        Me.Controls.Add(Me.ContoCassa)
        Me.Controls.Add(Me.ContoBanca)
        Me.Controls.Add(Me.PdcConsuntivo)
        Me.Controls.Add(Me.PdcPreventivo)
        Me.Controls.Add(Me.GruppoSpesa)
        Me.Controls.Add(Me.CodiceFiscale)
        Me.Controls.Add(Me.Provincia)
        Me.Controls.Add(Me.Localita)
        Me.Controls.Add(Me.Cap)
        Me.Controls.Add(Me.Indirizzo)
        Me.Controls.Add(Me.Denominazione)
        Me.Controls.Add(Me.Immobile)
        Me.Controls.Add(Me.ImmobiliBindingNavigator)
        Me.Controls.Add(NoteLabel)
        Me.Controls.Add(StudioLabel)
        Me.Controls.Add(GruppoMillesimiLabel)
        Me.Controls.Add(RiportiSuAvvisoLabel)
        Me.Controls.Add(SaldoSuAvvisoLabel)
        Me.Controls.Add(SpeseIncassoLabel)
        Me.Controls.Add(ArrotondamentoRateLabel)
        Me.Controls.Add(GiorniScadenzaAvvisoLabel)
        Me.Controls.Add(PercentoInteressiLabel)
        Me.Controls.Add(ModuloCorrispondenzaLabel)
        Me.Controls.Add(ContoAnticipiLabel)
        Me.Controls.Add(ContoCassaLabel)
        Me.Controls.Add(ContoBancaLabel)
        Me.Controls.Add(PdcConsuntivoLabel)
        Me.Controls.Add(PdcPreventivoLabel)
        Me.Controls.Add(GruppoSpesaLabel)
        Me.Controls.Add(CodiceFiscaleLabel)
        Me.Controls.Add(ProvinciaLabel)
        Me.Controls.Add(LocalitaLabel)
        Me.Controls.Add(CapLabel)
        Me.Controls.Add(IndirizzoLabel)
        Me.Controls.Add(DenominazioneLabel)
        Me.Controls.Add(ImmobileLabel)
        Me.Name = "Immobili"
        Me.Text = "Anagrafica Immobile"
        CType(Me.IMMOBILIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImmobiliBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImmobiliBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ImmobiliBindingNavigator.ResumeLayout(False)
        Me.ImmobiliBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IMMOBILIDataSet As Patrimonio2014.IMMOBILIDataSet
    Friend WithEvents ImmobiliBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ImmobiliTableAdapter As Patrimonio2014.IMMOBILIDataSetTableAdapters.ImmobiliTableAdapter
    Friend WithEvents TableAdapterManager As Patrimonio2014.IMMOBILIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ImmobiliBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ImmobiliBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Immobile As System.Windows.Forms.TextBox
    Friend WithEvents Denominazione As System.Windows.Forms.TextBox
    Friend WithEvents Indirizzo As System.Windows.Forms.TextBox
    Friend WithEvents Cap As System.Windows.Forms.TextBox
    Friend WithEvents Localita As System.Windows.Forms.TextBox
    Friend WithEvents Provincia As System.Windows.Forms.TextBox
    Friend WithEvents CodiceFiscale As System.Windows.Forms.TextBox
    Friend WithEvents GruppoSpesa As System.Windows.Forms.ComboBox
    Friend WithEvents PdcPreventivo As System.Windows.Forms.ComboBox
    Friend WithEvents PdcConsuntivo As System.Windows.Forms.ComboBox
    Friend WithEvents ContoBanca As System.Windows.Forms.ComboBox
    Friend WithEvents ContoCassa As System.Windows.Forms.ComboBox
    Friend WithEvents ContoAnticipi As System.Windows.Forms.ComboBox
    Friend WithEvents ModuloCorrispondenza As System.Windows.Forms.TextBox
    Friend WithEvents PercentoInteressi As System.Windows.Forms.TextBox
    Friend WithEvents GiorniScadenzaAvviso As System.Windows.Forms.TextBox
    Friend WithEvents ArrotondamentoRate As System.Windows.Forms.TextBox
    Friend WithEvents SpeseIncasso As System.Windows.Forms.TextBox
    Friend WithEvents SaldoSuAvviso As System.Windows.Forms.TextBox
    Friend WithEvents RiportiSuAvviso As System.Windows.Forms.TextBox
    Friend WithEvents GruppoMillesimi As System.Windows.Forms.TextBox
    Friend WithEvents Note As System.Windows.Forms.TextBox
    Friend WithEvents Studio As System.Windows.Forms.ComboBox
End Class
