<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Costanti
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
        Dim TabellaLabel As System.Windows.Forms.Label
        Dim OrdinanteLabel As System.Windows.Forms.Label
        Dim DipendenzaLabel As System.Windows.Forms.Label
        Dim CategoriaLabel As System.Windows.Forms.Label
        Dim ContoLabel As System.Windows.Forms.Label
        Me.IMMOBILIDataSet = New Patrimonio2014.IMMOBILIDataSet()
        Me.CostantiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CostantiTableAdapter = New Patrimonio2014.IMMOBILIDataSetTableAdapters.CostantiTableAdapter()
        Me.TableAdapterManager = New Patrimonio2014.IMMOBILIDataSetTableAdapters.TableAdapterManager()
        Me.ImmobileComboBox = New System.Windows.Forms.ComboBox()
        Me.TabellaTextBox = New System.Windows.Forms.TextBox()
        Me.OrdinanteTextBox = New System.Windows.Forms.TextBox()
        Me.DipendenzaTextBox = New System.Windows.Forms.TextBox()
        Me.CategoriaTextBox = New System.Windows.Forms.TextBox()
        Me.ContoTextBox = New System.Windows.Forms.TextBox()
        Me.CostantiDettaglioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CostantiDettaglioTableAdapter = New Patrimonio2014.IMMOBILIDataSetTableAdapters.CostantiDettaglioTableAdapter()
        Me.CostantiDettaglioDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        ImmobileLabel = New System.Windows.Forms.Label()
        TabellaLabel = New System.Windows.Forms.Label()
        OrdinanteLabel = New System.Windows.Forms.Label()
        DipendenzaLabel = New System.Windows.Forms.Label()
        CategoriaLabel = New System.Windows.Forms.Label()
        ContoLabel = New System.Windows.Forms.Label()
        CType(Me.IMMOBILIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CostantiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CostantiDettaglioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CostantiDettaglioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IMMOBILIDataSet
        '
        Me.IMMOBILIDataSet.DataSetName = "IMMOBILIDataSet"
        Me.IMMOBILIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CostantiBindingSource
        '
        Me.CostantiBindingSource.DataMember = "Costanti"
        Me.CostantiBindingSource.DataSource = Me.IMMOBILIDataSet
        '
        'CostantiTableAdapter
        '
        Me.CostantiTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AnagraficaStudioTableAdapter = Nothing
        Me.TableAdapterManager.AnagraficheTableAdapter = Nothing
        Me.TableAdapterManager.AssembleaDettaglioTableAdapter = Nothing
        Me.TableAdapterManager.AssembleaTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ContiFinanziariTableAdapter = Nothing
        Me.TableAdapterManager.CostantiDettaglioTableAdapter = Me.CostantiDettaglioTableAdapter
        Me.TableAdapterManager.CostantiTableAdapter = Me.CostantiTableAdapter
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
        'ImmobileLabel
        '
        ImmobileLabel.AutoSize = True
        ImmobileLabel.Location = New System.Drawing.Point(12, 46)
        ImmobileLabel.Name = "ImmobileLabel"
        ImmobileLabel.Size = New System.Drawing.Size(51, 13)
        ImmobileLabel.TabIndex = 1
        ImmobileLabel.Text = "Immobile:"
        '
        'ImmobileComboBox
        '
        Me.ImmobileComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostantiBindingSource, "Immobile", True))
        Me.ImmobileComboBox.FormattingEnabled = True
        Me.ImmobileComboBox.Location = New System.Drawing.Point(15, 62)
        Me.ImmobileComboBox.Name = "ImmobileComboBox"
        Me.ImmobileComboBox.Size = New System.Drawing.Size(300, 21)
        Me.ImmobileComboBox.TabIndex = 2
        '
        'TabellaLabel
        '
        TabellaLabel.AutoSize = True
        TabellaLabel.Location = New System.Drawing.Point(348, 46)
        TabellaLabel.Name = "TabellaLabel"
        TabellaLabel.Size = New System.Drawing.Size(45, 13)
        TabellaLabel.TabIndex = 2
        TabellaLabel.Text = "Tabella:"
        '
        'TabellaTextBox
        '
        Me.TabellaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostantiBindingSource, "Tabella", True))
        Me.TabellaTextBox.Location = New System.Drawing.Point(351, 62)
        Me.TabellaTextBox.Name = "TabellaTextBox"
        Me.TabellaTextBox.Size = New System.Drawing.Size(62, 20)
        Me.TabellaTextBox.TabIndex = 3
        '
        'OrdinanteLabel
        '
        OrdinanteLabel.AutoSize = True
        OrdinanteLabel.Location = New System.Drawing.Point(12, 95)
        OrdinanteLabel.Name = "OrdinanteLabel"
        OrdinanteLabel.Size = New System.Drawing.Size(56, 13)
        OrdinanteLabel.TabIndex = 4
        OrdinanteLabel.Text = "Ordinante:"
        '
        'OrdinanteTextBox
        '
        Me.OrdinanteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostantiBindingSource, "Ordinante", True))
        Me.OrdinanteTextBox.Location = New System.Drawing.Point(15, 111)
        Me.OrdinanteTextBox.Name = "OrdinanteTextBox"
        Me.OrdinanteTextBox.Size = New System.Drawing.Size(132, 20)
        Me.OrdinanteTextBox.TabIndex = 5
        '
        'DipendenzaLabel
        '
        DipendenzaLabel.AutoSize = True
        DipendenzaLabel.Location = New System.Drawing.Point(165, 95)
        DipendenzaLabel.Name = "DipendenzaLabel"
        DipendenzaLabel.Size = New System.Drawing.Size(67, 13)
        DipendenzaLabel.TabIndex = 6
        DipendenzaLabel.Text = "Dipendenza:"
        '
        'DipendenzaTextBox
        '
        Me.DipendenzaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostantiBindingSource, "Dipendenza", True))
        Me.DipendenzaTextBox.Location = New System.Drawing.Point(168, 111)
        Me.DipendenzaTextBox.Name = "DipendenzaTextBox"
        Me.DipendenzaTextBox.Size = New System.Drawing.Size(147, 20)
        Me.DipendenzaTextBox.TabIndex = 7
        '
        'CategoriaLabel
        '
        CategoriaLabel.AutoSize = True
        CategoriaLabel.Location = New System.Drawing.Point(352, 95)
        CategoriaLabel.Name = "CategoriaLabel"
        CategoriaLabel.Size = New System.Drawing.Size(55, 13)
        CategoriaLabel.TabIndex = 8
        CategoriaLabel.Text = "Categoria:"
        '
        'CategoriaTextBox
        '
        Me.CategoriaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostantiBindingSource, "Categoria", True))
        Me.CategoriaTextBox.Location = New System.Drawing.Point(351, 111)
        Me.CategoriaTextBox.Name = "CategoriaTextBox"
        Me.CategoriaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CategoriaTextBox.TabIndex = 9
        '
        'ContoLabel
        '
        ContoLabel.AutoSize = True
        ContoLabel.Location = New System.Drawing.Point(462, 95)
        ContoLabel.Name = "ContoLabel"
        ContoLabel.Size = New System.Drawing.Size(38, 13)
        ContoLabel.TabIndex = 10
        ContoLabel.Text = "Conto:"
        '
        'ContoTextBox
        '
        Me.ContoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostantiBindingSource, "Conto", True))
        Me.ContoTextBox.Location = New System.Drawing.Point(465, 111)
        Me.ContoTextBox.Name = "ContoTextBox"
        Me.ContoTextBox.Size = New System.Drawing.Size(150, 20)
        Me.ContoTextBox.TabIndex = 11
        '
        'CostantiDettaglioBindingSource
        '
        Me.CostantiDettaglioBindingSource.DataMember = "CostantiDettaglio"
        Me.CostantiDettaglioBindingSource.DataSource = Me.IMMOBILIDataSet
        '
        'CostantiDettaglioTableAdapter
        '
        Me.CostantiDettaglioTableAdapter.ClearBeforeFill = True
        '
        'CostantiDettaglioDataGridView
        '
        Me.CostantiDettaglioDataGridView.AutoGenerateColumns = False
        Me.CostantiDettaglioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CostantiDettaglioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.CostantiDettaglioDataGridView.DataSource = Me.CostantiDettaglioBindingSource
        Me.CostantiDettaglioDataGridView.Location = New System.Drawing.Point(15, 149)
        Me.CostantiDettaglioDataGridView.Name = "CostantiDettaglioDataGridView"
        Me.CostantiDettaglioDataGridView.Size = New System.Drawing.Size(600, 241)
        Me.CostantiDettaglioDataGridView.TabIndex = 12
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Riga"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Riga"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 50
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Descrizione"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Descrizione"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 500
        '
        'Costanti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 410)
        Me.Controls.Add(Me.CostantiDettaglioDataGridView)
        Me.Controls.Add(ContoLabel)
        Me.Controls.Add(Me.ContoTextBox)
        Me.Controls.Add(CategoriaLabel)
        Me.Controls.Add(Me.CategoriaTextBox)
        Me.Controls.Add(DipendenzaLabel)
        Me.Controls.Add(Me.DipendenzaTextBox)
        Me.Controls.Add(OrdinanteLabel)
        Me.Controls.Add(Me.OrdinanteTextBox)
        Me.Controls.Add(TabellaLabel)
        Me.Controls.Add(Me.TabellaTextBox)
        Me.Controls.Add(ImmobileLabel)
        Me.Controls.Add(Me.ImmobileComboBox)
        Me.Name = "Costanti"
        Me.Text = "Costanti per Avvisi"
        CType(Me.IMMOBILIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CostantiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CostantiDettaglioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CostantiDettaglioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IMMOBILIDataSet As Patrimonio2014.IMMOBILIDataSet
    Friend WithEvents CostantiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CostantiTableAdapter As Patrimonio2014.IMMOBILIDataSetTableAdapters.CostantiTableAdapter
    Friend WithEvents TableAdapterManager As Patrimonio2014.IMMOBILIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CostantiDettaglioTableAdapter As Patrimonio2014.IMMOBILIDataSetTableAdapters.CostantiDettaglioTableAdapter
    Friend WithEvents ImmobileComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TabellaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OrdinanteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DipendenzaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CategoriaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CostantiDettaglioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CostantiDettaglioDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
