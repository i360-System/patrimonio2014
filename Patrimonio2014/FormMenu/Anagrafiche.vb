Public Class Anagrafiche

    Private Sub AnagraficheBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles AnagraficheBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AnagraficheBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet2)

    End Sub

    Private Sub Anagrafiche_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.Anagrafiche'. È possibile spostarla o rimuoverla se necessario.
        Me.AnagraficheTableAdapter.Fill(Me.IMMOBILIDataSet2.Anagrafiche)
        'popolazione del combo immobili
        CreaCombo("Immobili", "SELECT * FROM Immobili", ImmobileComboBox)
    End Sub

    Private Sub DataNascitaLabel_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub CreaCombo(ByVal NomeTab As String, ByVal query As String, ByVal combo As ComboBox)

        Dim cn As New OleDbConnection(strconn)  ' ???????
        cn.Open()

        Dim command As New OleDbCommand(query, cn)
        Dim da As New OleDbDataAdapter

        da.SelectCommand = command

        Dim ds As New DataSet(NomeTab)

        ds.Clear()
        da.Fill(ds, NomeTab)

        combo.DataSource = ds.Tables(NomeTab)
        'combo.DisplayMember = "Nome"

    End Sub
End Class