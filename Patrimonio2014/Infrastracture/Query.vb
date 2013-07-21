Public Class Query

    Private Structure sintassiSQL
        Shared sel As String = "Select "
        Shared fro As String = "From "
        Shared wher As String = "Where "
        Shared an As String = " And "
        Shared asterisco = "*"
        Shared ug As String = "= "
        Shared at As String = "@"
    End Structure

    ''' <summary>
    ''' Metodo dinamico di cotruzione della query di select
    ''' </summary>
    ''' <param name="param"></param>
    ''' <param name="tab"></param>
    ''' <remarks></remarks>
    Public Function QuerySelect(ByVal param() As String, ByVal tab() As String, ByVal colum() As String) As OleDb.OleDbDataReader

        Dim strSql As String = ""
        Dim nomePar As String = ""

        strSql = sintassiSQL.sel & sintassiSQL.asterisco & sintassiSQL.fro & tab.ToString

        Try
            If IsNothing(param) Then

                'eseguo query
                MsgBox("")

            Else

                Dim indParam As Integer

                strSql = strSql & sintassiSQL.wher
                For Each c In colum
                    If indParam > 0 Then strSql = strSql & sintassiSQL.an
                    strSql = strSql & c.ToString & sintassiSQL.ug
                    nomePar = sintassiSQL.at & c.ToString
                    strSql = strSql & nomePar
                    indParam = indParam + 1
                Next
                Return DBlayerAC.ExQuery(strSql, param, nomePar)

            End If

        Catch ex As Exception

            MsgBox(ex.ToString)

        End Try

    End Function
End Class
