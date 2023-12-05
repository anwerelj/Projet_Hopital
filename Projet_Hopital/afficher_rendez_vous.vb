Public Class afficher_rendez_vous
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub afficher_rendez_vous_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        afficherrdv(dgvr)
    End Sub

    Private Sub dgvr_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvr.CellContentClick

    End Sub

    Private Sub btn_annuler_rdv_Click(sender As Object, e As EventArgs) Handles btn_annuler_rdv.Click
        Dim i As Integer
        i = dgvr.SelectedCells(0).RowIndex

        dgvr.Rows.RemoveAt(i)
        MessageBox.Show("annulation de rendez vous avec succée")
    End Sub
End Class