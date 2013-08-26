Public Class MainForm
    Public istform As List(Of Form)

    Private Sub FornitoriToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FornitoriToolStripMenuItem.Click
        Dim NewMDIChild As New Fornitori
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
        ''controllo istanza
        'Dim frm As New Fornitori
        'frm.Show()
    End Sub

    Private Sub OpzioniToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpzioniToolStripMenuItem.Click
        If Me.Contains(Opzioni) Then
            Dim NewMDIChild As New Opzioni
            'Set the Parent Form of the Child window.
            NewMDIChild.MdiParent = Me
            'Display the new form.
            NewMDIChild.Show()
            ''controllo istanza
            'Dim frm As New Opzioni
            'frm.Show()
        End If
    End Sub

    Private Sub SpeseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpeseToolStripMenuItem.Click

    End Sub

    Private Sub AnagraficaStudioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SsToolStripMenuItem.Click
        Dim NewMDIChild As New AnagraficaStudio
        ''Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        ''Display the new form.
        NewMDIChild.Show()
        ''controllo istanza
        ' ''Dim frm As New AnagraficaStudio
        ' ''frm.Show()
    End Sub



    Public Sub New()

        ' Chiamata richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        'Dim c As New CustomControl1
        'ToolStripContainer1.RightToolStripPanel.Controls.Clear()

    End Sub

    'Private Sub TreeView1_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs)
    '    'MsgBox(TreeView1.SelectedNode.ToString)
    '    Dim name As String
    '    Select Case TreeView1.SelectedNode.Text.ToString
    '        Case "Informazioni sul software"
    '            name = TreeView1.SelectedNode.Text.ToString
    '            If Me.Contains(AboutBox1) Then
    '                Dim NewMDIChild As New AboutBox1
    '                'Set the Parent Form of the Child window.
    '                NewMDIChild.MdiParent = Me
    '                'Display the new form.
    '                NewMDIChild.Show()
    '                ''controllo istanza
    '                'Dim frm As New Opzioni
    '                'frm.Show()
    '            End If
    '        Case "AnagraficaStudio"
    '            name = TreeView1.SelectedNode.Text.ToString
    '            If Me.Contains(AnagraficaStudio) Then
    '                Dim NewMDIChild As New AnagraficaStudio
    '                'Set the Parent Form of the Child window.
    '                NewMDIChild.MdiParent = Me
    '                'Display the new form.
    '                NewMDIChild.Show()
    '                ''controllo istanza
    '                'Dim frm As New Opzioni
    '                'frm.Show()
    '            End If

    '        Case "Fornitori"
    '            name = TreeView1.SelectedNode.Text.ToString
    '            If Me.Contains(Fornitori) Then
    '                Dim NewMDIChild As New Fornitori
    '                'Set the Parent Form of the Child window.
    '                NewMDIChild.MdiParent = Me
    '                'Display the new form.
    '                NewMDIChild.Show()
    '                ''controllo istanza
    '                'Dim frm As New Opzioni
    '                'frm.Show()
    '            End If
    '            'Case
    '            'Case
    '            'Case
    '            'Case
    '            'Case
    '            'Case
    '            'Case
    '            'Case
    '            'Case
    '            'Case
    '    End Select
    'End Sub

    Private Sub AnagrafeDeiCondominiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnagrafeDeiCondominiToolStripMenuItem.Click
        Dim NewMDIChild As New Anagrafiche
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()

    End Sub

    Private Sub ArchivioDelleConvocazioniToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArchivioDelleConvocazioniToolStripMenuItem.Click
        Dim NewMDIChild As New Assemblea
        ''Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        ''Display the new form.
        NewMDIChild.Show()

    End Sub

    Private Sub GruppiDiSpesaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GruppiDiSpesaToolStripMenuItem.Click
        Dim NewMDIChild As New Gruppi
        ''Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        ''Display the new form.
        NewMDIChild.Show()

    End Sub

    Private Sub ContiFinanziariToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContiFinanziariToolStripMenuItem.Click
        'Dim NewMDIChild As New ContiFinanziari
        ''Set the Parent Form of the Child window.
        'NewMDIChild.MdiParent = Me
        ''Display the new form.
        'NewMDIChild.Show()

    End Sub

    Private Sub FondiAmmortamentoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FondiAmmortamentoToolStripMenuItem.Click
        Dim NewMDIChild As New Fondi
        ''Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        ''Display the new form.
        NewMDIChild.Show()

    End Sub

    Private Sub AnagraficaCondominioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnagraficaCondominioToolStripMenuItem.Click
        'Dim NewMDIChild As New Immobili
        ''Set the Parent Form of the Child window.
        'NewMDIChild.MdiParent = Me
        ''Display the new form.
        'NewMDIChild.Show()

    End Sub

    Private Sub ArchivioRitenutePerDichiarazioniToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArchivioRitenutePerDichiarazioniToolStripMenuItem.Click
        'Dim NewMDIChild As New W_Ritenute
        ''Set the Parent Form of the Child window.
        'NewMDIChild.MdiParent = Me
        ''Display the new form.
        'NewMDIChild.Show()

    End Sub

    Private Sub TabelleCodiciTributoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabelleCodiciTributoToolStripMenuItem.Click
        'Dim NewMDIChild As New W_Tributi
        ''Set the Parent Form of the Child window.
        'NewMDIChild.MdiParent = Me
        ''Display the new form.
        'NewMDIChild.Show()

    End Sub

    Private Sub CausaliPerLeSpeseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CausaliPerLeSpeseToolStripMenuItem.Click
        'Dim NewMDIChild As New X_Causali
        ''Set the Parent Form of the Child window.
        'NewMDIChild.MdiParent = Me
        ''Display the new form.
        'NewMDIChild.Show()

    End Sub

    Private Sub TestiPerIlSollecitoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TestiPerIlSollecitoToolStripMenuItem.Click
        'Dim NewMDIChild As New Z_TestoSollecito
        ''Set the Parent Form of the Child window.
        'NewMDIChild.MdiParent = Me
        ''Display the new form.
        'NewMDIChild.Show()

    End Sub

    Private Sub StrutturaDelCondominioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StrutturaDelCondominioToolStripMenuItem.Click
        Dim NewMDIChild As New Fabbricati
        ''Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        ''Display the new form.
        NewMDIChild.Show()

    End Sub

    Private Sub ArchivioSpeseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ArchivioSpeseToolStripMenuItem.Click

    End Sub

    Private Sub GiornaleDiCassaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GiornaleDiCassaToolStripMenuItem.Click
        Dim NewMDIChild As New Cassa
        ''Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        ''Display the new form.
        NewMDIChild.Show()

    End Sub

    Private Sub MovimentiDeiContiFinanziariToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MovimentiDeiContiFinanziariToolStripMenuItem.Click
        Dim NewMDIChild As New ContiFinanziari
        ''Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        ''Display the new form.
        NewMDIChild.Show()

    End Sub

    Private Sub CostantiPerAvvisiToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CostantiPerAvvisiToolStripMenuItem.Click
        Dim NewMDIChild As New Costanti
        ''Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        ''Display the new form.
        NewMDIChild.Show()

    End Sub
End Class