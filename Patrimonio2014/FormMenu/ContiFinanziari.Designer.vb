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
        Me.IMMOBILIDataSet = New Patrimonio2014.IMMOBILIDataSet()
        Me.ContiFinanziariBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContiFinanziariTableAdapter = New Patrimonio2014.IMMOBILIDataSetTableAdapters.ContiFinanziariTableAdapter()
        Me.TableAdapterManager = New Patrimonio2014.IMMOBILIDataSetTableAdapters.TableAdapterManager()
        Me.ImmobileTextBox = New System.Windows.Forms.TextBox()
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
        CType(Me.IMMOBILIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContiFinanziariBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IMMOBILIDataSet
        '
        Me.IMMOBILIDataSet.DataSetName = "IMMOBILIDataSet"
        Me.IMMOBILIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ContiFinanziariBindingSource
        '
        Me.ContiFinanziariBindingSource.DataMember = "ContiFinanziari"
        Me.ContiFinanziariBindingSource.DataSource = Me.IMMOBILIDataSet
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
        Me.TableAdapterManager.ContiFinanziariTableAdapter = Me.ContiFinanziariTableAdapter
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
        'ImmobileLabel
        '
        ImmobileLabel.AutoSize = True
        ImmobileLabel.Location = New System.Drawing.Point(21, 49)
        ImmobileLabel.Name = "ImmobileLabel"
        ImmobileLabel.Size = New System.Drawing.Size(51, 13)
        ImmobileLabel.TabIndex = 1
        ImmobileLabel.Text = "Immobile:"
        '
        'ImmobileTextBox
        '
        Me.ImmobileTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContiFinanziariBindingSource, "Immobile", True))
        Me.ImmobileTextBox.Location = New System.Drawing.Point(24, 65)
        Me.ImmobileTextBox.Name = "ImmobileTextBox"
        Me.ImmobileTextBox.Size = New System.Drawing.Size(48, 20)
        Me.ImmobileTextBox.TabIndex = 2
        '
        'ContoLabel
        '
        ContoLabel.AutoSize = True
        ContoLabel.Location = New System.Drawing.Point(93, 49)
        ContoLabel.Name = "ContoLabel"
        ContoLabel.Size = New System.Drawing.Size(38, 13)
        ContoLabel.TabIndex = 2
        ContoLabel.Text = "Conto:"
        '
        'ContoTextBox
        '
        Me.ContoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContiFinanziariBindingSource, "Conto", True))
        Me.ContoTextBox.Location = New System.Drawing.Point(96, 65)
        Me.ContoTextBox.Name = "ContoTextBox"
        Me.ContoTextBox.Size = New System.Drawing.Size(46, 20)
        Me.ContoTextBox.TabIndex = 3
        '
        'BancaLabel
        '
        BancaLabel.AutoSize = True
        BancaLabel.Location = New System.Drawing.Point(164, 49)
        BancaLabel.Name = "BancaLabel"
        BancaLabel.Size = New System.Drawing.Size(41, 13)
        BancaLabel.TabIndex = 4
        BancaLabel.Text = "Banca:"
        '
        'BancaTextBox
        '
        Me.BancaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContiFinanziariBindingSource, "Banca", True))
        Me.BancaTextBox.Location = New System.Drawing.Point(167, 65)
        Me.BancaTextBox.Name = "BancaTextBox"
        Me.BancaTextBox.Size = New System.Drawing.Size(322, 20)
        Me.BancaTextBox.TabIndex = 5
        '
        'AgenziaLabel
        '
        AgenziaLabel.AutoSize = True
        AgenziaLabel.Location = New System.Drawing.Point(164, 88)
        AgenziaLabel.Name = "AgenziaLabel"
        AgenziaLabel.Size = New System.Drawing.Size(48, 13)
        AgenziaLabel.TabIndex = 6
        AgenziaLabel.Text = "Agenzia:"
        '
        'AgenziaTextBox
        '
        Me.AgenziaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContiFinanziariBindingSource, "Agenzia", True))
        Me.AgenziaTextBox.Location = New System.Drawing.Point(167, 104)
        Me.AgenziaTextBox.Name = "AgenziaTextBox"
        Me.AgenziaTextBox.Size = New System.Drawing.Size(322, 20)
        Me.AgenziaTextBox.TabIndex = 7
        '
        'IndirizzoLabel
        '
        IndirizzoLabel.AutoSize = True
        IndirizzoLabel.Location = New System.Drawing.Point(164, 127)
        IndirizzoLabel.Name = "IndirizzoLabel"
        IndirizzoLabel.Size = New System.Drawing.Size(48, 13)
        IndirizzoLabel.TabIndex = 8
        IndirizzoLabel.Text = "Indirizzo:"
        '
        'IndirizzoTextBox
        '
        Me.IndirizzoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContiFinanziariBindingSource, "Indirizzo", True))
        Me.IndirizzoTextBox.Location = New System.Drawing.Point(167, 143)
        Me.IndirizzoTextBox.Name = "IndirizzoTextBox"
        Me.IndirizzoTextBox.Size = New System.Drawing.Size(322, 20)
        Me.IndirizzoTextBox.TabIndex = 9
        '
        'LocalitaLabel
        '
        LocalitaLabel.AutoSize = True
        LocalitaLabel.Location = New System.Drawing.Point(164, 166)
        LocalitaLabel.Name = "LocalitaLabel"
        LocalitaLabel.Size = New System.Drawing.Size(47, 13)
        LocalitaLabel.TabIndex = 10
        LocalitaLabel.Text = "Localita:"
        '
        'LocalitaTextBox
        '
        Me.LocalitaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContiFinanziariBindingSource, "Localita", True))
        Me.LocalitaTextBox.Location = New System.Drawing.Point(167, 182)
        Me.LocalitaTextBox.Name = "LocalitaTextBox"
        Me.LocalitaTextBox.Size = New System.Drawing.Size(322, 20)
        Me.LocalitaTextBox.TabIndex = 11
        '
        'Intestatario1Label
        '
        Intestatario1Label.AutoSize = True
        Intestatario1Label.Location = New System.Drawing.Point(164, 218)
        Intestatario1Label.Name = "Intestatario1Label"
        Intestatario1Label.Size = New System.Drawing.Size(62, 13)
        Intestatario1Label.TabIndex = 12
        Intestatario1Label.Text = "Intestatario:"
        '
        'Intestatario1TextBox
        '
        Me.Intestatario1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContiFinanziariBindingSource, "Intestatario1", True))
        Me.Intestatario1TextBox.Location = New System.Drawing.Point(167, 234)
        Me.Intestatario1TextBox.Name = "Intestatario1TextBox"
        Me.Intestatario1TextBox.Size = New System.Drawing.Size(322, 20)
        Me.Intestatario1TextBox.TabIndex = 13
        '
        'Intestatario2TextBox
        '
        Me.Intestatario2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContiFinanziariBindingSource, "Intestatario2", True))
        Me.Intestatario2TextBox.Location = New System.Drawing.Point(167, 260)
        Me.Intestatario2TextBox.Name = "Intestatario2TextBox"
        Me.Intestatario2TextBox.Size = New System.Drawing.Size(322, 20)
        Me.Intestatario2TextBox.TabIndex = 15
        '
        'ContoCorrenteLabel
        '
        ContoCorrenteLabel.AutoSize = True
        ContoCorrenteLabel.Location = New System.Drawing.Point(164, 297)
        ContoCorrenteLabel.Name = "ContoCorrenteLabel"
        ContoCorrenteLabel.Size = New System.Drawing.Size(81, 13)
        ContoCorrenteLabel.TabIndex = 15
        ContoCorrenteLabel.Text = "Conto Corrente:"
        '
        'ContoCorrenteTextBox
        '
        Me.ContoCorrenteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContiFinanziariBindingSource, "ContoCorrente", True))
        Me.ContoCorrenteTextBox.Location = New System.Drawing.Point(167, 313)
        Me.ContoCorrenteTextBox.Name = "ContoCorrenteTextBox"
        Me.ContoCorrenteTextBox.Size = New System.Drawing.Size(167, 20)
        Me.ContoCorrenteTextBox.TabIndex = 16
        '
        'IBANLabel
        '
        IBANLabel.AutoSize = True
        IBANLabel.Location = New System.Drawing.Point(365, 297)
        IBANLabel.Name = "IBANLabel"
        IBANLabel.Size = New System.Drawing.Size(35, 13)
        IBANLabel.TabIndex = 17
        IBANLabel.Text = "IBAN:"
        '
        'IBANTextBox
        '
        Me.IBANTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContiFinanziariBindingSource, "IBAN", True))
        Me.IBANTextBox.Location = New System.Drawing.Point(368, 313)
        Me.IBANTextBox.Name = "IBANTextBox"
        Me.IBANTextBox.Size = New System.Drawing.Size(287, 20)
        Me.IBANTextBox.TabIndex = 18
        '
        'ContiFinanziari
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 355)
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
        Me.Controls.Add(Me.ImmobileTextBox)
        Me.Name = "ContiFinanziari"
        Me.Text = "Conti Finanziari"
        CType(Me.IMMOBILIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContiFinanziariBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IMMOBILIDataSet As Patrimonio2014.IMMOBILIDataSet
    Friend WithEvents ContiFinanziariBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ContiFinanziariTableAdapter As Patrimonio2014.IMMOBILIDataSetTableAdapters.ContiFinanziariTableAdapter
    Friend WithEvents TableAdapterManager As Patrimonio2014.IMMOBILIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ImmobileTextBox As System.Windows.Forms.TextBox
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
