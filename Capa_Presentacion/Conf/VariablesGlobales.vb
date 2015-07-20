Module VariablesGlobales
    'Variables generales
    Public DBIP As String

    'Variables Globales Sucursal
    Public G_Sucursal_id As Integer = 0
    Public G_Sucursal_nombre As String = "Lino Merino"
    Public G_Sucursal_Calle As String = ""
    Public G_Sucursal_CP As String = ""
    Public G_Sucursal_Ciudad As String = ""
    Public G_Sucursal_Telefono As String = ""
    Public G_Sucursal_Correo As String = ""
    Public G_Sucursal_Colonia As String = ""

    'Variables Globales Usuario
    Public G_Usuario_id As String = "LIBERTY510"
    Public G_Usuario_Nombre As String = "Daniel"
    Public G_Usuario_Apellidos As String = "Pérez Cortéz"
    Public G_Usuario_Imagen As Image
    Public G_Usuario_Tipo As Integer = 1

    'Variables Globales Punto de Venta
    Public G_PuntoVenta_Total As Decimal
    Public G_PuntoVenta_Monto As Decimal
    Public G_PuntoVenta_CantdadArticulos As Integer
    Public G_PuntoVenta_NumeroTicket As String
    Public G_PuntoVenta_Transacción As String
    Public G_PuntoVenta_TipoPago As String
    Public G_PuntoVenta_Cambio As String
    Public G_PuntoVenta_Descuento As String = ""
    Public G_PuntoVenta_InicioCaja As Integer = 0
    Public G_PuntoVenta_Fecha As String
    Public G_PuntoVenta_Hora As String


End Module
