Imports WindowsApplication1.clsTools
Imports System.Data.SqlClient
Imports System.Data
Public Class frmImpresoras

    Private Sub frmImpresoras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargalst()
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        MaximizeBox = False
        txtCodigo.Enabled = True
        txtImpresora.Enabled = False
        txtModelo.Enabled = False
        txtConceptoImpX.Enabled = False
        txtConceptoImpY.Enabled = False
        txtConceptoInfX.Enabled = False
        txtConceptoInfY.Enabled = False
        txtConceptoX.Enabled = False
        txtConceptoY.Enabled = False
        txtFechaX.Enabled = False
        txtFechaY.Enabled = False
        txtMontoLtrX.Enabled = False
        txtMontoLtrY.Enabled = False
        txtMontoNumX.Enabled = False
        txtMontoNumY.Enabled = False
        txtNombreX.Enabled = False
        txtNombreY.Enabled = False
        txtPolizaX.Enabled = False
        txtPolizaY.Enabled = False
        BtnGrabarImp.Enabled = False
        BtnNuevo.Enabled = True
        btnModificarImp.Enabled = False
        BtnEliminarImp.Enabled = False
    End Sub
    Private Sub Cargalst()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cn As New SqlConnection
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim consulta As String = "select * from catImpresoras"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        da = New SqlDataAdapter
        da.SelectCommand = cmd
        da.Fill(ds, "catImpresoras")
        Dim objListItem As New ListViewItem
        Me.lstImpresoras.Items.Clear()
        For Each drw As DataRow In ds.Tables("catImpresoras").Rows
            objListItem = lstImpresoras.Items.Add(drw.Item("Codigo").ToString, 0)
            objListItem.SubItems.Add(drw.Item("Descripcion").ToString)
            objListItem.SubItems.Add(drw.Item("Marca_Modelo").ToString)
            objListItem.SubItems.Add(drw.Item("FechaX").ToString)
            objListItem.SubItems.Add(drw.Item("FechaY").ToString)
            objListItem.SubItems.Add(drw.Item("NombreX").ToString)
            objListItem.SubItems.Add(drw.Item("NombreY").ToString)
            objListItem.SubItems.Add(drw.Item("MontoNumX").ToString)
            objListItem.SubItems.Add(drw.Item("MontoNumY").ToString)
            objListItem.SubItems.Add(drw.Item("MontoLtrX").ToString)
            objListItem.SubItems.Add(drw.Item("MontoLtrY").ToString)
            objListItem.SubItems.Add(drw.Item("ConceptoX").ToString)
            objListItem.SubItems.Add(drw.Item("ConceptoY").ToString)
            objListItem.SubItems.Add(drw.Item("ConceptoInfX").ToString)
            objListItem.SubItems.Add(drw.Item("ConceptoInfY").ToString)
            objListItem.SubItems.Add(drw.Item("ConceptoImpX").ToString)
            objListItem.SubItems.Add(drw.Item("ConceptoImpY").ToString)
            objListItem.SubItems.Add(drw.Item("PolizaX").ToString)
            objListItem.SubItems.Add(drw.Item("PolizaY").ToString)
        Next
    End Sub
    Private Sub BtnGrabarImp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrabarImp.Click
        If txtCodigo.Text = "" Or txtImpresora.Text = "" Or txtModelo.Text = "" Or txtFechaX.Text = "" Or txtFechaY.Text = "" Or txtNombreX.Text = "" Or txtNombreY.Text = "" Or txtMontoNumX.Text = "" Or txtMontoNumY.Text = "" Or txtMontoLtrX.Text = "" Or txtMontoLtrY.Text = "" Or txtConceptoX.Text = "" Or txtConceptoY.Text = "" Or txtConceptoInfX.Text = "" Or txtConceptoInfY.Text = "" Or txtConceptoImpX.Text = "" Or txtConceptoImpY.Text = "" Or txtPolizaX.Text = "" Or txtPolizaY.Text = "" Then
            MsgBox("No deben Quedar Datos Vacios..!!!", vbInformation, "Sistema Contable")
            txtCodigo.Focus()
            Cargalst()
        Else
            Try
                Dim cnnConexion = New SqlConnection()
                Dim clsDB = New clsBD()
                cnnConexion = clsDB.CreaConexion()
                Dim commandbus As New SqlCommand("spValidaImpresora", cnnConexion)
                commandbus.CommandType = CommandType.StoredProcedure
                commandbus.Parameters.AddWithValue("@Codigo", txtCodigo.Text)
                Dim n As Integer
                n = RTrim(commandbus.ExecuteScalar())
                If n > 0 Then
                    Dim pclsImp = New clsImpresoras()
                    pclsImp.ActualizaImpresora(txtCodigo.Text, txtImpresora.Text, txtModelo.Text, txtFechaX.Text,
                                               txtFechaY.Text, txtNombreX.Text, txtNombreY.Text, txtMontoNumX.Text,
                                               txtMontoNumY.Text, txtMontoLtrX.Text, txtMontoLtrY.Text, txtConceptoX.Text,
                                               txtConceptoY.Text, txtConceptoInfX.Text, txtConceptoInfY.Text, txtConceptoImpX.Text,
                                            txtConceptoImpY.Text, txtPolizaX.Text, txtPolizaY.Text)
                    MsgBox("Actualizado Correctamente", vbInformation, "Sistema Contable")
                    Limpiar()
                Else
                    Dim sXML = "<xImpresoras>"
                    sXML += "<Codigo>" + txtCodigo.Text + "</Codigo>"
                    sXML += "<Descripcion>" + txtImpresora.Text + "</Descripcion>"
                    sXML += "<Marca_Modelo>" + txtModelo.Text + "</Marca_Modelo>"
                    sXML += "<FechaX>" + txtFechaX.Text + "</FechaX>"
                    sXML += "<FechaY>" + txtFechaY.Text + "</FechaY>"
                    sXML += "<NombreX>" + txtNombreX.Text + "</NombreX>"
                    sXML += "<NombreY>" + txtNombreY.Text + "</NombreY>"
                    sXML += "<MontoNumX>" + txtMontoNumX.Text + "</MontoNumX>"
                    sXML += "<MontoNumY>" + txtMontoNumY.Text + "</MontoNumY>"
                    sXML += "<MontoLtrX>" + txtMontoLtrX.Text + "</MontoLtrX>"
                    sXML += "<MontoLtrY>" + txtMontoLtrY.Text + "</MontoLtrY>"
                    sXML += "<ConceptoX>" + txtConceptoX.Text + "</ConceptoX>"
                    sXML += "<ConceptoY>" + txtConceptoY.Text + "</ConceptoY>"
                    sXML += "<ConceptoInfX>" + txtConceptoInfX.Text + "</ConceptoInfX>"
                    sXML += "<ConceptoInfY>" + txtConceptoInfY.Text + "</ConceptoInfY>"
                    sXML += "<ConceptoImpX>" + txtConceptoImpX.Text + "</ConceptoImpX>"
                    sXML += "<ConceptoImpY>" + txtConceptoImpY.Text + "</ConceptoImpY>"
                    sXML += "<PolizaX>" + txtPolizaX.Text + "</PolizaX>"
                    sXML += "<PolizaY>" + txtPolizaY.Text + "</PolizaY>"
                    sXML += "</xImpresoras>"
                    Dim oclsImp = New clsImpresoras()
                    oclsImp.InsertaImpresora(sXML)
                    MsgBox("Registrado Correctamente", vbInformation, "Sistema Contable")
                    Cargalst()
                    Limpiar()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                MsgBox("Ocurrio un Error", vbInformation, "Sistema Contable")
            End Try
            txtCodigo.Enabled = True
            txtImpresora.Enabled = False
            txtModelo.Enabled = False
            txtConceptoImpX.Enabled = False
            txtConceptoImpY.Enabled = False
            txtConceptoInfX.Enabled = False
            txtConceptoInfY.Enabled = False
            txtConceptoX.Enabled = False
            txtConceptoY.Enabled = False
            txtFechaX.Enabled = False
            txtFechaY.Enabled = False
            txtMontoLtrX.Enabled = False
            txtMontoLtrY.Enabled = False
            txtMontoNumX.Enabled = False
            txtMontoNumY.Enabled = False
            txtNombreX.Enabled = False
            txtNombreY.Enabled = False
            txtPolizaX.Enabled = False
            txtPolizaY.Enabled = False
            BtnGrabarImp.Enabled = False
            BtnNuevo.Enabled = True
            BtnEliminarImp.Enabled = False
            btnModificarImp.Enabled = False
            Cargalst()
            Limpiar()
            txtCodigo.Focus()
        End If
    End Sub
    Private Sub BtnEliminarImp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminarImp.Click
        If txtCodigo.Text = "" Then
            MsgBox("Debe capturar un Codigo", vbInformation, "Sistema Contable")
            txtCodigo.Focus()
        Else
            If MessageBox.Show("¿Desea ELIMINAR Registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim oclsImp = New clsImpresoras()
                oclsImp.EliminaImpresora(txtCodigo.Text)
                MsgBox("Registro Eliminado", vbInformation, "Sistema Contable")
            End If
        End If
        BtnGrabarImp.Enabled = False
        BtnNuevo.Enabled = True
        btnModificarImp.Enabled = False
        BtnEliminarImp.Enabled = False
        txtCodigo.Enabled = True
        txtCodigo.Focus()
        Cargalst()
        Limpiar()
    End Sub
    Private Sub btnModificarImp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarImp.Click
        txtCodigo.Enabled = True
        txtImpresora.Enabled = True
        txtModelo.Enabled = True
        txtConceptoImpX.Enabled = True
        txtConceptoImpY.Enabled = True
        txtConceptoInfX.Enabled = True
        txtConceptoInfY.Enabled = True
        txtConceptoX.Enabled = True
        txtConceptoY.Enabled = True
        txtFechaX.Enabled = True
        txtFechaY.Enabled = True
        txtMontoLtrX.Enabled = True
        txtMontoLtrY.Enabled = True
        txtMontoNumX.Enabled = True
        txtMontoNumY.Enabled = True
        txtNombreX.Enabled = True
        txtNombreY.Enabled = True
        txtPolizaX.Enabled = True
        txtPolizaY.Enabled = True
        BtnGrabarImp.Enabled = True
        BtnNuevo.Enabled = False
        btnModificarImp.Enabled = False
        BtnEliminarImp.Enabled = False
        txtImpresora.Focus()
        Cargalst()
    End Sub
    Sub Limpiar()
        txtImpresora.Clear()
        txtModelo.Clear()
        txtCodigo.Clear()
        txtConceptoImpX.Clear()
        txtConceptoImpY.Clear()
        txtConceptoInfX.Clear()
        txtConceptoInfY.Clear()
        txtConceptoX.Clear()
        txtConceptoY.Clear()
        txtFechaX.Clear()
        txtFechaY.Clear()
        txtMontoLtrX.Clear()
        txtMontoLtrY.Clear()
        txtMontoNumX.Clear()
        txtMontoNumY.Clear()
        txtNombreX.Clear()
        txtNombreY.Clear()
        txtPolizaX.Clear()
        txtPolizaY.Clear()
    End Sub

    

    Private Sub TxtBuscar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBuscar.KeyPress
        Dim clsBD As New clsBD()
        Dim dr As SqlDataReader
        Dim oclsImp = New clsImpresoras()
        dr = oclsImp.BuscaNombreImpresora(Me.TxtBuscar.Text)
        Dim dt = New DataTable()
        dt.Load(dr)
        lstImpresoras.Items.Clear()
        For Each rRow As DataRow In dt.Rows
            Dim lstLista As New ListViewItem(rRow("Codigo").ToString)
            lstLista.SubItems.Add(rRow("Descripcion").ToString)
            lstLista.SubItems.Add(rRow("Marca_Modelo").ToString)
            lstLista.SubItems.Add(rRow("FechaX").ToString)
            lstLista.SubItems.Add(rRow("FechaY").ToString)
            lstLista.SubItems.Add(rRow("NombreX").ToString)
            lstLista.SubItems.Add(rRow("NombreY").ToString)
            lstLista.SubItems.Add(rRow("MontoNumX").ToString)
            lstLista.SubItems.Add(rRow("MontoNumY").ToString)
            lstLista.SubItems.Add(rRow("MontoLtrX").ToString)
            lstLista.SubItems.Add(rRow("MontoLtrY").ToString)
            lstLista.SubItems.Add(rRow("ConceptoX").ToString)
            lstLista.SubItems.Add(rRow("ConceptoY").ToString)
            lstLista.SubItems.Add(rRow("ConceptoInfX").ToString)
            lstLista.SubItems.Add(rRow("ConceptoInfY").ToString)
            lstLista.SubItems.Add(rRow("ConceptoImpX").ToString)
            lstLista.SubItems.Add(rRow("ConceptoImpY").ToString)
            lstLista.SubItems.Add(rRow("PolizaX").ToString)
            lstLista.SubItems.Add(rRow("PolizaY").ToString)
            lstImpresoras.Items.Add(lstLista)
        Next
    End Sub

    Private Sub TxtBuscar_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TxtBuscar.MouseClick
        TxtBuscar.Clear()
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        TxtBuscar.Text = "Buscar Impresora"
        TxtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic)
        txtCodigo.Enabled = True
        txtImpresora.Enabled = True
        txtModelo.Enabled = True
        txtConceptoImpX.Enabled = True
        txtConceptoImpY.Enabled = True
        txtConceptoInfX.Enabled = True
        txtConceptoInfY.Enabled = True
        txtConceptoX.Enabled = True
        txtConceptoY.Enabled = True
        txtFechaX.Enabled = True
        txtFechaY.Enabled = True
        txtMontoLtrX.Enabled = True
        txtMontoLtrY.Enabled = True
        txtMontoNumX.Enabled = True
        txtMontoNumY.Enabled = True
        txtNombreX.Enabled = True
        txtNombreY.Enabled = True
        txtPolizaX.Enabled = True
        txtPolizaY.Enabled = True
        BtnGrabarImp.Enabled = True
        BtnNuevo.Enabled = True
        btnModificarImp.Enabled = False
        BtnEliminarImp.Enabled = False
        Cargalst()
        Limpiar()
        txtCodigo.Focus()
    End Sub

    Private Sub lstImpresoras_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstImpresoras.MouseDoubleClick
        txtCodigo.Text = lstImpresoras.SelectedItems(0).SubItems(0).Text
        txtImpresora.Text = lstImpresoras.SelectedItems(0).SubItems(1).Text
        txtModelo.Text = lstImpresoras.SelectedItems(0).SubItems(2).Text
        txtFechaX.Text = lstImpresoras.SelectedItems(0).SubItems(3).Text
        txtFechaY.Text = lstImpresoras.SelectedItems(0).SubItems(4).Text
        txtNombreX.Text = lstImpresoras.SelectedItems(0).SubItems(5).Text
        txtNombreY.Text = lstImpresoras.SelectedItems(0).SubItems(6).Text
        txtMontoNumX.Text = lstImpresoras.SelectedItems(0).SubItems(7).Text
        txtMontoNumY.Text = lstImpresoras.SelectedItems(0).SubItems(8).Text
        txtMontoLtrX.Text = lstImpresoras.SelectedItems(0).SubItems(9).Text
        txtMontoLtrY.Text = lstImpresoras.SelectedItems(0).SubItems(10).Text
        txtConceptoX.Text = lstImpresoras.SelectedItems(0).SubItems(11).Text
        txtConceptoY.Text = lstImpresoras.SelectedItems(0).SubItems(12).Text
        txtConceptoInfX.Text = lstImpresoras.SelectedItems(0).SubItems(13).Text
        txtConceptoInfY.Text = lstImpresoras.SelectedItems(0).SubItems(14).Text
        txtConceptoImpX.Text = lstImpresoras.SelectedItems(0).SubItems(15).Text
        txtConceptoImpY.Text = lstImpresoras.SelectedItems(0).SubItems(16).Text
        txtPolizaX.Text = lstImpresoras.SelectedItems(0).SubItems(17).Text
        txtPolizaY.Text = lstImpresoras.SelectedItems(0).SubItems(18).Text
        txtCodigo.Enabled = False
        txtImpresora.Enabled = False
        txtModelo.Enabled = False
        txtConceptoImpX.Enabled = False
        txtConceptoImpY.Enabled = False
        txtConceptoInfX.Enabled = False
        txtConceptoInfY.Enabled = False
        txtConceptoX.Enabled = False
        txtConceptoY.Enabled = False
        txtFechaX.Enabled = False
        txtFechaY.Enabled = False
        txtMontoLtrX.Enabled = False
        txtMontoLtrY.Enabled = False
        txtMontoNumX.Enabled = False
        txtMontoNumY.Enabled = False
        txtNombreX.Enabled = False
        txtNombreY.Enabled = False
        txtPolizaX.Enabled = False
        txtPolizaY.Enabled = False
        btnModificarImp.Enabled = True
        BtnGrabarImp.Enabled = False
        BtnEliminarImp.Enabled = True
        BtnNuevo.Enabled = True
    End Sub
End Class