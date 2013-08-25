Public Class ContiFinanziari

    Private Sub ContiFinanziariBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles ContiFinanziariBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ContiFinanziariBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet2)

    End Sub

    Private Sub ContiFinanziari_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.ContiFinanziari'. È possibile spostarla o rimuoverla se necessario.
        Me.ContiFinanziariTableAdapter.Fill(Me.IMMOBILIDataSet2.ContiFinanziari)

    End Sub
End Class