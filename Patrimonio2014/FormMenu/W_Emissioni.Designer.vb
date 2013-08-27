<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class W_Emissioni
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(W_Emissioni))
        Dim ImmobileLabel As System.Windows.Forms.Label
        Dim ProgressivoLabel As System.Windows.Forms.Label
        Dim AnagraficaLabel As System.Windows.Forms.Label
        Dim GestioneLabel As System.Windows.Forms.Label
        Dim NumeroRataLabel As System.Windows.Forms.Label
        Dim DataScadenzaLabel As System.Windows.Forms.Label
        Dim ImportoRataLabel As System.Windows.Forms.Label
        Dim SpeseAvvisoLabel As System.Windows.Forms.Label
        Dim ContoLabel As System.Windows.Forms.Label
        Dim DataPagamentoLabel As System.Windows.Forms.Label
        Dim SpeseStornoLabel As System.Windows.Forms.Label
        Dim SaldoEsercizioPrecedenteLabel As System.Windows.Forms.Label
        Dim RataPreventivoLabel As System.Windows.Forms.Label
        Dim RateAddebitateLabel As System.Windows.Forms.Label
        Dim VersamentiLabel As System.Windows.Forms.Label
        Dim FondoLabel As System.Windows.Forms.Label
        Me.IMMOBILIDataSet2 = New Patrimonio2014.IMMOBILIDataSet2()
        Me.W_EmissioniBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.W_EmissioniTableAdapter = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.W_EmissioniTableAdapter()
        Me.TableAdapterManager = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.TableAdapterManager()
        Me.W_EmissioniBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.W_EmissioniBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ImmobileComboBox = New System.Windows.Forms.ComboBox()
        Me.ProgressivoTextBox = New System.Windows.Forms.TextBox()
        Me.AnagraficaComboBox = New System.Windows.Forms.ComboBox()
        Me.GestioneComboBox = New System.Windows.Forms.ComboBox()
        Me.NumeroRataTextBox = New System.Windows.Forms.TextBox()
        Me.DataScadenzaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ImportoRataTextBox = New System.Windows.Forms.TextBox()
        Me.SpeseAvvisoTextBox = New System.Windows.Forms.TextBox()
        Me.ContoComboBox = New System.Windows.Forms.ComboBox()
        Me.DataPagamentoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SpeseStornoTextBox = New System.Windows.Forms.TextBox()
        Me.SaldoEsercizioPrecedenteTextBox = New System.Windows.Forms.TextBox()
        Me.RataPreventivoTextBox = New System.Windows.Forms.TextBox()
        Me.RateAddebitateTextBox = New System.Windows.Forms.TextBox()
        Me.VersamentiTextBox = New System.Windows.Forms.TextBox()
        Me.FondoTextBox = New System.Windows.Forms.TextBox()
        Me.W_EmissioniDettaglioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.W_EmissioniDettaglioTableAdapter = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.W_EmissioniDettaglioTableAdapter()
        Me.W_EmissioniDettaglioDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        ImmobileLabel = New System.Windows.Forms.Label()
        ProgressivoLabel = New System.Windows.Forms.Label()
        AnagraficaLabel = New System.Windows.Forms.Label()
        GestioneLabel = New System.Windows.Forms.Label()
        NumeroRataLabel = New System.Windows.Forms.Label()
        DataScadenzaLabel = New System.Windows.Forms.Label()
        ImportoRataLabel = New System.Windows.Forms.Label()
        SpeseAvvisoLabel = New System.Windows.Forms.Label()
        ContoLabel = New System.Windows.Forms.Label()
        DataPagamentoLabel = New System.Windows.Forms.Label()
        SpeseStornoLabel = New System.Windows.Forms.Label()
        SaldoEsercizioPrecedenteLabel = New System.Windows.Forms.Label()
        RataPreventivoLabel = New System.Windows.Forms.Label()
        RateAddebitateLabel = New System.Windows.Forms.Label()
        VersamentiLabel = New System.Windows.Forms.Label()
        FondoLabel = New System.Windows.Forms.Label()
        CType(Me.IMMOBILIDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.W_EmissioniBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.W_EmissioniBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.W_EmissioniBindingNavigator.SuspendLayout()
        CType(Me.W_EmissioniDettaglioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.W_EmissioniDettaglioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IMMOBILIDataSet2
        '
        Me.IMMOBILIDataSet2.DataSetName = "IMMOBILIDataSet2"
        Me.IMMOBILIDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'W_EmissioniBindingSource
        '
        Me.W_EmissioniBindingSource.DataMember = "W_Emissioni"
        Me.W_EmissioniBindingSource.DataSource = Me.IMMOBILIDataSet2
        '
        'W_EmissioniTableAdapter
        '
        Me.W_EmissioniTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.CostantiDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.CostantiTableAdapter = Nothing
        Me.TableAdapterManager.FabbricatiDettaglio1TableAdapter = Nothing
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
        Me.TableAdapterManager.W_EmissioniDettaglioTableAdapter = Me.W_EmissioniDettaglioTableAdapter
        Me.TableAdapterManager.W_EmissioniTableAdapter = Me.W_EmissioniTableAdapter
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
        'W_EmissioniBindingNavigator
        '
        Me.W_EmissioniBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.W_EmissioniBindingNavigator.BindingSource = Me.W_EmissioniBindingSource
        Me.W_EmissioniBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.W_EmissioniBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.W_EmissioniBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.W_EmissioniBindingNavigatorSaveItem})
        Me.W_EmissioniBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.W_EmissioniBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.W_EmissioniBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.W_EmissioniBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.W_EmissioniBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.W_EmissioniBindingNavigator.Name = "W_EmissioniBindingNavigator"
        Me.W_EmissioniBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.W_EmissioniBindingNavigator.Size = New System.Drawing.Size(896, 25)
        Me.W_EmissioniBindingNavigator.TabIndex = 0
        Me.W_EmissioniBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(34, 13)
        Me.BindingNavigatorCountItem.Text = "di {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Numero totale di elementi"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Sposta avanti"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Sposta in ultima posizione"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Elimina"
        '
        'W_EmissioniBindingNavigatorSaveItem
        '
        Me.W_EmissioniBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.W_EmissioniBindingNavigatorSaveItem.Image = CType(resources.GetObject("W_EmissioniBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.W_EmissioniBindingNavigatorSaveItem.Name = "W_EmissioniBindingNavigatorSaveItem"
        Me.W_EmissioniBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.W_EmissioniBindingNavigatorSaveItem.Text = "Salva dati"
        '
        'ImmobileLabel
        '
        ImmobileLabel.AutoSize = True
        ImmobileLabel.Location = New System.Drawing.Point(12, 37)
        ImmobileLabel.Name = "ImmobileLabel"
        ImmobileLabel.Size = New System.Drawing.Size(51, 13)
        ImmobileLabel.TabIndex = 1
        ImmobileLabel.Text = "Immobile:"
        '
        'ImmobileComboBox
        '
        Me.ImmobileComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_EmissioniBindingSource, "Immobile", True))
        Me.ImmobileComboBox.FormattingEnabled = True
        Me.ImmobileComboBox.Location = New System.Drawing.Point(15, 53)
        Me.ImmobileComboBox.Name = "ImmobileComboBox"
        Me.ImmobileComboBox.Size = New System.Drawing.Size(251, 21)
        Me.ImmobileComboBox.TabIndex = 2
        '
        'ProgressivoLabel
        '
        ProgressivoLabel.AutoSize = True
        ProgressivoLabel.Location = New System.Drawing.Point(272, 37)
        ProgressivoLabel.Name = "ProgressivoLabel"
        ProgressivoLabel.Size = New System.Drawing.Size(65, 13)
        ProgressivoLabel.TabIndex = 3
        ProgressivoLabel.Text = "Progressivo:"
        '
        'ProgressivoTextBox
        '
        Me.ProgressivoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_EmissioniBindingSource, "Progressivo", True))
        Me.ProgressivoTextBox.Location = New System.Drawing.Point(275, 54)
        Me.ProgressivoTextBox.Name = "ProgressivoTextBox"
        Me.ProgressivoTextBox.Size = New System.Drawing.Size(77, 20)
        Me.ProgressivoTextBox.TabIndex = 4
        '
        'AnagraficaLabel
        '
        AnagraficaLabel.AutoSize = True
        AnagraficaLabel.Location = New System.Drawing.Point(12, 77)
        AnagraficaLabel.Name = "AnagraficaLabel"
        AnagraficaLabel.Size = New System.Drawing.Size(61, 13)
        AnagraficaLabel.TabIndex = 5
        AnagraficaLabel.Text = "Anagrafica:"
        '
        'AnagraficaComboBox
        '
        Me.AnagraficaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_EmissioniBindingSource, "Anagrafica", True))
        Me.AnagraficaComboBox.FormattingEnabled = True
        Me.AnagraficaComboBox.Location = New System.Drawing.Point(15, 93)
        Me.AnagraficaComboBox.Name = "AnagraficaComboBox"
        Me.AnagraficaComboBox.Size = New System.Drawing.Size(251, 21)
        Me.AnagraficaComboBox.TabIndex = 6
        '
        'GestioneLabel
        '
        GestioneLabel.AutoSize = True
        GestioneLabel.Location = New System.Drawing.Point(272, 77)
        GestioneLabel.Name = "GestioneLabel"
        GestioneLabel.Size = New System.Drawing.Size(52, 13)
        GestioneLabel.TabIndex = 7
        GestioneLabel.Text = "Gestione:"
        '
        'GestioneComboBox
        '
        Me.GestioneComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_EmissioniBindingSource, "Gestione", True))
        Me.GestioneComboBox.FormattingEnabled = True
        Me.GestioneComboBox.Location = New System.Drawing.Point(275, 93)
        Me.GestioneComboBox.Name = "GestioneComboBox"
        Me.GestioneComboBox.Size = New System.Drawing.Size(241, 21)
        Me.GestioneComboBox.TabIndex = 8
        '
        'NumeroRataLabel
        '
        NumeroRataLabel.AutoSize = True
        NumeroRataLabel.Location = New System.Drawing.Point(520, 77)
        NumeroRataLabel.Name = "NumeroRataLabel"
        NumeroRataLabel.Size = New System.Drawing.Size(47, 13)
        NumeroRataLabel.TabIndex = 9
        NumeroRataLabel.Text = "N. Rata:"
        '
        'NumeroRataTextBox
        '
        Me.NumeroRataTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_EmissioniBindingSource, "NumeroRata", True))
        Me.NumeroRataTextBox.Location = New System.Drawing.Point(522, 93)
        Me.NumeroRataTextBox.Name = "NumeroRataTextBox"
        Me.NumeroRataTextBox.Size = New System.Drawing.Size(45, 20)
        Me.NumeroRataTextBox.TabIndex = 10
        '
        'DataScadenzaLabel
        '
        DataScadenzaLabel.AutoSize = True
        DataScadenzaLabel.Location = New System.Drawing.Point(573, 77)
        DataScadenzaLabel.Name = "DataScadenzaLabel"
        DataScadenzaLabel.Size = New System.Drawing.Size(84, 13)
        DataScadenzaLabel.TabIndex = 11
        DataScadenzaLabel.Text = "Data Scadenza:"
        '
        'DataScadenzaDateTimePicker
        '
        Me.DataScadenzaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.W_EmissioniBindingSource, "DataScadenza", True))
        Me.DataScadenzaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataScadenzaDateTimePicker.Location = New System.Drawing.Point(576, 94)
        Me.DataScadenzaDateTimePicker.Name = "DataScadenzaDateTimePicker"
        Me.DataScadenzaDateTimePicker.Size = New System.Drawing.Size(92, 20)
        Me.DataScadenzaDateTimePicker.TabIndex = 12
        '
        'ImportoRataLabel
        '
        ImportoRataLabel.AutoSize = True
        ImportoRataLabel.Location = New System.Drawing.Point(674, 77)
        ImportoRataLabel.Name = "ImportoRataLabel"
        ImportoRataLabel.Size = New System.Drawing.Size(71, 13)
        ImportoRataLabel.TabIndex = 13
        ImportoRataLabel.Text = "Importo Rata:"
        '
        'ImportoRataTextBox
        '
        Me.ImportoRataTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_EmissioniBindingSource, "ImportoRata", True))
        Me.ImportoRataTextBox.Location = New System.Drawing.Point(677, 94)
        Me.ImportoRataTextBox.Name = "ImportoRataTextBox"
        Me.ImportoRataTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ImportoRataTextBox.TabIndex = 14
        '
        'SpeseAvvisoLabel
        '
        SpeseAvvisoLabel.AutoSize = True
        SpeseAvvisoLabel.Location = New System.Drawing.Point(678, 117)
        SpeseAvvisoLabel.Name = "SpeseAvvisoLabel"
        SpeseAvvisoLabel.Size = New System.Drawing.Size(75, 13)
        SpeseAvvisoLabel.TabIndex = 15
        SpeseAvvisoLabel.Text = "Spese Avviso:"
        '
        'SpeseAvvisoTextBox
        '
        Me.SpeseAvvisoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_EmissioniBindingSource, "SpeseAvviso", True))
        Me.SpeseAvvisoTextBox.Location = New System.Drawing.Point(677, 133)
        Me.SpeseAvvisoTextBox.Name = "SpeseAvvisoTextBox"
        Me.SpeseAvvisoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SpeseAvvisoTextBox.TabIndex = 16
        '
        'ContoLabel
        '
        ContoLabel.AutoSize = True
        ContoLabel.Location = New System.Drawing.Point(17, 117)
        ContoLabel.Name = "ContoLabel"
        ContoLabel.Size = New System.Drawing.Size(38, 13)
        ContoLabel.TabIndex = 17
        ContoLabel.Text = "Conto:"
        '
        'ContoComboBox
        '
        Me.ContoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_EmissioniBindingSource, "Conto", True))
        Me.ContoComboBox.FormattingEnabled = True
        Me.ContoComboBox.Location = New System.Drawing.Point(15, 133)
        Me.ContoComboBox.Name = "ContoComboBox"
        Me.ContoComboBox.Size = New System.Drawing.Size(251, 21)
        Me.ContoComboBox.TabIndex = 18
        '
        'DataPagamentoLabel
        '
        DataPagamentoLabel.AutoSize = True
        DataPagamentoLabel.Location = New System.Drawing.Point(272, 117)
        DataPagamentoLabel.Name = "DataPagamentoLabel"
        DataPagamentoLabel.Size = New System.Drawing.Size(90, 13)
        DataPagamentoLabel.TabIndex = 19
        DataPagamentoLabel.Text = "Data Pagamento:"
        '
        'DataPagamentoDateTimePicker
        '
        Me.DataPagamentoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.W_EmissioniBindingSource, "DataPagamento", True))
        Me.DataPagamentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataPagamentoDateTimePicker.Location = New System.Drawing.Point(275, 134)
        Me.DataPagamentoDateTimePicker.Name = "DataPagamentoDateTimePicker"
        Me.DataPagamentoDateTimePicker.Size = New System.Drawing.Size(87, 20)
        Me.DataPagamentoDateTimePicker.TabIndex = 20
        '
        'SpeseStornoLabel
        '
        SpeseStornoLabel.AutoSize = True
        SpeseStornoLabel.Location = New System.Drawing.Point(678, 156)
        SpeseStornoLabel.Name = "SpeseStornoLabel"
        SpeseStornoLabel.Size = New System.Drawing.Size(74, 13)
        SpeseStornoLabel.TabIndex = 21
        SpeseStornoLabel.Text = "Spese Storno:"
        '
        'SpeseStornoTextBox
        '
        Me.SpeseStornoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_EmissioniBindingSource, "SpeseStorno", True))
        Me.SpeseStornoTextBox.Location = New System.Drawing.Point(677, 172)
        Me.SpeseStornoTextBox.Name = "SpeseStornoTextBox"
        Me.SpeseStornoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SpeseStornoTextBox.TabIndex = 22
        '
        'SaldoEsercizioPrecedenteLabel
        '
        SaldoEsercizioPrecedenteLabel.AutoSize = True
        SaldoEsercizioPrecedenteLabel.Location = New System.Drawing.Point(678, 201)
        SaldoEsercizioPrecedenteLabel.Name = "SaldoEsercizioPrecedenteLabel"
        SaldoEsercizioPrecedenteLabel.Size = New System.Drawing.Size(95, 13)
        SaldoEsercizioPrecedenteLabel.TabIndex = 23
        SaldoEsercizioPrecedenteLabel.Text = "Saldo Precedente:"
        '
        'SaldoEsercizioPrecedenteTextBox
        '
        Me.SaldoEsercizioPrecedenteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_EmissioniBindingSource, "SaldoEsercizioPrecedente", True))
        Me.SaldoEsercizioPrecedenteTextBox.Location = New System.Drawing.Point(677, 217)
        Me.SaldoEsercizioPrecedenteTextBox.Name = "SaldoEsercizioPrecedenteTextBox"
        Me.SaldoEsercizioPrecedenteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SaldoEsercizioPrecedenteTextBox.TabIndex = 24
        '
        'RataPreventivoLabel
        '
        RataPreventivoLabel.AutoSize = True
        RataPreventivoLabel.Location = New System.Drawing.Point(678, 240)
        RataPreventivoLabel.Name = "RataPreventivoLabel"
        RataPreventivoLabel.Size = New System.Drawing.Size(87, 13)
        RataPreventivoLabel.TabIndex = 25
        RataPreventivoLabel.Text = "Rata Preventivo:"
        '
        'RataPreventivoTextBox
        '
        Me.RataPreventivoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_EmissioniBindingSource, "RataPreventivo", True))
        Me.RataPreventivoTextBox.Location = New System.Drawing.Point(677, 256)
        Me.RataPreventivoTextBox.Name = "RataPreventivoTextBox"
        Me.RataPreventivoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RataPreventivoTextBox.TabIndex = 26
        '
        'RateAddebitateLabel
        '
        RateAddebitateLabel.AutoSize = True
        RateAddebitateLabel.Location = New System.Drawing.Point(678, 279)
        RateAddebitateLabel.Name = "RateAddebitateLabel"
        RateAddebitateLabel.Size = New System.Drawing.Size(87, 13)
        RateAddebitateLabel.TabIndex = 27
        RateAddebitateLabel.Text = "Rate Addebitate:"
        '
        'RateAddebitateTextBox
        '
        Me.RateAddebitateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_EmissioniBindingSource, "RateAddebitate", True))
        Me.RateAddebitateTextBox.Location = New System.Drawing.Point(677, 295)
        Me.RateAddebitateTextBox.Name = "RateAddebitateTextBox"
        Me.RateAddebitateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RateAddebitateTextBox.TabIndex = 28
        '
        'VersamentiLabel
        '
        VersamentiLabel.AutoSize = True
        VersamentiLabel.Location = New System.Drawing.Point(674, 318)
        VersamentiLabel.Name = "VersamentiLabel"
        VersamentiLabel.Size = New System.Drawing.Size(62, 13)
        VersamentiLabel.TabIndex = 29
        VersamentiLabel.Text = "Versamenti:"
        '
        'VersamentiTextBox
        '
        Me.VersamentiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_EmissioniBindingSource, "Versamenti", True))
        Me.VersamentiTextBox.Location = New System.Drawing.Point(677, 334)
        Me.VersamentiTextBox.Name = "VersamentiTextBox"
        Me.VersamentiTextBox.Size = New System.Drawing.Size(100, 20)
        Me.VersamentiTextBox.TabIndex = 30
        '
        'FondoLabel
        '
        FondoLabel.AutoSize = True
        FondoLabel.Location = New System.Drawing.Point(678, 357)
        FondoLabel.Name = "FondoLabel"
        FondoLabel.Size = New System.Drawing.Size(40, 13)
        FondoLabel.TabIndex = 31
        FondoLabel.Text = "Fondo:"
        '
        'FondoTextBox
        '
        Me.FondoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_EmissioniBindingSource, "Fondo", True))
        Me.FondoTextBox.Location = New System.Drawing.Point(677, 373)
        Me.FondoTextBox.Name = "FondoTextBox"
        Me.FondoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FondoTextBox.TabIndex = 32
        '
        'W_EmissioniDettaglioBindingSource
        '
        Me.W_EmissioniDettaglioBindingSource.DataMember = "W_EmissioniDettaglio"
        Me.W_EmissioniDettaglioBindingSource.DataSource = Me.IMMOBILIDataSet2
        '
        'W_EmissioniDettaglioTableAdapter
        '
        Me.W_EmissioniDettaglioTableAdapter.ClearBeforeFill = True
        '
        'W_EmissioniDettaglioDataGridView
        '
        Me.W_EmissioniDettaglioDataGridView.AutoGenerateColumns = False
        Me.W_EmissioniDettaglioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.W_EmissioniDettaglioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.W_EmissioniDettaglioDataGridView.DataSource = Me.W_EmissioniDettaglioBindingSource
        Me.W_EmissioniDettaglioDataGridView.Location = New System.Drawing.Point(15, 173)
        Me.W_EmissioniDettaglioDataGridView.Name = "W_EmissioniDettaglioDataGridView"
        Me.W_EmissioniDettaglioDataGridView.Size = New System.Drawing.Size(608, 220)
        Me.W_EmissioniDettaglioDataGridView.TabIndex = 33
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Riga"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Riga"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Unita"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Unita"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "SaldoEsercizioPrecedente"
        Me.DataGridViewTextBoxColumn5.HeaderText = "SaldoEsercizioPrecedente"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "RataPreventivo"
        Me.DataGridViewTextBoxColumn6.HeaderText = "RataPreventivo"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Importo"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Importo"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'W_Emissioni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 428)
        Me.Controls.Add(Me.W_EmissioniDettaglioDataGridView)
        Me.Controls.Add(FondoLabel)
        Me.Controls.Add(Me.FondoTextBox)
        Me.Controls.Add(VersamentiLabel)
        Me.Controls.Add(Me.VersamentiTextBox)
        Me.Controls.Add(RateAddebitateLabel)
        Me.Controls.Add(Me.RateAddebitateTextBox)
        Me.Controls.Add(RataPreventivoLabel)
        Me.Controls.Add(Me.RataPreventivoTextBox)
        Me.Controls.Add(SaldoEsercizioPrecedenteLabel)
        Me.Controls.Add(Me.SaldoEsercizioPrecedenteTextBox)
        Me.Controls.Add(SpeseStornoLabel)
        Me.Controls.Add(Me.SpeseStornoTextBox)
        Me.Controls.Add(DataPagamentoLabel)
        Me.Controls.Add(Me.DataPagamentoDateTimePicker)
        Me.Controls.Add(ContoLabel)
        Me.Controls.Add(Me.ContoComboBox)
        Me.Controls.Add(SpeseAvvisoLabel)
        Me.Controls.Add(Me.SpeseAvvisoTextBox)
        Me.Controls.Add(ImportoRataLabel)
        Me.Controls.Add(Me.ImportoRataTextBox)
        Me.Controls.Add(DataScadenzaLabel)
        Me.Controls.Add(Me.DataScadenzaDateTimePicker)
        Me.Controls.Add(NumeroRataLabel)
        Me.Controls.Add(Me.NumeroRataTextBox)
        Me.Controls.Add(GestioneLabel)
        Me.Controls.Add(Me.GestioneComboBox)
        Me.Controls.Add(AnagraficaLabel)
        Me.Controls.Add(Me.AnagraficaComboBox)
        Me.Controls.Add(ProgressivoLabel)
        Me.Controls.Add(Me.ProgressivoTextBox)
        Me.Controls.Add(ImmobileLabel)
        Me.Controls.Add(Me.ImmobileComboBox)
        Me.Controls.Add(Me.W_EmissioniBindingNavigator)
        Me.Name = "W_Emissioni"
        Me.Text = "Archivio Avvisi"
        CType(Me.IMMOBILIDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.W_EmissioniBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.W_EmissioniBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.W_EmissioniBindingNavigator.ResumeLayout(False)
        Me.W_EmissioniBindingNavigator.PerformLayout()
        CType(Me.W_EmissioniDettaglioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.W_EmissioniDettaglioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IMMOBILIDataSet2 As Patrimonio2014.IMMOBILIDataSet2
    Friend WithEvents W_EmissioniBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents W_EmissioniTableAdapter As Patrimonio2014.IMMOBILIDataSet2TableAdapters.W_EmissioniTableAdapter
    Friend WithEvents TableAdapterManager As Patrimonio2014.IMMOBILIDataSet2TableAdapters.TableAdapterManager
    Friend WithEvents W_EmissioniBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents W_EmissioniBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents W_EmissioniDettaglioTableAdapter As Patrimonio2014.IMMOBILIDataSet2TableAdapters.W_EmissioniDettaglioTableAdapter
    Friend WithEvents ImmobileComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ProgressivoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AnagraficaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GestioneComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NumeroRataTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataScadenzaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ImportoRataTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SpeseAvvisoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DataPagamentoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents SpeseStornoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SaldoEsercizioPrecedenteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RataPreventivoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RateAddebitateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VersamentiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FondoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents W_EmissioniDettaglioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents W_EmissioniDettaglioDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
