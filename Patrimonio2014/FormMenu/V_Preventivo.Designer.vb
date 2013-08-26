<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class V_Preventivo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(V_Preventivo))
        Dim ImmobileLabel As System.Windows.Forms.Label
        Dim GestioneLabel As System.Windows.Forms.Label
        Dim GruppoLabel As System.Windows.Forms.Label
        Dim SpesaLabel As System.Windows.Forms.Label
        Dim ImportoLabel As System.Windows.Forms.Label
        Dim PianoContiLabel As System.Windows.Forms.Label
        Me.IMMOBILIDataSet2 = New Patrimonio2014.IMMOBILIDataSet2()
        Me.V_PreventivoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.V_PreventivoTableAdapter = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.V_PreventivoTableAdapter()
        Me.TableAdapterManager = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.TableAdapterManager()
        Me.V_PreventivoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.V_PreventivoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ImmobileComboBox = New System.Windows.Forms.ComboBox()
        Me.GestioneComboBox = New System.Windows.Forms.ComboBox()
        Me.GruppoComboBox = New System.Windows.Forms.ComboBox()
        Me.SpesaComboBox = New System.Windows.Forms.ComboBox()
        Me.ImportoTextBox = New System.Windows.Forms.TextBox()
        Me.PianoContiComboBox = New System.Windows.Forms.ComboBox()
        Me.V_PreventivoDettaglioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.V_PreventivoDettaglioTableAdapter = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.V_PreventivoDettaglioTableAdapter()
        Me.V_PreventivoDettaglioDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        ImmobileLabel = New System.Windows.Forms.Label()
        GestioneLabel = New System.Windows.Forms.Label()
        GruppoLabel = New System.Windows.Forms.Label()
        SpesaLabel = New System.Windows.Forms.Label()
        ImportoLabel = New System.Windows.Forms.Label()
        PianoContiLabel = New System.Windows.Forms.Label()
        CType(Me.IMMOBILIDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.V_PreventivoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.V_PreventivoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.V_PreventivoBindingNavigator.SuspendLayout()
        CType(Me.V_PreventivoDettaglioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.V_PreventivoDettaglioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IMMOBILIDataSet2
        '
        Me.IMMOBILIDataSet2.DataSetName = "IMMOBILIDataSet2"
        Me.IMMOBILIDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'V_PreventivoBindingSource
        '
        Me.V_PreventivoBindingSource.DataMember = "V_Preventivo"
        Me.V_PreventivoBindingSource.DataSource = Me.IMMOBILIDataSet2
        '
        'V_PreventivoTableAdapter
        '
        Me.V_PreventivoTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.V_PreventivoDettaglioTableAdapter = Me.V_PreventivoDettaglioTableAdapter
        Me.TableAdapterManager.V_PreventivoTableAdapter = Me.V_PreventivoTableAdapter
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
        'V_PreventivoBindingNavigator
        '
        Me.V_PreventivoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.V_PreventivoBindingNavigator.BindingSource = Me.V_PreventivoBindingSource
        Me.V_PreventivoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.V_PreventivoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.V_PreventivoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.V_PreventivoBindingNavigatorSaveItem})
        Me.V_PreventivoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.V_PreventivoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.V_PreventivoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.V_PreventivoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.V_PreventivoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.V_PreventivoBindingNavigator.Name = "V_PreventivoBindingNavigator"
        Me.V_PreventivoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.V_PreventivoBindingNavigator.Size = New System.Drawing.Size(762, 25)
        Me.V_PreventivoBindingNavigator.TabIndex = 0
        Me.V_PreventivoBindingNavigator.Text = "BindingNavigator1"
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
        'V_PreventivoBindingNavigatorSaveItem
        '
        Me.V_PreventivoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.V_PreventivoBindingNavigatorSaveItem.Image = CType(resources.GetObject("V_PreventivoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.V_PreventivoBindingNavigatorSaveItem.Name = "V_PreventivoBindingNavigatorSaveItem"
        Me.V_PreventivoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.V_PreventivoBindingNavigatorSaveItem.Text = "Salva dati"
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
        Me.ImmobileComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.V_PreventivoBindingSource, "Immobile", True))
        Me.ImmobileComboBox.FormattingEnabled = True
        Me.ImmobileComboBox.Location = New System.Drawing.Point(15, 53)
        Me.ImmobileComboBox.Name = "ImmobileComboBox"
        Me.ImmobileComboBox.Size = New System.Drawing.Size(258, 21)
        Me.ImmobileComboBox.TabIndex = 2
        '
        'GestioneLabel
        '
        GestioneLabel.AutoSize = True
        GestioneLabel.Location = New System.Drawing.Point(279, 37)
        GestioneLabel.Name = "GestioneLabel"
        GestioneLabel.Size = New System.Drawing.Size(52, 13)
        GestioneLabel.TabIndex = 3
        GestioneLabel.Text = "Gestione:"
        '
        'GestioneComboBox
        '
        Me.GestioneComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.V_PreventivoBindingSource, "Gestione", True))
        Me.GestioneComboBox.FormattingEnabled = True
        Me.GestioneComboBox.Location = New System.Drawing.Point(282, 53)
        Me.GestioneComboBox.Name = "GestioneComboBox"
        Me.GestioneComboBox.Size = New System.Drawing.Size(234, 21)
        Me.GestioneComboBox.TabIndex = 4
        '
        'GruppoLabel
        '
        GruppoLabel.AutoSize = True
        GruppoLabel.Location = New System.Drawing.Point(12, 77)
        GruppoLabel.Name = "GruppoLabel"
        GruppoLabel.Size = New System.Drawing.Size(45, 13)
        GruppoLabel.TabIndex = 5
        GruppoLabel.Text = "Gruppo:"
        AddHandler GruppoLabel.Click, AddressOf Me.GruppoLabel_Click
        '
        'GruppoComboBox
        '
        Me.GruppoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.V_PreventivoBindingSource, "Gruppo", True))
        Me.GruppoComboBox.FormattingEnabled = True
        Me.GruppoComboBox.Location = New System.Drawing.Point(15, 93)
        Me.GruppoComboBox.Name = "GruppoComboBox"
        Me.GruppoComboBox.Size = New System.Drawing.Size(258, 21)
        Me.GruppoComboBox.TabIndex = 6
        '
        'SpesaLabel
        '
        SpesaLabel.AutoSize = True
        SpesaLabel.Location = New System.Drawing.Point(279, 77)
        SpesaLabel.Name = "SpesaLabel"
        SpesaLabel.Size = New System.Drawing.Size(40, 13)
        SpesaLabel.TabIndex = 7
        SpesaLabel.Text = "Spesa:"
        '
        'SpesaComboBox
        '
        Me.SpesaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.V_PreventivoBindingSource, "Spesa", True))
        Me.SpesaComboBox.FormattingEnabled = True
        Me.SpesaComboBox.Location = New System.Drawing.Point(282, 93)
        Me.SpesaComboBox.Name = "SpesaComboBox"
        Me.SpesaComboBox.Size = New System.Drawing.Size(234, 21)
        Me.SpesaComboBox.TabIndex = 8
        '
        'ImportoLabel
        '
        ImportoLabel.AutoSize = True
        ImportoLabel.Location = New System.Drawing.Point(522, 78)
        ImportoLabel.Name = "ImportoLabel"
        ImportoLabel.Size = New System.Drawing.Size(45, 13)
        ImportoLabel.TabIndex = 9
        ImportoLabel.Text = "Importo:"
        '
        'ImportoTextBox
        '
        Me.ImportoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.V_PreventivoBindingSource, "Importo", True))
        Me.ImportoTextBox.Location = New System.Drawing.Point(525, 94)
        Me.ImportoTextBox.Name = "ImportoTextBox"
        Me.ImportoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ImportoTextBox.TabIndex = 10
        '
        'PianoContiLabel
        '
        PianoContiLabel.AutoSize = True
        PianoContiLabel.Location = New System.Drawing.Point(522, 37)
        PianoContiLabel.Name = "PianoContiLabel"
        PianoContiLabel.Size = New System.Drawing.Size(64, 13)
        PianoContiLabel.TabIndex = 11
        PianoContiLabel.Text = "Piano Conti:"
        '
        'PianoContiComboBox
        '
        Me.PianoContiComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.V_PreventivoBindingSource, "PianoConti", True))
        Me.PianoContiComboBox.FormattingEnabled = True
        Me.PianoContiComboBox.Location = New System.Drawing.Point(525, 54)
        Me.PianoContiComboBox.Name = "PianoContiComboBox"
        Me.PianoContiComboBox.Size = New System.Drawing.Size(217, 21)
        Me.PianoContiComboBox.TabIndex = 12
        '
        'V_PreventivoDettaglioBindingSource
        '
        Me.V_PreventivoDettaglioBindingSource.DataMember = "V_PreventivoDettaglio"
        Me.V_PreventivoDettaglioBindingSource.DataSource = Me.IMMOBILIDataSet2
        '
        'V_PreventivoDettaglioTableAdapter
        '
        Me.V_PreventivoDettaglioTableAdapter.ClearBeforeFill = True
        '
        'V_PreventivoDettaglioDataGridView
        '
        Me.V_PreventivoDettaglioDataGridView.AutoGenerateColumns = False
        Me.V_PreventivoDettaglioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.V_PreventivoDettaglioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.V_PreventivoDettaglioDataGridView.DataSource = Me.V_PreventivoDettaglioBindingSource
        Me.V_PreventivoDettaglioDataGridView.Location = New System.Drawing.Point(21, 139)
        Me.V_PreventivoDettaglioDataGridView.Name = "V_PreventivoDettaglioDataGridView"
        Me.V_PreventivoDettaglioDataGridView.Size = New System.Drawing.Size(721, 220)
        Me.V_PreventivoDettaglioDataGridView.TabIndex = 13
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Fabbricato"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Fabbricato"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Scala"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Scala"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Importo"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Importo"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'V_Preventivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 379)
        Me.Controls.Add(Me.V_PreventivoDettaglioDataGridView)
        Me.Controls.Add(PianoContiLabel)
        Me.Controls.Add(Me.PianoContiComboBox)
        Me.Controls.Add(ImportoLabel)
        Me.Controls.Add(Me.ImportoTextBox)
        Me.Controls.Add(SpesaLabel)
        Me.Controls.Add(Me.SpesaComboBox)
        Me.Controls.Add(GruppoLabel)
        Me.Controls.Add(Me.GruppoComboBox)
        Me.Controls.Add(GestioneLabel)
        Me.Controls.Add(Me.GestioneComboBox)
        Me.Controls.Add(ImmobileLabel)
        Me.Controls.Add(Me.ImmobileComboBox)
        Me.Controls.Add(Me.V_PreventivoBindingNavigator)
        Me.Name = "V_Preventivo"
        Me.Text = "Archivio dei Preventivi"
        CType(Me.IMMOBILIDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.V_PreventivoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.V_PreventivoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.V_PreventivoBindingNavigator.ResumeLayout(False)
        Me.V_PreventivoBindingNavigator.PerformLayout()
        CType(Me.V_PreventivoDettaglioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.V_PreventivoDettaglioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IMMOBILIDataSet2 As Patrimonio2014.IMMOBILIDataSet2
    Friend WithEvents V_PreventivoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents V_PreventivoTableAdapter As Patrimonio2014.IMMOBILIDataSet2TableAdapters.V_PreventivoTableAdapter
    Friend WithEvents TableAdapterManager As Patrimonio2014.IMMOBILIDataSet2TableAdapters.TableAdapterManager
    Friend WithEvents V_PreventivoBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents V_PreventivoBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ImmobileComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GestioneComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GruppoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents V_PreventivoDettaglioTableAdapter As Patrimonio2014.IMMOBILIDataSet2TableAdapters.V_PreventivoDettaglioTableAdapter
    Friend WithEvents SpesaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ImportoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PianoContiComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents V_PreventivoDettaglioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents V_PreventivoDettaglioDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
