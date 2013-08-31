<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class X_Fatture
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(X_Fatture))
        Dim DocumentoLabel As System.Windows.Forms.Label
        Dim FornitoreLabel As System.Windows.Forms.Label
        Dim QuantitaLabel As System.Windows.Forms.Label
        Dim ImmobileLabel As System.Windows.Forms.Label
        Me.IMMOBILIDataSet2 = New Patrimonio2014.IMMOBILIDataSet2()
        Me.X_FattureBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.X_FattureTableAdapter = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.X_FattureTableAdapter()
        Me.TableAdapterManager = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.TableAdapterManager()
        Me.X_FattureBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.X_FattureBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DocumentoTextBox = New System.Windows.Forms.TextBox()
        Me.FornitoreComboBox = New System.Windows.Forms.ComboBox()
        Me.QuantitaTextBox = New System.Windows.Forms.TextBox()
        Me.ImmobileComboBox = New System.Windows.Forms.ComboBox()
        Me.X_FattureDettaglioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.X_FattureDettaglioTableAdapter = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.X_FattureDettaglioTableAdapter()
        Me.X_FattureDettaglioDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        DocumentoLabel = New System.Windows.Forms.Label()
        FornitoreLabel = New System.Windows.Forms.Label()
        QuantitaLabel = New System.Windows.Forms.Label()
        ImmobileLabel = New System.Windows.Forms.Label()
        CType(Me.IMMOBILIDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X_FattureBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X_FattureBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.X_FattureBindingNavigator.SuspendLayout()
        CType(Me.X_FattureDettaglioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X_FattureDettaglioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IMMOBILIDataSet2
        '
        Me.IMMOBILIDataSet2.DataSetName = "IMMOBILIDataSet2"
        Me.IMMOBILIDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'X_FattureBindingSource
        '
        Me.X_FattureBindingSource.DataMember = "X_Fatture"
        Me.X_FattureBindingSource.DataSource = Me.IMMOBILIDataSet2
        '
        'X_FattureTableAdapter
        '
        Me.X_FattureTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.X_FattureDettaglioTableAdapter = Me.X_FattureDettaglioTableAdapter
        Me.TableAdapterManager.X_FattureTableAdapter = Me.X_FattureTableAdapter
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
        'X_FattureBindingNavigator
        '
        Me.X_FattureBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.X_FattureBindingNavigator.BindingSource = Me.X_FattureBindingSource
        Me.X_FattureBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.X_FattureBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.X_FattureBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.X_FattureBindingNavigatorSaveItem})
        Me.X_FattureBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.X_FattureBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.X_FattureBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.X_FattureBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.X_FattureBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.X_FattureBindingNavigator.Name = "X_FattureBindingNavigator"
        Me.X_FattureBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.X_FattureBindingNavigator.Size = New System.Drawing.Size(752, 25)
        Me.X_FattureBindingNavigator.TabIndex = 0
        Me.X_FattureBindingNavigator.Text = "BindingNavigator1"
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
        'X_FattureBindingNavigatorSaveItem
        '
        Me.X_FattureBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.X_FattureBindingNavigatorSaveItem.Image = CType(resources.GetObject("X_FattureBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.X_FattureBindingNavigatorSaveItem.Name = "X_FattureBindingNavigatorSaveItem"
        Me.X_FattureBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.X_FattureBindingNavigatorSaveItem.Text = "Salva dati"
        '
        'DocumentoLabel
        '
        DocumentoLabel.AutoSize = True
        DocumentoLabel.Location = New System.Drawing.Point(12, 35)
        DocumentoLabel.Name = "DocumentoLabel"
        DocumentoLabel.Size = New System.Drawing.Size(65, 13)
        DocumentoLabel.TabIndex = 1
        DocumentoLabel.Text = "Documento:"
        '
        'DocumentoTextBox
        '
        Me.DocumentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_FattureBindingSource, "Documento", True))
        Me.DocumentoTextBox.Location = New System.Drawing.Point(15, 51)
        Me.DocumentoTextBox.Name = "DocumentoTextBox"
        Me.DocumentoTextBox.Size = New System.Drawing.Size(136, 20)
        Me.DocumentoTextBox.TabIndex = 2
        '
        'FornitoreLabel
        '
        FornitoreLabel.AutoSize = True
        FornitoreLabel.Location = New System.Drawing.Point(157, 35)
        FornitoreLabel.Name = "FornitoreLabel"
        FornitoreLabel.Size = New System.Drawing.Size(51, 13)
        FornitoreLabel.TabIndex = 3
        FornitoreLabel.Text = "Fornitore:"
        '
        'FornitoreComboBox
        '
        Me.FornitoreComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_FattureBindingSource, "Fornitore", True))
        Me.FornitoreComboBox.FormattingEnabled = True
        Me.FornitoreComboBox.Location = New System.Drawing.Point(160, 51)
        Me.FornitoreComboBox.Name = "FornitoreComboBox"
        Me.FornitoreComboBox.Size = New System.Drawing.Size(252, 21)
        Me.FornitoreComboBox.TabIndex = 4
        '
        'QuantitaLabel
        '
        QuantitaLabel.AutoSize = True
        QuantitaLabel.Location = New System.Drawing.Point(12, 74)
        QuantitaLabel.Name = "QuantitaLabel"
        QuantitaLabel.Size = New System.Drawing.Size(50, 13)
        QuantitaLabel.TabIndex = 5
        QuantitaLabel.Text = "Quantita:"
        '
        'QuantitaTextBox
        '
        Me.QuantitaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_FattureBindingSource, "Quantita", True))
        Me.QuantitaTextBox.Location = New System.Drawing.Point(15, 90)
        Me.QuantitaTextBox.Name = "QuantitaTextBox"
        Me.QuantitaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.QuantitaTextBox.TabIndex = 6
        '
        'ImmobileLabel
        '
        ImmobileLabel.AutoSize = True
        ImmobileLabel.Location = New System.Drawing.Point(162, 75)
        ImmobileLabel.Name = "ImmobileLabel"
        ImmobileLabel.Size = New System.Drawing.Size(51, 13)
        ImmobileLabel.TabIndex = 7
        ImmobileLabel.Text = "Immobile:"
        '
        'ImmobileComboBox
        '
        Me.ImmobileComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_FattureBindingSource, "Immobile", True))
        Me.ImmobileComboBox.FormattingEnabled = True
        Me.ImmobileComboBox.Location = New System.Drawing.Point(160, 90)
        Me.ImmobileComboBox.Name = "ImmobileComboBox"
        Me.ImmobileComboBox.Size = New System.Drawing.Size(252, 21)
        Me.ImmobileComboBox.TabIndex = 8
        '
        'X_FattureDettaglioBindingSource
        '
        Me.X_FattureDettaglioBindingSource.DataMember = "X_FattureX_FattureDettaglio"
        Me.X_FattureDettaglioBindingSource.DataSource = Me.X_FattureBindingSource
        '
        'X_FattureDettaglioTableAdapter
        '
        Me.X_FattureDettaglioTableAdapter.ClearBeforeFill = True
        '
        'X_FattureDettaglioDataGridView
        '
        Me.X_FattureDettaglioDataGridView.AutoGenerateColumns = False
        Me.X_FattureDettaglioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.X_FattureDettaglioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.X_FattureDettaglioDataGridView.DataSource = Me.X_FattureDettaglioBindingSource
        Me.X_FattureDettaglioDataGridView.Location = New System.Drawing.Point(17, 133)
        Me.X_FattureDettaglioDataGridView.Name = "X_FattureDettaglioDataGridView"
        Me.X_FattureDettaglioDataGridView.Size = New System.Drawing.Size(723, 220)
        Me.X_FattureDettaglioDataGridView.TabIndex = 9
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Operazione"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Operazione"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Descrizione"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Descrizione"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Data"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Data"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Importo"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Importo"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "RiferimentoContoFinanziario"
        Me.DataGridViewTextBoxColumn7.HeaderText = "RiferimentoContoFinanziario"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Conto"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Conto"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'X_Fatture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 375)
        Me.Controls.Add(Me.X_FattureDettaglioDataGridView)
        Me.Controls.Add(ImmobileLabel)
        Me.Controls.Add(Me.ImmobileComboBox)
        Me.Controls.Add(QuantitaLabel)
        Me.Controls.Add(Me.QuantitaTextBox)
        Me.Controls.Add(FornitoreLabel)
        Me.Controls.Add(Me.FornitoreComboBox)
        Me.Controls.Add(DocumentoLabel)
        Me.Controls.Add(Me.DocumentoTextBox)
        Me.Controls.Add(Me.X_FattureBindingNavigator)
        Me.Name = "X_Fatture"
        Me.Text = "Archivio Fatture"
        CType(Me.IMMOBILIDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X_FattureBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X_FattureBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.X_FattureBindingNavigator.ResumeLayout(False)
        Me.X_FattureBindingNavigator.PerformLayout()
        CType(Me.X_FattureDettaglioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X_FattureDettaglioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IMMOBILIDataSet2 As Patrimonio2014.IMMOBILIDataSet2
    Friend WithEvents X_FattureBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents X_FattureTableAdapter As Patrimonio2014.IMMOBILIDataSet2TableAdapters.X_FattureTableAdapter
    Friend WithEvents TableAdapterManager As Patrimonio2014.IMMOBILIDataSet2TableAdapters.TableAdapterManager
    Friend WithEvents X_FattureBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents X_FattureBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents X_FattureDettaglioTableAdapter As Patrimonio2014.IMMOBILIDataSet2TableAdapters.X_FattureDettaglioTableAdapter
    Friend WithEvents DocumentoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FornitoreComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents QuantitaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ImmobileComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents X_FattureDettaglioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents X_FattureDettaglioDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
