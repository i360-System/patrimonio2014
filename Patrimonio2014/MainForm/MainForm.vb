Public Class MainForm

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
        'controllo istanza
        Dim frm As New AnagraficaStudio
        frm.Show()
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
End Class