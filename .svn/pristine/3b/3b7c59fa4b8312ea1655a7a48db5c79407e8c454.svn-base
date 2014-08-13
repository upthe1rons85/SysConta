Imports System.Data.SqlClient
Public Class frmTipoDocumento

    Private Sub frmTipoDocumento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargalista()
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        MaximizeBox = False
        txtCodigo.Enabled = True
        txtDesc.Enabled = False
        BtnGrabar.Enabled = False
        BtnNuevo.Enabled = True
        btnModificar.Enabled = False
        BtnEliminar.Enabled = False
    End Sub

    Private Sub Cargalista()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cn As New SqlConnection
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim consulta As String = "select * from catTipoDocumento"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        da = New SqlDataAdapter
        da.SelectCommand = cmd
        da.Fill(ds, "catTipoDocumento")
        Dim objListItem As New ListViewItem
        Me.lstTipoDoc.Items.Clear()
        For Each drw As DataRow In ds.Tables("catTipoDocumento").Rows
            objListItem = lstTipoDoc.Items.Add(drw.Item("CodigoDocumento").ToString, 0)
            objListItem.SubItems.Add(drw.Item("Descripcion").ToString)
        Next
    End Sub

    Sub Limpiar()
        TxtBuscar.Clear()
        txtCodigo.Clear()
        txtDesc.Clear()
    End Sub

    Private Sub BtnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrabar.Click
        If txtCodigo.Text = "" Or txtDesc.Text = "" Then
            MsgBox("No deben Quedar Datos Vacios..!!!", vbInformation, "Sistema Contable")
            txtCodigo.Focus()
            Cargalista()
        Else
            Try
                Dim cnnConexion = New SqlConnection()
                Dim clsDB = New clsBD()
                cnnConexion = clsDB.CreaConexion()
                Dim commandbus As New SqlCommand("spValidaTipoDocumento", cnnConexion)
                commandbus.CommandType = CommandType.StoredProcedure
                commandbus.Parameters.AddWithValue("@CodigoDocumento", txtCodigo.Text)
                Dim n As Integer
                n = RTrim(commandbus.ExecuteScalar())
                If n > 0 Then
                    Dim pclsTD = New clsTipoDocumento()
                    pclsTD.ActualizaTipoDoc(txtCodigo.Text, txtDesc.Text)
                    MsgBox("Actualizado Correctamente", vbInformation, "Sistema Contable")
                    Limpiar()
                Else
                    Dim sXML = "<xDescDoc>"
                    sXML += "<CodigoDocumento>" + txtCodigo.Text + "</CodigoDocumento>"
                    sXML += "<Descripcion>" + txtDesc.Text + "</Descripcion>"
                    sXML += "</xDescDoc>"
                    Dim pclsTD = New clsTipoDocumento()
                    pclsTD.InsertaDescripcionTipoDoc(sXML)
                    MsgBox("Registrado Correctamente", vbInformation, "Sistema Contable")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                MsgBox("Ocurrio un Error", vbInformation, "Sistema Contable")
            End Try
            txtCodigo.Enabled = True
            txtDesc.Enabled = False
            BtnGrabar.Enabled = False
            BtnNuevo.Enabled = True
            BtnEliminar.Enabled = False
            btnModificar.Enabled = False
            txtCodigo.Focus()
            Limpiar()
            Cargalista()
        End If
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        txtCodigo.Enabled = True
        txtDesc.Enabled = True
        BtnGrabar.Enabled = True
        BtnNuevo.Enabled = False
        btnModificar.Enabled = False
        BtnEliminar.Enabled = False
        txtDesc.Focus()
        Cargalista()
    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        If txtCodigo.Text = "" Then
            MsgBox("Debe capturar un Codigo", vbInformation, "Sistema Contable")
            txtCodigo.Focus()
        Else
            If MessageBox.Show("¿Desea ELIMINAR Registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim oclsTD = New clsTipoDocumento()
                oclsTD.EliminaTipoDoc(txtCodigo.Text)
                MsgBox("Registro Eliminado", vbInformation, "Sistema Contable")
            End If
        End If
        BtnGrabar.Enabled = False
        BtnNuevo.Enabled = True
        btnModificar.Enabled = False
        BtnEliminar.Enabled = False
        txtCodigo.Enabled = True
        txtCodigo.Focus()
        Limpiar()
        Cargalista()
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        TxtBuscar.Text = "Buscar Documento"
        TxtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic)
        txtCodigo.Enabled = True
        txtDesc.Enabled = True
        BtnGrabar.Enabled = True
        BtnNuevo.Enabled = True
        btnModificar.Enabled = False
        BtnEliminar.Enabled = False
        Cargalista()
        txtCodigo.Focus()
    End Sub

    Private Sub lstTipoDoc_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstTipoDoc.MouseDoubleClick
        txtCodigo.Text = lstTipoDoc.SelectedItems(0).SubItems(0).Text
        txtDesc.Text = lstTipoDoc.SelectedItems(0).SubItems(1).Text
        txtCodigo.Enabled = False
        txtDesc.Enabled = False
        btnModificar.Enabled = True
        BtnGrabar.Enabled = False
        BtnEliminar.Enabled = True
        BtnNuevo.Enabled = True
    End Sub

    Private Sub TxtBuscar_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TxtBuscar.MouseClick
        TxtBuscar.Clear()
    End Sub

    Private Sub TxtBuscar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBuscar.KeyPress
        Dim clsBD As New clsBD()
        Dim dr As SqlDataReader
        Dim oclsTD = New clsTipoDocumento()
        dr = oclsTD.BuscaNombreTipoDoc(Me.TxtBuscar.Text)
        Dim dt = New DataTable()
        dt.Load(dr)
        lstTipoDoc.Items.Clear()
        For Each rRow As DataRow In dt.Rows
            Dim lstLista As New ListViewItem(rRow("CodigoDocumento").ToString)
            lstLista.SubItems.Add(rRow("Descripcion").ToString)
            lstTipoDoc.Items.Add(lstLista)
        Next
    End Sub
End Class