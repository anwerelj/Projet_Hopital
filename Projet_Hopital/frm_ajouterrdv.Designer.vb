<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_ajouterrdv
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_coder = New System.Windows.Forms.TextBox()
        Me.txt_date = New System.Windows.Forms.TextBox()
        Me.txt_heure = New System.Windows.Forms.TextBox()
        Me.btn_ajouterr = New System.Windows.Forms.Button()
        Me.btn_annulerr = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(65, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(65, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(65, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Heure"
        '
        'txt_coder
        '
        Me.txt_coder.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_coder.Location = New System.Drawing.Point(185, 76)
        Me.txt_coder.Name = "txt_coder"
        Me.txt_coder.Size = New System.Drawing.Size(100, 27)
        Me.txt_coder.TabIndex = 3
        '
        'txt_date
        '
        Me.txt_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_date.Location = New System.Drawing.Point(185, 136)
        Me.txt_date.Name = "txt_date"
        Me.txt_date.Size = New System.Drawing.Size(100, 27)
        Me.txt_date.TabIndex = 4
        '
        'txt_heure
        '
        Me.txt_heure.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_heure.Location = New System.Drawing.Point(185, 192)
        Me.txt_heure.Name = "txt_heure"
        Me.txt_heure.Size = New System.Drawing.Size(100, 27)
        Me.txt_heure.TabIndex = 5
        '
        'btn_ajouterr
        '
        Me.btn_ajouterr.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btn_ajouterr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ajouterr.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_ajouterr.Location = New System.Drawing.Point(68, 254)
        Me.btn_ajouterr.Name = "btn_ajouterr"
        Me.btn_ajouterr.Size = New System.Drawing.Size(95, 32)
        Me.btn_ajouterr.TabIndex = 6
        Me.btn_ajouterr.Text = "Ajouter"
        Me.btn_ajouterr.UseVisualStyleBackColor = False
        '
        'btn_annulerr
        '
        Me.btn_annulerr.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btn_annulerr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_annulerr.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_annulerr.Location = New System.Drawing.Point(210, 254)
        Me.btn_annulerr.Name = "btn_annulerr"
        Me.btn_annulerr.Size = New System.Drawing.Size(100, 32)
        Me.btn_annulerr.TabIndex = 7
        Me.btn_annulerr.Text = "Annuler"
        Me.btn_annulerr.UseVisualStyleBackColor = False
        '
        'frm_ajouterrdv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Projet_Hopital.My.Resources.Resources.a
        Me.ClientSize = New System.Drawing.Size(604, 366)
        Me.Controls.Add(Me.btn_annulerr)
        Me.Controls.Add(Me.btn_ajouterr)
        Me.Controls.Add(Me.txt_heure)
        Me.Controls.Add(Me.txt_date)
        Me.Controls.Add(Me.txt_coder)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_ajouterrdv"
        Me.Text = "ajout_rendezvous"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_coder As TextBox
    Friend WithEvents txt_date As TextBox
    Friend WithEvents txt_heure As TextBox
    Friend WithEvents btn_ajouterr As Button
    Friend WithEvents btn_annulerr As Button
End Class
