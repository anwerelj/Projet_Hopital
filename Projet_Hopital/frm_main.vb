Public Class frm_main
    Private Sub AjouterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjouterToolStripMenuItem.Click

        frm_ajout_patient.MdiParent = Me
        frm_ajout_patient.Show()
    End Sub

    Private Sub RendezVousToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AjouterToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AjouterToolStripMenuItem1.Click
        frm_ajouterrdv.MdiParent = Me
        frm_ajouterrdv.Show()
    End Sub

    Private Sub AfficherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AfficherToolStripMenuItem.Click
        frm_aff_patient.MdiParent = Me

        frm_aff_patient.Show()
    End Sub

    Private Sub AfficherToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AfficherToolStripMenuItem1.Click
        afficher_rendez_vous.MdiParent = Me
        afficher_rendez_vous.Show()
    End Sub
End Class
