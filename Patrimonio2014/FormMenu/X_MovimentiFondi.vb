Imports System.Data.OleDb

Public Class X_MovimentiFondi

    Private Sub X_MovimentiFondiBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles X_MovimentiFondiBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.X_MovimentiFondiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet2)

    End Sub

    Private Sub X_MovimentiFondi_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.X_MovimentiFondi'. È possibile spostarla o rimuoverla se necessario.
        Me.X_MovimentiFondiTableAdapter.Fill(Me.IMMOBILIDataSet2.X_MovimentiFondi)
        CreaCombo("Immobili", "SELECT Immobile, (Immobile + ' - ' + Denominazione) AS DescrizioneImmobile FROM Immobili", ImmobileComboBox, "DescrizioneImmobile", "Immobile")
        CreaCombo("Fondi", "SELECT Fondo, (Fondo + ' - ' + Denominazione) AS DescrizioneFondo FROM Fondi WHERE Immobile='" & ImmobileComboBox.Text & "'", FondoComboBox, "DescrizioneFondo", "Fondo")

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
End Class