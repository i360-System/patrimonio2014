Public Class Unita

    Private Sub UnitaBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles UnitaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UnitaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet2)

    End Sub

    Private Sub Unita_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.UnitaDettaglioMillesimi'. È possibile spostarla o rimuoverla se necessario.
        Me.UnitaDettaglioMillesimiTableAdapter.Fill(Me.IMMOBILIDataSet2.UnitaDettaglioMillesimi)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.UnitaDettaglioAnagrafica'. È possibile spostarla o rimuoverla se necessario.
        Me.UnitaDettaglioAnagraficaTableAdapter.Fill(Me.IMMOBILIDataSet2.UnitaDettaglioAnagrafica)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.UnitaDettaglioLetture'. È possibile spostarla o rimuoverla se necessario.
        Me.UnitaDettaglioLettureTableAdapter.Fill(Me.IMMOBILIDataSet2.UnitaDettaglioLetture)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.UnitaDettaglio'. È possibile spostarla o rimuoverla se necessario.
        Me.UnitaDettaglioTableAdapter.Fill(Me.IMMOBILIDataSet2.UnitaDettaglio)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.Unita'. È possibile spostarla o rimuoverla se necessario.
        Me.UnitaTableAdapter.Fill(Me.IMMOBILIDataSet2.Unita)

    End Sub
End Class