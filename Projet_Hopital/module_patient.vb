Module module_patient
    Public Structure patient
        Dim code As Integer
        Dim nom As String
        Dim prenom As String
    End Structure
    Dim patients(100) As patient
    Dim nb As Integer
    Public Function existe(p As patient) As Boolean
        Dim j As Integer
        j = 0
        While ((j < nb) And (patients(j).code <> p.code))
            j = j + 1

        End While
        Return j < nb

    End Function
    Public Function ajoutpatient(p As patient)
        If nb < patients.Length And existe(p) = False Then
            patients(nb) = p
            nb += 1
            Return True
        Else
            Return False
        End If

    End Function
    Public Function afficher(dgv As DataGridView)

        Dim p As patient
        For Each p In patients
            If p.nom IsNot Nothing Then
                dgv.Rows.Add(p.code, p.nom, p.prenom)
            End If
        Next

    End Function


End Module
