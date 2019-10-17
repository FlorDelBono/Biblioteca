<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicial
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
        Me.btnABM = New System.Windows.Forms.Button()
        Me.btnLibros = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnConsultaLibros = New System.Windows.Forms.Button()
        Me.btnConsultaClientes = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnABM
        '
        Me.btnABM.Location = New System.Drawing.Point(222, 26)
        Me.btnABM.Name = "btnABM"
        Me.btnABM.Size = New System.Drawing.Size(289, 29)
        Me.btnABM.TabIndex = 0
        Me.btnABM.Text = "AGREGAR, MODIFICAR Y ELIMINAR REGISTROS"
        Me.btnABM.UseVisualStyleBackColor = True
        '
        'btnLibros
        '
        Me.btnLibros.Location = New System.Drawing.Point(306, 80)
        Me.btnLibros.Name = "btnLibros"
        Me.btnLibros.Size = New System.Drawing.Size(109, 23)
        Me.btnLibros.TabIndex = 1
        Me.btnLibros.Text = "VER LIBROS "
        Me.btnLibros.UseVisualStyleBackColor = True
        '
        'btnClientes
        '
        Me.btnClientes.Location = New System.Drawing.Point(306, 131)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(109, 23)
        Me.btnClientes.TabIndex = 2
        Me.btnClientes.Text = "VER CLIENTES"
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'btnConsultaLibros
        '
        Me.btnConsultaLibros.Location = New System.Drawing.Point(264, 183)
        Me.btnConsultaLibros.Name = "btnConsultaLibros"
        Me.btnConsultaLibros.Size = New System.Drawing.Size(199, 23)
        Me.btnConsultaLibros.TabIndex = 3
        Me.btnConsultaLibros.Text = "CONSULTA DE LIBROS"
        Me.btnConsultaLibros.UseVisualStyleBackColor = True
        '
        'btnConsultaClientes
        '
        Me.btnConsultaClientes.Location = New System.Drawing.Point(264, 250)
        Me.btnConsultaClientes.Name = "btnConsultaClientes"
        Me.btnConsultaClientes.Size = New System.Drawing.Size(199, 23)
        Me.btnConsultaClientes.TabIndex = 4
        Me.btnConsultaClientes.Text = "CONSULTA DE CLIENTES"
        Me.btnConsultaClientes.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(319, 300)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmInicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnConsultaClientes)
        Me.Controls.Add(Me.btnConsultaLibros)
        Me.Controls.Add(Me.btnClientes)
        Me.Controls.Add(Me.btnLibros)
        Me.Controls.Add(Me.btnABM)
        Me.Name = "frmInicial"
        Me.Text = "Menu Inicial"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnABM As Button
    Friend WithEvents btnLibros As Button
    Friend WithEvents btnClientes As Button
    Friend WithEvents btnConsultaLibros As Button
    Friend WithEvents btnConsultaClientes As Button
    Friend WithEvents btnSalir As Button
End Class
