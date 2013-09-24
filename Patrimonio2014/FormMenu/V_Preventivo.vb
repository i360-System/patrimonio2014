﻿Imports System.Data.OleDb

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
        CreaCombo("Immobili", "SELECT Immobile, (Immobile + ' - ' + Denominazione) AS DescrizioneImmobile FROM Immobili", ImmobileComboBox, "DescrizioneImmobile", "Immobile")
        CreaCombo("Y_Gestioni", "SELECT Gestione, (CStr(Gestione) + ' - ' + Descrizione1) AS DescrizioneGestione FROM Y_Gestioni WHERE Immobile='" & ImmobileComboBox.Text & "'", GestioneComboBox, "DescrizioneGestione", "Gestione")

    End Sub

    Private Sub GruppoLabel_Click(sender As System.Object, e As System.EventArgs)

    End Sub
    Private Sub CreaCombo(ByVal NomeTab As String, ByVal query As String, ByRef combo As ComboBox, DisplayMember As String, ValueMember As String)
        Dim cn As New OleDbConnection(My.Settings.IMMOBILIConnectionString.ToString)
        cn.Open()

        Dim command As New OleDbCommand(query, cn)
        Dim da As New OleDbDataAdapter
        da.SelectCommand = command
        Try
            Dim ds As New DataSet(NomeTab)
            ds.Clear()
            ds.Tables.Add(NomeTab)
            da.Fill(ds, NomeTab)

            combo.DisplayMember = DisplayMember
            combo.ValueMember = ValueMember
            combo.DataSource = ds.Tables(NomeTab)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        cn.Close()
    End Sub

    Private Sub ImmobileComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ImmobileComboBox.SelectedIndexChanged
        ImmobileComboBox.Text = ImmobileComboBox.SelectedValue

    End Sub

    Private Sub V_PreventivoBindingNavigator_RefreshItems(sender As System.Object, e As System.EventArgs) Handles V_PreventivoBindingNavigator.RefreshItems

    End Sub

    Private Sub GestioneComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles GestioneComboBox.SelectedIndexChanged
        GestioneComboBox.Text = GestioneComboBox.SelectedValue

    End Sub
End Class