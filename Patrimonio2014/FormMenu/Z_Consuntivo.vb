Public Class Z_Consuntivo

    Private Sub Z_ConsuntivoBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles Z_ConsuntivoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Z_ConsuntivoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet2)

    End Sub

    Private Sub Z_Consuntivo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.Z_ConsuntivoDettaglio'. È possibile spostarla o rimuoverla se necessario.
        Me.Z_ConsuntivoDettaglioTableAdapter.Fill(Me.IMMOBILIDataSet2.Z_ConsuntivoDettaglio)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.Z_Consuntivo'. È possibile spostarla o rimuoverla se necessario.
        Me.Z_ConsuntivoTableAdapter.Fill(Me.IMMOBILIDataSet2.Z_Consuntivo)

    End Sub
End Class