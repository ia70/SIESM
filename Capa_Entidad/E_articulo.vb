Public Class E_articulo
    Private _id_articulo As String
    Private _nombre As String
    Private _descripcion As String
    Private _nivel_critico As Integer
    Private _unidad_medida As String
    Private _precio_compra As Decimal
    Private _precio_venta As Decimal
    Private _imagen As Byte()
    Private _fecha As String

    Public Property id_articulo As String
        Get
            Return _id_articulo
        End Get
        Set(value As String)
            _id_articulo = value
        End Set
    End Property
    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Property descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
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
    Public Property unidad_medida As String
        Get
            Return _unidad_medida
        End Get
        Set(value As String)
            _unidad_medida = value
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
    Public Property imagen As Byte()
        Get
            Return _imagen
        End Get
        Set(value As Byte())
            _imagen = value
        End Set
    End Property
    Public Property fecha As String
        Get
            Return _fecha
        End Get
        Set(value As String)
            _fecha = value
        End Set
    End Property


End Class
