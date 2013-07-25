Public Class PianoContiConsuntivo

    Private Sub PianoContiConsuntivoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PianoContiConsuntivoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet)

    End Sub

    Private Sub PianoContiConsuntivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.PianoContiConsuntivoDettaglio'. È possibile spostarla o rimuoverla se necessario.
        Me.PianoContiConsuntivoDettaglioTableAdapter.Fill(Me.IMMOBILIDataSet.PianoContiConsuntivoDettaglio)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.PianoContiConsuntivo'. È possibile spostarla o rimuoverla se necessario.
        Me.PianoContiConsuntivoTableAdapter.Fill(Me.IMMOBILIDataSet.PianoContiConsuntivo)

    End Sub

    Private Sub PianoContiConsuntivoDettaglioDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PianoContiConsuntivoDettaglioDataGridView.CellContentClick

    End Sub
End Class