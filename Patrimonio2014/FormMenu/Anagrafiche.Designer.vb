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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Anagrafiche))
        Me.IMMOBILIDataSet2 = New Patrimonio2014.IMMOBILIDataSet2()
        Me.AnagraficheBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnagraficheTableAdapter = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.AnagraficheTableAdapter()
        Me.TableAdapterManager = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.TableAdapterManager()
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
        Me.ImmobileComboBox = New System.Windows.Forms.ComboBox()
        Me.ImmobiliBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.ImmobiliTableAdapter = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.ImmobiliTableAdapter()
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
        CType(Me.IMMOBILIDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnagraficheBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnagraficheBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AnagraficheBindingNavigator.SuspendLayout()
        CType(Me.ImmobiliBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImmobileLabel
        '
        ImmobileLabel.AutoSize = True
        ImmobileLabel.Location = New System.Drawing.Point(12, 49)
        ImmobileLabel.Name = "ImmobileLabel"
        ImmobileLabel.Size = New System.Drawing.Size(51, 13)
        ImmobileLabel.TabIndex = 1
        ImmobileLabel.Text = "Immobile:"
        '
        'AnagraficaLabel
        '
        AnagraficaLabel.AutoSize = True
        AnagraficaLabel.Location = New System.Drawing.Point(370, 49)
        AnagraficaLabel.Name = "AnagraficaLabel"
        AnagraficaLabel.Size = New System.Drawing.Size(61, 13)
        AnagraficaLabel.TabIndex = 3
        AnagraficaLabel.Text = "Anagrafica:"
        '
        'TitoloLabel
        '
        TitoloLabel.AutoSize = True
        TitoloLabel.Location = New System.Drawing.Point(12, 89)
        TitoloLabel.Name = "TitoloLabel"
        TitoloLabel.Size = New System.Drawing.Size(36, 13)
        TitoloLabel.TabIndex = 5
        TitoloLabel.Text = "Titolo:"
        '
        'Nominativo1Label
        '
        Nominativo1Label.AutoSize = True
        Nominativo1Label.Location = New System.Drawing.Point(113, 89)
        Nominativo1Label.Name = "Nominativo1Label"
        Nominativo1Label.Size = New System.Drawing.Size(63, 13)
        Nominativo1Label.TabIndex = 7
        Nominativo1Label.Text = "Nominativo:"
        '
        'IndirizzoLabel
        '
        IndirizzoLabel.AutoSize = True
        IndirizzoLabel.Location = New System.Drawing.Point(113, 154)
        IndirizzoLabel.Name = "IndirizzoLabel"
        IndirizzoLabel.Size = New System.Drawing.Size(48, 13)
        IndirizzoLabel.TabIndex = 10
        IndirizzoLabel.Text = "Indirizzo:"
        '
        'CapLabel
        '
        CapLabel.AutoSize = True
        CapLabel.Location = New System.Drawing.Point(12, 189)
        CapLabel.Name = "CapLabel"
        CapLabel.Size = New System.Drawing.Size(29, 13)
        CapLabel.TabIndex = 12
        CapLabel.Text = "Cap:"
        '
        'LocalitaLabel
        '
        LocalitaLabel.AutoSize = True
        LocalitaLabel.Location = New System.Drawing.Point(113, 193)
        LocalitaLabel.Name = "LocalitaLabel"
        LocalitaLabel.Size = New System.Drawing.Size(47, 13)
        LocalitaLabel.TabIndex = 14
        LocalitaLabel.Text = "Localita:"
        '
        'ProvinciaLabel
        '
        ProvinciaLabel.AutoSize = True
        ProvinciaLabel.Location = New System.Drawing.Point(434, 193)
        ProvinciaLabel.Name = "ProvinciaLabel"
        ProvinciaLabel.Size = New System.Drawing.Size(54, 13)
        ProvinciaLabel.TabIndex = 16
        ProvinciaLabel.Text = "Provincia:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(113, 244)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(52, 13)
        TelefonoLabel.TabIndex = 18
        TelefonoLabel.Text = "Telefono:"
        '
        'NoteLabel
        '
        NoteLabel.AutoSize = True
        NoteLabel.Location = New System.Drawing.Point(113, 283)
        NoteLabel.Name = "NoteLabel"
        NoteLabel.Size = New System.Drawing.Size(33, 13)
        NoteLabel.TabIndex = 20
        NoteLabel.Text = "Note:"
        '
        'SiglaLista1Label
        '
        SiglaLista1Label.AutoSize = True
        SiglaLista1Label.Location = New System.Drawing.Point(113, 335)
        SiglaLista1Label.Name = "SiglaLista1Label"
        SiglaLista1Label.Size = New System.Drawing.Size(42, 13)
        SiglaLista1Label.TabIndex = 22
        SiglaLista1Label.Text = "Sigla 1:"
        '
        'SiglaLista2Label
        '
        SiglaLista2Label.AutoSize = True
        SiglaLista2Label.Location = New System.Drawing.Point(161, 335)
        SiglaLista2Label.Name = "SiglaLista2Label"
        SiglaLista2Label.Size = New System.Drawing.Size(42, 13)
        SiglaLista2Label.TabIndex = 24
        SiglaLista2Label.Text = "Sigla 2:"
        '
        'SiglaRaccomandateLabel
        '
        SiglaRaccomandateLabel.AutoSize = True
        SiglaRaccomandateLabel.Location = New System.Drawing.Point(219, 335)
        SiglaRaccomandateLabel.Name = "SiglaRaccomandateLabel"
        SiglaRaccomandateLabel.Size = New System.Drawing.Size(79, 13)
        SiglaRaccomandateLabel.TabIndex = 26
        SiglaRaccomandateLabel.Text = "Sigla Raccom.:"
        '
        'AnagraficaCollegataLabel
        '
        AnagraficaCollegataLabel.AutoSize = True
        AnagraficaCollegataLabel.Location = New System.Drawing.Point(312, 335)
        AnagraficaCollegataLabel.Name = "AnagraficaCollegataLabel"
        AnagraficaCollegataLabel.Size = New System.Drawing.Size(80, 13)
        AnagraficaCollegataLabel.TabIndex = 28
        AnagraficaCollegataLabel.Text = "Testo Sollecito:"
        '
        'CodiceFiscaleLabel
        '
        CodiceFiscaleLabel.AutoSize = True
        CodiceFiscaleLabel.Location = New System.Drawing.Point(434, 335)
        CodiceFiscaleLabel.Name = "CodiceFiscaleLabel"
        CodiceFiscaleLabel.Size = New System.Drawing.Size(79, 13)
        CodiceFiscaleLabel.TabIndex = 30
        CodiceFiscaleLabel.Text = "Codice Fiscale:"
        '
        'LuogoNascitaLabel
        '
        LuogoNascitaLabel.AutoSize = True
        LuogoNascitaLabel.Location = New System.Drawing.Point(113, 377)
        LuogoNascitaLabel.Name = "LuogoNascitaLabel"
        LuogoNascitaLabel.Size = New System.Drawing.Size(79, 13)
        LuogoNascitaLabel.TabIndex = 32
        LuogoNascitaLabel.Text = "Luogo Nascita:"
        '
        'ProvinciaNascitaLabel
        '
        ProvinciaNascitaLabel.AutoSize = True
        ProvinciaNascitaLabel.Location = New System.Drawing.Point(329, 374)
        ProvinciaNascitaLabel.Name = "ProvinciaNascitaLabel"
        ProvinciaNascitaLabel.Size = New System.Drawing.Size(74, 13)
        ProvinciaNascitaLabel.TabIndex = 34
        ProvinciaNascitaLabel.Text = "Prov. Nascita:"
        '
        'DataNascitaLabel
        '
        DataNascitaLabel.AutoSize = True
        DataNascitaLabel.Location = New System.Drawing.Point(434, 374)
        DataNascitaLabel.Name = "DataNascitaLabel"
        DataNascitaLabel.Size = New System.Drawing.Size(72, 13)
        DataNascitaLabel.TabIndex = 36
        DataNascitaLabel.Text = "Data Nascita:"
        AddHandler DataNascitaLabel.Click, AddressOf Me.DataNascitaLabel_Click
        '
        'IMMOBILIDataSet2
        '
        Me.IMMOBILIDataSet2.DataSetName = "IMMOBILIDataSet2"
        Me.IMMOBILIDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AnagraficheBindingSource
        '
        Me.AnagraficheBindingSource.DataMember = "Anagrafiche"
        Me.AnagraficheBindingSource.DataSource = Me.IMMOBILIDataSet2
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
        Me.TableAdapterManager.CassaTableAdapter = Nothing
        Me.TableAdapterManager.ContiFinanziariTableAdapter = Nothing
        Me.TableAdapterManager.CostantiTableAdapter = Nothing
        Me.TableAdapterManager.FabbricatiDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.FabbricatiTableAdapter = Nothing
        Me.TableAdapterManager.FondiTableAdapter = Nothing
        Me.TableAdapterManager.FornitoriTableAdapter = Nothing
        Me.TableAdapterManager.GruppiDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.GruppiTableAdapter = Nothing
        Me.TableAdapterManager.ImmobiliTableAdapter = Nothing
        Me.TableAdapterManager.PianoContiConsuntivoDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.PianoContiConsuntivoTableAdapter = Nothing
        Me.TableAdapterManager.PianoContiPreventivoDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.PianoContiPreventivoTableAdapter = Nothing
        Me.TableAdapterManager.TabellaDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.TabellaTableAdapter = Nothing
        Me.TableAdapterManager.UnitaDettaglioAnagraficaTableAdapter = Nothing
        Me.TableAdapterManager.UnitaDettaglioLettureTableAdapter = Nothing
        Me.TableAdapterManager.UnitaDettaglioMillesimiTableAdapter = Nothing
        Me.TableAdapterManager.UnitaDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.UnitaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Patrimonio2014.IMMOBILIDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        Me.TableAdapterManager.Z_ConsuntivoDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.Z_ConsuntivoTableAdapter = Nothing
        Me.TableAdapterManager.Z_TestoSollecitoTableAdapter = Nothing
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
        Me.AnagraficheBindingNavigator.Size = New System.Drawing.Size(626, 25)
        Me.AnagraficheBindingNavigator.TabIndex = 0
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
        'ImmobileComboBox
        '
        Me.ImmobileComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "Immobile", True))
        Me.ImmobileComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ImmobiliBindingSource, "Immobile", True))
        Me.ImmobileComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImmobileComboBox.FormattingEnabled = True
        Me.ImmobileComboBox.Location = New System.Drawing.Point(15, 65)
        Me.ImmobileComboBox.Name = "ImmobileComboBox"
        Me.ImmobileComboBox.Size = New System.Drawing.Size(340, 21)
        Me.ImmobileComboBox.TabIndex = 2
        '
        'ImmobiliBindingSource
        '
        Me.ImmobiliBindingSource.DataMember = "Immobili"
        Me.ImmobiliBindingSource.DataSource = Me.IMMOBILIDataSet2
        '
        'AnagraficaTextBox
        '
        Me.AnagraficaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "Anagrafica", True))
        Me.AnagraficaTextBox.Location = New System.Drawing.Point(373, 66)
        Me.AnagraficaTextBox.Name = "AnagraficaTextBox"
        Me.AnagraficaTextBox.Size = New System.Drawing.Size(58, 20)
        Me.AnagraficaTextBox.TabIndex = 4
        '
        'TitoloTextBox
        '
        Me.TitoloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "Titolo", True))
        Me.TitoloTextBox.Location = New System.Drawing.Point(15, 105)
        Me.TitoloTextBox.Name = "TitoloTextBox"
        Me.TitoloTextBox.Size = New System.Drawing.Size(82, 20)
        Me.TitoloTextBox.TabIndex = 6
        '
        'Nominativo1TextBox
        '
        Me.Nominativo1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "Nominativo1", True))
        Me.Nominativo1TextBox.Location = New System.Drawing.Point(116, 105)
        Me.Nominativo1TextBox.Name = "Nominativo1TextBox"
        Me.Nominativo1TextBox.Size = New System.Drawing.Size(315, 20)
        Me.Nominativo1TextBox.TabIndex = 8
        '
        'Nominativo2TextBox
        '
        Me.Nominativo2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "Nominativo2", True))
        Me.Nominativo2TextBox.Location = New System.Drawing.Point(116, 131)
        Me.Nominativo2TextBox.Name = "Nominativo2TextBox"
        Me.Nominativo2TextBox.Size = New System.Drawing.Size(315, 20)
        Me.Nominativo2TextBox.TabIndex = 10
        '
        'IndirizzoTextBox
        '
        Me.IndirizzoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "Indirizzo", True))
        Me.IndirizzoTextBox.Location = New System.Drawing.Point(116, 170)
        Me.IndirizzoTextBox.Name = "IndirizzoTextBox"
        Me.IndirizzoTextBox.Size = New System.Drawing.Size(315, 20)
        Me.IndirizzoTextBox.TabIndex = 11
        '
        'CapTextBox
        '
        Me.CapTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "Cap", True))
        Me.CapTextBox.Location = New System.Drawing.Point(15, 205)
        Me.CapTextBox.Name = "CapTextBox"
        Me.CapTextBox.Size = New System.Drawing.Size(62, 20)
        Me.CapTextBox.TabIndex = 13
        '
        'LocalitaTextBox
        '
        Me.LocalitaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "Localita", True))
        Me.LocalitaTextBox.Location = New System.Drawing.Point(116, 205)
        Me.LocalitaTextBox.Name = "LocalitaTextBox"
        Me.LocalitaTextBox.Size = New System.Drawing.Size(315, 20)
        Me.LocalitaTextBox.TabIndex = 15
        '
        'ProvinciaTextBox
        '
        Me.ProvinciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "Provincia", True))
        Me.ProvinciaTextBox.Location = New System.Drawing.Point(437, 205)
        Me.ProvinciaTextBox.Name = "ProvinciaTextBox"
        Me.ProvinciaTextBox.Size = New System.Drawing.Size(51, 20)
        Me.ProvinciaTextBox.TabIndex = 17
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "Telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(116, 260)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(315, 20)
        Me.TelefonoTextBox.TabIndex = 19
        '
        'NoteTextBox
        '
        Me.NoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "Note", True))
        Me.NoteTextBox.Location = New System.Drawing.Point(116, 299)
        Me.NoteTextBox.Name = "NoteTextBox"
        Me.NoteTextBox.Size = New System.Drawing.Size(315, 20)
        Me.NoteTextBox.TabIndex = 21
        '
        'SiglaLista1TextBox
        '
        Me.SiglaLista1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "SiglaLista1", True))
        Me.SiglaLista1TextBox.Location = New System.Drawing.Point(116, 351)
        Me.SiglaLista1TextBox.Name = "SiglaLista1TextBox"
        Me.SiglaLista1TextBox.Size = New System.Drawing.Size(47, 20)
        Me.SiglaLista1TextBox.TabIndex = 23
        '
        'SiglaLista2TextBox
        '
        Me.SiglaLista2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "SiglaLista2", True))
        Me.SiglaLista2TextBox.Location = New System.Drawing.Point(169, 351)
        Me.SiglaLista2TextBox.Name = "SiglaLista2TextBox"
        Me.SiglaLista2TextBox.Size = New System.Drawing.Size(47, 20)
        Me.SiglaLista2TextBox.TabIndex = 25
        '
        'SiglaRaccomandateTextBox
        '
        Me.SiglaRaccomandateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "SiglaRaccomandate", True))
        Me.SiglaRaccomandateTextBox.Location = New System.Drawing.Point(222, 351)
        Me.SiglaRaccomandateTextBox.Name = "SiglaRaccomandateTextBox"
        Me.SiglaRaccomandateTextBox.Size = New System.Drawing.Size(68, 20)
        Me.SiglaRaccomandateTextBox.TabIndex = 27
        '
        'AnagraficaCollegataTextBox
        '
        Me.AnagraficaCollegataTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "AnagraficaCollegata", True))
        Me.AnagraficaCollegataTextBox.Location = New System.Drawing.Point(315, 351)
        Me.AnagraficaCollegataTextBox.Name = "AnagraficaCollegataTextBox"
        Me.AnagraficaCollegataTextBox.Size = New System.Drawing.Size(77, 20)
        Me.AnagraficaCollegataTextBox.TabIndex = 29
        '
        'CodiceFiscaleTextBox
        '
        Me.CodiceFiscaleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "CodiceFiscale", True))
        Me.CodiceFiscaleTextBox.Location = New System.Drawing.Point(437, 351)
        Me.CodiceFiscaleTextBox.Name = "CodiceFiscaleTextBox"
        Me.CodiceFiscaleTextBox.Size = New System.Drawing.Size(152, 20)
        Me.CodiceFiscaleTextBox.TabIndex = 31
        '
        'LuogoNascitaTextBox
        '
        Me.LuogoNascitaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "LuogoNascita", True))
        Me.LuogoNascitaTextBox.Location = New System.Drawing.Point(116, 393)
        Me.LuogoNascitaTextBox.Name = "LuogoNascitaTextBox"
        Me.LuogoNascitaTextBox.Size = New System.Drawing.Size(220, 20)
        Me.LuogoNascitaTextBox.TabIndex = 33
        '
        'ProvinciaNascitaTextBox
        '
        Me.ProvinciaNascitaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficheBindingSource, "ProvinciaNascita", True))
        Me.ProvinciaNascitaTextBox.Location = New System.Drawing.Point(342, 393)
        Me.ProvinciaNascitaTextBox.Name = "ProvinciaNascitaTextBox"
        Me.ProvinciaNascitaTextBox.Size = New System.Drawing.Size(50, 20)
        Me.ProvinciaNascitaTextBox.TabIndex = 35
        '
        'DataNascitaDateTimePicker
        '
        Me.DataNascitaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AnagraficheBindingSource, "DataNascita", True))
        Me.DataNascitaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataNascitaDateTimePicker.Location = New System.Drawing.Point(437, 393)
        Me.DataNascitaDateTimePicker.Name = "DataNascitaDateTimePicker"
        Me.DataNascitaDateTimePicker.Size = New System.Drawing.Size(96, 20)
        Me.DataNascitaDateTimePicker.TabIndex = 37
        '
        'ImmobiliTableAdapter
        '
        Me.ImmobiliTableAdapter.ClearBeforeFill = True
        '
        'Anagrafiche
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 456)
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
        Me.Controls.Add(Me.AnagraficheBindingNavigator)
        Me.Name = "Anagrafiche"
        Me.Text = "Anagrafiche"
        CType(Me.IMMOBILIDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnagraficheBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnagraficheBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AnagraficheBindingNavigator.ResumeLayout(False)
        Me.AnagraficheBindingNavigator.PerformLayout()
        CType(Me.ImmobiliBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IMMOBILIDataSet2 As Patrimonio2014.IMMOBILIDataSet2
    Friend WithEvents AnagraficheBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AnagraficheTableAdapter As Patrimonio2014.IMMOBILIDataSet2TableAdapters.AnagraficheTableAdapter
    Friend WithEvents TableAdapterManager As Patrimonio2014.IMMOBILIDataSet2TableAdapters.TableAdapterManager
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
    Friend WithEvents ImmobiliBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ImmobiliTableAdapter As Patrimonio2014.IMMOBILIDataSet2TableAdapters.ImmobiliTableAdapter
End Class
