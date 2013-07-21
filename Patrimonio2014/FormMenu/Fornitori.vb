Public Class Fornitori

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim ric As New ToolBarComune
        Dim dr = ric.Ricerca(Me)
        If Not IsNothing(dr) Then
            Interactive.populate(Me, dr)
        Else

        End If
    End Sub


End Class