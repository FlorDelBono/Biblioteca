
Imports System.Data.OleDb
Public Class frmABMLibros

    Dim Dt As New DataTable
    Dim Da As New OleDb.OleDbDataAdapter
    Dim Sqlstr As String
    Dim NroReg As Integer
    Dim CantReg As Integer

    Private Sub frmABMLibros_Load(sender As Object, e As EventArgs) Handles Me.Load
        nroreg = 0
        Conexion_biblioteca.Open()

        Sqlstr = "Select * from LIBROS  "

        'SELECT LIBROS.*, LIBROS.[CODIGO LIBRO], LIBROS.NOMBRE, LIBROS.AUTOR, LIBROS.[ANOPUBLI], LIBROS.DISPONIBLE, LIBROS.IDIOMA, LIBROS.GENERO
        'From LIBROS;


        Da = New OleDb.OleDbDataAdapter(Sqlstr, Conexion_biblioteca.ConnectionString)

        Dt.Clear()
        Da.Fill(Dt)
        Conexion_biblioteca.Close()
        llenartxt()

    End Sub

    Private Sub llenartxt()

        txtCodigodeLibro.Text = Dt.Rows(NroReg)("CODIGO")

        txtNombredelLibro.Text = Dt.Rows(NroReg)("NOMBRE")

        txtAutor.Text = Dt.Rows(NroReg)("AUTOR")

        rbtDisponibilidad.Checked = Dt.Rows(NroReg)("DISPONIBLE")

        txtAñodePublicacion.Text = Dt.Rows(NroReg)("ANOPUBLI")

        cmbIdiomas.Text = Dt.Rows(NroReg)("IDIOMA")

        txtGenero.Text = Dt.Rows(NroReg)("GENERO")



    End Sub

    Private Sub btnPrimerRegistro_Click(sender As Object, e As EventArgs) Handles btnPrimerRegistro.Click
        NroReg = 0
        llenartxt()
    End Sub

    Private Sub btnUltimoRegistro_Click(sender As Object, e As EventArgs) Handles btnUltimoRegistro.Click
        CantReg = Dt.Rows.Count
        NroReg = CantReg - 1

        llenartxt()


    End Sub

    Private Sub bntAnterior_Click(sender As Object, e As EventArgs) Handles bntAnterior.Click

        Try
            NroReg = NroReg - 1
            llenartxt()

        Catch ex As Exception
            NroReg = NroReg + 1
            llenartxt()
        End Try
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Try
            NroReg = NroReg + 1
            llenartxt()
        Catch ex As Exception
            NroReg = NroReg - 1
            llenartxt()
        End Try


    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click


        Dim Comando_Borrar As New OleDbCommand()

        Sqlstr = "delete * From LIBROS Where CODIGO= " & txtCodigodeLibro.Text


        If MsgBox("¿estas seguro de borrar este registro?", MsgBoxStyle.YesNo, "ATENCION") = MsgBoxResult.Yes Then


            Comando_Borrar.CommandText = Sqlstr
            Comando_Borrar.Connection = Conexion_biblioteca

            Conexion_biblioteca.Open()
            Comando_Borrar.ExecuteNonQuery()

            MessageBox.Show("se a eliminado un registro")

            Da = New OleDbDataAdapter("select * from LIBROS order by CODIGO", Conexion_biblioteca.ConnectionString)

            Dt.Clear()
            Da.Fill(Dt)

            NroReg = 0
            llenartxt()
            Conexion_biblioteca.Close()
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        btnConfirmar.Enabled = True
        btnAgregar.Visible = False


        grpBotones.Enabled = False
        txtCodigodeLibro.ReadOnly = False
        txtNombredelLibro.ReadOnly = False
        txtAñodePublicacion.ReadOnly = False
        txtGenero.ReadOnly = False
        txtAutor.ReadOnly = False
        cmbIdiomas.Enabled = True
        rbtDisponibilidad.Checked = False

        txtCodigodeLibro.Text = ""
        txtNombredelLibro.Text = ""
        txtAñodePublicacion.Text = ""
        txtGenero.Text = ""
        txtAutor.Text = ""
        rbtDisponibilidad.Checked = False

        btnModificar.Enabled = False
        btnEliminar.Enabled = False


    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click

        'valido campos
        '*************************


        grpBotones.Enabled = True
        txtCodigodeLibro.Visible = True
        txtNombredelLibro.Visible = True
        txtAñodePublicacion.Visible = True
        txtGenero.Visible = True
        txtAutor.Visible = True
        cmbIdiomas.Visible = True
        rbtDisponibilidad.Checked = True




        'valido codigos


        If IsNumeric(txtCodigodeLibro.Text) Then
        Else
            MessageBox.Show("El codigo debe ser numérico", "Atención")
            txtCodigodeLibro.Clear()
            txtCodigodeLibro.Focus()
            Exit Sub
        End If




        If IsNumeric(txtAñodePublicacion.Text) Then
        Else
            MessageBox.Show("El Año de Publicacion debe ser un número", "Atención")
            txtAñodePublicacion.Clear()
            txtAñodePublicacion.Focus()
            Exit Sub
        End If


        Dim sqlstring As String
        Dim comandoinsertar As New OleDbCommand

        If MsgBox("Confirma los valores a agregar ?", MsgBoxStyle.YesNo, "Atencion") = MsgBoxResult.Yes Then

            txtCodigodeLibro.Text = Strings.UCase(txtCodigodeLibro.Text)


            sqlstring = "Insert Into LIBROS(CODIGO,NOMBRE,AUTOR,ANOPUBLI,DISPONIBLE,IDIOMA,GENERO) " _
                  & " Values (" _
                  & "'" & txtCodigodeLibro.Text & "', " _
                  & "'" & txtNombredelLibro.Text & "', " _
                  & "'" & txtAutor.Text & "', " _
                  & "'" & txtAñodePublicacion.Text & "', " _
                  & "'" & rbtDisponibilidad.Checked & "', " _
                  & "'" & cmbIdiomas.Text & "', " _
                  & "'" & txtGenero.Text & "') "


            comandoinsertar.CommandText = sqlstring


            comandoinsertar.Connection = Conexion_biblioteca

            Conexion_biblioteca.Open()
            comandoinsertar.ExecuteNonQuery()



            'Dt.Clear()

            '  Da.Fill(Dt)

            'llenartxt()

            Conexion_biblioteca.Close()



            ' Catch err As System.Exception


            'MessageBox.Show("El CODIGO  está duplicado", "ERROR", MessageBoxButtons.OK)
            'NroReg = 0
            ' llenartxt()


            btnAgregar.Visible = True
            btnConfirmar.Visible = False
            btnConfirmar.Visible = True
            btnAgregar.Visible = True
            grpBotones.Enabled = True
            txtCodigodeLibro.Visible = True
            txtNombredelLibro.Visible = True
            txtAñodePublicacion.Visible = True
            txtGenero.Visible = True
            txtAutor.Visible = True
            cmbIdiomas.Enabled = True
            rbtDisponibilidad.Checked = True
            btnEliminar.Enabled = True
            btnModificar.Enabled = True
            btnConfirmar.Visible = True











            ' txtGenero.ReadOnly = True
            '  TxtBasico.ReadOnly = True
            'txtCodigodeLibro.ReadOnly = True
            'TxtFechIng.ReadOnly = True
            'TxtNombre.ReadOnly = True
            ''TxtPremio.ReadOnly = True
            'ChkCasado.Enabled = False

            ' GrpBotones.Enabled = True
            '   btnModificar.Enabled = True
            '  btnEliminar.Enabled = True

            'Try
            Conexion_biblioteca.Close()
            ' Catch ex As Exception

            'End Try


            'Exit Sub


            '   End Try


            ' Else




            'Try
            Conexion_biblioteca.Open()

            ' Catch ex As Exception

            ' End Try

            Da = New OleDb.OleDbDataAdapter("SELECT * from LIBROS order by CODIGO", Conexion_biblioteca.ConnectionString)

            Dt.Clear()

            Da.Fill(Dt)
            llenartxt()


        End If

        btnConfirmar.Visible = True
        btnAgregar.Visible = True

        grpBotones.Enabled = True
        txtCodigodeLibro.Visible = True
        txtNombredelLibro.Visible = True
        txtAñodePublicacion.Visible = True
        txtGenero.Visible = True
        txtAutor.Visible = True
        cmbIdiomas.Enabled = True
        rbtDisponibilidad.Checked = True


        grpBotones.Enabled = True
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
        Conexion_biblioteca.Close()

        'btnBuscarFoto.Visible = False




    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        btnModificar.Visible = False
        btnConfirmar.Enabled = True
        btnConfModificar.Enabled = True




        '  btnBuscarFoto.Visible = True

        txtCodigodeLibro.ReadOnly = False
        txtGenero.ReadOnly = False
        txtAutor.ReadOnly = False
        txtAñodePublicacion.ReadOnly = False
        cmbIdiomas.Visible = True
        rbtDisponibilidad.Enabled = True



        grpBotones.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        btnAgregar.Enabled = False





    End Sub

    Private Sub btnConfModificar_Click(sender As Object, e As EventArgs) Handles btnConfModificar.Click


        'VALIDAR CAMPOS


        ' If IsNumeric(txtAñodePublicacion.Text) Then

        'ssageBox.Show("El año de publicación debe ser numérico")
        'txtAñodePublicacion.Clear()
        ' txtAñodePublicacion.Focus()


        '  Exit Sub
        '  End If

        If IsNumeric(txtCodigodeLibro.Text) Then
        Else
            MessageBox.Show("el codigo de libro debe ser numérico")
            txtCodigodeLibro.Focus()
            txtCodigodeLibro.Clear()

        End If

        If MsgBox("Confirma los valores modificados ?", MsgBoxStyle.YesNo, "Atencion") = MsgBoxResult.Yes Then


            txtCodigodeLibro.Text = Strings.UCase(Trim(txtCodigodeLibro.Text))


            Dim ComandoMioUpdate As New OleDbCommand()





            Conexion_biblioteca.Open()


            Sqlstr = "update LIBROS set " _
             & "CODIGO=" & "'" & txtCodigodeLibro.Text & "', " _
             & "NOMBRE=" & "'" & txtNombredelLibro.Text & "', " _
             & "AUTOR=" & "'" & txtAutor.Text & "', " _
             & "ANOPUBLI=" & "'" & txtAñodePublicacion.Text & "', " _
             & "DISPONIBLE=" & "'" & rbtDisponibilidad.Checked & "', " _
             & "IDIOMA=" & "'" & cmbIdiomas.Enabled & "', " _
              & "GENERO= " & "'" & txtGenero.Text & "' where LIBROS = " & txtCodigodeLibro.Text






            ComandoMioUpdate.CommandText = Sqlstr


            ComandoMioUpdate.Connection = Conexion_biblioteca




            ComandoMioUpdate.ExecuteNonQuery()

            Dt.Clear()

            Da.Fill(Dt)








        Else
            Da = New OleDb.OleDbDataAdapter("SELECT * from LIBROS order by CODIGO", Conexion_biblioteca.ConnectionString)

            Dt.Clear()

            Da.Fill(Dt)

            llenartxt()

        End If




        btnConfModificar.Visible = False
        btnModificar.Visible = True
        txtAñodePublicacion.ReadOnly = True
        txtCodigodeLibro.ReadOnly = True
        txtGenero.ReadOnly = True
        txtNombredelLibro.ReadOnly = True
        rbtDisponibilidad.Enabled = True
        cmbIdiomas.Enabled = True



        grpBotones.Visible = True
        btnModificar.Visible = True
        btnEliminar.Visible = True
        btnAgregar.Visible = True

        Conexion_biblioteca.Close()

        ' btnBuscarFoto.Visible = False



        Da = New OleDb.OleDbDataAdapter("SELECT * from LIBROS order by CODIGO", Conexion_biblioteca.ConnectionString)

        Dt.Clear()

        Da.Fill(Dt)
        llenartxt()

    End Sub


End Class










