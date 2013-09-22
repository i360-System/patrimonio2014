﻿Imports System.Data.OleDb

Public Class X_MovimentiFinanziari

    Private Sub X_MovimentiFinanziariBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles X_MovimentiFinanziariBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.X_MovimentiFinanziariBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet2)

    End Sub

    Private Sub X_MovimentiFinanziari_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.X_MovimentiFinanziari'. È possibile spostarla o rimuoverla se necessario.
        Me.X_MovimentiFinanziariTableAdapter.Fill(Me.IMMOBILIDataSet2.X_MovimentiFinanziari)
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