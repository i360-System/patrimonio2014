Public Class Gruppi

    Private Sub GruppiBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.GruppiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet)

    End Sub

    Private Sub Gruppi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.GruppiDettaglio'. È possibile spostarla o rimuoverla se necessario.
        Me.GruppiDettaglioTableAdapter.Fill(Me.IMMOBILIDataSet.GruppiDettaglio)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.Gruppi'. È possibile spostarla o rimuoverla se necessario.
        Me.GruppiTableAdapter.Fill(Me.IMMOBILIDataSet.Gruppi)

    End Sub
End Class