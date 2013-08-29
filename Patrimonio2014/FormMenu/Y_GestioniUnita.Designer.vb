<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Y_GestioniUnita
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Y_GestioniUnita))
        Dim GestioneLabel As System.Windows.Forms.Label
        Dim UnitaLabel As System.Windows.Forms.Label
        Dim SaldoGestionePrecedenteLabel As System.Windows.Forms.Label
        Dim SpeseAddebitateLabel As System.Windows.Forms.Label
        Dim InteressiLabel As System.Windows.Forms.Label
        Dim SpesePersonaliLabel As System.Windows.Forms.Label
        Dim VersamentiLabel As System.Windows.Forms.Label
        Dim PreventivoAccontoLabel As System.Windows.Forms.Label
        Dim PreventivoProvvisorioLabel As System.Windows.Forms.Label
        Dim PreventivoSpesePersonaliLabel As System.Windows.Forms.Label
        Me.IMMOBILIDataSet2 = New Patrimonio2014.IMMOBILIDataSet2()
        Me.Y_GestioniUnitaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Y_GestioniUnitaTableAdapter = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.Y_GestioniUnitaTableAdapter()
        Me.TableAdapterManager = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.TableAdapterManager()
        Me.Y_GestioniUnitaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Y_GestioniUnitaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ImmobileComboBox = New System.Windows.Forms.ComboBox()
        Me.GestioneComboBox = New System.Windows.Forms.ComboBox()
        Me.UnitaComboBox = New System.Windows.Forms.ComboBox()
        Me.SaldoGestionePrecedenteTextBox = New System.Windows.Forms.TextBox()
        Me.SpeseAddebitateTextBox = New System.Windows.Forms.TextBox()
        Me.InteressiTextBox = New System.Windows.Forms.TextBox()
        Me.SpesePersonaliTextBox = New System.Windows.Forms.TextBox()
        Me.VersamentiTextBox = New System.Windows.Forms.TextBox()
        Me.PreventivoAccontoTextBox = New System.Windows.Forms.TextBox()
        Me.PreventivoProvvisorioTextBox = New System.Windows.Forms.TextBox()
        Me.PreventivoSpesePersonaliTextBox = New System.Windows.Forms.TextBox()
        Me.Y_GestioniUnitaDettaglioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Y_GestioniUnitaDettaglioTableAdapter = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.Y_GestioniUnitaDettaglioTableAdapter()
        Me.Y_GestioniUnitaDettaglioDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        ImmobileLabel = New System.Windows.Forms.Label()
        GestioneLabel = New System.Windows.Forms.Label()
        UnitaLabel = New System.Windows.Forms.Label()
        SaldoGestionePrecedenteLabel = New System.Windows.Forms.Label()
        SpeseAddebitateLabel = New System.Windows.Forms.Label()
        InteressiLabel = New System.Windows.Forms.Label()
        SpesePersonaliLabel = New System.Windows.Forms.Label()
        VersamentiLabel = New System.Windows.Forms.Label()
        PreventivoAccontoLabel = New System.Windows.Forms.Label()
        PreventivoProvvisorioLabel = New System.Windows.Forms.Label()
        PreventivoSpesePersonaliLabel = New System.Windows.Forms.Label()
        CType(Me.IMMOBILIDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Y_GestioniUnitaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Y_GestioniUnitaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Y_GestioniUnitaBindingNavigator.SuspendLayout()
        CType(Me.Y_GestioniUnitaDettaglioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Y_GestioniUnitaDettaglioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImmobileLabel
        '
        ImmobileLabel.AutoSize = True
        ImmobileLabel.Location = New System.Drawing.Point(12, 39)
        ImmobileLabel.Name = "ImmobileLabel"
        ImmobileLabel.Size = New System.Drawing.Size(51, 13)
        ImmobileLabel.TabIndex = 1
        ImmobileLabel.Text = "Immobile:"
        '
        'IMMOBILIDataSet2
        '
        Me.IMMOBILIDataSet2.DataSetName = "IMMOBILIDataSet2"
        Me.IMMOBILIDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Y_GestioniUnitaBindingSource
        '
        Me.Y_GestioniUnitaBindingSource.DataMember = "Y_GestioniUnita"
        Me.Y_GestioniUnitaBindingSource.DataSource = Me.IMMOBILIDataSet2
        '
        'Y_GestioniUnitaTableAdapter
        '
        Me.Y_GestioniUnitaTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.X_MovimentiFondiTableAdapter = Nothing
        Me.TableAdapterManager.X_SpeseDescrizioniTableAdapter = Nothing
        Me.TableAdapterManager.X_SpeseTableAdapter = Nothing
        Me.TableAdapterManager.Y_GestioniDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.Y_GestioniTableAdapter = Nothing
        Me.TableAdapterManager.Y_GestioniUnitaDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.Y_GestioniUnitaTableAdapter = Me.Y_GestioniUnitaTableAdapter
        Me.TableAdapterManager.Z_ConsuntivoDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.Z_ConsuntivoTableAdapter = Nothing
        Me.TableAdapterManager.Z_TestoSollecitoTableAdapter = Nothing
        '
        'Y_GestioniUnitaBindingNavigator
        '
        Me.Y_GestioniUnitaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Y_GestioniUnitaBindingNavigator.BindingSource = Me.Y_GestioniUnitaBindingSource
        Me.Y_GestioniUnitaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Y_GestioniUnitaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Y_GestioniUnitaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Y_GestioniUnitaBindingNavigatorSaveItem})
        Me.Y_GestioniUnitaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Y_GestioniUnitaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Y_GestioniUnitaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Y_GestioniUnitaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Y_GestioniUnitaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Y_GestioniUnitaBindingNavigator.Name = "Y_GestioniUnitaBindingNavigator"
        Me.Y_GestioniUnitaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Y_GestioniUnitaBindingNavigator.Size = New System.Drawing.Size(753, 25)
        Me.Y_GestioniUnitaBindingNavigator.TabIndex = 0
        Me.Y_GestioniUnitaBindingNavigator.Text = "BindingNavigator1"
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
        'Y_GestioniUnitaBindingNavigatorSaveItem
        '
        Me.Y_GestioniUnitaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Y_GestioniUnitaBindingNavigatorSaveItem.Image = CType(resources.GetObject("Y_GestioniUnitaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Y_GestioniUnitaBindingNavigatorSaveItem.Name = "Y_GestioniUnitaBindingNavigatorSaveItem"
        Me.Y_GestioniUnitaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Y_GestioniUnitaBindingNavigatorSaveItem.Text = "Salva dati"
        '
        'ImmobileComboBox
        '
        Me.ImmobileComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Y_GestioniUnitaBindingSource, "Immobile", True))
        Me.ImmobileComboBox.FormattingEnabled = True
        Me.ImmobileComboBox.Location = New System.Drawing.Point(15, 55)
        Me.ImmobileComboBox.Name = "ImmobileComboBox"
        Me.ImmobileComboBox.Size = New System.Drawing.Size(287, 21)
        Me.ImmobileComboBox.TabIndex = 2
        '
        'GestioneLabel
        '
        GestioneLabel.AutoSize = True
        GestioneLabel.Location = New System.Drawing.Point(308, 39)
        GestioneLabel.Name = "GestioneLabel"
        GestioneLabel.Size = New System.Drawing.Size(52, 13)
        GestioneLabel.TabIndex = 3
        GestioneLabel.Text = "Gestione:"
        '
        'GestioneComboBox
        '
        Me.GestioneComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Y_GestioniUnitaBindingSource, "Gestione", True))
        Me.GestioneComboBox.FormattingEnabled = True
        Me.GestioneComboBox.Location = New System.Drawing.Point(311, 55)
        Me.GestioneComboBox.Name = "GestioneComboBox"
        Me.GestioneComboBox.Size = New System.Drawing.Size(265, 21)
        Me.GestioneComboBox.TabIndex = 4
        '
        'UnitaLabel
        '
        UnitaLabel.AutoSize = True
        UnitaLabel.Location = New System.Drawing.Point(12, 79)
        UnitaLabel.Name = "UnitaLabel"
        UnitaLabel.Size = New System.Drawing.Size(35, 13)
        UnitaLabel.TabIndex = 5
        UnitaLabel.Text = "Unita:"
        '
        'UnitaComboBox
        '
        Me.UnitaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Y_GestioniUnitaBindingSource, "Unita", True))
        Me.UnitaComboBox.FormattingEnabled = True
        Me.UnitaComboBox.Location = New System.Drawing.Point(15, 95)
        Me.UnitaComboBox.Name = "UnitaComboBox"
        Me.UnitaComboBox.Size = New System.Drawing.Size(287, 21)
        Me.UnitaComboBox.TabIndex = 6
        '
        'SaldoGestionePrecedenteLabel
        '
        SaldoGestionePrecedenteLabel.AutoSize = True
        SaldoGestionePrecedenteLabel.Location = New System.Drawing.Point(12, 119)
        SaldoGestionePrecedenteLabel.Name = "SaldoGestionePrecedenteLabel"
        SaldoGestionePrecedenteLabel.Size = New System.Drawing.Size(105, 13)
        SaldoGestionePrecedenteLabel.TabIndex = 7
        SaldoGestionePrecedenteLabel.Text = "Saldo Gest. Preced.:"
        '
        'SaldoGestionePrecedenteTextBox
        '
        Me.SaldoGestionePrecedenteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Y_GestioniUnitaBindingSource, "SaldoGestionePrecedente", True))
        Me.SaldoGestionePrecedenteTextBox.Location = New System.Drawing.Point(15, 135)
        Me.SaldoGestionePrecedenteTextBox.Name = "SaldoGestionePrecedenteTextBox"
        Me.SaldoGestionePrecedenteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SaldoGestionePrecedenteTextBox.TabIndex = 8
        '
        'SpeseAddebitateLabel
        '
        SpeseAddebitateLabel.AutoSize = True
        SpeseAddebitateLabel.Location = New System.Drawing.Point(121, 119)
        SpeseAddebitateLabel.Name = "SpeseAddebitateLabel"
        SpeseAddebitateLabel.Size = New System.Drawing.Size(94, 13)
        SpeseAddebitateLabel.TabIndex = 9
        SpeseAddebitateLabel.Text = "Spese Addebitate:"
        '
        'SpeseAddebitateTextBox
        '
        Me.SpeseAddebitateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Y_GestioniUnitaBindingSource, "SpeseAddebitate", True))
        Me.SpeseAddebitateTextBox.Location = New System.Drawing.Point(124, 135)
        Me.SpeseAddebitateTextBox.Name = "SpeseAddebitateTextBox"
        Me.SpeseAddebitateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SpeseAddebitateTextBox.TabIndex = 10
        '
        'InteressiLabel
        '
        InteressiLabel.AutoSize = True
        InteressiLabel.Location = New System.Drawing.Point(227, 119)
        InteressiLabel.Name = "InteressiLabel"
        InteressiLabel.Size = New System.Drawing.Size(49, 13)
        InteressiLabel.TabIndex = 11
        InteressiLabel.Text = "Interessi:"
        '
        'InteressiTextBox
        '
        Me.InteressiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Y_GestioniUnitaBindingSource, "Interessi", True))
        Me.InteressiTextBox.Location = New System.Drawing.Point(230, 135)
        Me.InteressiTextBox.Name = "InteressiTextBox"
        Me.InteressiTextBox.Size = New System.Drawing.Size(100, 20)
        Me.InteressiTextBox.TabIndex = 12
        '
        'SpesePersonaliLabel
        '
        SpesePersonaliLabel.AutoSize = True
        SpesePersonaliLabel.Location = New System.Drawing.Point(336, 119)
        SpesePersonaliLabel.Name = "SpesePersonaliLabel"
        SpesePersonaliLabel.Size = New System.Drawing.Size(86, 13)
        SpesePersonaliLabel.TabIndex = 13
        SpesePersonaliLabel.Text = "Spese Personali:"
        '
        'SpesePersonaliTextBox
        '
        Me.SpesePersonaliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Y_GestioniUnitaBindingSource, "SpesePersonali", True))
        Me.SpesePersonaliTextBox.Location = New System.Drawing.Point(339, 135)
        Me.SpesePersonaliTextBox.Name = "SpesePersonaliTextBox"
        Me.SpesePersonaliTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SpesePersonaliTextBox.TabIndex = 14
        '
        'VersamentiLabel
        '
        VersamentiLabel.AutoSize = True
        VersamentiLabel.Location = New System.Drawing.Point(445, 119)
        VersamentiLabel.Name = "VersamentiLabel"
        VersamentiLabel.Size = New System.Drawing.Size(62, 13)
        VersamentiLabel.TabIndex = 15
        VersamentiLabel.Text = "Versamenti:"
        '
        'VersamentiTextBox
        '
        Me.VersamentiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Y_GestioniUnitaBindingSource, "Versamenti", True))
        Me.VersamentiTextBox.Location = New System.Drawing.Point(448, 135)
        Me.VersamentiTextBox.Name = "VersamentiTextBox"
        Me.VersamentiTextBox.Size = New System.Drawing.Size(100, 20)
        Me.VersamentiTextBox.TabIndex = 16
        '
        'PreventivoAccontoLabel
        '
        PreventivoAccontoLabel.AutoSize = True
        PreventivoAccontoLabel.Location = New System.Drawing.Point(15, 158)
        PreventivoAccontoLabel.Name = "PreventivoAccontoLabel"
        PreventivoAccontoLabel.Size = New System.Drawing.Size(104, 13)
        PreventivoAccontoLabel.TabIndex = 17
        PreventivoAccontoLabel.Text = "Preventivo Acconto:"
        '
        'PreventivoAccontoTextBox
        '
        Me.PreventivoAccontoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Y_GestioniUnitaBindingSource, "PreventivoAcconto", True))
        Me.PreventivoAccontoTextBox.Location = New System.Drawing.Point(15, 174)
        Me.PreventivoAccontoTextBox.Name = "PreventivoAccontoTextBox"
        Me.PreventivoAccontoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PreventivoAccontoTextBox.TabIndex = 18
        '
        'PreventivoProvvisorioLabel
        '
        PreventivoProvvisorioLabel.AutoSize = True
        PreventivoProvvisorioLabel.Location = New System.Drawing.Point(121, 158)
        PreventivoProvvisorioLabel.Name = "PreventivoProvvisorioLabel"
        PreventivoProvvisorioLabel.Size = New System.Drawing.Size(90, 13)
        PreventivoProvvisorioLabel.TabIndex = 19
        PreventivoProvvisorioLabel.Text = "Prev. Provvisorio:"
        '
        'PreventivoProvvisorioTextBox
        '
        Me.PreventivoProvvisorioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Y_GestioniUnitaBindingSource, "PreventivoProvvisorio", True))
        Me.PreventivoProvvisorioTextBox.Location = New System.Drawing.Point(124, 174)
        Me.PreventivoProvvisorioTextBox.Name = "PreventivoProvvisorioTextBox"
        Me.PreventivoProvvisorioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PreventivoProvvisorioTextBox.TabIndex = 20
        '
        'PreventivoSpesePersonaliLabel
        '
        PreventivoSpesePersonaliLabel.AutoSize = True
        PreventivoSpesePersonaliLabel.Location = New System.Drawing.Point(227, 158)
        PreventivoSpesePersonaliLabel.Name = "PreventivoSpesePersonaliLabel"
        PreventivoSpesePersonaliLabel.Size = New System.Drawing.Size(107, 13)
        PreventivoSpesePersonaliLabel.TabIndex = 21
        PreventivoSpesePersonaliLabel.Text = "Prev. Spese Person.:"
        '
        'PreventivoSpesePersonaliTextBox
        '
        Me.PreventivoSpesePersonaliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Y_GestioniUnitaBindingSource, "PreventivoSpesePersonali", True))
        Me.PreventivoSpesePersonaliTextBox.Location = New System.Drawing.Point(230, 174)
        Me.PreventivoSpesePersonaliTextBox.Name = "PreventivoSpesePersonaliTextBox"
        Me.PreventivoSpesePersonaliTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PreventivoSpesePersonaliTextBox.TabIndex = 22
        '
        'Y_GestioniUnitaDettaglioBindingSource
        '
        Me.Y_GestioniUnitaDettaglioBindingSource.DataMember = "Y_GestioniUnitaDettaglio"
        Me.Y_GestioniUnitaDettaglioBindingSource.DataSource = Me.IMMOBILIDataSet2
        '
        'Y_GestioniUnitaDettaglioTableAdapter
        '
        Me.Y_GestioniUnitaDettaglioTableAdapter.ClearBeforeFill = True
        '
        'Y_GestioniUnitaDettaglioDataGridView
        '
        Me.Y_GestioniUnitaDettaglioDataGridView.AutoGenerateColumns = False
        Me.Y_GestioniUnitaDettaglioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Y_GestioniUnitaDettaglioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.Y_GestioniUnitaDettaglioDataGridView.DataSource = Me.Y_GestioniUnitaDettaglioBindingSource
        Me.Y_GestioniUnitaDettaglioDataGridView.Location = New System.Drawing.Point(21, 215)
        Me.Y_GestioniUnitaDettaglioDataGridView.Name = "Y_GestioniUnitaDettaglioDataGridView"
        Me.Y_GestioniUnitaDettaglioDataGridView.Size = New System.Drawing.Size(309, 220)
        Me.Y_GestioniUnitaDettaglioDataGridView.TabIndex = 23
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Riga"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Riga"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 50
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Rata"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Rata"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Y_GestioniUnita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 455)
        Me.Controls.Add(Me.Y_GestioniUnitaDettaglioDataGridView)
        Me.Controls.Add(PreventivoSpesePersonaliLabel)
        Me.Controls.Add(Me.PreventivoSpesePersonaliTextBox)
        Me.Controls.Add(PreventivoProvvisorioLabel)
        Me.Controls.Add(Me.PreventivoProvvisorioTextBox)
        Me.Controls.Add(PreventivoAccontoLabel)
        Me.Controls.Add(Me.PreventivoAccontoTextBox)
        Me.Controls.Add(VersamentiLabel)
        Me.Controls.Add(Me.VersamentiTextBox)
        Me.Controls.Add(SpesePersonaliLabel)
        Me.Controls.Add(Me.SpesePersonaliTextBox)
        Me.Controls.Add(InteressiLabel)
        Me.Controls.Add(Me.InteressiTextBox)
        Me.Controls.Add(SpeseAddebitateLabel)
        Me.Controls.Add(Me.SpeseAddebitateTextBox)
        Me.Controls.Add(SaldoGestionePrecedenteLabel)
        Me.Controls.Add(Me.SaldoGestionePrecedenteTextBox)
        Me.Controls.Add(UnitaLabel)
        Me.Controls.Add(Me.UnitaComboBox)
        Me.Controls.Add(GestioneLabel)
        Me.Controls.Add(Me.GestioneComboBox)
        Me.Controls.Add(ImmobileLabel)
        Me.Controls.Add(Me.ImmobileComboBox)
        Me.Controls.Add(Me.Y_GestioniUnitaBindingNavigator)
        Me.Name = "Y_GestioniUnita"
        Me.Text = "Archivio Gestioni Unita' "
        CType(Me.IMMOBILIDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Y_GestioniUnitaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Y_GestioniUnitaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Y_GestioniUnitaBindingNavigator.ResumeLayout(False)
        Me.Y_GestioniUnitaBindingNavigator.PerformLayout()
        CType(Me.Y_GestioniUnitaDettaglioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Y_GestioniUnitaDettaglioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IMMOBILIDataSet2 As Patrimonio2014.IMMOBILIDataSet2
    Friend WithEvents Y_GestioniUnitaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Y_GestioniUnitaTableAdapter As Patrimonio2014.IMMOBILIDataSet2TableAdapters.Y_GestioniUnitaTableAdapter
    Friend WithEvents TableAdapterManager As Patrimonio2014.IMMOBILIDataSet2TableAdapters.TableAdapterManager
    Friend WithEvents Y_GestioniUnitaBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Y_GestioniUnitaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ImmobileComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GestioneComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents UnitaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SaldoGestionePrecedenteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SpeseAddebitateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InteressiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SpesePersonaliTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VersamentiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PreventivoAccontoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PreventivoProvvisorioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PreventivoSpesePersonaliTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Y_GestioniUnitaDettaglioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Y_GestioniUnitaDettaglioTableAdapter As Patrimonio2014.IMMOBILIDataSet2TableAdapters.Y_GestioniUnitaDettaglioTableAdapter
    Friend WithEvents Y_GestioniUnitaDettaglioDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
