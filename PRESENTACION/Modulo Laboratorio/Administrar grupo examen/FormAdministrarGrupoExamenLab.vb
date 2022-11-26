Imports NEGOCIO

Public Class FormAdministrarGrupoExamenLab

    'ATRIBUTOS LÓGICOS
    Private registro As AdministracionGrupoExamen

    'ATRIBUTOS LÓGICOS MODO FORM HIJO
    Public estadoFormGuardado As Boolean
    Public esFormHijo As Boolean

    'ATRIBUTOS G0
    Private tituloFormulario As String

    'ATRIBUTOS G1
    Private areaSeleccionada As AreaLaboratorio

    'ATRIBUTOS G2
    Private grupoSeleccionado As GrupoExamenLaboratorio
    Private clmCodGrupoDgvGru As String
    Private clmNomGrupoDgvGru As String
    Private accionSeleccionada As Short

    'ATRIBUTOS G3A
    Private clmCodExamenDgvExaAgrExa As String
    Private clmNomExamenDgvExaAgrExa As String
    Private nuevoExamenSeleccionado As ExamenLaboratorio
    Private clmCodExamenDgvNueExaAgrExa As String
    Private clmNomExamenDgvNueExaAgrExa As String
    Private clmButtonAccionDgvNueExaAgrExa As String

    'ATRIBUTOS G9A
    Private nuevosExamenesAgrExa As ListaEnlazadaExamenLaboratorio

    'ATRIBUTOS G3B
    Private clmCodExamenEliExa As String
    Private clmNomExamenEliExa As String
    Private clmIndividualEliExa As String
    Private clmCheckboxEliExa As String
    Private examenesMarcados As ExamenLaboratorio()


    'ATRIBUTOS G9B
    Private examenesParaConservarEliExa As ExamenLaboratorio()






    'METODOS INICIO
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        preIniciarAtributosFormHijo(False)
        iniciarFormulario()
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        establecerDisplay()
    End Sub

    Private Sub FormAdministrarGrupoExamenLab_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub preIniciarAtributosFormHijo(_esHijo As Boolean)
        estadoFormGuardado = False
        esFormHijo = _esHijo

        If _esHijo Then

        Else

        End If
    End Sub

    Public Sub iniciarFormulario()
        iniciarAtributos()
        iniciarProcesosNegocio()
        iniciarControlesInterfaz()

        registro.traerAreas()
        intPoblarCboxArea()

        'If esFormHijo Then iniciarControlesInterfazFormSecundario()
    End Sub

    Private Sub iniciarAtributos()
        'ATRIBUTOS LÓGICOS
        registro = New AdministracionGrupoExamen()

        'ATRIBUTOS LÓGICOS MODO FORM HIJO
        'estadoFormGuardado = False

        'ATRIBUTOS G0
        tituloFormulario = "Administrar grupos examen laboratorio"

        'ATRIBUTOS G1
        areaSeleccionada = New AreaLaboratorio()

        'ATRIBUTOS G2
        grupoSeleccionado = New GrupoExamenLaboratorio()
        clmCodGrupoDgvGru = "clmCodGrupoDgvGru"
        clmNomGrupoDgvGru = "clmNomGrupoDgvGru"
        accionSeleccionada = 0

        'ATRIBUTOS G3A
        nuevoExamenSeleccionado = New ExamenLaboratorio()
        clmCodExamenDgvExaAgrExa = "clmCodExamenDgvExaAgrExa"
        clmNomExamenDgvExaAgrExa = "clmCNomExamenDgvExaAgrExa"
        clmCodExamenDgvNueExaAgrExa = "clmCodExamenDgvNueExaAgrExa"
        clmNomExamenDgvNueExaAgrExa = "clmNomExamenDgvNueExaAgrExa"
        clmButtonAccionDgvNueExaAgrExa = "clmButtonAccionDgvNueExaAgrExa"

        'ATRIBUTOS G9A
        nuevosExamenesAgrExa = New ListaEnlazadaExamenLaboratorio()

        'ATRIBUTOS G3B
        clmCodExamenEliExa = "clmCodExamenEliExa"
        clmNomExamenEliExa = "clmNomExamenEliExa"
        clmIndividualEliExa = "clmIndividualEliExa"
        clmCheckboxEliExa = "clmCheckboxEliExa"
        examenesMarcados = New ExamenLaboratorio(-1) {}


        'ATRIBUTOS G9B
        examenesParaConservarEliExa = New ExamenLaboratorio(-1) {}
    End Sub

    Private Sub iniciarProcesosNegocio()

    End Sub

    Private Sub iniciarControlesInterfaz()
        iniciarControlesInterfazGrupo0()
        iniciarControlesInterfazGrupo1()
        iniciarControlesInterfazGrupo2()
        iniciarControlesInterfazGrupo3A()
        iniciarControlesInterfazGrupo3B()
    End Sub

    Private Sub iniciarControlesInterfazGrupo0()
        Me.Enabled = True
        Me.Text = tituloFormulario

        lblTituloPrincipal.Enabled = True
        lblTituloPrincipal.Visible = True
        lblTituloPrincipal.Font = New Font("Microsoft Sans Serif", 12.5)
        lblTituloPrincipal.Text = tituloFormulario.ToUpper
    End Sub

    Private Sub iniciarControlesInterfazGrupo1()
        panelArea.Enabled = True
        panelArea.Visible = True

        cboxArea.Enabled = True
        cboxArea.Visible = True
        cboxArea.Font = New Font("Microsoft Sans Serif", 9)
        cboxArea.Items.Clear()
        cboxArea.DropDownStyle = ComboBoxStyle.DropDownList

        hintArea.Enabled = True
        hintArea.Visible = True
        hintArea.Font = New Font("Microsoft Sans Serif", 8)
        hintArea.Text = "SELECCIONAR"
        hintArea.BackColor = Color.Transparent
    End Sub

    Private Sub iniciarControlesInterfazGrupo2()
        panelGrupo.Enabled = True
        panelGrupo.Visible = True

        iniciarDgvGrupos()

        lblAccion.Enabled = False
        lblAccion.Visible = True
        lblAccion.Font = New Font("Microsoft Sans Serif", 9.5)
        'lblAccion.Text = ""

        cboxAccion.Enabled = False
        cboxAccion.Visible = True
        cboxAccion.Font = New Font("Microsoft Sans Serif", 9)
        cboxAccion.Items.Clear()
        cboxAccion.DropDownStyle = ComboBoxStyle.DropDownList
        cboxAccion.Items.Add("AGREGAR EXAMENES")
        cboxAccion.Items.Add("ELIMINAR EXAMENES")

        hintAccion.Enabled = False
        hintAccion.Visible = True
        hintAccion.Font = New Font("Microsoft Sans Serif", 8)
        hintAccion.Text = "SELECCIONAR"
        hintAccion.BackColor = Color.Transparent
    End Sub

    Private Sub iniciarDgvGrupos()
        'ENCABEZADOS LABELS

        'PROPIEDADES BASE
        dgvGrupos.Enabled = True
        dgvGrupos.Visible = True
        dgvGrupos.Font = New Font("Microsoft Sans Serif", 9)
        dgvGrupos.Rows.Clear()
        dgvGrupos.Columns.Clear()

        'PERMISOS EDITAR
        dgvGrupos.EditMode = DataGridViewEditMode.EditOnEnter
        dgvGrupos.AllowUserToAddRows = False
        dgvGrupos.AllowUserToDeleteRows = False
        dgvGrupos.AllowUserToResizeRows = False
        dgvGrupos.AllowUserToOrderColumns = False
        dgvGrupos.AllowUserToResizeColumns = False
        dgvGrupos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgvGrupos.MultiSelect = False
        dgvGrupos.ReadOnly = True

        'PROPIEDADES MODOS DE SELECCION
        dgvGrupos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvGrupos.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        'PROPIEDADES COLOR CABEZAS COLUMNAS 
        dgvGrupos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(235, 235, 235)
        dgvGrupos.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black

        'PROPIEDADES COLOR CABEZERAS FILAS
        dgvGrupos.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 255, 255)
        dgvGrupos.RowHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 0, 0)

        'PROPIEDAES COLOR CELDAS NORMALES
        dgvGrupos.BackgroundColor = Color.FromArgb(255, 255, 255)
        dgvGrupos.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255)
        dgvGrupos.DefaultCellStyle.ForeColor = Color.Black

        'PROPIEDADES COLOR FILAS SELECCIONADAS
        dgvGrupos.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(48, 97, 255)
        dgvGrupos.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 0, 0)

        'OTRAS PROPIEDAES
        dgvGrupos.ScrollBars = ScrollBars.Both
        dgvGrupos.EnableHeadersVisualStyles = False




        'COLUMNAS 
        dgvGrupos.Columns.Clear()

        dgvGrupos.Columns.Add(clmCodGrupoDgvGru, "CODIGO GRUPO")
        dgvGrupos.Columns(clmCodGrupoDgvGru).Visible = False

        dgvGrupos.Columns.Add(clmNomGrupoDgvGru, "GRUPO")
        dgvGrupos.Columns(clmNomGrupoDgvGru).Visible = True

        'BLOQUEAR ORDENAR POR COLUMNA
        For Each columna As DataGridViewColumn In dgvGrupos.Columns
            columna.SortMode = DataGridViewColumnSortMode.NotSortable
        Next

        'ALINEAR COLUMNAS
        For Each columna As DataGridViewColumn In dgvGrupos.Columns
            columna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
            columna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Next


        'CONFIGURAR ANCHO COLUMNAS
        dgvGrupos.Columns(clmCodGrupoDgvGru).FillWeight = 1
        dgvGrupos.Columns(clmNomGrupoDgvGru).FillWeight = 99

        'FILAS
        dgvGrupos.Rows.Clear()
    End Sub

    Private Sub iniciarControlesInterfazGrupo3A()
        panelAgregarExamen.Enabled = True
        panelAgregarExamen.Visible = False

        iniciarDgvExamenesAgrExa()
        intDeshabilitarDgvExamenesAgrExa(False)

        cboxExamenAgrExa.Enabled = True
        cboxExamenAgrExa.Visible = True
        cboxExamenAgrExa.Font = New Font("Microsoft Sans Serif", 9)
        cboxExamenAgrExa.Items.Clear()
        cboxExamenAgrExa.DropDownStyle = ComboBoxStyle.DropDownList

        hintExamenAgrExa.Enabled = True
        hintExamenAgrExa.Visible = True
        hintExamenAgrExa.Font = New Font("Microsoft Sans Serif", 8)
        hintExamenAgrExa.Text = "SELECCIONAR"
        hintExamenAgrExa.BackColor = Color.Transparent

        iniciarDgvNuevosExamenesAgrExa()

        btnAgregarAgrExa.Enabled = True
        btnAgregarAgrExa.Visible = True
        btnAgregarAgrExa.Font = New Font("Microsoft Sans Serif", 9)
        'btnAgregarExamenNuevosExamenes.Text = ""
    End Sub

    Private Sub iniciarDgvExamenesAgrExa()
        'ENCABEZADOS LABELS

        'PROPIEDADES BASE
        dgvExamenesAgrExa.Enabled = True
        dgvExamenesAgrExa.Visible = True
        dgvExamenesAgrExa.Font = New Font("Microsoft Sans Serif", 9)
        dgvExamenesAgrExa.Rows.Clear()
        dgvExamenesAgrExa.Columns.Clear()

        'PERMISOS EDITAR
        dgvExamenesAgrExa.EditMode = DataGridViewEditMode.EditOnEnter
        dgvExamenesAgrExa.AllowUserToAddRows = False
        dgvExamenesAgrExa.AllowUserToDeleteRows = False
        dgvExamenesAgrExa.AllowUserToResizeRows = False
        dgvExamenesAgrExa.AllowUserToOrderColumns = False
        dgvExamenesAgrExa.AllowUserToResizeColumns = False
        dgvExamenesAgrExa.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgvExamenesAgrExa.MultiSelect = False
        dgvExamenesAgrExa.ReadOnly = True

        'PROPIEDADES MODOS DE SELECCION
        dgvExamenesAgrExa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvExamenesAgrExa.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        'PROPIEDADES COLOR CABEZAS COLUMNAS 
        dgvExamenesAgrExa.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(235, 235, 235)
        dgvExamenesAgrExa.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black

        'PROPIEDADES COLOR CABEZERAS FILAS
        dgvExamenesAgrExa.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 255, 255)
        dgvExamenesAgrExa.RowHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 0, 0)

        'PROPIEDAES COLOR CELDAS NORMALES
        dgvExamenesAgrExa.BackgroundColor = Color.FromArgb(255, 255, 255)
        dgvExamenesAgrExa.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255)
        dgvExamenesAgrExa.DefaultCellStyle.ForeColor = Color.Black

        'PROPIEDADES COLOR FILAS SELECCIONADAS
        dgvExamenesAgrExa.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 255, 255)
        dgvExamenesAgrExa.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 0, 0)

        'OTRAS PROPIEDAES
        dgvExamenesAgrExa.ScrollBars = ScrollBars.Both
        dgvExamenesAgrExa.EnableHeadersVisualStyles = False




        'COLUMNAS 
        dgvExamenesAgrExa.Columns.Clear()

        dgvExamenesAgrExa.Columns.Add(clmCodExamenDgvExaAgrExa, "CODIGO EXAMEN")
        dgvExamenesAgrExa.Columns(clmCodExamenDgvExaAgrExa).Visible = False

        dgvExamenesAgrExa.Columns.Add(clmNomExamenDgvExaAgrExa, "EXAMENES")
        dgvExamenesAgrExa.Columns(clmNomExamenDgvExaAgrExa).Visible = True

        'BLOQUEAR ORDENAR POR COLUMNA
        For Each columna As DataGridViewColumn In dgvExamenesAgrExa.Columns
            columna.SortMode = DataGridViewColumnSortMode.NotSortable
        Next

        'ALINEAR COLUMNAS
        For Each columna As DataGridViewColumn In dgvExamenesAgrExa.Columns
            columna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
            columna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Next


        'CONFIGURAR ANCHO COLUMNAS
        dgvExamenesAgrExa.Columns(clmCodExamenDgvExaAgrExa).FillWeight = 1
        dgvExamenesAgrExa.Columns(clmNomExamenDgvExaAgrExa).FillWeight = 99

        'FILAS
        dgvExamenesAgrExa.Rows.Clear()
        dgvExamenesAgrExa.Rows.Add()

    End Sub

    Private Sub iniciarDgvNuevosExamenesAgrExa()
        'ENCABEZADOS LABELS


        'PROPIEDADES BASE
        dgvNuevosExamenesAgrExa.Enabled = True
        dgvNuevosExamenesAgrExa.Visible = True
        dgvNuevosExamenesAgrExa.Font = New Font("Microsoft Sans Serif", 9)
        dgvNuevosExamenesAgrExa.Rows.Clear()
        dgvNuevosExamenesAgrExa.Columns.Clear()

        'PERMISOS EDITAR
        dgvNuevosExamenesAgrExa.EditMode = DataGridViewEditMode.EditOnEnter
        dgvNuevosExamenesAgrExa.AllowUserToAddRows = False
        dgvNuevosExamenesAgrExa.AllowUserToDeleteRows = False
        dgvNuevosExamenesAgrExa.AllowUserToResizeRows = False
        dgvNuevosExamenesAgrExa.AllowUserToOrderColumns = False
        dgvNuevosExamenesAgrExa.AllowUserToResizeColumns = False
        dgvNuevosExamenesAgrExa.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgvNuevosExamenesAgrExa.MultiSelect = False
        dgvNuevosExamenesAgrExa.ReadOnly = True

        'PROPIEDADES MODOS DE SELECCION
        dgvNuevosExamenesAgrExa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvNuevosExamenesAgrExa.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        'PROPIEDADES COLOR CABEZAS COLUMNAS 
        dgvNuevosExamenesAgrExa.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(235, 235, 235)
        dgvNuevosExamenesAgrExa.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black

        'PROPIEDADES COLOR CABEZERAS FILAS
        dgvNuevosExamenesAgrExa.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 255, 255)
        dgvNuevosExamenesAgrExa.RowHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 0, 0)

        'PROPIEDAES COLOR CELDAS NORMALES
        dgvNuevosExamenesAgrExa.BackgroundColor = Color.FromArgb(255, 255, 255)
        dgvNuevosExamenesAgrExa.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255)
        dgvNuevosExamenesAgrExa.DefaultCellStyle.ForeColor = Color.Black

        'PROPIEDADES COLOR FILAS SELECCIONADAS
        dgvNuevosExamenesAgrExa.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(48, 97, 255)
        dgvNuevosExamenesAgrExa.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 0, 0)

        'OTRAS PROPIEDAES
        dgvNuevosExamenesAgrExa.ScrollBars = ScrollBars.Both
        dgvNuevosExamenesAgrExa.EnableHeadersVisualStyles = False




        'COLUMNAS 
        dgvNuevosExamenesAgrExa.Columns.Clear()

        dgvNuevosExamenesAgrExa.Columns.Add(clmCodExamenDgvNueExaAgrExa, "CODIGO EXAMEN")
        dgvNuevosExamenesAgrExa.Columns(clmCodExamenDgvNueExaAgrExa).Visible = False

        dgvNuevosExamenesAgrExa.Columns.Add(clmNomExamenDgvNueExaAgrExa, "EXAMEN")
        dgvNuevosExamenesAgrExa.Columns(clmNomExamenDgvNueExaAgrExa).Visible = True

        Dim clmButton As New DataGridViewButtonColumn()
        clmButton.Name = clmButtonAccionDgvNueExaAgrExa
        clmButton.HeaderText = ""
        clmButton.Text = "ELIMINAR"
        clmButton.UseColumnTextForButtonValue = True
        dgvNuevosExamenesAgrExa.Columns.Add(clmButton)
        dgvNuevosExamenesAgrExa.Columns(clmButtonAccionDgvNueExaAgrExa).Visible = True


        'BLOQUEAR ORDENAR POR COLUMNA
        For Each columna As DataGridViewColumn In dgvNuevosExamenesAgrExa.Columns
            columna.SortMode = DataGridViewColumnSortMode.NotSortable
        Next

        'ALINEAR COLUMNAS
        For Each columna As DataGridViewColumn In dgvNuevosExamenesAgrExa.Columns
            If Not columna.Name = clmButtonAccionDgvNueExaAgrExa Then
                columna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
                columna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            End If
        Next


        'CONFIGURAR ANCHO COLUMNAS
        dgvNuevosExamenesAgrExa.Columns(clmCodExamenDgvNueExaAgrExa).FillWeight = 1
        dgvNuevosExamenesAgrExa.Columns(clmNomExamenDgvNueExaAgrExa).FillWeight = 99

        'FILAS
        dgvNuevosExamenesAgrExa.Rows.Clear()
    End Sub

    Private Sub iniciarControlesInterfazGrupo3B()
        panelEliminarExamen.Enabled = True
        panelEliminarExamen.Visible = False

        iniciarDgvExamenesEliExa()

        btnGuardarEliExa.Enabled = True
        btnGuardarEliExa.Visible = True
        btnGuardarEliExa.Font = New Font("Microsoft Sans Serif", 9)
        'btnEliminarExamenes.Text = ""
    End Sub

    Private Sub iniciarDgvExamenesEliExa()
        'ENCABEZADOS LABELS

        'PROPIEDADES BASE
        dgvExamenesEliExa.Enabled = True
        dgvExamenesEliExa.Visible = True
        dgvExamenesEliExa.Font = New Font("Microsoft Sans Serif", 9)
        dgvExamenesEliExa.Rows.Clear()
        dgvExamenesEliExa.Columns.Clear()

        'PERMISOS EDITAR
        dgvExamenesEliExa.EditMode = DataGridViewEditMode.EditOnEnter
        dgvExamenesEliExa.AllowUserToAddRows = False
        dgvExamenesEliExa.AllowUserToDeleteRows = False
        dgvExamenesEliExa.AllowUserToResizeRows = False
        dgvExamenesEliExa.AllowUserToOrderColumns = False
        dgvExamenesEliExa.AllowUserToResizeColumns = False
        dgvExamenesEliExa.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgvExamenesEliExa.MultiSelect = False
        dgvExamenesEliExa.ReadOnly = False

        'PROPIEDADES MODOS DE SELECCION
        dgvExamenesEliExa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvExamenesEliExa.SelectionMode = DataGridViewSelectionMode.CellSelect

        'PROPIEDADES COLOR CABEZAS COLUMNAS 
        dgvExamenesEliExa.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(235, 235, 235)
        dgvExamenesEliExa.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black

        'PROPIEDADES COLOR CABEZERAS FILAS
        dgvExamenesEliExa.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 255, 255)
        dgvExamenesEliExa.RowHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 0, 0)

        'PROPIEDAES COLOR CELDAS NORMALES
        dgvExamenesEliExa.BackgroundColor = Color.FromArgb(255, 255, 255)
        dgvExamenesEliExa.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255)
        dgvExamenesEliExa.DefaultCellStyle.ForeColor = Color.Black

        'PROPIEDADES COLOR FILAS SELECCIONADAS
        dgvExamenesEliExa.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 255, 255)
        dgvExamenesEliExa.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 0, 0)

        'OTRAS PROPIEDAES
        dgvExamenesEliExa.ScrollBars = ScrollBars.Both
        dgvExamenesEliExa.EnableHeadersVisualStyles = False




        'COLUMNAS 
        dgvExamenesEliExa.Columns.Clear()

        dgvExamenesEliExa.Columns.Add(clmCodExamenEliExa, "CODIGO")
        dgvExamenesEliExa.Columns(clmCodExamenEliExa).Visible = False

        dgvExamenesEliExa.Columns.Add(clmNomExamenEliExa, "EXAMEN")
        dgvExamenesEliExa.Columns(clmNomExamenEliExa).Visible = True

        dgvExamenesEliExa.Columns.Add(clmIndividualEliExa, "PUEDE SOLICITARSE INDIVIDUALMENTE")
        dgvExamenesEliExa.Columns(clmIndividualEliExa).Visible = True

        Dim cboxColumn As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn()
        cboxColumn.Name = clmCheckboxEliExa
        cboxColumn.HeaderText = "ELIMINAR"
        dgvExamenesEliExa.Columns.Add(cboxColumn)
        dgvExamenesEliExa.Columns(clmCheckboxEliExa).Visible = True



        'BLOQUEAR ORDENAR POR COLUMNA
        For Each columna As DataGridViewColumn In dgvExamenesEliExa.Columns
            columna.SortMode = DataGridViewColumnSortMode.NotSortable
        Next

        'ALINEAR COLUMNAS
        For Each columna As DataGridViewColumn In dgvExamenesEliExa.Columns
            If Not columna.Name = clmCheckboxEliExa Then
                columna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
                columna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            End If
        Next


        'CONFIGURAR ANCHO COLUMNAS
        dgvExamenesEliExa.Columns(clmNomExamenEliExa).FillWeight = 50
        dgvExamenesEliExa.Columns(clmIndividualEliExa).FillWeight = 40
        dgvExamenesEliExa.Columns(clmCheckboxEliExa).FillWeight = 10

        'FILAS
        dgvExamenesEliExa.Rows.Clear()
        dgvExamenesEliExa.Rows.Add()
    End Sub

    Private Sub establecerDisplay()
        '    Dim ejeX As Short, ejeY As Short
        '    ejeX = Utilitarios.resolucionEstandarEjeX
        '    ejeY = Utilitarios.resolucionEstandarEjeY

        '    Size = New Size(ejeX, ejeY)
        '    MinimumSize = New System.Drawing.Size(ejeX, ejeY)
        '    MaximumSize = New System.Drawing.Size(ejeX, ejeY)

        Me.CenterToScreen()
    End Sub








    'METODOS LOGICOS G1
    Private Sub logSeleccionarArea()
        Dim index As Short = cboxArea.SelectedIndex
        areaSeleccionada = registro.areas(index)
    End Sub

    'METODOS LOGICOS G2
    Private Sub logSeleccionarGrupo()
        Dim index As Short

        For Each row As DataGridViewRow In dgvGrupos.SelectedRows
            index = row.Index
        Next

        grupoSeleccionado = registro.grupos(index)
    End Sub

    Private Sub logSeleccionarAccion()
        Dim index As Short = cboxAccion.SelectedIndex
        If index = 0 Then accionSeleccionada = 1
        If index = 1 Then accionSeleccionada = 2
    End Sub

    Private Sub logReiniciarConAccion()
        accionSeleccionada = 0
    End Sub

    'METODOS LOGICOS G3A
    Private Sub logSeleccionarExamenAgrExa()
        Dim index As Short = cboxExamenAgrExa.SelectedIndex
        nuevoExamenSeleccionado = registro.examenesDelArea(index)
    End Sub

    Private Sub logEnviarDatosDeLista()
        Dim mensajeValidacion As String

        mensajeValidacion = logValidarEntradasDeLista()

        If mensajeValidacion = "" Then
            registro.agregarExamenEnLista(nuevosExamenesAgrExa, nuevoExamenSeleccionado)
        Else
            mostrarMensaje(mensajeValidacion)
        End If
    End Sub

    Private Function logValidarEntradasDeLista() As String
        Dim mensaje As String = registro.validarEntradasDeLista(nuevoExamenSeleccionado, nuevosExamenesAgrExa)
        Return mensaje
    End Function


    'METODOS LOGICOS G9A
    Private Sub logEnviarDatosAgregarExamen()
        Dim mensajeValidacion As String = logValidarEntradasAgregarExamen()

        If mensajeValidacion = "" Then
            logEnviarDatosDatabaseAgregarExamen()
        Else
            mostrarMensaje(mensajeValidacion)
        End If
    End Sub

    Private Sub logEnviarDatosDatabaseAgregarExamen()
        Dim estadoInsercion As Short, mensajeInsercion As String

        registro.insertNuevosExamenes(grupoSeleccionado, nuevosExamenesAgrExa)
        estadoInsercion = registro.estadoInsercion
        mensajeInsercion = registro.generarMensajeInsercionAgregarExamen()
        mostrarMensaje(mensajeInsercion)

        If estadoInsercion > 0 Then
            logIniciarFormularioAgregarExamen()
            intReiniciarPanelesAgregarEliminarExamen()
        End If
    End Sub

    Private Function logValidarEntradasAgregarExamen() As String
        Dim mensaje As String = registro.validarEntradasAgregarExamen(nuevosExamenesAgrExa)
        Return mensaje
    End Function

    Private Sub logIniciarFormularioAgregarExamen()
        nuevosExamenesAgrExa.vaciarLista()
        registro.estadoInsercion = 0

        registro.traerExamenesDelGrupo(grupoSeleccionado)
        intPoblarDgvExamenesAgrExa()
        intDeseleccionarDgvExamenesAgrExa()

        registro.traerExamenesDelArea(areaSeleccionada)
        intPoblarCboxExamenAgrExa()
        hintExamenAgrExa.Visible = True

        intDeseleccionarDgvNuevosExamenesAgrExa()
    End Sub

    'METODOS LOGICOS G9B
    Private Sub logEnviarDatosEliminarExamen()
        Dim entradasCargadas As Boolean, mensajeValidacion As String, objetosCargados As Boolean

        entradasCargadas = logCargarEntradasEliminarExamen()

        If entradasCargadas Then
            mensajeValidacion = logValidarEntradasEliminarExamen()

            If mensajeValidacion = "" Then
                objetosCargados = logCargarObjetosEliminarExamen()

                If objetosCargados Then logEnviarDatosDatabaseEliminarExamen()
            Else
                mostrarMensaje(mensajeValidacion)
            End If
        End If

    End Sub

    Private Function logCargarEntradasEliminarExamen() As Boolean
        Try
            examenesMarcados = registro.generarListaExamenesMarcados(dgvExamenesEliExa.Rows, clmCheckboxEliExa, clmCodExamenEliExa)
            Return True

        Catch ex As Exception
            mostrarMensaje(ex.Message)
            Return False
        End Try
    End Function

    Private Function logValidarEntradasEliminarExamen() As String
        Dim mensaje As String = registro.validarEntradasEliminarExamenn(examenesMarcados)
        Return mensaje
    End Function

    Private Function logCargarObjetosEliminarExamen() As Boolean
        Try
            examenesParaConservarEliExa = registro.generarListaExamenesParaConservar(examenesMarcados)
            Return True

        Catch ex As Exception
            mostrarMensaje(ex.Message)
            Return False
        End Try
    End Function

    Private Sub logEnviarDatosDatabaseEliminarExamen()
        Dim estadoInsercion As Short, mensajeInsercion As String

        registro.updateExamenes(examenesParaConservarEliExa, grupoSeleccionado)
        estadoInsercion = registro.estadoInsercion
        mensajeInsercion = registro.generarMensajeInsercionEliminarExamen
        mostrarMensaje(mensajeInsercion)
        If estadoInsercion > 0 Then
            logIniciarFormularioEliminarExamen()
            intReiniciarPanelesAgregarEliminarExamen()
        End If
    End Sub

    Private Sub logIniciarFormularioEliminarExamen()
        nuevosExamenesAgrExa.vaciarLista()
        registro.estadoInsercion = 0

        registro.traerExamenesDelGrupo(grupoSeleccionado)
        intPoblarDgvExamenesEliExa()
        intHacerReadonlyDgvExamenesEliExa()
        intDeseleccionarDgvExamenesEliExa()
    End Sub














    'METODOS INTERFAZ G1
    Private Sub intPoblarCboxArea()
        cboxArea.Items.Clear()

        For Each area As AreaLaboratorio In registro.areas
            cboxArea.Items.Add(area.getNombre())
        Next
    End Sub

    Private Sub intOcultarHintArea()
        hintArea.Visible = False
    End Sub


    'METODOS INTERFAZ G2
    Private Sub intPoblarDgvGrupos()
        dgvGrupos.Rows.Clear()

        For Each grupo As GrupoExamenLaboratorio In registro.grupos
            Dim rowIndex As Short, rowAux As DataGridViewRow, codigo As String, nombre As String

            rowIndex = dgvGrupos.Rows.Add()
            rowAux = dgvGrupos.Rows(rowIndex)
            codigo = grupo.getCodigo()
            nombre = grupo.getNombre()

            rowAux.Cells(clmCodGrupoDgvGru).Value = codigo
            rowAux.Cells(clmNomGrupoDgvGru).Value = nombre
        Next
    End Sub

    Private Sub intDeseleccionarDgvGrupos()
        dgvGrupos.ClearSelection()
    End Sub

    Private Sub intOcultarHintAccion()
        hintAccion.Visible = False
    End Sub

    Private Sub intHabilitarConAccion()
        lblAccion.Enabled = True
        cboxAccion.Enabled = True
        hintAccion.Enabled = True
    End Sub

    Private Sub intDeshabilitarConAccion()
        lblAccion.Enabled = False
        cboxAccion.Enabled = False
        hintAccion.Enabled = False
    End Sub

    Private Sub intReiniciarConAccion()
        cboxAccion.SelectedIndex = -1
        hintAccion.Visible = True
    End Sub


    'METODOS INTERFAZ G3
    Private Sub intMostrarPanelAccionSeleccionada()
        If accionSeleccionada = 1 Then
            panelAgregarExamen.Visible = True 'MOSTRAR
            panelEliminarExamen.Visible = False 'OCULTAR

        ElseIf accionSeleccionada = 2 Then
            panelEliminarExamen.Visible = True 'MOSTRAR
            panelAgregarExamen.Visible = False 'OCULTAR
        End If

    End Sub

    Private Sub intReiniciarPanelesAgregarEliminarExamen()
        panelAgregarExamen.Visible = False
        panelEliminarExamen.Visible = False
    End Sub


    'METODOS INTERFAZ G3A
    Private Sub intPoblarDgvExamenesAgrExa()
        dgvExamenesAgrExa.Rows.Clear()

        For Each examen As ExamenLaboratorio In registro.examenesDelGrupo
            Dim rowIndex As Short, rowAux As DataGridViewRow, codigo As String, nombre As String

            rowIndex = dgvExamenesAgrExa.Rows.Add()
            rowAux = dgvExamenesAgrExa.Rows(rowIndex)
            codigo = examen.getCodigo()
            nombre = examen.getNombre()

            rowAux.Cells(clmCodExamenDgvExaAgrExa).Value = codigo
            rowAux.Cells(clmNomExamenDgvExaAgrExa).Value = nombre
        Next
    End Sub

    Private Sub intDeseleccionarDgvExamenesAgrExa()
        dgvExamenesAgrExa.ClearSelection()
    End Sub

    Private Sub intDeshabilitarDgvExamenesAgrExa(_bloquear As Boolean)
        If _bloquear Then dgvExamenesAgrExa.Enabled = False

        dgvExamenesAgrExa.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Control
        dgvExamenesAgrExa.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.GrayText

        dgvExamenesAgrExa.DefaultCellStyle.BackColor = SystemColors.Control
        dgvExamenesAgrExa.DefaultCellStyle.ForeColor = SystemColors.GrayText

        dgvExamenesAgrExa.RowsDefaultCellStyle.SelectionBackColor = SystemColors.Control
        dgvExamenesAgrExa.RowsDefaultCellStyle.SelectionForeColor = SystemColors.GrayText

        dgvExamenesAgrExa.BackgroundColor = SystemColors.Control
        dgvExamenesAgrExa.CurrentCell = Nothing
        dgvExamenesAgrExa.ReadOnly = True
        dgvExamenesAgrExa.EnableHeadersVisualStyles = False
    End Sub

    Private Sub intPoblarCboxExamenAgrExa()
        cboxExamenAgrExa.Items.Clear()

        For Each examen As ExamenLaboratorio In registro.examenesDelArea
            cboxExamenAgrExa.Items.Add(examen.getNombre())
        Next
    End Sub

    Private Sub intOcultarHintExamenAgrExa()
        hintExamenAgrExa.Visible = False
    End Sub

    Private Sub intPoblarDgvNuevosExamenesAgrExa()
        dgvNuevosExamenesAgrExa.Rows.Clear()

        Dim nodo As NodoExamenLaboratorio
        nodo = nuevosExamenesAgrExa.raiz

        While nodo IsNot Nothing
            Dim examen As ExamenLaboratorio, rowIndex As Short, rowAux As DataGridViewRow,
                codigo As String, nombre As String

            examen = nodo.examen

            rowIndex = dgvNuevosExamenesAgrExa.Rows.Add()
            rowAux = dgvNuevosExamenesAgrExa.Rows(rowIndex)
            codigo = examen.getCodigo()
            nombre = examen.getNombre()

            rowAux.Cells(clmCodExamenDgvNueExaAgrExa).Value = codigo
            rowAux.Cells(clmNomExamenDgvNueExaAgrExa).Value = nombre

            nodo = nodo.siguiente
        End While
    End Sub

    Private Sub intDeseleccionarDgvNuevosExamenesAgrExa()
        dgvNuevosExamenesAgrExa.ClearSelection()
    End Sub

    Private Sub intIniciarControlesAgrExa()
        dgvExamenesAgrExa.Rows.Clear()
        cboxExamenAgrExa.SelectedIndex = -1
        hintExamenAgrExa.Visible = True
        dgvNuevosExamenesAgrExa.Rows.Clear()
    End Sub

    Private Sub intIniciarControlesEliExa()
        dgvExamenesEliExa.Rows.Clear()
    End Sub

    'METODOS INTERFAZ G3B
    Private Sub intPoblarDgvExamenesEliExa()
        dgvExamenesEliExa.Rows.Clear()

        For Each examen As ExamenLaboratorio In registro.examenesDelGrupo
            Dim rowIndex As Short, rowAux As DataGridViewRow, codigo As String, nombre As String,
                codIndividual As Short, descripcion As String

            rowIndex = dgvExamenesEliExa.Rows.Add()
            rowAux = dgvExamenesEliExa.Rows(rowIndex)

            codigo = examen.getCodigo()
            nombre = examen.getNombre()
            codIndividual = examen.getCodigoIndividual()


            rowAux.Cells(clmCodExamenEliExa).Value = codigo
            rowAux.Cells(clmNomExamenEliExa).Value = nombre
            If codIndividual = 1 Then descripcion = "SI"
            If codIndividual = 2 Then descripcion = "NO"
            rowAux.Cells(clmIndividualEliExa).Value = descripcion
        Next
    End Sub

    Private Sub intDeseleccionarDgvExamenesEliExa()
        dgvExamenesEliExa.ClearSelection()
    End Sub

    Private Sub intHacerReadonlyDgvExamenesEliExa()
        For Each column As DataGridViewColumn In dgvExamenesEliExa.Columns
            If Not column.Name = clmCheckboxEliExa Then column.ReadOnly = True
        Next
    End Sub

    'METODOS INTERFAZ G9
    Private Sub mostrarMensaje(ByVal _mensaje As String)
        MessageBox.Show(_mensaje, "Mensaje")
    End Sub







    'EVENTOS G0
    Private Sub menuStripMenuLaboratorio_Click(sender As Object, e As EventArgs) Handles menuStripMenuLaboratorio.Click
        Dim form As FormMenuLaboratorio
        form = New FormMenuLaboratorio()
        form.Show()
        Me.Close()
    End Sub

    'EVENTOS G1
    Private Sub cboxArea_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxArea.SelectionChangeCommitted
        Try
            logSeleccionarArea()
            intOcultarHintArea()

            registro.traerGrupos(areaSeleccionada)
            intPoblarDgvGrupos()
            intDeseleccionarDgvGrupos()

            intReiniciarConAccion()
            intDeshabilitarConAccion()


        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    'EVENTOS G2
    Private Sub dgvGrupos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGrupos.CellClick
        Try
            logSeleccionarGrupo()
            logReiniciarConAccion()
            intReiniciarConAccion()
            intHabilitarConAccion()
            intReiniciarPanelesAgregarEliminarExamen()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub dgvGruposSeleccionarGrupo_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvGrupos.RowPostPaint
        Try
            Dim grid = TryCast(sender, DataGridView)
            Dim rowIdx = (e.RowIndex + 1).ToString()
            Dim centerFormat = New StringFormat() With
                           {
                            .Alignment = StringAlignment.Center,
                            .LineAlignment = StringAlignment.Center
                           }
            Dim headerBounds = New Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height)
            e.Graphics.DrawString(rowIdx, Me.Font, SystemBrushes.ControlText, headerBounds, centerFormat)


        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub cboxAccion_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxAccion.SelectionChangeCommitted
        Try
            logSeleccionarAccion()
            intOcultarHintAccion()
            intMostrarPanelAccionSeleccionada()

            If accionSeleccionada = 1 Then 'G3A
                intIniciarControlesAgrExa()
                logIniciarFormularioAgregarExamen()

            ElseIf accionSeleccionada = 2 Then 'G3B
                intIniciarControlesEliExa()
                logIniciarFormularioEliminarExamen()
            End If

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub


    'EVENTOS G3A
    Private Sub dgvExamenesDelGrupoAgregarExamen_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvExamenesAgrExa.RowPostPaint
        Try
            Dim grid = TryCast(sender, DataGridView)
            Dim rowIdx = (e.RowIndex + 1).ToString()
            Dim centerFormat = New StringFormat() With
                           {
                            .Alignment = StringAlignment.Center,
                            .LineAlignment = StringAlignment.Center
                           }
            Dim headerBounds = New Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height)
            e.Graphics.DrawString(rowIdx, Me.Font, SystemBrushes.ControlText, headerBounds, centerFormat)


        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub cboxExamenAgregarExamen_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxExamenAgrExa.SelectionChangeCommitted
        Try
            logSeleccionarExamenAgrExa()
            intOcultarHintExamenAgrExa()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub btnAgregarExamenNuevosExamenes_Click(sender As Object, e As EventArgs) Handles btnAgregarAgrExa.Click
        Try
            logEnviarDatosDeLista()
            intPoblarDgvNuevosExamenesAgrExa()
            intDeseleccionarDgvNuevosExamenesAgrExa()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub dgvNuevosExamenesAgrExa_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNuevosExamenesAgrExa.CellClick
        Try
            Dim columnIndex As Short, filaIndex As Short, clmAccionIndex As Short

            columnIndex = e.ColumnIndex
            filaIndex = e.RowIndex
            clmAccionIndex = dgvNuevosExamenesAgrExa.Columns(clmButtonAccionDgvNueExaAgrExa).Index


            If filaIndex >= 0 And columnIndex = clmAccionIndex Then
                Dim row As DataGridViewRow, _codigo As Long

                row = dgvNuevosExamenesAgrExa.Rows(filaIndex)
                _codigo = row.Cells(clmCodExamenDgvNueExaAgrExa).Value
                registro.eliminarExamen(_codigo, nuevosExamenesAgrExa)
                intPoblarDgvNuevosExamenesAgrExa()
            End If

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub dgvNuevosExamenesAgrExa_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvNuevosExamenesAgrExa.RowPostPaint
        Try
            Dim grid = TryCast(sender, DataGridView)
            Dim rowIdx = (e.RowIndex + 1).ToString()
            Dim centerFormat = New StringFormat() With
                           {
                            .Alignment = StringAlignment.Center,
                            .LineAlignment = StringAlignment.Center
                           }
            Dim headerBounds = New Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height)
            e.Graphics.DrawString(rowIdx, Me.Font, SystemBrushes.ControlText, headerBounds, centerFormat)


        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub btnAgregarNuevosExamenes_Click(sender As Object, e As EventArgs) Handles btnGuardarAgrExa.Click
        Try
            logEnviarDatosAgregarExamen()


        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    'EVENTOS G3B
    Private Sub dgvExamenesEliExa_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvExamenesEliExa.RowPostPaint
        Try
            Dim grid = TryCast(sender, DataGridView)
            Dim rowIdx = (e.RowIndex + 1).ToString()
            Dim centerFormat = New StringFormat() With
                           {
                            .Alignment = StringAlignment.Center,
                            .LineAlignment = StringAlignment.Center
                           }
            Dim headerBounds = New Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height)
            e.Graphics.DrawString(rowIdx, Me.Font, SystemBrushes.ControlText, headerBounds, centerFormat)


        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub btnGuardarEliExa_Click(sender As Object, e As EventArgs) Handles btnGuardarEliExa.Click
        Try
            logEnviarDatosEliminarExamen()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub


End Class
