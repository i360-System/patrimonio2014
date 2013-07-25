Public Class V_Preventivo

    Private Sub V_PreventivoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.V_PreventivoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet)

    End Sub

    Private Sub V_Preventivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.V_PreventivoDettaglio'. È possibile spostarla o rimuoverla se necessario.
        Me.V_PreventivoDettaglioTableAdapter.Fill(Me.IMMOBILIDataSet.V_PreventivoDettaglio)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.V_Preventivo'. È possibile spostarla o rimuoverla se necessario.
        Me.V_PreventivoTableAdapter.Fill(Me.IMMOBILIDataSet.V_Preventivo)

    End Sub
End Class