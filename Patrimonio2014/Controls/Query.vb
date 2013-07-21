Public Class Query
    Inherits DBlayer

    Dim asterisco = "*"
    ''' <summary>
    ''' Metodo dinamico di cotruzione della query di select
    ''' </summary>
    ''' <param name="param"></param>
    ''' <param name="tab"></param>
    ''' <remarks></remarks>
    Public Sub QuerySelect(ByVal param() As String, ByVal tab() As String)

        Dim query As String = ""

        'costruisco la select
        query = "Select " 'select
        If IsNothing(param) Then
            query = query & asterisco
        Else
            'inserisco param
        End If

    End Sub
End Class
