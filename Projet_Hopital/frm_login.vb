Public Class frm_login
    Private Sub btn_valider_Click(sender As Object, e As EventArgs) Handles btn_valider.Click
        Dim nu As String
        Dim mdp As String
        nu = txt_nom_utilisateur.Text
        mdp = txt_mdp.Text
        If (nu = "admin") And (mdp = "1234") Then
            Me.Hide()
            frm_main.Show()
        Else
            MessageBox.Show("Votre donnéees sont faux")
            txt_mdp.Clear()
            txt_nom_utilisateur.Clear()
        End If
    End Sub

    Private Sub btn_annuler_Click(sender As Object, e As EventArgs) Handles btn_annuler.Click
        txt_mdp.Clear()
        txt_nom_utilisateur.Clear()
    End Sub

    Private Sub txt_mdp_TextChanged(sender As Object, e As EventArgs) Handles txt_mdp.TextChanged

    End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class