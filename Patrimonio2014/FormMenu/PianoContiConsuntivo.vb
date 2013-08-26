Public Class PianoContiConsuntivo

    Private Sub PianoContiConsuntivoBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles PianoContiConsuntivoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PianoContiConsuntivoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet2)

    End Sub

    Private Sub PianoContiConsuntivo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.PianoContiConsuntivoDettaglio'. È possibile spostarla o rimuoverla se necessario.
        Me.PianoContiConsuntivoDettaglioTableAdapter.Fill(Me.IMMOBILIDataSet2.PianoContiConsuntivoDettaglio)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.PianoContiConsuntivo'. È possibile spostarla o rimuoverla se necessario.
        Me.PianoContiConsuntivoTableAdapter.Fill(Me.IMMOBILIDataSet2.PianoContiConsuntivo)

    End Sub
End Class