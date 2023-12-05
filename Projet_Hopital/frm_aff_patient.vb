Public Class frm_aff_patient
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

    Private Sub frm_aff_patient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        afficher(dgv)

    End Sub

    Private Sub btn_supprimer_pat_Click(sender As Object, e As EventArgs) Handles btn_supprimer_pat.Click
        Dim i As Integer
        i = dgv.SelectedCells(0).RowIndex

        dgv.Rows.RemoveAt(i)
        MessageBox.Show("suppression de patient avec succée")
    End Sub
End Class