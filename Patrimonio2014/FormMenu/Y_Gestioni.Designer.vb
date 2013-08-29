<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Y_Gestioni
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Y_Gestioni))
        Dim ImmobileLabel As System.Windows.Forms.Label
        Dim GestioneLabel As System.Windows.Forms.Label
        Dim Descrizione1Label As System.Windows.Forms.Label
        Dim TipoLabel As System.Windows.Forms.Label
        Dim DataInizioLabel As System.Windows.Forms.Label
        Dim DataTermineLabel As System.Windows.Forms.Label
        Dim TabellaLabel As System.Windows.Forms.Label
        Dim ImportoMinimoLabel As System.Windows.Forms.Label
        Dim ImportoMassimoLabel As System.Windows.Forms.Label
        Dim StoricoLabel As System.Windows.Forms.Label
        Dim GruppoAccontoLabel As System.Windows.Forms.Label
        Dim PercentoAccontoLabel As System.Windows.Forms.Label
        Dim GestioneSuccessivaLabel As System.Windows.Forms.Label
        Dim GestioneCollegataLabel As System.Windows.Forms.Label
        Dim PreventivoConfermatoLabel As System.Windows.Forms.Label
        Me.IMMOBILIDataSet2 = New Patrimonio2014.IMMOBILIDataSet2()
        Me.Y_GestioniBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Y_GestioniTableAdapter = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.Y_GestioniTableAdapter()
        Me.TableAdapterManager = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.TableAdapterManager()
        Me.Y_GestioniBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Y_GestioniBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ImmobileComboBox = New System.Windows.Forms.ComboBox()
        Me.GestioneComboBox = New System.Windows.Forms.ComboBox()
        Me.Descrizione1TextBox = New System.Windows.Forms.TextBox()
        Me.Descrizione2TextBox = New System.Windows.Forms.TextBox()
        Me.TipoTextBox = New System.Windows.Forms.TextBox()
        Me.DataInizioDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DataTermineDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TabellaComboBox = New System.Windows.Forms.ComboBox()
        Me.ImportoMinimoTextBox = New System.Windows.Forms.TextBox()
        Me.ImportoMassimoTextBox = New System.Windows.Forms.TextBox()
        Me.StoricoTextBox = New System.Windows.Forms.TextBox()
        Me.GruppoAccontoTextBox = New System.Windows.Forms.TextBox()
        Me.PercentoAccontoTextBox = New System.Windows.Forms.TextBox()
        Me.GestioneSuccessivaTextBox = New System.Windows.Forms.TextBox()
        Me.GestioneCollegataTextBox = New System.Windows.Forms.TextBox()
        Me.PreventivoConfermatoTextBox = New System.Windows.Forms.TextBox()
        Me.Y_GestioniDettaglioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Y_GestioniDettaglioTableAdapter = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.Y_GestioniDettaglioTableAdapter()
        Me.Y_GestioniDettaglioDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        ImmobileLabel = New System.Windows.Forms.Label()
        GestioneLabel = New System.Windows.Forms.Label()
        Descrizione1Label = New System.Windows.Forms.Label()
        TipoLabel = New System.Windows.Forms.Label()
        DataInizioLabel = New System.Windows.Forms.Label()
        DataTermineLabel = New System.Windows.Forms.Label()
        TabellaLabel = New System.Windows.Forms.Label()
        ImportoMinimoLabel = New System.Windows.Forms.Label()
        ImportoMassimoLabel = New System.Windows.Forms.Label()
        StoricoLabel = New System.Windows.Forms.Label()
        GruppoAccontoLabel = New System.Windows.Forms.Label()
        PercentoAccontoLabel = New System.Windows.Forms.Label()
        GestioneSuccessivaLabel = New System.Windows.Forms.Label()
        GestioneCollegataLabel = New System.Windows.Forms.Label()
        PreventivoConfermatoLabel = New System.Windows.Forms.Label()
        CType(Me.IMMOBILIDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Y_GestioniBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Y_GestioniBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Y_GestioniBindingNavigator.SuspendLayout()
        CType(Me.Y_GestioniDettaglioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Y_GestioniDettaglioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IMMOBILIDataSet2
        '
        Me.IMMOBILIDataSet2.DataSetName = "IMMOBILIDataSet2"
        Me.IMMOBILIDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Y_GestioniBindingSource
        '
        Me.Y_GestioniBindingSource.DataMember = "Y_Gestioni"
        Me.Y_GestioniBindingSource.DataSource = Me.IMMOBILIDataSet2
        '
        'Y_GestioniTableAdapter
        '
        Me.Y_GestioniTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Y_GestioniDettaglioTableAdapter = Me.Y_GestioniDettaglioTableAdapter
        Me.TableAdapterManager.Y_GestioniTableAdapter = Me.Y_GestioniTableAdapter
        Me.TableAdapterManager.Y_GestioniUnitaDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.Y_GestioniUnitaTableAdapter = Nothing
        Me.TableAdapterManager.Z_ConsuntivoDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.Z_ConsuntivoTableAdapter = Nothing
        Me.TableAdapterManager.Z_TestoSollecitoTableAdapter = Nothing
        '
        'Y_GestioniBindingNavigator
        '
        Me.Y_GestioniBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Y_GestioniBindingNavigator.BindingSource = Me.Y_GestioniBindingSource
        Me.Y_GestioniBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Y_GestioniBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Y_GestioniBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Y_GestioniBindingNavigatorSaveItem})
        Me.Y_GestioniBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Y_GestioniBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Y_GestioniBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Y_GestioniBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Y_GestioniBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Y_GestioniBindingNavigator.Name = "Y_GestioniBindingNavigator"
        Me.Y_GestioniBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Y_GestioniBindingNavigator.Size = New System.Drawing.Size(920, 25)
        Me.Y_GestioniBindingNavigator.TabIndex = 0
        Me.Y_GestioniBindingNavigator.Text = "BindingNavigator1"
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
        'Y_GestioniBindingNavigatorSaveItem
        '
        Me.Y_GestioniBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Y_GestioniBindingNavigatorSaveItem.Image = CType(resources.GetObject("Y_GestioniBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Y_GestioniBindingNavigatorSaveItem.Name = "Y_GestioniBindingNavigatorSaveItem"
        Me.Y_GestioniBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Y_GestioniBindingNavigatorSaveItem.Text = "Salva dati"
        '
        'ImmobileLabel
        '
        ImmobileLabel.AutoSize = True
        ImmobileLabel.Location = New System.Drawing.Point(12, 42)
        ImmobileLabel.Name = "ImmobileLabel"
        ImmobileLabel.Size = New System.Drawing.Size(51, 13)
        ImmobileLabel.TabIndex = 1
        ImmobileLabel.Text = "Immobile:"
        '
        'ImmobileComboBox
        '
        Me.ImmobileComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Y_GestioniBindingSource, "Immobile", True))
        Me.ImmobileComboBox.FormattingEnabled = True
        Me.ImmobileComboBox.Location = New System.Drawing.Point(15, 58)
        Me.ImmobileComboBox.Name = "ImmobileComboBox"
        Me.ImmobileComboBox.Size = New System.Drawing.Size(287, 21)
        Me.ImmobileComboBox.TabIndex = 2
        '
        'GestioneLabel
        '
        GestioneLabel.AutoSize = True
        GestioneLabel.Location = New System.Drawing.Point(308, 42)
        GestioneLabel.Name = "GestioneLabel"
        GestioneLabel.Size = New System.Drawing.Size(52, 13)
        GestioneLabel.TabIndex = 3
        GestioneLabel.Text = "Gestione:"
        '
        'GestioneComboBox
        '
        Me.GestioneComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Y_GestioniBindingSource, "Gestione", True))
        Me.GestioneComboBox.FormattingEnabled = True
        Me.GestioneComboBox.Location = New System.Drawing.Point(311, 58)
        Me.GestioneComboBox.Name = "GestioneComboBox"
        Me.GestioneComboBox.Size = New System.Drawing.Size(282, 21)
        Me.GestioneComboBox.TabIndex = 4
        '
        'Descrizione1Label
        '
        Descrizione1Label.AutoSize = True
        Descrizione1Label.Location = New System.Drawing.Point(12, 82)
        Descrizione1Label.Name = "Descrizione1Label"
        Descrizione1Label.Size = New System.Drawing.Size(65, 13)
        Descrizione1Label.TabIndex = 5
        Descrizione1Label.Text = "Descrizione:"
        '
        'Descrizione1TextBox
        '
        Me.Descrizione1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Y_GestioniBindingSource, "Descrizione1", True))
        Me.Descrizione1TextBox.Location = New System.Drawing.Point(15, 98)
        Me.Descrizione1TextBox.Name = "Descrizione1TextBox"
        Me.Descrizione1TextBox.Size = New System.Drawing.Size(287, 20)
        Me.Descrizione1TextBox.TabIndex = 6
        '
        'Descrizione2TextBox
        '
        Me.Descrizione2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Y_GestioniBindingSource, "Descrizione2", True))
        Me.Descrizione2TextBox.Location = New System.Drawing.Point(15, 123)
        Me.Descrizione2TextBox.Name = "Descrizione2TextBox"
        Me.Descrizione2TextBox.Size = New System.Drawing.Size(287, 20)
        Me.Descrizione2TextBox.TabIndex = 8
        '
        'TipoLabel
        '
        TipoLabel.AutoSize = True
        TipoLabel.Location = New System.Drawing.Point(308, 82)
        TipoLabel.Name = "TipoLabel"
        TipoLabel.Size = New System.Drawing.Size(31, 13)
        TipoLabel.TabIndex = 8
        TipoLabel.Text = "Tipo:"
        '
        'TipoTextBox
        '
        Me.TipoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Y_GestioniBindingSource, "Tipo", True))
        Me.TipoTextBox.Location = New System.Drawing.Point(311, 98)
        Me.TipoTextBox.Name = "TipoTextBox"
        Me.TipoTextBox.Size = New System.Drawing.Size(38, 20)
        Me.TipoTextBox.TabIndex = 9
        '
        'DataInizioLabel
        '
        DataInizioLabel.AutoSize = True
        DataInizioLabel.Location = New System.Drawing.Point(355, 82)
        DataInizioLabel.Name = "DataInizioLabel"
        DataInizioLabel.Size = New System.Drawing.Size(60, 13)
        DataInizioLabel.TabIndex = 10
        DataInizioLabel.Text = "Data Inizio:"
        '
        'DataInizioDateTimePicker
        '
        Me.DataInizioDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Y_GestioniBindingSource, "DataInizio", True))
        Me.DataInizioDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataInizioDateTimePicker.Location = New System.Drawing.Point(358, 98)
        Me.DataInizioDateTimePicker.Name = "DataInizioDateTimePicker"
        Me.DataInizioDateTimePicker.Size = New System.Drawing.Size(93, 20)
        Me.DataInizioDateTimePicker.TabIndex = 11
        '
        'DataTermineLabel
        '
        DataTermineLabel.AutoSize = True
        DataTermineLabel.Location = New System.Drawing.Point(457, 82)
        DataTermineLabel.Name = "DataTermineLabel"
        DataTermineLabel.Size = New System.Drawing.Size(74, 13)
        DataTermineLabel.TabIndex = 12
        DataTermineLabel.Text = "Data Termine:"
        '
        'DataTermineDateTimePicker
        '
        Me.DataTermineDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Y_GestioniBindingSource, "DataTermine", True))
        Me.DataTermineDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataTermineDateTimePicker.Location = New System.Drawing.Point(460, 98)
        Me.DataTermineDateTimePicker.Name = "DataTermineDateTimePicker"
        Me.DataTermineDateTimePicker.Size = New System.Drawing.Size(95, 20)
        Me.DataTermineDateTimePicker.TabIndex = 13
        '
        'TabellaLabel
        '
        TabellaLabel.AutoSize = True
        TabellaLabel.Location = New System.Drawing.Point(561, 82)
        TabellaLabel.Name = "TabellaLabel"
        TabellaLabel.Size = New System.Drawing.Size(45, 13)
        TabellaLabel.TabIndex = 14
        TabellaLabel.Text = "Tabella:"
        '
        'TabellaComboBox
        '
        Me.TabellaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Y_GestioniBindingSource, "Tabella", True))
        Me.TabellaComboBox.FormattingEnabled = True
        Me.TabellaComboBox.Location = New System.Drawing.Point(564, 97)
        Me.TabellaComboBox.Name = "TabellaComboBox"
        Me.TabellaComboBox.Size = New System.Drawing.Size(187, 21)
        Me.TabellaComboBox.TabIndex = 16
        '
        'ImportoMinimoLabel
        '
        ImportoMinimoLabel.AutoSize = True
        ImportoMinimoLabel.Location = New System.Drawing.Point(12, 151)
        ImportoMinimoLabel.Name = "ImportoMinimoLabel"
        ImportoMinimoLabel.Size = New System.Drawing.Size(81, 13)
        ImportoMinimoLabel.TabIndex = 16
        ImportoMinimoLabel.Text = "Importo Minimo:"
        '
        'ImportoMinimoTextBox
        '
        Me.ImportoMinimoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Y_GestioniBindingSource, "ImportoMinimo", True))
        Me.ImportoMinimoTextBox.Location = New System.Drawing.Point(15, 167)
        Me.ImportoMinimoTextBox.Name = "ImportoMinimoTextBox"
        Me.ImportoMinimoTextBox.Size = New System.Drawing.Size(98, 20)
        Me.ImportoMinimoTextBox.TabIndex = 17
        '
        'ImportoMassimoLabel
        '
        ImportoMassimoLabel.AutoSize = True
        ImportoMassimoLabel.Location = New System.Drawing.Point(116, 151)
        ImportoMassimoLabel.Name = "ImportoMassimoLabel"
        ImportoMassimoLabel.Size = New System.Drawing.Size(89, 13)
        ImportoMassimoLabel.TabIndex = 18
        ImportoMassimoLabel.Text = "Importo Massimo:"
        '
        'ImportoMassimoTextBox
        '
        Me.ImportoMassimoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Y_GestioniBindingSource, "ImportoMassimo", True))
        Me.ImportoMassimoTextBox.Location = New System.Drawing.Point(119, 167)
        Me.ImportoMassimoTextBox.Name = "ImportoMassimoTextBox"
        Me.ImportoMassimoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ImportoMassimoTextBox.TabIndex = 19
        '
        'StoricoLabel
        '
        StoricoLabel.AutoSize = True
        StoricoLabel.Location = New System.Drawing.Point(232, 151)
        StoricoLabel.Name = "StoricoLabel"
        StoricoLabel.Size = New System.Drawing.Size(43, 13)
        StoricoLabel.TabIndex = 20
        StoricoLabel.Text = "Storico:"
        '
        'StoricoTextBox
        '
        Me.StoricoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Y_GestioniBindingSource, "Storico", True))
        Me.StoricoTextBox.Location = New System.Drawing.Point(235, 167)
        Me.StoricoTextBox.Name = "StoricoTextBox"
        Me.StoricoTextBox.Size = New System.Drawing.Size(40, 20)
        Me.StoricoTextBox.TabIndex = 21
        '
        'GruppoAccontoLabel
        '
        GruppoAccontoLabel.AutoSize = True
        GruppoAccontoLabel.Location = New System.Drawing.Point(281, 151)
        GruppoAccontoLabel.Name = "GruppoAccontoLabel"
        GruppoAccontoLabel.Size = New System.Drawing.Size(88, 13)
        GruppoAccontoLabel.TabIndex = 22
        GruppoAccontoLabel.Text = "Gruppo Acconto:"
        '
        'GruppoAccontoTextBox
        '
        Me.GruppoAccontoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Y_GestioniBindingSource, "GruppoAcconto", True))
        Me.GruppoAccontoTextBox.Location = New System.Drawing.Point(284, 167)
        Me.GruppoAccontoTextBox.Name = "GruppoAccontoTextBox"
        Me.GruppoAccontoTextBox.Size = New System.Drawing.Size(85, 20)
        Me.GruppoAccontoTextBox.TabIndex = 23
        '
        'PercentoAccontoLabel
        '
        PercentoAccontoLabel.AutoSize = True
        PercentoAccontoLabel.Location = New System.Drawing.Point(375, 151)
        PercentoAccontoLabel.Name = "PercentoAccontoLabel"
        PercentoAccontoLabel.Size = New System.Drawing.Size(61, 13)
        PercentoAccontoLabel.TabIndex = 24
        PercentoAccontoLabel.Text = "% Acconto:"
        '
        'PercentoAccontoTextBox
        '
        Me.PercentoAccontoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Y_GestioniBindingSource, "PercentoAcconto", True))
        Me.PercentoAccontoTextBox.Location = New System.Drawing.Point(378, 167)
        Me.PercentoAccontoTextBox.Name = "PercentoAccontoTextBox"
        Me.PercentoAccontoTextBox.Size = New System.Drawing.Size(58, 20)
        Me.PercentoAccontoTextBox.TabIndex = 25
        '
        'GestioneSuccessivaLabel
        '
        GestioneSuccessivaLabel.AutoSize = True
        GestioneSuccessivaLabel.Location = New System.Drawing.Point(445, 151)
        GestioneSuccessivaLabel.Name = "GestioneSuccessivaLabel"
        GestioneSuccessivaLabel.Size = New System.Drawing.Size(110, 13)
        GestioneSuccessivaLabel.TabIndex = 26
        GestioneSuccessivaLabel.Text = "Gestione Successiva:"
        '
        'GestioneSuccessivaTextBox
        '
        Me.GestioneSuccessivaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Y_GestioniBindingSource, "GestioneSuccessiva", True))
        Me.GestioneSuccessivaTextBox.Location = New System.Drawing.Point(448, 167)
        Me.GestioneSuccessivaTextBox.Name = "GestioneSuccessivaTextBox"
        Me.GestioneSuccessivaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.GestioneSuccessivaTextBox.TabIndex = 27
        '
        'GestioneCollegataLabel
        '
        GestioneCollegataLabel.AutoSize = True
        GestioneCollegataLabel.Location = New System.Drawing.Point(560, 151)
        GestioneCollegataLabel.Name = "GestioneCollegataLabel"
        GestioneCollegataLabel.Size = New System.Drawing.Size(99, 13)
        GestioneCollegataLabel.TabIndex = 28
        GestioneCollegataLabel.Text = "Gestione Collegata:"
        '
        'GestioneCollegataTextBox
        '
        Me.GestioneCollegataTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Y_GestioniBindingSource, "GestioneCollegata", True))
        Me.GestioneCollegataTextBox.Location = New System.Drawing.Point(563, 167)
        Me.GestioneCollegataTextBox.Name = "GestioneCollegataTextBox"
        Me.GestioneCollegataTextBox.Size = New System.Drawing.Size(100, 20)
        Me.GestioneCollegataTextBox.TabIndex = 29
        '
        'PreventivoConfermatoLabel
        '
        PreventivoConfermatoLabel.AutoSize = True
        PreventivoConfermatoLabel.Location = New System.Drawing.Point(669, 151)
        PreventivoConfermatoLabel.Name = "PreventivoConfermatoLabel"
        PreventivoConfermatoLabel.Size = New System.Drawing.Size(118, 13)
        PreventivoConfermatoLabel.TabIndex = 30
        PreventivoConfermatoLabel.Text = "Preventivo Confermato:"
        '
        'PreventivoConfermatoTextBox
        '
        Me.PreventivoConfermatoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Y_GestioniBindingSource, "PreventivoConfermato", True))
        Me.PreventivoConfermatoTextBox.Location = New System.Drawing.Point(712, 167)
        Me.PreventivoConfermatoTextBox.Name = "PreventivoConfermatoTextBox"
        Me.PreventivoConfermatoTextBox.Size = New System.Drawing.Size(31, 20)
        Me.PreventivoConfermatoTextBox.TabIndex = 31
        '
        'Y_GestioniDettaglioBindingSource
        '
        Me.Y_GestioniDettaglioBindingSource.DataMember = "Y_GestioniDettaglio"
        Me.Y_GestioniDettaglioBindingSource.DataSource = Me.IMMOBILIDataSet2
        '
        'Y_GestioniDettaglioTableAdapter
        '
        Me.Y_GestioniDettaglioTableAdapter.ClearBeforeFill = True
        '
        'Y_GestioniDettaglioDataGridView
        '
        Me.Y_GestioniDettaglioDataGridView.AutoGenerateColumns = False
        Me.Y_GestioniDettaglioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Y_GestioniDettaglioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.Y_GestioniDettaglioDataGridView.DataSource = Me.Y_GestioniDettaglioBindingSource
        Me.Y_GestioniDettaglioDataGridView.Location = New System.Drawing.Point(18, 215)
        Me.Y_GestioniDettaglioDataGridView.Name = "Y_GestioniDettaglioDataGridView"
        Me.Y_GestioniDettaglioDataGridView.Size = New System.Drawing.Size(537, 220)
        Me.Y_GestioniDettaglioDataGridView.TabIndex = 32
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Riga"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Riga"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 50
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PercentoRata"
        Me.DataGridViewTextBoxColumn4.HeaderText = "PercentoRata"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DataRata"
        Me.DataGridViewTextBoxColumn5.HeaderText = "DataRata"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "RataGenerata"
        Me.DataGridViewTextBoxColumn6.HeaderText = "RataGenerata"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "RataEmessa"
        Me.DataGridViewTextBoxColumn7.HeaderText = "RataEmessa"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'Y_Gestioni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 455)
        Me.Controls.Add(Me.Y_GestioniDettaglioDataGridView)
        Me.Controls.Add(PreventivoConfermatoLabel)
        Me.Controls.Add(Me.PreventivoConfermatoTextBox)
        Me.Controls.Add(GestioneCollegataLabel)
        Me.Controls.Add(Me.GestioneCollegataTextBox)
        Me.Controls.Add(GestioneSuccessivaLabel)
        Me.Controls.Add(Me.GestioneSuccessivaTextBox)
        Me.Controls.Add(PercentoAccontoLabel)
        Me.Controls.Add(Me.PercentoAccontoTextBox)
        Me.Controls.Add(GruppoAccontoLabel)
        Me.Controls.Add(Me.GruppoAccontoTextBox)
        Me.Controls.Add(StoricoLabel)
        Me.Controls.Add(Me.StoricoTextBox)
        Me.Controls.Add(ImportoMassimoLabel)
        Me.Controls.Add(Me.ImportoMassimoTextBox)
        Me.Controls.Add(ImportoMinimoLabel)
        Me.Controls.Add(Me.ImportoMinimoTextBox)
        Me.Controls.Add(Me.TabellaComboBox)
        Me.Controls.Add(TabellaLabel)
        Me.Controls.Add(DataTermineLabel)
        Me.Controls.Add(Me.DataTermineDateTimePicker)
        Me.Controls.Add(DataInizioLabel)
        Me.Controls.Add(Me.DataInizioDateTimePicker)
        Me.Controls.Add(TipoLabel)
        Me.Controls.Add(Me.TipoTextBox)
        Me.Controls.Add(Me.Descrizione2TextBox)
        Me.Controls.Add(Descrizione1Label)
        Me.Controls.Add(Me.Descrizione1TextBox)
        Me.Controls.Add(GestioneLabel)
        Me.Controls.Add(Me.GestioneComboBox)
        Me.Controls.Add(ImmobileLabel)
        Me.Controls.Add(Me.ImmobileComboBox)
        Me.Controls.Add(Me.Y_GestioniBindingNavigator)
        Me.Name = "Y_Gestioni"
        Me.Text = "Archivio delle Gestioni"
        CType(Me.IMMOBILIDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Y_GestioniBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Y_GestioniBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Y_GestioniBindingNavigator.ResumeLayout(False)
        Me.Y_GestioniBindingNavigator.PerformLayout()
        CType(Me.Y_GestioniDettaglioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Y_GestioniDettaglioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IMMOBILIDataSet2 As Patrimonio2014.IMMOBILIDataSet2
    Friend WithEvents Y_GestioniBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Y_GestioniTableAdapter As Patrimonio2014.IMMOBILIDataSet2TableAdapters.Y_GestioniTableAdapter
    Friend WithEvents TableAdapterManager As Patrimonio2014.IMMOBILIDataSet2TableAdapters.TableAdapterManager
    Friend WithEvents Y_GestioniBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Y_GestioniBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Y_GestioniDettaglioTableAdapter As Patrimonio2014.IMMOBILIDataSet2TableAdapters.Y_GestioniDettaglioTableAdapter
    Friend WithEvents ImmobileComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GestioneComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Descrizione1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Descrizione2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents TipoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataInizioDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataTermineDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TabellaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ImportoMinimoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ImportoMassimoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StoricoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GruppoAccontoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PercentoAccontoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GestioneSuccessivaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GestioneCollegataTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PreventivoConfermatoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Y_GestioniDettaglioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Y_GestioniDettaglioDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
