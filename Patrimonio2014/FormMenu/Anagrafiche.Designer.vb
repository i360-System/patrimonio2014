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
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim NoteLabel As System.Windows.Forms.Label
        Dim SiglaLista1Label As System.Windows.Forms.Label
        Dim SiglaLista2Label As System.Windows.Forms.Label
        Dim SiglaRaccomandateLabel As System.Windows.Forms.Label
        Dim AnagraficaCollegataLabel As System.Windows.Forms.Label
        Dim CodiceFiscaleLabel As System.Windows.Forms.Label
        Dim LuogoNascitaLabel As System.Windows.Forms.Label
        Dim ProvinciaNascitaLabel As System.Windows.Forms.Label
        Dim DataNascitaLabel As System.Windows.Forms.Label
        Me.IMMOBILIDataSet = New Patrimonio2014.IMMOBILIDataSet()
        Me.AnagraficheBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnagraficheTableAdapter = New Patrimonio2014.IMMOBILIDataSetTableAdapters.AnagraficheTableAdapter()
        Me.TableAdapterManager = New Patrimonio2014.IMMOBILIDataSetTableAdapters.TableAdapterManager()
        Me.ImmobileComboBox = New System.Windows.Forms.ComboBox()
        Me.AnagraficaTextBox = New System.Windows.Forms.TextBox()
        Me.TitoloTextBox = New System.Windows.Forms.TextBox()
        Me.Nominativo1TextBox = New System.Windows.Forms.TextBox()
        Me.Nominativo2TextBox = New System.Windows.Forms.TextBox()
        Me.IndirizzoTextBox = New System.Windows.Forms.TextBox()
        Me.CapTextBox = New System.Windows.Forms.TextBox()
        Me.LocalitaTextBox = New System.Windows.Forms.TextBox()
        Me.ProvinciaTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.NoteTextBox = New System.Windows.Forms.TextBox()
        Me.SiglaLista1TextBox = New System.Windows.Forms.TextBox()
        Me.SiglaLista2TextBox = New System.Windows.Forms.TextBox()
        Me.SiglaRaccomandateTextBox = New System.Windows.Forms.TextBox()
        Me.AnagraficaCollegataTextBox = New System.Windows.Forms.TextBox()
        Me.CodiceFiscaleTextBox = New System.Windows.Forms.TextBox()
        Me.LuogoNascitaTextBox = New System.Windows.Forms.TextBox()
        Me.ProvinciaNascitaTextBox = New System.Windows.Forms.TextBox()
        Me.DataNascitaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        ImmobileLabel = New System.Windows.Forms.Label()
        AnagraficaLabel = New System.Windows.Forms.Label()
        TitoloLabel = New System.Windows.Forms.Label()
        Nominativo1Label = New System.Windows.Forms.Label()
        IndirizzoLabel = New System.Windows.Forms.Label()
        CapLabel = New System.Windows.Forms.Label()
        LocalitaLabel = New System.Windows.Forms.Label()
        ProvinciaLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        NoteLabel = New System.Windows.Forms.Label()
        SiglaLista1Label = New System.Windows.Forms.Label()
        SiglaLista2Label = New System.Windows.Forms.Label()
        SiglaRaccomandateLabel = New System.Windows.Forms.Label()
        AnagraficaCollegataLabel = New System.Windows.Forms.Label()
        CodiceFiscaleLabel = New System.Windows.Forms.Label()
        LuogoNascitaLabel = New System.Windows.Forms.Label()
        ProvinciaNascitaLabel = New System.Windows.Forms.Label()
        DataNascitaLabel = New System.Windows.Forms.Label()
        CType(Me.IMMOBILIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnagraficheBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'ImmobileLabel
        '
        ImmobileLabel.AutoSize = True
        ImmobileLabel.Location = New System.Drawing.Point(41, 72)
        ImmobileLabel.Name = "ImmobileLabel"
        ImmobileLabel.Size = New System.Drawing.Size(51, 13)
        ImmobileLabel.TabIndex = 1
        ImmobileLabel.Text = "Immobile:"
        '
        'ImmobileComboBox
        '
        Me.ImmobileComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "Immobile", True))
        Me.ImmobileComboBox.FormattingEnabled = True
        Me.ImmobileComboBox.Location = New System.Drawing.Point(44, 88)
        Me.ImmobileComboBox.Name = "ImmobileComboBox"
        Me.ImmobileComboBox.Size = New System.Drawing.Size(376, 21)
        Me.ImmobileComboBox.TabIndex = 2
        '
        'AnagraficaLabel
        '
        AnagraficaLabel.AutoSize = True
        AnagraficaLabel.Location = New System.Drawing.Point(447, 72)
        AnagraficaLabel.Name = "AnagraficaLabel"
        AnagraficaLabel.Size = New System.Drawing.Size(61, 13)
        AnagraficaLabel.TabIndex = 2
        AnagraficaLabel.Text = "Anagrafica:"
        '
        'AnagraficaTextBox
        '
        Me.AnagraficaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "Anagrafica", True))
        Me.AnagraficaTextBox.Location = New System.Drawing.Point(450, 88)
        Me.AnagraficaTextBox.Name = "AnagraficaTextBox"
        Me.AnagraficaTextBox.Size = New System.Drawing.Size(65, 20)
        Me.AnagraficaTextBox.TabIndex = 3
        '
        'TitoloLabel
        '
        TitoloLabel.AutoSize = True
        TitoloLabel.Location = New System.Drawing.Point(41, 121)
        TitoloLabel.Name = "TitoloLabel"
        TitoloLabel.Size = New System.Drawing.Size(36, 13)
        TitoloLabel.TabIndex = 4
        TitoloLabel.Text = "Titolo:"
        '
        'TitoloTextBox
        '
        Me.TitoloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "Titolo", True))
        Me.TitoloTextBox.Location = New System.Drawing.Point(44, 137)
        Me.TitoloTextBox.Name = "TitoloTextBox"
        Me.TitoloTextBox.Size = New System.Drawing.Size(72, 20)
        Me.TitoloTextBox.TabIndex = 5
        '
        'Nominativo1Label
        '
        Nominativo1Label.AutoSize = True
        Nominativo1Label.Location = New System.Drawing.Point(149, 121)
        Nominativo1Label.Name = "Nominativo1Label"
        Nominativo1Label.Size = New System.Drawing.Size(63, 13)
        Nominativo1Label.TabIndex = 6
        Nominativo1Label.Text = "Nominativo:"
        '
        'Nominativo1TextBox
        '
        Me.Nominativo1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "Nominativo1", True))
        Me.Nominativo1TextBox.Location = New System.Drawing.Point(152, 137)
        Me.Nominativo1TextBox.Name = "Nominativo1TextBox"
        Me.Nominativo1TextBox.Size = New System.Drawing.Size(363, 20)
        Me.Nominativo1TextBox.TabIndex = 7
        '
        'Nominativo2TextBox
        '
        Me.Nominativo2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "Nominativo2", True))
        Me.Nominativo2TextBox.Location = New System.Drawing.Point(152, 163)
        Me.Nominativo2TextBox.Name = "Nominativo2TextBox"
        Me.Nominativo2TextBox.Size = New System.Drawing.Size(363, 20)
        Me.Nominativo2TextBox.TabIndex = 9
        '
        'IndirizzoLabel
        '
        IndirizzoLabel.AutoSize = True
        IndirizzoLabel.Location = New System.Drawing.Point(149, 186)
        IndirizzoLabel.Name = "IndirizzoLabel"
        IndirizzoLabel.Size = New System.Drawing.Size(48, 13)
        IndirizzoLabel.TabIndex = 9
        IndirizzoLabel.Text = "Indirizzo:"
        '
        'IndirizzoTextBox
        '
        Me.IndirizzoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "Indirizzo", True))
        Me.IndirizzoTextBox.Location = New System.Drawing.Point(152, 202)
        Me.IndirizzoTextBox.Name = "IndirizzoTextBox"
        Me.IndirizzoTextBox.Size = New System.Drawing.Size(363, 20)
        Me.IndirizzoTextBox.TabIndex = 10
        '
        'CapLabel
        '
        CapLabel.AutoSize = True
        CapLabel.Location = New System.Drawing.Point(41, 225)
        CapLabel.Name = "CapLabel"
        CapLabel.Size = New System.Drawing.Size(29, 13)
        CapLabel.TabIndex = 11
        CapLabel.Text = "Cap:"
        '
        'CapTextBox
        '
        Me.CapTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "Cap", True))
        Me.CapTextBox.Location = New System.Drawing.Point(44, 241)
        Me.CapTextBox.Name = "CapTextBox"
        Me.CapTextBox.Size = New System.Drawing.Size(90, 20)
        Me.CapTextBox.TabIndex = 12
        '
        'LocalitaLabel
        '
        LocalitaLabel.AutoSize = True
        LocalitaLabel.Location = New System.Drawing.Point(149, 225)
        LocalitaLabel.Name = "LocalitaLabel"
        LocalitaLabel.Size = New System.Drawing.Size(47, 13)
        LocalitaLabel.TabIndex = 13
        LocalitaLabel.Text = "Localita:"
        '
        'LocalitaTextBox
        '
        Me.LocalitaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "Localita", True))
        Me.LocalitaTextBox.Location = New System.Drawing.Point(152, 241)
        Me.LocalitaTextBox.Name = "LocalitaTextBox"
        Me.LocalitaTextBox.Size = New System.Drawing.Size(363, 20)
        Me.LocalitaTextBox.TabIndex = 14
        '
        'ProvinciaLabel
        '
        ProvinciaLabel.AutoSize = True
        ProvinciaLabel.Location = New System.Drawing.Point(529, 225)
        ProvinciaLabel.Name = "ProvinciaLabel"
        ProvinciaLabel.Size = New System.Drawing.Size(54, 13)
        ProvinciaLabel.TabIndex = 15
        ProvinciaLabel.Text = "Provincia:"
        '
        'ProvinciaTextBox
        '
        Me.ProvinciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "Provincia", True))
        Me.ProvinciaTextBox.Location = New System.Drawing.Point(532, 241)
        Me.ProvinciaTextBox.Name = "ProvinciaTextBox"
        Me.ProvinciaTextBox.Size = New System.Drawing.Size(51, 20)
        Me.ProvinciaTextBox.TabIndex = 16
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(144, 281)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(52, 13)
        TelefonoLabel.TabIndex = 17
        TelefonoLabel.Text = "Telefono:"
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "Telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(152, 297)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(363, 20)
        Me.TelefonoTextBox.TabIndex = 18
        '
        'NoteLabel
        '
        NoteLabel.AutoSize = True
        NoteLabel.Location = New System.Drawing.Point(144, 320)
        NoteLabel.Name = "NoteLabel"
        NoteLabel.Size = New System.Drawing.Size(33, 13)
        NoteLabel.TabIndex = 19
        NoteLabel.Text = "Note:"
        '
        'NoteTextBox
        '
        Me.NoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "Note", True))
        Me.NoteTextBox.Location = New System.Drawing.Point(147, 336)
        Me.NoteTextBox.Name = "NoteTextBox"
        Me.NoteTextBox.Size = New System.Drawing.Size(368, 20)
        Me.NoteTextBox.TabIndex = 20
        '
        'SiglaLista1Label
        '
        SiglaLista1Label.AutoSize = True
        SiglaLista1Label.Location = New System.Drawing.Point(55, 359)
        SiglaLista1Label.Name = "SiglaLista1Label"
        SiglaLista1Label.Size = New System.Drawing.Size(64, 13)
        SiglaLista1Label.TabIndex = 21
        SiglaLista1Label.Text = "Sigla Lista1:"
        '
        'SiglaLista1TextBox
        '
        Me.SiglaLista1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "SiglaLista1", True))
        Me.SiglaLista1TextBox.Location = New System.Drawing.Point(58, 375)
        Me.SiglaLista1TextBox.Name = "SiglaLista1TextBox"
        Me.SiglaLista1TextBox.Size = New System.Drawing.Size(61, 20)
        Me.SiglaLista1TextBox.TabIndex = 22
        '
        'SiglaLista2Label
        '
        SiglaLista2Label.AutoSize = True
        SiglaLista2Label.Location = New System.Drawing.Point(144, 359)
        SiglaLista2Label.Name = "SiglaLista2Label"
        SiglaLista2Label.Size = New System.Drawing.Size(64, 13)
        SiglaLista2Label.TabIndex = 23
        SiglaLista2Label.Text = "Sigla Lista2:"
        '
        'SiglaLista2TextBox
        '
        Me.SiglaLista2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "SiglaLista2", True))
        Me.SiglaLista2TextBox.Location = New System.Drawing.Point(147, 375)
        Me.SiglaLista2TextBox.Name = "SiglaLista2TextBox"
        Me.SiglaLista2TextBox.Size = New System.Drawing.Size(61, 20)
        Me.SiglaLista2TextBox.TabIndex = 24
        '
        'SiglaRaccomandateLabel
        '
        SiglaRaccomandateLabel.AutoSize = True
        SiglaRaccomandateLabel.Location = New System.Drawing.Point(225, 359)
        SiglaRaccomandateLabel.Name = "SiglaRaccomandateLabel"
        SiglaRaccomandateLabel.Size = New System.Drawing.Size(109, 13)
        SiglaRaccomandateLabel.TabIndex = 25
        SiglaRaccomandateLabel.Text = "Sigla Raccomandate:"
        '
        'SiglaRaccomandateTextBox
        '
        Me.SiglaRaccomandateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "SiglaRaccomandate", True))
        Me.SiglaRaccomandateTextBox.Location = New System.Drawing.Point(228, 375)
        Me.SiglaRaccomandateTextBox.Name = "SiglaRaccomandateTextBox"
        Me.SiglaRaccomandateTextBox.Size = New System.Drawing.Size(68, 20)
        Me.SiglaRaccomandateTextBox.TabIndex = 26
        '
        'AnagraficaCollegataLabel
        '
        AnagraficaCollegataLabel.AutoSize = True
        AnagraficaCollegataLabel.Location = New System.Drawing.Point(340, 359)
        AnagraficaCollegataLabel.Name = "AnagraficaCollegataLabel"
        AnagraficaCollegataLabel.Size = New System.Drawing.Size(108, 13)
        AnagraficaCollegataLabel.TabIndex = 27
        AnagraficaCollegataLabel.Text = "Anagrafica Collegata:"
        '
        'AnagraficaCollegataTextBox
        '
        Me.AnagraficaCollegataTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "AnagraficaCollegata", True))
        Me.AnagraficaCollegataTextBox.Location = New System.Drawing.Point(343, 375)
        Me.AnagraficaCollegataTextBox.Name = "AnagraficaCollegataTextBox"
        Me.AnagraficaCollegataTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AnagraficaCollegataTextBox.TabIndex = 28
        '
        'CodiceFiscaleLabel
        '
        CodiceFiscaleLabel.AutoSize = True
        CodiceFiscaleLabel.Location = New System.Drawing.Point(463, 359)
        CodiceFiscaleLabel.Name = "CodiceFiscaleLabel"
        CodiceFiscaleLabel.Size = New System.Drawing.Size(79, 13)
        CodiceFiscaleLabel.TabIndex = 29
        CodiceFiscaleLabel.Text = "Codice Fiscale:"
        '
        'CodiceFiscaleTextBox
        '
        Me.CodiceFiscaleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "CodiceFiscale", True))
        Me.CodiceFiscaleTextBox.Location = New System.Drawing.Point(466, 375)
        Me.CodiceFiscaleTextBox.Name = "CodiceFiscaleTextBox"
        Me.CodiceFiscaleTextBox.Size = New System.Drawing.Size(190, 20)
        Me.CodiceFiscaleTextBox.TabIndex = 30
        '
        'LuogoNascitaLabel
        '
        LuogoNascitaLabel.AutoSize = True
        LuogoNascitaLabel.Location = New System.Drawing.Point(55, 398)
        LuogoNascitaLabel.Name = "LuogoNascitaLabel"
        LuogoNascitaLabel.Size = New System.Drawing.Size(79, 13)
        LuogoNascitaLabel.TabIndex = 31
        LuogoNascitaLabel.Text = "Luogo Nascita:"
        '
        'LuogoNascitaTextBox
        '
        Me.LuogoNascitaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "LuogoNascita", True))
        Me.LuogoNascitaTextBox.Location = New System.Drawing.Point(58, 414)
        Me.LuogoNascitaTextBox.Name = "LuogoNascitaTextBox"
        Me.LuogoNascitaTextBox.Size = New System.Drawing.Size(266, 20)
        Me.LuogoNascitaTextBox.TabIndex = 32
        '
        'ProvinciaNascitaLabel
        '
        ProvinciaNascitaLabel.AutoSize = True
        ProvinciaNascitaLabel.Location = New System.Drawing.Point(340, 398)
        ProvinciaNascitaLabel.Name = "ProvinciaNascitaLabel"
        ProvinciaNascitaLabel.Size = New System.Drawing.Size(93, 13)
        ProvinciaNascitaLabel.TabIndex = 33
        ProvinciaNascitaLabel.Text = "Provincia Nascita:"
        '
        'ProvinciaNascitaTextBox
        '
        Me.ProvinciaNascitaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "ProvinciaNascita", True))
        Me.ProvinciaNascitaTextBox.Location = New System.Drawing.Point(343, 414)
        Me.ProvinciaNascitaTextBox.Name = "ProvinciaNascitaTextBox"
        Me.ProvinciaNascitaTextBox.Size = New System.Drawing.Size(90, 20)
        Me.ProvinciaNascitaTextBox.TabIndex = 34
        '
        'DataNascitaLabel
        '
        DataNascitaLabel.AutoSize = True
        DataNascitaLabel.Location = New System.Drawing.Point(463, 398)
        DataNascitaLabel.Name = "DataNascitaLabel"
        DataNascitaLabel.Size = New System.Drawing.Size(72, 13)
        DataNascitaLabel.TabIndex = 35
        DataNascitaLabel.Text = "Data Nascita:"
        '
        'DataNascitaDateTimePicker
        '
        Me.DataNascitaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AnagraficheBindingSource, "DataNascita", True))
        Me.DataNascitaDateTimePicker.Location = New System.Drawing.Point(466, 414)
        Me.DataNascitaDateTimePicker.Name = "DataNascitaDateTimePicker"
        Me.DataNascitaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DataNascitaDateTimePicker.TabIndex = 36
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 464)
        Me.Controls.Add(DataNascitaLabel)
        Me.Controls.Add(Me.DataNascitaDateTimePicker)
        Me.Controls.Add(ProvinciaNascitaLabel)
        Me.Controls.Add(Me.ProvinciaNascitaTextBox)
        Me.Controls.Add(LuogoNascitaLabel)
        Me.Controls.Add(Me.LuogoNascitaTextBox)
        Me.Controls.Add(CodiceFiscaleLabel)
        Me.Controls.Add(Me.CodiceFiscaleTextBox)
        Me.Controls.Add(AnagraficaCollegataLabel)
        Me.Controls.Add(Me.AnagraficaCollegataTextBox)
        Me.Controls.Add(SiglaRaccomandateLabel)
        Me.Controls.Add(Me.SiglaRaccomandateTextBox)
        Me.Controls.Add(SiglaLista2Label)
        Me.Controls.Add(Me.SiglaLista2TextBox)
        Me.Controls.Add(SiglaLista1Label)
        Me.Controls.Add(Me.SiglaLista1TextBox)
        Me.Controls.Add(NoteLabel)
        Me.Controls.Add(Me.NoteTextBox)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(ProvinciaLabel)
        Me.Controls.Add(Me.ProvinciaTextBox)
        Me.Controls.Add(LocalitaLabel)
        Me.Controls.Add(Me.LocalitaTextBox)
        Me.Controls.Add(CapLabel)
        Me.Controls.Add(Me.CapTextBox)
        Me.Controls.Add(IndirizzoLabel)
        Me.Controls.Add(Me.IndirizzoTextBox)
        Me.Controls.Add(Me.Nominativo2TextBox)
        Me.Controls.Add(Nominativo1Label)
        Me.Controls.Add(Me.Nominativo1TextBox)
        Me.Controls.Add(TitoloLabel)
        Me.Controls.Add(Me.TitoloTextBox)
        Me.Controls.Add(AnagraficaLabel)
        Me.Controls.Add(Me.AnagraficaTextBox)
        Me.Controls.Add(ImmobileLabel)
        Me.Controls.Add(Me.ImmobileComboBox)
        Me.Name = "Form1"
        Me.Text = "Anagrafiche"
        CType(Me.IMMOBILIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnagraficheBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IMMOBILIDataSet As Patrimonio2014.IMMOBILIDataSet
    Friend WithEvents AnagraficheBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AnagraficheTableAdapter As Patrimonio2014.IMMOBILIDataSetTableAdapters.AnagraficheTableAdapter
    Friend WithEvents TableAdapterManager As Patrimonio2014.IMMOBILIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ImmobileComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AnagraficaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TitoloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nominativo1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nominativo2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents IndirizzoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CapTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LocalitaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProvinciaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NoteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SiglaLista1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents SiglaLista2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents SiglaRaccomandateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AnagraficaCollegataTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CodiceFiscaleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LuogoNascitaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProvinciaNascitaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataNascitaDateTimePicker As System.Windows.Forms.DateTimePicker
End Class
