<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContiFinanziari
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
        Dim ContoLabel As System.Windows.Forms.Label
        Dim BancaLabel As System.Windows.Forms.Label
        Dim AgenziaLabel As System.Windows.Forms.Label
        Dim IndirizzoLabel As System.Windows.Forms.Label
        Dim LocalitaLabel As System.Windows.Forms.Label
        Dim Intestatario1Label As System.Windows.Forms.Label
        Dim ContoCorrenteLabel As System.Windows.Forms.Label
        Dim IBANLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ContiFinanziari))
        Me.IMMOBILIDataSet = New Patrimonio2014.IMMOBILIDataSet()
        Me.ContiFinanziariBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContiFinanziariTableAdapter = New Patrimonio2014.IMMOBILIDataSetTableAdapters.ContiFinanziariTableAdapter()
        Me.TableAdapterManager = New Patrimonio2014.IMMOBILIDataSetTableAdapters.TableAdapterManager()
        Me.Immobile = New System.Windows.Forms.TextBox()
        Me.Conto = New System.Windows.Forms.TextBox()
        Me.Banca = New System.Windows.Forms.TextBox()
        Me.Agenzia = New System.Windows.Forms.TextBox()
        Me.Indirizzo = New System.Windows.Forms.TextBox()
        Me.Localita = New System.Windows.Forms.TextBox()
        Me.Intestatario1 = New System.Windows.Forms.TextBox()
        Me.Intestatario2 = New System.Windows.Forms.TextBox()
        Me.ContoCorrente = New System.Windows.Forms.TextBox()
        Me.IBAN = New System.Windows.Forms.TextBox()
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
        ImmobileLabel = New System.Windows.Forms.Label()
        ContoLabel = New System.Windows.Forms.Label()
        BancaLabel = New System.Windows.Forms.Label()
        AgenziaLabel = New System.Windows.Forms.Label()
        IndirizzoLabel = New System.Windows.Forms.Label()
        LocalitaLabel = New System.Windows.Forms.Label()
        Intestatario1Label = New System.Windows.Forms.Label()
        ContoCorrenteLabel = New System.Windows.Forms.Label()
        IBANLabel = New System.Windows.Forms.Label()
        CType(Me.IMMOBILIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContiFinanziariBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnagraficaStudioBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AnagraficaStudioBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImmobileLabel
        '
        ImmobileLabel.AutoSize = True
        ImmobileLabel.Location = New System.Drawing.Point(21, 49)
        ImmobileLabel.Name = "ImmobileLabel"
        ImmobileLabel.Size = New System.Drawing.Size(51, 13)
        ImmobileLabel.TabIndex = 1
        ImmobileLabel.Text = "Immobile:"
        '
        'ContoLabel
        '
        ContoLabel.AutoSize = True
        ContoLabel.Location = New System.Drawing.Point(93, 49)
        ContoLabel.Name = "ContoLabel"
        ContoLabel.Size = New System.Drawing.Size(38, 13)
        ContoLabel.TabIndex = 2
        ContoLabel.Text = "Conto:"
        '
        'BancaLabel
        '
        BancaLabel.AutoSize = True
        BancaLabel.Location = New System.Drawing.Point(164, 49)
        BancaLabel.Name = "BancaLabel"
        BancaLabel.Size = New System.Drawing.Size(41, 13)
        BancaLabel.TabIndex = 4
        BancaLabel.Text = "Banca:"
        '
        'AgenziaLabel
        '
        AgenziaLabel.AutoSize = True
        AgenziaLabel.Location = New System.Drawing.Point(164, 88)
        AgenziaLabel.Name = "AgenziaLabel"
        AgenziaLabel.Size = New System.Drawing.Size(48, 13)
        AgenziaLabel.TabIndex = 6
        AgenziaLabel.Text = "Agenzia:"
        '
        'IndirizzoLabel
        '
        IndirizzoLabel.AutoSize = True
        IndirizzoLabel.Location = New System.Drawing.Point(164, 127)
        IndirizzoLabel.Name = "IndirizzoLabel"
        IndirizzoLabel.Size = New System.Drawing.Size(48, 13)
        IndirizzoLabel.TabIndex = 8
        IndirizzoLabel.Text = "Indirizzo:"
        '
        'LocalitaLabel
        '
        LocalitaLabel.AutoSize = True
        LocalitaLabel.Location = New System.Drawing.Point(164, 166)
        LocalitaLabel.Name = "LocalitaLabel"
        LocalitaLabel.Size = New System.Drawing.Size(47, 13)
        LocalitaLabel.TabIndex = 10
        LocalitaLabel.Text = "Localita:"
        '
        'Intestatario1Label
        '
        Intestatario1Label.AutoSize = True
        Intestatario1Label.Location = New System.Drawing.Point(164, 218)
        Intestatario1Label.Name = "Intestatario1Label"
        Intestatario1Label.Size = New System.Drawing.Size(62, 13)
        Intestatario1Label.TabIndex = 12
        Intestatario1Label.Text = "Intestatario:"
        '
        'ContoCorrenteLabel
        '
        ContoCorrenteLabel.AutoSize = True
        ContoCorrenteLabel.Location = New System.Drawing.Point(164, 297)
        ContoCorrenteLabel.Name = "ContoCorrenteLabel"
        ContoCorrenteLabel.Size = New System.Drawing.Size(81, 13)
        ContoCorrenteLabel.TabIndex = 15
        ContoCorrenteLabel.Text = "Conto Corrente:"
        '
        'IBANLabel
        '
        IBANLabel.AutoSize = True
        IBANLabel.Location = New System.Drawing.Point(164, 336)
        IBANLabel.Name = "IBANLabel"
        IBANLabel.Size = New System.Drawing.Size(35, 13)
        IBANLabel.TabIndex = 17
        IBANLabel.Text = "IBAN:"
        '
        'IMMOBILIDataSet
        '
        Me.IMMOBILIDataSet.DataSetName = "IMMOBILIDataSet"
        Me.IMMOBILIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ContiFinanziariBindingSource
        '
        Me.ContiFinanziariBindingSource.DataMember = "ContiFinanziari"
        Me.ContiFinanziariBindingSource.DataSource = Me.IMMOBILIDataSet
        '
        'ContiFinanziariTableAdapter
        '
        Me.ContiFinanziariTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AnagraficaStudioTableAdapter = Nothing
        Me.TableAdapterManager.AnagraficheTableAdapter = Nothing
        Me.TableAdapterManager.AssembleaDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.AssembleaTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ContiFinanziariTableAdapter = Me.ContiFinanziariTableAdapter
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
        'Immobile
        '
        Me.Immobile.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContiFinanziariBindingSource, "Immobile", True))
        Me.Immobile.Location = New System.Drawing.Point(24, 65)
        Me.Immobile.Name = "Immobile"
        Me.Immobile.Size = New System.Drawing.Size(48, 20)
        Me.Immobile.TabIndex = 20
        '
        'Conto
        '
        Me.Conto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContiFinanziariBindingSource, "Conto", True))
        Me.Conto.Location = New System.Drawing.Point(96, 65)
        Me.Conto.Name = "Conto"
        Me.Conto.Size = New System.Drawing.Size(49, 20)
        Me.Conto.TabIndex = 21
        '
        'Banca
        '
        Me.Banca.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContiFinanziariBindingSource, "Banca", True))
        Me.Banca.Location = New System.Drawing.Point(167, 68)
        Me.Banca.Name = "Banca"
        Me.Banca.Size = New System.Drawing.Size(322, 20)
        Me.Banca.TabIndex = 22
        '
        'Agenzia
        '
        Me.Agenzia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContiFinanziariBindingSource, "Agenzia", True))
        Me.Agenzia.Location = New System.Drawing.Point(167, 104)
        Me.Agenzia.Name = "Agenzia"
        Me.Agenzia.Size = New System.Drawing.Size(322, 20)
        Me.Agenzia.TabIndex = 23
        '
        'Indirizzo
        '
        Me.Indirizzo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContiFinanziariBindingSource, "Indirizzo", True))
        Me.Indirizzo.Location = New System.Drawing.Point(167, 145)
        Me.Indirizzo.Name = "Indirizzo"
        Me.Indirizzo.Size = New System.Drawing.Size(322, 20)
        Me.Indirizzo.TabIndex = 24
        '
        'Localita
        '
        Me.Localita.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContiFinanziariBindingSource, "Localita", True))
        Me.Localita.Location = New System.Drawing.Point(167, 184)
        Me.Localita.Name = "Localita"
        Me.Localita.Size = New System.Drawing.Size(322, 20)
        Me.Localita.TabIndex = 25
        '
        'Intestatario1
        '
        Me.Intestatario1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContiFinanziariBindingSource, "Intestatario1", True))
        Me.Intestatario1.Location = New System.Drawing.Point(167, 234)
        Me.Intestatario1.Name = "Intestatario1"
        Me.Intestatario1.Size = New System.Drawing.Size(322, 20)
        Me.Intestatario1.TabIndex = 26
        '
        'Intestatario2
        '
        Me.Intestatario2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContiFinanziariBindingSource, "Intestatario2", True))
        Me.Intestatario2.Location = New System.Drawing.Point(167, 260)
        Me.Intestatario2.Name = "Intestatario2"
        Me.Intestatario2.Size = New System.Drawing.Size(322, 20)
        Me.Intestatario2.TabIndex = 27
        '
        'ContoCorrente
        '
        Me.ContoCorrente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContiFinanziariBindingSource, "ContoCorrente", True))
        Me.ContoCorrente.Location = New System.Drawing.Point(167, 313)
        Me.ContoCorrente.Name = "ContoCorrente"
        Me.ContoCorrente.Size = New System.Drawing.Size(177, 20)
        Me.ContoCorrente.TabIndex = 28
        '
        'IBAN
        '
        Me.IBAN.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContiFinanziariBindingSource, "IBAN", True))
        Me.IBAN.Location = New System.Drawing.Point(167, 352)
        Me.IBAN.Name = "IBAN"
        Me.IBAN.Size = New System.Drawing.Size(277, 20)
        Me.IBAN.TabIndex = 29
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
        Me.AnagraficaStudioBindingNavigator.Size = New System.Drawing.Size(718, 38)
        Me.AnagraficaStudioBindingNavigator.TabIndex = 30
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
        'ContiFinanziari
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 398)
        Me.Controls.Add(Me.AnagraficaStudioBindingNavigator)
        Me.Controls.Add(Me.IBAN)
        Me.Controls.Add(Me.ContoCorrente)
        Me.Controls.Add(Me.Intestatario2)
        Me.Controls.Add(Me.Intestatario1)
        Me.Controls.Add(Me.Localita)
        Me.Controls.Add(Me.Indirizzo)
        Me.Controls.Add(Me.Agenzia)
        Me.Controls.Add(Me.Banca)
        Me.Controls.Add(Me.Conto)
        Me.Controls.Add(Me.Immobile)
        Me.Controls.Add(IBANLabel)
        Me.Controls.Add(ContoCorrenteLabel)
        Me.Controls.Add(Intestatario1Label)
        Me.Controls.Add(LocalitaLabel)
        Me.Controls.Add(IndirizzoLabel)
        Me.Controls.Add(AgenziaLabel)
        Me.Controls.Add(BancaLabel)
        Me.Controls.Add(ContoLabel)
        Me.Controls.Add(ImmobileLabel)
        Me.Name = "ContiFinanziari"
        Me.Text = "Conti Finanziari"
        CType(Me.IMMOBILIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContiFinanziariBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnagraficaStudioBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AnagraficaStudioBindingNavigator.ResumeLayout(False)
        Me.AnagraficaStudioBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IMMOBILIDataSet As Patrimonio2014.IMMOBILIDataSet
    Friend WithEvents ContiFinanziariBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ContiFinanziariTableAdapter As Patrimonio2014.IMMOBILIDataSetTableAdapters.ContiFinanziariTableAdapter
    Friend WithEvents TableAdapterManager As Patrimonio2014.IMMOBILIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Immobile As System.Windows.Forms.TextBox
    Friend WithEvents Conto As System.Windows.Forms.TextBox
    Friend WithEvents Banca As System.Windows.Forms.TextBox
    Friend WithEvents Agenzia As System.Windows.Forms.TextBox
    Friend WithEvents Indirizzo As System.Windows.Forms.TextBox
    Friend WithEvents Localita As System.Windows.Forms.TextBox
    Friend WithEvents Intestatario1 As System.Windows.Forms.TextBox
    Friend WithEvents Intestatario2 As System.Windows.Forms.TextBox
    Friend WithEvents ContoCorrente As System.Windows.Forms.TextBox
    Friend WithEvents IBAN As System.Windows.Forms.TextBox
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
End Class
