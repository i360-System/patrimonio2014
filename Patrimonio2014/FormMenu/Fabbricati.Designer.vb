<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fabbricati
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
        Dim FabbricatoLabel As System.Windows.Forms.Label
        Dim DescrizioneLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fabbricati))
        Me.IMMOBILIDataSet = New Patrimonio2014.IMMOBILIDataSet()
        Me.FabbricatiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FabbricatiTableAdapter = New Patrimonio2014.IMMOBILIDataSetTableAdapters.FabbricatiTableAdapter()
        Me.TableAdapterManager = New Patrimonio2014.IMMOBILIDataSetTableAdapters.TableAdapterManager()
        Me.Fabbricato = New System.Windows.Forms.TextBox()
        Me.Immobile = New System.Windows.Forms.TextBox()
        Me.Descrizione = New System.Windows.Forms.TextBox()
        Me.AnagraficaStudioBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.AnagraficaStudioBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.IMMOBILIDataSet2 = New Patrimonio2014.IMMOBILIDataSet2()
        Me.FabbricatiDettaglioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FabbricatiDettaglioTableAdapter = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.FabbricatiDettaglioTableAdapter()
        Me.TableAdapterManager1 = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.TableAdapterManager()
        Me.FabbricatiDettaglio = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        ImmobileLabel = New System.Windows.Forms.Label()
        FabbricatoLabel = New System.Windows.Forms.Label()
        DescrizioneLabel = New System.Windows.Forms.Label()
        CType(Me.IMMOBILIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabbricatiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnagraficaStudioBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AnagraficaStudioBindingNavigator.SuspendLayout()
        CType(Me.IMMOBILIDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabbricatiDettaglioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabbricatiDettaglio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImmobileLabel
        '
        ImmobileLabel.AutoSize = True
        ImmobileLabel.Location = New System.Drawing.Point(16, 59)
        ImmobileLabel.Name = "ImmobileLabel"
        ImmobileLabel.Size = New System.Drawing.Size(51, 13)
        ImmobileLabel.TabIndex = 1
        ImmobileLabel.Text = "Immobile:"
        '
        'FabbricatoLabel
        '
        FabbricatoLabel.AutoSize = True
        FabbricatoLabel.Location = New System.Drawing.Point(317, 59)
        FabbricatoLabel.Name = "FabbricatoLabel"
        FabbricatoLabel.Size = New System.Drawing.Size(60, 13)
        FabbricatoLabel.TabIndex = 2
        FabbricatoLabel.Text = "Fabbricato:"
        '
        'DescrizioneLabel
        '
        DescrizioneLabel.AutoSize = True
        DescrizioneLabel.Location = New System.Drawing.Point(16, 99)
        DescrizioneLabel.Name = "DescrizioneLabel"
        DescrizioneLabel.Size = New System.Drawing.Size(65, 13)
        DescrizioneLabel.TabIndex = 4
        DescrizioneLabel.Text = "Descrizione:"
        '
        'IMMOBILIDataSet
        '
        Me.IMMOBILIDataSet.DataSetName = "IMMOBILIDataSet"
        Me.IMMOBILIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FabbricatiBindingSource
        '
        Me.FabbricatiBindingSource.DataMember = "Fabbricati"
        Me.FabbricatiBindingSource.DataSource = Me.IMMOBILIDataSet
        '
        'FabbricatiTableAdapter
        '
        Me.FabbricatiTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AnagraficaStudioTableAdapter = Nothing
        Me.TableAdapterManager.AnagraficheTableAdapter = Nothing
        Me.TableAdapterManager.AssembleaDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.AssembleaTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ContiFinanziariTableAdapter = Nothing
        Me.TableAdapterManager.CostantiDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.CostantiTableAdapter = Nothing
        Me.TableAdapterManager.FabbricatiTableAdapter = Me.FabbricatiTableAdapter
        Me.TableAdapterManager.FondiTableAdapter = Nothing
        Me.TableAdapterManager.FornitoriTableAdapter = Nothing
        Me.TableAdapterManager.GruppiDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.GruppiTableAdapter = Nothing
        Me.TableAdapterManager.ImmobiliTableAdapter = Nothing
        Me.TableAdapterManager.OperatoriTableAdapter = Nothing
        Me.TableAdapterManager.PianoContiConsuntivoDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.PianoContiConsuntivoTableAdapter = Nothing
        Me.TableAdapterManager.PianoContiPreventivoDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.PianoContiPreventivoTableAdapter = Nothing
        Me.TableAdapterManager.ScaleTableAdapter = Nothing
        Me.TableAdapterManager.TabellaDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.TabellaTableAdapter = Nothing
        Me.TableAdapterManager.UnitaDettaglioAnagraficaTableAdapter = Nothing
        Me.TableAdapterManager.UnitaDettaglioLettureTableAdapter = Nothing
        Me.TableAdapterManager.UnitaDettaglioMillesimiTableAdapter = Nothing
        Me.TableAdapterManager.UnitaDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.UnitaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Patrimonio2014.IMMOBILIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.V_ConsuntivoDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.V_ConsuntivoTableAdapter = Nothing
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
        Me.TableAdapterManager.Z_AvvisiDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.Z_AvvisiTableAdapter = Nothing
        Me.TableAdapterManager.Z_BilancioTableAdapter = Nothing
        Me.TableAdapterManager.Z_ConsuntivoDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.Z_ConsuntivoRipartoDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.Z_ConsuntivoRipartoTableAdapter = Nothing
        Me.TableAdapterManager.Z_ConsuntivoTableAdapter = Nothing
        Me.TableAdapterManager.Z_ConvocazioniDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.Z_ConvocazioniTableAdapter = Nothing
        Me.TableAdapterManager.Z_EmissioniTableAdapter = Nothing
        Me.TableAdapterManager.Z_EtichetteTableAdapter = Nothing
        Me.TableAdapterManager.Z_InteressiTableAdapter = Nothing
        Me.TableAdapterManager.Z_PreventivoRipartoDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.Z_PreventivoRipartoTableAdapter = Nothing
        Me.TableAdapterManager.Z_RaffrontoTableAdapter = Nothing
        Me.TableAdapterManager.Z_SaldoTableAdapter = Nothing
        Me.TableAdapterManager.Z_TestoSollecitoTableAdapter = Nothing
        Me.TableAdapterManager.ZZ_RipartoDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.ZZ_RipartoTableAdapter = Nothing
        '
        'Fabbricato
        '
        Me.Fabbricato.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FabbricatiBindingSource, "Fabbricato", True))
        Me.Fabbricato.Location = New System.Drawing.Point(320, 75)
        Me.Fabbricato.Name = "Fabbricato"
        Me.Fabbricato.Size = New System.Drawing.Size(57, 20)
        Me.Fabbricato.TabIndex = 8
        '
        'Immobile
        '
        Me.Immobile.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FabbricatiBindingSource, "Immobile", True))
        Me.Immobile.Location = New System.Drawing.Point(20, 75)
        Me.Immobile.Name = "Immobile"
        Me.Immobile.Size = New System.Drawing.Size(280, 20)
        Me.Immobile.TabIndex = 9
        '
        'Descrizione
        '
        Me.Descrizione.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FabbricatiBindingSource, "Descrizione", True))
        Me.Descrizione.Location = New System.Drawing.Point(20, 119)
        Me.Descrizione.Name = "Descrizione"
        Me.Descrizione.Size = New System.Drawing.Size(357, 20)
        Me.Descrizione.TabIndex = 10
        '
        'AnagraficaStudioBindingNavigator
        '
        Me.AnagraficaStudioBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AnagraficaStudioBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AnagraficaStudioBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AnagraficaStudioBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AnagraficaStudioBindingNavigatorSaveItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator1, Me.ToolStripButton2})
        Me.AnagraficaStudioBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AnagraficaStudioBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AnagraficaStudioBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AnagraficaStudioBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AnagraficaStudioBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AnagraficaStudioBindingNavigator.Name = "AnagraficaStudioBindingNavigator"
        Me.AnagraficaStudioBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AnagraficaStudioBindingNavigator.Size = New System.Drawing.Size(584, 38)
        Me.AnagraficaStudioBindingNavigator.TabIndex = 26
        Me.AnagraficaStudioBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(47, 35)
        Me.BindingNavigatorAddNewItem.Text = "&Nuovo"
        Me.BindingNavigatorAddNewItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(34, 35)
        Me.BindingNavigatorCountItem.Text = "di {0}"
        Me.BindingNavigatorCountItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BindingNavigatorCountItem.ToolTipText = "Numero totale di elementi"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(50, 35)
        Me.BindingNavigatorDeleteItem.Text = "&Elimina"
        Me.BindingNavigatorDeleteItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BindingNavigatorDeleteItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(49, 35)
        Me.ToolStripButton1.Text = "&Ricerca"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'AnagraficaStudioBindingNavigatorSaveItem
        '
        Me.AnagraficaStudioBindingNavigatorSaveItem.Image = CType(resources.GetObject("AnagraficaStudioBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AnagraficaStudioBindingNavigatorSaveItem.Name = "AnagraficaStudioBindingNavigatorSaveItem"
        Me.AnagraficaStudioBindingNavigatorSaveItem.Size = New System.Drawing.Size(38, 35)
        Me.AnagraficaStudioBindingNavigatorSaveItem.Text = "&Salva"
        Me.AnagraficaStudioBindingNavigatorSaveItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 38)
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(43, 35)
        Me.BindingNavigatorMoveFirstItem.Text = "&Primo"
        Me.BindingNavigatorMoveFirstItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(52, 35)
        Me.BindingNavigatorMovePreviousItem.Text = "&Indietro"
        Me.BindingNavigatorMovePreviousItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 38)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posizione"
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 38)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posizione corrente"
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(45, 35)
        Me.BindingNavigatorMoveNextItem.Text = "&Avanti"
        Me.BindingNavigatorMoveNextItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(47, 35)
        Me.BindingNavigatorMoveLastItem.Text = "&Ultimo"
        Me.BindingNavigatorMoveLastItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 38)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(51, 35)
        Me.ToolStripButton2.Text = "Sta&mpa"
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'IMMOBILIDataSet2
        '
        Me.IMMOBILIDataSet2.DataSetName = "IMMOBILIDataSet2"
        Me.IMMOBILIDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FabbricatiDettaglioBindingSource
        '
        Me.FabbricatiDettaglioBindingSource.DataMember = "FabbricatiDettaglio"
        Me.FabbricatiDettaglioBindingSource.DataSource = Me.IMMOBILIDataSet2
        '
        'FabbricatiDettaglioTableAdapter
        '
        Me.FabbricatiDettaglioTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.AnagraficaStudioTableAdapter = Nothing
        Me.TableAdapterManager1.AnagraficheTableAdapter = Nothing
        Me.TableAdapterManager1.AssembleaDettaglioTableAdapter = Nothing
        Me.TableAdapterManager1.AssembleaTableAdapter = Nothing
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.ContiFinanziariTableAdapter = Nothing
        Me.TableAdapterManager1.CostantiDettaglioTableAdapter = Nothing
        Me.TableAdapterManager1.CostantiTableAdapter = Nothing
        Me.TableAdapterManager1.FabbricatiDettaglioTableAdapter = Me.FabbricatiDettaglioTableAdapter
        Me.TableAdapterManager1.FabbricatiTableAdapter = Nothing
        Me.TableAdapterManager1.FondiTableAdapter = Nothing
        Me.TableAdapterManager1.FornitoriTableAdapter = Nothing
        Me.TableAdapterManager1.GruppiDettaglioTableAdapter = Nothing
        Me.TableAdapterManager1.GruppiTableAdapter = Nothing
        Me.TableAdapterManager1.ImmobiliTableAdapter = Nothing
        Me.TableAdapterManager1.PianoContiConsuntivoDettaglioTableAdapter = Nothing
        Me.TableAdapterManager1.PianoContiConsuntivoTableAdapter = Nothing
        Me.TableAdapterManager1.PianoContiPreventivoDettaglioTableAdapter = Nothing
        Me.TableAdapterManager1.PianoContiPreventivoTableAdapter = Nothing
        Me.TableAdapterManager1.TabellaDettaglioTableAdapter = Nothing
        Me.TableAdapterManager1.TabellaTableAdapter = Nothing
        Me.TableAdapterManager1.UnitaDettaglioAnagraficaTableAdapter = Nothing
        Me.TableAdapterManager1.UnitaDettaglioLettureTableAdapter = Nothing
        Me.TableAdapterManager1.UnitaDettaglioMillesimiTableAdapter = Nothing
        Me.TableAdapterManager1.UnitaDettaglioTableAdapter = Nothing
        Me.TableAdapterManager1.UnitaTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = Patrimonio2014.IMMOBILIDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.V_PreventivoDettaglioTableAdapter = Nothing
        Me.TableAdapterManager1.V_PreventivoTableAdapter = Nothing
        Me.TableAdapterManager1.W_EmissioniDettaglioTableAdapter = Nothing
        Me.TableAdapterManager1.W_EmissioniTableAdapter = Nothing
        Me.TableAdapterManager1.W_RitenuteTableAdapter = Nothing
        Me.TableAdapterManager1.W_TributiTableAdapter = Nothing
        Me.TableAdapterManager1.X_CausaliTableAdapter = Nothing
        Me.TableAdapterManager1.X_FattureDettaglioTableAdapter = Nothing
        Me.TableAdapterManager1.X_FattureTableAdapter = Nothing
        Me.TableAdapterManager1.X_MovimentiCondominiTableAdapter = Nothing
        Me.TableAdapterManager1.X_MovimentiFinanziariTableAdapter = Nothing
        Me.TableAdapterManager1.X_MovimentiFondiTableAdapter = Nothing
        Me.TableAdapterManager1.X_SpeseDescrizioniTableAdapter = Nothing
        Me.TableAdapterManager1.X_SpeseTableAdapter = Nothing
        Me.TableAdapterManager1.Y_GestioniDettaglioTableAdapter = Nothing
        Me.TableAdapterManager1.Y_GestioniTableAdapter = Nothing
        Me.TableAdapterManager1.Y_GestioniUnitaDettaglioTableAdapter = Nothing
        Me.TableAdapterManager1.Y_GestioniUnitaTableAdapter = Nothing
        Me.TableAdapterManager1.Z_ConsuntivoDettaglioTableAdapter = Nothing
        Me.TableAdapterManager1.Z_ConsuntivoTableAdapter = Nothing
        Me.TableAdapterManager1.Z_TestoSollecitoTableAdapter = Nothing
        '
        'FabbricatiDettaglio
        '
        Me.FabbricatiDettaglio.AutoGenerateColumns = False
        Me.FabbricatiDettaglio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FabbricatiDettaglio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.FabbricatiDettaglio.DataSource = Me.FabbricatiDettaglioBindingSource
        Me.FabbricatiDettaglio.Location = New System.Drawing.Point(25, 171)
        Me.FabbricatiDettaglio.Name = "FabbricatiDettaglio"
        Me.FabbricatiDettaglio.Size = New System.Drawing.Size(513, 220)
        Me.FabbricatiDettaglio.TabIndex = 26
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Scala"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Scala"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Descrizione"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Descrizione"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 200
        '
        'Fabbricati
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 415)
        Me.Controls.Add(Me.FabbricatiDettaglio)
        Me.Controls.Add(Me.AnagraficaStudioBindingNavigator)
        Me.Controls.Add(Me.Descrizione)
        Me.Controls.Add(Me.Immobile)
        Me.Controls.Add(Me.Fabbricato)
        Me.Controls.Add(DescrizioneLabel)
        Me.Controls.Add(FabbricatoLabel)
        Me.Controls.Add(ImmobileLabel)
        Me.Name = "Fabbricati"
        Me.Text = "Struttura Fabbricato"
        CType(Me.IMMOBILIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabbricatiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnagraficaStudioBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AnagraficaStudioBindingNavigator.ResumeLayout(False)
        Me.AnagraficaStudioBindingNavigator.PerformLayout()
        CType(Me.IMMOBILIDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabbricatiDettaglioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabbricatiDettaglio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IMMOBILIDataSet As Patrimonio2014.IMMOBILIDataSet
    Friend WithEvents FabbricatiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FabbricatiTableAdapter As Patrimonio2014.IMMOBILIDataSetTableAdapters.FabbricatiTableAdapter
    Friend WithEvents TableAdapterManager As Patrimonio2014.IMMOBILIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Fabbricato As System.Windows.Forms.TextBox
    Friend WithEvents Immobile As System.Windows.Forms.TextBox
    Friend WithEvents Descrizione As System.Windows.Forms.TextBox
    Friend WithEvents AnagraficaStudioBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents AnagraficaStudioBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents IMMOBILIDataSet2 As Patrimonio2014.IMMOBILIDataSet2
    Friend WithEvents FabbricatiDettaglioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FabbricatiDettaglioTableAdapter As Patrimonio2014.IMMOBILIDataSet2TableAdapters.FabbricatiDettaglioTableAdapter
    Friend WithEvents TableAdapterManager1 As Patrimonio2014.IMMOBILIDataSet2TableAdapters.TableAdapterManager
    Friend WithEvents FabbricatiDettaglio As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
