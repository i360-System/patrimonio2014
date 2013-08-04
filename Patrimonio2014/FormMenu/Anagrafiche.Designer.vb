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
        Me.AnagraficheBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.AnagraficheBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
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
        Me.AnagraficaCollegata = New System.Windows.Forms.ComboBox()
        Me.CodiceFiscale = New System.Windows.Forms.TextBox()
        Me.LuogoNascita = New System.Windows.Forms.TextBox()
        Me.ProvinciaNascita = New System.Windows.Forms.TextBox()
        Me.DataNascita = New System.Windows.Forms.DateTimePicker()
        Me.ZTestoSollecitoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Z_TestoSollecitoTableAdapter = New Patrimonio2014.IMMOBILIDataSetTableAdapters.Z_TestoSollecitoTableAdapter()
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
        CType(Me.AnagraficheBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AnagraficheBindingNavigator.SuspendLayout()
        CType(Me.ZTestoSollecitoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'AnagraficaLabel
        '
        AnagraficaLabel.AutoSize = True
        AnagraficaLabel.Location = New System.Drawing.Point(447, 72)
        AnagraficaLabel.Name = "AnagraficaLabel"
        AnagraficaLabel.Size = New System.Drawing.Size(61, 13)
        AnagraficaLabel.TabIndex = 2
        AnagraficaLabel.Text = "Anagrafica:"
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
        'Nominativo1Label
        '
        Nominativo1Label.AutoSize = True
        Nominativo1Label.Location = New System.Drawing.Point(149, 121)
        Nominativo1Label.Name = "Nominativo1Label"
        Nominativo1Label.Size = New System.Drawing.Size(63, 13)
        Nominativo1Label.TabIndex = 6
        Nominativo1Label.Text = "Nominativo:"
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
        'CapLabel
        '
        CapLabel.AutoSize = True
        CapLabel.Location = New System.Drawing.Point(41, 225)
        CapLabel.Name = "CapLabel"
        CapLabel.Size = New System.Drawing.Size(29, 13)
        CapLabel.TabIndex = 11
        CapLabel.Text = "Cap:"
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
        'ProvinciaLabel
        '
        ProvinciaLabel.AutoSize = True
        ProvinciaLabel.Location = New System.Drawing.Point(529, 225)
        ProvinciaLabel.Name = "ProvinciaLabel"
        ProvinciaLabel.Size = New System.Drawing.Size(54, 13)
        ProvinciaLabel.TabIndex = 15
        ProvinciaLabel.Text = "Provincia:"
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
        'SiglaLista1Label
        '
        SiglaLista1Label.AutoSize = True
        SiglaLista1Label.Location = New System.Drawing.Point(55, 359)
        SiglaLista1Label.Name = "SiglaLista1Label"
        SiglaLista1Label.Size = New System.Drawing.Size(64, 13)
        SiglaLista1Label.TabIndex = 21
        SiglaLista1Label.Text = "Sigla Lista1:"
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
        'SiglaRaccomandateLabel
        '
        SiglaRaccomandateLabel.AutoSize = True
        SiglaRaccomandateLabel.Location = New System.Drawing.Point(225, 359)
        SiglaRaccomandateLabel.Name = "SiglaRaccomandateLabel"
        SiglaRaccomandateLabel.Size = New System.Drawing.Size(109, 13)
        SiglaRaccomandateLabel.TabIndex = 25
        SiglaRaccomandateLabel.Text = "Sigla Raccomandate:"
        '
        'AnagraficaCollegataLabel
        '
        AnagraficaCollegataLabel.AutoSize = True
        AnagraficaCollegataLabel.Location = New System.Drawing.Point(340, 359)
        AnagraficaCollegataLabel.Name = "AnagraficaCollegataLabel"
        AnagraficaCollegataLabel.Size = New System.Drawing.Size(77, 13)
        AnagraficaCollegataLabel.TabIndex = 27
        AnagraficaCollegataLabel.Text = "Testo Sollecito"
        '
        'CodiceFiscaleLabel
        '
        CodiceFiscaleLabel.AutoSize = True
        CodiceFiscaleLabel.Location = New System.Drawing.Point(529, 359)
        CodiceFiscaleLabel.Name = "CodiceFiscaleLabel"
        CodiceFiscaleLabel.Size = New System.Drawing.Size(79, 13)
        CodiceFiscaleLabel.TabIndex = 29
        CodiceFiscaleLabel.Text = "Codice Fiscale:"
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
        'ProvinciaNascitaLabel
        '
        ProvinciaNascitaLabel.AutoSize = True
        ProvinciaNascitaLabel.Location = New System.Drawing.Point(340, 398)
        ProvinciaNascitaLabel.Name = "ProvinciaNascitaLabel"
        ProvinciaNascitaLabel.Size = New System.Drawing.Size(93, 13)
        ProvinciaNascitaLabel.TabIndex = 33
        ProvinciaNascitaLabel.Text = "Provincia Nascita:"
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
        'TelefonoLabel1
        '
        TelefonoLabel1.AutoSize = True
        TelefonoLabel1.Location = New System.Drawing.Point(144, 284)
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
        'AnagraficheBindingNavigator
        '
        Me.AnagraficheBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AnagraficheBindingNavigator.BindingSource = Me.AnagraficheBindingSource
        Me.AnagraficheBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AnagraficheBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AnagraficheBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AnagraficheBindingNavigatorSaveItem})
        Me.AnagraficheBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AnagraficheBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AnagraficheBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AnagraficheBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AnagraficheBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AnagraficheBindingNavigator.Name = "AnagraficheBindingNavigator"
        Me.AnagraficheBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AnagraficheBindingNavigator.Size = New System.Drawing.Size(776, 25)
        Me.AnagraficheBindingNavigator.TabIndex = 37
        Me.AnagraficheBindingNavigator.Text = "BindingNavigator1"
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
        'AnagraficheBindingNavigatorSaveItem
        '
        Me.AnagraficheBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AnagraficheBindingNavigatorSaveItem.Image = CType(resources.GetObject("AnagraficheBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AnagraficheBindingNavigatorSaveItem.Name = "AnagraficheBindingNavigatorSaveItem"
        Me.AnagraficheBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.AnagraficheBindingNavigatorSaveItem.Text = "Salva dati"
        '
        'Immobile
        '
        Me.Immobile.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "Immobile", True))
        Me.Immobile.FormattingEnabled = True
        Me.Immobile.Location = New System.Drawing.Point(44, 88)
        Me.Immobile.Name = "Immobile"
        Me.Immobile.Size = New System.Drawing.Size(389, 21)
        Me.Immobile.TabIndex = 38
        '
        'Anagrafica
        '
        Me.Anagrafica.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "Anagrafica", True))
        Me.Anagrafica.Location = New System.Drawing.Point(450, 89)
        Me.Anagrafica.Name = "Anagrafica"
        Me.Anagrafica.Size = New System.Drawing.Size(65, 20)
        Me.Anagrafica.TabIndex = 39
        '
        'Titolo
        '
        Me.Titolo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "Titolo", True))
        Me.Titolo.Location = New System.Drawing.Point(46, 137)
        Me.Titolo.Name = "Titolo"
        Me.Titolo.Size = New System.Drawing.Size(88, 20)
        Me.Titolo.TabIndex = 40
        '
        'Nominativo1
        '
        Me.Nominativo1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "Nominativo1", True))
        Me.Nominativo1.Location = New System.Drawing.Point(152, 137)
        Me.Nominativo1.Name = "Nominativo1"
        Me.Nominativo1.Size = New System.Drawing.Size(363, 20)
        Me.Nominativo1.TabIndex = 41
        '
        'Nominativo2
        '
        Me.Nominativo2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "Nominativo2", True))
        Me.Nominativo2.Location = New System.Drawing.Point(152, 163)
        Me.Nominativo2.Name = "Nominativo2"
        Me.Nominativo2.Size = New System.Drawing.Size(363, 20)
        Me.Nominativo2.TabIndex = 42
        '
        'Indirizzo
        '
        Me.Indirizzo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "Indirizzo", True))
        Me.Indirizzo.Location = New System.Drawing.Point(152, 202)
        Me.Indirizzo.Name = "Indirizzo"
        Me.Indirizzo.Size = New System.Drawing.Size(363, 20)
        Me.Indirizzo.TabIndex = 43
        '
        'Cap
        '
        Me.Cap.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "Cap", True))
        Me.Cap.Location = New System.Drawing.Point(46, 241)
        Me.Cap.Name = "Cap"
        Me.Cap.Size = New System.Drawing.Size(88, 20)
        Me.Cap.TabIndex = 44
        '
        'Localita
        '
        Me.Localita.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "Localita", True))
        Me.Localita.Location = New System.Drawing.Point(152, 241)
        Me.Localita.Name = "Localita"
        Me.Localita.Size = New System.Drawing.Size(363, 20)
        Me.Localita.TabIndex = 45
        '
        'Provincia
        '
        Me.Provincia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "Provincia", True))
        Me.Provincia.Location = New System.Drawing.Point(532, 241)
        Me.Provincia.Name = "Provincia"
        Me.Provincia.Size = New System.Drawing.Size(51, 20)
        Me.Provincia.TabIndex = 46
        '
        'Telefono
        '
        Me.Telefono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "Telefono", True))
        Me.Telefono.Location = New System.Drawing.Point(147, 300)
        Me.Telefono.Name = "Telefono"
        Me.Telefono.Size = New System.Drawing.Size(368, 20)
        Me.Telefono.TabIndex = 47
        '
        'Note
        '
        Me.Note.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "Note", True))
        Me.Note.Location = New System.Drawing.Point(147, 336)
        Me.Note.Name = "Note"
        Me.Note.Size = New System.Drawing.Size(368, 20)
        Me.Note.TabIndex = 48
        '
        'SiglaLista1
        '
        Me.SiglaLista1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "SiglaLista1", True))
        Me.SiglaLista1.Location = New System.Drawing.Point(58, 375)
        Me.SiglaLista1.Name = "SiglaLista1"
        Me.SiglaLista1.Size = New System.Drawing.Size(61, 20)
        Me.SiglaLista1.TabIndex = 49
        '
        'SiglaLista2
        '
        Me.SiglaLista2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "SiglaLista2", True))
        Me.SiglaLista2.Location = New System.Drawing.Point(147, 375)
        Me.SiglaLista2.Name = "SiglaLista2"
        Me.SiglaLista2.Size = New System.Drawing.Size(61, 20)
        Me.SiglaLista2.TabIndex = 50
        '
        'SiglaRaccomandate
        '
        Me.SiglaRaccomandate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "SiglaRaccomandate", True))
        Me.SiglaRaccomandate.Location = New System.Drawing.Point(228, 375)
        Me.SiglaRaccomandate.Name = "SiglaRaccomandate"
        Me.SiglaRaccomandate.Size = New System.Drawing.Size(100, 20)
        Me.SiglaRaccomandate.TabIndex = 51
        '
        'AnagraficaCollegata
        '
        Me.AnagraficaCollegata.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AnagraficheBindingSource, "AnagraficaCollegata", True))
        Me.AnagraficaCollegata.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "AnagraficaCollegata", True))
        Me.AnagraficaCollegata.DataSource = Me.AnagraficheBindingSource
        Me.AnagraficaCollegata.DisplayMember = "AnagraficaCollegata"
        Me.AnagraficaCollegata.FormattingEnabled = True
        Me.AnagraficaCollegata.Location = New System.Drawing.Point(343, 374)
        Me.AnagraficaCollegata.Name = "AnagraficaCollegata"
        Me.AnagraficaCollegata.Size = New System.Drawing.Size(172, 21)
        Me.AnagraficaCollegata.TabIndex = 52
        Me.AnagraficaCollegata.ValueMember = "AnagraficaCollegata"
        '
        'CodiceFiscale
        '
        Me.CodiceFiscale.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "CodiceFiscale", True))
        Me.CodiceFiscale.Location = New System.Drawing.Point(532, 375)
        Me.CodiceFiscale.Name = "CodiceFiscale"
        Me.CodiceFiscale.Size = New System.Drawing.Size(219, 20)
        Me.CodiceFiscale.TabIndex = 53
        '
        'LuogoNascita
        '
        Me.LuogoNascita.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "LuogoNascita", True))
        Me.LuogoNascita.Location = New System.Drawing.Point(58, 414)
        Me.LuogoNascita.Name = "LuogoNascita"
        Me.LuogoNascita.Size = New System.Drawing.Size(270, 20)
        Me.LuogoNascita.TabIndex = 54
        '
        'ProvinciaNascita
        '
        Me.ProvinciaNascita.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "ProvinciaNascita", True))
        Me.ProvinciaNascita.Location = New System.Drawing.Point(343, 414)
        Me.ProvinciaNascita.Name = "ProvinciaNascita"
        Me.ProvinciaNascita.Size = New System.Drawing.Size(90, 20)
        Me.ProvinciaNascita.TabIndex = 55
        '
        'DataNascita
        '
        Me.DataNascita.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AnagraficheBindingSource, "DataNascita", True))
        Me.DataNascita.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataNascita.Location = New System.Drawing.Point(466, 411)
        Me.DataNascita.Name = "DataNascita"
        Me.DataNascita.Size = New System.Drawing.Size(200, 20)
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
        'Anagrafiche
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 464)
        Me.Controls.Add(Me.DataNascita)
        Me.Controls.Add(Me.ProvinciaNascita)
        Me.Controls.Add(Me.LuogoNascita)
        Me.Controls.Add(Me.CodiceFiscale)
        Me.Controls.Add(Me.AnagraficaCollegata)
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
        Me.Controls.Add(Me.AnagraficheBindingNavigator)
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
        CType(Me.AnagraficheBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AnagraficheBindingNavigator.ResumeLayout(False)
        Me.AnagraficheBindingNavigator.PerformLayout()
        CType(Me.ZTestoSollecitoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IMMOBILIDataSet As Patrimonio2014.IMMOBILIDataSet
    Friend WithEvents AnagraficheBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AnagraficheTableAdapter As Patrimonio2014.IMMOBILIDataSetTableAdapters.AnagraficheTableAdapter
    Friend WithEvents TableAdapterManager As Patrimonio2014.IMMOBILIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AnagraficheBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents AnagraficheBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
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
    Friend WithEvents AnagraficaCollegata As System.Windows.Forms.ComboBox
    Friend WithEvents CodiceFiscale As System.Windows.Forms.TextBox
    Friend WithEvents LuogoNascita As System.Windows.Forms.TextBox
    Friend WithEvents ProvinciaNascita As System.Windows.Forms.TextBox
    Friend WithEvents DataNascita As System.Windows.Forms.DateTimePicker
    Friend WithEvents ZTestoSollecitoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Z_TestoSollecitoTableAdapter As Patrimonio2014.IMMOBILIDataSetTableAdapters.Z_TestoSollecitoTableAdapter
End Class
