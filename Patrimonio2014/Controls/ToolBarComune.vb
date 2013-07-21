Public Class ToolBarComune
    Inherits Query

    ''' <summary>
    ''' Metodo di ricerca query
    ''' </summary>
    ''' <param name="frm">parametri e tabella</param>
    ''' <remarks></remarks>
    Public Function Ricerca(ByRef frm As Form) As OleDb.OleDbDataReader

        Dim index As Integer
        Dim param(), Tab(), colum() As String

        'metodo set pulsanti barra

        For Each tb As TextBox In frm.Controls
            If (tb.GetType() Is GetType(TextBox)) Then
                If Not IsNothing(tb) Then
                    param(index) = tb.Text
                    Tab(index) = frm.Name.ToString
                    colum(index) = tb.Name.ToString
                    index = index + 1
                End If
            End If
        Next

        If index > 0 Then
            Return QuerySelect(param, Tab, colum) 'if >0 call query
        Else
            MsgBox(Messaggi.InserireValore)
            Return Nothing
        End If



    End Function

    ''' <summary>
    ''' Metodo di eliminazione di un record su database
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub elimina(ByRef frm As Form)

        Dim index As Integer
        Dim param(), Tab() As String

        'se pulsanti barra

        'Build query
        For Each tb As TextBox In frm.Controls.OfType(Of TextBox)()
            If Not IsNothing(tb) Then
                param(index) = tb.Name.ToString
                TAB(index) = frm.Name.ToString
                index = index + 1
            End If
        Next

    End Sub

    ''' <summary>
    ''' Metodo di update su database
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub aggiorna(ByRef frm As Form)

        Dim index As Integer
        Dim param(), Tab() As String

        'set pulsanti barra

        'build query
        For Each tb As TextBox In frm.Controls.OfType(Of TextBox)()
            If Not IsNothing(tb) Then
                param(index) = tb.Name.ToString
                TAB(index) = frm.Name.ToString
                index = index + 1
            End If
        Next

    End Sub

    

End Class
