<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Unita
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Unita))
        Dim UnitaLabel As System.Windows.Forms.Label
        Dim DescrizioneLabel As System.Windows.Forms.Label
        Dim FabbricatoLabel As System.Windows.Forms.Label
        Dim ScalaLabel As System.Windows.Forms.Label
        Dim ProprietarioLabel As System.Windows.Forms.Label
        Dim InquilinoLabel As System.Windows.Forms.Label
        Dim InternoLabel As System.Windows.Forms.Label
        Dim PianoLabel As System.Windows.Forms.Label
        Dim TrasmissioneSpeseLabel As System.Windows.Forms.Label
        Dim TrasmissioneConvocazioneLabel As System.Windows.Forms.Label
        Dim TrasmissioneAvvisiLabel As System.Windows.Forms.Label
        Dim CollegamentoLabel As System.Windows.Forms.Label
        Dim UnitaCollegataLabel As System.Windows.Forms.Label
        Me.IMMOBILIDataSet2 = New Patrimonio2014.IMMOBILIDataSet2()
        Me.UnitaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnitaTableAdapter = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.UnitaTableAdapter()
        Me.TableAdapterManager = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.TableAdapterManager()
        Me.UnitaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.UnitaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ImmobileComboBox = New System.Windows.Forms.ComboBox()
        Me.UnitaTextBox = New System.Windows.Forms.TextBox()
        Me.DescrizioneTextBox = New System.Windows.Forms.TextBox()
        Me.FabbricatoComboBox = New System.Windows.Forms.ComboBox()
        Me.ScalaComboBox = New System.Windows.Forms.ComboBox()
        Me.ProprietarioComboBox = New System.Windows.Forms.ComboBox()
        Me.InquilinoComboBox = New System.Windows.Forms.ComboBox()
        Me.InternoTextBox = New System.Windows.Forms.TextBox()
        Me.PianoTextBox = New System.Windows.Forms.TextBox()
        Me.TrasmissioneSpeseTextBox = New System.Windows.Forms.TextBox()
        Me.TrasmissioneConvocazioneTextBox = New System.Windows.Forms.TextBox()
        Me.TrasmissioneAvvisiTextBox = New System.Windows.Forms.TextBox()
        Me.CollegamentoTextBox = New System.Windows.Forms.TextBox()
        Me.UnitaCollegataTextBox = New System.Windows.Forms.TextBox()
        Me.UnitaDettaglioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnitaDettaglioTableAdapter = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.UnitaDettaglioTableAdapter()
        Me.UnitaDettaglioDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitaDettaglioLettureBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnitaDettaglioLettureTableAdapter = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.UnitaDettaglioLettureTableAdapter()
        Me.UnitaDettaglioLettureDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitaDettaglioAnagraficaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnitaDettaglioAnagraficaTableAdapter = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.UnitaDettaglioAnagraficaTableAdapter()
        Me.UnitaDettaglioAnagraficaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitaDettaglioMillesimiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnitaDettaglioMillesimiTableAdapter = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.UnitaDettaglioMillesimiTableAdapter()
        Me.UnitaDettaglioMillesimiDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        ImmobileLabel = New System.Windows.Forms.Label()
        UnitaLabel = New System.Windows.Forms.Label()
        DescrizioneLabel = New System.Windows.Forms.Label()
        FabbricatoLabel = New System.Windows.Forms.Label()
        ScalaLabel = New System.Windows.Forms.Label()
        ProprietarioLabel = New System.Windows.Forms.Label()
        InquilinoLabel = New System.Windows.Forms.Label()
        InternoLabel = New System.Windows.Forms.Label()
        PianoLabel = New System.Windows.Forms.Label()
        TrasmissioneSpeseLabel = New System.Windows.Forms.Label()
        TrasmissioneConvocazioneLabel = New System.Windows.Forms.Label()
        TrasmissioneAvvisiLabel = New System.Windows.Forms.Label()
        CollegamentoLabel = New System.Windows.Forms.Label()
        UnitaCollegataLabel = New System.Windows.Forms.Label()
        CType(Me.IMMOBILIDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UnitaBindingNavigator.SuspendLayout()
        CType(Me.UnitaDettaglioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitaDettaglioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitaDettaglioLettureBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitaDettaglioLettureDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitaDettaglioAnagraficaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitaDettaglioAnagraficaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitaDettaglioMillesimiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitaDettaglioMillesimiDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImmobileLabel
        '
        ImmobileLabel.AutoSize = True
        ImmobileLabel.Location = New System.Drawing.Point(12, 47)
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
        'UnitaBindingSource
        '
        Me.UnitaBindingSource.DataMember = "Unita"
        Me.UnitaBindingSource.DataSource = Me.IMMOBILIDataSet2
        '
        'UnitaTableAdapter
        '
        Me.UnitaTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.UnitaTableAdapter = Me.UnitaTableAdapter
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
        'UnitaBindingNavigator
        '
        Me.UnitaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.UnitaBindingNavigator.BindingSource = Me.UnitaBindingSource
        Me.UnitaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.UnitaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.UnitaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.UnitaBindingNavigatorSaveItem})
        Me.UnitaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.UnitaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.UnitaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.UnitaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.UnitaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.UnitaBindingNavigator.Name = "UnitaBindingNavigator"
        Me.UnitaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.UnitaBindingNavigator.Size = New System.Drawing.Size(941, 25)
        Me.UnitaBindingNavigator.TabIndex = 0
        Me.UnitaBindingNavigator.Text = "BindingNavigator1"
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
        'UnitaBindingNavigatorSaveItem
        '
        Me.UnitaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UnitaBindingNavigatorSaveItem.Image = CType(resources.GetObject("UnitaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.UnitaBindingNavigatorSaveItem.Name = "UnitaBindingNavigatorSaveItem"
        Me.UnitaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.UnitaBindingNavigatorSaveItem.Text = "Salva dati"
        '
        'ImmobileComboBox
        '
        Me.ImmobileComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UnitaBindingSource, "Immobile", True))
        Me.ImmobileComboBox.FormattingEnabled = True
        Me.ImmobileComboBox.Location = New System.Drawing.Point(15, 63)
        Me.ImmobileComboBox.Name = "ImmobileComboBox"
        Me.ImmobileComboBox.Size = New System.Drawing.Size(256, 21)
        Me.ImmobileComboBox.TabIndex = 2
        '
        'UnitaLabel
        '
        UnitaLabel.AutoSize = True
        UnitaLabel.Location = New System.Drawing.Point(277, 47)
        UnitaLabel.Name = "UnitaLabel"
        UnitaLabel.Size = New System.Drawing.Size(35, 13)
        UnitaLabel.TabIndex = 3
        UnitaLabel.Text = "Unita:"
        '
        'UnitaTextBox
        '
        Me.UnitaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UnitaBindingSource, "Unita", True))
        Me.UnitaTextBox.Location = New System.Drawing.Point(280, 63)
        Me.UnitaTextBox.Name = "UnitaTextBox"
        Me.UnitaTextBox.Size = New System.Drawing.Size(47, 20)
        Me.UnitaTextBox.TabIndex = 4
        '
        'DescrizioneLabel
        '
        DescrizioneLabel.AutoSize = True
        DescrizioneLabel.Location = New System.Drawing.Point(330, 47)
        DescrizioneLabel.Name = "DescrizioneLabel"
        DescrizioneLabel.Size = New System.Drawing.Size(65, 13)
        DescrizioneLabel.TabIndex = 5
        DescrizioneLabel.Text = "Descrizione:"
        '
        'DescrizioneTextBox
        '
        Me.DescrizioneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UnitaBindingSource, "Descrizione", True))
        Me.DescrizioneTextBox.Location = New System.Drawing.Point(333, 64)
        Me.DescrizioneTextBox.Name = "DescrizioneTextBox"
        Me.DescrizioneTextBox.Size = New System.Drawing.Size(254, 20)
        Me.DescrizioneTextBox.TabIndex = 6
        '
        'FabbricatoLabel
        '
        FabbricatoLabel.AutoSize = True
        FabbricatoLabel.Location = New System.Drawing.Point(12, 87)
        FabbricatoLabel.Name = "FabbricatoLabel"
        FabbricatoLabel.Size = New System.Drawing.Size(60, 13)
        FabbricatoLabel.TabIndex = 7
        FabbricatoLabel.Text = "Fabbricato:"
        '
        'FabbricatoComboBox
        '
        Me.FabbricatoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UnitaBindingSource, "Fabbricato", True))
        Me.FabbricatoComboBox.FormattingEnabled = True
        Me.FabbricatoComboBox.Location = New System.Drawing.Point(15, 103)
        Me.FabbricatoComboBox.Name = "FabbricatoComboBox"
        Me.FabbricatoComboBox.Size = New System.Drawing.Size(256, 21)
        Me.FabbricatoComboBox.TabIndex = 8
        '
        'ScalaLabel
        '
        ScalaLabel.AutoSize = True
        ScalaLabel.Location = New System.Drawing.Point(330, 87)
        ScalaLabel.Name = "ScalaLabel"
        ScalaLabel.Size = New System.Drawing.Size(37, 13)
        ScalaLabel.TabIndex = 9
        ScalaLabel.Text = "Scala:"
        '
        'ScalaComboBox
        '
        Me.ScalaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UnitaBindingSource, "Scala", True))
        Me.ScalaComboBox.FormattingEnabled = True
        Me.ScalaComboBox.Location = New System.Drawing.Point(333, 103)
        Me.ScalaComboBox.Name = "ScalaComboBox"
        Me.ScalaComboBox.Size = New System.Drawing.Size(254, 21)
        Me.ScalaComboBox.TabIndex = 10
        '
        'ProprietarioLabel
        '
        ProprietarioLabel.AutoSize = True
        ProprietarioLabel.Location = New System.Drawing.Point(12, 127)
        ProprietarioLabel.Name = "ProprietarioLabel"
        ProprietarioLabel.Size = New System.Drawing.Size(63, 13)
        ProprietarioLabel.TabIndex = 11
        ProprietarioLabel.Text = "Proprietario:"
        '
        'ProprietarioComboBox
        '
        Me.ProprietarioComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UnitaBindingSource, "Proprietario", True))
        Me.ProprietarioComboBox.FormattingEnabled = True
        Me.ProprietarioComboBox.Location = New System.Drawing.Point(15, 143)
        Me.ProprietarioComboBox.Name = "ProprietarioComboBox"
        Me.ProprietarioComboBox.Size = New System.Drawing.Size(256, 21)
        Me.ProprietarioComboBox.TabIndex = 12
        '
        'InquilinoLabel
        '
        InquilinoLabel.AutoSize = True
        InquilinoLabel.Location = New System.Drawing.Point(330, 127)
        InquilinoLabel.Name = "InquilinoLabel"
        InquilinoLabel.Size = New System.Drawing.Size(49, 13)
        InquilinoLabel.TabIndex = 13
        InquilinoLabel.Text = "Inquilino:"
        '
        'InquilinoComboBox
        '
        Me.InquilinoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UnitaBindingSource, "Inquilino", True))
        Me.InquilinoComboBox.FormattingEnabled = True
        Me.InquilinoComboBox.Location = New System.Drawing.Point(333, 143)
        Me.InquilinoComboBox.Name = "InquilinoComboBox"
        Me.InquilinoComboBox.Size = New System.Drawing.Size(254, 21)
        Me.InquilinoComboBox.TabIndex = 14
        '
        'InternoLabel
        '
        InternoLabel.AutoSize = True
        InternoLabel.Location = New System.Drawing.Point(12, 177)
        InternoLabel.Name = "InternoLabel"
        InternoLabel.Size = New System.Drawing.Size(43, 13)
        InternoLabel.TabIndex = 15
        InternoLabel.Text = "Interno:"
        '
        'InternoTextBox
        '
        Me.InternoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UnitaBindingSource, "Interno", True))
        Me.InternoTextBox.Location = New System.Drawing.Point(15, 193)
        Me.InternoTextBox.Name = "InternoTextBox"
        Me.InternoTextBox.Size = New System.Drawing.Size(40, 20)
        Me.InternoTextBox.TabIndex = 16
        '
        'PianoLabel
        '
        PianoLabel.AutoSize = True
        PianoLabel.Location = New System.Drawing.Point(61, 177)
        PianoLabel.Name = "PianoLabel"
        PianoLabel.Size = New System.Drawing.Size(37, 13)
        PianoLabel.TabIndex = 17
        PianoLabel.Text = "Piano:"
        '
        'PianoTextBox
        '
        Me.PianoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UnitaBindingSource, "Piano", True))
        Me.PianoTextBox.Location = New System.Drawing.Point(61, 193)
        Me.PianoTextBox.Name = "PianoTextBox"
        Me.PianoTextBox.Size = New System.Drawing.Size(37, 20)
        Me.PianoTextBox.TabIndex = 18
        '
        'TrasmissioneSpeseLabel
        '
        TrasmissioneSpeseLabel.AutoSize = True
        TrasmissioneSpeseLabel.Location = New System.Drawing.Point(104, 177)
        TrasmissioneSpeseLabel.Name = "TrasmissioneSpeseLabel"
        TrasmissioneSpeseLabel.Size = New System.Drawing.Size(56, 13)
        TrasmissioneSpeseLabel.TabIndex = 19
        TrasmissioneSpeseLabel.Text = "Tr. Spese:"
        '
        'TrasmissioneSpeseTextBox
        '
        Me.TrasmissioneSpeseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UnitaBindingSource, "TrasmissioneSpese", True))
        Me.TrasmissioneSpeseTextBox.Location = New System.Drawing.Point(107, 193)
        Me.TrasmissioneSpeseTextBox.Name = "TrasmissioneSpeseTextBox"
        Me.TrasmissioneSpeseTextBox.Size = New System.Drawing.Size(53, 20)
        Me.TrasmissioneSpeseTextBox.TabIndex = 20
        '
        'TrasmissioneConvocazioneLabel
        '
        TrasmissioneConvocazioneLabel.AutoSize = True
        TrasmissioneConvocazioneLabel.Location = New System.Drawing.Point(166, 177)
        TrasmissioneConvocazioneLabel.Name = "TrasmissioneConvocazioneLabel"
        TrasmissioneConvocazioneLabel.Size = New System.Drawing.Size(94, 13)
        TrasmissioneConvocazioneLabel.TabIndex = 21
        TrasmissioneConvocazioneLabel.Text = "Tr. Convocazione:"
        '
        'TrasmissioneConvocazioneTextBox
        '
        Me.TrasmissioneConvocazioneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UnitaBindingSource, "TrasmissioneConvocazione", True))
        Me.TrasmissioneConvocazioneTextBox.Location = New System.Drawing.Point(171, 193)
        Me.TrasmissioneConvocazioneTextBox.Name = "TrasmissioneConvocazioneTextBox"
        Me.TrasmissioneConvocazioneTextBox.Size = New System.Drawing.Size(89, 20)
        Me.TrasmissioneConvocazioneTextBox.TabIndex = 22
        '
        'TrasmissioneAvvisiLabel
        '
        TrasmissioneAvvisiLabel.AutoSize = True
        TrasmissioneAvvisiLabel.Location = New System.Drawing.Point(266, 177)
        TrasmissioneAvvisiLabel.Name = "TrasmissioneAvvisiLabel"
        TrasmissioneAvvisiLabel.Size = New System.Drawing.Size(54, 13)
        TrasmissioneAvvisiLabel.TabIndex = 23
        TrasmissioneAvvisiLabel.Text = "Tr. Avvisi:"
        '
        'TrasmissioneAvvisiTextBox
        '
        Me.TrasmissioneAvvisiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UnitaBindingSource, "TrasmissioneAvvisi", True))
        Me.TrasmissioneAvvisiTextBox.Location = New System.Drawing.Point(269, 193)
        Me.TrasmissioneAvvisiTextBox.Name = "TrasmissioneAvvisiTextBox"
        Me.TrasmissioneAvvisiTextBox.Size = New System.Drawing.Size(51, 20)
        Me.TrasmissioneAvvisiTextBox.TabIndex = 24
        '
        'CollegamentoLabel
        '
        CollegamentoLabel.AutoSize = True
        CollegamentoLabel.Location = New System.Drawing.Point(330, 177)
        CollegamentoLabel.Name = "CollegamentoLabel"
        CollegamentoLabel.Size = New System.Drawing.Size(74, 13)
        CollegamentoLabel.TabIndex = 25
        CollegamentoLabel.Text = "Collegamento:"
        '
        'CollegamentoTextBox
        '
        Me.CollegamentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UnitaBindingSource, "Collegamento", True))
        Me.CollegamentoTextBox.Location = New System.Drawing.Point(333, 193)
        Me.CollegamentoTextBox.Name = "CollegamentoTextBox"
        Me.CollegamentoTextBox.Size = New System.Drawing.Size(71, 20)
        Me.CollegamentoTextBox.TabIndex = 26
        '
        'UnitaCollegataLabel
        '
        UnitaCollegataLabel.AutoSize = True
        UnitaCollegataLabel.Location = New System.Drawing.Point(410, 177)
        UnitaCollegataLabel.Name = "UnitaCollegataLabel"
        UnitaCollegataLabel.Size = New System.Drawing.Size(82, 13)
        UnitaCollegataLabel.TabIndex = 27
        UnitaCollegataLabel.Text = "Unita Collegata:"
        '
        'UnitaCollegataTextBox
        '
        Me.UnitaCollegataTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UnitaBindingSource, "UnitaCollegata", True))
        Me.UnitaCollegataTextBox.Location = New System.Drawing.Point(413, 193)
        Me.UnitaCollegataTextBox.Name = "UnitaCollegataTextBox"
        Me.UnitaCollegataTextBox.Size = New System.Drawing.Size(79, 20)
        Me.UnitaCollegataTextBox.TabIndex = 28
        '
        'UnitaDettaglioBindingSource
        '
        Me.UnitaDettaglioBindingSource.DataMember = "UnitaUnitaDettaglio"
        Me.UnitaDettaglioBindingSource.DataSource = Me.UnitaBindingSource
        '
        'UnitaDettaglioTableAdapter
        '
        Me.UnitaDettaglioTableAdapter.ClearBeforeFill = True
        '
        'UnitaDettaglioDataGridView
        '
        Me.UnitaDettaglioDataGridView.AutoGenerateColumns = False
        Me.UnitaDettaglioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UnitaDettaglioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.UnitaDettaglioDataGridView.DataSource = Me.UnitaDettaglioBindingSource
        Me.UnitaDettaglioDataGridView.Location = New System.Drawing.Point(12, 228)
        Me.UnitaDettaglioDataGridView.Name = "UnitaDettaglioDataGridView"
        Me.UnitaDettaglioDataGridView.Size = New System.Drawing.Size(409, 220)
        Me.UnitaDettaglioDataGridView.TabIndex = 29
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Gruppo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Gruppo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 50
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Valore"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Valore"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PercentualeUtilizzo"
        Me.DataGridViewTextBoxColumn5.HeaderText = "PercentualeUtilizzo"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Puntatore"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Puntatore"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'UnitaDettaglioLettureBindingSource
        '
        Me.UnitaDettaglioLettureBindingSource.DataMember = "UnitaUnitaDettaglioLetture"
        Me.UnitaDettaglioLettureBindingSource.DataSource = Me.UnitaBindingSource
        '
        'UnitaDettaglioLettureTableAdapter
        '
        Me.UnitaDettaglioLettureTableAdapter.ClearBeforeFill = True
        '
        'UnitaDettaglioLettureDataGridView
        '
        Me.UnitaDettaglioLettureDataGridView.AutoGenerateColumns = False
        Me.UnitaDettaglioLettureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UnitaDettaglioLettureDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.UnitaDettaglioLettureDataGridView.DataSource = Me.UnitaDettaglioLettureBindingSource
        Me.UnitaDettaglioLettureDataGridView.Location = New System.Drawing.Point(427, 228)
        Me.UnitaDettaglioLettureDataGridView.Name = "UnitaDettaglioLettureDataGridView"
        Me.UnitaDettaglioLettureDataGridView.Size = New System.Drawing.Size(455, 220)
        Me.UnitaDettaglioLettureDataGridView.TabIndex = 30
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Gruppo"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Gruppo"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 50
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "LetturaAttuale"
        Me.DataGridViewTextBoxColumn8.HeaderText = "LetturaAttuale"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "LetturaPrecedente"
        Me.DataGridViewTextBoxColumn9.HeaderText = "LetturaPrecedente"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Matricola"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Matricola"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Note"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Note"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'UnitaDettaglioAnagraficaBindingSource
        '
        Me.UnitaDettaglioAnagraficaBindingSource.DataMember = "UnitaUnitaDettaglioAnagrafica"
        Me.UnitaDettaglioAnagraficaBindingSource.DataSource = Me.UnitaBindingSource
        '
        'UnitaDettaglioAnagraficaTableAdapter
        '
        Me.UnitaDettaglioAnagraficaTableAdapter.ClearBeforeFill = True
        '
        'UnitaDettaglioAnagraficaDataGridView
        '
        Me.UnitaDettaglioAnagraficaDataGridView.AutoGenerateColumns = False
        Me.UnitaDettaglioAnagraficaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UnitaDettaglioAnagraficaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32})
        Me.UnitaDettaglioAnagraficaDataGridView.DataSource = Me.UnitaDettaglioAnagraficaBindingSource
        Me.UnitaDettaglioAnagraficaDataGridView.Location = New System.Drawing.Point(12, 454)
        Me.UnitaDettaglioAnagraficaDataGridView.Name = "UnitaDettaglioAnagraficaDataGridView"
        Me.UnitaDettaglioAnagraficaDataGridView.Size = New System.Drawing.Size(870, 233)
        Me.UnitaDettaglioAnagraficaDataGridView.TabIndex = 31
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Riga"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Riga"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 50
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Foglio"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Foglio"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 50
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Mappale"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Mappale"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Subalterno"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Subalterno"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Interno"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Interno"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Scala"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Scala"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Tipo"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Codice"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Codice"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Cognome"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Cognome"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "Nome"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Nome"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "LuogoNascita"
        Me.DataGridViewTextBoxColumn22.HeaderText = "LuogoNascita"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "ProvinciaNascita"
        Me.DataGridViewTextBoxColumn23.HeaderText = "ProvinciaNascita"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "DataNascita"
        Me.DataGridViewTextBoxColumn24.HeaderText = "DataNascita"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "CodiceFiscale"
        Me.DataGridViewTextBoxColumn25.HeaderText = "CodiceFiscale"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "ResidenzaVia"
        Me.DataGridViewTextBoxColumn26.HeaderText = "ResidenzaVia"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "ResidenzaNumero"
        Me.DataGridViewTextBoxColumn27.HeaderText = "ResidenzaNumero"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "ResidenzaLocalita"
        Me.DataGridViewTextBoxColumn28.HeaderText = "ResidenzaLocalita"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "ResidenzaProvincia"
        Me.DataGridViewTextBoxColumn29.HeaderText = "ResidenzaProvincia"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "Telefono"
        Me.DataGridViewTextBoxColumn30.HeaderText = "Telefono"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn31.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "Note"
        Me.DataGridViewTextBoxColumn32.HeaderText = "Note"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        '
        'UnitaDettaglioMillesimiBindingSource
        '
        Me.UnitaDettaglioMillesimiBindingSource.DataMember = "UnitaUnitaDettaglioMillesimi"
        Me.UnitaDettaglioMillesimiBindingSource.DataSource = Me.UnitaBindingSource
        '
        'UnitaDettaglioMillesimiTableAdapter
        '
        Me.UnitaDettaglioMillesimiTableAdapter.ClearBeforeFill = True
        '
        'UnitaDettaglioMillesimiDataGridView
        '
        Me.UnitaDettaglioMillesimiDataGridView.AutoGenerateColumns = False
        Me.UnitaDettaglioMillesimiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UnitaDettaglioMillesimiDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn36})
        Me.UnitaDettaglioMillesimiDataGridView.DataSource = Me.UnitaDettaglioMillesimiBindingSource
        Me.UnitaDettaglioMillesimiDataGridView.Location = New System.Drawing.Point(611, 63)
        Me.UnitaDettaglioMillesimiDataGridView.Name = "UnitaDettaglioMillesimiDataGridView"
        Me.UnitaDettaglioMillesimiDataGridView.Size = New System.Drawing.Size(271, 159)
        Me.UnitaDettaglioMillesimiDataGridView.TabIndex = 32
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "Numero"
        Me.DataGridViewTextBoxColumn33.HeaderText = "Numero"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.Width = 50
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "Valore"
        Me.DataGridViewTextBoxColumn34.HeaderText = "Valore"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "PercentualeUtilizzo"
        Me.DataGridViewTextBoxColumn35.HeaderText = "PercentualeUtilizzo"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "Descrizione"
        Me.DataGridViewTextBoxColumn36.HeaderText = "Descrizione"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        '
        'Unita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(941, 707)
        Me.Controls.Add(Me.UnitaDettaglioMillesimiDataGridView)
        Me.Controls.Add(Me.UnitaDettaglioAnagraficaDataGridView)
        Me.Controls.Add(Me.UnitaDettaglioLettureDataGridView)
        Me.Controls.Add(Me.UnitaDettaglioDataGridView)
        Me.Controls.Add(UnitaCollegataLabel)
        Me.Controls.Add(Me.UnitaCollegataTextBox)
        Me.Controls.Add(CollegamentoLabel)
        Me.Controls.Add(Me.CollegamentoTextBox)
        Me.Controls.Add(TrasmissioneAvvisiLabel)
        Me.Controls.Add(Me.TrasmissioneAvvisiTextBox)
        Me.Controls.Add(TrasmissioneConvocazioneLabel)
        Me.Controls.Add(Me.TrasmissioneConvocazioneTextBox)
        Me.Controls.Add(TrasmissioneSpeseLabel)
        Me.Controls.Add(Me.TrasmissioneSpeseTextBox)
        Me.Controls.Add(PianoLabel)
        Me.Controls.Add(Me.PianoTextBox)
        Me.Controls.Add(InternoLabel)
        Me.Controls.Add(Me.InternoTextBox)
        Me.Controls.Add(InquilinoLabel)
        Me.Controls.Add(Me.InquilinoComboBox)
        Me.Controls.Add(ProprietarioLabel)
        Me.Controls.Add(Me.ProprietarioComboBox)
        Me.Controls.Add(ScalaLabel)
        Me.Controls.Add(Me.ScalaComboBox)
        Me.Controls.Add(FabbricatoLabel)
        Me.Controls.Add(Me.FabbricatoComboBox)
        Me.Controls.Add(DescrizioneLabel)
        Me.Controls.Add(Me.DescrizioneTextBox)
        Me.Controls.Add(UnitaLabel)
        Me.Controls.Add(Me.UnitaTextBox)
        Me.Controls.Add(ImmobileLabel)
        Me.Controls.Add(Me.ImmobileComboBox)
        Me.Controls.Add(Me.UnitaBindingNavigator)
        Me.Name = "Unita"
        Me.Text = "Unita' Immobiliari"
        CType(Me.IMMOBILIDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UnitaBindingNavigator.ResumeLayout(False)
        Me.UnitaBindingNavigator.PerformLayout()
        CType(Me.UnitaDettaglioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitaDettaglioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitaDettaglioLettureBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitaDettaglioLettureDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitaDettaglioAnagraficaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitaDettaglioAnagraficaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitaDettaglioMillesimiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitaDettaglioMillesimiDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IMMOBILIDataSet2 As Patrimonio2014.IMMOBILIDataSet2
    Friend WithEvents UnitaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UnitaTableAdapter As Patrimonio2014.IMMOBILIDataSet2TableAdapters.UnitaTableAdapter
    Friend WithEvents TableAdapterManager As Patrimonio2014.IMMOBILIDataSet2TableAdapters.TableAdapterManager
    Friend WithEvents UnitaBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents UnitaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ImmobileComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents UnitaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescrizioneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FabbricatoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ScalaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ProprietarioComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents InquilinoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents InternoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PianoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TrasmissioneSpeseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TrasmissioneConvocazioneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TrasmissioneAvvisiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CollegamentoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UnitaCollegataTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UnitaDettaglioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UnitaDettaglioTableAdapter As Patrimonio2014.IMMOBILIDataSet2TableAdapters.UnitaDettaglioTableAdapter
    Friend WithEvents UnitaDettaglioDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitaDettaglioLettureBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UnitaDettaglioLettureTableAdapter As Patrimonio2014.IMMOBILIDataSet2TableAdapters.UnitaDettaglioLettureTableAdapter
    Friend WithEvents UnitaDettaglioLettureDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitaDettaglioAnagraficaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UnitaDettaglioAnagraficaTableAdapter As Patrimonio2014.IMMOBILIDataSet2TableAdapters.UnitaDettaglioAnagraficaTableAdapter
    Friend WithEvents UnitaDettaglioAnagraficaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitaDettaglioMillesimiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UnitaDettaglioMillesimiTableAdapter As Patrimonio2014.IMMOBILIDataSet2TableAdapters.UnitaDettaglioMillesimiTableAdapter
    Friend WithEvents UnitaDettaglioMillesimiDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
