<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Z_TestoSollecito
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
        Dim TestoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Z_TestoSollecito))
        Dim Riga1Label As System.Windows.Forms.Label
        Me.IMMOBILIDataSet2 = New Patrimonio2014.IMMOBILIDataSet2()
        Me.Z_TestoSollecitoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Z_TestoSollecitoTableAdapter = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.Z_TestoSollecitoTableAdapter()
        Me.TableAdapterManager = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.TableAdapterManager()
        Me.Z_TestoSollecitoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Z_TestoSollecitoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TestoTextBox = New System.Windows.Forms.TextBox()
        Me.Riga1TextBox = New System.Windows.Forms.TextBox()
        Me.Riga2TextBox = New System.Windows.Forms.TextBox()
        Me.Riga3TextBox = New System.Windows.Forms.TextBox()
        Me.Riga4TextBox = New System.Windows.Forms.TextBox()
        Me.Riga5TextBox = New System.Windows.Forms.TextBox()
        TestoLabel = New System.Windows.Forms.Label()
        Riga1Label = New System.Windows.Forms.Label()
        CType(Me.IMMOBILIDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Z_TestoSollecitoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Z_TestoSollecitoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Z_TestoSollecitoBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'TestoLabel
        '
        TestoLabel.AutoSize = True
        TestoLabel.Location = New System.Drawing.Point(12, 45)
        TestoLabel.Name = "TestoLabel"
        TestoLabel.Size = New System.Drawing.Size(47, 13)
        TestoLabel.TabIndex = 1
        TestoLabel.Text = "Numero:"
        '
        'IMMOBILIDataSet2
        '
        Me.IMMOBILIDataSet2.DataSetName = "IMMOBILIDataSet2"
        Me.IMMOBILIDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Z_TestoSollecitoBindingSource
        '
        Me.Z_TestoSollecitoBindingSource.DataMember = "Z_TestoSollecito"
        Me.Z_TestoSollecitoBindingSource.DataSource = Me.IMMOBILIDataSet2
        '
        'Z_TestoSollecitoTableAdapter
        '
        Me.Z_TestoSollecitoTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Z_TestoSollecitoTableAdapter = Me.Z_TestoSollecitoTableAdapter
        '
        'Z_TestoSollecitoBindingNavigator
        '
        Me.Z_TestoSollecitoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Z_TestoSollecitoBindingNavigator.BindingSource = Me.Z_TestoSollecitoBindingSource
        Me.Z_TestoSollecitoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Z_TestoSollecitoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Z_TestoSollecitoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Z_TestoSollecitoBindingNavigatorSaveItem})
        Me.Z_TestoSollecitoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Z_TestoSollecitoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Z_TestoSollecitoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Z_TestoSollecitoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Z_TestoSollecitoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Z_TestoSollecitoBindingNavigator.Name = "Z_TestoSollecitoBindingNavigator"
        Me.Z_TestoSollecitoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Z_TestoSollecitoBindingNavigator.Size = New System.Drawing.Size(632, 25)
        Me.Z_TestoSollecitoBindingNavigator.TabIndex = 0
        Me.Z_TestoSollecitoBindingNavigator.Text = "BindingNavigator1"
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
        'Z_TestoSollecitoBindingNavigatorSaveItem
        '
        Me.Z_TestoSollecitoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Z_TestoSollecitoBindingNavigatorSaveItem.Image = CType(resources.GetObject("Z_TestoSollecitoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Z_TestoSollecitoBindingNavigatorSaveItem.Name = "Z_TestoSollecitoBindingNavigatorSaveItem"
        Me.Z_TestoSollecitoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Z_TestoSollecitoBindingNavigatorSaveItem.Text = "Salva dati"
        '
        'TestoTextBox
        '
        Me.TestoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Z_TestoSollecitoBindingSource, "Testo", True))
        Me.TestoTextBox.Location = New System.Drawing.Point(15, 61)
        Me.TestoTextBox.Name = "TestoTextBox"
        Me.TestoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TestoTextBox.TabIndex = 2
        '
        'Riga1Label
        '
        Riga1Label.AutoSize = True
        Riga1Label.Location = New System.Drawing.Point(121, 45)
        Riga1Label.Name = "Riga1Label"
        Riga1Label.Size = New System.Drawing.Size(37, 13)
        Riga1Label.TabIndex = 3
        Riga1Label.Text = "Testo:"
        '
        'Riga1TextBox
        '
        Me.Riga1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Z_TestoSollecitoBindingSource, "Riga1", True))
        Me.Riga1TextBox.Location = New System.Drawing.Point(124, 61)
        Me.Riga1TextBox.Name = "Riga1TextBox"
        Me.Riga1TextBox.Size = New System.Drawing.Size(456, 20)
        Me.Riga1TextBox.TabIndex = 4
        '
        'Riga2TextBox
        '
        Me.Riga2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Z_TestoSollecitoBindingSource, "Riga2", True))
        Me.Riga2TextBox.Location = New System.Drawing.Point(124, 87)
        Me.Riga2TextBox.Name = "Riga2TextBox"
        Me.Riga2TextBox.Size = New System.Drawing.Size(456, 20)
        Me.Riga2TextBox.TabIndex = 6
        '
        'Riga3TextBox
        '
        Me.Riga3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Z_TestoSollecitoBindingSource, "Riga3", True))
        Me.Riga3TextBox.Location = New System.Drawing.Point(124, 113)
        Me.Riga3TextBox.Name = "Riga3TextBox"
        Me.Riga3TextBox.Size = New System.Drawing.Size(456, 20)
        Me.Riga3TextBox.TabIndex = 7
        '
        'Riga4TextBox
        '
        Me.Riga4TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Z_TestoSollecitoBindingSource, "Riga4", True))
        Me.Riga4TextBox.Location = New System.Drawing.Point(124, 139)
        Me.Riga4TextBox.Name = "Riga4TextBox"
        Me.Riga4TextBox.Size = New System.Drawing.Size(456, 20)
        Me.Riga4TextBox.TabIndex = 8
        '
        'Riga5TextBox
        '
        Me.Riga5TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Z_TestoSollecitoBindingSource, "Riga5", True))
        Me.Riga5TextBox.Location = New System.Drawing.Point(124, 165)
        Me.Riga5TextBox.Name = "Riga5TextBox"
        Me.Riga5TextBox.Size = New System.Drawing.Size(456, 20)
        Me.Riga5TextBox.TabIndex = 9
        '
        'Z_TestoSollecito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 273)
        Me.Controls.Add(Me.Riga5TextBox)
        Me.Controls.Add(Me.Riga4TextBox)
        Me.Controls.Add(Me.Riga3TextBox)
        Me.Controls.Add(Me.Riga2TextBox)
        Me.Controls.Add(Riga1Label)
        Me.Controls.Add(Me.Riga1TextBox)
        Me.Controls.Add(TestoLabel)
        Me.Controls.Add(Me.TestoTextBox)
        Me.Controls.Add(Me.Z_TestoSollecitoBindingNavigator)
        Me.Name = "Z_TestoSollecito"
        Me.Text = "Testi per il Sollecito"
        CType(Me.IMMOBILIDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Z_TestoSollecitoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Z_TestoSollecitoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Z_TestoSollecitoBindingNavigator.ResumeLayout(False)
        Me.Z_TestoSollecitoBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IMMOBILIDataSet2 As Patrimonio2014.IMMOBILIDataSet2
    Friend WithEvents Z_TestoSollecitoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Z_TestoSollecitoTableAdapter As Patrimonio2014.IMMOBILIDataSet2TableAdapters.Z_TestoSollecitoTableAdapter
    Friend WithEvents TableAdapterManager As Patrimonio2014.IMMOBILIDataSet2TableAdapters.TableAdapterManager
    Friend WithEvents Z_TestoSollecitoBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Z_TestoSollecitoBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TestoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Riga1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Riga2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Riga3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Riga4TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Riga5TextBox As System.Windows.Forms.TextBox
End Class
