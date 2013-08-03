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
        Me.ContiFinanziariBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ContiFinanziariBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ImmobileTextBox = New System.Windows.Forms.TextBox()
        Me.ContoTextBox = New System.Windows.Forms.TextBox()
        Me.BancaTextBox = New System.Windows.Forms.TextBox()
        Me.AgenziaTextBox = New System.Windows.Forms.TextBox()
        Me.IndirizzoTextBox = New System.Windows.Forms.TextBox()
        Me.LocalitaTextBox = New System.Windows.Forms.TextBox()
        Me.Intestatario1TextBox = New System.Windows.Forms.TextBox()
        Me.Intestatario2TextBox = New System.Windows.Forms.TextBox()
        Me.ContoCorrenteTextBox = New System.Windows.Forms.TextBox()
        Me.IBANTextBox = New System.Windows.Forms.TextBox()
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
        CType(Me.ContiFinanziariBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContiFinanziariBindingNavigator.SuspendLayout()
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
        'ContiFinanziariBindingNavigator
        '
        Me.ContiFinanziariBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ContiFinanziariBindingNavigator.BindingSource = Me.ContiFinanziariBindingSource
        Me.ContiFinanziariBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ContiFinanziariBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ContiFinanziariBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ContiFinanziariBindingNavigatorSaveItem})
        Me.ContiFinanziariBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ContiFinanziariBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ContiFinanziariBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ContiFinanziariBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ContiFinanziariBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ContiFinanziariBindingNavigator.Name = "ContiFinanziariBindingNavigator"
        Me.ContiFinanziariBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ContiFinanziariBindingNavigator.Size = New System.Drawing.Size(718, 25)
        Me.ContiFinanziariBindingNavigator.TabIndex = 19
        Me.ContiFinanziariBindingNavigator.Text = "BindingNavigator1"
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
        'ContiFinanziariBindingNavigatorSaveItem
        '
        Me.ContiFinanziariBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ContiFinanziariBindingNavigatorSaveItem.Image = CType(resources.GetObject("ContiFinanziariBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ContiFinanziariBindingNavigatorSaveItem.Name = "ContiFinanziariBindingNavigatorSaveItem"
        Me.ContiFinanziariBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.ContiFinanziariBindingNavigatorSaveItem.Text = "Salva dati"
        '
        'ImmobileTextBox
        '
        Me.ImmobileTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContiFinanziariBindingSource, "Immobile", True))
        Me.ImmobileTextBox.Location = New System.Drawing.Point(24, 65)
        Me.ImmobileTextBox.Name = "ImmobileTextBox"
        Me.ImmobileTextBox.Size = New System.Drawing.Size(48, 20)
        Me.ImmobileTextBox.TabIndex = 20
        '
        'ContoTextBox
        '
        Me.ContoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContiFinanziariBindingSource, "Conto", True))
        Me.ContoTextBox.Location = New System.Drawing.Point(96, 65)
        Me.ContoTextBox.Name = "ContoTextBox"
        Me.ContoTextBox.Size = New System.Drawing.Size(49, 20)
        Me.ContoTextBox.TabIndex = 21
        '
        'BancaTextBox
        '
        Me.BancaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContiFinanziariBindingSource, "Banca", True))
        Me.BancaTextBox.Location = New System.Drawing.Point(167, 68)
        Me.BancaTextBox.Name = "BancaTextBox"
        Me.BancaTextBox.Size = New System.Drawing.Size(322, 20)
        Me.BancaTextBox.TabIndex = 22
        '
        'AgenziaTextBox
        '
        Me.AgenziaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContiFinanziariBindingSource, "Agenzia", True))
        Me.AgenziaTextBox.Location = New System.Drawing.Point(167, 104)
        Me.AgenziaTextBox.Name = "AgenziaTextBox"
        Me.AgenziaTextBox.Size = New System.Drawing.Size(322, 20)
        Me.AgenziaTextBox.TabIndex = 23
        '
        'IndirizzoTextBox
        '
        Me.IndirizzoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContiFinanziariBindingSource, "Indirizzo", True))
        Me.IndirizzoTextBox.Location = New System.Drawing.Point(167, 145)
        Me.IndirizzoTextBox.Name = "IndirizzoTextBox"
        Me.IndirizzoTextBox.Size = New System.Drawing.Size(322, 20)
        Me.IndirizzoTextBox.TabIndex = 24
        '
        'LocalitaTextBox
        '
        Me.LocalitaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContiFinanziariBindingSource, "Localita", True))
        Me.LocalitaTextBox.Location = New System.Drawing.Point(167, 184)
        Me.LocalitaTextBox.Name = "LocalitaTextBox"
        Me.LocalitaTextBox.Size = New System.Drawing.Size(322, 20)
        Me.LocalitaTextBox.TabIndex = 25
        '
        'Intestatario1TextBox
        '
        Me.Intestatario1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContiFinanziariBindingSource, "Intestatario1", True))
        Me.Intestatario1TextBox.Location = New System.Drawing.Point(167, 234)
        Me.Intestatario1TextBox.Name = "Intestatario1TextBox"
        Me.Intestatario1TextBox.Size = New System.Drawing.Size(322, 20)
        Me.Intestatario1TextBox.TabIndex = 26
        '
        'Intestatario2TextBox
        '
        Me.Intestatario2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContiFinanziariBindingSource, "Intestatario2", True))
        Me.Intestatario2TextBox.Location = New System.Drawing.Point(167, 260)
        Me.Intestatario2TextBox.Name = "Intestatario2TextBox"
        Me.Intestatario2TextBox.Size = New System.Drawing.Size(322, 20)
        Me.Intestatario2TextBox.TabIndex = 27
        '
        'ContoCorrenteTextBox
        '
        Me.ContoCorrenteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContiFinanziariBindingSource, "ContoCorrente", True))
        Me.ContoCorrenteTextBox.Location = New System.Drawing.Point(167, 313)
        Me.ContoCorrenteTextBox.Name = "ContoCorrenteTextBox"
        Me.ContoCorrenteTextBox.Size = New System.Drawing.Size(177, 20)
        Me.ContoCorrenteTextBox.TabIndex = 28
        '
        'IBANTextBox
        '
        Me.IBANTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContiFinanziariBindingSource, "IBAN", True))
        Me.IBANTextBox.Location = New System.Drawing.Point(167, 352)
        Me.IBANTextBox.Name = "IBANTextBox"
        Me.IBANTextBox.Size = New System.Drawing.Size(277, 20)
        Me.IBANTextBox.TabIndex = 29
        '
        'ContiFinanziari
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 398)
        Me.Controls.Add(Me.IBANTextBox)
        Me.Controls.Add(Me.ContoCorrenteTextBox)
        Me.Controls.Add(Me.Intestatario2TextBox)
        Me.Controls.Add(Me.Intestatario1TextBox)
        Me.Controls.Add(Me.LocalitaTextBox)
        Me.Controls.Add(Me.IndirizzoTextBox)
        Me.Controls.Add(Me.AgenziaTextBox)
        Me.Controls.Add(Me.BancaTextBox)
        Me.Controls.Add(Me.ContoTextBox)
        Me.Controls.Add(Me.ImmobileTextBox)
        Me.Controls.Add(Me.ContiFinanziariBindingNavigator)
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
        CType(Me.ContiFinanziariBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContiFinanziariBindingNavigator.ResumeLayout(False)
        Me.ContiFinanziariBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IMMOBILIDataSet As Patrimonio2014.IMMOBILIDataSet
    Friend WithEvents ContiFinanziariBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ContiFinanziariTableAdapter As Patrimonio2014.IMMOBILIDataSetTableAdapters.ContiFinanziariTableAdapter
    Friend WithEvents TableAdapterManager As Patrimonio2014.IMMOBILIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ContiFinanziariBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ContiFinanziariBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ImmobileTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BancaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AgenziaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IndirizzoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LocalitaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Intestatario1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Intestatario2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContoCorrenteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IBANTextBox As System.Windows.Forms.TextBox
End Class
