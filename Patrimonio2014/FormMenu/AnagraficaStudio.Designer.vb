<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnagraficaStudio
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
        Dim StudioLabel As System.Windows.Forms.Label
        Dim Denominazione1Label As System.Windows.Forms.Label
        Dim IndirizzoLabel As System.Windows.Forms.Label
        Dim CapLabel As System.Windows.Forms.Label
        Dim LocalitaLabel As System.Windows.Forms.Label
        Dim ProvinciaLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim CodiceFiscaleLabel As System.Windows.Forms.Label
        Dim PartitaIvaLabel As System.Windows.Forms.Label
        Dim TipoSocietaLabel As System.Windows.Forms.Label
        Dim Note1Label As System.Windows.Forms.Label
        Me.IMMOBILIDataSet = New Patrimonio2014.IMMOBILIDataSet()
        Me.AnagraficaStudioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnagraficaStudioTableAdapter = New Patrimonio2014.IMMOBILIDataSetTableAdapters.AnagraficaStudioTableAdapter()
        Me.TableAdapterManager = New Patrimonio2014.IMMOBILIDataSetTableAdapters.TableAdapterManager()
        Me.StudioTextBox = New System.Windows.Forms.TextBox()
        Me.Denominazione1TextBox = New System.Windows.Forms.TextBox()
        Me.Denominazione2TextBox = New System.Windows.Forms.TextBox()
        Me.IndirizzoTextBox = New System.Windows.Forms.TextBox()
        Me.CapTextBox = New System.Windows.Forms.TextBox()
        Me.LocalitaTextBox = New System.Windows.Forms.TextBox()
        Me.ProvinciaTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.CodiceFiscaleTextBox = New System.Windows.Forms.TextBox()
        Me.PartitaIvaTextBox = New System.Windows.Forms.TextBox()
        Me.TipoSocietaTextBox = New System.Windows.Forms.TextBox()
        Me.Note1TextBox = New System.Windows.Forms.TextBox()
        Me.Note2TextBox = New System.Windows.Forms.TextBox()
        StudioLabel = New System.Windows.Forms.Label()
        Denominazione1Label = New System.Windows.Forms.Label()
        IndirizzoLabel = New System.Windows.Forms.Label()
        CapLabel = New System.Windows.Forms.Label()
        LocalitaLabel = New System.Windows.Forms.Label()
        ProvinciaLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        CodiceFiscaleLabel = New System.Windows.Forms.Label()
        PartitaIvaLabel = New System.Windows.Forms.Label()
        TipoSocietaLabel = New System.Windows.Forms.Label()
        Note1Label = New System.Windows.Forms.Label()
        CType(Me.IMMOBILIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnagraficaStudioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StudioLabel
        '
        StudioLabel.AutoSize = True
        StudioLabel.Location = New System.Drawing.Point(12, 45)
        StudioLabel.Name = "StudioLabel"
        StudioLabel.Size = New System.Drawing.Size(40, 13)
        StudioLabel.TabIndex = 1
        StudioLabel.Text = "Studio:"
        '
        'Denominazione1Label
        '
        Denominazione1Label.AutoSize = True
        Denominazione1Label.Location = New System.Drawing.Point(129, 45)
        Denominazione1Label.Name = "Denominazione1Label"
        Denominazione1Label.Size = New System.Drawing.Size(83, 13)
        Denominazione1Label.TabIndex = 3
        Denominazione1Label.Text = "Denominazione:"
        AddHandler Denominazione1Label.Click, AddressOf Me.Denominazione1Label_Click
        '
        'IndirizzoLabel
        '
        IndirizzoLabel.AutoSize = True
        IndirizzoLabel.Location = New System.Drawing.Point(128, 110)
        IndirizzoLabel.Name = "IndirizzoLabel"
        IndirizzoLabel.Size = New System.Drawing.Size(48, 13)
        IndirizzoLabel.TabIndex = 6
        IndirizzoLabel.Text = "Indirizzo:"
        '
        'CapLabel
        '
        CapLabel.AutoSize = True
        CapLabel.Location = New System.Drawing.Point(45, 149)
        CapLabel.Name = "CapLabel"
        CapLabel.Size = New System.Drawing.Size(29, 13)
        CapLabel.TabIndex = 8
        CapLabel.Text = "Cap:"
        '
        'LocalitaLabel
        '
        LocalitaLabel.AutoSize = True
        LocalitaLabel.Location = New System.Drawing.Point(129, 149)
        LocalitaLabel.Name = "LocalitaLabel"
        LocalitaLabel.Size = New System.Drawing.Size(47, 13)
        LocalitaLabel.TabIndex = 10
        LocalitaLabel.Text = "Localita:"
        '
        'ProvinciaLabel
        '
        ProvinciaLabel.AutoSize = True
        ProvinciaLabel.Location = New System.Drawing.Point(445, 149)
        ProvinciaLabel.Name = "ProvinciaLabel"
        ProvinciaLabel.Size = New System.Drawing.Size(54, 13)
        ProvinciaLabel.TabIndex = 12
        ProvinciaLabel.Text = "Provincia:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(45, 198)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(52, 13)
        TelefonoLabel.TabIndex = 14
        TelefonoLabel.Text = "Telefono:"
        '
        'CodiceFiscaleLabel
        '
        CodiceFiscaleLabel.AutoSize = True
        CodiceFiscaleLabel.Location = New System.Drawing.Point(445, 198)
        CodiceFiscaleLabel.Name = "CodiceFiscaleLabel"
        CodiceFiscaleLabel.Size = New System.Drawing.Size(79, 13)
        CodiceFiscaleLabel.TabIndex = 16
        CodiceFiscaleLabel.Text = "Codice Fiscale:"
        '
        'PartitaIvaLabel
        '
        PartitaIvaLabel.AutoSize = True
        PartitaIvaLabel.Location = New System.Drawing.Point(662, 198)
        PartitaIvaLabel.Name = "PartitaIvaLabel"
        PartitaIvaLabel.Size = New System.Drawing.Size(58, 13)
        PartitaIvaLabel.TabIndex = 18
        PartitaIvaLabel.Text = "Partita Iva:"
        '
        'TipoSocietaLabel
        '
        TipoSocietaLabel.AutoSize = True
        TipoSocietaLabel.Location = New System.Drawing.Point(45, 237)
        TipoSocietaLabel.Name = "TipoSocietaLabel"
        TipoSocietaLabel.Size = New System.Drawing.Size(70, 13)
        TipoSocietaLabel.TabIndex = 20
        TipoSocietaLabel.Text = "Tipo Societa:"
        '
        'Note1Label
        '
        Note1Label.AutoSize = True
        Note1Label.Location = New System.Drawing.Point(129, 237)
        Note1Label.Name = "Note1Label"
        Note1Label.Size = New System.Drawing.Size(33, 13)
        Note1Label.TabIndex = 22
        Note1Label.Text = "Note:"
        '
        'IMMOBILIDataSet
        '
        Me.IMMOBILIDataSet.DataSetName = "IMMOBILIDataSet"
        Me.IMMOBILIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AnagraficaStudioBindingSource
        '
        Me.AnagraficaStudioBindingSource.DataMember = "AnagraficaStudio"
        Me.AnagraficaStudioBindingSource.DataSource = Me.IMMOBILIDataSet
        '
        'AnagraficaStudioTableAdapter
        '
        Me.AnagraficaStudioTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AnagraficaStudioTableAdapter = Me.AnagraficaStudioTableAdapter
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
        'StudioTextBox
        '
        Me.StudioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaStudioBindingSource, "Studio", True))
        Me.StudioTextBox.Location = New System.Drawing.Point(15, 61)
        Me.StudioTextBox.Name = "StudioTextBox"
        Me.StudioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StudioTextBox.TabIndex = 2
        '
        'Denominazione1TextBox
        '
        Me.Denominazione1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaStudioBindingSource, "Denominazione1", True))
        Me.Denominazione1TextBox.Location = New System.Drawing.Point(131, 61)
        Me.Denominazione1TextBox.Name = "Denominazione1TextBox"
        Me.Denominazione1TextBox.Size = New System.Drawing.Size(303, 20)
        Me.Denominazione1TextBox.TabIndex = 4
        '
        'Denominazione2TextBox
        '
        Me.Denominazione2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaStudioBindingSource, "Denominazione2", True))
        Me.Denominazione2TextBox.Location = New System.Drawing.Point(132, 87)
        Me.Denominazione2TextBox.Name = "Denominazione2TextBox"
        Me.Denominazione2TextBox.Size = New System.Drawing.Size(302, 20)
        Me.Denominazione2TextBox.TabIndex = 6
        '
        'IndirizzoTextBox
        '
        Me.IndirizzoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaStudioBindingSource, "Indirizzo", True))
        Me.IndirizzoTextBox.Location = New System.Drawing.Point(131, 126)
        Me.IndirizzoTextBox.Name = "IndirizzoTextBox"
        Me.IndirizzoTextBox.Size = New System.Drawing.Size(303, 20)
        Me.IndirizzoTextBox.TabIndex = 7
        '
        'CapTextBox
        '
        Me.CapTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaStudioBindingSource, "Cap", True))
        Me.CapTextBox.Location = New System.Drawing.Point(48, 165)
        Me.CapTextBox.Name = "CapTextBox"
        Me.CapTextBox.Size = New System.Drawing.Size(77, 20)
        Me.CapTextBox.TabIndex = 9
        '
        'LocalitaTextBox
        '
        Me.LocalitaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaStudioBindingSource, "Localita", True))
        Me.LocalitaTextBox.Location = New System.Drawing.Point(131, 165)
        Me.LocalitaTextBox.Name = "LocalitaTextBox"
        Me.LocalitaTextBox.Size = New System.Drawing.Size(303, 20)
        Me.LocalitaTextBox.TabIndex = 11
        '
        'ProvinciaTextBox
        '
        Me.ProvinciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaStudioBindingSource, "Provincia", True))
        Me.ProvinciaTextBox.Location = New System.Drawing.Point(448, 165)
        Me.ProvinciaTextBox.Name = "ProvinciaTextBox"
        Me.ProvinciaTextBox.Size = New System.Drawing.Size(51, 20)
        Me.ProvinciaTextBox.TabIndex = 13
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaStudioBindingSource, "Telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(48, 214)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(386, 20)
        Me.TelefonoTextBox.TabIndex = 15
        '
        'CodiceFiscaleTextBox
        '
        Me.CodiceFiscaleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaStudioBindingSource, "CodiceFiscale", True))
        Me.CodiceFiscaleTextBox.Location = New System.Drawing.Point(448, 214)
        Me.CodiceFiscaleTextBox.Name = "CodiceFiscaleTextBox"
        Me.CodiceFiscaleTextBox.Size = New System.Drawing.Size(211, 20)
        Me.CodiceFiscaleTextBox.TabIndex = 17
        '
        'PartitaIvaTextBox
        '
        Me.PartitaIvaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaStudioBindingSource, "PartitaIva", True))
        Me.PartitaIvaTextBox.Location = New System.Drawing.Point(665, 214)
        Me.PartitaIvaTextBox.Name = "PartitaIvaTextBox"
        Me.PartitaIvaTextBox.Size = New System.Drawing.Size(139, 20)
        Me.PartitaIvaTextBox.TabIndex = 19
        '
        'TipoSocietaTextBox
        '
        Me.TipoSocietaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaStudioBindingSource, "TipoSocieta", True))
        Me.TipoSocietaTextBox.Location = New System.Drawing.Point(48, 255)
        Me.TipoSocietaTextBox.Name = "TipoSocietaTextBox"
        Me.TipoSocietaTextBox.Size = New System.Drawing.Size(67, 20)
        Me.TipoSocietaTextBox.TabIndex = 21
        '
        'Note1TextBox
        '
        Me.Note1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaStudioBindingSource, "Note1", True))
        Me.Note1TextBox.Location = New System.Drawing.Point(132, 255)
        Me.Note1TextBox.Name = "Note1TextBox"
        Me.Note1TextBox.Size = New System.Drawing.Size(672, 20)
        Me.Note1TextBox.TabIndex = 23
        '
        'Note2TextBox
        '
        Me.Note2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaStudioBindingSource, "Note2", True))
        Me.Note2TextBox.Location = New System.Drawing.Point(132, 281)
        Me.Note2TextBox.Name = "Note2TextBox"
        Me.Note2TextBox.Size = New System.Drawing.Size(672, 20)
        Me.Note2TextBox.TabIndex = 25
        '
        'AnagraficaStudio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 313)
        Me.Controls.Add(Me.Note2TextBox)
        Me.Controls.Add(Note1Label)
        Me.Controls.Add(Me.Note1TextBox)
        Me.Controls.Add(TipoSocietaLabel)
        Me.Controls.Add(Me.TipoSocietaTextBox)
        Me.Controls.Add(PartitaIvaLabel)
        Me.Controls.Add(Me.PartitaIvaTextBox)
        Me.Controls.Add(CodiceFiscaleLabel)
        Me.Controls.Add(Me.CodiceFiscaleTextBox)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(ProvinciaLabel)
        Me.Controls.Add(Me.ProvinciaTextBox)
        Me.Controls.Add(LocalitaLabel)
        Me.Controls.Add(Me.LocalitaTextBox)
        Me.Controls.Add(CapLabel)
        Me.Controls.Add(Me.CapTextBox)
        Me.Controls.Add(IndirizzoLabel)
        Me.Controls.Add(Me.IndirizzoTextBox)
        Me.Controls.Add(Me.Denominazione2TextBox)
        Me.Controls.Add(Denominazione1Label)
        Me.Controls.Add(Me.Denominazione1TextBox)
        Me.Controls.Add(StudioLabel)
        Me.Controls.Add(Me.StudioTextBox)
        Me.Name = "AnagraficaStudio"
        Me.Text = "Anagrafica Studio"
        CType(Me.IMMOBILIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnagraficaStudioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IMMOBILIDataSet As Patrimonio2014.IMMOBILIDataSet
    Friend WithEvents AnagraficaStudioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AnagraficaStudioTableAdapter As Patrimonio2014.IMMOBILIDataSetTableAdapters.AnagraficaStudioTableAdapter
    Friend WithEvents TableAdapterManager As Patrimonio2014.IMMOBILIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StudioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Denominazione1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Denominazione2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents IndirizzoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CapTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LocalitaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProvinciaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CodiceFiscaleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PartitaIvaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TipoSocietaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Note1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Note2TextBox As System.Windows.Forms.TextBox
End Class
