Imports System.Data.SqlClient
Imports WindowsApplication1.clsTools
Imports WindowsApplication1.clsBD
Public Class frmInformePolizas
    Dim sortColumn As String
    Private Sub frmInformePolizas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenalistaInicial()
        dtpFechaIni.Value = Today
        dtpfechafin.Value = Today
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        MaximizeBox = False
    End Sub
    Private Sub llenalistaInicial()
        Dim oclsInformePolizas As New clsInformePolizas
        Dim dr As SqlDataReader
        Dim dt = New DataTable()
        dr = oclsInformePolizas.SeleccionaListaPolizas()
        dt.Load(dr)
        If dt.Rows.Count > 0 Then
            lstTiposMovimiento.Items.Clear()
            For Each rRow As DataRow In dt.Rows
                Dim lstLista As New ListViewItem(rRow("TipoPoliza").ToString)
                lstLista.SubItems.Add(rRow("Descripcion").ToString)
                lstLista.SubItems.Add(rRow("TipoMovimiento").ToString)
                lstTiposMovimiento.Items.Add(lstLista)
            Next
        End If
    End Sub

    Private Sub lstTiposMovimiento_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lstTiposMovimiento.ColumnClick
        If e.Column = 0 Then
            llenalista2()
        Else
            If e.Column = 1 Then
                llenalistaInicial()
            End If
        End If
    End Sub
    Private Sub llenalista2()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cn As New SqlConnection
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim consulta As String = "select * from dbo.conTipoMovPoliza order by tipoPoliza"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        'cmd.CommandType = CommandType.Text
        da = New SqlDataAdapter
        da.SelectCommand = cmd
        da.Fill(ds, "conTipoMovPoliza")
        Dim objListItem As New ListViewItem
        Me.lstTiposMovimiento.Items.Clear()
        For Each drw As DataRow In ds.Tables("conTipoMovPoliza").Rows
            objListItem = lstTiposMovimiento.Items.Add(drw.Item("tipoPoliza").ToString, 0)
            objListItem.SubItems.Add(drw.Item("Descripcion").ToString)
            objListItem.SubItems.Add(drw.Item("TipoMovimiento").ToString)
        Next
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Private Sub lstTiposMovimiento_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstTiposMovimiento.DoubleClick

        For i As Integer = 0 To lstSeleccionados.Items.Count - 1
            If lstSeleccionados.Items(i).SubItems(0).Text = lstTiposMovimiento.SelectedItems(0).SubItems(0).Text _
               And lstSeleccionados.Items(i).SubItems(2).Text = lstTiposMovimiento.SelectedItems(0).SubItems(2).Text Then
                MsgBox("Elemento ya se encuentra Agregado", MsgBoxStyle.Information)
                Exit Sub
            End If
        Next
        Dim lstLista As New ListViewItem(lstTiposMovimiento.SelectedItems(0).SubItems(0).Text)
        lstLista.SubItems.Add(lstTiposMovimiento.SelectedItems(0).SubItems(1).Text)
        lstLista.SubItems.Add(lstTiposMovimiento.SelectedItems(0).SubItems(2).Text)
        lstSeleccionados.Items.Add(lstLista)
        btnImprimir.Enabled = True
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        Dim cadenaXML As String = ""
        Dim TiposPoliza As String
        Dim sXML = "<xTipos>"

        TiposPoliza = "0"
        For i As Integer = 0 To lstSeleccionados.Items.Count - 1
            sXML += "<row>"
            If sXML = "" Then
                sXML += "<TipoMovimiento>" + lstSeleccionados.Items(i).SubItems(2).Text + "</TipoMovimiento>"
                sXML += "<TipoPoliza>" + lstSeleccionados.Items(i).SubItems(0).Text + "</TipoPoliza>"
                sXML += "<Descripcion>" + lstSeleccionados.Items(i).SubItems(1).Text + "</Descripcion>"
                cadenaXML = sXML
            Else
                sXML += "<TipoMovimiento>" + lstSeleccionados.Items(i).SubItems(2).Text + "</TipoMovimiento>"
                sXML += "<TipoPoliza>" + lstSeleccionados.Items(i).SubItems(0).Text + "</TipoPoliza>"
                sXML += "<Descripcion>" + lstSeleccionados.Items(i).SubItems(1).Text + "</Descripcion>"
                cadenaXML = cadenaXML + sXML
            End If
            sXML += "</row>"
            TiposPoliza += "," + lstSeleccionados.Items(i).SubItems(0).Text
        Next
        sXML += "</xTipos>"
        Dim fechainicial As String
        Dim fechafinal As String
        fechainicial = dtpFechaIni.Value
        fechafinal = dtpfechafin.Value
        Dim frm As New frmRPTInfPolizas
        frm.TiposPolizas = TiposPoliza
        frm.sXML = sXML
        frm.fechaIni = fechainicial
        frm.fechaFin = fechafinal
        If chPolizaDif.Checked = False Then
            frm.nDif = 0
        Else
            frm.nDif = 1
        End If
        If rFecha.Checked = True Then
            frm.Opcion = 1
        Else
            frm.Opcion = 2
        End If
        If txtPolizaIni.Text = "" Then
            frm.PolizaIni = 0
        Else
            frm.PolizaIni = txtPolizaIni.Text
        End If
        If txtPolizaFin.Text = "" Then
            frm.PolizaFin = 9999999 ' SACAR MAXIMO POLIZAS
        Else
            frm.PolizaFin = txtPolizaFin.Text
        End If
        frm.ShowDialog()
    End Sub

    Private Sub lstSeleccionados_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstSeleccionados.DoubleClick
        lstSeleccionados.SelectedItems(0).Remove()
        If lstSeleccionados.Items.Count = 0 Then
            btnImprimir.Enabled = False
        End If
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        dtpFechaIni.Value = Today
        dtpfechafin.Value = Today
        btnImprimir.Enabled = False
        lstSeleccionados.Items.Clear()
        llenalistaInicial()
    End Sub

    Private Sub brnSelTodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brnSelTodo.Click
        lstSeleccionados.Items.Clear()
        For i As Integer = 0 To lstTiposMovimiento.Items.Count - 1
            Dim lstLista As New ListViewItem(lstTiposMovimiento.Items(i).SubItems(0).Text)
            lstLista.SubItems.Add(lstTiposMovimiento.Items(i).SubItems(1).Text)
            lstLista.SubItems.Add(lstTiposMovimiento.Items(i).SubItems(2).Text)
            lstSeleccionados.Items.Add(lstLista)
        Next
        btnImprimir.Enabled = True
    End Sub

    Private Sub lstTiposMovimiento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lstTiposMovimiento.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            For i As Integer = 0 To lstSeleccionados.Items.Count - 1
                If lstSeleccionados.Items(i).SubItems(0).Text = lstTiposMovimiento.SelectedItems(0).SubItems(0).Text Then
                    MsgBox("Elemento ya se encuentra Agregado", MsgBoxStyle.Information)
                    Exit Sub
                End If
            Next
            Dim lstLista As New ListViewItem(lstTiposMovimiento.SelectedItems(0).SubItems(0).Text)
            lstLista.SubItems.Add(lstTiposMovimiento.SelectedItems(0).SubItems(1).Text)
            lstLista.SubItems.Add(lstTiposMovimiento.SelectedItems(0).SubItems(2).Text)
            lstSeleccionados.Items.Add(lstLista)
            btnImprimir.Enabled = True
        End If
    End Sub

    Private Sub txtPolizaIni_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPolizaIni.Click
        txtPolizaIni.SelectAll()
    End Sub

    Private Sub txtPolizaFin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPolizaFin.Click
        txtPolizaFin.SelectAll()
    End Sub

    Private Sub lstSeleccionados_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstSeleccionados.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brnDesTodo.Click
        lstSeleccionados.Items.Clear()
        btnImprimir.Enabled = False
    End Sub


    Private Sub rPoliza_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rPoliza.CheckedChanged
        
    End Sub

    Private Sub rPoliza_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rPoliza.Click
        If rPoliza.Checked = True Then
            dtpfechafin.Enabled = False
            dtpFechaIni.Enabled = False
            txtPolizaFin.Enabled = True
            txtPolizaIni.Enabled = True

        End If
    End Sub

    Private Sub rFecha_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rFecha.Click
        If rFecha.Checked = True Then
            dtpfechafin.Enabled = True
            dtpFechaIni.Enabled = True
            txtPolizaFin.Enabled = False
            txtPolizaIni.Enabled = False
            txtPolizaFin.Text = ""
            txtPolizaIni.Text = ""
        End If
    End Sub

    Private Sub txtPolizaIni_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPolizaIni.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            txtPolizaFin.Select()
        End If
    End Sub

    Private Sub txtPolizaIni_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPolizaIni.TextChanged

    End Sub

    Private Sub txtPolizaFin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPolizaFin.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

End Class