﻿Public Class MainForm

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
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
        'controllo istanza
        ''Dim frm As New AnagraficaStudio
        ''frm.Show()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Public Sub New()

        ' Chiamata richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

    End Sub

   
    Private Sub TreeView1_NodeMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick
        MsgBox(TreeView1.SelectedNode.Name.ToString)
    End Sub

    Private Sub AnagrafeDeiCondominiToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AnagrafeDeiCondominiToolStripMenuItem.Click
        Dim NewMDIChild As New Anagrafiche
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()

    End Sub

    Private Sub ArchivioDelleConvocazioniToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ArchivioDelleConvocazioniToolStripMenuItem.Click
        Dim NewMDIChild As New Assemblea
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()

    End Sub

    Private Sub GruppiDiSpesaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GruppiDiSpesaToolStripMenuItem.Click
        Dim NewMDIChild As New Gruppi
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()

    End Sub

    Private Sub ContiFinanziariToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ContiFinanziariToolStripMenuItem.Click
        Dim NewMDIChild As New ContiFinanziari
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()

    End Sub

    Private Sub FondiAmmortamentoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FondiAmmortamentoToolStripMenuItem.Click
        Dim NewMDIChild As New Fondi
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()

    End Sub

    Private Sub AnagraficaCondominioToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AnagraficaCondominioToolStripMenuItem.Click
        Dim NewMDIChild As New Immobili
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()

    End Sub
End Class