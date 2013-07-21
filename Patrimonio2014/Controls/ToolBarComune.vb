Public Class ToolBarComune
    Inherits Query
    ''' <summary>
    ''' Metodo di ricerca query
    ''' </summary>
    ''' <param name="frm">parametri e tabella</param>
    ''' <remarks></remarks>
    Public Sub Ricerca(ByRef frm As Form)

        Dim index As Integer
        Dim param(), Tab() As String

        'metodo set pulsanti barra

        'Build query
        For Each tb As TextBox In frm.Controls.OfType(Of TextBox)()
            If Not IsNothing(tb) Then
                param(index) = tb.Name.ToString
                Tab(index) = frm.Name.ToString
                index = index + 1
            End If
        Next
        If index > 0 Then QuerySelect(param, Tab) 'if >0 call query

    End Sub

    Public Sub elimina()

    End Sub

    Public Sub aggiorna()

    End Sub

End Class
