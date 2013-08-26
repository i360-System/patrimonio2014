Public Class PianoContiPreventivo

    Private Sub PianoContiPreventivoBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles PianoContiPreventivoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PianoContiPreventivoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet2)

    End Sub

    Private Sub PianoContiPreventivo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.PianoContiPreventivoDettaglio'. È possibile spostarla o rimuoverla se necessario.
        Me.PianoContiPreventivoDettaglioTableAdapter.Fill(Me.IMMOBILIDataSet2.PianoContiPreventivoDettaglio)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.PianoContiPreventivo'. È possibile spostarla o rimuoverla se necessario.
        Me.PianoContiPreventivoTableAdapter.Fill(Me.IMMOBILIDataSet2.PianoContiPreventivo)

    End Sub
End Class