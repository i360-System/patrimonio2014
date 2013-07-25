Public Class Unita

    Private Sub UnitaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.UnitaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet)

    End Sub

    Private Sub Unita_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.UnitaDettaglioLetture'. È possibile spostarla o rimuoverla se necessario.
        Me.UnitaDettaglioLettureTableAdapter.Fill(Me.IMMOBILIDataSet.UnitaDettaglioLetture)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.UnitaDettaglioMillesimi'. È possibile spostarla o rimuoverla se necessario.
        Me.UnitaDettaglioMillesimiTableAdapter.Fill(Me.IMMOBILIDataSet.UnitaDettaglioMillesimi)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.UnitaDettaglio'. È possibile spostarla o rimuoverla se necessario.
        Me.UnitaDettaglioTableAdapter.Fill(Me.IMMOBILIDataSet.UnitaDettaglio)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.UnitaDettaglioAnagrafica'. È possibile spostarla o rimuoverla se necessario.
        Me.UnitaDettaglioAnagraficaTableAdapter.Fill(Me.IMMOBILIDataSet.UnitaDettaglioAnagrafica)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.Unita'. È possibile spostarla o rimuoverla se necessario.
        Me.UnitaTableAdapter.Fill(Me.IMMOBILIDataSet.Unita)

    End Sub
End Class