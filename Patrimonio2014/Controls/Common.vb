Module Common

    Public Function caricaDatiIniziali() As Boolean

        If MsgBox(Message.Messaggi.CaricavalInizialiForm, vbYesNo, Message.titoli.CaricaDatiIni) = vbNo Then
            Return False
        Else
            Return True
        End If

    End Function

End Module
