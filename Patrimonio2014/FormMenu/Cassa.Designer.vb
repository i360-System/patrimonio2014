<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cassa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cassa))
        Dim ProgressivoLabel As System.Windows.Forms.Label
        Dim DataMovimentoLabel As System.Windows.Forms.Label
        Dim ImmobileLabel As System.Windows.Forms.Label
        Dim Denominazione1Label As System.Windows.Forms.Label
        Dim ImportoLabel As System.Windows.Forms.Label
        Dim SegnoLabel As System.Windows.Forms.Label
        Dim GestioneLabel As System.Windows.Forms.Label
        Me.IMMOBILIDataSet2 = New Patrimonio2014.IMMOBILIDataSet2()
        Me.CassaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CassaTableAdapter = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.CassaTableAdapter()
        Me.TableAdapterManager = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.TableAdapterManager()
        Me.CassaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CassaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ProgressivoTextBox = New System.Windows.Forms.TextBox()
        Me.DataMovimentoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ImmobileComboBox = New System.Windows.Forms.ComboBox()
        Me.Denominazione1TextBox = New System.Windows.Forms.TextBox()
        Me.Denominazione2TextBox = New System.Windows.Forms.TextBox()
        Me.ImportoTextBox = New System.Windows.Forms.TextBox()
        Me.SegnoTextBox = New System.Windows.Forms.TextBox()
        Me.GestioneComboBox = New System.Windows.Forms.ComboBox()
        ProgressivoLabel = New System.Windows.Forms.Label()
        DataMovimentoLabel = New System.Windows.Forms.Label()
        ImmobileLabel = New System.Windows.Forms.Label()
        Denominazione1Label = New System.Windows.Forms.Label()
        ImportoLabel = New System.Windows.Forms.Label()
        SegnoLabel = New System.Windows.Forms.Label()
        GestioneLabel = New System.Windows.Forms.Label()
        CType(Me.IMMOBILIDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CassaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CassaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CassaBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IMMOBILIDataSet2
        '
        Me.IMMOBILIDataSet2.DataSetName = "IMMOBILIDataSet2"
        Me.IMMOBILIDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CassaBindingSource
        '
        Me.CassaBindingSource.DataMember = "Cassa"
        Me.CassaBindingSource.DataSource = Me.IMMOBILIDataSet2
        '
        'CassaTableAdapter
        '
        Me.CassaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AnagraficaStudioTableAdapter = Nothing
        Me.TableAdapterManager.AnagraficheTableAdapter = Nothing
        Me.TableAdapterManager.AssembleaDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.AssembleaTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CassaTableAdapter = Me.CassaTableAdapter
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
        Me.TableAdapterManager.Y_GestioniDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.Y_GestioniTableAdapter = Nothing
        Me.TableAdapterManager.Y_GestioniUnitaDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.Y_GestioniUnitaTableAdapter = Nothing
        Me.TableAdapterManager.Z_ConsuntivoDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.Z_ConsuntivoTableAdapter = Nothing
        Me.TableAdapterManager.Z_TestoSollecitoTableAdapter = Nothing
        '
        'CassaBindingNavigator
        '
        Me.CassaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CassaBindingNavigator.BindingSource = Me.CassaBindingSource
        Me.CassaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CassaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CassaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CassaBindingNavigatorSaveItem})
        Me.CassaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CassaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CassaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CassaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CassaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CassaBindingNavigator.Name = "CassaBindingNavigator"
        Me.CassaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CassaBindingNavigator.Size = New System.Drawing.Size(698, 25)
        Me.CassaBindingNavigator.TabIndex = 0
        Me.CassaBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(34, 15)
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
        'CassaBindingNavigatorSaveItem
        '
        Me.CassaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CassaBindingNavigatorSaveItem.Image = CType(resources.GetObject("CassaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CassaBindingNavigatorSaveItem.Name = "CassaBindingNavigatorSaveItem"
        Me.CassaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.CassaBindingNavigatorSaveItem.Text = "Salva dati"
        '
        'ProgressivoLabel
        '
        ProgressivoLabel.AutoSize = True
        ProgressivoLabel.Location = New System.Drawing.Point(12, 52)
        ProgressivoLabel.Name = "ProgressivoLabel"
        ProgressivoLabel.Size = New System.Drawing.Size(65, 13)
        ProgressivoLabel.TabIndex = 1
        ProgressivoLabel.Text = "Progressivo:"
        '
        'ProgressivoTextBox
        '
        Me.ProgressivoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CassaBindingSource, "Progressivo", True))
        Me.ProgressivoTextBox.Location = New System.Drawing.Point(15, 68)
        Me.ProgressivoTextBox.Name = "ProgressivoTextBox"
        Me.ProgressivoTextBox.Size = New System.Drawing.Size(74, 20)
        Me.ProgressivoTextBox.TabIndex = 2
        '
        'DataMovimentoLabel
        '
        DataMovimentoLabel.AutoSize = True
        DataMovimentoLabel.Location = New System.Drawing.Point(98, 52)
        DataMovimentoLabel.Name = "DataMovimentoLabel"
        DataMovimentoLabel.Size = New System.Drawing.Size(88, 13)
        DataMovimentoLabel.TabIndex = 3
        DataMovimentoLabel.Text = "Data Movimento:"
        '
        'DataMovimentoDateTimePicker
        '
        Me.DataMovimentoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CassaBindingSource, "DataMovimento", True))
        Me.DataMovimentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataMovimentoDateTimePicker.Location = New System.Drawing.Point(101, 68)
        Me.DataMovimentoDateTimePicker.Name = "DataMovimentoDateTimePicker"
        Me.DataMovimentoDateTimePicker.Size = New System.Drawing.Size(98, 20)
        Me.DataMovimentoDateTimePicker.TabIndex = 4
        '
        'ImmobileLabel
        '
        ImmobileLabel.AutoSize = True
        ImmobileLabel.Location = New System.Drawing.Point(205, 52)
        ImmobileLabel.Name = "ImmobileLabel"
        ImmobileLabel.Size = New System.Drawing.Size(51, 13)
        ImmobileLabel.TabIndex = 5
        ImmobileLabel.Text = "Immobile:"
        '
        'ImmobileComboBox
        '
        Me.ImmobileComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CassaBindingSource, "Immobile", True))
        Me.ImmobileComboBox.FormattingEnabled = True
        Me.ImmobileComboBox.Location = New System.Drawing.Point(208, 68)
        Me.ImmobileComboBox.Name = "ImmobileComboBox"
        Me.ImmobileComboBox.Size = New System.Drawing.Size(305, 21)
        Me.ImmobileComboBox.TabIndex = 6
        '
        'Denominazione1Label
        '
        Denominazione1Label.AutoSize = True
        Denominazione1Label.Location = New System.Drawing.Point(205, 99)
        Denominazione1Label.Name = "Denominazione1Label"
        Denominazione1Label.Size = New System.Drawing.Size(83, 13)
        Denominazione1Label.TabIndex = 7
        Denominazione1Label.Text = "Denominazione:"
        '
        'Denominazione1TextBox
        '
        Me.Denominazione1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CassaBindingSource, "Denominazione1", True))
        Me.Denominazione1TextBox.Location = New System.Drawing.Point(208, 115)
        Me.Denominazione1TextBox.Name = "Denominazione1TextBox"
        Me.Denominazione1TextBox.Size = New System.Drawing.Size(305, 20)
        Me.Denominazione1TextBox.TabIndex = 8
        '
        'Denominazione2TextBox
        '
        Me.Denominazione2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CassaBindingSource, "Denominazione2", True))
        Me.Denominazione2TextBox.Location = New System.Drawing.Point(208, 141)
        Me.Denominazione2TextBox.Name = "Denominazione2TextBox"
        Me.Denominazione2TextBox.Size = New System.Drawing.Size(305, 20)
        Me.Denominazione2TextBox.TabIndex = 10
        '
        'ImportoLabel
        '
        ImportoLabel.AutoSize = True
        ImportoLabel.Location = New System.Drawing.Point(519, 122)
        ImportoLabel.Name = "ImportoLabel"
        ImportoLabel.Size = New System.Drawing.Size(45, 13)
        ImportoLabel.TabIndex = 10
        ImportoLabel.Text = "Importo:"
        '
        'ImportoTextBox
        '
        Me.ImportoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CassaBindingSource, "Importo", True))
        Me.ImportoTextBox.Location = New System.Drawing.Point(522, 141)
        Me.ImportoTextBox.Name = "ImportoTextBox"
        Me.ImportoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ImportoTextBox.TabIndex = 11
        '
        'SegnoLabel
        '
        SegnoLabel.AutoSize = True
        SegnoLabel.Location = New System.Drawing.Point(631, 122)
        SegnoLabel.Name = "SegnoLabel"
        SegnoLabel.Size = New System.Drawing.Size(41, 13)
        SegnoLabel.TabIndex = 12
        SegnoLabel.Text = "Segno:"
        '
        'SegnoTextBox
        '
        Me.SegnoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CassaBindingSource, "Segno", True))
        Me.SegnoTextBox.Location = New System.Drawing.Point(634, 141)
        Me.SegnoTextBox.Name = "SegnoTextBox"
        Me.SegnoTextBox.Size = New System.Drawing.Size(38, 20)
        Me.SegnoTextBox.TabIndex = 13
        '
        'GestioneLabel
        '
        GestioneLabel.AutoSize = True
        GestioneLabel.Location = New System.Drawing.Point(205, 164)
        GestioneLabel.Name = "GestioneLabel"
        GestioneLabel.Size = New System.Drawing.Size(52, 13)
        GestioneLabel.TabIndex = 14
        GestioneLabel.Text = "Gestione:"
        '
        'GestioneComboBox
        '
        Me.GestioneComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CassaBindingSource, "Gestione", True))
        Me.GestioneComboBox.FormattingEnabled = True
        Me.GestioneComboBox.Location = New System.Drawing.Point(208, 180)
        Me.GestioneComboBox.Name = "GestioneComboBox"
        Me.GestioneComboBox.Size = New System.Drawing.Size(305, 21)
        Me.GestioneComboBox.TabIndex = 15
        '
        'Cassa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 262)
        Me.Controls.Add(GestioneLabel)
        Me.Controls.Add(Me.GestioneComboBox)
        Me.Controls.Add(SegnoLabel)
        Me.Controls.Add(Me.SegnoTextBox)
        Me.Controls.Add(ImportoLabel)
        Me.Controls.Add(Me.ImportoTextBox)
        Me.Controls.Add(Me.Denominazione2TextBox)
        Me.Controls.Add(Denominazione1Label)
        Me.Controls.Add(Me.Denominazione1TextBox)
        Me.Controls.Add(ImmobileLabel)
        Me.Controls.Add(Me.ImmobileComboBox)
        Me.Controls.Add(DataMovimentoLabel)
        Me.Controls.Add(Me.DataMovimentoDateTimePicker)
        Me.Controls.Add(ProgressivoLabel)
        Me.Controls.Add(Me.ProgressivoTextBox)
        Me.Controls.Add(Me.CassaBindingNavigator)
        Me.Name = "Cassa"
        Me.Text = "Giornale di Cassa"
        CType(Me.IMMOBILIDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CassaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CassaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CassaBindingNavigator.ResumeLayout(False)
        Me.CassaBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IMMOBILIDataSet2 As Patrimonio2014.IMMOBILIDataSet2
    Friend WithEvents CassaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CassaTableAdapter As Patrimonio2014.IMMOBILIDataSet2TableAdapters.CassaTableAdapter
    Friend WithEvents TableAdapterManager As Patrimonio2014.IMMOBILIDataSet2TableAdapters.TableAdapterManager
    Friend WithEvents CassaBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents CassaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ProgressivoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataMovimentoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ImmobileComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Denominazione1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Denominazione2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents ImportoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SegnoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GestioneComboBox As System.Windows.Forms.ComboBox
End Class
