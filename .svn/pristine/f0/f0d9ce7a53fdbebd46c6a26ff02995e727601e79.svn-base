Imports System.Data.OleDb
Public Class frmPolizasImportarExcel

    Private Sub frmPolizasImportarExcel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub btnCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargar.Click
        Try
            Dim strconn As String
            strconn = "Provider=Microsoft.Jet.Oledb.4.0; data source= " + txtArchivo.Text + ";Extended properties=""Excel 8.0;hdr=yes;imex=1"""
            Dim mconn As New OleDbConnection(strconn)
            Dim cadenaConexion As String = _
                "Provider=Microsoft.ACE.OLEDB.12.0;" & _
                "Extended Properties='Excel 12.0 Xml;HDR=Yes;'" & _
                ";Data Source=" & txtArchivo.Text

            Dim sql As String = "SELECT * FROM [Poliza$]"

            'Dim sql As New OleDbDataAdapter("Select * from [Poliza$]", mconn)
            Dim da As New OleDbDataAdapter(sql, mconn)

            Dim dt As New DataTable()
            da.Fill(dt)
            DGVExcel.DataSource = dt

        Catch ex As OleDbException
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub btnArchivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArchivo.Click
        Dim openFD As New OpenFileDialog()
        With openFD
            .Title = "Seleccionar archivos"
            .Filter = "Todos los archivos (*.xlsx)|*.xlsx"
            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                txtArchivo.Text = .FileName
            End If
        End With
    End Sub
End Class