<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class X_MovimentiFinanziari
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(X_MovimentiFinanziari))
        Dim ContoLabel As System.Windows.Forms.Label
        Dim ImmobileLabel As System.Windows.Forms.Label
        Dim DataMovimentoLabel As System.Windows.Forms.Label
        Dim OperazioneLabel As System.Windows.Forms.Label
        Dim DataRiferimentoLabel As System.Windows.Forms.Label
        Dim ImportoLabel As System.Windows.Forms.Label
        Dim DescrizioneLabel As System.Windows.Forms.Label
        Dim MarkerLabel As System.Windows.Forms.Label
        Me.IMMOBILIDataSet2 = New Patrimonio2014.IMMOBILIDataSet2()
        Me.X_MovimentiFinanziariBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.X_MovimentiFinanziariTableAdapter = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.X_MovimentiFinanziariTableAdapter()
        Me.TableAdapterManager = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.TableAdapterManager()
        Me.X_MovimentiFinanziariBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.X_MovimentiFinanziariBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ProgressivoTextBox = New System.Windows.Forms.TextBox()
        Me.ContoComboBox = New System.Windows.Forms.ComboBox()
        Me.ImmobileComboBox = New System.Windows.Forms.ComboBox()
        Me.DataMovimentoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.OperazioneTextBox = New System.Windows.Forms.TextBox()
        Me.DataRiferimentoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ImportoTextBox = New System.Windows.Forms.TextBox()
        Me.DescrizioneTextBox = New System.Windows.Forms.TextBox()
        Me.MarkerTextBox = New System.Windows.Forms.TextBox()
        ProgressivoLabel = New System.Windows.Forms.Label()
        ContoLabel = New System.Windows.Forms.Label()
        ImmobileLabel = New System.Windows.Forms.Label()
        DataMovimentoLabel = New System.Windows.Forms.Label()
        OperazioneLabel = New System.Windows.Forms.Label()
        DataRiferimentoLabel = New System.Windows.Forms.Label()
        ImportoLabel = New System.Windows.Forms.Label()
        DescrizioneLabel = New System.Windows.Forms.Label()
        MarkerLabel = New System.Windows.Forms.Label()
        CType(Me.IMMOBILIDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X_MovimentiFinanziariBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X_MovimentiFinanziariBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.X_MovimentiFinanziariBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProgressivoLabel
        '
        ProgressivoLabel.AutoSize = True
        ProgressivoLabel.Location = New System.Drawing.Point(10, 37)
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
        'X_MovimentiFinanziariBindingSource
        '
        Me.X_MovimentiFinanziariBindingSource.DataMember = "X_MovimentiFinanziari"
        Me.X_MovimentiFinanziariBindingSource.DataSource = Me.IMMOBILIDataSet2
        '
        'X_MovimentiFinanziariTableAdapter
        '
        Me.X_MovimentiFinanziariTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.W_RitenuteTableAdapter = Nothing
        Me.TableAdapterManager.W_TributiTableAdapter = Nothing
        Me.TableAdapterManager.X_CausaliTableAdapter = Nothing
        Me.TableAdapterManager.X_FattureDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.X_FattureTableAdapter = Nothing
        Me.TableAdapterManager.X_MovimentiCondominiTableAdapter = Nothing
        Me.TableAdapterManager.X_MovimentiFinanziariTableAdapter = Me.X_MovimentiFinanziariTableAdapter
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
        'X_MovimentiFinanziariBindingNavigator
        '
        Me.X_MovimentiFinanziariBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.X_MovimentiFinanziariBindingNavigator.BindingSource = Me.X_MovimentiFinanziariBindingSource
        Me.X_MovimentiFinanziariBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.X_MovimentiFinanziariBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.X_MovimentiFinanziariBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.X_MovimentiFinanziariBindingNavigatorSaveItem})
        Me.X_MovimentiFinanziariBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.X_MovimentiFinanziariBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.X_MovimentiFinanziariBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.X_MovimentiFinanziariBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.X_MovimentiFinanziariBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.X_MovimentiFinanziariBindingNavigator.Name = "X_MovimentiFinanziariBindingNavigator"
        Me.X_MovimentiFinanziariBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.X_MovimentiFinanziariBindingNavigator.Size = New System.Drawing.Size(661, 25)
        Me.X_MovimentiFinanziariBindingNavigator.TabIndex = 0
        Me.X_MovimentiFinanziariBindingNavigator.Text = "BindingNavigator1"
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
        'X_MovimentiFinanziariBindingNavigatorSaveItem
        '
        Me.X_MovimentiFinanziariBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.X_MovimentiFinanziariBindingNavigatorSaveItem.Image = CType(resources.GetObject("X_MovimentiFinanziariBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.X_MovimentiFinanziariBindingNavigatorSaveItem.Name = "X_MovimentiFinanziariBindingNavigatorSaveItem"
        Me.X_MovimentiFinanziariBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.X_MovimentiFinanziariBindingNavigatorSaveItem.Text = "Salva dati"
        '
        'ProgressivoTextBox
        '
        Me.ProgressivoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_MovimentiFinanziariBindingSource, "Progressivo", True))
        Me.ProgressivoTextBox.Location = New System.Drawing.Point(13, 53)
        Me.ProgressivoTextBox.Name = "ProgressivoTextBox"
        Me.ProgressivoTextBox.Size = New System.Drawing.Size(72, 20)
        Me.ProgressivoTextBox.TabIndex = 2
        '
        'ContoLabel
        '
        ContoLabel.AutoSize = True
        ContoLabel.Location = New System.Drawing.Point(91, 37)
        ContoLabel.Name = "ContoLabel"
        ContoLabel.Size = New System.Drawing.Size(38, 13)
        ContoLabel.TabIndex = 3
        ContoLabel.Text = "Conto:"
        '
        'ContoComboBox
        '
        Me.ContoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_MovimentiFinanziariBindingSource, "Conto", True))
        Me.ContoComboBox.FormattingEnabled = True
        Me.ContoComboBox.Location = New System.Drawing.Point(94, 53)
        Me.ContoComboBox.Name = "ContoComboBox"
        Me.ContoComboBox.Size = New System.Drawing.Size(246, 21)
        Me.ContoComboBox.TabIndex = 4
        '
        'ImmobileLabel
        '
        ImmobileLabel.AutoSize = True
        ImmobileLabel.Location = New System.Drawing.Point(346, 37)
        ImmobileLabel.Name = "ImmobileLabel"
        ImmobileLabel.Size = New System.Drawing.Size(51, 13)
        ImmobileLabel.TabIndex = 5
        ImmobileLabel.Text = "Immobile:"
        '
        'ImmobileComboBox
        '
        Me.ImmobileComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_MovimentiFinanziariBindingSource, "Immobile", True))
        Me.ImmobileComboBox.FormattingEnabled = True
        Me.ImmobileComboBox.Location = New System.Drawing.Point(349, 53)
        Me.ImmobileComboBox.Name = "ImmobileComboBox"
        Me.ImmobileComboBox.Size = New System.Drawing.Size(252, 21)
        Me.ImmobileComboBox.TabIndex = 6
        '
        'DataMovimentoLabel
        '
        DataMovimentoLabel.AutoSize = True
        DataMovimentoLabel.Location = New System.Drawing.Point(12, 87)
        DataMovimentoLabel.Name = "DataMovimentoLabel"
        DataMovimentoLabel.Size = New System.Drawing.Size(88, 13)
        DataMovimentoLabel.TabIndex = 7
        DataMovimentoLabel.Text = "Data Movimento:"
        '
        'DataMovimentoDateTimePicker
        '
        Me.DataMovimentoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.X_MovimentiFinanziariBindingSource, "DataMovimento", True))
        Me.DataMovimentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataMovimentoDateTimePicker.Location = New System.Drawing.Point(12, 103)
        Me.DataMovimentoDateTimePicker.Name = "DataMovimentoDateTimePicker"
        Me.DataMovimentoDateTimePicker.Size = New System.Drawing.Size(83, 20)
        Me.DataMovimentoDateTimePicker.TabIndex = 8
        '
        'OperazioneLabel
        '
        OperazioneLabel.AutoSize = True
        OperazioneLabel.Location = New System.Drawing.Point(106, 87)
        OperazioneLabel.Name = "OperazioneLabel"
        OperazioneLabel.Size = New System.Drawing.Size(64, 13)
        OperazioneLabel.TabIndex = 9
        OperazioneLabel.Text = "Operazione:"
        '
        'OperazioneTextBox
        '
        Me.OperazioneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_MovimentiFinanziariBindingSource, "Operazione", True))
        Me.OperazioneTextBox.Location = New System.Drawing.Point(109, 103)
        Me.OperazioneTextBox.Name = "OperazioneTextBox"
        Me.OperazioneTextBox.Size = New System.Drawing.Size(61, 20)
        Me.OperazioneTextBox.TabIndex = 10
        '
        'DataRiferimentoLabel
        '
        DataRiferimentoLabel.AutoSize = True
        DataRiferimentoLabel.Location = New System.Drawing.Point(176, 87)
        DataRiferimentoLabel.Name = "DataRiferimentoLabel"
        DataRiferimentoLabel.Size = New System.Drawing.Size(89, 13)
        DataRiferimentoLabel.TabIndex = 11
        DataRiferimentoLabel.Text = "Data Riferimento:"
        '
        'DataRiferimentoDateTimePicker
        '
        Me.DataRiferimentoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.X_MovimentiFinanziariBindingSource, "DataRiferimento", True))
        Me.DataRiferimentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataRiferimentoDateTimePicker.Location = New System.Drawing.Point(179, 103)
        Me.DataRiferimentoDateTimePicker.Name = "DataRiferimentoDateTimePicker"
        Me.DataRiferimentoDateTimePicker.Size = New System.Drawing.Size(84, 20)
        Me.DataRiferimentoDateTimePicker.TabIndex = 12
        '
        'ImportoLabel
        '
        ImportoLabel.AutoSize = True
        ImportoLabel.Location = New System.Drawing.Point(271, 87)
        ImportoLabel.Name = "ImportoLabel"
        ImportoLabel.Size = New System.Drawing.Size(45, 13)
        ImportoLabel.TabIndex = 13
        ImportoLabel.Text = "Importo:"
        '
        'ImportoTextBox
        '
        Me.ImportoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_MovimentiFinanziariBindingSource, "Importo", True))
        Me.ImportoTextBox.Location = New System.Drawing.Point(274, 103)
        Me.ImportoTextBox.Name = "ImportoTextBox"
        Me.ImportoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ImportoTextBox.TabIndex = 14
        '
        'DescrizioneLabel
        '
        DescrizioneLabel.AutoSize = True
        DescrizioneLabel.Location = New System.Drawing.Point(376, 87)
        DescrizioneLabel.Name = "DescrizioneLabel"
        DescrizioneLabel.Size = New System.Drawing.Size(65, 13)
        DescrizioneLabel.TabIndex = 15
        DescrizioneLabel.Text = "Descrizione:"
        '
        'DescrizioneTextBox
        '
        Me.DescrizioneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_MovimentiFinanziariBindingSource, "Descrizione", True))
        Me.DescrizioneTextBox.Location = New System.Drawing.Point(380, 103)
        Me.DescrizioneTextBox.Name = "DescrizioneTextBox"
        Me.DescrizioneTextBox.Size = New System.Drawing.Size(221, 20)
        Me.DescrizioneTextBox.TabIndex = 16
        '
        'MarkerLabel
        '
        MarkerLabel.AutoSize = True
        MarkerLabel.Location = New System.Drawing.Point(612, 87)
        MarkerLabel.Name = "MarkerLabel"
        MarkerLabel.Size = New System.Drawing.Size(43, 13)
        MarkerLabel.TabIndex = 17
        MarkerLabel.Text = "Marker:"
        '
        'MarkerTextBox
        '
        Me.MarkerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_MovimentiFinanziariBindingSource, "Marker", True))
        Me.MarkerTextBox.Location = New System.Drawing.Point(615, 103)
        Me.MarkerTextBox.Name = "MarkerTextBox"
        Me.MarkerTextBox.Size = New System.Drawing.Size(40, 20)
        Me.MarkerTextBox.TabIndex = 18
        '
        'X_MovimentiFinanziari
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 159)
        Me.Controls.Add(MarkerLabel)
        Me.Controls.Add(Me.MarkerTextBox)
        Me.Controls.Add(DescrizioneLabel)
        Me.Controls.Add(Me.DescrizioneTextBox)
        Me.Controls.Add(ImportoLabel)
        Me.Controls.Add(Me.ImportoTextBox)
        Me.Controls.Add(DataRiferimentoLabel)
        Me.Controls.Add(Me.DataRiferimentoDateTimePicker)
        Me.Controls.Add(OperazioneLabel)
        Me.Controls.Add(Me.OperazioneTextBox)
        Me.Controls.Add(DataMovimentoLabel)
        Me.Controls.Add(Me.DataMovimentoDateTimePicker)
        Me.Controls.Add(ImmobileLabel)
        Me.Controls.Add(Me.ImmobileComboBox)
        Me.Controls.Add(ContoLabel)
        Me.Controls.Add(Me.ContoComboBox)
        Me.Controls.Add(ProgressivoLabel)
        Me.Controls.Add(Me.ProgressivoTextBox)
        Me.Controls.Add(Me.X_MovimentiFinanziariBindingNavigator)
        Me.Name = "X_MovimentiFinanziari"
        Me.Text = "Movimenti Finanziari"
        CType(Me.IMMOBILIDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X_MovimentiFinanziariBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X_MovimentiFinanziariBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.X_MovimentiFinanziariBindingNavigator.ResumeLayout(False)
        Me.X_MovimentiFinanziariBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IMMOBILIDataSet2 As Patrimonio2014.IMMOBILIDataSet2
    Friend WithEvents X_MovimentiFinanziariBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents X_MovimentiFinanziariTableAdapter As Patrimonio2014.IMMOBILIDataSet2TableAdapters.X_MovimentiFinanziariTableAdapter
    Friend WithEvents TableAdapterManager As Patrimonio2014.IMMOBILIDataSet2TableAdapters.TableAdapterManager
    Friend WithEvents X_MovimentiFinanziariBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents X_MovimentiFinanziariBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ProgressivoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ImmobileComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DataMovimentoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents OperazioneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataRiferimentoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ImportoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescrizioneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MarkerTextBox As System.Windows.Forms.TextBox
End Class
