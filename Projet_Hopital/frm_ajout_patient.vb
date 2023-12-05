Public Class frm_ajout_patient
    Private Sub btn_ajouter_Click(sender As Object, e As EventArgs) Handles btn_ajouter.Click
        Dim p As patient
        With p
            p.code = txt_code.Text
            p.nom = txt_nom.Text
            p.prenom = txt_prenom.Text

        End With
        If ajoutpatient(p) Then
            MessageBox.Show("Patient ajouté avec succès")

        Else
            MessageBox.Show("Erreur lors de l'ajout du patient")
        End If
    End Sub

    Private Sub btn_annuler_Click(sender As Object, e As EventArgs) Handles btn_annuler.Click
        txt_code.Clear()
        txt_nom.Clear()
        txt_prenom.Clear()
    End Sub



End Class