Public Class MainForm

    Private Sub FornitoriToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FornitoriToolStripMenuItem.Click
        'controllo istanza
        Dim frm As New Fornitori
        frm.Show()
    End Sub
End Class