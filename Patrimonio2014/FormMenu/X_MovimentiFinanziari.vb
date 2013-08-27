Public Class X_MovimentiFinanziari

    Private Sub X_MovimentiFinanziariBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles X_MovimentiFinanziariBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.X_MovimentiFinanziariBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet2)

    End Sub

    Private Sub X_MovimentiFinanziari_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.X_MovimentiFinanziari'. È possibile spostarla o rimuoverla se necessario.
        Me.X_MovimentiFinanziariTableAdapter.Fill(Me.IMMOBILIDataSet2.X_MovimentiFinanziari)

    End Sub
End Class