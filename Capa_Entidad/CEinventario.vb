Public Class CEinventario
    Private _id_registro As Integer
    Private _id_sucursal As Integer
    Private _id_proveedor As Integer
    Private _id_articulo As String
    Private _unidad_medida As String
    Private _existencia As Decimal
    Private _nivel_critico As Integer
    Private _precio_compra As Decimal
    Private _precio_venta As Decimal
    Private _fecha_surtido As String

    Public Property id_registro As Integer
        Get
            Return _id_registro
        End Get
        Set(value As Integer)
            _id_registro = value
        End Set
    End Property
    Public Property id_sucursal As Integer
        Get
            Return _id_sucursal
        End Get
        Set(value As Integer)
            _id_sucursal = value
        End Set
    End Property
    Public Property id_proveedor As Integer
        Get
            Return _id_proveedor
        End Get
        Set(value As Integer)
            _id_proveedor = value
        End Set
    End Property
    Public Property id_articulo As String
        Get
            Return _id_articulo
        End Get
        Set(value As String)
            _id_articulo = value
        End Set
    End Property
    Public Property unidad_medida As String
        Get
            Return _unidad_medida
        End Get
        Set(value As String)
            _unidad_medida = value
        End Set
    End Property
    Public Property existencia As Decimal
        Get
            Return _existencia
        End Get
        Set(value As Decimal)
            _existencia = value
        End Set
    End Property
    Public Property nivel_critico As Integer
        Get
            Return _nivel_critico
        End Get
        Set(value As Integer)
            _nivel_critico = value
        End Set
    End Property
    Public Property precio_compra As Decimal
        Get
            Return _precio_compra
        End Get
        Set(value As Decimal)
            _precio_compra = value
        End Set
    End Property
    Public Property precio_venta As Decimal
        Get
            Return _precio_venta
        End Get
        Set(value As Decimal)
            _precio_venta = value
        End Set
    End Property
    Public Property fecha_surtido As String
        Get
            Return _fecha_surtido
        End Get
        Set(value As String)
            _fecha_surtido = value
        End Set
    End Property

End Class
