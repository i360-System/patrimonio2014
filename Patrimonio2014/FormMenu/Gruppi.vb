Public Class Gruppi

    Private Sub GruppiBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles GruppiBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.GruppiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet2)

    End Sub

    Private Sub Gruppi_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.GruppiDettaglio'. È possibile spostarla o rimuoverla se necessario.
        Me.GruppiDettaglioTableAdapter.Fill(Me.IMMOBILIDataSet2.GruppiDettaglio)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.Gruppi'. È possibile spostarla o rimuoverla se necessario.
        Me.GruppiTableAdapter.Fill(Me.IMMOBILIDataSet2.Gruppi)

    End Sub
End Class