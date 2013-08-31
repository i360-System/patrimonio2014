<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Costanti
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
        Dim ImmobileLabel As System.Windows.Forms.Label
        Dim TabellaLabel As System.Windows.Forms.Label
        Dim OrdinanteLabel As System.Windows.Forms.Label
        Dim DipendenzaLabel As System.Windows.Forms.Label
        Dim CategoriaLabel As System.Windows.Forms.Label
        Dim ContoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Costanti))
        Me.IMMOBILIDataSet2 = New Patrimonio2014.IMMOBILIDataSet2()
        Me.CostantiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CostantiTableAdapter = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.CostantiTableAdapter()
        Me.TableAdapterManager = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.TableAdapterManager()
        Me.CostantiBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CostantiBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ImmobileComboBox = New System.Windows.Forms.ComboBox()
        Me.TabellaTextBox = New System.Windows.Forms.TextBox()
        Me.OrdinanteTextBox = New System.Windows.Forms.TextBox()
        Me.DipendenzaTextBox = New System.Windows.Forms.TextBox()
        Me.CategoriaTextBox = New System.Windows.Forms.TextBox()
        Me.ContoTextBox = New System.Windows.Forms.TextBox()
        ImmobileLabel = New System.Windows.Forms.Label()
        TabellaLabel = New System.Windows.Forms.Label()
        OrdinanteLabel = New System.Windows.Forms.Label()
        DipendenzaLabel = New System.Windows.Forms.Label()
        CategoriaLabel = New System.Windows.Forms.Label()
        ContoLabel = New System.Windows.Forms.Label()
        CType(Me.IMMOBILIDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CostantiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CostantiBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CostantiBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImmobileLabel
        '
        ImmobileLabel.AutoSize = True
        ImmobileLabel.Location = New System.Drawing.Point(12, 49)
        ImmobileLabel.Name = "ImmobileLabel"
        ImmobileLabel.Size = New System.Drawing.Size(51, 13)
        ImmobileLabel.TabIndex = 1
        ImmobileLabel.Text = "Immobile:"
        '
        'TabellaLabel
        '
        TabellaLabel.AutoSize = True
        TabellaLabel.Location = New System.Drawing.Point(322, 49)
        TabellaLabel.Name = "TabellaLabel"
        TabellaLabel.Size = New System.Drawing.Size(45, 13)
        TabellaLabel.TabIndex = 3
        TabellaLabel.Text = "Tabella:"
        '
        'OrdinanteLabel
        '
        OrdinanteLabel.AutoSize = True
        OrdinanteLabel.Location = New System.Drawing.Point(12, 89)
        OrdinanteLabel.Name = "OrdinanteLabel"
        OrdinanteLabel.Size = New System.Drawing.Size(56, 13)
        OrdinanteLabel.TabIndex = 5
        OrdinanteLabel.Text = "Ordinante:"
        '
        'DipendenzaLabel
        '
        DipendenzaLabel.AutoSize = True
        DipendenzaLabel.Location = New System.Drawing.Point(183, 89)
        DipendenzaLabel.Name = "DipendenzaLabel"
        DipendenzaLabel.Size = New System.Drawing.Size(67, 13)
        DipendenzaLabel.TabIndex = 7
        DipendenzaLabel.Text = "Dipendenza:"
        '
        'CategoriaLabel
        '
        CategoriaLabel.AutoSize = True
        CategoriaLabel.Location = New System.Drawing.Point(324, 89)
        CategoriaLabel.Name = "CategoriaLabel"
        CategoriaLabel.Size = New System.Drawing.Size(55, 13)
        CategoriaLabel.TabIndex = 9
        CategoriaLabel.Text = "Categoria:"
        '
        'ContoLabel
        '
        ContoLabel.AutoSize = True
        ContoLabel.Location = New System.Drawing.Point(440, 89)
        ContoLabel.Name = "ContoLabel"
        ContoLabel.Size = New System.Drawing.Size(38, 13)
        ContoLabel.TabIndex = 11
        ContoLabel.Text = "Conto:"
        '
        'IMMOBILIDataSet2
        '
        Me.IMMOBILIDataSet2.DataSetName = "IMMOBILIDataSet2"
        Me.IMMOBILIDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CostantiBindingSource
        '
        Me.CostantiBindingSource.DataMember = "Costanti"
        Me.CostantiBindingSource.DataSource = Me.IMMOBILIDataSet2
        '
        'CostantiTableAdapter
        '
        Me.CostantiTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.CostantiTableAdapter = Me.CostantiTableAdapter
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
        'CostantiBindingNavigator
        '
        Me.CostantiBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CostantiBindingNavigator.BindingSource = Me.CostantiBindingSource
        Me.CostantiBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CostantiBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CostantiBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CostantiBindingNavigatorSaveItem})
        Me.CostantiBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CostantiBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CostantiBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CostantiBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CostantiBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CostantiBindingNavigator.Name = "CostantiBindingNavigator"
        Me.CostantiBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CostantiBindingNavigator.Size = New System.Drawing.Size(634, 25)
        Me.CostantiBindingNavigator.TabIndex = 0
        Me.CostantiBindingNavigator.Text = "BindingNavigator1"
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
        'CostantiBindingNavigatorSaveItem
        '
        Me.CostantiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CostantiBindingNavigatorSaveItem.Image = CType(resources.GetObject("CostantiBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CostantiBindingNavigatorSaveItem.Name = "CostantiBindingNavigatorSaveItem"
        Me.CostantiBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CostantiBindingNavigatorSaveItem.Text = "Salva dati"
        '
        'ImmobileComboBox
        '
        Me.ImmobileComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostantiBindingSource, "Immobile", True))
        Me.ImmobileComboBox.FormattingEnabled = True
        Me.ImmobileComboBox.Location = New System.Drawing.Point(15, 65)
        Me.ImmobileComboBox.Name = "ImmobileComboBox"
        Me.ImmobileComboBox.Size = New System.Drawing.Size(291, 21)
        Me.ImmobileComboBox.TabIndex = 2
        '
        'TabellaTextBox
        '
        Me.TabellaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostantiBindingSource, "Tabella", True))
        Me.TabellaTextBox.Location = New System.Drawing.Point(325, 66)
        Me.TabellaTextBox.Name = "TabellaTextBox"
        Me.TabellaTextBox.Size = New System.Drawing.Size(42, 20)
        Me.TabellaTextBox.TabIndex = 4
        '
        'OrdinanteTextBox
        '
        Me.OrdinanteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostantiBindingSource, "Ordinante", True))
        Me.OrdinanteTextBox.Location = New System.Drawing.Point(15, 105)
        Me.OrdinanteTextBox.Name = "OrdinanteTextBox"
        Me.OrdinanteTextBox.Size = New System.Drawing.Size(162, 20)
        Me.OrdinanteTextBox.TabIndex = 6
        '
        'DipendenzaTextBox
        '
        Me.DipendenzaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostantiBindingSource, "Dipendenza", True))
        Me.DipendenzaTextBox.Location = New System.Drawing.Point(186, 105)
        Me.DipendenzaTextBox.Name = "DipendenzaTextBox"
        Me.DipendenzaTextBox.Size = New System.Drawing.Size(120, 20)
        Me.DipendenzaTextBox.TabIndex = 8
        '
        'CategoriaTextBox
        '
        Me.CategoriaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostantiBindingSource, "Categoria", True))
        Me.CategoriaTextBox.Location = New System.Drawing.Point(325, 105)
        Me.CategoriaTextBox.Name = "CategoriaTextBox"
        Me.CategoriaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CategoriaTextBox.TabIndex = 10
        '
        'ContoTextBox
        '
        Me.ContoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostantiBindingSource, "Conto", True))
        Me.ContoTextBox.Location = New System.Drawing.Point(443, 105)
        Me.ContoTextBox.Name = "ContoTextBox"
        Me.ContoTextBox.Size = New System.Drawing.Size(171, 20)
        Me.ContoTextBox.TabIndex = 12
        '
        'Costanti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 172)
        Me.Controls.Add(ContoLabel)
        Me.Controls.Add(Me.ContoTextBox)
        Me.Controls.Add(CategoriaLabel)
        Me.Controls.Add(Me.CategoriaTextBox)
        Me.Controls.Add(DipendenzaLabel)
        Me.Controls.Add(Me.DipendenzaTextBox)
        Me.Controls.Add(OrdinanteLabel)
        Me.Controls.Add(Me.OrdinanteTextBox)
        Me.Controls.Add(TabellaLabel)
        Me.Controls.Add(Me.TabellaTextBox)
        Me.Controls.Add(ImmobileLabel)
        Me.Controls.Add(Me.ImmobileComboBox)
        Me.Controls.Add(Me.CostantiBindingNavigator)
        Me.Name = "Costanti"
        Me.Text = "Costanti per Avvisi"
        CType(Me.IMMOBILIDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CostantiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CostantiBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CostantiBindingNavigator.ResumeLayout(False)
        Me.CostantiBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IMMOBILIDataSet2 As Patrimonio2014.IMMOBILIDataSet2
    Friend WithEvents CostantiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CostantiTableAdapter As Patrimonio2014.IMMOBILIDataSet2TableAdapters.CostantiTableAdapter
    Friend WithEvents TableAdapterManager As Patrimonio2014.IMMOBILIDataSet2TableAdapters.TableAdapterManager
    Friend WithEvents CostantiBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents CostantiBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ImmobileComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TabellaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OrdinanteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DipendenzaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CategoriaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContoTextBox As System.Windows.Forms.TextBox
End Class
