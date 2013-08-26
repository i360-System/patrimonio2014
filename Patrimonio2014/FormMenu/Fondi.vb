Public Class Fondi

    Private Sub FondiBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles FondiBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FondiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet2)

    End Sub

    Private Sub Fondi_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.Fondi'. È possibile spostarla o rimuoverla se necessario.
        Me.FondiTableAdapter.Fill(Me.IMMOBILIDataSet2.Fondi)

    End Sub
End Class