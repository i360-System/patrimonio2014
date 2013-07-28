Module Interactive

    Public Sub populate(ByRef frm As Form, ByVal rd As OleDb.OleDbDataReader)

        For Each ctrl As Control In frm.Controls
            For Each con In ctrl.Controls

                If TypeOf con Is TextBox Then
                    rd.Read()
                    Dim txt As TextBox = con
                    If Not IsNothing(rd.Item(txt.Name.ToString)) Then
                        con.Text = rd.Item(txt.Name.ToString)
                    End If
                End If
            Next
        Next

    End Sub

End Module



