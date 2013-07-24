Public Class ContiFinanziari

    Private Sub ContiFinanziariBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ContiFinanziariBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet)

    End Sub

    Private Sub ContiFinanziari_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.ContiFinanziari'. È possibile spostarla o rimuoverla se necessario.
        Me.ContiFinanziariTableAdapter.Fill(Me.IMMOBILIDataSet.ContiFinanziari)

    End Sub
End Class