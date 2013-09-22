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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(X_MovimentiCondomini))
        Me.IMMOBILIDataSet2 = New Patrimonio2014.IMMOBILIDataSet2()
        Me.X_MovimentiCondominiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.X_MovimentiCondominiTableAdapter = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.X_MovimentiCondominiTableAdapter()
        Me.TableAdapterManager = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.TableAdapterManager()
        Me.X_MovimentiCondominiBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.X_MovimentiCondominiBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
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
        Me.RiferimentoContoFinanziarioTextBox = New System.Windows.Forms.TextBox()
        Me.RiferimentoContoAnticipiTextBox = New System.Windows.Forms.TextBox()
        Me.ContoTextBox = New System.Windows.Forms.TextBox()
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
        CType(Me.IMMOBILIDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X_MovimentiCondominiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X_MovimentiCondominiBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.X_MovimentiCondominiBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProgressivoLabel
        '
        ProgressivoLabel.AutoSize = True
        ProgressivoLabel.Location = New System.Drawing.Point(12, 40)
        ProgressivoLabel.Name = "ProgressivoLabel"
        ProgressivoLabel.Size = New System.Drawing.Size(65, 13)
        ProgressivoLabel.TabIndex = 1
        ProgressivoLabel.Text = "Progressivo:"
        '
        'ImmobileLabel
        '
        ImmobileLabel.AutoSize = True
        ImmobileLabel.Location = New System.Drawing.Point(93, 40)
        ImmobileLabel.Name = "ImmobileLabel"
        ImmobileLabel.Size = New System.Drawing.Size(51, 13)
        ImmobileLabel.TabIndex = 3
        ImmobileLabel.Text = "Immobile:"
        '
        'GestioneLabel
        '
        GestioneLabel.AutoSize = True
        GestioneLabel.Location = New System.Drawing.Point(342, 40)
        GestioneLabel.Name = "GestioneLabel"
        GestioneLabel.Size = New System.Drawing.Size(52, 13)
        GestioneLabel.TabIndex = 5
        GestioneLabel.Text = "Gestione:"
        '
        'AnagraficaLabel
        '
        AnagraficaLabel.AutoSize = True
        AnagraficaLabel.Location = New System.Drawing.Point(93, 79)
        AnagraficaLabel.Name = "AnagraficaLabel"
        AnagraficaLabel.Size = New System.Drawing.Size(61, 13)
        AnagraficaLabel.TabIndex = 7
        AnagraficaLabel.Text = "Anagrafica:"
        '
        'UnitaLabel
        '
        UnitaLabel.AutoSize = True
        UnitaLabel.Location = New System.Drawing.Point(345, 80)
        UnitaLabel.Name = "UnitaLabel"
        UnitaLabel.Size = New System.Drawing.Size(35, 13)
        UnitaLabel.TabIndex = 9
        UnitaLabel.Text = "Unita:"
        '
        'RataLabel
        '
        RataLabel.AutoSize = True
        RataLabel.Location = New System.Drawing.Point(12, 119)
        RataLabel.Name = "RataLabel"
        RataLabel.Size = New System.Drawing.Size(33, 13)
        RataLabel.TabIndex = 11
        RataLabel.Text = "Rata:"
        '
        'OperazioneLabel
        '
        OperazioneLabel.AutoSize = True
        OperazioneLabel.Location = New System.Drawing.Point(93, 119)
        OperazioneLabel.Name = "OperazioneLabel"
        OperazioneLabel.Size = New System.Drawing.Size(64, 13)
        OperazioneLabel.TabIndex = 13
        OperazioneLabel.Text = "Operazione:"
        '
        'DescrizioneLabel
        '
        DescrizioneLabel.AutoSize = True
        DescrizioneLabel.Location = New System.Drawing.Point(163, 119)
        DescrizioneLabel.Name = "DescrizioneLabel"
        DescrizioneLabel.Size = New System.Drawing.Size(65, 13)
        DescrizioneLabel.TabIndex = 15
        DescrizioneLabel.Text = "Descrizione:"
        '
        'DataOperazioneLabel
        '
        DataOperazioneLabel.AutoSize = True
        DataOperazioneLabel.Location = New System.Drawing.Point(442, 119)
        DataOperazioneLabel.Name = "DataOperazioneLabel"
        DataOperazioneLabel.Size = New System.Drawing.Size(90, 13)
        DataOperazioneLabel.TabIndex = 17
        DataOperazioneLabel.Text = "Data Operazione:"
        '
        'ImportoLabel
        '
        ImportoLabel.AutoSize = True
        ImportoLabel.Location = New System.Drawing.Point(538, 119)
        ImportoLabel.Name = "ImportoLabel"
        ImportoLabel.Size = New System.Drawing.Size(45, 13)
        ImportoLabel.TabIndex = 19
        ImportoLabel.Text = "Importo:"
        '
        'DataRiferimentoLabel
        '
        DataRiferimentoLabel.AutoSize = True
        DataRiferimentoLabel.Location = New System.Drawing.Point(643, 119)
        DataRiferimentoLabel.Name = "DataRiferimentoLabel"
        DataRiferimentoLabel.Size = New System.Drawing.Size(89, 13)
        DataRiferimentoLabel.TabIndex = 21
        DataRiferimentoLabel.Text = "Data Riferimento:"
        '
        'RiferimentoContoFinanziarioLabel
        '
        RiferimentoContoFinanziarioLabel.AutoSize = True
        RiferimentoContoFinanziarioLabel.Location = New System.Drawing.Point(93, 158)
        RiferimentoContoFinanziarioLabel.Name = "RiferimentoContoFinanziarioLabel"
        RiferimentoContoFinanziarioLabel.Size = New System.Drawing.Size(57, 13)
        RiferimentoContoFinanziarioLabel.TabIndex = 23
        RiferimentoContoFinanziarioLabel.Text = "Rif. Conto:"
        '
        'RiferimentoContoAnticipiLabel
        '
        RiferimentoContoAnticipiLabel.AutoSize = True
        RiferimentoContoAnticipiLabel.Location = New System.Drawing.Point(163, 158)
        RiferimentoContoAnticipiLabel.Name = "RiferimentoContoAnticipiLabel"
        RiferimentoContoAnticipiLabel.Size = New System.Drawing.Size(63, 13)
        RiferimentoContoAnticipiLabel.TabIndex = 25
        RiferimentoContoAnticipiLabel.Text = "Rif. Anticipi:"
        '
        'ContoLabel
        '
        ContoLabel.AutoSize = True
        ContoLabel.Location = New System.Drawing.Point(232, 158)
        ContoLabel.Name = "ContoLabel"
        ContoLabel.Size = New System.Drawing.Size(38, 13)
        ContoLabel.TabIndex = 27
        ContoLabel.Text = "Conto:"
        '
        'IMMOBILIDataSet2
        '
        Me.IMMOBILIDataSet2.DataSetName = "IMMOBILIDataSet2"
        Me.IMMOBILIDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'X_MovimentiCondominiBindingSource
        '
        Me.X_MovimentiCondominiBindingSource.DataMember = "X_MovimentiCondomini"
        Me.X_MovimentiCondominiBindingSource.DataSource = Me.IMMOBILIDataSet2
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
        Me.TableAdapterManager.X_MovimentiCondominiTableAdapter = Me.X_MovimentiCondominiTableAdapter
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
        'X_MovimentiCondominiBindingNavigator
        '
        Me.X_MovimentiCondominiBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.X_MovimentiCondominiBindingNavigator.BindingSource = Me.X_MovimentiCondominiBindingSource
        Me.X_MovimentiCondominiBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.X_MovimentiCondominiBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.X_MovimentiCondominiBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.X_MovimentiCondominiBindingNavigatorSaveItem})
        Me.X_MovimentiCondominiBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.X_MovimentiCondominiBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.X_MovimentiCondominiBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.X_MovimentiCondominiBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.X_MovimentiCondominiBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.X_MovimentiCondominiBindingNavigator.Name = "X_MovimentiCondominiBindingNavigator"
        Me.X_MovimentiCondominiBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.X_MovimentiCondominiBindingNavigator.Size = New System.Drawing.Size(752, 25)
        Me.X_MovimentiCondominiBindingNavigator.TabIndex = 0
        Me.X_MovimentiCondominiBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
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
        'X_MovimentiCondominiBindingNavigatorSaveItem
        '
        Me.X_MovimentiCondominiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.X_MovimentiCondominiBindingNavigatorSaveItem.Image = CType(resources.GetObject("X_MovimentiCondominiBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.X_MovimentiCondominiBindingNavigatorSaveItem.Name = "X_MovimentiCondominiBindingNavigatorSaveItem"
        Me.X_MovimentiCondominiBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.X_MovimentiCondominiBindingNavigatorSaveItem.Text = "Salva dati"
        '
        'ProgressivoTextBox
        '
        Me.ProgressivoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_MovimentiCondominiBindingSource, "Progressivo", True))
        Me.ProgressivoTextBox.Location = New System.Drawing.Point(15, 56)
        Me.ProgressivoTextBox.Name = "ProgressivoTextBox"
        Me.ProgressivoTextBox.Size = New System.Drawing.Size(72, 20)
        Me.ProgressivoTextBox.TabIndex = 2
        '
        'ImmobileComboBox
        '
        Me.ImmobileComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_MovimentiCondominiBindingSource, "Immobile", True))
        Me.ImmobileComboBox.FormattingEnabled = True
        Me.ImmobileComboBox.Location = New System.Drawing.Point(96, 55)
        Me.ImmobileComboBox.Name = "ImmobileComboBox"
        Me.ImmobileComboBox.Size = New System.Drawing.Size(243, 21)
        Me.ImmobileComboBox.TabIndex = 4
        '
        'GestioneComboBox
        '
        Me.GestioneComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_MovimentiCondominiBindingSource, "Gestione", True))
        Me.GestioneComboBox.FormattingEnabled = True
        Me.GestioneComboBox.Location = New System.Drawing.Point(345, 56)
        Me.GestioneComboBox.Name = "GestioneComboBox"
        Me.GestioneComboBox.Size = New System.Drawing.Size(239, 21)
        Me.GestioneComboBox.TabIndex = 6
        '
        'AnagraficaComboBox
        '
        Me.AnagraficaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_MovimentiCondominiBindingSource, "Anagrafica", True))
        Me.AnagraficaComboBox.FormattingEnabled = True
        Me.AnagraficaComboBox.Location = New System.Drawing.Point(96, 95)
        Me.AnagraficaComboBox.Name = "AnagraficaComboBox"
        Me.AnagraficaComboBox.Size = New System.Drawing.Size(243, 21)
        Me.AnagraficaComboBox.TabIndex = 8
        '
        'UnitaComboBox
        '
        Me.UnitaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_MovimentiCondominiBindingSource, "Unita", True))
        Me.UnitaComboBox.FormattingEnabled = True
        Me.UnitaComboBox.Location = New System.Drawing.Point(345, 95)
        Me.UnitaComboBox.Name = "UnitaComboBox"
        Me.UnitaComboBox.Size = New System.Drawing.Size(239, 21)
        Me.UnitaComboBox.TabIndex = 10
        '
        'RataTextBox
        '
        Me.RataTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_MovimentiCondominiBindingSource, "Rata", True))
        Me.RataTextBox.Location = New System.Drawing.Point(15, 135)
        Me.RataTextBox.Name = "RataTextBox"
        Me.RataTextBox.Size = New System.Drawing.Size(51, 20)
        Me.RataTextBox.TabIndex = 12
        '
        'OperazioneTextBox
        '
        Me.OperazioneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_MovimentiCondominiBindingSource, "Operazione", True))
        Me.OperazioneTextBox.Location = New System.Drawing.Point(96, 135)
        Me.OperazioneTextBox.Name = "OperazioneTextBox"
        Me.OperazioneTextBox.Size = New System.Drawing.Size(61, 20)
        Me.OperazioneTextBox.TabIndex = 14
        '
        'DescrizioneTextBox
        '
        Me.DescrizioneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_MovimentiCondominiBindingSource, "Descrizione", True))
        Me.DescrizioneTextBox.Location = New System.Drawing.Point(166, 135)
        Me.DescrizioneTextBox.Name = "DescrizioneTextBox"
        Me.DescrizioneTextBox.Size = New System.Drawing.Size(270, 20)
        Me.DescrizioneTextBox.TabIndex = 16
        '
        'DataOperazioneDateTimePicker
        '
        Me.DataOperazioneDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.X_MovimentiCondominiBindingSource, "DataOperazione", True))
        Me.DataOperazioneDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataOperazioneDateTimePicker.Location = New System.Drawing.Point(445, 135)
        Me.DataOperazioneDateTimePicker.Name = "DataOperazioneDateTimePicker"
        Me.DataOperazioneDateTimePicker.Size = New System.Drawing.Size(86, 20)
        Me.DataOperazioneDateTimePicker.TabIndex = 18
        '
        'ImportoTextBox
        '
        Me.ImportoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_MovimentiCondominiBindingSource, "Importo", True))
        Me.ImportoTextBox.Location = New System.Drawing.Point(537, 135)
        Me.ImportoTextBox.Name = "ImportoTextBox"
        Me.ImportoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ImportoTextBox.TabIndex = 20
        '
        'DataRiferimentoDateTimePicker
        '
        Me.DataRiferimentoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.X_MovimentiCondominiBindingSource, "DataRiferimento", True))
        Me.DataRiferimentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataRiferimentoDateTimePicker.Location = New System.Drawing.Point(643, 135)
        Me.DataRiferimentoDateTimePicker.Name = "DataRiferimentoDateTimePicker"
        Me.DataRiferimentoDateTimePicker.Size = New System.Drawing.Size(89, 20)
        Me.DataRiferimentoDateTimePicker.TabIndex = 22
        '
        'RiferimentoContoFinanziarioTextBox
        '
        Me.RiferimentoContoFinanziarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_MovimentiCondominiBindingSource, "RiferimentoContoFinanziario", True))
        Me.RiferimentoContoFinanziarioTextBox.Location = New System.Drawing.Point(96, 174)
        Me.RiferimentoContoFinanziarioTextBox.Name = "RiferimentoContoFinanziarioTextBox"
        Me.RiferimentoContoFinanziarioTextBox.Size = New System.Drawing.Size(61, 20)
        Me.RiferimentoContoFinanziarioTextBox.TabIndex = 24
        '
        'RiferimentoContoAnticipiTextBox
        '
        Me.RiferimentoContoAnticipiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_MovimentiCondominiBindingSource, "RiferimentoContoAnticipi", True))
        Me.RiferimentoContoAnticipiTextBox.Location = New System.Drawing.Point(166, 174)
        Me.RiferimentoContoAnticipiTextBox.Name = "RiferimentoContoAnticipiTextBox"
        Me.RiferimentoContoAnticipiTextBox.Size = New System.Drawing.Size(62, 20)
        Me.RiferimentoContoAnticipiTextBox.TabIndex = 26
        '
        'ContoTextBox
        '
        Me.ContoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_MovimentiCondominiBindingSource, "Conto", True))
        Me.ContoTextBox.Location = New System.Drawing.Point(234, 174)
        Me.ContoTextBox.Name = "ContoTextBox"
        Me.ContoTextBox.Size = New System.Drawing.Size(63, 20)
        Me.ContoTextBox.TabIndex = 28
        '
        'X_MovimentiCondomini
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 273)
        Me.Controls.Add(ContoLabel)
        Me.Controls.Add(Me.ContoTextBox)
        Me.Controls.Add(RiferimentoContoAnticipiLabel)
        Me.Controls.Add(Me.RiferimentoContoAnticipiTextBox)
        Me.Controls.Add(RiferimentoContoFinanziarioLabel)
        Me.Controls.Add(Me.RiferimentoContoFinanziarioTextBox)
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
        Me.Controls.Add(Me.X_MovimentiCondominiBindingNavigator)
        Me.Name = "X_MovimentiCondomini"
        Me.Text = "Movimenti Contabili dei Condomini"
        CType(Me.IMMOBILIDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X_MovimentiCondominiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X_MovimentiCondominiBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.X_MovimentiCondominiBindingNavigator.ResumeLayout(False)
        Me.X_MovimentiCondominiBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IMMOBILIDataSet2 As Patrimonio2014.IMMOBILIDataSet2
    Friend WithEvents X_MovimentiCondominiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents X_MovimentiCondominiTableAdapter As Patrimonio2014.IMMOBILIDataSet2TableAdapters.X_MovimentiCondominiTableAdapter
    Friend WithEvents TableAdapterManager As Patrimonio2014.IMMOBILIDataSet2TableAdapters.TableAdapterManager
    Friend WithEvents X_MovimentiCondominiBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents X_MovimentiCondominiBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
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
    Friend WithEvents RiferimentoContoFinanziarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RiferimentoContoAnticipiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContoTextBox As System.Windows.Forms.TextBox
End Class
