<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class afficher_rendez_vous
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgvr = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_annuler_rdv = New System.Windows.Forms.Button()
        CType(Me.dgvr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvr
        '
        Me.dgvr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvr.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgvr.Location = New System.Drawing.Point(12, 12)
        Me.dgvr.Name = "dgvr"
        Me.dgvr.RowHeadersWidth = 51
        Me.dgvr.RowTemplate.Height = 24
        Me.dgvr.Size = New System.Drawing.Size(649, 358)
        Me.dgvr.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Code"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Date"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Heure"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'btn_annuler_rdv
        '
        Me.btn_annuler_rdv.Location = New System.Drawing.Point(596, 394)
        Me.btn_annuler_rdv.Name = "btn_annuler_rdv"
        Me.btn_annuler_rdv.Size = New System.Drawing.Size(177, 44)
        Me.btn_annuler_rdv.TabIndex = 1
        Me.btn_annuler_rdv.Text = "Annuler le rendez vous"
        Me.btn_annuler_rdv.UseVisualStyleBackColor = True
        '
        'afficher_rendez_vous
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_annuler_rdv)
        Me.Controls.Add(Me.dgvr)
        Me.Name = "afficher_rendez_vous"
        Me.Text = "afficher_rendez_vous"
        CType(Me.dgvr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvr As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents btn_annuler_rdv As Button
End Class
