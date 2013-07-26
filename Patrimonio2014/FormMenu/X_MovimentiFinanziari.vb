Public Class X_MovimentiFinanziari

    Private Sub X_MovimentiFinanziariBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.X_MovimentiFinanziariBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet)

    End Sub

    Private Sub X_MovimentiFinanziari_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.X_MovimentiFinanziari'. È possibile spostarla o rimuoverla se necessario.
        Me.X_MovimentiFinanziariTableAdapter.Fill(Me.IMMOBILIDataSet.X_MovimentiFinanziari)

    End Sub
End Class