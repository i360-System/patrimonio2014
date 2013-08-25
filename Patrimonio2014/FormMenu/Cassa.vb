Public Class Cassa

    Private Sub CassaBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles CassaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CassaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet2)

    End Sub

    Private Sub Cassa_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.Cassa'. È possibile spostarla o rimuoverla se necessario.
        Me.CassaTableAdapter.Fill(Me.IMMOBILIDataSet2.Cassa)

    End Sub
End Class