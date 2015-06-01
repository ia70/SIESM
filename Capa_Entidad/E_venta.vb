Public Class E_venta

    Private _id_reg As Integer
    Private _id_venta As String
    Private _id_usuario As String
    Private _id_sucursal As String
    Private _id_articulo As String
    Private _transaccion As String
    Private _cantidad As Integer
    Private _precio_compra As String
    Private _precio_venta As String
    Private _fecha As String
    Private _hora As String

    Public Property id_reg As Integer
        Get
            Return _id_reg
        End Get
        Set(value As Integer)
            _id_reg = value
        End Set
    End Property
    Public Property id_venta As String
        Get
            Return _id_venta
        End Get
        Set(value As String)
            _id_venta = value
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
    Public Property transaccion As String
        Get
            Return _transaccion
        End Get
        Set(value As String)
            _transaccion = value
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
    Public Property precio_compra As String
        Get
            Return _precio_compra
        End Get
        Set(value As String)
            If Not Len(value) > 0 Then
                _precio_compra = "0.00"
            Else
                _precio_compra = value
            End If
        End Set
    End Property
    Public Property precio_venta As String
        Get
            Return _precio_venta
        End Get
        Set(value As String)
            If Not Len(value) > 0 Then
                _precio_venta = "0.00"
            Else
                _precio_venta = value
            End If
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
    Public Property hora As String
        Get
            Return _hora
        End Get
        Set(value As String)
            _fecha = value
        End Set
    End Property


End Class
