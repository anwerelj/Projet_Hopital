Module modulerdv

    Public Structure rendezvous
        Dim code As Integer
        Dim heure As String
        Dim Dat As String
    End Structure
    Dim rdvs(100) As rendezvous
    Dim nb As Integer
    Public Function ajoutrdv(q As rendezvous)
        If nb < rdvs.Length Then
            rdvs(nb) = q
            nb += 1
            Return True
        Else
            Return False
        End If

    End Function


    Public Function afficherrdv(dgvr As DataGridView)

        Dim r As rendezvous
        For Each r In rdvs
            If r.Dat IsNot Nothing Then
                dgvr.Rows.Add(r.code, r.Dat, r.heure)
            End If
        Next

    End Function
End Module


