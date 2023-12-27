<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Bienvenidos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnHola = New Button()
        lblBienvenidos = New Label()
        SuspendLayout()
        ' 
        ' btnHola
        ' 
        btnHola.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point)
        btnHola.Location = New Point(126, 171)
        btnHola.Name = "btnHola"
        btnHola.Size = New Size(257, 66)
        btnHola.TabIndex = 0
        btnHola.Text = "Hola"
        btnHola.UseVisualStyleBackColor = True
        ' 
        ' lblBienvenidos
        ' 
        lblBienvenidos.Font = New Font("Segoe UI", 75F, FontStyle.Bold, GraphicsUnit.Point)
        lblBienvenidos.Location = New Point(95, 329)
        lblBienvenidos.Name = "lblBienvenidos"
        lblBienvenidos.Size = New Size(918, 204)
        lblBienvenidos.TabIndex = 1
        lblBienvenidos.Text = "Bienvenidos"
        lblBienvenidos.TextAlign = ContentAlignment.MiddleCenter
        lblBienvenidos.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1072, 683)
        Controls.Add(lblBienvenidos)
        Controls.Add(btnHola)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnHola As Button
    Friend WithEvents lblBienvenidos As Label

End Class
