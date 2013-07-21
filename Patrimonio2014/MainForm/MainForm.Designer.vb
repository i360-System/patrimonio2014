<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimentazioneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreventiviToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AvvisiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConvocazioniToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArchiviToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FornitoriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RitenuteDAccontoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TerminaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpzioniToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformazioniSulSoftwareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformazioniSullaLicenzaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MovimentazioneToolStripMenuItem, Me.PreventiviToolStripMenuItem, Me.AvvisiToolStripMenuItem, Me.ConvocazioniToolStripMenuItem, Me.ArchiviToolStripMenuItem, Me.RitenuteDAccontoToolStripMenuItem, Me.InfoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(722, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TerminaToolStripMenuItem, Me.OpzioniToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'MovimentazioneToolStripMenuItem
        '
        Me.MovimentazioneToolStripMenuItem.Name = "MovimentazioneToolStripMenuItem"
        Me.MovimentazioneToolStripMenuItem.Size = New System.Drawing.Size(108, 20)
        Me.MovimentazioneToolStripMenuItem.Text = "Movimentazione"
        '
        'PreventiviToolStripMenuItem
        '
        Me.PreventiviToolStripMenuItem.Name = "PreventiviToolStripMenuItem"
        Me.PreventiviToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.PreventiviToolStripMenuItem.Text = "Preventivi"
        '
        'AvvisiToolStripMenuItem
        '
        Me.AvvisiToolStripMenuItem.Name = "AvvisiToolStripMenuItem"
        Me.AvvisiToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.AvvisiToolStripMenuItem.Text = "Avvisi"
        '
        'ConvocazioniToolStripMenuItem
        '
        Me.ConvocazioniToolStripMenuItem.Name = "ConvocazioniToolStripMenuItem"
        Me.ConvocazioniToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.ConvocazioniToolStripMenuItem.Text = "Convocazioni"
        '
        'ArchiviToolStripMenuItem
        '
        Me.ArchiviToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FornitoriToolStripMenuItem})
        Me.ArchiviToolStripMenuItem.Name = "ArchiviToolStripMenuItem"
        Me.ArchiviToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.ArchiviToolStripMenuItem.Text = "Archivi"
        '
        'FornitoriToolStripMenuItem
        '
        Me.FornitoriToolStripMenuItem.Name = "FornitoriToolStripMenuItem"
        Me.FornitoriToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.FornitoriToolStripMenuItem.Text = "Fornitori"
        '
        'RitenuteDAccontoToolStripMenuItem
        '
        Me.RitenuteDAccontoToolStripMenuItem.Name = "RitenuteDAccontoToolStripMenuItem"
        Me.RitenuteDAccontoToolStripMenuItem.Size = New System.Drawing.Size(121, 20)
        Me.RitenuteDAccontoToolStripMenuItem.Text = "Ritenute d'Acconto"
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformazioniSulSoftwareToolStripMenuItem, Me.InformazioniSullaLicenzaToolStripMenuItem})
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.InfoToolStripMenuItem.Text = "Info"
        '
        'TerminaToolStripMenuItem
        '
        Me.TerminaToolStripMenuItem.Name = "TerminaToolStripMenuItem"
        Me.TerminaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TerminaToolStripMenuItem.Text = "Termina"
        '
        'OpzioniToolStripMenuItem
        '
        Me.OpzioniToolStripMenuItem.Name = "OpzioniToolStripMenuItem"
        Me.OpzioniToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OpzioniToolStripMenuItem.Text = "Opzioni"
        '
        'InformazioniSulSoftwareToolStripMenuItem
        '
        Me.InformazioniSulSoftwareToolStripMenuItem.Name = "InformazioniSulSoftwareToolStripMenuItem"
        Me.InformazioniSulSoftwareToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.InformazioniSulSoftwareToolStripMenuItem.Text = "Informazioni sul software"
        '
        'InformazioniSullaLicenzaToolStripMenuItem
        '
        Me.InformazioniSullaLicenzaToolStripMenuItem.Name = "InformazioniSullaLicenzaToolStripMenuItem"
        Me.InformazioniSullaLicenzaToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.InformazioniSullaLicenzaToolStripMenuItem.Text = "Informazioni sulla licenza"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 45)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Menu Patrimonio 2014"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MovimentazioneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreventiviToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AvvisiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConvocazioniToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArchiviToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FornitoriToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RitenuteDAccontoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TerminaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpzioniToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformazioniSulSoftwareToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformazioniSullaLicenzaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
