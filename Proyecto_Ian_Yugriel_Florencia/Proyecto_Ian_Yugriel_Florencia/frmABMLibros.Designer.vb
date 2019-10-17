<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmABMLibros
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblAutor = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblIdiomas = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCodigodeLibro = New System.Windows.Forms.TextBox()
        Me.txtNombredelLibro = New System.Windows.Forms.TextBox()
        Me.txtAutor = New System.Windows.Forms.TextBox()
        Me.txtAñodePublicacion = New System.Windows.Forms.TextBox()
        Me.txtGenero = New System.Windows.Forms.TextBox()
        Me.cmbIdiomas = New System.Windows.Forms.ComboBox()
        Me.rbtDisponibilidad = New System.Windows.Forms.RadioButton()
        Me.btnPrimerRegistro = New System.Windows.Forms.Button()
        Me.bntAnterior = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnUltimoRegistro = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.grpBotones = New System.Windows.Forms.GroupBox()
        Me.btnConfModificar = New System.Windows.Forms.Button()
        Me.grpBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(175, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo de Libro"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(175, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre del Libro"
        '
        'lblAutor
        '
        Me.lblAutor.AutoSize = True
        Me.lblAutor.Location = New System.Drawing.Point(175, 126)
        Me.lblAutor.Name = "lblAutor"
        Me.lblAutor.Size = New System.Drawing.Size(32, 13)
        Me.lblAutor.TabIndex = 2
        Me.lblAutor.Text = "Autor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(175, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Disponible"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(175, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Año de Publicacion"
        '
        'lblIdiomas
        '
        Me.lblIdiomas.AutoSize = True
        Me.lblIdiomas.Location = New System.Drawing.Point(175, 232)
        Me.lblIdiomas.Name = "lblIdiomas"
        Me.lblIdiomas.Size = New System.Drawing.Size(38, 13)
        Me.lblIdiomas.TabIndex = 5
        Me.lblIdiomas.Text = "Idioma"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(175, 280)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Genero"
        '
        'txtCodigodeLibro
        '
        Me.txtCodigodeLibro.Location = New System.Drawing.Point(319, 54)
        Me.txtCodigodeLibro.Name = "txtCodigodeLibro"
        Me.txtCodigodeLibro.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigodeLibro.TabIndex = 7
        '
        'txtNombredelLibro
        '
        Me.txtNombredelLibro.Location = New System.Drawing.Point(319, 91)
        Me.txtNombredelLibro.Name = "txtNombredelLibro"
        Me.txtNombredelLibro.Size = New System.Drawing.Size(100, 20)
        Me.txtNombredelLibro.TabIndex = 8
        '
        'txtAutor
        '
        Me.txtAutor.Location = New System.Drawing.Point(319, 123)
        Me.txtAutor.Name = "txtAutor"
        Me.txtAutor.Size = New System.Drawing.Size(100, 20)
        Me.txtAutor.TabIndex = 9
        '
        'txtAñodePublicacion
        '
        Me.txtAñodePublicacion.Location = New System.Drawing.Point(319, 157)
        Me.txtAñodePublicacion.Name = "txtAñodePublicacion"
        Me.txtAñodePublicacion.Size = New System.Drawing.Size(100, 20)
        Me.txtAñodePublicacion.TabIndex = 10
        '
        'txtGenero
        '
        Me.txtGenero.Location = New System.Drawing.Point(319, 277)
        Me.txtGenero.Name = "txtGenero"
        Me.txtGenero.Size = New System.Drawing.Size(100, 20)
        Me.txtGenero.TabIndex = 11
        '
        'cmbIdiomas
        '
        Me.cmbIdiomas.FormattingEnabled = True
        Me.cmbIdiomas.Items.AddRange(New Object() {"Inglés", "Portugues", "Español"})
        Me.cmbIdiomas.Location = New System.Drawing.Point(319, 229)
        Me.cmbIdiomas.Name = "cmbIdiomas"
        Me.cmbIdiomas.Size = New System.Drawing.Size(121, 21)
        Me.cmbIdiomas.TabIndex = 13
        '
        'rbtDisponibilidad
        '
        Me.rbtDisponibilidad.AutoSize = True
        Me.rbtDisponibilidad.Location = New System.Drawing.Point(319, 192)
        Me.rbtDisponibilidad.Name = "rbtDisponibilidad"
        Me.rbtDisponibilidad.Size = New System.Drawing.Size(14, 13)
        Me.rbtDisponibilidad.TabIndex = 14
        Me.rbtDisponibilidad.TabStop = True
        Me.rbtDisponibilidad.UseVisualStyleBackColor = True
        '
        'btnPrimerRegistro
        '
        Me.btnPrimerRegistro.Location = New System.Drawing.Point(46, 36)
        Me.btnPrimerRegistro.Name = "btnPrimerRegistro"
        Me.btnPrimerRegistro.Size = New System.Drawing.Size(75, 23)
        Me.btnPrimerRegistro.TabIndex = 15
        Me.btnPrimerRegistro.Text = "<<"
        Me.btnPrimerRegistro.UseVisualStyleBackColor = True
        '
        'bntAnterior
        '
        Me.bntAnterior.Location = New System.Drawing.Point(159, 36)
        Me.bntAnterior.Name = "bntAnterior"
        Me.bntAnterior.Size = New System.Drawing.Size(75, 23)
        Me.bntAnterior.TabIndex = 16
        Me.bntAnterior.Text = "<"
        Me.bntAnterior.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(273, 36)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(75, 23)
        Me.btnSiguiente.TabIndex = 17
        Me.btnSiguiente.Text = ">"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnUltimoRegistro
        '
        Me.btnUltimoRegistro.Location = New System.Drawing.Point(368, 36)
        Me.btnUltimoRegistro.Name = "btnUltimoRegistro"
        Me.btnUltimoRegistro.Size = New System.Drawing.Size(75, 23)
        Me.btnUltimoRegistro.TabIndex = 18
        Me.btnUltimoRegistro.Text = ">>"
        Me.btnUltimoRegistro.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(132, 395)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(149, 23)
        Me.btnEliminar.TabIndex = 19
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(319, 395)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(149, 23)
        Me.btnAgregar.TabIndex = 20
        Me.btnAgregar.Text = "AGREGAR"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(499, 397)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(149, 23)
        Me.btnModificar.TabIndex = 21
        Me.btnModificar.Text = "MODIFICAR "
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Enabled = False
        Me.btnConfirmar.Location = New System.Drawing.Point(319, 369)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(149, 23)
        Me.btnConfirmar.TabIndex = 22
        Me.btnConfirmar.Text = "CONFIRMAR AGREGAR"
        Me.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'grpBotones
        '
        Me.grpBotones.Controls.Add(Me.btnPrimerRegistro)
        Me.grpBotones.Controls.Add(Me.bntAnterior)
        Me.grpBotones.Controls.Add(Me.btnSiguiente)
        Me.grpBotones.Controls.Add(Me.btnUltimoRegistro)
        Me.grpBotones.Location = New System.Drawing.Point(146, 303)
        Me.grpBotones.Name = "grpBotones"
        Me.grpBotones.Size = New System.Drawing.Size(460, 71)
        Me.grpBotones.TabIndex = 23
        Me.grpBotones.TabStop = False
        '
        'btnConfModificar
        '
        Me.btnConfModificar.Location = New System.Drawing.Point(499, 369)
        Me.btnConfModificar.Name = "btnConfModificar"
        Me.btnConfModificar.Size = New System.Drawing.Size(149, 23)
        Me.btnConfModificar.TabIndex = 24
        Me.btnConfModificar.Text = "CONFIRMAR MODIFICAR"
        Me.btnConfModificar.UseVisualStyleBackColor = True
        '
        'frmABMLibros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnConfModificar)
        Me.Controls.Add(Me.grpBotones)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.rbtDisponibilidad)
        Me.Controls.Add(Me.cmbIdiomas)
        Me.Controls.Add(Me.txtGenero)
        Me.Controls.Add(Me.txtAñodePublicacion)
        Me.Controls.Add(Me.txtAutor)
        Me.Controls.Add(Me.txtNombredelLibro)
        Me.Controls.Add(Me.txtCodigodeLibro)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblIdiomas)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblAutor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmABMLibros"
        Me.Text = "frmABMLibros"
        Me.grpBotones.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblAutor As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblIdiomas As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCodigodeLibro As TextBox
    Friend WithEvents txtNombredelLibro As TextBox
    Friend WithEvents txtAutor As TextBox
    Friend WithEvents txtAñodePublicacion As TextBox
    Friend WithEvents txtGenero As TextBox
    Friend WithEvents cmbIdiomas As ComboBox
    Friend WithEvents rbtDisponibilidad As RadioButton
    Friend WithEvents btnPrimerRegistro As Button
    Friend WithEvents bntAnterior As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnUltimoRegistro As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents grpBotones As GroupBox
    Friend WithEvents btnConfModificar As Button
End Class
