Public Class MainForm

    Private Sub FornitoriToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FornitoriToolStripMenuItem.Click
        'controllo istanza
        Dim frm As New Fornitori
        frm.Show()
    End Sub

    Private Sub OpzioniToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpzioniToolStripMenuItem.Click
        'controllo istanza
        Dim frm As New Opzioni
        frm.Show()
    End Sub

    Private Sub SpeseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpeseToolStripMenuItem.Click

    End Sub
End Class