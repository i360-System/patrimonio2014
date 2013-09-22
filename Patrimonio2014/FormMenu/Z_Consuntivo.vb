Imports System.Data.OleDb

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
        CreaCombo("Immobili", "SELECT Immobile, (Immobile + ' - ' + Denominazione) AS DescrizioneImmobile FROM Immobili", ImmobileComboBox, "DescrizioneImmobile", "Immobile")

    End Sub
    Private Sub CreaCombo(ByVal NomeTab As String, ByVal query As String, ByRef combo As ComboBox, DisplayMember As String, ValueMember As String)
        Dim cn As New OleDbConnection(My.Settings.IMMOBILIConnectionString.ToString)
        cn.Open()

        Dim command As New OleDbCommand(query, cn)
        Dim da As New OleDbDataAdapter
        da.SelectCommand = command

        Dim ds As New DataSet(NomeTab)
        ds.Clear()
        da.Fill(ds, NomeTab)

        combo.DisplayMember = DisplayMember
        combo.ValueMember = ValueMember
        combo.DataSource = ds.Tables(NomeTab)
        cn.Close()
    End Sub

    Private Sub ImmobileComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ImmobileComboBox.SelectedIndexChanged
        ImmobileComboBox.Text = ImmobileComboBox.SelectedValue

    End Sub
End Class