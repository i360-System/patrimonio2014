<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class X_MovimentiFinanziari
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
        Dim ProgressivoLabel As System.Windows.Forms.Label
        Dim ContoLabel As System.Windows.Forms.Label
        Dim ImmobileLabel As System.Windows.Forms.Label
        Dim DataMovimentoLabel As System.Windows.Forms.Label
        Dim OperazioneLabel As System.Windows.Forms.Label
        Dim DataRiferimentoLabel As System.Windows.Forms.Label
        Dim ImportoLabel As System.Windows.Forms.Label
        Dim DescrizioneLabel As System.Windows.Forms.Label
        Dim MarkerLabel As System.Windows.Forms.Label
        Me.IMMOBILIDataSet = New Patrimonio2014.IMMOBILIDataSet()
        Me.X_MovimentiFinanziariBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.X_MovimentiFinanziariTableAdapter = New Patrimonio2014.IMMOBILIDataSetTableAdapters.X_MovimentiFinanziariTableAdapter()
        Me.TableAdapterManager = New Patrimonio2014.IMMOBILIDataSetTableAdapters.TableAdapterManager()
        Me.ProgressivoTextBox = New System.Windows.Forms.TextBox()
        Me.ContoComboBox = New System.Windows.Forms.ComboBox()
        Me.ImmobileComboBox = New System.Windows.Forms.ComboBox()
        Me.DataMovimentoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.OperazioneTextBox = New System.Windows.Forms.TextBox()
        Me.DataRiferimentoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ImportoTextBox = New System.Windows.Forms.TextBox()
        Me.DescrizioneTextBox = New System.Windows.Forms.TextBox()
        Me.MarkerTextBox = New System.Windows.Forms.TextBox()
        ProgressivoLabel = New System.Windows.Forms.Label()
        ContoLabel = New System.Windows.Forms.Label()
        ImmobileLabel = New System.Windows.Forms.Label()
        DataMovimentoLabel = New System.Windows.Forms.Label()
        OperazioneLabel = New System.Windows.Forms.Label()
        DataRiferimentoLabel = New System.Windows.Forms.Label()
        ImportoLabel = New System.Windows.Forms.Label()
        DescrizioneLabel = New System.Windows.Forms.Label()
        MarkerLabel = New System.Windows.Forms.Label()
        CType(Me.IMMOBILIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X_MovimentiFinanziariBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgressivoLabel
        '
        ProgressivoLabel.AutoSize = True
        ProgressivoLabel.Location = New System.Drawing.Point(12, 71)
        ProgressivoLabel.Name = "ProgressivoLabel"
        ProgressivoLabel.Size = New System.Drawing.Size(65, 13)
        ProgressivoLabel.TabIndex = 1
        ProgressivoLabel.Text = "Progressivo:"
        '
        'ContoLabel
        '
        ContoLabel.AutoSize = True
        ContoLabel.Location = New System.Drawing.Point(117, 71)
        ContoLabel.Name = "ContoLabel"
        ContoLabel.Size = New System.Drawing.Size(38, 13)
        ContoLabel.TabIndex = 2
        ContoLabel.Text = "Conto:"
        '
        'ImmobileLabel
        '
        ImmobileLabel.AutoSize = True
        ImmobileLabel.Location = New System.Drawing.Point(373, 71)
        ImmobileLabel.Name = "ImmobileLabel"
        ImmobileLabel.Size = New System.Drawing.Size(51, 13)
        ImmobileLabel.TabIndex = 4
        ImmobileLabel.Text = "Immobile:"
        '
        'DataMovimentoLabel
        '
        DataMovimentoLabel.AutoSize = True
        DataMovimentoLabel.Location = New System.Drawing.Point(12, 119)
        DataMovimentoLabel.Name = "DataMovimentoLabel"
        DataMovimentoLabel.Size = New System.Drawing.Size(88, 13)
        DataMovimentoLabel.TabIndex = 6
        DataMovimentoLabel.Text = "Data Movimento:"
        '
        'OperazioneLabel
        '
        OperazioneLabel.AutoSize = True
        OperazioneLabel.Location = New System.Drawing.Point(115, 119)
        OperazioneLabel.Name = "OperazioneLabel"
        OperazioneLabel.Size = New System.Drawing.Size(64, 13)
        OperazioneLabel.TabIndex = 8
        OperazioneLabel.Text = "Operazione:"
        '
        'DataRiferimentoLabel
        '
        DataRiferimentoLabel.AutoSize = True
        DataRiferimentoLabel.Location = New System.Drawing.Point(373, 119)
        DataRiferimentoLabel.Name = "DataRiferimentoLabel"
        DataRiferimentoLabel.Size = New System.Drawing.Size(89, 13)
        DataRiferimentoLabel.TabIndex = 10
        DataRiferimentoLabel.Text = "Data Riferimento:"
        '
        'ImportoLabel
        '
        ImportoLabel.AutoSize = True
        ImportoLabel.Location = New System.Drawing.Point(487, 119)
        ImportoLabel.Name = "ImportoLabel"
        ImportoLabel.Size = New System.Drawing.Size(45, 13)
        ImportoLabel.TabIndex = 12
        ImportoLabel.Text = "Importo:"
        '
        'DescrizioneLabel
        '
        DescrizioneLabel.AutoSize = True
        DescrizioneLabel.Location = New System.Drawing.Point(171, 119)
        DescrizioneLabel.Name = "DescrizioneLabel"
        DescrizioneLabel.Size = New System.Drawing.Size(65, 13)
        DescrizioneLabel.TabIndex = 14
        DescrizioneLabel.Text = "Descrizione:"
        '
        'MarkerLabel
        '
        MarkerLabel.AutoSize = True
        MarkerLabel.Location = New System.Drawing.Point(590, 119)
        MarkerLabel.Name = "MarkerLabel"
        MarkerLabel.Size = New System.Drawing.Size(43, 13)
        MarkerLabel.TabIndex = 16
        MarkerLabel.Text = "Marker:"
        '
        'IMMOBILIDataSet
        '
        Me.IMMOBILIDataSet.DataSetName = "IMMOBILIDataSet"
        Me.IMMOBILIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'X_MovimentiFinanziariBindingSource
        '
        Me.X_MovimentiFinanziariBindingSource.DataMember = "X_MovimentiFinanziari"
        Me.X_MovimentiFinanziariBindingSource.DataSource = Me.IMMOBILIDataSet
        '
        'X_MovimentiFinanziariTableAdapter
        '
        Me.X_MovimentiFinanziariTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.W_TributiTableAdapter = Nothing
        Me.TableAdapterManager.X_CausaliTableAdapter = Nothing
        Me.TableAdapterManager.X_FattureDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.X_FattureTableAdapter = Nothing
        Me.TableAdapterManager.X_MovimentiCondominiTableAdapter = Nothing
        Me.TableAdapterManager.X_MovimentiFinanziariTableAdapter = Me.X_MovimentiFinanziariTableAdapter
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
        'ProgressivoTextBox
        '
        Me.ProgressivoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_MovimentiFinanziariBindingSource, "Progressivo", True))
        Me.ProgressivoTextBox.Location = New System.Drawing.Point(15, 87)
        Me.ProgressivoTextBox.Name = "ProgressivoTextBox"
        Me.ProgressivoTextBox.Size = New System.Drawing.Size(96, 20)
        Me.ProgressivoTextBox.TabIndex = 2
        '
        'ContoComboBox
        '
        Me.ContoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_MovimentiFinanziariBindingSource, "Conto", True))
        Me.ContoComboBox.FormattingEnabled = True
        Me.ContoComboBox.Location = New System.Drawing.Point(118, 87)
        Me.ContoComboBox.Name = "ContoComboBox"
        Me.ContoComboBox.Size = New System.Drawing.Size(244, 21)
        Me.ContoComboBox.TabIndex = 3
        '
        'ImmobileComboBox
        '
        Me.ImmobileComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_MovimentiFinanziariBindingSource, "Immobile", True))
        Me.ImmobileComboBox.FormattingEnabled = True
        Me.ImmobileComboBox.Location = New System.Drawing.Point(376, 87)
        Me.ImmobileComboBox.Name = "ImmobileComboBox"
        Me.ImmobileComboBox.Size = New System.Drawing.Size(257, 21)
        Me.ImmobileComboBox.TabIndex = 5
        '
        'DataMovimentoDateTimePicker
        '
        Me.DataMovimentoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.X_MovimentiFinanziariBindingSource, "DataMovimento", True))
        Me.DataMovimentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataMovimentoDateTimePicker.Location = New System.Drawing.Point(15, 135)
        Me.DataMovimentoDateTimePicker.Name = "DataMovimentoDateTimePicker"
        Me.DataMovimentoDateTimePicker.Size = New System.Drawing.Size(96, 20)
        Me.DataMovimentoDateTimePicker.TabIndex = 7
        '
        'OperazioneTextBox
        '
        Me.OperazioneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_MovimentiFinanziariBindingSource, "Operazione", True))
        Me.OperazioneTextBox.Location = New System.Drawing.Point(118, 135)
        Me.OperazioneTextBox.Name = "OperazioneTextBox"
        Me.OperazioneTextBox.Size = New System.Drawing.Size(50, 20)
        Me.OperazioneTextBox.TabIndex = 9
        '
        'DataRiferimentoDateTimePicker
        '
        Me.DataRiferimentoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.X_MovimentiFinanziariBindingSource, "DataRiferimento", True))
        Me.DataRiferimentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataRiferimentoDateTimePicker.Location = New System.Drawing.Point(376, 135)
        Me.DataRiferimentoDateTimePicker.Name = "DataRiferimentoDateTimePicker"
        Me.DataRiferimentoDateTimePicker.Size = New System.Drawing.Size(105, 20)
        Me.DataRiferimentoDateTimePicker.TabIndex = 11
        '
        'ImportoTextBox
        '
        Me.ImportoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_MovimentiFinanziariBindingSource, "Importo", True))
        Me.ImportoTextBox.Location = New System.Drawing.Point(487, 135)
        Me.ImportoTextBox.Name = "ImportoTextBox"
        Me.ImportoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ImportoTextBox.TabIndex = 13
        '
        'DescrizioneTextBox
        '
        Me.DescrizioneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_MovimentiFinanziariBindingSource, "Descrizione", True))
        Me.DescrizioneTextBox.Location = New System.Drawing.Point(174, 135)
        Me.DescrizioneTextBox.Name = "DescrizioneTextBox"
        Me.DescrizioneTextBox.Size = New System.Drawing.Size(188, 20)
        Me.DescrizioneTextBox.TabIndex = 15
        '
        'MarkerTextBox
        '
        Me.MarkerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_MovimentiFinanziariBindingSource, "Marker", True))
        Me.MarkerTextBox.Location = New System.Drawing.Point(593, 135)
        Me.MarkerTextBox.Name = "MarkerTextBox"
        Me.MarkerTextBox.Size = New System.Drawing.Size(40, 20)
        Me.MarkerTextBox.TabIndex = 17
        '
        'X_MovimentiFinanziari
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 195)
        Me.Controls.Add(MarkerLabel)
        Me.Controls.Add(Me.MarkerTextBox)
        Me.Controls.Add(DescrizioneLabel)
        Me.Controls.Add(Me.DescrizioneTextBox)
        Me.Controls.Add(ImportoLabel)
        Me.Controls.Add(Me.ImportoTextBox)
        Me.Controls.Add(DataRiferimentoLabel)
        Me.Controls.Add(Me.DataRiferimentoDateTimePicker)
        Me.Controls.Add(OperazioneLabel)
        Me.Controls.Add(Me.OperazioneTextBox)
        Me.Controls.Add(DataMovimentoLabel)
        Me.Controls.Add(Me.DataMovimentoDateTimePicker)
        Me.Controls.Add(ImmobileLabel)
        Me.Controls.Add(Me.ImmobileComboBox)
        Me.Controls.Add(ContoLabel)
        Me.Controls.Add(Me.ContoComboBox)
        Me.Controls.Add(ProgressivoLabel)
        Me.Controls.Add(Me.ProgressivoTextBox)
        Me.Name = "X_MovimentiFinanziari"
        Me.Text = "Movimenti Finanziari"
        CType(Me.IMMOBILIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X_MovimentiFinanziariBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IMMOBILIDataSet As Patrimonio2014.IMMOBILIDataSet
    Friend WithEvents X_MovimentiFinanziariBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents X_MovimentiFinanziariTableAdapter As Patrimonio2014.IMMOBILIDataSetTableAdapters.X_MovimentiFinanziariTableAdapter
    Friend WithEvents TableAdapterManager As Patrimonio2014.IMMOBILIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProgressivoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ImmobileComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DataMovimentoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents OperazioneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataRiferimentoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ImportoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescrizioneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MarkerTextBox As System.Windows.Forms.TextBox
End Class
