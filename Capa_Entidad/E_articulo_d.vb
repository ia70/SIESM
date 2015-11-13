Public Class E_articulo_d
    Private _id_reg As Integer
    Private _id_sucursal As String
    Private _id_articulo As String
    Private _id_defectuoso As String
    Private _precio_venta As Decimal
    Private _cantidad As Integer
    Private _fecha As String
    Private _iva As String

    Public Property id_reg As Integer
        Get
            Return _id_reg
        End Get
        Set(value As Integer)
            _id_reg = value
        End Set
    End Property

    Public Property id_sucursal As String
        Get
            Return _id_sucursal
        End Get
        Set(value As String)
            _id_sucursal = value
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

    Public Property id_defectuoso As String
        Get
            Return _id_defectuoso
        End Get
        Set(value As String)
            _id_defectuoso = value
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

    Public Property cantidad As Integer
        Get
            Return _cantidad
        End Get
        Set(value As Integer)
            _cantidad = value
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

    Public Property iva As String
        Get
            Return _iva
        End Get
        Set(value As String)
            _iva = value
        End Set
    End Property


End Class
