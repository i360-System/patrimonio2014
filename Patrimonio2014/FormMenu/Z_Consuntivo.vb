Public Class Z_Consuntivo

    Private Sub Z_ConsuntivoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Z_ConsuntivoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet)

    End Sub

    Private Sub Z_Consuntivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.Z_ConsuntivoDettaglio'. È possibile spostarla o rimuoverla se necessario.
        Me.Z_ConsuntivoDettaglioTableAdapter.Fill(Me.IMMOBILIDataSet.Z_ConsuntivoDettaglio)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.Z_Consuntivo'. È possibile spostarla o rimuoverla se necessario.
        Me.Z_ConsuntivoTableAdapter.Fill(Me.IMMOBILIDataSet.Z_Consuntivo)

    End Sub
End Class