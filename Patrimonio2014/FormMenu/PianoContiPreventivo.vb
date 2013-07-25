Public Class PianoContiPreventivo

    Private Sub PianoContiPreventivoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PianoContiPreventivoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet)

    End Sub

    Private Sub PianoContiPreventivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.PianoContiPreventivoDettaglio'. È possibile spostarla o rimuoverla se necessario.
        Me.PianoContiPreventivoDettaglioTableAdapter.Fill(Me.IMMOBILIDataSet.PianoContiPreventivoDettaglio)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.PianoContiPreventivo'. È possibile spostarla o rimuoverla se necessario.
        Me.PianoContiPreventivoTableAdapter.Fill(Me.IMMOBILIDataSet.PianoContiPreventivo)

    End Sub
End Class