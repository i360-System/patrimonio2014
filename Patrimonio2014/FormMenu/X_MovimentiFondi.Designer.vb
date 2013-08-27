<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class X_MovimentiFondi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(X_MovimentiFondi))
        Dim ImmobileLabel As System.Windows.Forms.Label
        Dim FondoLabel As System.Windows.Forms.Label
        Dim DataMovimentoLabel As System.Windows.Forms.Label
        Dim OperazioneLabel As System.Windows.Forms.Label
        Dim ImportoLabel As System.Windows.Forms.Label
        Dim DescrizioneLabel As System.Windows.Forms.Label
        Me.IMMOBILIDataSet2 = New Patrimonio2014.IMMOBILIDataSet2()
        Me.X_MovimentiFondiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.X_MovimentiFondiTableAdapter = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.X_MovimentiFondiTableAdapter()
        Me.TableAdapterManager = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.TableAdapterManager()
        Me.X_MovimentiFondiBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.X_MovimentiFondiBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ProgressivoTextBox = New System.Windows.Forms.TextBox()
        Me.ImmobileComboBox = New System.Windows.Forms.ComboBox()
        Me.FondoComboBox = New System.Windows.Forms.ComboBox()
        Me.DataMovimentoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.OperazioneTextBox = New System.Windows.Forms.TextBox()
        Me.ImportoTextBox = New System.Windows.Forms.TextBox()
        Me.DescrizioneTextBox = New System.Windows.Forms.TextBox()
        ProgressivoLabel = New System.Windows.Forms.Label()
        ImmobileLabel = New System.Windows.Forms.Label()
        FondoLabel = New System.Windows.Forms.Label()
        DataMovimentoLabel = New System.Windows.Forms.Label()
        OperazioneLabel = New System.Windows.Forms.Label()
        ImportoLabel = New System.Windows.Forms.Label()
        DescrizioneLabel = New System.Windows.Forms.Label()
        CType(Me.IMMOBILIDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X_MovimentiFondiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X_MovimentiFondiBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.X_MovimentiFondiBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProgressivoLabel
        '
        ProgressivoLabel.AutoSize = True
        ProgressivoLabel.Location = New System.Drawing.Point(12, 34)
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
        'X_MovimentiFondiBindingSource
        '
        Me.X_MovimentiFondiBindingSource.DataMember = "X_MovimentiFondi"
        Me.X_MovimentiFondiBindingSource.DataSource = Me.IMMOBILIDataSet2
        '
        'X_MovimentiFondiTableAdapter
        '
        Me.X_MovimentiFondiTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.X_MovimentiFondiTableAdapter = Me.X_MovimentiFondiTableAdapter
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
        'X_MovimentiFondiBindingNavigator
        '
        Me.X_MovimentiFondiBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.X_MovimentiFondiBindingNavigator.BindingSource = Me.X_MovimentiFondiBindingSource
        Me.X_MovimentiFondiBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.X_MovimentiFondiBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.X_MovimentiFondiBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.X_MovimentiFondiBindingNavigatorSaveItem})
        Me.X_MovimentiFondiBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.X_MovimentiFondiBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.X_MovimentiFondiBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.X_MovimentiFondiBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.X_MovimentiFondiBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.X_MovimentiFondiBindingNavigator.Name = "X_MovimentiFondiBindingNavigator"
        Me.X_MovimentiFondiBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.X_MovimentiFondiBindingNavigator.Size = New System.Drawing.Size(596, 25)
        Me.X_MovimentiFondiBindingNavigator.TabIndex = 0
        Me.X_MovimentiFondiBindingNavigator.Text = "BindingNavigator1"
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
        'X_MovimentiFondiBindingNavigatorSaveItem
        '
        Me.X_MovimentiFondiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.X_MovimentiFondiBindingNavigatorSaveItem.Image = CType(resources.GetObject("X_MovimentiFondiBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.X_MovimentiFondiBindingNavigatorSaveItem.Name = "X_MovimentiFondiBindingNavigatorSaveItem"
        Me.X_MovimentiFondiBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.X_MovimentiFondiBindingNavigatorSaveItem.Text = "Salva dati"
        '
        'ProgressivoTextBox
        '
        Me.ProgressivoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_MovimentiFondiBindingSource, "Progressivo", True))
        Me.ProgressivoTextBox.Location = New System.Drawing.Point(15, 50)
        Me.ProgressivoTextBox.Name = "ProgressivoTextBox"
        Me.ProgressivoTextBox.Size = New System.Drawing.Size(71, 20)
        Me.ProgressivoTextBox.TabIndex = 2
        '
        'ImmobileLabel
        '
        ImmobileLabel.AutoSize = True
        ImmobileLabel.Location = New System.Drawing.Point(92, 34)
        ImmobileLabel.Name = "ImmobileLabel"
        ImmobileLabel.Size = New System.Drawing.Size(51, 13)
        ImmobileLabel.TabIndex = 3
        ImmobileLabel.Text = "Immobile:"
        '
        'ImmobileComboBox
        '
        Me.ImmobileComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_MovimentiFondiBindingSource, "Immobile", True))
        Me.ImmobileComboBox.FormattingEnabled = True
        Me.ImmobileComboBox.Location = New System.Drawing.Point(95, 50)
        Me.ImmobileComboBox.Name = "ImmobileComboBox"
        Me.ImmobileComboBox.Size = New System.Drawing.Size(229, 21)
        Me.ImmobileComboBox.TabIndex = 4
        '
        'FondoLabel
        '
        FondoLabel.AutoSize = True
        FondoLabel.Location = New System.Drawing.Point(330, 34)
        FondoLabel.Name = "FondoLabel"
        FondoLabel.Size = New System.Drawing.Size(40, 13)
        FondoLabel.TabIndex = 5
        FondoLabel.Text = "Fondo:"
        '
        'FondoComboBox
        '
        Me.FondoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_MovimentiFondiBindingSource, "Fondo", True))
        Me.FondoComboBox.FormattingEnabled = True
        Me.FondoComboBox.Location = New System.Drawing.Point(333, 50)
        Me.FondoComboBox.Name = "FondoComboBox"
        Me.FondoComboBox.Size = New System.Drawing.Size(227, 21)
        Me.FondoComboBox.TabIndex = 6
        '
        'DataMovimentoLabel
        '
        DataMovimentoLabel.AutoSize = True
        DataMovimentoLabel.Location = New System.Drawing.Point(12, 74)
        DataMovimentoLabel.Name = "DataMovimentoLabel"
        DataMovimentoLabel.Size = New System.Drawing.Size(88, 13)
        DataMovimentoLabel.TabIndex = 7
        DataMovimentoLabel.Text = "Data Movimento:"
        '
        'DataMovimentoDateTimePicker
        '
        Me.DataMovimentoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.X_MovimentiFondiBindingSource, "DataMovimento", True))
        Me.DataMovimentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataMovimentoDateTimePicker.Location = New System.Drawing.Point(15, 90)
        Me.DataMovimentoDateTimePicker.Name = "DataMovimentoDateTimePicker"
        Me.DataMovimentoDateTimePicker.Size = New System.Drawing.Size(88, 20)
        Me.DataMovimentoDateTimePicker.TabIndex = 8
        '
        'OperazioneLabel
        '
        OperazioneLabel.AutoSize = True
        OperazioneLabel.Location = New System.Drawing.Point(109, 74)
        OperazioneLabel.Name = "OperazioneLabel"
        OperazioneLabel.Size = New System.Drawing.Size(64, 13)
        OperazioneLabel.TabIndex = 9
        OperazioneLabel.Text = "Operazione:"
        '
        'OperazioneTextBox
        '
        Me.OperazioneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_MovimentiFondiBindingSource, "Operazione", True))
        Me.OperazioneTextBox.Location = New System.Drawing.Point(112, 90)
        Me.OperazioneTextBox.Name = "OperazioneTextBox"
        Me.OperazioneTextBox.Size = New System.Drawing.Size(61, 20)
        Me.OperazioneTextBox.TabIndex = 10
        '
        'ImportoLabel
        '
        ImportoLabel.AutoSize = True
        ImportoLabel.Location = New System.Drawing.Point(179, 74)
        ImportoLabel.Name = "ImportoLabel"
        ImportoLabel.Size = New System.Drawing.Size(45, 13)
        ImportoLabel.TabIndex = 11
        ImportoLabel.Text = "Importo:"
        '
        'ImportoTextBox
        '
        Me.ImportoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_MovimentiFondiBindingSource, "Importo", True))
        Me.ImportoTextBox.Location = New System.Drawing.Point(182, 90)
        Me.ImportoTextBox.Name = "ImportoTextBox"
        Me.ImportoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ImportoTextBox.TabIndex = 12
        '
        'DescrizioneLabel
        '
        DescrizioneLabel.AutoSize = True
        DescrizioneLabel.Location = New System.Drawing.Point(288, 74)
        DescrizioneLabel.Name = "DescrizioneLabel"
        DescrizioneLabel.Size = New System.Drawing.Size(65, 13)
        DescrizioneLabel.TabIndex = 13
        DescrizioneLabel.Text = "Descrizione:"
        '
        'DescrizioneTextBox
        '
        Me.DescrizioneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_MovimentiFondiBindingSource, "Descrizione", True))
        Me.DescrizioneTextBox.Location = New System.Drawing.Point(291, 90)
        Me.DescrizioneTextBox.Name = "DescrizioneTextBox"
        Me.DescrizioneTextBox.Size = New System.Drawing.Size(269, 20)
        Me.DescrizioneTextBox.TabIndex = 14
        '
        'X_MovimentiFondi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 148)
        Me.Controls.Add(DescrizioneLabel)
        Me.Controls.Add(Me.DescrizioneTextBox)
        Me.Controls.Add(ImportoLabel)
        Me.Controls.Add(Me.ImportoTextBox)
        Me.Controls.Add(OperazioneLabel)
        Me.Controls.Add(Me.OperazioneTextBox)
        Me.Controls.Add(DataMovimentoLabel)
        Me.Controls.Add(Me.DataMovimentoDateTimePicker)
        Me.Controls.Add(FondoLabel)
        Me.Controls.Add(Me.FondoComboBox)
        Me.Controls.Add(ImmobileLabel)
        Me.Controls.Add(Me.ImmobileComboBox)
        Me.Controls.Add(ProgressivoLabel)
        Me.Controls.Add(Me.ProgressivoTextBox)
        Me.Controls.Add(Me.X_MovimentiFondiBindingNavigator)
        Me.Name = "X_MovimentiFondi"
        Me.Text = "Movimenti dei Fondi"
        CType(Me.IMMOBILIDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X_MovimentiFondiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X_MovimentiFondiBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.X_MovimentiFondiBindingNavigator.ResumeLayout(False)
        Me.X_MovimentiFondiBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IMMOBILIDataSet2 As Patrimonio2014.IMMOBILIDataSet2
    Friend WithEvents X_MovimentiFondiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents X_MovimentiFondiTableAdapter As Patrimonio2014.IMMOBILIDataSet2TableAdapters.X_MovimentiFondiTableAdapter
    Friend WithEvents TableAdapterManager As Patrimonio2014.IMMOBILIDataSet2TableAdapters.TableAdapterManager
    Friend WithEvents X_MovimentiFondiBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents X_MovimentiFondiBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ProgressivoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ImmobileComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FondoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DataMovimentoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents OperazioneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ImportoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescrizioneTextBox As System.Windows.Forms.TextBox
End Class
