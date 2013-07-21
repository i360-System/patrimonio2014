Module Interactive

    Public Sub populate(ByRef frm As Form, ByVal rd As OleDb.OleDbDataReader)

        For Each ctrl As Control In frm.Controls
            If (ctrl.GetType() Is GetType(TextBox)) Then
                While rd.Read
                    ctrl.Text = rd.Item(ctrl.Name.ToString)
                End While
            End If
        Next

    End Sub

End Module



