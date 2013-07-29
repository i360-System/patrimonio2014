<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class W_Tributi
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
        Dim TributoLabel As System.Windows.Forms.Label
        Dim DescrizioneLabel As System.Windows.Forms.Label
        Dim CodiceTributoLabel As System.Windows.Forms.Label
        Dim CausaleLabel As System.Windows.Forms.Label
        Dim PercentoPrevidenzaLabel As System.Windows.Forms.Label
        Dim PercentoIvaLabel As System.Windows.Forms.Label
        Dim PercentoRitenutaAccontoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(W_Tributi))
        Dim PrevidenzaSoggettaLabel As System.Windows.Forms.Label
        Me.IMMOBILIDataSet = New Patrimonio2014.IMMOBILIDataSet()
        Me.W_TributiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.W_TributiTableAdapter = New Patrimonio2014.IMMOBILIDataSetTableAdapters.W_TributiTableAdapter()
        Me.TableAdapterManager = New Patrimonio2014.IMMOBILIDataSetTableAdapters.TableAdapterManager()
        Me.W_TributiBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.W_TributiBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TributoTextBox = New System.Windows.Forms.TextBox()
        Me.DescrizioneTextBox = New System.Windows.Forms.TextBox()
        Me.CodiceTributoTextBox = New System.Windows.Forms.TextBox()
        Me.CausaleTextBox = New System.Windows.Forms.TextBox()
        Me.PercentoPrevidenzaTextBox = New System.Windows.Forms.TextBox()
        Me.PercentoIvaTextBox = New System.Windows.Forms.TextBox()
        Me.PercentoRitenutaAccontoTextBox = New System.Windows.Forms.TextBox()
        Me.PrevidenzaSoggettaTextBox = New System.Windows.Forms.TextBox()
        TributoLabel = New System.Windows.Forms.Label()
        DescrizioneLabel = New System.Windows.Forms.Label()
        CodiceTributoLabel = New System.Windows.Forms.Label()
        CausaleLabel = New System.Windows.Forms.Label()
        PercentoPrevidenzaLabel = New System.Windows.Forms.Label()
        PercentoIvaLabel = New System.Windows.Forms.Label()
        PercentoRitenutaAccontoLabel = New System.Windows.Forms.Label()
        PrevidenzaSoggettaLabel = New System.Windows.Forms.Label()
        CType(Me.IMMOBILIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.W_TributiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.W_TributiBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.W_TributiBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'TributoLabel
        '
        TributoLabel.AutoSize = True
        TributoLabel.Location = New System.Drawing.Point(12, 51)
        TributoLabel.Name = "TributoLabel"
        TributoLabel.Size = New System.Drawing.Size(57, 13)
        TributoLabel.TabIndex = 1
        TributoLabel.Text = "N. Tributo:"
        '
        'DescrizioneLabel
        '
        DescrizioneLabel.AutoSize = True
        DescrizioneLabel.Location = New System.Drawing.Point(88, 51)
        DescrizioneLabel.Name = "DescrizioneLabel"
        DescrizioneLabel.Size = New System.Drawing.Size(65, 13)
        DescrizioneLabel.TabIndex = 2
        DescrizioneLabel.Text = "Descrizione:"
        '
        'CodiceTributoLabel
        '
        CodiceTributoLabel.AutoSize = True
        CodiceTributoLabel.Location = New System.Drawing.Point(371, 51)
        CodiceTributoLabel.Name = "CodiceTributoLabel"
        CodiceTributoLabel.Size = New System.Drawing.Size(79, 13)
        CodiceTributoLabel.TabIndex = 4
        CodiceTributoLabel.Text = "Codice Tributo:"
        '
        'CausaleLabel
        '
        CausaleLabel.AutoSize = True
        CausaleLabel.Location = New System.Drawing.Point(456, 51)
        CausaleLabel.Name = "CausaleLabel"
        CausaleLabel.Size = New System.Drawing.Size(48, 13)
        CausaleLabel.TabIndex = 6
        CausaleLabel.Text = "Causale:"
        '
        'PercentoPrevidenzaLabel
        '
        PercentoPrevidenzaLabel.AutoSize = True
        PercentoPrevidenzaLabel.Location = New System.Drawing.Point(88, 90)
        PercentoPrevidenzaLabel.Name = "PercentoPrevidenzaLabel"
        PercentoPrevidenzaLabel.Size = New System.Drawing.Size(74, 13)
        PercentoPrevidenzaLabel.TabIndex = 8
        PercentoPrevidenzaLabel.Text = "% Previdenza:"
        '
        'PercentoIvaLabel
        '
        PercentoIvaLabel.AutoSize = True
        PercentoIvaLabel.Location = New System.Drawing.Point(168, 90)
        PercentoIvaLabel.Name = "PercentoIvaLabel"
        PercentoIvaLabel.Size = New System.Drawing.Size(36, 13)
        PercentoIvaLabel.TabIndex = 10
        PercentoIvaLabel.Text = "% Iva:"
        '
        'PercentoRitenutaAccontoLabel
        '
        PercentoRitenutaAccontoLabel.AutoSize = True
        PercentoRitenutaAccontoLabel.Location = New System.Drawing.Point(245, 90)
        PercentoRitenutaAccontoLabel.Name = "PercentoRitenutaAccontoLabel"
        PercentoRitenutaAccontoLabel.Size = New System.Drawing.Size(80, 13)
        PercentoRitenutaAccontoLabel.TabIndex = 12
        PercentoRitenutaAccontoLabel.Text = "% Rit. Acconto:"
        '
        'IMMOBILIDataSet
        '
        Me.IMMOBILIDataSet.DataSetName = "IMMOBILIDataSet"
        Me.IMMOBILIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'W_TributiBindingSource
        '
        Me.W_TributiBindingSource.DataMember = "W_Tributi"
        Me.W_TributiBindingSource.DataSource = Me.IMMOBILIDataSet
        '
        'W_TributiTableAdapter
        '
        Me.W_TributiTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AnagraficaStudioTableAdapter = Nothing
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
        Me.TableAdapterManager.W_TributiTableAdapter = Me.W_TributiTableAdapter
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
        'W_TributiBindingNavigator
        '
        Me.W_TributiBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.W_TributiBindingNavigator.BindingSource = Me.W_TributiBindingSource
        Me.W_TributiBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.W_TributiBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.W_TributiBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.W_TributiBindingNavigatorSaveItem})
        Me.W_TributiBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.W_TributiBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.W_TributiBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.W_TributiBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.W_TributiBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.W_TributiBindingNavigator.Name = "W_TributiBindingNavigator"
        Me.W_TributiBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.W_TributiBindingNavigator.Size = New System.Drawing.Size(684, 25)
        Me.W_TributiBindingNavigator.TabIndex = 16
        Me.W_TributiBindingNavigator.Text = "BindingNavigator1"
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
        'W_TributiBindingNavigatorSaveItem
        '
        Me.W_TributiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.W_TributiBindingNavigatorSaveItem.Image = CType(resources.GetObject("W_TributiBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.W_TributiBindingNavigatorSaveItem.Name = "W_TributiBindingNavigatorSaveItem"
        Me.W_TributiBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.W_TributiBindingNavigatorSaveItem.Text = "Salva dati"
        '
        'TributoTextBox
        '
        Me.TributoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_TributiBindingSource, "Tributo", True))
        Me.TributoTextBox.Location = New System.Drawing.Point(15, 66)
        Me.TributoTextBox.Name = "TributoTextBox"
        Me.TributoTextBox.Size = New System.Drawing.Size(70, 20)
        Me.TributoTextBox.TabIndex = 17
        '
        'DescrizioneTextBox
        '
        Me.DescrizioneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_TributiBindingSource, "Descrizione", True))
        Me.DescrizioneTextBox.Location = New System.Drawing.Point(91, 65)
        Me.DescrizioneTextBox.Name = "DescrizioneTextBox"
        Me.DescrizioneTextBox.Size = New System.Drawing.Size(277, 20)
        Me.DescrizioneTextBox.TabIndex = 18
        '
        'CodiceTributoTextBox
        '
        Me.CodiceTributoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_TributiBindingSource, "CodiceTributo", True))
        Me.CodiceTributoTextBox.Location = New System.Drawing.Point(374, 65)
        Me.CodiceTributoTextBox.Name = "CodiceTributoTextBox"
        Me.CodiceTributoTextBox.Size = New System.Drawing.Size(76, 20)
        Me.CodiceTributoTextBox.TabIndex = 19
        '
        'CausaleTextBox
        '
        Me.CausaleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_TributiBindingSource, "Causale", True))
        Me.CausaleTextBox.Location = New System.Drawing.Point(459, 65)
        Me.CausaleTextBox.Name = "CausaleTextBox"
        Me.CausaleTextBox.Size = New System.Drawing.Size(205, 20)
        Me.CausaleTextBox.TabIndex = 20
        '
        'PercentoPrevidenzaTextBox
        '
        Me.PercentoPrevidenzaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_TributiBindingSource, "PercentoPrevidenza", True))
        Me.PercentoPrevidenzaTextBox.Location = New System.Drawing.Point(91, 106)
        Me.PercentoPrevidenzaTextBox.Name = "PercentoPrevidenzaTextBox"
        Me.PercentoPrevidenzaTextBox.Size = New System.Drawing.Size(74, 20)
        Me.PercentoPrevidenzaTextBox.TabIndex = 21
        '
        'PercentoIvaTextBox
        '
        Me.PercentoIvaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_TributiBindingSource, "PercentoIva", True))
        Me.PercentoIvaTextBox.Location = New System.Drawing.Point(171, 106)
        Me.PercentoIvaTextBox.Name = "PercentoIvaTextBox"
        Me.PercentoIvaTextBox.Size = New System.Drawing.Size(71, 20)
        Me.PercentoIvaTextBox.TabIndex = 22
        '
        'PercentoRitenutaAccontoTextBox
        '
        Me.PercentoRitenutaAccontoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_TributiBindingSource, "PercentoRitenutaAcconto", True))
        Me.PercentoRitenutaAccontoTextBox.Location = New System.Drawing.Point(248, 106)
        Me.PercentoRitenutaAccontoTextBox.Name = "PercentoRitenutaAccontoTextBox"
        Me.PercentoRitenutaAccontoTextBox.Size = New System.Drawing.Size(80, 20)
        Me.PercentoRitenutaAccontoTextBox.TabIndex = 23
        '
        'PrevidenzaSoggettaLabel
        '
        PrevidenzaSoggettaLabel.AutoSize = True
        PrevidenzaSoggettaLabel.Location = New System.Drawing.Point(331, 90)
        PrevidenzaSoggettaLabel.Name = "PrevidenzaSoggettaLabel"
        PrevidenzaSoggettaLabel.Size = New System.Drawing.Size(109, 13)
        PrevidenzaSoggettaLabel.TabIndex = 23
        PrevidenzaSoggettaLabel.Text = "Previdenza Soggetta:"
        '
        'PrevidenzaSoggettaTextBox
        '
        Me.PrevidenzaSoggettaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.W_TributiBindingSource, "PrevidenzaSoggetta", True))
        Me.PrevidenzaSoggettaTextBox.Location = New System.Drawing.Point(361, 106)
        Me.PrevidenzaSoggettaTextBox.Name = "PrevidenzaSoggettaTextBox"
        Me.PrevidenzaSoggettaTextBox.Size = New System.Drawing.Size(31, 20)
        Me.PrevidenzaSoggettaTextBox.TabIndex = 24
        '
        'W_Tributi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 177)
        Me.Controls.Add(PrevidenzaSoggettaLabel)
        Me.Controls.Add(Me.PrevidenzaSoggettaTextBox)
        Me.Controls.Add(Me.PercentoRitenutaAccontoTextBox)
        Me.Controls.Add(Me.PercentoIvaTextBox)
        Me.Controls.Add(Me.PercentoPrevidenzaTextBox)
        Me.Controls.Add(Me.CausaleTextBox)
        Me.Controls.Add(Me.CodiceTributoTextBox)
        Me.Controls.Add(Me.DescrizioneTextBox)
        Me.Controls.Add(Me.TributoTextBox)
        Me.Controls.Add(Me.W_TributiBindingNavigator)
        Me.Controls.Add(PercentoRitenutaAccontoLabel)
        Me.Controls.Add(PercentoIvaLabel)
        Me.Controls.Add(PercentoPrevidenzaLabel)
        Me.Controls.Add(CausaleLabel)
        Me.Controls.Add(CodiceTributoLabel)
        Me.Controls.Add(DescrizioneLabel)
        Me.Controls.Add(TributoLabel)
        Me.Name = "W_Tributi"
        Me.Text = "Tabella Tributi"
        CType(Me.IMMOBILIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.W_TributiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.W_TributiBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.W_TributiBindingNavigator.ResumeLayout(False)
        Me.W_TributiBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IMMOBILIDataSet As Patrimonio2014.IMMOBILIDataSet
    Friend WithEvents W_TributiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents W_TributiTableAdapter As Patrimonio2014.IMMOBILIDataSetTableAdapters.W_TributiTableAdapter
    Friend WithEvents TableAdapterManager As Patrimonio2014.IMMOBILIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents W_TributiBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents W_TributiBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TributoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescrizioneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CodiceTributoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CausaleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PercentoPrevidenzaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PercentoIvaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PercentoRitenutaAccontoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrevidenzaSoggettaTextBox As System.Windows.Forms.TextBox
End Class
