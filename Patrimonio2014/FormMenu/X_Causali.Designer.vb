<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class X_Causali
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
        Dim CausaleLabel As System.Windows.Forms.Label
        Dim DescrizioneLabel As System.Windows.Forms.Label
        Dim Riga1Label As System.Windows.Forms.Label
        Me.IMMOBILIDataSet = New Patrimonio2014.IMMOBILIDataSet()
        Me.X_CausaliBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.X_CausaliTableAdapter = New Patrimonio2014.IMMOBILIDataSetTableAdapters.X_CausaliTableAdapter()
        Me.TableAdapterManager = New Patrimonio2014.IMMOBILIDataSetTableAdapters.TableAdapterManager()
        Me.CausaleTextBox = New System.Windows.Forms.TextBox()
        Me.DescrizioneTextBox = New System.Windows.Forms.TextBox()
        Me.Riga1TextBox = New System.Windows.Forms.TextBox()
        Me.Riga2TextBox = New System.Windows.Forms.TextBox()
        Me.Riga3TextBox = New System.Windows.Forms.TextBox()
        Me.Riga4TextBox = New System.Windows.Forms.TextBox()
        Me.Riga5TextBox = New System.Windows.Forms.TextBox()
        Me.Riga6TextBox = New System.Windows.Forms.TextBox()
        Me.Riga7TextBox = New System.Windows.Forms.TextBox()
        CausaleLabel = New System.Windows.Forms.Label()
        DescrizioneLabel = New System.Windows.Forms.Label()
        Riga1Label = New System.Windows.Forms.Label()
        CType(Me.IMMOBILIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X_CausaliBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IMMOBILIDataSet
        '
        Me.IMMOBILIDataSet.DataSetName = "IMMOBILIDataSet"
        Me.IMMOBILIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'X_CausaliBindingSource
        '
        Me.X_CausaliBindingSource.DataMember = "X_Causali"
        Me.X_CausaliBindingSource.DataSource = Me.IMMOBILIDataSet
        '
        'X_CausaliTableAdapter
        '
        Me.X_CausaliTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.X_CausaliTableAdapter = Me.X_CausaliTableAdapter
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
        'CausaleLabel
        '
        CausaleLabel.AutoSize = True
        CausaleLabel.Location = New System.Drawing.Point(12, 57)
        CausaleLabel.Name = "CausaleLabel"
        CausaleLabel.Size = New System.Drawing.Size(48, 13)
        CausaleLabel.TabIndex = 1
        CausaleLabel.Text = "Causale:"
        '
        'CausaleTextBox
        '
        Me.CausaleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_CausaliBindingSource, "Causale", True))
        Me.CausaleTextBox.Location = New System.Drawing.Point(15, 73)
        Me.CausaleTextBox.Name = "CausaleTextBox"
        Me.CausaleTextBox.Size = New System.Drawing.Size(57, 20)
        Me.CausaleTextBox.TabIndex = 2
        '
        'DescrizioneLabel
        '
        DescrizioneLabel.AutoSize = True
        DescrizioneLabel.Location = New System.Drawing.Point(78, 57)
        DescrizioneLabel.Name = "DescrizioneLabel"
        DescrizioneLabel.Size = New System.Drawing.Size(65, 13)
        DescrizioneLabel.TabIndex = 2
        DescrizioneLabel.Text = "Descrizione:"
        '
        'DescrizioneTextBox
        '
        Me.DescrizioneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_CausaliBindingSource, "Descrizione", True))
        Me.DescrizioneTextBox.Location = New System.Drawing.Point(81, 73)
        Me.DescrizioneTextBox.Name = "DescrizioneTextBox"
        Me.DescrizioneTextBox.Size = New System.Drawing.Size(288, 20)
        Me.DescrizioneTextBox.TabIndex = 3
        '
        'Riga1Label
        '
        Riga1Label.AutoSize = True
        Riga1Label.Location = New System.Drawing.Point(78, 106)
        Riga1Label.Name = "Riga1Label"
        Riga1Label.Size = New System.Drawing.Size(38, 13)
        Riga1Label.TabIndex = 4
        Riga1Label.Text = "Righe:"
        '
        'Riga1TextBox
        '
        Me.Riga1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_CausaliBindingSource, "Riga1", True))
        Me.Riga1TextBox.Location = New System.Drawing.Point(81, 122)
        Me.Riga1TextBox.Name = "Riga1TextBox"
        Me.Riga1TextBox.Size = New System.Drawing.Size(288, 20)
        Me.Riga1TextBox.TabIndex = 5
        '
        'Riga2TextBox
        '
        Me.Riga2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_CausaliBindingSource, "Riga2", True))
        Me.Riga2TextBox.Location = New System.Drawing.Point(81, 148)
        Me.Riga2TextBox.Name = "Riga2TextBox"
        Me.Riga2TextBox.Size = New System.Drawing.Size(288, 20)
        Me.Riga2TextBox.TabIndex = 7
        '
        'Riga3TextBox
        '
        Me.Riga3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_CausaliBindingSource, "Riga3", True))
        Me.Riga3TextBox.Location = New System.Drawing.Point(81, 174)
        Me.Riga3TextBox.Name = "Riga3TextBox"
        Me.Riga3TextBox.Size = New System.Drawing.Size(288, 20)
        Me.Riga3TextBox.TabIndex = 8
        '
        'Riga4TextBox
        '
        Me.Riga4TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_CausaliBindingSource, "Riga4", True))
        Me.Riga4TextBox.Location = New System.Drawing.Point(81, 200)
        Me.Riga4TextBox.Name = "Riga4TextBox"
        Me.Riga4TextBox.Size = New System.Drawing.Size(288, 20)
        Me.Riga4TextBox.TabIndex = 9
        '
        'Riga5TextBox
        '
        Me.Riga5TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_CausaliBindingSource, "Riga5", True))
        Me.Riga5TextBox.Location = New System.Drawing.Point(81, 226)
        Me.Riga5TextBox.Name = "Riga5TextBox"
        Me.Riga5TextBox.Size = New System.Drawing.Size(288, 20)
        Me.Riga5TextBox.TabIndex = 10
        '
        'Riga6TextBox
        '
        Me.Riga6TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_CausaliBindingSource, "Riga6", True))
        Me.Riga6TextBox.Location = New System.Drawing.Point(81, 252)
        Me.Riga6TextBox.Name = "Riga6TextBox"
        Me.Riga6TextBox.Size = New System.Drawing.Size(288, 20)
        Me.Riga6TextBox.TabIndex = 11
        '
        'Riga7TextBox
        '
        Me.Riga7TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.X_CausaliBindingSource, "Riga7", True))
        Me.Riga7TextBox.Location = New System.Drawing.Point(81, 278)
        Me.Riga7TextBox.Name = "Riga7TextBox"
        Me.Riga7TextBox.Size = New System.Drawing.Size(288, 20)
        Me.Riga7TextBox.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 333)
        Me.Controls.Add(Me.Riga7TextBox)
        Me.Controls.Add(Me.Riga6TextBox)
        Me.Controls.Add(Me.Riga5TextBox)
        Me.Controls.Add(Me.Riga4TextBox)
        Me.Controls.Add(Me.Riga3TextBox)
        Me.Controls.Add(Me.Riga2TextBox)
        Me.Controls.Add(Riga1Label)
        Me.Controls.Add(Me.Riga1TextBox)
        Me.Controls.Add(DescrizioneLabel)
        Me.Controls.Add(Me.DescrizioneTextBox)
        Me.Controls.Add(CausaleLabel)
        Me.Controls.Add(Me.CausaleTextBox)
        Me.Name = "Form1"
        Me.Text = "Causali per la Registrazione Spese"
        CType(Me.IMMOBILIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X_CausaliBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IMMOBILIDataSet As Patrimonio2014.IMMOBILIDataSet
    Friend WithEvents X_CausaliBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents X_CausaliTableAdapter As Patrimonio2014.IMMOBILIDataSetTableAdapters.X_CausaliTableAdapter
    Friend WithEvents TableAdapterManager As Patrimonio2014.IMMOBILIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CausaleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescrizioneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Riga1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Riga2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Riga3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Riga4TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Riga5TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Riga6TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Riga7TextBox As System.Windows.Forms.TextBox
End Class
