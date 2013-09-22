<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Assemblea
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
        Dim GestioneLabel As System.Windows.Forms.Label
        Dim TotaleMillesimiLabel As System.Windows.Forms.Label
        Dim TotalePersoneLabel As System.Windows.Forms.Label
        Dim _1VotazioneLabel As System.Windows.Forms.Label
        Dim _1RisultatoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Assemblea))
        Me.IMMOBILIDataSet2 = New Patrimonio2014.IMMOBILIDataSet2()
        Me.AssembleaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AssembleaTableAdapter = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.AssembleaTableAdapter()
        Me.TableAdapterManager = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.TableAdapterManager()
        Me.AssembleaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.AssembleaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ImmobileComboBox = New System.Windows.Forms.ComboBox()
        Me.GestioneComboBox = New System.Windows.Forms.ComboBox()
        Me.TotaleMillesimiTextBox = New System.Windows.Forms.TextBox()
        Me.TotalePersoneTextBox = New System.Windows.Forms.TextBox()
        Me._1VotazioneTextBox = New System.Windows.Forms.TextBox()
        Me._1RisultatoTextBox = New System.Windows.Forms.TextBox()
        Me._2VotazioneTextBox = New System.Windows.Forms.TextBox()
        Me._2RisultatoTextBox = New System.Windows.Forms.TextBox()
        Me._3VotazioneTextBox = New System.Windows.Forms.TextBox()
        Me._3RisultatoTextBox = New System.Windows.Forms.TextBox()
        Me._4VotazioneTextBox = New System.Windows.Forms.TextBox()
        Me._4RisultatoTextBox = New System.Windows.Forms.TextBox()
        Me._5VotazioneTextBox = New System.Windows.Forms.TextBox()
        Me._5RisultatoTextBox = New System.Windows.Forms.TextBox()
        Me._6VotazioneTextBox = New System.Windows.Forms.TextBox()
        Me._6RisultatoTextBox = New System.Windows.Forms.TextBox()
        Me._7VotazioneTextBox = New System.Windows.Forms.TextBox()
        Me._7RisultatoTextBox = New System.Windows.Forms.TextBox()
        Me._8VotazioneTextBox = New System.Windows.Forms.TextBox()
        Me._8RisultatoTextBox = New System.Windows.Forms.TextBox()
        Me._9VotazioneTextBox = New System.Windows.Forms.TextBox()
        Me._9RisultatoTextBox = New System.Windows.Forms.TextBox()
        Me.AssembleaDettaglioTableAdapter = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.AssembleaDettaglioTableAdapter()
        Me.AssembleaDettaglioBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AssembleaDettaglioDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        ImmobileLabel = New System.Windows.Forms.Label()
        GestioneLabel = New System.Windows.Forms.Label()
        TotaleMillesimiLabel = New System.Windows.Forms.Label()
        TotalePersoneLabel = New System.Windows.Forms.Label()
        _1VotazioneLabel = New System.Windows.Forms.Label()
        _1RisultatoLabel = New System.Windows.Forms.Label()
        CType(Me.IMMOBILIDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssembleaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssembleaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AssembleaBindingNavigator.SuspendLayout()
        CType(Me.AssembleaDettaglioBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssembleaDettaglioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImmobileLabel
        '
        ImmobileLabel.AutoSize = True
        ImmobileLabel.Location = New System.Drawing.Point(9, 50)
        ImmobileLabel.Name = "ImmobileLabel"
        ImmobileLabel.Size = New System.Drawing.Size(51, 13)
        ImmobileLabel.TabIndex = 1
        ImmobileLabel.Text = "Immobile:"
        '
        'GestioneLabel
        '
        GestioneLabel.AutoSize = True
        GestioneLabel.Location = New System.Drawing.Point(317, 50)
        GestioneLabel.Name = "GestioneLabel"
        GestioneLabel.Size = New System.Drawing.Size(52, 13)
        GestioneLabel.TabIndex = 3
        GestioneLabel.Text = "Gestione:"
        '
        'TotaleMillesimiLabel
        '
        TotaleMillesimiLabel.AutoSize = True
        TotaleMillesimiLabel.Location = New System.Drawing.Point(393, 329)
        TotaleMillesimiLabel.Name = "TotaleMillesimiLabel"
        TotaleMillesimiLabel.Size = New System.Drawing.Size(81, 13)
        TotaleMillesimiLabel.TabIndex = 5
        TotaleMillesimiLabel.Text = "Totale Millesimi:"
        '
        'TotalePersoneLabel
        '
        TotalePersoneLabel.AutoSize = True
        TotalePersoneLabel.Location = New System.Drawing.Point(12, 329)
        TotalePersoneLabel.Name = "TotalePersoneLabel"
        TotalePersoneLabel.Size = New System.Drawing.Size(82, 13)
        TotalePersoneLabel.TabIndex = 7
        TotalePersoneLabel.Text = "Totale Persone:"
        '
        '_1VotazioneLabel
        '
        _1VotazioneLabel.AutoSize = True
        _1VotazioneLabel.Location = New System.Drawing.Point(12, 386)
        _1VotazioneLabel.Name = "_1VotazioneLabel"
        _1VotazioneLabel.Size = New System.Drawing.Size(57, 13)
        _1VotazioneLabel.TabIndex = 9
        _1VotazioneLabel.Text = "Votazione:"
        '
        '_1RisultatoLabel
        '
        _1RisultatoLabel.AutoSize = True
        _1RisultatoLabel.Location = New System.Drawing.Point(206, 386)
        _1RisultatoLabel.Name = "_1RisultatoLabel"
        _1RisultatoLabel.Size = New System.Drawing.Size(51, 13)
        _1RisultatoLabel.TabIndex = 11
        _1RisultatoLabel.Text = "Risultato:"
        '
        'IMMOBILIDataSet2
        '
        Me.IMMOBILIDataSet2.DataSetName = "IMMOBILIDataSet2"
        Me.IMMOBILIDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AssembleaBindingSource
        '
        Me.AssembleaBindingSource.DataMember = "Assemblea"
        Me.AssembleaBindingSource.DataSource = Me.IMMOBILIDataSet2
        '
        'AssembleaTableAdapter
        '
        Me.AssembleaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AnagraficaStudioTableAdapter = Nothing
        Me.TableAdapterManager.AnagraficheTableAdapter = Nothing
        Me.TableAdapterManager.AssembleaDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.AssembleaTableAdapter = Me.AssembleaTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CassaTableAdapter = Nothing
        Me.TableAdapterManager.ContiFinanziariTableAdapter = Nothing
        Me.TableAdapterManager.CostantiTableAdapter = Nothing
        Me.TableAdapterManager.FabbricatiDettaglioTableAdapter = Nothing
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
        'AssembleaBindingNavigator
        '
        Me.AssembleaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AssembleaBindingNavigator.BindingSource = Me.AssembleaBindingSource
        Me.AssembleaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AssembleaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AssembleaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AssembleaBindingNavigatorSaveItem})
        Me.AssembleaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AssembleaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AssembleaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AssembleaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AssembleaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AssembleaBindingNavigator.Name = "AssembleaBindingNavigator"
        Me.AssembleaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AssembleaBindingNavigator.Size = New System.Drawing.Size(920, 25)
        Me.AssembleaBindingNavigator.TabIndex = 0
        Me.AssembleaBindingNavigator.Text = "BindingNavigator1"
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
        'AssembleaBindingNavigatorSaveItem
        '
        Me.AssembleaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AssembleaBindingNavigatorSaveItem.Image = CType(resources.GetObject("AssembleaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AssembleaBindingNavigatorSaveItem.Name = "AssembleaBindingNavigatorSaveItem"
        Me.AssembleaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.AssembleaBindingNavigatorSaveItem.Text = "Salva dati"
        '
        'ImmobileComboBox
        '
        Me.ImmobileComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "Immobile", True))
        Me.ImmobileComboBox.FormattingEnabled = True
        Me.ImmobileComboBox.Location = New System.Drawing.Point(15, 66)
        Me.ImmobileComboBox.Name = "ImmobileComboBox"
        Me.ImmobileComboBox.Size = New System.Drawing.Size(288, 21)
        Me.ImmobileComboBox.TabIndex = 2
        '
        'GestioneComboBox
        '
        Me.GestioneComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "Gestione", True))
        Me.GestioneComboBox.FormattingEnabled = True
        Me.GestioneComboBox.Location = New System.Drawing.Point(320, 66)
        Me.GestioneComboBox.Name = "GestioneComboBox"
        Me.GestioneComboBox.Size = New System.Drawing.Size(270, 21)
        Me.GestioneComboBox.TabIndex = 4
        '
        'TotaleMillesimiTextBox
        '
        Me.TotaleMillesimiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "TotaleMillesimi", True))
        Me.TotaleMillesimiTextBox.Location = New System.Drawing.Point(397, 345)
        Me.TotaleMillesimiTextBox.Name = "TotaleMillesimiTextBox"
        Me.TotaleMillesimiTextBox.Size = New System.Drawing.Size(77, 20)
        Me.TotaleMillesimiTextBox.TabIndex = 6
        '
        'TotalePersoneTextBox
        '
        Me.TotalePersoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "TotalePersone", True))
        Me.TotalePersoneTextBox.Location = New System.Drawing.Point(15, 345)
        Me.TotalePersoneTextBox.Name = "TotalePersoneTextBox"
        Me.TotalePersoneTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalePersoneTextBox.TabIndex = 8
        '
        '_1VotazioneTextBox
        '
        Me._1VotazioneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "1Votazione", True))
        Me._1VotazioneTextBox.Location = New System.Drawing.Point(15, 402)
        Me._1VotazioneTextBox.Name = "_1VotazioneTextBox"
        Me._1VotazioneTextBox.Size = New System.Drawing.Size(182, 20)
        Me._1VotazioneTextBox.TabIndex = 10
        '
        '_1RisultatoTextBox
        '
        Me._1RisultatoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "1Risultato", True))
        Me._1RisultatoTextBox.Location = New System.Drawing.Point(209, 402)
        Me._1RisultatoTextBox.Name = "_1RisultatoTextBox"
        Me._1RisultatoTextBox.Size = New System.Drawing.Size(381, 20)
        Me._1RisultatoTextBox.TabIndex = 12
        '
        '_2VotazioneTextBox
        '
        Me._2VotazioneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "2Votazione", True))
        Me._2VotazioneTextBox.Location = New System.Drawing.Point(15, 428)
        Me._2VotazioneTextBox.Name = "_2VotazioneTextBox"
        Me._2VotazioneTextBox.Size = New System.Drawing.Size(182, 20)
        Me._2VotazioneTextBox.TabIndex = 14
        '
        '_2RisultatoTextBox
        '
        Me._2RisultatoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "2Risultato", True))
        Me._2RisultatoTextBox.Location = New System.Drawing.Point(209, 428)
        Me._2RisultatoTextBox.Name = "_2RisultatoTextBox"
        Me._2RisultatoTextBox.Size = New System.Drawing.Size(381, 20)
        Me._2RisultatoTextBox.TabIndex = 15
        '
        '_3VotazioneTextBox
        '
        Me._3VotazioneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "3Votazione", True))
        Me._3VotazioneTextBox.Location = New System.Drawing.Point(15, 454)
        Me._3VotazioneTextBox.Name = "_3VotazioneTextBox"
        Me._3VotazioneTextBox.Size = New System.Drawing.Size(182, 20)
        Me._3VotazioneTextBox.TabIndex = 16
        '
        '_3RisultatoTextBox
        '
        Me._3RisultatoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "3Risultato", True))
        Me._3RisultatoTextBox.Location = New System.Drawing.Point(209, 454)
        Me._3RisultatoTextBox.Name = "_3RisultatoTextBox"
        Me._3RisultatoTextBox.Size = New System.Drawing.Size(381, 20)
        Me._3RisultatoTextBox.TabIndex = 17
        '
        '_4VotazioneTextBox
        '
        Me._4VotazioneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "4Votazione", True))
        Me._4VotazioneTextBox.Location = New System.Drawing.Point(15, 480)
        Me._4VotazioneTextBox.Name = "_4VotazioneTextBox"
        Me._4VotazioneTextBox.Size = New System.Drawing.Size(182, 20)
        Me._4VotazioneTextBox.TabIndex = 18
        '
        '_4RisultatoTextBox
        '
        Me._4RisultatoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "4Risultato", True))
        Me._4RisultatoTextBox.Location = New System.Drawing.Point(209, 480)
        Me._4RisultatoTextBox.Name = "_4RisultatoTextBox"
        Me._4RisultatoTextBox.Size = New System.Drawing.Size(381, 20)
        Me._4RisultatoTextBox.TabIndex = 19
        '
        '_5VotazioneTextBox
        '
        Me._5VotazioneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "5Votazione", True))
        Me._5VotazioneTextBox.Location = New System.Drawing.Point(15, 506)
        Me._5VotazioneTextBox.Name = "_5VotazioneTextBox"
        Me._5VotazioneTextBox.Size = New System.Drawing.Size(182, 20)
        Me._5VotazioneTextBox.TabIndex = 20
        '
        '_5RisultatoTextBox
        '
        Me._5RisultatoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "5Risultato", True))
        Me._5RisultatoTextBox.Location = New System.Drawing.Point(209, 506)
        Me._5RisultatoTextBox.Name = "_5RisultatoTextBox"
        Me._5RisultatoTextBox.Size = New System.Drawing.Size(381, 20)
        Me._5RisultatoTextBox.TabIndex = 21
        '
        '_6VotazioneTextBox
        '
        Me._6VotazioneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "6Votazione", True))
        Me._6VotazioneTextBox.Location = New System.Drawing.Point(15, 532)
        Me._6VotazioneTextBox.Name = "_6VotazioneTextBox"
        Me._6VotazioneTextBox.Size = New System.Drawing.Size(182, 20)
        Me._6VotazioneTextBox.TabIndex = 22
        '
        '_6RisultatoTextBox
        '
        Me._6RisultatoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "6Risultato", True))
        Me._6RisultatoTextBox.Location = New System.Drawing.Point(209, 532)
        Me._6RisultatoTextBox.Name = "_6RisultatoTextBox"
        Me._6RisultatoTextBox.Size = New System.Drawing.Size(381, 20)
        Me._6RisultatoTextBox.TabIndex = 23
        '
        '_7VotazioneTextBox
        '
        Me._7VotazioneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "7Votazione", True))
        Me._7VotazioneTextBox.Location = New System.Drawing.Point(15, 558)
        Me._7VotazioneTextBox.Name = "_7VotazioneTextBox"
        Me._7VotazioneTextBox.Size = New System.Drawing.Size(182, 20)
        Me._7VotazioneTextBox.TabIndex = 24
        '
        '_7RisultatoTextBox
        '
        Me._7RisultatoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "7Risultato", True))
        Me._7RisultatoTextBox.Location = New System.Drawing.Point(209, 558)
        Me._7RisultatoTextBox.Name = "_7RisultatoTextBox"
        Me._7RisultatoTextBox.Size = New System.Drawing.Size(381, 20)
        Me._7RisultatoTextBox.TabIndex = 25
        '
        '_8VotazioneTextBox
        '
        Me._8VotazioneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "8Votazione", True))
        Me._8VotazioneTextBox.Location = New System.Drawing.Point(15, 584)
        Me._8VotazioneTextBox.Name = "_8VotazioneTextBox"
        Me._8VotazioneTextBox.Size = New System.Drawing.Size(182, 20)
        Me._8VotazioneTextBox.TabIndex = 26
        '
        '_8RisultatoTextBox
        '
        Me._8RisultatoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "8Risultato", True))
        Me._8RisultatoTextBox.Location = New System.Drawing.Point(209, 584)
        Me._8RisultatoTextBox.Name = "_8RisultatoTextBox"
        Me._8RisultatoTextBox.Size = New System.Drawing.Size(381, 20)
        Me._8RisultatoTextBox.TabIndex = 27
        '
        '_9VotazioneTextBox
        '
        Me._9VotazioneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "9Votazione", True))
        Me._9VotazioneTextBox.Location = New System.Drawing.Point(15, 610)
        Me._9VotazioneTextBox.Name = "_9VotazioneTextBox"
        Me._9VotazioneTextBox.Size = New System.Drawing.Size(182, 20)
        Me._9VotazioneTextBox.TabIndex = 28
        '
        '_9RisultatoTextBox
        '
        Me._9RisultatoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "9Risultato", True))
        Me._9RisultatoTextBox.Location = New System.Drawing.Point(209, 610)
        Me._9RisultatoTextBox.Name = "_9RisultatoTextBox"
        Me._9RisultatoTextBox.Size = New System.Drawing.Size(381, 20)
        Me._9RisultatoTextBox.TabIndex = 29
        '
        'AssembleaDettaglioTableAdapter
        '
        Me.AssembleaDettaglioTableAdapter.ClearBeforeFill = True
        '
        'AssembleaDettaglioBindingSource1
        '
        Me.AssembleaDettaglioBindingSource1.DataMember = "AssembleaAssembleaDettaglio"
        Me.AssembleaDettaglioBindingSource1.DataSource = Me.AssembleaBindingSource
        '
        'AssembleaDettaglioDataGridView
        '
        Me.AssembleaDettaglioDataGridView.AutoGenerateColumns = False
        Me.AssembleaDettaglioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AssembleaDettaglioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17})
        Me.AssembleaDettaglioDataGridView.DataSource = Me.AssembleaDettaglioBindingSource1
        Me.AssembleaDettaglioDataGridView.Location = New System.Drawing.Point(17, 105)
        Me.AssembleaDettaglioDataGridView.Name = "AssembleaDettaglioDataGridView"
        Me.AssembleaDettaglioDataGridView.Size = New System.Drawing.Size(816, 220)
        Me.AssembleaDettaglioDataGridView.TabIndex = 29
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Progressivo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Progressivo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 70
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Anagrafica"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Anagrafica"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 70
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Nominativo"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Nominativo"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 200
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Millesimo"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Millesimo"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 70
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Presenza"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Presenza"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 70
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Delega"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Delega"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Votazione1"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Votazione1"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 70
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Votazione2"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Votazione2"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 70
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Votazione3"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Votazione3"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 70
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Votazione4"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Votazione4"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 70
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Votazione5"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Votazione5"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 70
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Votazione6"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Votazione6"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 70
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Votazione7"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Votazione7"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 70
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Votazione8"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Votazione8"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Width = 70
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Votazione9"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Votazione9"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Width = 70
        '
        'Assemblea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 650)
        Me.Controls.Add(Me.AssembleaDettaglioDataGridView)
        Me.Controls.Add(Me._9RisultatoTextBox)
        Me.Controls.Add(Me._9VotazioneTextBox)
        Me.Controls.Add(Me._8RisultatoTextBox)
        Me.Controls.Add(Me._8VotazioneTextBox)
        Me.Controls.Add(Me._7RisultatoTextBox)
        Me.Controls.Add(Me._7VotazioneTextBox)
        Me.Controls.Add(Me._6RisultatoTextBox)
        Me.Controls.Add(Me._6VotazioneTextBox)
        Me.Controls.Add(Me._5RisultatoTextBox)
        Me.Controls.Add(Me._5VotazioneTextBox)
        Me.Controls.Add(Me._4RisultatoTextBox)
        Me.Controls.Add(Me._4VotazioneTextBox)
        Me.Controls.Add(Me._3RisultatoTextBox)
        Me.Controls.Add(Me._3VotazioneTextBox)
        Me.Controls.Add(Me._2RisultatoTextBox)
        Me.Controls.Add(Me._2VotazioneTextBox)
        Me.Controls.Add(_1RisultatoLabel)
        Me.Controls.Add(Me._1RisultatoTextBox)
        Me.Controls.Add(_1VotazioneLabel)
        Me.Controls.Add(Me._1VotazioneTextBox)
        Me.Controls.Add(TotalePersoneLabel)
        Me.Controls.Add(Me.TotalePersoneTextBox)
        Me.Controls.Add(TotaleMillesimiLabel)
        Me.Controls.Add(Me.TotaleMillesimiTextBox)
        Me.Controls.Add(GestioneLabel)
        Me.Controls.Add(Me.GestioneComboBox)
        Me.Controls.Add(ImmobileLabel)
        Me.Controls.Add(Me.ImmobileComboBox)
        Me.Controls.Add(Me.AssembleaBindingNavigator)
        Me.Name = "Assemblea"
        Me.Text = "Assemblea"
        CType(Me.IMMOBILIDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssembleaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssembleaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AssembleaBindingNavigator.ResumeLayout(False)
        Me.AssembleaBindingNavigator.PerformLayout()
        CType(Me.AssembleaDettaglioBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssembleaDettaglioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IMMOBILIDataSet2 As Patrimonio2014.IMMOBILIDataSet2
    Friend WithEvents AssembleaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AssembleaTableAdapter As Patrimonio2014.IMMOBILIDataSet2TableAdapters.AssembleaTableAdapter
    Friend WithEvents TableAdapterManager As Patrimonio2014.IMMOBILIDataSet2TableAdapters.TableAdapterManager
    Friend WithEvents AssembleaBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents AssembleaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ImmobileComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GestioneComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TotaleMillesimiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalePersoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents _1VotazioneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents _1RisultatoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents _2VotazioneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents _2RisultatoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents _3VotazioneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents _3RisultatoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents _4VotazioneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents _4RisultatoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents _5VotazioneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents _5RisultatoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents _6VotazioneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents _6RisultatoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents _7VotazioneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents _7RisultatoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents _8VotazioneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents _8RisultatoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents _9VotazioneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents _9RisultatoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AssembleaDettaglioTableAdapter As Patrimonio2014.IMMOBILIDataSet2TableAdapters.AssembleaDettaglioTableAdapter
    Friend WithEvents AssembleaDettaglioBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents AssembleaDettaglioDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
