Public Class V_Preventivo

    Private Sub V_PreventivoBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles V_PreventivoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.V_PreventivoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet2)

    End Sub

    Private Sub V_Preventivo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.V_PreventivoDettaglio'. È possibile spostarla o rimuoverla se necessario.
        Me.V_PreventivoDettaglioTableAdapter.Fill(Me.IMMOBILIDataSet2.V_PreventivoDettaglio)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.V_Preventivo'. È possibile spostarla o rimuoverla se necessario.
        Me.V_PreventivoTableAdapter.Fill(Me.IMMOBILIDataSet2.V_Preventivo)

    End Sub

    Private Sub GruppoLabel_Click(sender As System.Object, e As System.EventArgs)

    End Sub
End Class