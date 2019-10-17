Imports System.Data.OleDb
Public Class frmInicial

    Dim Dt As New DataTable
    Dim Da As New OleDb.OleDbDataAdapter
    Dim Sqlstr As String

    Private Sub btnLibros_Click(sender As Object, e As EventArgs) Handles btnLibros.Click

        frmLibros.ShowDialog()

    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click

        frmClientes.Show()

    End Sub











    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        End

    End Sub

    Private Sub btnABM_Click(sender As Object, e As EventArgs) Handles btnABM.Click

        frmABMInicial.ShowDialog()

    End Sub
End Class
