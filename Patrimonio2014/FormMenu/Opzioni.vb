Imports System.Windows.Forms

Public Class Opzioni

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Dispose()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialogPathDB.ShowDialog()
        percorsoDB.Text = OpenFileDialogPathDB.FileName
    End Sub

    Private Sub OpenFileDialogPathDB_FileOk(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialogPathDB.FileOk

    End Sub

    Public Sub New()

        ' Chiamata richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        percorsoDB.Text = My.Settings.StringaConnessione

    End Sub
End Class
