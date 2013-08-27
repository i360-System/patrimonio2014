<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class X_Causali
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
        Dim CausaleLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(X_Causali))
        Dim DescrizioneLabel As System.Windows.Forms.Label
        Dim Riga1Label As System.Windows.Forms.Label
        Me.IMMOBILIDataSet2 = New Patrimonio2014.IMMOBILIDataSet2()
        Me.X_CausaliBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.X_CausaliTableAdapter = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.X_CausaliTableAdapter()
        Me.TableAdapterManager = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.TableAdapterManager()
        Me.X_CausaliBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.X_CausaliBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CausaleTextBox = New System.Windows.Forms.TextBox()
        Me.DescrizioneTextBox = New System.Windows.Forms.TextBox()
        Me.Riga1TextBox = New System.Windows.Forms.TextBox()
        Me.Riga2TextBox = New System.Windows.Forms.TextBox()
        Me.Riga3TextBox = New System.Windows.Forms.TextBox()
        Me.Riga4TextBox = New System.Windows.Forms.TextBox()
        Me.Riga5TextBox = New System.Windows.Forms.TextBox()
        Me.Riga6TextBox = New System.Windows.Forms.TextBox()
        Me.Riga7TextBox = New System.Windows.Forms.TextBox()
        CausaleLabel = New System.Windows.Forms.Label()
        DescrizioneLabel = New System.Windows.Forms.Label()
        Riga1Label = New System.Windows.Forms.Label()
        CType(Me.IMMOBILIDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X_CausaliBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X_CausaliBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.X_CausaliBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'CausaleLabel
        '
        CausaleLabel.AutoSize = True
        CausaleLabel.Location = New System.Drawing.Point(12, 35)
        CausaleLabel.Name = "CausaleLabel"
        CausaleLabel.Size = New System.Drawing.Size(48, 13)
        CausaleLabel.TabIndex = 1
        CausaleLabel.Text = "Causale:"
        '
        'IMMOBILIDataSet2
        '
        Me.IMMOBILIDataSet2.DataSetName = "IMMOBILIDataSet2"
        Me.IMMOBILIDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'X_CausaliBindingSource
        '
        Me.X_CausaliBindingSource.DataMember = "X_Causali"
        Me.X_CausaliBindingSource.DataSource = Me.IMMOBILIDataSet2
        '
        'X_CausaliTableAdapter
        '
        Me.X_CausaliTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.X_CausaliTableAdapter = Me.X_CausaliTableAdapter
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
        'X_CausaliBindingNavigator
        '
        Me.X_CausaliBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.X_CausaliBindingNavigator.BindingSource = Me.X_CausaliBindingSource
        Me.X_CausaliBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.X_CausaliBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.X_CausaliBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.X_CausaliBindingNavigatorSaveItem})
        Me.X_CausaliBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.X_CausaliBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.X_CausaliBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.X_CausaliBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.X_CausaliBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.X_CausaliBindingNavigator.Name = "X_CausaliBindingNavigator"
        Me.X_CausaliBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.X_CausaliBindingNavigator.Size = New System.Drawing.Size(520, 25)
        Me.X_CausaliBindingNavigator.TabIndex = 0
        Me.X_CausaliBindingNavigator.Text = "BindingNavigator1"
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
        'X_CausaliBindingNavigatorSaveItem
        '
        Me.X_CausaliBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.X_CausaliBindingNavigatorSaveItem.Image = CType(resources.GetObject("X_CausaliBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.X_CausaliBindingNavigatorSaveItem.Name = "X_CausaliBindingNavigatorSaveItem"
        Me.X_CausaliBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.X_CausaliBindingNavigatorSaveItem.Text = "Salva dati"
        '
        'CausaleTextBox
        '
        Me.CausaleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_CausaliBindingSource, "Causale", True))
        Me.CausaleTextBox.Location = New System.Drawing.Point(15, 51)
        Me.CausaleTextBox.Name = "CausaleTextBox"
        Me.CausaleTextBox.Size = New System.Drawing.Size(45, 20)
        Me.CausaleTextBox.TabIndex = 2
        '
        'DescrizioneLabel
        '
        DescrizioneLabel.AutoSize = True
        DescrizioneLabel.Location = New System.Drawing.Point(66, 35)
        DescrizioneLabel.Name = "DescrizioneLabel"
        DescrizioneLabel.Size = New System.Drawing.Size(65, 13)
        DescrizioneLabel.TabIndex = 3
        DescrizioneLabel.Text = "Descrizione:"
        '
        'DescrizioneTextBox
        '
        Me.DescrizioneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_CausaliBindingSource, "Descrizione", True))
        Me.DescrizioneTextBox.Location = New System.Drawing.Point(69, 51)
        Me.DescrizioneTextBox.Name = "DescrizioneTextBox"
        Me.DescrizioneTextBox.Size = New System.Drawing.Size(431, 20)
        Me.DescrizioneTextBox.TabIndex = 4
        '
        'Riga1Label
        '
        Riga1Label.AutoSize = True
        Riga1Label.Location = New System.Drawing.Point(66, 74)
        Riga1Label.Name = "Riga1Label"
        Riga1Label.Size = New System.Drawing.Size(37, 13)
        Riga1Label.TabIndex = 5
        Riga1Label.Text = "Testo:"
        '
        'Riga1TextBox
        '
        Me.Riga1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_CausaliBindingSource, "Riga1", True))
        Me.Riga1TextBox.Location = New System.Drawing.Point(69, 90)
        Me.Riga1TextBox.Name = "Riga1TextBox"
        Me.Riga1TextBox.Size = New System.Drawing.Size(431, 20)
        Me.Riga1TextBox.TabIndex = 6
        '
        'Riga2TextBox
        '
        Me.Riga2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_CausaliBindingSource, "Riga2", True))
        Me.Riga2TextBox.Location = New System.Drawing.Point(69, 116)
        Me.Riga2TextBox.Name = "Riga2TextBox"
        Me.Riga2TextBox.Size = New System.Drawing.Size(431, 20)
        Me.Riga2TextBox.TabIndex = 8
        '
        'Riga3TextBox
        '
        Me.Riga3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_CausaliBindingSource, "Riga3", True))
        Me.Riga3TextBox.Location = New System.Drawing.Point(69, 142)
        Me.Riga3TextBox.Name = "Riga3TextBox"
        Me.Riga3TextBox.Size = New System.Drawing.Size(431, 20)
        Me.Riga3TextBox.TabIndex = 9
        '
        'Riga4TextBox
        '
        Me.Riga4TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_CausaliBindingSource, "Riga4", True))
        Me.Riga4TextBox.Location = New System.Drawing.Point(69, 168)
        Me.Riga4TextBox.Name = "Riga4TextBox"
        Me.Riga4TextBox.Size = New System.Drawing.Size(431, 20)
        Me.Riga4TextBox.TabIndex = 10
        '
        'Riga5TextBox
        '
        Me.Riga5TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_CausaliBindingSource, "Riga5", True))
        Me.Riga5TextBox.Location = New System.Drawing.Point(69, 194)
        Me.Riga5TextBox.Name = "Riga5TextBox"
        Me.Riga5TextBox.Size = New System.Drawing.Size(431, 20)
        Me.Riga5TextBox.TabIndex = 11
        '
        'Riga6TextBox
        '
        Me.Riga6TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_CausaliBindingSource, "Riga6", True))
        Me.Riga6TextBox.Location = New System.Drawing.Point(69, 220)
        Me.Riga6TextBox.Name = "Riga6TextBox"
        Me.Riga6TextBox.Size = New System.Drawing.Size(431, 20)
        Me.Riga6TextBox.TabIndex = 12
        '
        'Riga7TextBox
        '
        Me.Riga7TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_CausaliBindingSource, "Riga7", True))
        Me.Riga7TextBox.Location = New System.Drawing.Point(69, 246)
        Me.Riga7TextBox.Name = "Riga7TextBox"
        Me.Riga7TextBox.Size = New System.Drawing.Size(431, 20)
        Me.Riga7TextBox.TabIndex = 13
        '
        'X_Causali
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 287)
        Me.Controls.Add(Me.Riga7TextBox)
        Me.Controls.Add(Me.Riga6TextBox)
        Me.Controls.Add(Me.Riga5TextBox)
        Me.Controls.Add(Me.Riga4TextBox)
        Me.Controls.Add(Me.Riga3TextBox)
        Me.Controls.Add(Me.Riga2TextBox)
        Me.Controls.Add(Riga1Label)
        Me.Controls.Add(Me.Riga1TextBox)
        Me.Controls.Add(DescrizioneLabel)
        Me.Controls.Add(Me.DescrizioneTextBox)
        Me.Controls.Add(CausaleLabel)
        Me.Controls.Add(Me.CausaleTextBox)
        Me.Controls.Add(Me.X_CausaliBindingNavigator)
        Me.Name = "X_Causali"
        Me.Text = "Causali per la Registrazione delle Spese"
        CType(Me.IMMOBILIDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X_CausaliBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X_CausaliBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.X_CausaliBindingNavigator.ResumeLayout(False)
        Me.X_CausaliBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IMMOBILIDataSet2 As Patrimonio2014.IMMOBILIDataSet2
    Friend WithEvents X_CausaliBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents X_CausaliTableAdapter As Patrimonio2014.IMMOBILIDataSet2TableAdapters.X_CausaliTableAdapter
    Friend WithEvents TableAdapterManager As Patrimonio2014.IMMOBILIDataSet2TableAdapters.TableAdapterManager
    Friend WithEvents X_CausaliBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents X_CausaliBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CausaleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescrizioneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Riga1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Riga2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Riga3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Riga4TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Riga5TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Riga6TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Riga7TextBox As System.Windows.Forms.TextBox
End Class
