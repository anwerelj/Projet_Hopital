Public Class frm_ajouterrdv

    Private Sub btn_ajouterr_Click(sender As Object, e As EventArgs) Handles btn_ajouterr.Click

        Dim r As rendezvous
        With r
            r.code = txt_coder.Text
            r.Dat = txt_date.Text
            r.heure = txt_heure.Text

        End With
        If ajoutrdv(r) Then
            MessageBox.Show("Rendez-vous ajouté avec succès")
        Else
            MessageBox.Show("Erreur lors de l'ajout du rendez-vous")
        End If
    End Sub

    Private Sub btn_annulerr_Click(sender As Object, e As EventArgs) Handles btn_annulerr.Click
        txt_coder.Clear()
        txt_date.Clear()
        txt_heure.Clear()

    End Sub

    Private Sub frm_ajouterrdv_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class