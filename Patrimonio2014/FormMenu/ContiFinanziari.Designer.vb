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
        Me.IMMOBILIDataSet2 = New Patrimonio2014.IMMOBILIDataSet2()
        Me.ContiFinanziariBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContiFinanziariTableAdapter = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.ContiFinanziariTableAdapter()
        Me.TableAdapterManager = New Patrimonio2014.IMMOBILIDataSet2TableAdapters.TableAdapterManager()
        Me.ContiFinanziariBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ContiFinanziariBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ImmobileComboBox = New System.Windows.Forms.ComboBox()
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
        CType(Me.IMMOBILIDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContiFinanziariBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContiFinanziariBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContiFinanziariBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImmobileLabel
        '
        ImmobileLabel.AutoSize = True
        ImmobileLabel.Location = New System.Drawing.Point(12, 45)
        ImmobileLabel.Name = "ImmobileLabel"
        ImmobileLabel.Size = New System.Drawing.Size(51, 13)
        ImmobileLabel.TabIndex = 1
        ImmobileLabel.Text = "Immobile:"
        '
        'ContoLabel
        '
        ContoLabel.AutoSize = True
        ContoLabel.Location = New System.Drawing.Point(346, 45)
        ContoLabel.Name = "ContoLabel"
        ContoLabel.Size = New System.Drawing.Size(38, 13)
        ContoLabel.TabIndex = 3
        ContoLabel.Text = "Conto:"
        '
        'BancaLabel
        '
        BancaLabel.AutoSize = True
        BancaLabel.Location = New System.Drawing.Point(12, 85)
        BancaLabel.Name = "BancaLabel"
        BancaLabel.Size = New System.Drawing.Size(41, 13)
        BancaLabel.TabIndex = 5
        BancaLabel.Text = "Banca:"
        '
        'AgenziaLabel
        '
        AgenziaLabel.AutoSize = True
        AgenziaLabel.Location = New System.Drawing.Point(351, 85)
        AgenziaLabel.Name = "AgenziaLabel"
        AgenziaLabel.Size = New System.Drawing.Size(48, 13)
        AgenziaLabel.TabIndex = 7
        AgenziaLabel.Text = "Agenzia:"
        '
        'IndirizzoLabel
        '
        IndirizzoLabel.AutoSize = True
        IndirizzoLabel.Location = New System.Drawing.Point(15, 124)
        IndirizzoLabel.Name = "IndirizzoLabel"
        IndirizzoLabel.Size = New System.Drawing.Size(48, 13)
        IndirizzoLabel.TabIndex = 9
        IndirizzoLabel.Text = "Indirizzo:"
        '
        'LocalitaLabel
        '
        LocalitaLabel.AutoSize = True
        LocalitaLabel.Location = New System.Drawing.Point(16, 163)
        LocalitaLabel.Name = "LocalitaLabel"
        LocalitaLabel.Size = New System.Drawing.Size(47, 13)
        LocalitaLabel.TabIndex = 11
        LocalitaLabel.Text = "Localita:"
        '
        'Intestatario1Label
        '
        Intestatario1Label.AutoSize = True
        Intestatario1Label.Location = New System.Drawing.Point(15, 202)
        Intestatario1Label.Name = "Intestatario1Label"
        Intestatario1Label.Size = New System.Drawing.Size(62, 13)
        Intestatario1Label.TabIndex = 13
        Intestatario1Label.Text = "Intestatario:"
        '
        'ContoCorrenteLabel
        '
        ContoCorrenteLabel.AutoSize = True
        ContoCorrenteLabel.Location = New System.Drawing.Point(351, 225)
        ContoCorrenteLabel.Name = "ContoCorrenteLabel"
        ContoCorrenteLabel.Size = New System.Drawing.Size(81, 13)
        ContoCorrenteLabel.TabIndex = 16
        ContoCorrenteLabel.Text = "Conto Corrente:"
        '
        'IBANLabel
        '
        IBANLabel.AutoSize = True
        IBANLabel.Location = New System.Drawing.Point(530, 225)
        IBANLabel.Name = "IBANLabel"
        IBANLabel.Size = New System.Drawing.Size(35, 13)
        IBANLabel.TabIndex = 18
        IBANLabel.Text = "IBAN:"
        '
        'IMMOBILIDataSet2
        '
        Me.IMMOBILIDataSet2.DataSetName = "IMMOBILIDataSet2"
        Me.IMMOBILIDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ContiFinanziariBindingSource
        '
        Me.ContiFinanziariBindingSource.DataMember = "ContiFinanziari"
        Me.ContiFinanziariBindingSource.DataSource = Me.IMMOBILIDataSet2
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
        Me.TableAdapterManager.CassaTableAdapter = Nothing
        Me.TableAdapterManager.ContiFinanziariTableAdapter = Me.ContiFinanziariTableAdapter
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
        Me.ContiFinanziariBindingNavigator.Size = New System.Drawing.Size(817, 25)
        Me.ContiFinanziariBindingNavigator.TabIndex = 0
        Me.ContiFinanziariBindingNavigator.Text = "BindingNavigator1"
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
        'ContiFinanziariBindingNavigatorSaveItem
        '
        Me.ContiFinanziariBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ContiFinanziariBindingNavigatorSaveItem.Image = CType(resources.GetObject("ContiFinanziariBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ContiFinanziariBindingNavigatorSaveItem.Name = "ContiFinanziariBindingNavigatorSaveItem"
        Me.ContiFinanziariBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ContiFinanziariBindingNavigatorSaveItem.Text = "Salva dati"
        '
        'ImmobileComboBox
        '
        Me.ImmobileComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContiFinanziariBindingSource, "Immobile", True))
        Me.ImmobileComboBox.FormattingEnabled = True
        Me.ImmobileComboBox.Location = New System.Drawing.Point(15, 61)
        Me.ImmobileComboBox.Name = "ImmobileComboBox"
        Me.ImmobileComboBox.Size = New System.Drawing.Size(325, 21)
        Me.ImmobileComboBox.TabIndex = 2
        '
        'ContoTextBox
        '
        Me.ContoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContiFinanziariBindingSource, "Conto", True))
        Me.ContoTextBox.Location = New System.Drawing.Point(349, 62)
        Me.ContoTextBox.Name = "ContoTextBox"
        Me.ContoTextBox.Size = New System.Drawing.Size(50, 20)
        Me.ContoTextBox.TabIndex = 4
        '
        'BancaTextBox
        '
        Me.BancaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContiFinanziariBindingSource, "Banca", True))
        Me.BancaTextBox.Location = New System.Drawing.Point(15, 101)
        Me.BancaTextBox.Name = "BancaTextBox"
        Me.BancaTextBox.Size = New System.Drawing.Size(325, 20)
        Me.BancaTextBox.TabIndex = 6
        '
        'AgenziaTextBox
        '
        Me.AgenziaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContiFinanziariBindingSource, "Agenzia", True))
        Me.AgenziaTextBox.Location = New System.Drawing.Point(349, 101)
        Me.AgenziaTextBox.Name = "AgenziaTextBox"
        Me.AgenziaTextBox.Size = New System.Drawing.Size(270, 20)
        Me.AgenziaTextBox.TabIndex = 8
        '
        'IndirizzoTextBox
        '
        Me.IndirizzoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContiFinanziariBindingSource, "Indirizzo", True))
        Me.IndirizzoTextBox.Location = New System.Drawing.Point(18, 140)
        Me.IndirizzoTextBox.Name = "IndirizzoTextBox"
        Me.IndirizzoTextBox.Size = New System.Drawing.Size(322, 20)
        Me.IndirizzoTextBox.TabIndex = 10
        '
        'LocalitaTextBox
        '
        Me.LocalitaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContiFinanziariBindingSource, "Localita", True))
        Me.LocalitaTextBox.Location = New System.Drawing.Point(19, 179)
        Me.LocalitaTextBox.Name = "LocalitaTextBox"
        Me.LocalitaTextBox.Size = New System.Drawing.Size(321, 20)
        Me.LocalitaTextBox.TabIndex = 12
        '
        'Intestatario1TextBox
        '
        Me.Intestatario1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContiFinanziariBindingSource, "Intestatario1", True))
        Me.Intestatario1TextBox.Location = New System.Drawing.Point(19, 218)
        Me.Intestatario1TextBox.Name = "Intestatario1TextBox"
        Me.Intestatario1TextBox.Size = New System.Drawing.Size(321, 20)
        Me.Intestatario1TextBox.TabIndex = 14
        '
        'Intestatario2TextBox
        '
        Me.Intestatario2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContiFinanziariBindingSource, "Intestatario2", True))
        Me.Intestatario2TextBox.Location = New System.Drawing.Point(19, 244)
        Me.Intestatario2TextBox.Name = "Intestatario2TextBox"
        Me.Intestatario2TextBox.Size = New System.Drawing.Size(321, 20)
        Me.Intestatario2TextBox.TabIndex = 16
        '
        'ContoCorrenteTextBox
        '
        Me.ContoCorrenteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContiFinanziariBindingSource, "ContoCorrente", True))
        Me.ContoCorrenteTextBox.Location = New System.Drawing.Point(354, 244)
        Me.ContoCorrenteTextBox.Name = "ContoCorrenteTextBox"
        Me.ContoCorrenteTextBox.Size = New System.Drawing.Size(171, 20)
        Me.ContoCorrenteTextBox.TabIndex = 17
        '
        'IBANTextBox
        '
        Me.IBANTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContiFinanziariBindingSource, "IBAN", True))
        Me.IBANTextBox.Location = New System.Drawing.Point(533, 244)
        Me.IBANTextBox.Name = "IBANTextBox"
        Me.IBANTextBox.Size = New System.Drawing.Size(260, 20)
        Me.IBANTextBox.TabIndex = 19
        '
        'ContiFinanziari
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 287)
        Me.Controls.Add(IBANLabel)
        Me.Controls.Add(Me.IBANTextBox)
        Me.Controls.Add(ContoCorrenteLabel)
        Me.Controls.Add(Me.ContoCorrenteTextBox)
        Me.Controls.Add(Me.Intestatario2TextBox)
        Me.Controls.Add(Intestatario1Label)
        Me.Controls.Add(Me.Intestatario1TextBox)
        Me.Controls.Add(LocalitaLabel)
        Me.Controls.Add(Me.LocalitaTextBox)
        Me.Controls.Add(IndirizzoLabel)
        Me.Controls.Add(Me.IndirizzoTextBox)
        Me.Controls.Add(AgenziaLabel)
        Me.Controls.Add(Me.AgenziaTextBox)
        Me.Controls.Add(BancaLabel)
        Me.Controls.Add(Me.BancaTextBox)
        Me.Controls.Add(ContoLabel)
        Me.Controls.Add(Me.ContoTextBox)
        Me.Controls.Add(ImmobileLabel)
        Me.Controls.Add(Me.ImmobileComboBox)
        Me.Controls.Add(Me.ContiFinanziariBindingNavigator)
        Me.Name = "ContiFinanziari"
        Me.Text = "Conti Finanziari"
        CType(Me.IMMOBILIDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContiFinanziariBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContiFinanziariBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContiFinanziariBindingNavigator.ResumeLayout(False)
        Me.ContiFinanziariBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IMMOBILIDataSet2 As Patrimonio2014.IMMOBILIDataSet2
    Friend WithEvents ContiFinanziariBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ContiFinanziariTableAdapter As Patrimonio2014.IMMOBILIDataSet2TableAdapters.ContiFinanziariTableAdapter
    Friend WithEvents TableAdapterManager As Patrimonio2014.IMMOBILIDataSet2TableAdapters.TableAdapterManager
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
    Friend WithEvents ImmobileComboBox As System.Windows.Forms.ComboBox
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
