Imports System.Data.SqlClient
Imports System.Data
Imports WindowsApplication1.clsUsuarios
Imports WindowsApplication1.clsTools
Imports WindowsApplication1.mdVariables
Public Class frmPrincipal

    Private Sub AbandonarElSistemaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MsgBox("Desea Salir de SysCont ? ", MessageBoxButtons.YesNo, "" + Space(3) + CStr(VersionCont())) = MsgBoxResult.Yes Then
            Me.Close()
            Application.Exit()
        End If
    End Sub


    Private Sub ImportaPolizasDeComprasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim frm As New frmImportePolizaCompras
        'frm.Show()
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmImportePolizaCompras.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmImportePolizaCompras.Show()
        Else
            My.Forms.frmImportePolizaCompras.Focus()
        End If
    End Sub


    Private Sub TipoDePolizaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoDePolizaToolStripMenuItem.Click
        'Dim frm As New frmTipoMovPoliza
        'frm.Show()
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmTipoMovPoliza.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmTipoMovPoliza.Show()
        Else
            My.Forms.frmTipoMovPoliza.Focus()
        End If
    End Sub
    Private Sub MttoActivosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MttoActivosToolStripMenuItem.Click
        'Dim frm As New frmActivoFijo
        'frm.Show()
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmActivoFijo.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmActivoFijo.Show()
        Else
            My.Forms.frmActivoFijo.Focus()
        End If
    End Sub
    Private Sub GenerarPolizasDepreciacionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarPolizasDepreciacionToolStripMenuItem.Click
        'Dim frm As New frmPolizasDepreciacion
        'frm.Show()
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmPolizasDepreciacion.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmPolizasDepreciacion.Show()
        Else
            My.Forms.frmPolizasDepreciacion.Focus()
        End If
    End Sub
    Private Sub MttoImpresorasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MttoImpresorasToolStripMenuItem.Click
        'Dim frm As New frmImpresoras
        'frm.Show()
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmImpresoras.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmImpresoras.Show()
        Else
            My.Forms.frmImpresoras.Focus()
        End If
    End Sub
    Private Sub GenerarPolizasIVAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim frm As New frmPolizasIVA
        'frm.Show()
        'Dim isOpen As Boolean = False
        'For Each f As Form In Application.OpenForms
        '    If f.Name = frmPolizasIVA.Name Then
        '        isOpen = True
        '    End If
        'Next
        'If isOpen = False Then
        '    My.Forms.frmPolizasIVA.Show()
        'Else
        '    My.Forms.frmPolizasIVA.Focus()
        'End If
    End Sub

    Private Sub DepreciacionFiscalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepreciacionFiscalToolStripMenuItem.Click

        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmDepreciacionFiscal.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmDepreciacionFiscal.Show()
        Else
            My.Forms.frmDepreciacionFiscal.Focus()
        End If
    End Sub
   
    Private Sub GeneracionDeSaldosInicialesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneracionDeSaldosInicialesToolStripMenuItem.Click
    
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmInicializaSaldos.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmInicializaSaldos.Show()
        Else
            My.Forms.frmInicializaSaldos.Focus()
        End If
    End Sub
    Private Sub InicioEjercicioContableToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InicioEjercicioContableToolStripMenuItem.Click
    
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmIniciarEjercicio.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmIniciarEjercicio.Show()
        Else
            My.Forms.frmIniciarEjercicio.Focus()
        End If
    End Sub
    Private Sub ProgramaciónDePagosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub DepreciacionContableToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepreciacionContableToolStripMenuItem.Click
        Dim frm As New frmDepreciacionContable
        frm.Show()
    End Sub

    Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        MenuStrip1.Renderer = New Colores()
        Me.Text = Space(160) + "Desarrollo de Engordas Estabuladas S.A. de C.V." + Space(10) + CStr(VersionCont())
        ImportaPolizasDeComprasToolStripMenuItem.Visible = False
        Me.Hide()
        login.ShowDialog()
        'Me.TopMost = True
        Me.WindowState = 2
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        NoRepetirInstancia()
        '-----------CAMBIO DE CONEXION
        If LoginUsuario = "TEST" Then
            ConexionBD = "Data Source=DENES-JORTIZ\sqlexpress;Initial Catalog=Contabilidad;User ID=TEST;Password=Denes1257"
            TSSConexion.Text = ConexionBD
            lblPruebas.Text = "SISTEMA DE PRUEBAS VERSION " & CStr(VersionCont())
            lblPruebas2.Text = "SISTEMA DE PRUEBAS VERSION " & CStr(VersionCont())
            MenuStrip1.BackColor = Color.Gold
            StatusStrip1.BackColor = Color.Gold
        End If
        'Me.BringToFront()

    End Sub


    Private Sub ClasificaciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClasificaciónToolStripMenuItem.Click
        'Dim frm As New frmCECOSClasifica
        'frm.Show()
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmCECOSClasifica.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmCECOSClasifica.Show()
        Else
            My.Forms.frmCECOSClasifica.Focus()
        End If
    End Sub

    Private Sub AreasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AreasToolStripMenuItem.Click
        'Dim frm As New frmCECOSAreas
        'frm.Show()
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmCECOSAreas.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmCECOSAreas.Show()
        Else
            My.Forms.frmCECOSAreas.Focus()
        End If
    End Sub

    Private Sub DepartamentosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartamentosToolStripMenuItem.Click
        'Dim frm As New frmCECOSDepartamentos
        'frm.Show()
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmCECOSDepartamentos.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmCECOSDepartamentos.Show()
        Else
            My.Forms.frmCECOSDepartamentos.Focus()
        End If
    End Sub

    Private Sub CuentasDeMayorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuentasDeMayorToolStripMenuItem.Click
        'Dim frm As New frmCuentasMayor
        'frm.ShowDialog()
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmCuentasMayor.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmCuentasMayor.Show()
        Else
            My.Forms.frmCuentasMayor.Focus()
        End If
    End Sub

    Private Sub Cuentas2NivelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cuentas2NivelToolStripMenuItem.Click
        'Dim frm As New frmCuentasMaySeg()
        'frm.Show()
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmCuentasMaySeg.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmCuentasMaySeg.Show()
        Else
            My.Forms.frmCuentasMaySeg.Focus()
        End If
    End Sub

    Private Sub Cuentas3erNivelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cuentas3erNivelToolStripMenuItem.Click
        'Dim frm As New frmCuentasMayTer()
        'frm.Show()
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmCuentasMayTer.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmCuentasMayTer.Show()
        Else
            My.Forms.frmCuentasMayTer.Focus()
        End If
    End Sub

    Private Sub CuentasContToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuentasContToolStripMenuItem.Click
        'Dim frm As New frmCuentasContables
        'frm.Show()
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmCuentasContables.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmCuentasContables.Show()
        Else
            My.Forms.frmCuentasContables.Focus()
        End If
    End Sub

    Private Sub BancosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BancosToolStripMenuItem.Click
        'Dim frm As New frmBancos()
        'frm.Show()
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmBancos.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmBancos.Show()
        Else
            My.Forms.frmBancos.Focus()
        End If
    End Sub

    Private Sub ProveedoresToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresToolStripMenuItem1.Click
        'Dim frm As New frmProveedores
        'frm.Show()
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmProveedores.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmProveedores.Show()
        Else
            My.Forms.frmProveedores.Focus()
        End If
    End Sub

    Private Sub MttoProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MttoProveedoresToolStripMenuItem.Click

        'Dim frm As New frmGiroProveedores
        'frm.Show()
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmGiroProveedores.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmGiroProveedores.Show()
        Else
            My.Forms.frmGiroProveedores.Focus()
        End If
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        'Dim frm As New FrmClientes()
        'frm.Show()
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = FrmClientes.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.FrmClientes.Show()
        Else
            My.Forms.FrmClientes.Focus()
        End If
    End Sub

    Private Sub MantenimientToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MantenimientToolStripMenuItem.Click
        'Dim frm As New frmUsuarios()
        'frm.Show()
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmUsuarios.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmUsuarios.Show()
        Else
            My.Forms.frmUsuarios.Focus()
        End If
    End Sub

    Private Sub PerifilesDeUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerifilesDeUsuarioToolStripMenuItem.Click
        'Dim frm As New frmPerfilesUsuario
        'frm.Show()
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmPerfilesUsuario.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmPerfilesUsuario.Show()
        Else
            My.Forms.frmPerfilesUsuario.Focus()
        End If
    End Sub

    Private Sub ResetDeContraseñasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetDeContraseñasToolStripMenuItem.Click
        'Dim frm As New frmResetContraseña()
        'frm.Show()
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmResetContraseña.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmResetContraseña.Show()
        Else
            My.Forms.frmResetContraseña.Focus()
        End If
    End Sub

    Private Sub TipoDeCambioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoDeCambioToolStripMenuItem.Click
        'Dim frm As New frmTipoCambio()
        'frm.Show()
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmTipoCambio.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmTipoCambio.Show()
        Else
            My.Forms.frmTipoCambio.Focus()
        End If
    End Sub

    Private Sub PolizaManualToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PolizaManualToolStripMenuItem.Click
        'Dim frm As New frmPolizasManuales
        'frm.Show()
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmPolizasManuales.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmPolizasManuales.Show()
        Else
            My.Forms.frmPolizasManuales.Focus()
        End If
    End Sub

    Private Sub ImportaPolizasDeComprasToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportaPolizasDeComprasToolStripMenuItem.Click
        'Dim frm As New frmInterfasePoliza()
        'frm.Show()
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmInterfasePoliza.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmInterfasePoliza.Show()

        Else
            My.Forms.frmInterfasePoliza.Focus()
        End If
    End Sub

    Private Sub CerrarMesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarMesToolStripMenuItem.Click
        'Dim frm As New frmMesCerrado()
        'frm.Show()

        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmMesCerrado.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmMesCerrado.Show()

        Else
            My.Forms.frmMesCerrado.Focus()
        End If
    End Sub

    Private Sub ChequesYTransferenciasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChequesYTransferenciasToolStripMenuItem.Click
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmMovBancos.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmMovBancos.Show()
        Else
            My.Forms.frmMovBancos.Focus()
        End If
    End Sub

    Private Sub TransferenciasInterBancariasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransferenciasInterBancariasToolStripMenuItem.Click
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = FrmTransferenciaSaldos.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.FrmTransferenciaSaldos.Show()
        Else
            My.Forms.FrmTransferenciaSaldos.Focus()
        End If
    End Sub

    Private Sub ReporteDeChequesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteDeChequesToolStripMenuItem1.Click
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmReporteCheques.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmReporteCheques.Show()
        Else
            My.Forms.frmReporteCheques.Focus()
        End If
    End Sub


    Private Sub AbandonarElSistemaToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbandonarElSistemaToolStripMenuItem.Click
        If MsgBox("Desea Salir de SysContabilidad ? ", MessageBoxButtons.YesNo, "               SysContabilidad [V 1.0]") = MsgBoxResult.Yes Then
            Me.Close()
            Application.Exit()
        End If
    End Sub

    Private Sub INDICEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles INDICEToolStripMenuItem.Click
        Process.Start("C:\Program Files\Internet Explorer\IExplore.exe", "SERVIDOR1/HomeDenes/ManualSysConta/ManualSysConta.html")
    End Sub

    Private Sub CerrarSesionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        If MsgBox("Desea Cerrar Sesion ? ", MessageBoxButtons.YesNo, "Sistema" + Space(3) + CStr(VersionCont())) = MsgBoxResult.Yes Then
            Me.Hide()
            login.Show()
        End If
    End Sub

    Private Sub RecuperacionDeIVAToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecuperacionDeIVAToolStripMenuItem1.Click
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmPolizasIVA.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmPolizasIVA.Show()
        Else
            My.Forms.frmPolizasIVA.Focus()
        End If
    End Sub

    Private Sub InformeDeIVAToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformeDeIVAToolStripMenuItem1.Click
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmInformeIva.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmInformeIva.Show()
        Else
            My.Forms.frmInformeIva.Focus()
        End If
    End Sub

    Private Sub AjusteDePolizasDeGanadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjusteDePolizasDeGanadoToolStripMenuItem.Click
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmPolizasAjuste.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmPolizasAjuste.Show()
        Else
            My.Forms.frmPolizasAjuste.Focus()
        End If
    End Sub

    Private Sub InformeDeEntradasDeGanadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformeDeEntradasDeGanadoToolStripMenuItem.Click
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmInformeAjusteEntrada.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmInformeAjusteEntrada.Show()
        Else
            My.Forms.frmInformeAjusteEntrada.Focus()
        End If

    End Sub

    Private Sub CierreDeEntradasDeGanadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CierreDeEntradasDeGanadoToolStripMenuItem.Click
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmEntradasCierre.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmEntradasCierre.Show()
        Else
            My.Forms.frmEntradasCierre.Focus()
        End If
    End Sub

    Private Sub ImpresionDePolizasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImpresionDePolizasToolStripMenuItem.Click
        Dim frm As New frmInformePolizas
        frm.Show()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Process.Start("http://servidor1/HomeDenes/index.html")
    End Sub

    Private Sub InformeHistorialCuentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformeHistorialCuentaToolStripMenuItem.Click
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmInformeHistorialCuenta.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmInformeHistorialCuenta.Show()
        Else
            My.Forms.frmInformeHistorialCuenta.Focus()
        End If
    End Sub


    Private Sub InformeContablesToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformeContablesToolStripMenuItem.Click
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmInformesContabilidad.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmInformesContabilidad.Show()
        Else
            My.Forms.frmInformesContabilidad.Focus()
        End If
    End Sub

    Private Sub VersionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VersionesToolStripMenuItem.Click
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmCtrlVersiones.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmCtrlVersiones.Show()
        Else
            My.Forms.frmCtrlVersiones.Focus()
        End If
    End Sub


    Private Sub ProgramaciónDePagosToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramaciónDePagosToolStripMenuItem.Click
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmProgramacionPago.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmProgramacionPago.Show()
        Else
            My.Forms.frmProgramacionPago.Focus()
        End If
    End Sub

    Private Sub InformeOCPendientesProgramacionPagoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformeOCPendientesProgramacionPagoToolStripMenuItem.Click
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmProgramacionPago_PendientePago.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmProgramacionPago_PendientePago.Show()
        Else
            My.Forms.frmProgramacionPago_PendientePago.Focus()
        End If
    End Sub

    Private Sub InformeCambioDeFolioFacturaCRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformeCambioDeFolioFacturaCRToolStripMenuItem.Click
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmProgramacionPago_CambioFacturaReporte.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmProgramacionPago_CambioFacturaReporte.Show()
        Else
            My.Forms.frmProgramacionPago_CambioFacturaReporte.Focus()
        End If
    End Sub

    Private Sub MovimientoProveedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovimientoProveedorToolStripMenuItem.Click
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmInformeMovimientosProveedor.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmInformeMovimientosProveedor.Show()
        Else
            My.Forms.frmInformeMovimientosProveedor.Focus()
        End If
    End Sub

    Private Sub NotaDeCreditoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotaDeCreditoToolStripMenuItem.Click
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmNotaCredito.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmNotaCredito.Show()
        Else
            My.Forms.frmNotaCredito.Focus()
        End If
    End Sub

    Private Sub ModificacionPreciosOCToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificacionPreciosOCToolStripMenuItem.Click

        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmProveedorCambioPrecioOC.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmProveedorCambioPrecioOC.Show()
        Else
            My.Forms.frmProveedorCambioPrecioOC.Focus()
        End If
    End Sub
End Class