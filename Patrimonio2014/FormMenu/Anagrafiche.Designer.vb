<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Anagrafiche
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
        Dim AnagraficaLabel As System.Windows.Forms.Label
        Dim TitoloLabel As System.Windows.Forms.Label
        Dim Nominativo1Label As System.Windows.Forms.Label
        Dim IndirizzoLabel As System.Windows.Forms.Label
        Dim CapLabel As System.Windows.Forms.Label
        Dim LocalitaLabel As System.Windows.Forms.Label
        Dim ProvinciaLabel As System.Windows.Forms.Label
        Dim NoteLabel As System.Windows.Forms.Label
        Dim SiglaLista1Label As System.Windows.Forms.Label
        Dim SiglaLista2Label As System.Windows.Forms.Label
        Dim SiglaRaccomandateLabel As System.Windows.Forms.Label
        Dim AnagraficaCollegataLabel As System.Windows.Forms.Label
        Dim CodiceFiscaleLabel As System.Windows.Forms.Label
        Dim LuogoNascitaLabel As System.Windows.Forms.Label
        Dim ProvinciaNascitaLabel As System.Windows.Forms.Label
        Dim DataNascitaLabel As System.Windows.Forms.Label
        Dim TelefonoLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Anagrafiche))
        Me.IMMOBILIDataSet = New Patrimonio2014.IMMOBILIDataSet()
        Me.AnagraficheBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnagraficheTableAdapter = New Patrimonio2014.IMMOBILIDataSetTableAdapters.AnagraficheTableAdapter()
        Me.TableAdapterManager = New Patrimonio2014.IMMOBILIDataSetTableAdapters.TableAdapterManager()
        Me.Immobile = New System.Windows.Forms.ComboBox()
        Me.Anagrafica = New System.Windows.Forms.TextBox()
        Me.Titolo = New System.Windows.Forms.TextBox()
        Me.Nominativo1 = New System.Windows.Forms.TextBox()
        Me.Nominativo2 = New System.Windows.Forms.TextBox()
        Me.Indirizzo = New System.Windows.Forms.TextBox()
        Me.Cap = New System.Windows.Forms.TextBox()
        Me.Localita = New System.Windows.Forms.TextBox()
        Me.Provincia = New System.Windows.Forms.TextBox()
        Me.Telefono = New System.Windows.Forms.TextBox()
        Me.Note = New System.Windows.Forms.TextBox()
        Me.SiglaLista1 = New System.Windows.Forms.TextBox()
        Me.SiglaLista2 = New System.Windows.Forms.TextBox()
        Me.SiglaRaccomandate = New System.Windows.Forms.TextBox()
        Me.CodiceFiscale = New System.Windows.Forms.TextBox()
        Me.LuogoNascita = New System.Windows.Forms.TextBox()
        Me.ProvinciaNascita = New System.Windows.Forms.TextBox()
        Me.DataNascita = New System.Windows.Forms.DateTimePicker()
        Me.ZTestoSollecitoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Z_TestoSollecitoTableAdapter = New Patrimonio2014.IMMOBILIDataSetTableAdapters.Z_TestoSollecitoTableAdapter()
        Me.AnagraficaCollegataTextBox = New System.Windows.Forms.TextBox()
        Me.AnagraficaStudioBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.AnagraficaStudioBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        ImmobileLabel = New System.Windows.Forms.Label()
        AnagraficaLabel = New System.Windows.Forms.Label()
        TitoloLabel = New System.Windows.Forms.Label()
        Nominativo1Label = New System.Windows.Forms.Label()
        IndirizzoLabel = New System.Windows.Forms.Label()
        CapLabel = New System.Windows.Forms.Label()
        LocalitaLabel = New System.Windows.Forms.Label()
        ProvinciaLabel = New System.Windows.Forms.Label()
        NoteLabel = New System.Windows.Forms.Label()
        SiglaLista1Label = New System.Windows.Forms.Label()
        SiglaLista2Label = New System.Windows.Forms.Label()
        SiglaRaccomandateLabel = New System.Windows.Forms.Label()
        AnagraficaCollegataLabel = New System.Windows.Forms.Label()
        CodiceFiscaleLabel = New System.Windows.Forms.Label()
        LuogoNascitaLabel = New System.Windows.Forms.Label()
        ProvinciaNascitaLabel = New System.Windows.Forms.Label()
        DataNascitaLabel = New System.Windows.Forms.Label()
        TelefonoLabel1 = New System.Windows.Forms.Label()
        CType(Me.IMMOBILIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnagraficheBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZTestoSollecitoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnagraficaStudioBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AnagraficaStudioBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImmobileLabel
        '
        ImmobileLabel.AutoSize = True
        ImmobileLabel.Location = New System.Drawing.Point(107, 73)
        ImmobileLabel.Name = "ImmobileLabel"
        ImmobileLabel.Size = New System.Drawing.Size(51, 13)
        ImmobileLabel.TabIndex = 1
        ImmobileLabel.Text = "Immobile:"
        '
        'AnagraficaLabel
        '
        AnagraficaLabel.AutoSize = True
        AnagraficaLabel.Location = New System.Drawing.Point(480, 73)
        AnagraficaLabel.Name = "AnagraficaLabel"
        AnagraficaLabel.Size = New System.Drawing.Size(61, 13)
        AnagraficaLabel.TabIndex = 2
        AnagraficaLabel.Text = "Anagrafica:"
        '
        'TitoloLabel
        '
        TitoloLabel.AutoSize = True
        TitoloLabel.Location = New System.Drawing.Point(12, 121)
        TitoloLabel.Name = "TitoloLabel"
        TitoloLabel.Size = New System.Drawing.Size(36, 13)
        TitoloLabel.TabIndex = 4
        TitoloLabel.Text = "Titolo:"
        '
        'Nominativo1Label
        '
        Nominativo1Label.AutoSize = True
        Nominativo1Label.Location = New System.Drawing.Point(106, 121)
        Nominativo1Label.Name = "Nominativo1Label"
        Nominativo1Label.Size = New System.Drawing.Size(63, 13)
        Nominativo1Label.TabIndex = 6
        Nominativo1Label.Text = "Nominativo:"
        '
        'IndirizzoLabel
        '
        IndirizzoLabel.AutoSize = True
        IndirizzoLabel.Location = New System.Drawing.Point(106, 186)
        IndirizzoLabel.Name = "IndirizzoLabel"
        IndirizzoLabel.Size = New System.Drawing.Size(48, 13)
        IndirizzoLabel.TabIndex = 9
        IndirizzoLabel.Text = "Indirizzo:"
        '
        'CapLabel
        '
        CapLabel.AutoSize = True
        CapLabel.Location = New System.Drawing.Point(19, 225)
        CapLabel.Name = "CapLabel"
        CapLabel.Size = New System.Drawing.Size(29, 13)
        CapLabel.TabIndex = 11
        CapLabel.Text = "Cap:"
        '
        'LocalitaLabel
        '
        LocalitaLabel.AutoSize = True
        LocalitaLabel.Location = New System.Drawing.Point(106, 225)
        LocalitaLabel.Name = "LocalitaLabel"
        LocalitaLabel.Size = New System.Drawing.Size(47, 13)
        LocalitaLabel.TabIndex = 13
        LocalitaLabel.Text = "Localita:"
        '
        'ProvinciaLabel
        '
        ProvinciaLabel.AutoSize = True
        ProvinciaLabel.Location = New System.Drawing.Point(475, 225)
        ProvinciaLabel.Name = "ProvinciaLabel"
        ProvinciaLabel.Size = New System.Drawing.Size(54, 13)
        ProvinciaLabel.TabIndex = 15
        ProvinciaLabel.Text = "Provincia:"
        '
        'NoteLabel
        '
        NoteLabel.AutoSize = True
        NoteLabel.Location = New System.Drawing.Point(106, 320)
        NoteLabel.Name = "NoteLabel"
        NoteLabel.Size = New System.Drawing.Size(33, 13)
        NoteLabel.TabIndex = 19
        NoteLabel.Text = "Note:"
        '
        'SiglaLista1Label
        '
        SiglaLista1Label.AutoSize = True
        SiglaLista1Label.Location = New System.Drawing.Point(107, 359)
        SiglaLista1Label.Name = "SiglaLista1Label"
        SiglaLista1Label.Size = New System.Drawing.Size(64, 13)
        SiglaLista1Label.TabIndex = 21
        SiglaLista1Label.Text = "Sigla Lista1:"
        '
        'SiglaLista2Label
        '
        SiglaLista2Label.AutoSize = True
        SiglaLista2Label.Location = New System.Drawing.Point(198, 359)
        SiglaLista2Label.Name = "SiglaLista2Label"
        SiglaLista2Label.Size = New System.Drawing.Size(64, 13)
        SiglaLista2Label.TabIndex = 23
        SiglaLista2Label.Text = "Sigla Lista2:"
        '
        'SiglaRaccomandateLabel
        '
        SiglaRaccomandateLabel.AutoSize = True
        SiglaRaccomandateLabel.Location = New System.Drawing.Point(268, 360)
        SiglaRaccomandateLabel.Name = "SiglaRaccomandateLabel"
        SiglaRaccomandateLabel.Size = New System.Drawing.Size(109, 13)
        SiglaRaccomandateLabel.TabIndex = 25
        SiglaRaccomandateLabel.Text = "Sigla Raccomandate:"
        '
        'AnagraficaCollegataLabel
        '
        AnagraficaCollegataLabel.AutoSize = True
        AnagraficaCollegataLabel.Location = New System.Drawing.Point(374, 360)
        AnagraficaCollegataLabel.Name = "AnagraficaCollegataLabel"
        AnagraficaCollegataLabel.Size = New System.Drawing.Size(77, 13)
        AnagraficaCollegataLabel.TabIndex = 27
        AnagraficaCollegataLabel.Text = "Testo Sollecito"
        '
        'CodiceFiscaleLabel
        '
        CodiceFiscaleLabel.AutoSize = True
        CodiceFiscaleLabel.Location = New System.Drawing.Point(480, 359)
        CodiceFiscaleLabel.Name = "CodiceFiscaleLabel"
        CodiceFiscaleLabel.Size = New System.Drawing.Size(79, 13)
        CodiceFiscaleLabel.TabIndex = 29
        CodiceFiscaleLabel.Text = "Codice Fiscale:"
        '
        'LuogoNascitaLabel
        '
        LuogoNascitaLabel.AutoSize = True
        LuogoNascitaLabel.Location = New System.Drawing.Point(107, 399)
        LuogoNascitaLabel.Name = "LuogoNascitaLabel"
        LuogoNascitaLabel.Size = New System.Drawing.Size(79, 13)
        LuogoNascitaLabel.TabIndex = 31
        LuogoNascitaLabel.Text = "Luogo Nascita:"
        '
        'ProvinciaNascitaLabel
        '
        ProvinciaNascitaLabel.AutoSize = True
        ProvinciaNascitaLabel.Location = New System.Drawing.Point(374, 399)
        ProvinciaNascitaLabel.Name = "ProvinciaNascitaLabel"
        ProvinciaNascitaLabel.Size = New System.Drawing.Size(93, 13)
        ProvinciaNascitaLabel.TabIndex = 33
        ProvinciaNascitaLabel.Text = "Provincia Nascita:"
        '
        'DataNascitaLabel
        '
        DataNascitaLabel.AutoSize = True
        DataNascitaLabel.Location = New System.Drawing.Point(480, 398)
        DataNascitaLabel.Name = "DataNascitaLabel"
        DataNascitaLabel.Size = New System.Drawing.Size(72, 13)
        DataNascitaLabel.TabIndex = 35
        DataNascitaLabel.Text = "Data Nascita:"
        '
        'TelefonoLabel1
        '
        TelefonoLabel1.AutoSize = True
        TelefonoLabel1.Location = New System.Drawing.Point(106, 281)
        TelefonoLabel1.Name = "TelefonoLabel1"
        TelefonoLabel1.Size = New System.Drawing.Size(52, 13)
        TelefonoLabel1.TabIndex = 46
        TelefonoLabel1.Text = "Telefono:"
        '
        'IMMOBILIDataSet
        '
        Me.IMMOBILIDataSet.DataSetName = "IMMOBILIDataSet"
        Me.IMMOBILIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AnagraficheBindingSource
        '
        Me.AnagraficheBindingSource.DataMember = "Anagrafiche"
        Me.AnagraficheBindingSource.DataSource = Me.IMMOBILIDataSet
        '
        'AnagraficheTableAdapter
        '
        Me.AnagraficheTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AnagraficaStudioTableAdapter = Nothing
        Me.TableAdapterManager.AnagraficheTableAdapter = Me.AnagraficheTableAdapter
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
        'Immobile
        '
        Me.Immobile.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "Immobile", True))
        Me.Immobile.FormattingEnabled = True
        Me.Immobile.Location = New System.Drawing.Point(109, 89)
        Me.Immobile.Name = "Immobile"
        Me.Immobile.Size = New System.Drawing.Size(362, 21)
        Me.Immobile.TabIndex = 38
        '
        'Anagrafica
        '
        Me.Anagrafica.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "Anagrafica", True))
        Me.Anagrafica.Location = New System.Drawing.Point(483, 90)
        Me.Anagrafica.Name = "Anagrafica"
        Me.Anagrafica.Size = New System.Drawing.Size(88, 20)
        Me.Anagrafica.TabIndex = 39
        '
        'Titolo
        '
        Me.Titolo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "Titolo", True))
        Me.Titolo.Location = New System.Drawing.Point(15, 137)
        Me.Titolo.Name = "Titolo"
        Me.Titolo.Size = New System.Drawing.Size(88, 20)
        Me.Titolo.TabIndex = 40
        '
        'Nominativo1
        '
        Me.Nominativo1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "Nominativo1", True))
        Me.Nominativo1.Location = New System.Drawing.Point(109, 137)
        Me.Nominativo1.Name = "Nominativo1"
        Me.Nominativo1.Size = New System.Drawing.Size(363, 20)
        Me.Nominativo1.TabIndex = 41
        '
        'Nominativo2
        '
        Me.Nominativo2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "Nominativo2", True))
        Me.Nominativo2.Location = New System.Drawing.Point(109, 163)
        Me.Nominativo2.Name = "Nominativo2"
        Me.Nominativo2.Size = New System.Drawing.Size(363, 20)
        Me.Nominativo2.TabIndex = 42
        '
        'Indirizzo
        '
        Me.Indirizzo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "Indirizzo", True))
        Me.Indirizzo.Location = New System.Drawing.Point(109, 202)
        Me.Indirizzo.Name = "Indirizzo"
        Me.Indirizzo.Size = New System.Drawing.Size(363, 20)
        Me.Indirizzo.TabIndex = 43
        '
        'Cap
        '
        Me.Cap.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "Cap", True))
        Me.Cap.Location = New System.Drawing.Point(15, 241)
        Me.Cap.Name = "Cap"
        Me.Cap.Size = New System.Drawing.Size(88, 20)
        Me.Cap.TabIndex = 44
        '
        'Localita
        '
        Me.Localita.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "Localita", True))
        Me.Localita.Location = New System.Drawing.Point(109, 241)
        Me.Localita.Name = "Localita"
        Me.Localita.Size = New System.Drawing.Size(363, 20)
        Me.Localita.TabIndex = 45
        '
        'Provincia
        '
        Me.Provincia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "Provincia", True))
        Me.Provincia.Location = New System.Drawing.Point(478, 241)
        Me.Provincia.Name = "Provincia"
        Me.Provincia.Size = New System.Drawing.Size(51, 20)
        Me.Provincia.TabIndex = 46
        '
        'Telefono
        '
        Me.Telefono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "Telefono", True))
        Me.Telefono.Location = New System.Drawing.Point(109, 297)
        Me.Telefono.Name = "Telefono"
        Me.Telefono.Size = New System.Drawing.Size(368, 20)
        Me.Telefono.TabIndex = 47
        '
        'Note
        '
        Me.Note.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "Note", True))
        Me.Note.Location = New System.Drawing.Point(109, 336)
        Me.Note.Name = "Note"
        Me.Note.Size = New System.Drawing.Size(368, 20)
        Me.Note.TabIndex = 48
        '
        'SiglaLista1
        '
        Me.SiglaLista1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "SiglaLista1", True))
        Me.SiglaLista1.Location = New System.Drawing.Point(110, 375)
        Me.SiglaLista1.Name = "SiglaLista1"
        Me.SiglaLista1.Size = New System.Drawing.Size(61, 20)
        Me.SiglaLista1.TabIndex = 49
        '
        'SiglaLista2
        '
        Me.SiglaLista2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "SiglaLista2", True))
        Me.SiglaLista2.Location = New System.Drawing.Point(204, 375)
        Me.SiglaLista2.Name = "SiglaLista2"
        Me.SiglaLista2.Size = New System.Drawing.Size(61, 20)
        Me.SiglaLista2.TabIndex = 50
        '
        'SiglaRaccomandate
        '
        Me.SiglaRaccomandate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "SiglaRaccomandate", True))
        Me.SiglaRaccomandate.Location = New System.Drawing.Point(271, 376)
        Me.SiglaRaccomandate.Name = "SiglaRaccomandate"
        Me.SiglaRaccomandate.Size = New System.Drawing.Size(100, 20)
        Me.SiglaRaccomandate.TabIndex = 51
        '
        'CodiceFiscale
        '
        Me.CodiceFiscale.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "CodiceFiscale", True))
        Me.CodiceFiscale.Location = New System.Drawing.Point(483, 376)
        Me.CodiceFiscale.Name = "CodiceFiscale"
        Me.CodiceFiscale.Size = New System.Drawing.Size(214, 20)
        Me.CodiceFiscale.TabIndex = 53
        '
        'LuogoNascita
        '
        Me.LuogoNascita.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "LuogoNascita", True))
        Me.LuogoNascita.Location = New System.Drawing.Point(110, 415)
        Me.LuogoNascita.Name = "LuogoNascita"
        Me.LuogoNascita.Size = New System.Drawing.Size(258, 20)
        Me.LuogoNascita.TabIndex = 54
        '
        'ProvinciaNascita
        '
        Me.ProvinciaNascita.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "ProvinciaNascita", True))
        Me.ProvinciaNascita.Location = New System.Drawing.Point(377, 414)
        Me.ProvinciaNascita.Name = "ProvinciaNascita"
        Me.ProvinciaNascita.Size = New System.Drawing.Size(100, 20)
        Me.ProvinciaNascita.TabIndex = 55
        '
        'DataNascita
        '
        Me.DataNascita.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AnagraficheBindingSource, "DataNascita", True))
        Me.DataNascita.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataNascita.Location = New System.Drawing.Point(483, 415)
        Me.DataNascita.Name = "DataNascita"
        Me.DataNascita.Size = New System.Drawing.Size(120, 20)
        Me.DataNascita.TabIndex = 56
        '
        'ZTestoSollecitoBindingSource
        '
        Me.ZTestoSollecitoBindingSource.DataMember = "Z_TestoSollecito"
        Me.ZTestoSollecitoBindingSource.DataSource = Me.IMMOBILIDataSet
        '
        'Z_TestoSollecitoTableAdapter
        '
        Me.Z_TestoSollecitoTableAdapter.ClearBeforeFill = True
        '
        'AnagraficaCollegataTextBox
        '
        Me.AnagraficaCollegataTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "AnagraficaCollegata", True))
        Me.AnagraficaCollegataTextBox.Location = New System.Drawing.Point(377, 376)
        Me.AnagraficaCollegataTextBox.Name = "AnagraficaCollegataTextBox"
        Me.AnagraficaCollegataTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AnagraficaCollegataTextBox.TabIndex = 57
        '
        'AnagraficaStudioBindingNavigator
        '
        Me.AnagraficaStudioBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AnagraficaStudioBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AnagraficaStudioBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AnagraficaStudioBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AnagraficaStudioBindingNavigatorSaveItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator1, Me.ToolStripButton2})
        Me.AnagraficaStudioBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AnagraficaStudioBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AnagraficaStudioBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AnagraficaStudioBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AnagraficaStudioBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AnagraficaStudioBindingNavigator.Name = "AnagraficaStudioBindingNavigator"
        Me.AnagraficaStudioBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AnagraficaStudioBindingNavigator.Size = New System.Drawing.Size(717, 38)
        Me.AnagraficaStudioBindingNavigator.TabIndex = 58
        Me.AnagraficaStudioBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(47, 35)
        Me.BindingNavigatorAddNewItem.Text = "&Nuovo"
        Me.BindingNavigatorAddNewItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(34, 35)
        Me.BindingNavigatorCountItem.Text = "di {0}"
        Me.BindingNavigatorCountItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BindingNavigatorCountItem.ToolTipText = "Numero totale di elementi"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(50, 35)
        Me.BindingNavigatorDeleteItem.Text = "&Elimina"
        Me.BindingNavigatorDeleteItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BindingNavigatorDeleteItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(49, 35)
        Me.ToolStripButton1.Text = "&Ricerca"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'AnagraficaStudioBindingNavigatorSaveItem
        '
        Me.AnagraficaStudioBindingNavigatorSaveItem.Image = CType(resources.GetObject("AnagraficaStudioBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AnagraficaStudioBindingNavigatorSaveItem.Name = "AnagraficaStudioBindingNavigatorSaveItem"
        Me.AnagraficaStudioBindingNavigatorSaveItem.Size = New System.Drawing.Size(38, 35)
        Me.AnagraficaStudioBindingNavigatorSaveItem.Text = "&Salva"
        Me.AnagraficaStudioBindingNavigatorSaveItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 38)
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(43, 35)
        Me.BindingNavigatorMoveFirstItem.Text = "&Primo"
        Me.BindingNavigatorMoveFirstItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(52, 35)
        Me.BindingNavigatorMovePreviousItem.Text = "&Indietro"
        Me.BindingNavigatorMovePreviousItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 38)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posizione"
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 38)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posizione corrente"
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(45, 35)
        Me.BindingNavigatorMoveNextItem.Text = "&Avanti"
        Me.BindingNavigatorMoveNextItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(47, 35)
        Me.BindingNavigatorMoveLastItem.Text = "&Ultimo"
        Me.BindingNavigatorMoveLastItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 38)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(51, 35)
        Me.ToolStripButton2.Text = "Sta&mpa"
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Anagrafiche
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 464)
        Me.Controls.Add(Me.AnagraficaStudioBindingNavigator)
        Me.Controls.Add(Me.AnagraficaCollegataTextBox)
        Me.Controls.Add(Me.DataNascita)
        Me.Controls.Add(Me.ProvinciaNascita)
        Me.Controls.Add(Me.LuogoNascita)
        Me.Controls.Add(Me.CodiceFiscale)
        Me.Controls.Add(Me.SiglaRaccomandate)
        Me.Controls.Add(Me.SiglaLista2)
        Me.Controls.Add(Me.SiglaLista1)
        Me.Controls.Add(Me.Note)
        Me.Controls.Add(TelefonoLabel1)
        Me.Controls.Add(Me.Telefono)
        Me.Controls.Add(Me.Provincia)
        Me.Controls.Add(Me.Localita)
        Me.Controls.Add(Me.Cap)
        Me.Controls.Add(Me.Indirizzo)
        Me.Controls.Add(Me.Nominativo2)
        Me.Controls.Add(Me.Nominativo1)
        Me.Controls.Add(Me.Titolo)
        Me.Controls.Add(Me.Anagrafica)
        Me.Controls.Add(Me.Immobile)
        Me.Controls.Add(DataNascitaLabel)
        Me.Controls.Add(ProvinciaNascitaLabel)
        Me.Controls.Add(LuogoNascitaLabel)
        Me.Controls.Add(CodiceFiscaleLabel)
        Me.Controls.Add(AnagraficaCollegataLabel)
        Me.Controls.Add(SiglaRaccomandateLabel)
        Me.Controls.Add(SiglaLista2Label)
        Me.Controls.Add(SiglaLista1Label)
        Me.Controls.Add(NoteLabel)
        Me.Controls.Add(ProvinciaLabel)
        Me.Controls.Add(LocalitaLabel)
        Me.Controls.Add(CapLabel)
        Me.Controls.Add(IndirizzoLabel)
        Me.Controls.Add(Nominativo1Label)
        Me.Controls.Add(TitoloLabel)
        Me.Controls.Add(AnagraficaLabel)
        Me.Controls.Add(ImmobileLabel)
        Me.Name = "Anagrafiche"
        Me.Text = "Anagrafiche"
        CType(Me.IMMOBILIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnagraficheBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZTestoSollecitoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnagraficaStudioBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AnagraficaStudioBindingNavigator.ResumeLayout(False)
        Me.AnagraficaStudioBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IMMOBILIDataSet As Patrimonio2014.IMMOBILIDataSet
    Friend WithEvents AnagraficheBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AnagraficheTableAdapter As Patrimonio2014.IMMOBILIDataSetTableAdapters.AnagraficheTableAdapter
    Friend WithEvents TableAdapterManager As Patrimonio2014.IMMOBILIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Immobile As System.Windows.Forms.ComboBox
    Friend WithEvents Anagrafica As System.Windows.Forms.TextBox
    Friend WithEvents Titolo As System.Windows.Forms.TextBox
    Friend WithEvents Nominativo1 As System.Windows.Forms.TextBox
    Friend WithEvents Nominativo2 As System.Windows.Forms.TextBox
    Friend WithEvents Indirizzo As System.Windows.Forms.TextBox
    Friend WithEvents Cap As System.Windows.Forms.TextBox
    Friend WithEvents Localita As System.Windows.Forms.TextBox
    Friend WithEvents Provincia As System.Windows.Forms.TextBox
    Friend WithEvents Telefono As System.Windows.Forms.TextBox
    Friend WithEvents Note As System.Windows.Forms.TextBox
    Friend WithEvents SiglaLista1 As System.Windows.Forms.TextBox
    Friend WithEvents SiglaLista2 As System.Windows.Forms.TextBox
    Friend WithEvents SiglaRaccomandate As System.Windows.Forms.TextBox
    Friend WithEvents CodiceFiscale As System.Windows.Forms.TextBox
    Friend WithEvents LuogoNascita As System.Windows.Forms.TextBox
    Friend WithEvents ProvinciaNascita As System.Windows.Forms.TextBox
    Friend WithEvents DataNascita As System.Windows.Forms.DateTimePicker
    Friend WithEvents ZTestoSollecitoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Z_TestoSollecitoTableAdapter As Patrimonio2014.IMMOBILIDataSetTableAdapters.Z_TestoSollecitoTableAdapter
    Friend WithEvents AnagraficaCollegataTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AnagraficaStudioBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents AnagraficaStudioBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
End Class
