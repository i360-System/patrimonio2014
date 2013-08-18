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
        Dim _6VotazioneLabel As System.Windows.Forms.Label
        Dim _6RisultatoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Assemblea))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.IMMOBILIDataSet = New Patrimonio2014.IMMOBILIDataSet()
        Me.AssembleaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AssembleaTableAdapter = New Patrimonio2014.IMMOBILIDataSetTableAdapters.AssembleaTableAdapter()
        Me.TableAdapterManager = New Patrimonio2014.IMMOBILIDataSetTableAdapters.TableAdapterManager()
        Me.AssembleaDettaglioTableAdapter = New Patrimonio2014.IMMOBILIDataSetTableAdapters.AssembleaDettaglioTableAdapter()
        Me.Immobile = New System.Windows.Forms.ComboBox()
        Me.AssembleaDettaglioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Gestione = New System.Windows.Forms.ComboBox()
        Me.TotaleMillesimi = New System.Windows.Forms.TextBox()
        Me.TotalePersone = New System.Windows.Forms.TextBox()
        Me._1Votazione = New System.Windows.Forms.TextBox()
        Me._1Risultato = New System.Windows.Forms.TextBox()
        Me._2Votazione = New System.Windows.Forms.TextBox()
        Me._2Risultato = New System.Windows.Forms.TextBox()
        Me._3Votazione = New System.Windows.Forms.TextBox()
        Me._3Risultato = New System.Windows.Forms.TextBox()
        Me._4Votazione = New System.Windows.Forms.TextBox()
        Me._4Risultato = New System.Windows.Forms.TextBox()
        Me._5Votazione = New System.Windows.Forms.TextBox()
        Me._5Risultato = New System.Windows.Forms.TextBox()
        Me._6Votazione = New System.Windows.Forms.TextBox()
        Me._6Risultato = New System.Windows.Forms.TextBox()
        Me._7Votazione = New System.Windows.Forms.TextBox()
        Me._7Risultato = New System.Windows.Forms.TextBox()
        Me._8Votazione = New System.Windows.Forms.TextBox()
        Me._8Risultato = New System.Windows.Forms.TextBox()
        Me._9Votazione = New System.Windows.Forms.TextBox()
        Me._9Risultato = New System.Windows.Forms.TextBox()
        Me.AssembleaDettaglioBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AssembleaDettaglio = New System.Windows.Forms.DataGridView()
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
        GestioneLabel = New System.Windows.Forms.Label()
        TotaleMillesimiLabel = New System.Windows.Forms.Label()
        TotalePersoneLabel = New System.Windows.Forms.Label()
        _1VotazioneLabel = New System.Windows.Forms.Label()
        _1RisultatoLabel = New System.Windows.Forms.Label()
        _6VotazioneLabel = New System.Windows.Forms.Label()
        _6RisultatoLabel = New System.Windows.Forms.Label()
        CType(Me.IMMOBILIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssembleaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssembleaDettaglioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssembleaDettaglioBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssembleaDettaglio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnagraficaStudioBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AnagraficaStudioBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImmobileLabel
        '
        ImmobileLabel.AutoSize = True
        ImmobileLabel.Location = New System.Drawing.Point(12, 51)
        ImmobileLabel.Name = "ImmobileLabel"
        ImmobileLabel.Size = New System.Drawing.Size(51, 13)
        ImmobileLabel.TabIndex = 1
        ImmobileLabel.Text = "Immobile:"
        '
        'GestioneLabel
        '
        GestioneLabel.AutoSize = True
        GestioneLabel.Location = New System.Drawing.Point(321, 51)
        GestioneLabel.Name = "GestioneLabel"
        GestioneLabel.Size = New System.Drawing.Size(52, 13)
        GestioneLabel.TabIndex = 3
        GestioneLabel.Text = "Gestione:"
        '
        'TotaleMillesimiLabel
        '
        TotaleMillesimiLabel.AutoSize = True
        TotaleMillesimiLabel.Location = New System.Drawing.Point(631, 51)
        TotaleMillesimiLabel.Name = "TotaleMillesimiLabel"
        TotaleMillesimiLabel.Size = New System.Drawing.Size(81, 13)
        TotaleMillesimiLabel.TabIndex = 5
        TotaleMillesimiLabel.Text = "Totale Millesimi:"
        '
        'TotalePersoneLabel
        '
        TotalePersoneLabel.AutoSize = True
        TotalePersoneLabel.Location = New System.Drawing.Point(728, 51)
        TotalePersoneLabel.Name = "TotalePersoneLabel"
        TotalePersoneLabel.Size = New System.Drawing.Size(82, 13)
        TotalePersoneLabel.TabIndex = 7
        TotalePersoneLabel.Text = "Totale Persone:"
        '
        '_1VotazioneLabel
        '
        _1VotazioneLabel.AutoSize = True
        _1VotazioneLabel.Location = New System.Drawing.Point(12, 100)
        _1VotazioneLabel.Name = "_1VotazioneLabel"
        _1VotazioneLabel.Size = New System.Drawing.Size(57, 13)
        _1VotazioneLabel.TabIndex = 9
        _1VotazioneLabel.Text = "Votazione:"
        '
        '_1RisultatoLabel
        '
        _1RisultatoLabel.AutoSize = True
        _1RisultatoLabel.Location = New System.Drawing.Point(182, 100)
        _1RisultatoLabel.Name = "_1RisultatoLabel"
        _1RisultatoLabel.Size = New System.Drawing.Size(51, 13)
        _1RisultatoLabel.TabIndex = 11
        _1RisultatoLabel.Text = "Risultato:"
        '
        '_6VotazioneLabel
        '
        _6VotazioneLabel.AutoSize = True
        _6VotazioneLabel.Location = New System.Drawing.Point(421, 100)
        _6VotazioneLabel.Name = "_6VotazioneLabel"
        _6VotazioneLabel.Size = New System.Drawing.Size(57, 13)
        _6VotazioneLabel.TabIndex = 26
        _6VotazioneLabel.Text = "Votazione:"
        '
        '_6RisultatoLabel
        '
        _6RisultatoLabel.AutoSize = True
        _6RisultatoLabel.Location = New System.Drawing.Point(589, 100)
        _6RisultatoLabel.Name = "_6RisultatoLabel"
        _6RisultatoLabel.Size = New System.Drawing.Size(51, 13)
        _6RisultatoLabel.TabIndex = 28
        _6RisultatoLabel.Text = "Risultato:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(169, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(169, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(169, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(169, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(169, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(576, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "6"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(576, 151)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "7"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(576, 177)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 13)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "8"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(576, 204)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 13)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "9"
        '
        'IMMOBILIDataSet
        '
        Me.IMMOBILIDataSet.DataSetName = "IMMOBILIDataSet"
        Me.IMMOBILIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AssembleaBindingSource
        '
        Me.AssembleaBindingSource.DataMember = "Assemblea"
        Me.AssembleaBindingSource.DataSource = Me.IMMOBILIDataSet
        '
        'AssembleaTableAdapter
        '
        Me.AssembleaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AnagraficaStudioTableAdapter = Nothing
        Me.TableAdapterManager.AnagraficheTableAdapter = Nothing
        Me.TableAdapterManager.AssembleaDettaglioTableAdapter = Me.AssembleaDettaglioTableAdapter
        Me.TableAdapterManager.AssembleaTableAdapter = Me.AssembleaTableAdapter
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
        'AssembleaDettaglioTableAdapter
        '
        Me.AssembleaDettaglioTableAdapter.ClearBeforeFill = True
        '
        'Immobile
        '
        Me.Immobile.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "Immobile", True))
        Me.Immobile.FormattingEnabled = True
        Me.Immobile.Location = New System.Drawing.Point(15, 68)
        Me.Immobile.Name = "Immobile"
        Me.Immobile.Size = New System.Drawing.Size(289, 21)
        Me.Immobile.TabIndex = 42
        '
        'AssembleaDettaglioBindingSource
        '
        Me.AssembleaDettaglioBindingSource.DataMember = "AssembleaDettaglio"
        Me.AssembleaDettaglioBindingSource.DataSource = Me.IMMOBILIDataSet
        '
        'Gestione
        '
        Me.Gestione.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "Gestione", True))
        Me.Gestione.FormattingEnabled = True
        Me.Gestione.Location = New System.Drawing.Point(324, 68)
        Me.Gestione.Name = "Gestione"
        Me.Gestione.Size = New System.Drawing.Size(245, 21)
        Me.Gestione.TabIndex = 43
        '
        'TotaleMillesimi
        '
        Me.TotaleMillesimi.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "TotaleMillesimi", True))
        Me.TotaleMillesimi.Location = New System.Drawing.Point(634, 68)
        Me.TotaleMillesimi.Name = "TotaleMillesimi"
        Me.TotaleMillesimi.Size = New System.Drawing.Size(78, 20)
        Me.TotaleMillesimi.TabIndex = 44
        '
        'TotalePersone
        '
        Me.TotalePersone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "TotalePersone", True))
        Me.TotalePersone.Location = New System.Drawing.Point(731, 68)
        Me.TotalePersone.Name = "TotalePersone"
        Me.TotalePersone.Size = New System.Drawing.Size(79, 20)
        Me.TotalePersone.TabIndex = 45
        '
        '_1Votazione
        '
        Me._1Votazione.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "1Votazione", True))
        Me._1Votazione.Location = New System.Drawing.Point(15, 119)
        Me._1Votazione.Name = "_1Votazione"
        Me._1Votazione.Size = New System.Drawing.Size(147, 20)
        Me._1Votazione.TabIndex = 46
        '
        '_1Risultato
        '
        Me._1Risultato.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "1Risultato", True))
        Me._1Risultato.Location = New System.Drawing.Point(188, 119)
        Me._1Risultato.Name = "_1Risultato"
        Me._1Risultato.Size = New System.Drawing.Size(213, 20)
        Me._1Risultato.TabIndex = 47
        '
        '_2Votazione
        '
        Me._2Votazione.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "2Votazione", True))
        Me._2Votazione.Location = New System.Drawing.Point(15, 144)
        Me._2Votazione.Name = "_2Votazione"
        Me._2Votazione.Size = New System.Drawing.Size(147, 20)
        Me._2Votazione.TabIndex = 48
        '
        '_2Risultato
        '
        Me._2Risultato.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "2Risultato", True))
        Me._2Risultato.Location = New System.Drawing.Point(188, 147)
        Me._2Risultato.Name = "_2Risultato"
        Me._2Risultato.Size = New System.Drawing.Size(213, 20)
        Me._2Risultato.TabIndex = 49
        '
        '_3Votazione
        '
        Me._3Votazione.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "3Votazione", True))
        Me._3Votazione.Location = New System.Drawing.Point(15, 174)
        Me._3Votazione.Name = "_3Votazione"
        Me._3Votazione.Size = New System.Drawing.Size(147, 20)
        Me._3Votazione.TabIndex = 50
        '
        '_3Risultato
        '
        Me._3Risultato.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "3Risultato", True))
        Me._3Risultato.Location = New System.Drawing.Point(188, 175)
        Me._3Risultato.Name = "_3Risultato"
        Me._3Risultato.Size = New System.Drawing.Size(213, 20)
        Me._3Risultato.TabIndex = 51
        '
        '_4Votazione
        '
        Me._4Votazione.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "4Votazione", True))
        Me._4Votazione.Location = New System.Drawing.Point(12, 200)
        Me._4Votazione.Name = "_4Votazione"
        Me._4Votazione.Size = New System.Drawing.Size(150, 20)
        Me._4Votazione.TabIndex = 52
        '
        '_4Risultato
        '
        Me._4Risultato.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "4Risultato", True))
        Me._4Risultato.Location = New System.Drawing.Point(188, 200)
        Me._4Risultato.Name = "_4Risultato"
        Me._4Risultato.Size = New System.Drawing.Size(213, 20)
        Me._4Risultato.TabIndex = 53
        '
        '_5Votazione
        '
        Me._5Votazione.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "5Votazione", True))
        Me._5Votazione.Location = New System.Drawing.Point(15, 229)
        Me._5Votazione.Name = "_5Votazione"
        Me._5Votazione.Size = New System.Drawing.Size(145, 20)
        Me._5Votazione.TabIndex = 54
        '
        '_5Risultato
        '
        Me._5Risultato.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "5Risultato", True))
        Me._5Risultato.Location = New System.Drawing.Point(188, 229)
        Me._5Risultato.Name = "_5Risultato"
        Me._5Risultato.Size = New System.Drawing.Size(213, 20)
        Me._5Risultato.TabIndex = 55
        '
        '_6Votazione
        '
        Me._6Votazione.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "6Votazione", True))
        Me._6Votazione.Location = New System.Drawing.Point(424, 119)
        Me._6Votazione.Name = "_6Votazione"
        Me._6Votazione.Size = New System.Drawing.Size(145, 20)
        Me._6Votazione.TabIndex = 56
        '
        '_6Risultato
        '
        Me._6Risultato.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "6Risultato", True))
        Me._6Risultato.Location = New System.Drawing.Point(592, 119)
        Me._6Risultato.Name = "_6Risultato"
        Me._6Risultato.Size = New System.Drawing.Size(218, 20)
        Me._6Risultato.TabIndex = 57
        '
        '_7Votazione
        '
        Me._7Votazione.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "7Votazione", True))
        Me._7Votazione.Location = New System.Drawing.Point(425, 145)
        Me._7Votazione.Name = "_7Votazione"
        Me._7Votazione.Size = New System.Drawing.Size(145, 20)
        Me._7Votazione.TabIndex = 58
        '
        '_7Risultato
        '
        Me._7Risultato.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "7Risultato", True))
        Me._7Risultato.Location = New System.Drawing.Point(592, 144)
        Me._7Risultato.Name = "_7Risultato"
        Me._7Risultato.Size = New System.Drawing.Size(218, 20)
        Me._7Risultato.TabIndex = 59
        '
        '_8Votazione
        '
        Me._8Votazione.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "8Votazione", True))
        Me._8Votazione.Location = New System.Drawing.Point(424, 175)
        Me._8Votazione.Name = "_8Votazione"
        Me._8Votazione.Size = New System.Drawing.Size(145, 20)
        Me._8Votazione.TabIndex = 60
        '
        '_8Risultato
        '
        Me._8Risultato.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "8Risultato", True))
        Me._8Risultato.Location = New System.Drawing.Point(592, 174)
        Me._8Risultato.Name = "_8Risultato"
        Me._8Risultato.Size = New System.Drawing.Size(218, 20)
        Me._8Risultato.TabIndex = 61
        '
        '_9Votazione
        '
        Me._9Votazione.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "9Votazione", True))
        Me._9Votazione.Location = New System.Drawing.Point(424, 201)
        Me._9Votazione.Name = "_9Votazione"
        Me._9Votazione.Size = New System.Drawing.Size(145, 20)
        Me._9Votazione.TabIndex = 62
        '
        '_9Risultato
        '
        Me._9Risultato.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "9Risultato", True))
        Me._9Risultato.Location = New System.Drawing.Point(592, 200)
        Me._9Risultato.Name = "_9Risultato"
        Me._9Risultato.Size = New System.Drawing.Size(218, 20)
        Me._9Risultato.TabIndex = 63
        '
        'AssembleaDettaglioBindingSource1
        '
        Me.AssembleaDettaglioBindingSource1.DataMember = "AssembleaAssembleaDettaglio"
        Me.AssembleaDettaglioBindingSource1.DataSource = Me.AssembleaBindingSource
        '
        'AssembleaDettaglio
        '
        Me.AssembleaDettaglio.AutoGenerateColumns = False
        Me.AssembleaDettaglio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AssembleaDettaglio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17})
        Me.AssembleaDettaglio.DataSource = Me.AssembleaDettaglioBindingSource1
        Me.AssembleaDettaglio.Location = New System.Drawing.Point(15, 255)
        Me.AssembleaDettaglio.Name = "AssembleaDettaglio"
        Me.AssembleaDettaglio.Size = New System.Drawing.Size(791, 220)
        Me.AssembleaDettaglio.TabIndex = 63
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
        Me.DataGridViewTextBoxColumn4.Width = 60
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
        Me.DataGridViewTextBoxColumn6.Width = 50
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Presenza"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Presenza"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 60
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Delega"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Delega"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 50
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Votazione1"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Votazione1"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 65
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Votazione2"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Votazione2"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 65
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Votazione3"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Votazione3"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 65
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Votazione4"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Votazione4"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 65
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Votazione5"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Votazione5"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 66
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Votazione6"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Votazione6"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 66
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Votazione7"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Votazione7"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 66
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Votazione8"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Votazione8"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Width = 66
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Votazione9"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Votazione9"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Width = 66
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
        Me.AnagraficaStudioBindingNavigator.Size = New System.Drawing.Size(1010, 38)
        Me.AnagraficaStudioBindingNavigator.TabIndex = 64
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
        'Assemblea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 506)
        Me.Controls.Add(Me.AnagraficaStudioBindingNavigator)
        Me.Controls.Add(Me.AssembleaDettaglio)
        Me.Controls.Add(Me._9Risultato)
        Me.Controls.Add(Me._9Votazione)
        Me.Controls.Add(Me._8Risultato)
        Me.Controls.Add(Me._8Votazione)
        Me.Controls.Add(Me._7Risultato)
        Me.Controls.Add(Me._7Votazione)
        Me.Controls.Add(Me._6Risultato)
        Me.Controls.Add(Me._6Votazione)
        Me.Controls.Add(Me._5Risultato)
        Me.Controls.Add(Me._5Votazione)
        Me.Controls.Add(Me._4Risultato)
        Me.Controls.Add(Me._4Votazione)
        Me.Controls.Add(Me._3Risultato)
        Me.Controls.Add(Me._3Votazione)
        Me.Controls.Add(Me._2Risultato)
        Me.Controls.Add(Me._2Votazione)
        Me.Controls.Add(Me._1Risultato)
        Me.Controls.Add(Me._1Votazione)
        Me.Controls.Add(Me.TotalePersone)
        Me.Controls.Add(Me.TotaleMillesimi)
        Me.Controls.Add(Me.Gestione)
        Me.Controls.Add(Me.Immobile)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(_6RisultatoLabel)
        Me.Controls.Add(_6VotazioneLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(_1RisultatoLabel)
        Me.Controls.Add(_1VotazioneLabel)
        Me.Controls.Add(TotalePersoneLabel)
        Me.Controls.Add(TotaleMillesimiLabel)
        Me.Controls.Add(GestioneLabel)
        Me.Controls.Add(ImmobileLabel)
        Me.Name = "Assemblea"
        Me.Text = "Assemblea"
        CType(Me.IMMOBILIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssembleaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssembleaDettaglioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssembleaDettaglioBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssembleaDettaglio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnagraficaStudioBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AnagraficaStudioBindingNavigator.ResumeLayout(False)
        Me.AnagraficaStudioBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents IMMOBILIDataSet As Patrimonio2014.IMMOBILIDataSet
    Friend WithEvents AssembleaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AssembleaTableAdapter As Patrimonio2014.IMMOBILIDataSetTableAdapters.AssembleaTableAdapter
    Friend WithEvents TableAdapterManager As Patrimonio2014.IMMOBILIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AssembleaDettaglioTableAdapter As Patrimonio2014.IMMOBILIDataSetTableAdapters.AssembleaDettaglioTableAdapter
    Friend WithEvents Immobile As System.Windows.Forms.ComboBox
    Friend WithEvents AssembleaDettaglioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Gestione As System.Windows.Forms.ComboBox
    Friend WithEvents TotaleMillesimi As System.Windows.Forms.TextBox
    Friend WithEvents TotalePersone As System.Windows.Forms.TextBox
    Friend WithEvents _1Votazione As System.Windows.Forms.TextBox
    Friend WithEvents _1Risultato As System.Windows.Forms.TextBox
    Friend WithEvents _2Votazione As System.Windows.Forms.TextBox
    Friend WithEvents _2Risultato As System.Windows.Forms.TextBox
    Friend WithEvents _3Votazione As System.Windows.Forms.TextBox
    Friend WithEvents _3Risultato As System.Windows.Forms.TextBox
    Friend WithEvents _4Votazione As System.Windows.Forms.TextBox
    Friend WithEvents _4Risultato As System.Windows.Forms.TextBox
    Friend WithEvents _5Votazione As System.Windows.Forms.TextBox
    Friend WithEvents _5Risultato As System.Windows.Forms.TextBox
    Friend WithEvents _6Votazione As System.Windows.Forms.TextBox
    Friend WithEvents _6Risultato As System.Windows.Forms.TextBox
    Friend WithEvents _7Votazione As System.Windows.Forms.TextBox
    Friend WithEvents _7Risultato As System.Windows.Forms.TextBox
    Friend WithEvents _8Votazione As System.Windows.Forms.TextBox
    Friend WithEvents _8Risultato As System.Windows.Forms.TextBox
    Friend WithEvents _9Votazione As System.Windows.Forms.TextBox
    Friend WithEvents _9Risultato As System.Windows.Forms.TextBox
    Friend WithEvents AssembleaDettaglioBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents AssembleaDettaglio As System.Windows.Forms.DataGridView
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
