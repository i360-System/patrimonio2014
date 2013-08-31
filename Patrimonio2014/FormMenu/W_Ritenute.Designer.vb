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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(W_Ritenute))
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
        Me.IMMOBILIDataSet2 = New Patrimonio2014.IMMOBILIDataSet2()
        Me.W_RitenuteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.W_RitenuteTableAdapter = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.W_RitenuteTableAdapter()
        Me.TableAdapterManager = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.TableAdapterManager()
        Me.W_RitenuteBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.W_RitenuteBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ProgressivoTextBox = New System.Windows.Forms.TextBox()
        Me.ImmobileComboBox = New System.Windows.Forms.ComboBox()
        Me.DocumentoTextBox = New System.Windows.Forms.TextBox()
        Me.DataDocumentoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FornitoreComboBox = New System.Windows.Forms.ComboBox()
        Me.TrattamentoComboBox = New System.Windows.Forms.ComboBox()
        Me.TributoTextBox = New System.Windows.Forms.TextBox()
        Me.CausaleTextBox = New System.Windows.Forms.TextBox()
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
        CType(Me.IMMOBILIDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.W_RitenuteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.W_RitenuteBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.W_RitenuteBindingNavigator.SuspendLayout()
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
        'IMMOBILIDataSet2
        '
        Me.IMMOBILIDataSet2.DataSetName = "IMMOBILIDataSet2"
        Me.IMMOBILIDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'W_RitenuteBindingSource
        '
        Me.W_RitenuteBindingSource.DataMember = "W_Ritenute"
        Me.W_RitenuteBindingSource.DataSource = Me.IMMOBILIDataSet2
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
        Me.TableAdapterManager.CassaTableAdapter = Nothing
        Me.TableAdapterManager.ContiFinanziariTableAdapter = Nothing
        'Me.TableAdapterManager.CostantiDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.CostantiTableAdapter = Nothing
        'Me.TableAdapterManager.FabbricatiScaleTableAdapter = Nothing
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
        Me.TableAdapterManager.Z_ConsuntivoDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.Z_ConsuntivoTableAdapter = Nothing
        Me.TableAdapterManager.Z_TestoSollecitoTableAdapter = Nothing
        '
        'W_RitenuteBindingNavigator
        '
        Me.W_RitenuteBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.W_RitenuteBindingNavigator.BindingSource = Me.W_RitenuteBindingSource
        Me.W_RitenuteBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.W_RitenuteBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.W_RitenuteBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.W_RitenuteBindingNavigatorSaveItem})
        Me.W_RitenuteBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.W_RitenuteBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.W_RitenuteBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.W_RitenuteBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.W_RitenuteBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.W_RitenuteBindingNavigator.Name = "W_RitenuteBindingNavigator"
        Me.W_RitenuteBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.W_RitenuteBindingNavigator.Size = New System.Drawing.Size(925, 25)
        Me.W_RitenuteBindingNavigator.TabIndex = 0
        Me.W_RitenuteBindingNavigator.Text = "BindingNavigator1"
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
        'W_RitenuteBindingNavigatorSaveItem
        '
        Me.W_RitenuteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.W_RitenuteBindingNavigatorSaveItem.Image = CType(resources.GetObject("W_RitenuteBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.W_RitenuteBindingNavigatorSaveItem.Name = "W_RitenuteBindingNavigatorSaveItem"
        Me.W_RitenuteBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.W_RitenuteBindingNavigatorSaveItem.Text = "Salva dati"
        '
        'ProgressivoTextBox
        '
        Me.ProgressivoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_RitenuteBindingSource, "Progressivo", True))
        Me.ProgressivoTextBox.Location = New System.Drawing.Point(15, 56)
        Me.ProgressivoTextBox.Name = "ProgressivoTextBox"
        Me.ProgressivoTextBox.Size = New System.Drawing.Size(83, 20)
        Me.ProgressivoTextBox.TabIndex = 2
        '
        'ImmobileLabel
        '
        ImmobileLabel.AutoSize = True
        ImmobileLabel.Location = New System.Drawing.Point(104, 40)
        ImmobileLabel.Name = "ImmobileLabel"
        ImmobileLabel.Size = New System.Drawing.Size(51, 13)
        ImmobileLabel.TabIndex = 3
        ImmobileLabel.Text = "Immobile:"
        '
        'ImmobileComboBox
        '
        Me.ImmobileComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_RitenuteBindingSource, "Immobile", True))
        Me.ImmobileComboBox.FormattingEnabled = True
        Me.ImmobileComboBox.Location = New System.Drawing.Point(107, 56)
        Me.ImmobileComboBox.Name = "ImmobileComboBox"
        Me.ImmobileComboBox.Size = New System.Drawing.Size(274, 21)
        Me.ImmobileComboBox.TabIndex = 4
        '
        'DocumentoLabel
        '
        DocumentoLabel.AutoSize = True
        DocumentoLabel.Location = New System.Drawing.Point(387, 40)
        DocumentoLabel.Name = "DocumentoLabel"
        DocumentoLabel.Size = New System.Drawing.Size(65, 13)
        DocumentoLabel.TabIndex = 5
        DocumentoLabel.Text = "Documento:"
        '
        'DocumentoTextBox
        '
        Me.DocumentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_RitenuteBindingSource, "Documento", True))
        Me.DocumentoTextBox.Location = New System.Drawing.Point(390, 57)
        Me.DocumentoTextBox.Name = "DocumentoTextBox"
        Me.DocumentoTextBox.Size = New System.Drawing.Size(142, 20)
        Me.DocumentoTextBox.TabIndex = 6
        '
        'DataDocumentoLabel
        '
        DataDocumentoLabel.AutoSize = True
        DataDocumentoLabel.Location = New System.Drawing.Point(535, 40)
        DataDocumentoLabel.Name = "DataDocumentoLabel"
        DataDocumentoLabel.Size = New System.Drawing.Size(91, 13)
        DataDocumentoLabel.TabIndex = 7
        DataDocumentoLabel.Text = "Data Documento:"
        '
        'DataDocumentoDateTimePicker
        '
        Me.DataDocumentoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.W_RitenuteBindingSource, "DataDocumento", True))
        Me.DataDocumentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataDocumentoDateTimePicker.Location = New System.Drawing.Point(538, 56)
        Me.DataDocumentoDateTimePicker.Name = "DataDocumentoDateTimePicker"
        Me.DataDocumentoDateTimePicker.Size = New System.Drawing.Size(96, 20)
        Me.DataDocumentoDateTimePicker.TabIndex = 8
        '
        'FornitoreLabel
        '
        FornitoreLabel.AutoSize = True
        FornitoreLabel.Location = New System.Drawing.Point(12, 79)
        FornitoreLabel.Name = "FornitoreLabel"
        FornitoreLabel.Size = New System.Drawing.Size(51, 13)
        FornitoreLabel.TabIndex = 9
        FornitoreLabel.Text = "Fornitore:"
        '
        'FornitoreComboBox
        '
        Me.FornitoreComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_RitenuteBindingSource, "Fornitore", True))
        Me.FornitoreComboBox.FormattingEnabled = True
        Me.FornitoreComboBox.Location = New System.Drawing.Point(15, 95)
        Me.FornitoreComboBox.Name = "FornitoreComboBox"
        Me.FornitoreComboBox.Size = New System.Drawing.Size(366, 21)
        Me.FornitoreComboBox.TabIndex = 10
        '
        'TrattamentoLabel
        '
        TrattamentoLabel.AutoSize = True
        TrattamentoLabel.Location = New System.Drawing.Point(390, 80)
        TrattamentoLabel.Name = "TrattamentoLabel"
        TrattamentoLabel.Size = New System.Drawing.Size(67, 13)
        TrattamentoLabel.TabIndex = 11
        TrattamentoLabel.Text = "Trattamento:"
        '
        'TrattamentoComboBox
        '
        Me.TrattamentoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_RitenuteBindingSource, "Trattamento", True))
        Me.TrattamentoComboBox.FormattingEnabled = True
        Me.TrattamentoComboBox.Location = New System.Drawing.Point(390, 95)
        Me.TrattamentoComboBox.Name = "TrattamentoComboBox"
        Me.TrattamentoComboBox.Size = New System.Drawing.Size(244, 21)
        Me.TrattamentoComboBox.TabIndex = 12
        '
        'TributoLabel
        '
        TributoLabel.AutoSize = True
        TributoLabel.Location = New System.Drawing.Point(12, 119)
        TributoLabel.Name = "TributoLabel"
        TributoLabel.Size = New System.Drawing.Size(43, 13)
        TributoLabel.TabIndex = 13
        TributoLabel.Text = "Tributo:"
        '
        'TributoTextBox
        '
        Me.TributoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_RitenuteBindingSource, "Tributo", True))
        Me.TributoTextBox.Location = New System.Drawing.Point(15, 135)
        Me.TributoTextBox.Name = "TributoTextBox"
        Me.TributoTextBox.Size = New System.Drawing.Size(62, 20)
        Me.TributoTextBox.TabIndex = 14
        '
        'CausaleLabel
        '
        CausaleLabel.AutoSize = True
        CausaleLabel.Location = New System.Drawing.Point(82, 119)
        CausaleLabel.Name = "CausaleLabel"
        CausaleLabel.Size = New System.Drawing.Size(48, 13)
        CausaleLabel.TabIndex = 15
        CausaleLabel.Text = "Causale:"
        '
        'CausaleTextBox
        '
        Me.CausaleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_RitenuteBindingSource, "Causale", True))
        Me.CausaleTextBox.Location = New System.Drawing.Point(85, 135)
        Me.CausaleTextBox.Name = "CausaleTextBox"
        Me.CausaleTextBox.Size = New System.Drawing.Size(181, 20)
        Me.CausaleTextBox.TabIndex = 16
        '
        'CompensoLabel
        '
        CompensoLabel.AutoSize = True
        CompensoLabel.Location = New System.Drawing.Point(272, 119)
        CompensoLabel.Name = "CompensoLabel"
        CompensoLabel.Size = New System.Drawing.Size(60, 13)
        CompensoLabel.TabIndex = 17
        CompensoLabel.Text = "Compenso:"
        '
        'CompensoTextBox
        '
        Me.CompensoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_RitenuteBindingSource, "Compenso", True))
        Me.CompensoTextBox.Location = New System.Drawing.Point(275, 135)
        Me.CompensoTextBox.Name = "CompensoTextBox"
        Me.CompensoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CompensoTextBox.TabIndex = 18
        '
        'EsenteLabel
        '
        EsenteLabel.AutoSize = True
        EsenteLabel.Location = New System.Drawing.Point(381, 119)
        EsenteLabel.Name = "EsenteLabel"
        EsenteLabel.Size = New System.Drawing.Size(43, 13)
        EsenteLabel.TabIndex = 19
        EsenteLabel.Text = "Esente:"
        '
        'EsenteTextBox
        '
        Me.EsenteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_RitenuteBindingSource, "Esente", True))
        Me.EsenteTextBox.Location = New System.Drawing.Point(384, 135)
        Me.EsenteTextBox.Name = "EsenteTextBox"
        Me.EsenteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EsenteTextBox.TabIndex = 20
        '
        'PrevidenzaLabel
        '
        PrevidenzaLabel.AutoSize = True
        PrevidenzaLabel.Location = New System.Drawing.Point(490, 119)
        PrevidenzaLabel.Name = "PrevidenzaLabel"
        PrevidenzaLabel.Size = New System.Drawing.Size(63, 13)
        PrevidenzaLabel.TabIndex = 21
        PrevidenzaLabel.Text = "Previdenza:"
        '
        'PrevidenzaTextBox
        '
        Me.PrevidenzaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_RitenuteBindingSource, "Previdenza", True))
        Me.PrevidenzaTextBox.Location = New System.Drawing.Point(493, 135)
        Me.PrevidenzaTextBox.Name = "PrevidenzaTextBox"
        Me.PrevidenzaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PrevidenzaTextBox.TabIndex = 22
        '
        'IvaLabel
        '
        IvaLabel.AutoSize = True
        IvaLabel.Location = New System.Drawing.Point(601, 119)
        IvaLabel.Name = "IvaLabel"
        IvaLabel.Size = New System.Drawing.Size(25, 13)
        IvaLabel.TabIndex = 23
        IvaLabel.Text = "Iva:"
        '
        'IvaTextBox
        '
        Me.IvaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_RitenuteBindingSource, "Iva", True))
        Me.IvaTextBox.Location = New System.Drawing.Point(604, 135)
        Me.IvaTextBox.Name = "IvaTextBox"
        Me.IvaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IvaTextBox.TabIndex = 24
        '
        'ImponibileLabel
        '
        ImponibileLabel.AutoSize = True
        ImponibileLabel.Location = New System.Drawing.Point(710, 119)
        ImponibileLabel.Name = "ImponibileLabel"
        ImponibileLabel.Size = New System.Drawing.Size(57, 13)
        ImponibileLabel.TabIndex = 25
        ImponibileLabel.Text = "Imponibile:"
        '
        'ImponibileTextBox
        '
        Me.ImponibileTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_RitenuteBindingSource, "Imponibile", True))
        Me.ImponibileTextBox.Location = New System.Drawing.Point(713, 135)
        Me.ImponibileTextBox.Name = "ImponibileTextBox"
        Me.ImponibileTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ImponibileTextBox.TabIndex = 26
        '
        'RitenutaLabel
        '
        RitenutaLabel.AutoSize = True
        RitenutaLabel.Location = New System.Drawing.Point(601, 158)
        RitenutaLabel.Name = "RitenutaLabel"
        RitenutaLabel.Size = New System.Drawing.Size(50, 13)
        RitenutaLabel.TabIndex = 27
        RitenutaLabel.Text = "Ritenuta:"
        '
        'RitenutaTextBox
        '
        Me.RitenutaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_RitenuteBindingSource, "Ritenuta", True))
        Me.RitenutaTextBox.Location = New System.Drawing.Point(604, 174)
        Me.RitenutaTextBox.Name = "RitenutaTextBox"
        Me.RitenutaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RitenutaTextBox.TabIndex = 28
        '
        'NettoLabel
        '
        NettoLabel.AutoSize = True
        NettoLabel.Location = New System.Drawing.Point(710, 158)
        NettoLabel.Name = "NettoLabel"
        NettoLabel.Size = New System.Drawing.Size(36, 13)
        NettoLabel.TabIndex = 29
        NettoLabel.Text = "Netto:"
        '
        'NettoTextBox
        '
        Me.NettoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_RitenuteBindingSource, "Netto", True))
        Me.NettoTextBox.Location = New System.Drawing.Point(713, 174)
        Me.NettoTextBox.Name = "NettoTextBox"
        Me.NettoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NettoTextBox.TabIndex = 30
        '
        'DataPagamentoLabel
        '
        DataPagamentoLabel.AutoSize = True
        DataPagamentoLabel.Location = New System.Drawing.Point(601, 197)
        DataPagamentoLabel.Name = "DataPagamentoLabel"
        DataPagamentoLabel.Size = New System.Drawing.Size(90, 13)
        DataPagamentoLabel.TabIndex = 31
        DataPagamentoLabel.Text = "Data Pagamento:"
        '
        'DataPagamentoDateTimePicker
        '
        Me.DataPagamentoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.W_RitenuteBindingSource, "DataPagamento", True))
        Me.DataPagamentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataPagamentoDateTimePicker.Location = New System.Drawing.Point(604, 213)
        Me.DataPagamentoDateTimePicker.Name = "DataPagamentoDateTimePicker"
        Me.DataPagamentoDateTimePicker.Size = New System.Drawing.Size(100, 20)
        Me.DataPagamentoDateTimePicker.TabIndex = 32
        '
        'AnnoLabel
        '
        AnnoLabel.AutoSize = True
        AnnoLabel.Location = New System.Drawing.Point(711, 197)
        AnnoLabel.Name = "AnnoLabel"
        AnnoLabel.Size = New System.Drawing.Size(35, 13)
        AnnoLabel.TabIndex = 33
        AnnoLabel.Text = "Anno:"
        '
        'AnnoTextBox
        '
        Me.AnnoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_RitenuteBindingSource, "Anno", True))
        Me.AnnoTextBox.Location = New System.Drawing.Point(714, 213)
        Me.AnnoTextBox.Name = "AnnoTextBox"
        Me.AnnoTextBox.Size = New System.Drawing.Size(53, 20)
        Me.AnnoTextBox.TabIndex = 34
        '
        'W_Ritenute
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 273)
        Me.Controls.Add(AnnoLabel)
        Me.Controls.Add(Me.AnnoTextBox)
        Me.Controls.Add(DataPagamentoLabel)
        Me.Controls.Add(Me.DataPagamentoDateTimePicker)
        Me.Controls.Add(NettoLabel)
        Me.Controls.Add(Me.NettoTextBox)
        Me.Controls.Add(RitenutaLabel)
        Me.Controls.Add(Me.RitenutaTextBox)
        Me.Controls.Add(ImponibileLabel)
        Me.Controls.Add(Me.ImponibileTextBox)
        Me.Controls.Add(IvaLabel)
        Me.Controls.Add(Me.IvaTextBox)
        Me.Controls.Add(PrevidenzaLabel)
        Me.Controls.Add(Me.PrevidenzaTextBox)
        Me.Controls.Add(EsenteLabel)
        Me.Controls.Add(Me.EsenteTextBox)
        Me.Controls.Add(CompensoLabel)
        Me.Controls.Add(Me.CompensoTextBox)
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
        Me.Controls.Add(Me.W_RitenuteBindingNavigator)
        Me.Name = "W_Ritenute"
        Me.Text = "Archivio Ritenute d'Acconto"
        CType(Me.IMMOBILIDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.W_RitenuteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.W_RitenuteBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.W_RitenuteBindingNavigator.ResumeLayout(False)
        Me.W_RitenuteBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IMMOBILIDataSet2 As Patrimonio2014.IMMOBILIDataSet2
    Friend WithEvents W_RitenuteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents W_RitenuteTableAdapter As Patrimonio2014.IMMOBILIDataSet2TableAdapters.W_RitenuteTableAdapter
    Friend WithEvents TableAdapterManager As Patrimonio2014.IMMOBILIDataSet2TableAdapters.TableAdapterManager
    Friend WithEvents W_RitenuteBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents W_RitenuteBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ProgressivoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ImmobileComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DocumentoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataDocumentoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents FornitoreComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TrattamentoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TributoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CausaleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CompensoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EsenteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrevidenzaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IvaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ImponibileTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RitenutaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NettoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataPagamentoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents AnnoTextBox As System.Windows.Forms.TextBox
End Class
