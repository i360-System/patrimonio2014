Imports System.Data.OleDb

Public Class Y_Gestioni

    Private Sub Y_GestioniBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles Y_GestioniBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Y_GestioniBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet2)

    End Sub

    Private Sub Y_Gestioni_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.Y_GestioniDettaglio'. È possibile spostarla o rimuoverla se necessario.
        Me.Y_GestioniDettaglioTableAdapter.Fill(Me.IMMOBILIDataSet2.Y_GestioniDettaglio)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.Y_Gestioni'. È possibile spostarla o rimuoverla se necessario.
        Me.Y_GestioniTableAdapter.Fill(Me.IMMOBILIDataSet2.Y_Gestioni)
        CreaCombo("Immobili", "SELECT Immobile, (Immobile + ' - ' + Denominazione) AS DescrizioneImmobile FROM Immobili", ImmobileComboBox, "DescrizioneImmobile", "Immobile")
        CreaCombo("Y_Gestioni", "SELECT Gestione, (CStr(Gestione) + ' - ' + Descrizione1) AS DescrizioneGestione FROM Y_Gestioni WHERE Immobile='" & ImmobileComboBox.Text & "'", GestioneComboBox, "DescrizioneGestione", "Gestione")
        CreaCombo("Costanti", "SELECT Tabella, Tabella + ' - ' + Ordinante) AS DescrizioneCostanti FROM Costanti WHERE Immobile='" & ImmobileComboBox.Text & "'", TabellaComboBox, "DescrizioneCostanti", "Tabella")

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

    Private Sub GestioneComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles GestioneComboBox.SelectedIndexChanged
        GestioneComboBox.Text = GestioneComboBox.SelectedValue

    End Sub

    Private Sub TabellaComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles TabellaComboBox.SelectedIndexChanged
        TabellaComboBox.Text = TabellaComboBox.SelectedValue

    End Sub
End Class