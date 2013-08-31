<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnagraficaStudio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AnagraficaStudio))
        Dim StudioLabel As System.Windows.Forms.Label
        Dim Denominazione1Label As System.Windows.Forms.Label
        Dim IndirizzoLabel As System.Windows.Forms.Label
        Dim CapLabel As System.Windows.Forms.Label
        Dim LocalitaLabel As System.Windows.Forms.Label
        Dim ProvinciaLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim CodiceFiscaleLabel As System.Windows.Forms.Label
        Dim PartitaIvaLabel As System.Windows.Forms.Label
        Dim TipoSocietaLabel As System.Windows.Forms.Label
        Dim Note1Label As System.Windows.Forms.Label
        Me.IMMOBILIDataSet2 = New Patrimonio2014.IMMOBILIDataSet2()
        Me.AnagraficaStudioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnagraficaStudioTableAdapter = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.AnagraficaStudioTableAdapter()
        Me.TableAdapterManager = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.TableAdapterManager()
        Me.AnagraficaStudioBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.AnagraficaStudioBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.StudioTextBox = New System.Windows.Forms.TextBox()
        Me.Denominazione1TextBox = New System.Windows.Forms.TextBox()
        Me.Denominazione2TextBox = New System.Windows.Forms.TextBox()
        Me.IndirizzoTextBox = New System.Windows.Forms.TextBox()
        Me.CapTextBox = New System.Windows.Forms.TextBox()
        Me.LocalitaTextBox = New System.Windows.Forms.TextBox()
        Me.ProvinciaTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.CodiceFiscaleTextBox = New System.Windows.Forms.TextBox()
        Me.PartitaIvaTextBox = New System.Windows.Forms.TextBox()
        Me.TipoSocietaTextBox = New System.Windows.Forms.TextBox()
        Me.Note1TextBox = New System.Windows.Forms.TextBox()
        Me.Note2TextBox = New System.Windows.Forms.TextBox()
        StudioLabel = New System.Windows.Forms.Label()
        Denominazione1Label = New System.Windows.Forms.Label()
        IndirizzoLabel = New System.Windows.Forms.Label()
        CapLabel = New System.Windows.Forms.Label()
        LocalitaLabel = New System.Windows.Forms.Label()
        ProvinciaLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        CodiceFiscaleLabel = New System.Windows.Forms.Label()
        PartitaIvaLabel = New System.Windows.Forms.Label()
        TipoSocietaLabel = New System.Windows.Forms.Label()
        Note1Label = New System.Windows.Forms.Label()
        CType(Me.IMMOBILIDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnagraficaStudioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnagraficaStudioBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AnagraficaStudioBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IMMOBILIDataSet2
        '
        Me.IMMOBILIDataSet2.DataSetName = "IMMOBILIDataSet2"
        Me.IMMOBILIDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AnagraficaStudioBindingSource
        '
        Me.AnagraficaStudioBindingSource.DataMember = "AnagraficaStudio"
        Me.AnagraficaStudioBindingSource.DataSource = Me.IMMOBILIDataSet2
        '
        'AnagraficaStudioTableAdapter
        '
        Me.AnagraficaStudioTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AnagraficaStudioTableAdapter = Me.AnagraficaStudioTableAdapter
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
        Me.TableAdapterManager.Z_TestoSollecitoTableAdapter = Nothing
        '
        'AnagraficaStudioBindingNavigator
        '
        Me.AnagraficaStudioBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AnagraficaStudioBindingNavigator.BindingSource = Me.AnagraficaStudioBindingSource
        Me.AnagraficaStudioBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AnagraficaStudioBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AnagraficaStudioBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AnagraficaStudioBindingNavigatorSaveItem})
        Me.AnagraficaStudioBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AnagraficaStudioBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AnagraficaStudioBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AnagraficaStudioBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AnagraficaStudioBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AnagraficaStudioBindingNavigator.Name = "AnagraficaStudioBindingNavigator"
        Me.AnagraficaStudioBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AnagraficaStudioBindingNavigator.Size = New System.Drawing.Size(627, 25)
        Me.AnagraficaStudioBindingNavigator.TabIndex = 0
        Me.AnagraficaStudioBindingNavigator.Text = "BindingNavigator1"
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
        'AnagraficaStudioBindingNavigatorSaveItem
        '
        Me.AnagraficaStudioBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AnagraficaStudioBindingNavigatorSaveItem.Image = CType(resources.GetObject("AnagraficaStudioBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AnagraficaStudioBindingNavigatorSaveItem.Name = "AnagraficaStudioBindingNavigatorSaveItem"
        Me.AnagraficaStudioBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.AnagraficaStudioBindingNavigatorSaveItem.Text = "Salva dati"
        '
        'StudioLabel
        '
        StudioLabel.AutoSize = True
        StudioLabel.Location = New System.Drawing.Point(12, 38)
        StudioLabel.Name = "StudioLabel"
        StudioLabel.Size = New System.Drawing.Size(40, 13)
        StudioLabel.TabIndex = 1
        StudioLabel.Text = "Studio:"
        '
        'StudioTextBox
        '
        Me.StudioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaStudioBindingSource, "Studio", True))
        Me.StudioTextBox.Location = New System.Drawing.Point(15, 54)
        Me.StudioTextBox.Name = "StudioTextBox"
        Me.StudioTextBox.Size = New System.Drawing.Size(52, 20)
        Me.StudioTextBox.TabIndex = 2
        '
        'Denominazione1Label
        '
        Denominazione1Label.AutoSize = True
        Denominazione1Label.Location = New System.Drawing.Point(80, 38)
        Denominazione1Label.Name = "Denominazione1Label"
        Denominazione1Label.Size = New System.Drawing.Size(83, 13)
        Denominazione1Label.TabIndex = 3
        Denominazione1Label.Text = "Denominazione:"
        '
        'Denominazione1TextBox
        '
        Me.Denominazione1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaStudioBindingSource, "Denominazione1", True))
        Me.Denominazione1TextBox.Location = New System.Drawing.Point(83, 54)
        Me.Denominazione1TextBox.Name = "Denominazione1TextBox"
        Me.Denominazione1TextBox.Size = New System.Drawing.Size(330, 20)
        Me.Denominazione1TextBox.TabIndex = 4
        '
        'Denominazione2TextBox
        '
        Me.Denominazione2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaStudioBindingSource, "Denominazione2", True))
        Me.Denominazione2TextBox.Location = New System.Drawing.Point(83, 80)
        Me.Denominazione2TextBox.Name = "Denominazione2TextBox"
        Me.Denominazione2TextBox.Size = New System.Drawing.Size(330, 20)
        Me.Denominazione2TextBox.TabIndex = 6
        '
        'IndirizzoLabel
        '
        IndirizzoLabel.AutoSize = True
        IndirizzoLabel.Location = New System.Drawing.Point(80, 103)
        IndirizzoLabel.Name = "IndirizzoLabel"
        IndirizzoLabel.Size = New System.Drawing.Size(48, 13)
        IndirizzoLabel.TabIndex = 6
        IndirizzoLabel.Text = "Indirizzo:"
        '
        'IndirizzoTextBox
        '
        Me.IndirizzoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaStudioBindingSource, "Indirizzo", True))
        Me.IndirizzoTextBox.Location = New System.Drawing.Point(83, 119)
        Me.IndirizzoTextBox.Name = "IndirizzoTextBox"
        Me.IndirizzoTextBox.Size = New System.Drawing.Size(330, 20)
        Me.IndirizzoTextBox.TabIndex = 7
        '
        'CapLabel
        '
        CapLabel.AutoSize = True
        CapLabel.Location = New System.Drawing.Point(12, 142)
        CapLabel.Name = "CapLabel"
        CapLabel.Size = New System.Drawing.Size(29, 13)
        CapLabel.TabIndex = 8
        CapLabel.Text = "Cap:"
        '
        'CapTextBox
        '
        Me.CapTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaStudioBindingSource, "Cap", True))
        Me.CapTextBox.Location = New System.Drawing.Point(12, 158)
        Me.CapTextBox.Name = "CapTextBox"
        Me.CapTextBox.Size = New System.Drawing.Size(52, 20)
        Me.CapTextBox.TabIndex = 9
        '
        'LocalitaLabel
        '
        LocalitaLabel.AutoSize = True
        LocalitaLabel.Location = New System.Drawing.Point(81, 142)
        LocalitaLabel.Name = "LocalitaLabel"
        LocalitaLabel.Size = New System.Drawing.Size(47, 13)
        LocalitaLabel.TabIndex = 10
        LocalitaLabel.Text = "Localita:"
        '
        'LocalitaTextBox
        '
        Me.LocalitaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaStudioBindingSource, "Localita", True))
        Me.LocalitaTextBox.Location = New System.Drawing.Point(84, 158)
        Me.LocalitaTextBox.Name = "LocalitaTextBox"
        Me.LocalitaTextBox.Size = New System.Drawing.Size(329, 20)
        Me.LocalitaTextBox.TabIndex = 11
        '
        'ProvinciaLabel
        '
        ProvinciaLabel.AutoSize = True
        ProvinciaLabel.Location = New System.Drawing.Point(419, 142)
        ProvinciaLabel.Name = "ProvinciaLabel"
        ProvinciaLabel.Size = New System.Drawing.Size(54, 13)
        ProvinciaLabel.TabIndex = 12
        ProvinciaLabel.Text = "Provincia:"
        '
        'ProvinciaTextBox
        '
        Me.ProvinciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaStudioBindingSource, "Provincia", True))
        Me.ProvinciaTextBox.Location = New System.Drawing.Point(422, 158)
        Me.ProvinciaTextBox.Name = "ProvinciaTextBox"
        Me.ProvinciaTextBox.Size = New System.Drawing.Size(51, 20)
        Me.ProvinciaTextBox.TabIndex = 13
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(81, 202)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(52, 13)
        TelefonoLabel.TabIndex = 14
        TelefonoLabel.Text = "Telefono:"
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaStudioBindingSource, "Telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(83, 218)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(330, 20)
        Me.TelefonoTextBox.TabIndex = 15
        '
        'CodiceFiscaleLabel
        '
        CodiceFiscaleLabel.AutoSize = True
        CodiceFiscaleLabel.Location = New System.Drawing.Point(81, 241)
        CodiceFiscaleLabel.Name = "CodiceFiscaleLabel"
        CodiceFiscaleLabel.Size = New System.Drawing.Size(79, 13)
        CodiceFiscaleLabel.TabIndex = 16
        CodiceFiscaleLabel.Text = "Codice Fiscale:"
        '
        'CodiceFiscaleTextBox
        '
        Me.CodiceFiscaleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaStudioBindingSource, "CodiceFiscale", True))
        Me.CodiceFiscaleTextBox.Location = New System.Drawing.Point(83, 257)
        Me.CodiceFiscaleTextBox.Name = "CodiceFiscaleTextBox"
        Me.CodiceFiscaleTextBox.Size = New System.Drawing.Size(167, 20)
        Me.CodiceFiscaleTextBox.TabIndex = 17
        '
        'PartitaIvaLabel
        '
        PartitaIvaLabel.AutoSize = True
        PartitaIvaLabel.Location = New System.Drawing.Point(256, 241)
        PartitaIvaLabel.Name = "PartitaIvaLabel"
        PartitaIvaLabel.Size = New System.Drawing.Size(58, 13)
        PartitaIvaLabel.TabIndex = 18
        PartitaIvaLabel.Text = "Partita Iva:"
        '
        'PartitaIvaTextBox
        '
        Me.PartitaIvaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaStudioBindingSource, "PartitaIva", True))
        Me.PartitaIvaTextBox.Location = New System.Drawing.Point(259, 257)
        Me.PartitaIvaTextBox.Name = "PartitaIvaTextBox"
        Me.PartitaIvaTextBox.Size = New System.Drawing.Size(154, 20)
        Me.PartitaIvaTextBox.TabIndex = 19
        '
        'TipoSocietaLabel
        '
        TipoSocietaLabel.AutoSize = True
        TipoSocietaLabel.Location = New System.Drawing.Point(419, 241)
        TipoSocietaLabel.Name = "TipoSocietaLabel"
        TipoSocietaLabel.Size = New System.Drawing.Size(70, 13)
        TipoSocietaLabel.TabIndex = 20
        TipoSocietaLabel.Text = "Tipo Societa:"
        '
        'TipoSocietaTextBox
        '
        Me.TipoSocietaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaStudioBindingSource, "TipoSocieta", True))
        Me.TipoSocietaTextBox.Location = New System.Drawing.Point(422, 257)
        Me.TipoSocietaTextBox.Name = "TipoSocietaTextBox"
        Me.TipoSocietaTextBox.Size = New System.Drawing.Size(67, 20)
        Me.TipoSocietaTextBox.TabIndex = 21
        '
        'Note1Label
        '
        Note1Label.AutoSize = True
        Note1Label.Location = New System.Drawing.Point(81, 280)
        Note1Label.Name = "Note1Label"
        Note1Label.Size = New System.Drawing.Size(33, 13)
        Note1Label.TabIndex = 22
        Note1Label.Text = "Note:"
        '
        'Note1TextBox
        '
        Me.Note1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaStudioBindingSource, "Note1", True))
        Me.Note1TextBox.Location = New System.Drawing.Point(84, 296)
        Me.Note1TextBox.Name = "Note1TextBox"
        Me.Note1TextBox.Size = New System.Drawing.Size(405, 20)
        Me.Note1TextBox.TabIndex = 23
        '
        'Note2TextBox
        '
        Me.Note2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaStudioBindingSource, "Note2", True))
        Me.Note2TextBox.Location = New System.Drawing.Point(84, 322)
        Me.Note2TextBox.Name = "Note2TextBox"
        Me.Note2TextBox.Size = New System.Drawing.Size(405, 20)
        Me.Note2TextBox.TabIndex = 25
        '
        'AnagraficaStudio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 372)
        Me.Controls.Add(Me.Note2TextBox)
        Me.Controls.Add(Note1Label)
        Me.Controls.Add(Me.Note1TextBox)
        Me.Controls.Add(TipoSocietaLabel)
        Me.Controls.Add(Me.TipoSocietaTextBox)
        Me.Controls.Add(PartitaIvaLabel)
        Me.Controls.Add(Me.PartitaIvaTextBox)
        Me.Controls.Add(CodiceFiscaleLabel)
        Me.Controls.Add(Me.CodiceFiscaleTextBox)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(ProvinciaLabel)
        Me.Controls.Add(Me.ProvinciaTextBox)
        Me.Controls.Add(LocalitaLabel)
        Me.Controls.Add(Me.LocalitaTextBox)
        Me.Controls.Add(CapLabel)
        Me.Controls.Add(Me.CapTextBox)
        Me.Controls.Add(IndirizzoLabel)
        Me.Controls.Add(Me.IndirizzoTextBox)
        Me.Controls.Add(Me.Denominazione2TextBox)
        Me.Controls.Add(Denominazione1Label)
        Me.Controls.Add(Me.Denominazione1TextBox)
        Me.Controls.Add(StudioLabel)
        Me.Controls.Add(Me.StudioTextBox)
        Me.Controls.Add(Me.AnagraficaStudioBindingNavigator)
        Me.Name = "AnagraficaStudio"
        Me.Text = "AnagraficaStudio"
        CType(Me.IMMOBILIDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnagraficaStudioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnagraficaStudioBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AnagraficaStudioBindingNavigator.ResumeLayout(False)
        Me.AnagraficaStudioBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IMMOBILIDataSet2 As Patrimonio2014.IMMOBILIDataSet2
    Friend WithEvents AnagraficaStudioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AnagraficaStudioTableAdapter As Patrimonio2014.IMMOBILIDataSet2TableAdapters.AnagraficaStudioTableAdapter
    Friend WithEvents TableAdapterManager As Patrimonio2014.IMMOBILIDataSet2TableAdapters.TableAdapterManager
    Friend WithEvents AnagraficaStudioBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents AnagraficaStudioBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents StudioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Denominazione1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Denominazione2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents IndirizzoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CapTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LocalitaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProvinciaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CodiceFiscaleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PartitaIvaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TipoSocietaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Note1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Note2TextBox As System.Windows.Forms.TextBox
End Class
