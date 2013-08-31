<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PianoContiPreventivo
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
        Dim PianoContiLabel As System.Windows.Forms.Label
        Dim DenominazioneLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PianoContiPreventivo))
        Me.IMMOBILIDataSet2 = New Patrimonio2014.IMMOBILIDataSet2()
        Me.PianoContiPreventivoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PianoContiPreventivoTableAdapter = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.PianoContiPreventivoTableAdapter()
        Me.TableAdapterManager = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.TableAdapterManager()
        Me.PianoContiPreventivoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PianoContiPreventivoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PianoContiTextBox = New System.Windows.Forms.TextBox()
        Me.DenominazioneTextBox = New System.Windows.Forms.TextBox()
        Me.PianoContiPreventivoDettaglioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PianoContiPreventivoDettaglioTableAdapter = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.PianoContiPreventivoDettaglioTableAdapter()
        Me.PianoContiPreventivoDettaglioDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        PianoContiLabel = New System.Windows.Forms.Label()
        DenominazioneLabel = New System.Windows.Forms.Label()
        CType(Me.IMMOBILIDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PianoContiPreventivoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PianoContiPreventivoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PianoContiPreventivoBindingNavigator.SuspendLayout()
        CType(Me.PianoContiPreventivoDettaglioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PianoContiPreventivoDettaglioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PianoContiLabel
        '
        PianoContiLabel.AutoSize = True
        PianoContiLabel.Location = New System.Drawing.Point(12, 46)
        PianoContiLabel.Name = "PianoContiLabel"
        PianoContiLabel.Size = New System.Drawing.Size(64, 13)
        PianoContiLabel.TabIndex = 1
        PianoContiLabel.Text = "Piano Conti:"
        '
        'DenominazioneLabel
        '
        DenominazioneLabel.AutoSize = True
        DenominazioneLabel.Location = New System.Drawing.Point(82, 46)
        DenominazioneLabel.Name = "DenominazioneLabel"
        DenominazioneLabel.Size = New System.Drawing.Size(83, 13)
        DenominazioneLabel.TabIndex = 3
        DenominazioneLabel.Text = "Denominazione:"
        '
        'IMMOBILIDataSet2
        '
        Me.IMMOBILIDataSet2.DataSetName = "IMMOBILIDataSet2"
        Me.IMMOBILIDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PianoContiPreventivoBindingSource
        '
        Me.PianoContiPreventivoBindingSource.DataMember = "PianoContiPreventivo"
        Me.PianoContiPreventivoBindingSource.DataSource = Me.IMMOBILIDataSet2
        '
        'PianoContiPreventivoTableAdapter
        '
        Me.PianoContiPreventivoTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.PianoContiPreventivoTableAdapter = Me.PianoContiPreventivoTableAdapter
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
        'PianoContiPreventivoBindingNavigator
        '
        Me.PianoContiPreventivoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PianoContiPreventivoBindingNavigator.BindingSource = Me.PianoContiPreventivoBindingSource
        Me.PianoContiPreventivoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PianoContiPreventivoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PianoContiPreventivoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PianoContiPreventivoBindingNavigatorSaveItem})
        Me.PianoContiPreventivoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PianoContiPreventivoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PianoContiPreventivoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PianoContiPreventivoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PianoContiPreventivoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PianoContiPreventivoBindingNavigator.Name = "PianoContiPreventivoBindingNavigator"
        Me.PianoContiPreventivoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PianoContiPreventivoBindingNavigator.Size = New System.Drawing.Size(605, 25)
        Me.PianoContiPreventivoBindingNavigator.TabIndex = 0
        Me.PianoContiPreventivoBindingNavigator.Text = "BindingNavigator1"
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
        'PianoContiPreventivoBindingNavigatorSaveItem
        '
        Me.PianoContiPreventivoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PianoContiPreventivoBindingNavigatorSaveItem.Image = CType(resources.GetObject("PianoContiPreventivoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PianoContiPreventivoBindingNavigatorSaveItem.Name = "PianoContiPreventivoBindingNavigatorSaveItem"
        Me.PianoContiPreventivoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PianoContiPreventivoBindingNavigatorSaveItem.Text = "Salva dati"
        '
        'PianoContiTextBox
        '
        Me.PianoContiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PianoContiPreventivoBindingSource, "PianoConti", True))
        Me.PianoContiTextBox.Location = New System.Drawing.Point(15, 62)
        Me.PianoContiTextBox.Name = "PianoContiTextBox"
        Me.PianoContiTextBox.Size = New System.Drawing.Size(61, 20)
        Me.PianoContiTextBox.TabIndex = 2
        '
        'DenominazioneTextBox
        '
        Me.DenominazioneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PianoContiPreventivoBindingSource, "Denominazione", True))
        Me.DenominazioneTextBox.Location = New System.Drawing.Point(85, 62)
        Me.DenominazioneTextBox.Name = "DenominazioneTextBox"
        Me.DenominazioneTextBox.Size = New System.Drawing.Size(272, 20)
        Me.DenominazioneTextBox.TabIndex = 4
        '
        'PianoContiPreventivoDettaglioBindingSource
        '
        Me.PianoContiPreventivoDettaglioBindingSource.DataMember = "PianoContiPreventivoPianoContiPreventivoDettaglio"
        Me.PianoContiPreventivoDettaglioBindingSource.DataSource = Me.PianoContiPreventivoBindingSource
        '
        'PianoContiPreventivoDettaglioTableAdapter
        '
        Me.PianoContiPreventivoDettaglioTableAdapter.ClearBeforeFill = True
        '
        'PianoContiPreventivoDettaglioDataGridView
        '
        Me.PianoContiPreventivoDettaglioDataGridView.AutoGenerateColumns = False
        Me.PianoContiPreventivoDettaglioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PianoContiPreventivoDettaglioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.PianoContiPreventivoDettaglioDataGridView.DataSource = Me.PianoContiPreventivoDettaglioBindingSource
        Me.PianoContiPreventivoDettaglioDataGridView.Location = New System.Drawing.Point(18, 99)
        Me.PianoContiPreventivoDettaglioDataGridView.Name = "PianoContiPreventivoDettaglioDataGridView"
        Me.PianoContiPreventivoDettaglioDataGridView.Size = New System.Drawing.Size(517, 594)
        Me.PianoContiPreventivoDettaglioDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Gruppo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Gruppo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 50
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Spesa"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Spesa"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 50
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Descrizione"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Descrizione"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 200
        '
        'PianoContiPreventivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 719)
        Me.Controls.Add(Me.PianoContiPreventivoDettaglioDataGridView)
        Me.Controls.Add(DenominazioneLabel)
        Me.Controls.Add(Me.DenominazioneTextBox)
        Me.Controls.Add(PianoContiLabel)
        Me.Controls.Add(Me.PianoContiTextBox)
        Me.Controls.Add(Me.PianoContiPreventivoBindingNavigator)
        Me.Name = "PianoContiPreventivo"
        Me.Text = "Piano dei Conti del Preventivo"
        Me.TopMost = True
        CType(Me.IMMOBILIDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PianoContiPreventivoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PianoContiPreventivoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PianoContiPreventivoBindingNavigator.ResumeLayout(False)
        Me.PianoContiPreventivoBindingNavigator.PerformLayout()
        CType(Me.PianoContiPreventivoDettaglioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PianoContiPreventivoDettaglioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IMMOBILIDataSet2 As Patrimonio2014.IMMOBILIDataSet2
    Friend WithEvents PianoContiPreventivoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PianoContiPreventivoTableAdapter As Patrimonio2014.IMMOBILIDataSet2TableAdapters.PianoContiPreventivoTableAdapter
    Friend WithEvents TableAdapterManager As Patrimonio2014.IMMOBILIDataSet2TableAdapters.TableAdapterManager
    Friend WithEvents PianoContiPreventivoBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents PianoContiPreventivoBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PianoContiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DenominazioneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PianoContiPreventivoDettaglioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PianoContiPreventivoDettaglioTableAdapter As Patrimonio2014.IMMOBILIDataSet2TableAdapters.PianoContiPreventivoDettaglioTableAdapter
    Friend WithEvents PianoContiPreventivoDettaglioDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
