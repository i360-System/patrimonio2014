﻿Imports System.Data.OleDb

Public Class Y_GestioniUnita

    Private Sub Y_GestioniUnitaBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles Y_GestioniUnitaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Y_GestioniUnitaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet2)

    End Sub

    Private Sub Y_GestioniUnita_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.Y_GestioniUnitaDettaglio'. È possibile spostarla o rimuoverla se necessario.
        Me.Y_GestioniUnitaDettaglioTableAdapter.Fill(Me.IMMOBILIDataSet2.Y_GestioniUnitaDettaglio)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.Y_GestioniUnita'. È possibile spostarla o rimuoverla se necessario.
        Me.Y_GestioniUnitaTableAdapter.Fill(Me.IMMOBILIDataSet2.Y_GestioniUnita)
        CreaCombo("Immobili", "SELECT Immobile, (Immobile + ' - ' + Denominazione) AS DescrizioneImmobile FROM Immobili", ImmobileComboBox)

    End Sub
    Private Sub CreaCombo(ByVal NomeTab As String, ByVal query As String, ByRef combo As ComboBox)
        Dim cn As New OleDbConnection(My.Settings.IMMOBILIConnectionString.ToString)
        cn.Open()

        Dim command As New OleDbCommand(query, cn)
        Dim da As New OleDbDataAdapter
        da.SelectCommand = command

        Dim ds As New DataSet(NomeTab)
        ds.Clear()
        da.Fill(ds, NomeTab)

        combo.DisplayMember = "DescrizioneImmobile"
        combo.ValueMember = "Immobile"
        combo.DataSource = ds.Tables(NomeTab)
        cn.Close()
    End Sub

    Private Sub ImmobileComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ImmobileComboBox.SelectedIndexChanged
        ImmobileComboBox.Text = ImmobileComboBox.SelectedValue

    End Sub
End Class