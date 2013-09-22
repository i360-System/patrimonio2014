<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class X_Spese
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
        Dim FabbricatoLabel As System.Windows.Forms.Label
        Dim ScalaLabel As System.Windows.Forms.Label
        Dim GruppoLabel As System.Windows.Forms.Label
        Dim SpesaLabel As System.Windows.Forms.Label
        Dim UnitaLabel As System.Windows.Forms.Label
        Dim DocumentoLabel As System.Windows.Forms.Label
        Dim FornitoreLabel As System.Windows.Forms.Label
        Dim QuantitaLabel As System.Windows.Forms.Label
        Dim ImportoSpesaLabel As System.Windows.Forms.Label
        Dim DataDocumentoLabel As System.Windows.Forms.Label
        Dim FatturaSaldataLabel As System.Windows.Forms.Label
        Dim TrattamentoLabel As System.Windows.Forms.Label
        Dim CodiceTributoLabel As System.Windows.Forms.Label
        Dim CausaleLabel As System.Windows.Forms.Label
        Dim CompensoLabel As System.Windows.Forms.Label
        Dim EsenteLabel As System.Windows.Forms.Label
        Dim PrevidenzaLabel As System.Windows.Forms.Label
        Dim IvaLabel As System.Windows.Forms.Label
        Dim ImponibileLabel As System.Windows.Forms.Label
        Dim RitenutaLabel As System.Windows.Forms.Label
        Dim NettoLabel As System.Windows.Forms.Label
        Dim QuadroAcLabel As System.Windows.Forms.Label
        Dim DataPagamentoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(X_Spese))
        Me.IMMOBILIDataSet2 = New Patrimonio2014.IMMOBILIDataSet2()
        Me.X_SpeseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.X_SpeseTableAdapter = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.X_SpeseTableAdapter()
        Me.TableAdapterManager = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.TableAdapterManager()
        Me.X_SpeseDescrizioniTableAdapter = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.X_SpeseDescrizioniTableAdapter()
        Me.X_SpeseBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.X_SpeseBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ProgressivoTextBox = New System.Windows.Forms.TextBox()
        Me.ImmobileComboBox = New System.Windows.Forms.ComboBox()
        Me.GestioneComboBox = New System.Windows.Forms.ComboBox()
        Me.FabbricatoComboBox = New System.Windows.Forms.ComboBox()
        Me.ScalaComboBox = New System.Windows.Forms.ComboBox()
        Me.GruppoComboBox = New System.Windows.Forms.ComboBox()
        Me.SpesaComboBox = New System.Windows.Forms.ComboBox()
        Me.UnitaComboBox = New System.Windows.Forms.ComboBox()
        Me.DocumentoTextBox = New System.Windows.Forms.TextBox()
        Me.FornitoreComboBox = New System.Windows.Forms.ComboBox()
        Me.QuantitaTextBox = New System.Windows.Forms.TextBox()
        Me.ImportoSpesaTextBox = New System.Windows.Forms.TextBox()
        Me.DataDocumentoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FatturaSaldataTextBox = New System.Windows.Forms.TextBox()
        Me.TrattamentoComboBox = New System.Windows.Forms.ComboBox()
        Me.CodiceTributoTextBox = New System.Windows.Forms.TextBox()
        Me.CausaleTextBox = New System.Windows.Forms.TextBox()
        Me.CompensoTextBox = New System.Windows.Forms.TextBox()
        Me.EsenteTextBox = New System.Windows.Forms.TextBox()
        Me.PrevidenzaTextBox = New System.Windows.Forms.TextBox()
        Me.IvaTextBox = New System.Windows.Forms.TextBox()
        Me.ImponibileTextBox = New System.Windows.Forms.TextBox()
        Me.RitenutaTextBox = New System.Windows.Forms.TextBox()
        Me.NettoTextBox = New System.Windows.Forms.TextBox()
        Me.QuadroAcTextBox = New System.Windows.Forms.TextBox()
        Me.DataPagamentoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.X_SpeseDescrizioniBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.X_SpeseDescrizioniDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        ProgressivoLabel = New System.Windows.Forms.Label()
        ImmobileLabel = New System.Windows.Forms.Label()
        GestioneLabel = New System.Windows.Forms.Label()
        FabbricatoLabel = New System.Windows.Forms.Label()
        ScalaLabel = New System.Windows.Forms.Label()
        GruppoLabel = New System.Windows.Forms.Label()
        SpesaLabel = New System.Windows.Forms.Label()
        UnitaLabel = New System.Windows.Forms.Label()
        DocumentoLabel = New System.Windows.Forms.Label()
        FornitoreLabel = New System.Windows.Forms.Label()
        QuantitaLabel = New System.Windows.Forms.Label()
        ImportoSpesaLabel = New System.Windows.Forms.Label()
        DataDocumentoLabel = New System.Windows.Forms.Label()
        FatturaSaldataLabel = New System.Windows.Forms.Label()
        TrattamentoLabel = New System.Windows.Forms.Label()
        CodiceTributoLabel = New System.Windows.Forms.Label()
        CausaleLabel = New System.Windows.Forms.Label()
        CompensoLabel = New System.Windows.Forms.Label()
        EsenteLabel = New System.Windows.Forms.Label()
        PrevidenzaLabel = New System.Windows.Forms.Label()
        IvaLabel = New System.Windows.Forms.Label()
        ImponibileLabel = New System.Windows.Forms.Label()
        RitenutaLabel = New System.Windows.Forms.Label()
        NettoLabel = New System.Windows.Forms.Label()
        QuadroAcLabel = New System.Windows.Forms.Label()
        DataPagamentoLabel = New System.Windows.Forms.Label()
        CType(Me.IMMOBILIDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X_SpeseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X_SpeseBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.X_SpeseBindingNavigator.SuspendLayout()
        CType(Me.X_SpeseDescrizioniBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X_SpeseDescrizioniDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgressivoLabel
        '
        ProgressivoLabel.AutoSize = True
        ProgressivoLabel.Location = New System.Drawing.Point(12, 43)
        ProgressivoLabel.Name = "ProgressivoLabel"
        ProgressivoLabel.Size = New System.Drawing.Size(65, 13)
        ProgressivoLabel.TabIndex = 1
        ProgressivoLabel.Text = "Progressivo:"
        '
        'ImmobileLabel
        '
        ImmobileLabel.AutoSize = True
        ImmobileLabel.Location = New System.Drawing.Point(96, 43)
        ImmobileLabel.Name = "ImmobileLabel"
        ImmobileLabel.Size = New System.Drawing.Size(51, 13)
        ImmobileLabel.TabIndex = 3
        ImmobileLabel.Text = "Immobile:"
        '
        'GestioneLabel
        '
        GestioneLabel.AutoSize = True
        GestioneLabel.Location = New System.Drawing.Point(363, 43)
        GestioneLabel.Name = "GestioneLabel"
        GestioneLabel.Size = New System.Drawing.Size(52, 13)
        GestioneLabel.TabIndex = 5
        GestioneLabel.Text = "Gestione:"
        '
        'FabbricatoLabel
        '
        FabbricatoLabel.AutoSize = True
        FabbricatoLabel.Location = New System.Drawing.Point(96, 82)
        FabbricatoLabel.Name = "FabbricatoLabel"
        FabbricatoLabel.Size = New System.Drawing.Size(60, 13)
        FabbricatoLabel.TabIndex = 7
        FabbricatoLabel.Text = "Fabbricato:"
        '
        'ScalaLabel
        '
        ScalaLabel.AutoSize = True
        ScalaLabel.Location = New System.Drawing.Point(363, 82)
        ScalaLabel.Name = "ScalaLabel"
        ScalaLabel.Size = New System.Drawing.Size(37, 13)
        ScalaLabel.TabIndex = 9
        ScalaLabel.Text = "Scala:"
        '
        'GruppoLabel
        '
        GruppoLabel.AutoSize = True
        GruppoLabel.Location = New System.Drawing.Point(96, 122)
        GruppoLabel.Name = "GruppoLabel"
        GruppoLabel.Size = New System.Drawing.Size(45, 13)
        GruppoLabel.TabIndex = 11
        GruppoLabel.Text = "Gruppo:"
        '
        'SpesaLabel
        '
        SpesaLabel.AutoSize = True
        SpesaLabel.Location = New System.Drawing.Point(96, 162)
        SpesaLabel.Name = "SpesaLabel"
        SpesaLabel.Size = New System.Drawing.Size(40, 13)
        SpesaLabel.TabIndex = 13
        SpesaLabel.Text = "Spesa:"
        '
        'UnitaLabel
        '
        UnitaLabel.AutoSize = True
        UnitaLabel.Location = New System.Drawing.Point(365, 122)
        UnitaLabel.Name = "UnitaLabel"
        UnitaLabel.Size = New System.Drawing.Size(35, 13)
        UnitaLabel.TabIndex = 15
        UnitaLabel.Text = "Unita:"
        '
        'DocumentoLabel
        '
        DocumentoLabel.AutoSize = True
        DocumentoLabel.Location = New System.Drawing.Point(12, 208)
        DocumentoLabel.Name = "DocumentoLabel"
        DocumentoLabel.Size = New System.Drawing.Size(65, 13)
        DocumentoLabel.TabIndex = 17
        DocumentoLabel.Text = "Documento:"
        '
        'FornitoreLabel
        '
        FornitoreLabel.AutoSize = True
        FornitoreLabel.Location = New System.Drawing.Point(96, 208)
        FornitoreLabel.Name = "FornitoreLabel"
        FornitoreLabel.Size = New System.Drawing.Size(51, 13)
        FornitoreLabel.TabIndex = 19
        FornitoreLabel.Text = "Fornitore:"
        '
        'QuantitaLabel
        '
        QuantitaLabel.AutoSize = True
        QuantitaLabel.Location = New System.Drawing.Point(365, 208)
        QuantitaLabel.Name = "QuantitaLabel"
        QuantitaLabel.Size = New System.Drawing.Size(50, 13)
        QuantitaLabel.TabIndex = 21
        QuantitaLabel.Text = "Quantita:"
        '
        'ImportoSpesaLabel
        '
        ImportoSpesaLabel.AutoSize = True
        ImportoSpesaLabel.Location = New System.Drawing.Point(421, 208)
        ImportoSpesaLabel.Name = "ImportoSpesaLabel"
        ImportoSpesaLabel.Size = New System.Drawing.Size(78, 13)
        ImportoSpesaLabel.TabIndex = 23
        ImportoSpesaLabel.Text = "Importo Spesa:"
        '
        'DataDocumentoLabel
        '
        DataDocumentoLabel.AutoSize = True
        DataDocumentoLabel.Location = New System.Drawing.Point(530, 208)
        DataDocumentoLabel.Name = "DataDocumentoLabel"
        DataDocumentoLabel.Size = New System.Drawing.Size(91, 13)
        DataDocumentoLabel.TabIndex = 25
        DataDocumentoLabel.Text = "Data Documento:"
        '
        'FatturaSaldataLabel
        '
        FatturaSaldataLabel.AutoSize = True
        FatturaSaldataLabel.Location = New System.Drawing.Point(632, 208)
        FatturaSaldataLabel.Name = "FatturaSaldataLabel"
        FatturaSaldataLabel.Size = New System.Drawing.Size(37, 13)
        FatturaSaldataLabel.TabIndex = 27
        FatturaSaldataLabel.Text = "Saldo:"
        '
        'TrattamentoLabel
        '
        TrattamentoLabel.AutoSize = True
        TrattamentoLabel.Location = New System.Drawing.Point(96, 247)
        TrattamentoLabel.Name = "TrattamentoLabel"
        TrattamentoLabel.Size = New System.Drawing.Size(67, 13)
        TrattamentoLabel.TabIndex = 29
        TrattamentoLabel.Text = "Trattamento:"
        '
        'CodiceTributoLabel
        '
        CodiceTributoLabel.AutoSize = True
        CodiceTributoLabel.Location = New System.Drawing.Point(12, 287)
        CodiceTributoLabel.Name = "CodiceTributoLabel"
        CodiceTributoLabel.Size = New System.Drawing.Size(79, 13)
        CodiceTributoLabel.TabIndex = 31
        CodiceTributoLabel.Text = "Codice Tributo:"
        '
        'CausaleLabel
        '
        CausaleLabel.AutoSize = True
        CausaleLabel.Location = New System.Drawing.Point(99, 287)
        CausaleLabel.Name = "CausaleLabel"
        CausaleLabel.Size = New System.Drawing.Size(48, 13)
        CausaleLabel.TabIndex = 33
        CausaleLabel.Text = "Causale:"
        '
        'CompensoLabel
        '
        CompensoLabel.AutoSize = True
        CompensoLabel.Location = New System.Drawing.Point(17, 326)
        CompensoLabel.Name = "CompensoLabel"
        CompensoLabel.Size = New System.Drawing.Size(60, 13)
        CompensoLabel.TabIndex = 35
        CompensoLabel.Text = "Compenso:"
        '
        'EsenteLabel
        '
        EsenteLabel.AutoSize = True
        EsenteLabel.Location = New System.Drawing.Point(121, 326)
        EsenteLabel.Name = "EsenteLabel"
        EsenteLabel.Size = New System.Drawing.Size(43, 13)
        EsenteLabel.TabIndex = 37
        EsenteLabel.Text = "Esente:"
        '
        'PrevidenzaLabel
        '
        PrevidenzaLabel.AutoSize = True
        PrevidenzaLabel.Location = New System.Drawing.Point(187, 326)
        PrevidenzaLabel.Name = "PrevidenzaLabel"
        PrevidenzaLabel.Size = New System.Drawing.Size(63, 13)
        PrevidenzaLabel.TabIndex = 39
        PrevidenzaLabel.Text = "Previdenza:"
        '
        'IvaLabel
        '
        IvaLabel.AutoSize = True
        IvaLabel.Location = New System.Drawing.Point(275, 326)
        IvaLabel.Name = "IvaLabel"
        IvaLabel.Size = New System.Drawing.Size(25, 13)
        IvaLabel.TabIndex = 41
        IvaLabel.Text = "Iva:"
        '
        'ImponibileLabel
        '
        ImponibileLabel.AutoSize = True
        ImponibileLabel.Location = New System.Drawing.Point(365, 326)
        ImponibileLabel.Name = "ImponibileLabel"
        ImponibileLabel.Size = New System.Drawing.Size(57, 13)
        ImponibileLabel.TabIndex = 43
        ImponibileLabel.Text = "Imponibile:"
        '
        'RitenutaLabel
        '
        RitenutaLabel.AutoSize = True
        RitenutaLabel.Location = New System.Drawing.Point(454, 326)
        RitenutaLabel.Name = "RitenutaLabel"
        RitenutaLabel.Size = New System.Drawing.Size(50, 13)
        RitenutaLabel.TabIndex = 45
        RitenutaLabel.Text = "Ritenuta:"
        '
        'NettoLabel
        '
        NettoLabel.AutoSize = True
        NettoLabel.Location = New System.Drawing.Point(542, 326)
        NettoLabel.Name = "NettoLabel"
        NettoLabel.Size = New System.Drawing.Size(36, 13)
        NettoLabel.TabIndex = 47
        NettoLabel.Text = "Netto:"
        '
        'QuadroAcLabel
        '
        QuadroAcLabel.AutoSize = True
        QuadroAcLabel.Location = New System.Drawing.Point(675, 208)
        QuadroAcLabel.Name = "QuadroAcLabel"
        QuadroAcLabel.Size = New System.Drawing.Size(61, 13)
        QuadroAcLabel.TabIndex = 49
        QuadroAcLabel.Text = "Quadro Ac:"
        '
        'DataPagamentoLabel
        '
        DataPagamentoLabel.AutoSize = True
        DataPagamentoLabel.Location = New System.Drawing.Point(632, 326)
        DataPagamentoLabel.Name = "DataPagamentoLabel"
        DataPagamentoLabel.Size = New System.Drawing.Size(90, 13)
        DataPagamentoLabel.TabIndex = 51
        DataPagamentoLabel.Text = "Data Pagamento:"
        '
        'IMMOBILIDataSet2
        '
        Me.IMMOBILIDataSet2.DataSetName = "IMMOBILIDataSet2"
        Me.IMMOBILIDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'X_SpeseBindingSource
        '
        Me.X_SpeseBindingSource.DataMember = "X_Spese"
        Me.X_SpeseBindingSource.DataSource = Me.IMMOBILIDataSet2
        '
        'X_SpeseTableAdapter
        '
        Me.X_SpeseTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.X_MovimentiCondominiTableAdapter = Nothing
        Me.TableAdapterManager.X_MovimentiFinanziariTableAdapter = Nothing
        Me.TableAdapterManager.X_MovimentiFondiTableAdapter = Nothing
        Me.TableAdapterManager.X_SpeseDescrizioniTableAdapter = Me.X_SpeseDescrizioniTableAdapter
        Me.TableAdapterManager.X_SpeseTableAdapter = Me.X_SpeseTableAdapter
        Me.TableAdapterManager.Y_GestioniDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.Y_GestioniTableAdapter = Nothing
        Me.TableAdapterManager.Y_GestioniUnitaDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.Y_GestioniUnitaTableAdapter = Nothing
        Me.TableAdapterManager.Z_ConsuntivoDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.Z_ConsuntivoTableAdapter = Nothing
        Me.TableAdapterManager.Z_TestoSollecitoTableAdapter = Nothing
        '
        'X_SpeseDescrizioniTableAdapter
        '
        Me.X_SpeseDescrizioniTableAdapter.ClearBeforeFill = True
        '
        'X_SpeseBindingNavigator
        '
        Me.X_SpeseBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.X_SpeseBindingNavigator.BindingSource = Me.X_SpeseBindingSource
        Me.X_SpeseBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.X_SpeseBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.X_SpeseBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.X_SpeseBindingNavigatorSaveItem})
        Me.X_SpeseBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.X_SpeseBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.X_SpeseBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.X_SpeseBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.X_SpeseBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.X_SpeseBindingNavigator.Name = "X_SpeseBindingNavigator"
        Me.X_SpeseBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.X_SpeseBindingNavigator.Size = New System.Drawing.Size(756, 25)
        Me.X_SpeseBindingNavigator.TabIndex = 0
        Me.X_SpeseBindingNavigator.Text = "BindingNavigator1"
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
        'X_SpeseBindingNavigatorSaveItem
        '
        Me.X_SpeseBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.X_SpeseBindingNavigatorSaveItem.Image = CType(resources.GetObject("X_SpeseBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.X_SpeseBindingNavigatorSaveItem.Name = "X_SpeseBindingNavigatorSaveItem"
        Me.X_SpeseBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.X_SpeseBindingNavigatorSaveItem.Text = "Salva dati"
        '
        'ProgressivoTextBox
        '
        Me.ProgressivoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_SpeseBindingSource, "Progressivo", True))
        Me.ProgressivoTextBox.Location = New System.Drawing.Point(15, 59)
        Me.ProgressivoTextBox.Name = "ProgressivoTextBox"
        Me.ProgressivoTextBox.Size = New System.Drawing.Size(75, 20)
        Me.ProgressivoTextBox.TabIndex = 2
        '
        'ImmobileComboBox
        '
        Me.ImmobileComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_SpeseBindingSource, "Immobile", True))
        Me.ImmobileComboBox.FormattingEnabled = True
        Me.ImmobileComboBox.Location = New System.Drawing.Point(99, 58)
        Me.ImmobileComboBox.Name = "ImmobileComboBox"
        Me.ImmobileComboBox.Size = New System.Drawing.Size(258, 21)
        Me.ImmobileComboBox.TabIndex = 4
        '
        'GestioneComboBox
        '
        Me.GestioneComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_SpeseBindingSource, "Gestione", True))
        Me.GestioneComboBox.FormattingEnabled = True
        Me.GestioneComboBox.Location = New System.Drawing.Point(366, 58)
        Me.GestioneComboBox.Name = "GestioneComboBox"
        Me.GestioneComboBox.Size = New System.Drawing.Size(260, 21)
        Me.GestioneComboBox.TabIndex = 6
        '
        'FabbricatoComboBox
        '
        Me.FabbricatoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_SpeseBindingSource, "Fabbricato", True))
        Me.FabbricatoComboBox.FormattingEnabled = True
        Me.FabbricatoComboBox.Location = New System.Drawing.Point(99, 98)
        Me.FabbricatoComboBox.Name = "FabbricatoComboBox"
        Me.FabbricatoComboBox.Size = New System.Drawing.Size(258, 21)
        Me.FabbricatoComboBox.TabIndex = 8
        '
        'ScalaComboBox
        '
        Me.ScalaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_SpeseBindingSource, "Scala", True))
        Me.ScalaComboBox.FormattingEnabled = True
        Me.ScalaComboBox.Location = New System.Drawing.Point(366, 98)
        Me.ScalaComboBox.Name = "ScalaComboBox"
        Me.ScalaComboBox.Size = New System.Drawing.Size(260, 21)
        Me.ScalaComboBox.TabIndex = 10
        '
        'GruppoComboBox
        '
        Me.GruppoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_SpeseBindingSource, "Gruppo", True))
        Me.GruppoComboBox.FormattingEnabled = True
        Me.GruppoComboBox.Location = New System.Drawing.Point(99, 138)
        Me.GruppoComboBox.Name = "GruppoComboBox"
        Me.GruppoComboBox.Size = New System.Drawing.Size(258, 21)
        Me.GruppoComboBox.TabIndex = 12
        '
        'SpesaComboBox
        '
        Me.SpesaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_SpeseBindingSource, "Spesa", True))
        Me.SpesaComboBox.FormattingEnabled = True
        Me.SpesaComboBox.Location = New System.Drawing.Point(99, 178)
        Me.SpesaComboBox.Name = "SpesaComboBox"
        Me.SpesaComboBox.Size = New System.Drawing.Size(258, 21)
        Me.SpesaComboBox.TabIndex = 14
        '
        'UnitaComboBox
        '
        Me.UnitaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_SpeseBindingSource, "Unita", True))
        Me.UnitaComboBox.FormattingEnabled = True
        Me.UnitaComboBox.Location = New System.Drawing.Point(368, 138)
        Me.UnitaComboBox.Name = "UnitaComboBox"
        Me.UnitaComboBox.Size = New System.Drawing.Size(258, 21)
        Me.UnitaComboBox.TabIndex = 16
        '
        'DocumentoTextBox
        '
        Me.DocumentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_SpeseBindingSource, "Documento", True))
        Me.DocumentoTextBox.Location = New System.Drawing.Point(15, 224)
        Me.DocumentoTextBox.Name = "DocumentoTextBox"
        Me.DocumentoTextBox.Size = New System.Drawing.Size(75, 20)
        Me.DocumentoTextBox.TabIndex = 18
        '
        'FornitoreComboBox
        '
        Me.FornitoreComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_SpeseBindingSource, "Fornitore", True))
        Me.FornitoreComboBox.FormattingEnabled = True
        Me.FornitoreComboBox.Location = New System.Drawing.Point(99, 223)
        Me.FornitoreComboBox.Name = "FornitoreComboBox"
        Me.FornitoreComboBox.Size = New System.Drawing.Size(258, 21)
        Me.FornitoreComboBox.TabIndex = 20
        '
        'QuantitaTextBox
        '
        Me.QuantitaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_SpeseBindingSource, "Quantita", True))
        Me.QuantitaTextBox.Location = New System.Drawing.Point(368, 224)
        Me.QuantitaTextBox.Name = "QuantitaTextBox"
        Me.QuantitaTextBox.Size = New System.Drawing.Size(47, 20)
        Me.QuantitaTextBox.TabIndex = 22
        '
        'ImportoSpesaTextBox
        '
        Me.ImportoSpesaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_SpeseBindingSource, "ImportoSpesa", True))
        Me.ImportoSpesaTextBox.Location = New System.Drawing.Point(424, 223)
        Me.ImportoSpesaTextBox.Name = "ImportoSpesaTextBox"
        Me.ImportoSpesaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ImportoSpesaTextBox.TabIndex = 24
        '
        'DataDocumentoDateTimePicker
        '
        Me.DataDocumentoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.X_SpeseBindingSource, "DataDocumento", True))
        Me.DataDocumentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataDocumentoDateTimePicker.Location = New System.Drawing.Point(533, 224)
        Me.DataDocumentoDateTimePicker.Name = "DataDocumentoDateTimePicker"
        Me.DataDocumentoDateTimePicker.Size = New System.Drawing.Size(93, 20)
        Me.DataDocumentoDateTimePicker.TabIndex = 26
        '
        'FatturaSaldataTextBox
        '
        Me.FatturaSaldataTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_SpeseBindingSource, "FatturaSaldata", True))
        Me.FatturaSaldataTextBox.Location = New System.Drawing.Point(635, 223)
        Me.FatturaSaldataTextBox.Name = "FatturaSaldataTextBox"
        Me.FatturaSaldataTextBox.Size = New System.Drawing.Size(34, 20)
        Me.FatturaSaldataTextBox.TabIndex = 28
        '
        'TrattamentoComboBox
        '
        Me.TrattamentoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_SpeseBindingSource, "Trattamento", True))
        Me.TrattamentoComboBox.FormattingEnabled = True
        Me.TrattamentoComboBox.Location = New System.Drawing.Point(99, 263)
        Me.TrattamentoComboBox.Name = "TrattamentoComboBox"
        Me.TrattamentoComboBox.Size = New System.Drawing.Size(258, 21)
        Me.TrattamentoComboBox.TabIndex = 30
        '
        'CodiceTributoTextBox
        '
        Me.CodiceTributoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_SpeseBindingSource, "CodiceTributo", True))
        Me.CodiceTributoTextBox.Location = New System.Drawing.Point(15, 303)
        Me.CodiceTributoTextBox.Name = "CodiceTributoTextBox"
        Me.CodiceTributoTextBox.Size = New System.Drawing.Size(76, 20)
        Me.CodiceTributoTextBox.TabIndex = 32
        '
        'CausaleTextBox
        '
        Me.CausaleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_SpeseBindingSource, "Causale", True))
        Me.CausaleTextBox.Location = New System.Drawing.Point(102, 303)
        Me.CausaleTextBox.Name = "CausaleTextBox"
        Me.CausaleTextBox.Size = New System.Drawing.Size(255, 20)
        Me.CausaleTextBox.TabIndex = 34
        '
        'CompensoTextBox
        '
        Me.CompensoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_SpeseBindingSource, "Compenso", True))
        Me.CompensoTextBox.Location = New System.Drawing.Point(15, 342)
        Me.CompensoTextBox.Name = "CompensoTextBox"
        Me.CompensoTextBox.Size = New System.Drawing.Size(76, 20)
        Me.CompensoTextBox.TabIndex = 36
        '
        'EsenteTextBox
        '
        Me.EsenteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_SpeseBindingSource, "Esente", True))
        Me.EsenteTextBox.Location = New System.Drawing.Point(102, 342)
        Me.EsenteTextBox.Name = "EsenteTextBox"
        Me.EsenteTextBox.Size = New System.Drawing.Size(79, 20)
        Me.EsenteTextBox.TabIndex = 38
        '
        'PrevidenzaTextBox
        '
        Me.PrevidenzaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_SpeseBindingSource, "Previdenza", True))
        Me.PrevidenzaTextBox.Location = New System.Drawing.Point(190, 342)
        Me.PrevidenzaTextBox.Name = "PrevidenzaTextBox"
        Me.PrevidenzaTextBox.Size = New System.Drawing.Size(79, 20)
        Me.PrevidenzaTextBox.TabIndex = 40
        '
        'IvaTextBox
        '
        Me.IvaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_SpeseBindingSource, "Iva", True))
        Me.IvaTextBox.Location = New System.Drawing.Point(275, 342)
        Me.IvaTextBox.Name = "IvaTextBox"
        Me.IvaTextBox.Size = New System.Drawing.Size(82, 20)
        Me.IvaTextBox.TabIndex = 42
        '
        'ImponibileTextBox
        '
        Me.ImponibileTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_SpeseBindingSource, "Imponibile", True))
        Me.ImponibileTextBox.Location = New System.Drawing.Point(368, 342)
        Me.ImponibileTextBox.Name = "ImponibileTextBox"
        Me.ImponibileTextBox.Size = New System.Drawing.Size(80, 20)
        Me.ImponibileTextBox.TabIndex = 44
        '
        'RitenutaTextBox
        '
        Me.RitenutaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_SpeseBindingSource, "Ritenuta", True))
        Me.RitenutaTextBox.Location = New System.Drawing.Point(454, 342)
        Me.RitenutaTextBox.Name = "RitenutaTextBox"
        Me.RitenutaTextBox.Size = New System.Drawing.Size(82, 20)
        Me.RitenutaTextBox.TabIndex = 46
        '
        'NettoTextBox
        '
        Me.NettoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_SpeseBindingSource, "Netto", True))
        Me.NettoTextBox.Location = New System.Drawing.Point(542, 342)
        Me.NettoTextBox.Name = "NettoTextBox"
        Me.NettoTextBox.Size = New System.Drawing.Size(84, 20)
        Me.NettoTextBox.TabIndex = 48
        '
        'QuadroAcTextBox
        '
        Me.QuadroAcTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_SpeseBindingSource, "QuadroAc", True))
        Me.QuadroAcTextBox.Location = New System.Drawing.Point(678, 223)
        Me.QuadroAcTextBox.Name = "QuadroAcTextBox"
        Me.QuadroAcTextBox.Size = New System.Drawing.Size(58, 20)
        Me.QuadroAcTextBox.TabIndex = 50
        '
        'DataPagamentoDateTimePicker
        '
        Me.DataPagamentoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.X_SpeseBindingSource, "DataPagamento", True))
        Me.DataPagamentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataPagamentoDateTimePicker.Location = New System.Drawing.Point(635, 342)
        Me.DataPagamentoDateTimePicker.Name = "DataPagamentoDateTimePicker"
        Me.DataPagamentoDateTimePicker.Size = New System.Drawing.Size(101, 20)
        Me.DataPagamentoDateTimePicker.TabIndex = 52
        '
        'X_SpeseDescrizioniBindingSource
        '
        Me.X_SpeseDescrizioniBindingSource.DataMember = "X_SpeseX_SpeseDescrizioni"
        Me.X_SpeseDescrizioniBindingSource.DataSource = Me.X_SpeseBindingSource
        '
        'X_SpeseDescrizioniDataGridView
        '
        Me.X_SpeseDescrizioniDataGridView.AutoGenerateColumns = False
        Me.X_SpeseDescrizioniDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.X_SpeseDescrizioniDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.X_SpeseDescrizioniDataGridView.DataSource = Me.X_SpeseDescrizioniBindingSource
        Me.X_SpeseDescrizioniDataGridView.Location = New System.Drawing.Point(18, 386)
        Me.X_SpeseDescrizioniDataGridView.Name = "X_SpeseDescrizioniDataGridView"
        Me.X_SpeseDescrizioniDataGridView.Size = New System.Drawing.Size(518, 220)
        Me.X_SpeseDescrizioniDataGridView.TabIndex = 53
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Riga"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Riga"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 50
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Descrizione"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Descrizione"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 240
        '
        'X_Spese
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 626)
        Me.Controls.Add(Me.X_SpeseDescrizioniDataGridView)
        Me.Controls.Add(DataPagamentoLabel)
        Me.Controls.Add(Me.DataPagamentoDateTimePicker)
        Me.Controls.Add(QuadroAcLabel)
        Me.Controls.Add(Me.QuadroAcTextBox)
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
        Me.Controls.Add(CodiceTributoLabel)
        Me.Controls.Add(Me.CodiceTributoTextBox)
        Me.Controls.Add(TrattamentoLabel)
        Me.Controls.Add(Me.TrattamentoComboBox)
        Me.Controls.Add(FatturaSaldataLabel)
        Me.Controls.Add(Me.FatturaSaldataTextBox)
        Me.Controls.Add(DataDocumentoLabel)
        Me.Controls.Add(Me.DataDocumentoDateTimePicker)
        Me.Controls.Add(ImportoSpesaLabel)
        Me.Controls.Add(Me.ImportoSpesaTextBox)
        Me.Controls.Add(QuantitaLabel)
        Me.Controls.Add(Me.QuantitaTextBox)
        Me.Controls.Add(FornitoreLabel)
        Me.Controls.Add(Me.FornitoreComboBox)
        Me.Controls.Add(DocumentoLabel)
        Me.Controls.Add(Me.DocumentoTextBox)
        Me.Controls.Add(UnitaLabel)
        Me.Controls.Add(Me.UnitaComboBox)
        Me.Controls.Add(SpesaLabel)
        Me.Controls.Add(Me.SpesaComboBox)
        Me.Controls.Add(GruppoLabel)
        Me.Controls.Add(Me.GruppoComboBox)
        Me.Controls.Add(ScalaLabel)
        Me.Controls.Add(Me.ScalaComboBox)
        Me.Controls.Add(FabbricatoLabel)
        Me.Controls.Add(Me.FabbricatoComboBox)
        Me.Controls.Add(GestioneLabel)
        Me.Controls.Add(Me.GestioneComboBox)
        Me.Controls.Add(ImmobileLabel)
        Me.Controls.Add(Me.ImmobileComboBox)
        Me.Controls.Add(ProgressivoLabel)
        Me.Controls.Add(Me.ProgressivoTextBox)
        Me.Controls.Add(Me.X_SpeseBindingNavigator)
        Me.Name = "X_Spese"
        Me.Text = "Archivio delle Spese"
        CType(Me.IMMOBILIDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X_SpeseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X_SpeseBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.X_SpeseBindingNavigator.ResumeLayout(False)
        Me.X_SpeseBindingNavigator.PerformLayout()
        CType(Me.X_SpeseDescrizioniBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X_SpeseDescrizioniDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IMMOBILIDataSet2 As Patrimonio2014.IMMOBILIDataSet2
    Friend WithEvents X_SpeseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents X_SpeseTableAdapter As Patrimonio2014.IMMOBILIDataSet2TableAdapters.X_SpeseTableAdapter
    Friend WithEvents TableAdapterManager As Patrimonio2014.IMMOBILIDataSet2TableAdapters.TableAdapterManager
    Friend WithEvents X_SpeseBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents X_SpeseBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ProgressivoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ImmobileComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GestioneComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FabbricatoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ScalaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GruppoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SpesaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents UnitaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DocumentoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FornitoreComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents QuantitaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ImportoSpesaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataDocumentoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents FatturaSaldataTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TrattamentoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CodiceTributoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CausaleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CompensoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EsenteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrevidenzaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IvaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ImponibileTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RitenutaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NettoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents X_SpeseDescrizioniTableAdapter As Patrimonio2014.IMMOBILIDataSet2TableAdapters.X_SpeseDescrizioniTableAdapter
    Friend WithEvents QuadroAcTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataPagamentoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents X_SpeseDescrizioniBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents X_SpeseDescrizioniDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
