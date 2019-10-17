
Imports System.Data.OleDb
Public Class frmClientes

    Dim Dt As New DataTable
    Dim Da As New OleDb.OleDbDataAdapter
    Dim Sqlstr As String

    Private Sub frmLibros_Load(sender As Object, e As EventArgs) Handles Me.Load

        Conexion_biblioteca.Open()

        Sqlstr = "Select * from CLIENTES  "

        'SELECT LIBROS.*, LIBROS.[CODIGO LIBRO], LIBROS.NOMBRE, LIBROS.AUTOR, LIBROS.[AÑO DE PUBLICACIÓN], LIBROS.DISPONIBLE, LIBROS.IDIOMA, LIBROS.GENERO
        'From LIBROS;


        Da = New OleDb.OleDbDataAdapter(Sqlstr, Conexion_biblioteca.ConnectionString)

        Dt.Clear()
        Da.Fill(Dt)
        Conexion_biblioteca.Close()
        dgvClientes.DataSource = Dt

    End Sub


End Class
