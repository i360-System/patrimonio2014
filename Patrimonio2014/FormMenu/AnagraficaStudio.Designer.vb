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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AnagraficaStudio))
        Me.IMMOBILIDataSet = New Patrimonio2014.IMMOBILIDataSet()
        Me.AnagraficaStudioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnagraficaStudioTableAdapter = New Patrimonio2014.IMMOBILIDataSetTableAdapters.AnagraficaStudioTableAdapter()
        Me.TableAdapterManager = New Patrimonio2014.IMMOBILIDataSetTableAdapters.TableAdapterManager()
        Me.AnagraficaStudioBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.AnagraficaStudioBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Studio = New System.Windows.Forms.TextBox()
        Me.Denominazione1 = New System.Windows.Forms.TextBox()
        Me.Denominazione2 = New System.Windows.Forms.TextBox()
        Me.Indirizzo = New System.Windows.Forms.TextBox()
        Me.Cap = New System.Windows.Forms.TextBox()
        Me.Provincia = New System.Windows.Forms.TextBox()
        Me.Telefono = New System.Windows.Forms.TextBox()
        Me.TipoSocieta = New System.Windows.Forms.TextBox()
        Me.Note1 = New System.Windows.Forms.TextBox()
        Me.Note2 = New System.Windows.Forms.TextBox()
        Me.Localita = New System.Windows.Forms.TextBox()
        Me.CodiceFiscale = New System.Windows.Forms.TextBox()
        Me.PartitaIva = New System.Windows.Forms.TextBox()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
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
        CType(Me.IMMOBILIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnagraficaStudioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnagraficaStudioBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AnagraficaStudioBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'StudioLabel
        '
        StudioLabel.AutoSize = True
        StudioLabel.Location = New System.Drawing.Point(37, 45)
        StudioLabel.Name = "StudioLabel"
        StudioLabel.Size = New System.Drawing.Size(40, 13)
        StudioLabel.TabIndex = 1
        StudioLabel.Text = "Studio:"
        '
        'Denominazione1Label
        '
        Denominazione1Label.AutoSize = True
        Denominazione1Label.Location = New System.Drawing.Point(129, 45)
        Denominazione1Label.Name = "Denominazione1Label"
        Denominazione1Label.Size = New System.Drawing.Size(83, 13)
        Denominazione1Label.TabIndex = 3
        Denominazione1Label.Text = "Denominazione:"
        AddHandler Denominazione1Label.Click, AddressOf Me.Denominazione1Label_Click
        '
        'IndirizzoLabel
        '
        IndirizzoLabel.AutoSize = True
        IndirizzoLabel.Location = New System.Drawing.Point(128, 110)
        IndirizzoLabel.Name = "IndirizzoLabel"
        IndirizzoLabel.Size = New System.Drawing.Size(48, 13)
        IndirizzoLabel.TabIndex = 6
        IndirizzoLabel.Text = "Indirizzo:"
        '
        'CapLabel
        '
        CapLabel.AutoSize = True
        CapLabel.Location = New System.Drawing.Point(45, 149)
        CapLabel.Name = "CapLabel"
        CapLabel.Size = New System.Drawing.Size(29, 13)
        CapLabel.TabIndex = 8
        CapLabel.Text = "Cap:"
        '
        'LocalitaLabel
        '
        LocalitaLabel.AutoSize = True
        LocalitaLabel.Location = New System.Drawing.Point(129, 149)
        LocalitaLabel.Name = "LocalitaLabel"
        LocalitaLabel.Size = New System.Drawing.Size(47, 13)
        LocalitaLabel.TabIndex = 10
        LocalitaLabel.Text = "Localita:"
        '
        'ProvinciaLabel
        '
        ProvinciaLabel.AutoSize = True
        ProvinciaLabel.Location = New System.Drawing.Point(445, 149)
        ProvinciaLabel.Name = "ProvinciaLabel"
        ProvinciaLabel.Size = New System.Drawing.Size(54, 13)
        ProvinciaLabel.TabIndex = 12
        ProvinciaLabel.Text = "Provincia:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(45, 198)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(52, 13)
        TelefonoLabel.TabIndex = 14
        TelefonoLabel.Text = "Telefono:"
        '
        'CodiceFiscaleLabel
        '
        CodiceFiscaleLabel.AutoSize = True
        CodiceFiscaleLabel.Location = New System.Drawing.Point(445, 198)
        CodiceFiscaleLabel.Name = "CodiceFiscaleLabel"
        CodiceFiscaleLabel.Size = New System.Drawing.Size(79, 13)
        CodiceFiscaleLabel.TabIndex = 16
        CodiceFiscaleLabel.Text = "Codice Fiscale:"
        '
        'PartitaIvaLabel
        '
        PartitaIvaLabel.AutoSize = True
        PartitaIvaLabel.Location = New System.Drawing.Point(662, 198)
        PartitaIvaLabel.Name = "PartitaIvaLabel"
        PartitaIvaLabel.Size = New System.Drawing.Size(58, 13)
        PartitaIvaLabel.TabIndex = 18
        PartitaIvaLabel.Text = "Partita Iva:"
        '
        'TipoSocietaLabel
        '
        TipoSocietaLabel.AutoSize = True
        TipoSocietaLabel.Location = New System.Drawing.Point(45, 237)
        TipoSocietaLabel.Name = "TipoSocietaLabel"
        TipoSocietaLabel.Size = New System.Drawing.Size(70, 13)
        TipoSocietaLabel.TabIndex = 20
        TipoSocietaLabel.Text = "Tipo Societa:"
        '
        'Note1Label
        '
        Note1Label.AutoSize = True
        Note1Label.Location = New System.Drawing.Point(129, 237)
        Note1Label.Name = "Note1Label"
        Note1Label.Size = New System.Drawing.Size(33, 13)
        Note1Label.TabIndex = 22
        Note1Label.Text = "Note:"
        '
        'IMMOBILIDataSet
        '
        Me.IMMOBILIDataSet.DataSetName = "IMMOBILIDataSet"
        Me.IMMOBILIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AnagraficaStudioBindingSource
        '
        Me.AnagraficaStudioBindingSource.DataMember = "AnagraficaStudio"
        Me.AnagraficaStudioBindingSource.DataSource = Me.IMMOBILIDataSet
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
        Me.TableAdapterManager.ContiFinanziariTableAdapter = Nothing
        Me.TableAdapterManager.CostantiDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.CostantiTableAdapter = Nothing
        Me.TableAdapterManager.FabbricatiTableAdapter = Nothing
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
        'AnagraficaStudioBindingNavigator
        '
        Me.AnagraficaStudioBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AnagraficaStudioBindingNavigator.BindingSource = Me.AnagraficaStudioBindingSource
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
        Me.AnagraficaStudioBindingNavigator.Size = New System.Drawing.Size(846, 38)
        Me.AnagraficaStudioBindingNavigator.TabIndex = 25
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 38)
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
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 38)
        '
        'AnagraficaStudioBindingNavigatorSaveItem
        '
        Me.AnagraficaStudioBindingNavigatorSaveItem.Image = CType(resources.GetObject("AnagraficaStudioBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AnagraficaStudioBindingNavigatorSaveItem.Name = "AnagraficaStudioBindingNavigatorSaveItem"
        Me.AnagraficaStudioBindingNavigatorSaveItem.Size = New System.Drawing.Size(38, 35)
        Me.AnagraficaStudioBindingNavigatorSaveItem.Text = "&Salva"
        Me.AnagraficaStudioBindingNavigatorSaveItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Studio
        '
        Me.Studio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaStudioBindingSource, "Studio", True))
        Me.Studio.Location = New System.Drawing.Point(40, 61)
        Me.Studio.Name = "Studio"
        Me.Studio.Size = New System.Drawing.Size(75, 20)
        Me.Studio.TabIndex = 26
        '
        'Denominazione1
        '
        Me.Denominazione1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaStudioBindingSource, "Denominazione1", True))
        Me.Denominazione1.Location = New System.Drawing.Point(132, 61)
        Me.Denominazione1.Name = "Denominazione1"
        Me.Denominazione1.Size = New System.Drawing.Size(302, 20)
        Me.Denominazione1.TabIndex = 27
        '
        'Denominazione2
        '
        Me.Denominazione2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaStudioBindingSource, "Denominazione2", True))
        Me.Denominazione2.Location = New System.Drawing.Point(132, 89)
        Me.Denominazione2.Name = "Denominazione2"
        Me.Denominazione2.Size = New System.Drawing.Size(302, 20)
        Me.Denominazione2.TabIndex = 28
        '
        'Indirizzo
        '
        Me.Indirizzo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaStudioBindingSource, "Indirizzo", True))
        Me.Indirizzo.Location = New System.Drawing.Point(132, 126)
        Me.Indirizzo.Name = "Indirizzo"
        Me.Indirizzo.Size = New System.Drawing.Size(302, 20)
        Me.Indirizzo.TabIndex = 29
        '
        'Cap
        '
        Me.Cap.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaStudioBindingSource, "Cap", True))
        Me.Cap.Location = New System.Drawing.Point(48, 165)
        Me.Cap.Name = "Cap"
        Me.Cap.Size = New System.Drawing.Size(67, 20)
        Me.Cap.TabIndex = 30
        '
        'Provincia
        '
        Me.Provincia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaStudioBindingSource, "Provincia", True))
        Me.Provincia.Location = New System.Drawing.Point(448, 165)
        Me.Provincia.Name = "Provincia"
        Me.Provincia.Size = New System.Drawing.Size(51, 20)
        Me.Provincia.TabIndex = 31
        '
        'Telefono
        '
        Me.Telefono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaStudioBindingSource, "Telefono", True))
        Me.Telefono.Location = New System.Drawing.Point(48, 214)
        Me.Telefono.Name = "Telefono"
        Me.Telefono.Size = New System.Drawing.Size(386, 20)
        Me.Telefono.TabIndex = 32
        '
        'TipoSocieta
        '
        Me.TipoSocieta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaStudioBindingSource, "TipoSocieta", True))
        Me.TipoSocieta.Location = New System.Drawing.Point(48, 255)
        Me.TipoSocieta.Name = "TipoSocieta"
        Me.TipoSocieta.Size = New System.Drawing.Size(67, 20)
        Me.TipoSocieta.TabIndex = 33
        '
        'Note1
        '
        Me.Note1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaStudioBindingSource, "Note1", True))
        Me.Note1.Location = New System.Drawing.Point(132, 256)
        Me.Note1.Name = "Note1"
        Me.Note1.Size = New System.Drawing.Size(672, 20)
        Me.Note1.TabIndex = 34
        '
        'Note2
        '
        Me.Note2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaStudioBindingSource, "Note2", True))
        Me.Note2.Location = New System.Drawing.Point(132, 282)
        Me.Note2.Name = "Note2"
        Me.Note2.Size = New System.Drawing.Size(672, 20)
        Me.Note2.TabIndex = 35
        '
        'Localita
        '
        Me.Localita.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaStudioBindingSource, "Localita", True))
        Me.Localita.Location = New System.Drawing.Point(132, 165)
        Me.Localita.Name = "Localita"
        Me.Localita.Size = New System.Drawing.Size(302, 20)
        Me.Localita.TabIndex = 36
        '
        'CodiceFiscale
        '
        Me.CodiceFiscale.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaStudioBindingSource, "CodiceFiscale", True))
        Me.CodiceFiscale.Location = New System.Drawing.Point(448, 214)
        Me.CodiceFiscale.Name = "CodiceFiscale"
        Me.CodiceFiscale.Size = New System.Drawing.Size(194, 20)
        Me.CodiceFiscale.TabIndex = 37
        '
        'PartitaIva
        '
        Me.PartitaIva.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaStudioBindingSource, "PartitaIva", True))
        Me.PartitaIva.Location = New System.Drawing.Point(665, 214)
        Me.PartitaIva.Name = "PartitaIva"
        Me.PartitaIva.Size = New System.Drawing.Size(139, 20)
        Me.PartitaIva.TabIndex = 38
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
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(51, 35)
        Me.ToolStripButton2.Text = "Sta&mpa"
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'AnagraficaStudio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 338)
        Me.Controls.Add(Me.PartitaIva)
        Me.Controls.Add(Me.CodiceFiscale)
        Me.Controls.Add(Me.Localita)
        Me.Controls.Add(Me.Note2)
        Me.Controls.Add(Me.Note1)
        Me.Controls.Add(Me.TipoSocieta)
        Me.Controls.Add(Me.Telefono)
        Me.Controls.Add(Me.Provincia)
        Me.Controls.Add(Me.Cap)
        Me.Controls.Add(Me.Indirizzo)
        Me.Controls.Add(Me.Denominazione2)
        Me.Controls.Add(Me.Denominazione1)
        Me.Controls.Add(Me.Studio)
        Me.Controls.Add(Me.AnagraficaStudioBindingNavigator)
        Me.Controls.Add(Note1Label)
        Me.Controls.Add(TipoSocietaLabel)
        Me.Controls.Add(PartitaIvaLabel)
        Me.Controls.Add(CodiceFiscaleLabel)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(ProvinciaLabel)
        Me.Controls.Add(LocalitaLabel)
        Me.Controls.Add(CapLabel)
        Me.Controls.Add(IndirizzoLabel)
        Me.Controls.Add(Denominazione1Label)
        Me.Controls.Add(StudioLabel)
        Me.Name = "AnagraficaStudio"
        Me.Text = "Anagrafica Studio"
        CType(Me.IMMOBILIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnagraficaStudioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnagraficaStudioBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AnagraficaStudioBindingNavigator.ResumeLayout(False)
        Me.AnagraficaStudioBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IMMOBILIDataSet As Patrimonio2014.IMMOBILIDataSet
    Friend WithEvents AnagraficaStudioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AnagraficaStudioTableAdapter As Patrimonio2014.IMMOBILIDataSetTableAdapters.AnagraficaStudioTableAdapter
    Friend WithEvents TableAdapterManager As Patrimonio2014.IMMOBILIDataSetTableAdapters.TableAdapterManager
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
    Friend WithEvents Studio As System.Windows.Forms.TextBox
    Friend WithEvents Denominazione1 As System.Windows.Forms.TextBox
    Friend WithEvents Denominazione2 As System.Windows.Forms.TextBox
    Friend WithEvents Indirizzo As System.Windows.Forms.TextBox
    Friend WithEvents Cap As System.Windows.Forms.TextBox
    Friend WithEvents Provincia As System.Windows.Forms.TextBox
    Friend WithEvents Telefono As System.Windows.Forms.TextBox
    Friend WithEvents TipoSocieta As System.Windows.Forms.TextBox
    Friend WithEvents Note1 As System.Windows.Forms.TextBox
    Friend WithEvents Note2 As System.Windows.Forms.TextBox
    Friend WithEvents Localita As System.Windows.Forms.TextBox
    Friend WithEvents CodiceFiscale As System.Windows.Forms.TextBox
    Friend WithEvents PartitaIva As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
End Class
