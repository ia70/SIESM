Public Class E_inventario
    Private _id_inventario As Integer
    Private _id_sucursal As Integer
    Private _id_proveedor As Integer
    Private _id_usuario As String
    Private _id_articulo As String
    Private _existencia As Decimal
    Private _condicion As String
    Private _fecha As Date


    Public Property id_inventario As Integer
        Get
            Return _id_inventario
        End Get
        Set(value As Integer)
            _id_inventario = value
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

    Public Property id_usuario As String
        Get
            Return _id_usuario
        End Get
        Set(value As String)
            _id_usuario = value
        End Set
    End Property
    Public Property id_articulo As String
        Get
            Return _id_usuario
        End Get
        Set(value As String)
            _id_usuario = value
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
    Public Property condicion As String
        Get
            Return _condicion
        End Get
        Set(value As String)
            _condicion = value
        End Set
    End Property
   
    Public Property fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property

End Class
