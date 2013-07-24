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
        Me.IMMOBILIDataSet = New Patrimonio2014.IMMOBILIDataSet()
        Me.AssembleaDettaglioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AssembleaDettaglioTableAdapter = New Patrimonio2014.IMMOBILIDataSetTableAdapters.AssembleaDettaglioTableAdapter()
        Me.TableAdapterManager = New Patrimonio2014.IMMOBILIDataSetTableAdapters.TableAdapterManager()
        Me.AssembleaDettaglioDataGridView = New System.Windows.Forms.DataGridView()
        Me.AssembleaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AssembleaTableAdapter = New Patrimonio2014.IMMOBILIDataSetTableAdapters.AssembleaTableAdapter()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me._6VotazioneTextBox = New System.Windows.Forms.TextBox()
        Me._6RisultatoTextBox = New System.Windows.Forms.TextBox()
        Me._7VotazioneTextBox = New System.Windows.Forms.TextBox()
        Me._7RisultatoTextBox = New System.Windows.Forms.TextBox()
        Me._8VotazioneTextBox = New System.Windows.Forms.TextBox()
        Me._8RisultatoTextBox = New System.Windows.Forms.TextBox()
        Me._9VotazioneTextBox = New System.Windows.Forms.TextBox()
        Me._9RisultatoTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
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
        _6VotazioneLabel = New System.Windows.Forms.Label()
        _6RisultatoLabel = New System.Windows.Forms.Label()
        CType(Me.IMMOBILIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssembleaDettaglioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssembleaDettaglioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssembleaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'IMMOBILIDataSet
        '
        Me.IMMOBILIDataSet.DataSetName = "IMMOBILIDataSet"
        Me.IMMOBILIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AssembleaDettaglioBindingSource
        '
        Me.AssembleaDettaglioBindingSource.DataMember = "AssembleaDettaglio"
        Me.AssembleaDettaglioBindingSource.DataSource = Me.IMMOBILIDataSet
        '
        'AssembleaDettaglioTableAdapter
        '
        Me.AssembleaDettaglioTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AnagraficaStudioTableAdapter = Nothing
        Me.TableAdapterManager.AnagraficheTableAdapter = Nothing
        Me.TableAdapterManager.AssembleaDettaglioTableAdapter = Me.AssembleaDettaglioTableAdapter
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
        'AssembleaDettaglioDataGridView
        '
        Me.AssembleaDettaglioDataGridView.AutoGenerateColumns = False
        Me.AssembleaDettaglioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AssembleaDettaglioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17})
        Me.AssembleaDettaglioDataGridView.DataSource = Me.AssembleaDettaglioBindingSource
        Me.AssembleaDettaglioDataGridView.Location = New System.Drawing.Point(12, 248)
        Me.AssembleaDettaglioDataGridView.Name = "AssembleaDettaglioDataGridView"
        Me.AssembleaDettaglioDataGridView.Size = New System.Drawing.Size(978, 220)
        Me.AssembleaDettaglioDataGridView.TabIndex = 1
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
        'ImmobileComboBox
        '
        Me.ImmobileComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "Immobile", True))
        Me.ImmobileComboBox.FormattingEnabled = True
        Me.ImmobileComboBox.Location = New System.Drawing.Point(15, 67)
        Me.ImmobileComboBox.Name = "ImmobileComboBox"
        Me.ImmobileComboBox.Size = New System.Drawing.Size(290, 21)
        Me.ImmobileComboBox.TabIndex = 2
        '
        'GestioneComboBox
        '
        Me.GestioneComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "Gestione", True))
        Me.GestioneComboBox.FormattingEnabled = True
        Me.GestioneComboBox.Location = New System.Drawing.Point(324, 67)
        Me.GestioneComboBox.Name = "GestioneComboBox"
        Me.GestioneComboBox.Size = New System.Drawing.Size(293, 21)
        Me.GestioneComboBox.TabIndex = 4
        '
        'TotaleMillesimiTextBox
        '
        Me.TotaleMillesimiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "TotaleMillesimi", True))
        Me.TotaleMillesimiTextBox.Location = New System.Drawing.Point(634, 67)
        Me.TotaleMillesimiTextBox.Name = "TotaleMillesimiTextBox"
        Me.TotaleMillesimiTextBox.Size = New System.Drawing.Size(78, 20)
        Me.TotaleMillesimiTextBox.TabIndex = 6
        '
        'TotalePersoneTextBox
        '
        Me.TotalePersoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "TotalePersone", True))
        Me.TotalePersoneTextBox.Location = New System.Drawing.Point(731, 68)
        Me.TotalePersoneTextBox.Name = "TotalePersoneTextBox"
        Me.TotalePersoneTextBox.Size = New System.Drawing.Size(79, 20)
        Me.TotalePersoneTextBox.TabIndex = 8
        '
        '_1VotazioneTextBox
        '
        Me._1VotazioneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "1Votazione", True))
        Me._1VotazioneTextBox.Location = New System.Drawing.Point(15, 116)
        Me._1VotazioneTextBox.Name = "_1VotazioneTextBox"
        Me._1VotazioneTextBox.Size = New System.Drawing.Size(147, 20)
        Me._1VotazioneTextBox.TabIndex = 10
        '
        '_1RisultatoTextBox
        '
        Me._1RisultatoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "1Risultato", True))
        Me._1RisultatoTextBox.Location = New System.Drawing.Point(185, 116)
        Me._1RisultatoTextBox.Name = "_1RisultatoTextBox"
        Me._1RisultatoTextBox.Size = New System.Drawing.Size(216, 20)
        Me._1RisultatoTextBox.TabIndex = 12
        '
        '_2VotazioneTextBox
        '
        Me._2VotazioneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "2Votazione", True))
        Me._2VotazioneTextBox.Location = New System.Drawing.Point(15, 142)
        Me._2VotazioneTextBox.Name = "_2VotazioneTextBox"
        Me._2VotazioneTextBox.Size = New System.Drawing.Size(147, 20)
        Me._2VotazioneTextBox.TabIndex = 14
        '
        '_2RisultatoTextBox
        '
        Me._2RisultatoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "2Risultato", True))
        Me._2RisultatoTextBox.Location = New System.Drawing.Point(185, 142)
        Me._2RisultatoTextBox.Name = "_2RisultatoTextBox"
        Me._2RisultatoTextBox.Size = New System.Drawing.Size(216, 20)
        Me._2RisultatoTextBox.TabIndex = 15
        '
        '_3VotazioneTextBox
        '
        Me._3VotazioneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "3Votazione", True))
        Me._3VotazioneTextBox.Location = New System.Drawing.Point(15, 168)
        Me._3VotazioneTextBox.Name = "_3VotazioneTextBox"
        Me._3VotazioneTextBox.Size = New System.Drawing.Size(147, 20)
        Me._3VotazioneTextBox.TabIndex = 16
        '
        '_3RisultatoTextBox
        '
        Me._3RisultatoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "3Risultato", True))
        Me._3RisultatoTextBox.Location = New System.Drawing.Point(185, 168)
        Me._3RisultatoTextBox.Name = "_3RisultatoTextBox"
        Me._3RisultatoTextBox.Size = New System.Drawing.Size(216, 20)
        Me._3RisultatoTextBox.TabIndex = 17
        '
        '_4VotazioneTextBox
        '
        Me._4VotazioneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "4Votazione", True))
        Me._4VotazioneTextBox.Location = New System.Drawing.Point(15, 194)
        Me._4VotazioneTextBox.Name = "_4VotazioneTextBox"
        Me._4VotazioneTextBox.Size = New System.Drawing.Size(147, 20)
        Me._4VotazioneTextBox.TabIndex = 18
        '
        '_4RisultatoTextBox
        '
        Me._4RisultatoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "4Risultato", True))
        Me._4RisultatoTextBox.Location = New System.Drawing.Point(185, 194)
        Me._4RisultatoTextBox.Name = "_4RisultatoTextBox"
        Me._4RisultatoTextBox.Size = New System.Drawing.Size(216, 20)
        Me._4RisultatoTextBox.TabIndex = 19
        '
        '_5VotazioneTextBox
        '
        Me._5VotazioneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "5Votazione", True))
        Me._5VotazioneTextBox.Location = New System.Drawing.Point(15, 222)
        Me._5VotazioneTextBox.Name = "_5VotazioneTextBox"
        Me._5VotazioneTextBox.Size = New System.Drawing.Size(147, 20)
        Me._5VotazioneTextBox.TabIndex = 20
        '
        '_5RisultatoTextBox
        '
        Me._5RisultatoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "5Risultato", True))
        Me._5RisultatoTextBox.Location = New System.Drawing.Point(185, 222)
        Me._5RisultatoTextBox.Name = "_5RisultatoTextBox"
        Me._5RisultatoTextBox.Size = New System.Drawing.Size(216, 20)
        Me._5RisultatoTextBox.TabIndex = 21
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
        '_6VotazioneTextBox
        '
        Me._6VotazioneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "6Votazione", True))
        Me._6VotazioneTextBox.Location = New System.Drawing.Point(424, 117)
        Me._6VotazioneTextBox.Name = "_6VotazioneTextBox"
        Me._6VotazioneTextBox.Size = New System.Drawing.Size(145, 20)
        Me._6VotazioneTextBox.TabIndex = 27
        '
        '_6RisultatoTextBox
        '
        Me._6RisultatoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "6Risultato", True))
        Me._6RisultatoTextBox.Location = New System.Drawing.Point(592, 117)
        Me._6RisultatoTextBox.Name = "_6RisultatoTextBox"
        Me._6RisultatoTextBox.Size = New System.Drawing.Size(218, 20)
        Me._6RisultatoTextBox.TabIndex = 29
        '
        '_7VotazioneTextBox
        '
        Me._7VotazioneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "7Votazione", True))
        Me._7VotazioneTextBox.Location = New System.Drawing.Point(424, 143)
        Me._7VotazioneTextBox.Name = "_7VotazioneTextBox"
        Me._7VotazioneTextBox.Size = New System.Drawing.Size(145, 20)
        Me._7VotazioneTextBox.TabIndex = 31
        '
        '_7RisultatoTextBox
        '
        Me._7RisultatoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "7Risultato", True))
        Me._7RisultatoTextBox.Location = New System.Drawing.Point(592, 145)
        Me._7RisultatoTextBox.Name = "_7RisultatoTextBox"
        Me._7RisultatoTextBox.Size = New System.Drawing.Size(218, 20)
        Me._7RisultatoTextBox.TabIndex = 32
        '
        '_8VotazioneTextBox
        '
        Me._8VotazioneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "8Votazione", True))
        Me._8VotazioneTextBox.Location = New System.Drawing.Point(424, 171)
        Me._8VotazioneTextBox.Name = "_8VotazioneTextBox"
        Me._8VotazioneTextBox.Size = New System.Drawing.Size(145, 20)
        Me._8VotazioneTextBox.TabIndex = 33
        '
        '_8RisultatoTextBox
        '
        Me._8RisultatoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "8Risultato", True))
        Me._8RisultatoTextBox.Location = New System.Drawing.Point(592, 171)
        Me._8RisultatoTextBox.Name = "_8RisultatoTextBox"
        Me._8RisultatoTextBox.Size = New System.Drawing.Size(218, 20)
        Me._8RisultatoTextBox.TabIndex = 34
        '
        '_9VotazioneTextBox
        '
        Me._9VotazioneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "9Votazione", True))
        Me._9VotazioneTextBox.Location = New System.Drawing.Point(424, 197)
        Me._9VotazioneTextBox.Name = "_9VotazioneTextBox"
        Me._9VotazioneTextBox.Size = New System.Drawing.Size(145, 20)
        Me._9VotazioneTextBox.TabIndex = 35
        '
        '_9RisultatoTextBox
        '
        Me._9RisultatoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssembleaBindingSource, "9Risultato", True))
        Me._9RisultatoTextBox.Location = New System.Drawing.Point(592, 197)
        Me._9RisultatoTextBox.Name = "_9RisultatoTextBox"
        Me._9RisultatoTextBox.Size = New System.Drawing.Size(218, 20)
        Me._9RisultatoTextBox.TabIndex = 36
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
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Progressivo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Numero"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 50
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
        Me.DataGridViewTextBoxColumn6.Width = 50
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Presenza"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Presenza"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 30
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
        Me.DataGridViewTextBoxColumn9.HeaderText = "1"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 30
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Votazione2"
        Me.DataGridViewTextBoxColumn10.HeaderText = "2"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 30
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Votazione3"
        Me.DataGridViewTextBoxColumn11.HeaderText = "3"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 30
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Votazione4"
        Me.DataGridViewTextBoxColumn12.HeaderText = "4"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 30
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Votazione5"
        Me.DataGridViewTextBoxColumn13.HeaderText = "5"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 30
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Votazione6"
        Me.DataGridViewTextBoxColumn14.HeaderText = "6"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 30
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Votazione7"
        Me.DataGridViewTextBoxColumn15.HeaderText = "7"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 30
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Votazione8"
        Me.DataGridViewTextBoxColumn16.HeaderText = "8"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Width = 30
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Votazione9"
        Me.DataGridViewTextBoxColumn17.HeaderText = "9"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Width = 30
        '
        'Assemblea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 488)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me._9RisultatoTextBox)
        Me.Controls.Add(Me._9VotazioneTextBox)
        Me.Controls.Add(Me._8RisultatoTextBox)
        Me.Controls.Add(Me._8VotazioneTextBox)
        Me.Controls.Add(Me._7RisultatoTextBox)
        Me.Controls.Add(Me._7VotazioneTextBox)
        Me.Controls.Add(_6RisultatoLabel)
        Me.Controls.Add(Me._6RisultatoTextBox)
        Me.Controls.Add(_6VotazioneLabel)
        Me.Controls.Add(Me._6VotazioneTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
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
        Me.Controls.Add(Me.AssembleaDettaglioDataGridView)
        Me.Name = "Assemblea"
        Me.Text = "Assemblea"
        CType(Me.IMMOBILIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssembleaDettaglioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssembleaDettaglioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssembleaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IMMOBILIDataSet As Patrimonio2014.IMMOBILIDataSet
    Friend WithEvents AssembleaDettaglioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AssembleaDettaglioTableAdapter As Patrimonio2014.IMMOBILIDataSetTableAdapters.AssembleaDettaglioTableAdapter
    Friend WithEvents TableAdapterManager As Patrimonio2014.IMMOBILIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AssembleaDettaglioDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents AssembleaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AssembleaTableAdapter As Patrimonio2014.IMMOBILIDataSetTableAdapters.AssembleaTableAdapter
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents _6VotazioneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents _6RisultatoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents _7VotazioneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents _7RisultatoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents _8VotazioneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents _8RisultatoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents _9VotazioneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents _9RisultatoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
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
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
