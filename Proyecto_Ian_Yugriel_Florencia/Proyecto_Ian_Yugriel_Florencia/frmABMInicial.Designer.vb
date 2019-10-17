<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmABMInicial
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.bntABMLibros = New System.Windows.Forms.Button()
        Me.btnABMClientes = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bntABMLibros
        '
        Me.bntABMLibros.Location = New System.Drawing.Point(200, 167)
        Me.bntABMLibros.Name = "bntABMLibros"
        Me.bntABMLibros.Size = New System.Drawing.Size(135, 63)
        Me.bntABMLibros.TabIndex = 0
        Me.bntABMLibros.Text = "ABM LIBROS"
        Me.bntABMLibros.UseVisualStyleBackColor = True
        '
        'btnABMClientes
        '
        Me.btnABMClientes.Location = New System.Drawing.Point(494, 167)
        Me.btnABMClientes.Name = "btnABMClientes"
        Me.btnABMClientes.Size = New System.Drawing.Size(122, 63)
        Me.btnABMClientes.TabIndex = 1
        Me.btnABMClientes.Text = "ABM CLIENTES"
        Me.btnABMClientes.UseVisualStyleBackColor = True
        '
        'frmABMInicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnABMClientes)
        Me.Controls.Add(Me.bntABMLibros)
        Me.Name = "frmABMInicial"
        Me.Text = "frmABMInicial"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bntABMLibros As Button
    Friend WithEvents btnABMClientes As Button
End Class
