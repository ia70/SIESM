Public Class E_devolucion
    Private _id_registro As String
    Private _id_venta As String
    Private _id_usuario As String
    Private _id_articulo As String
    Private _motivo As String
    Private _accion As String
    Private _descripcion As String
    Private _cantidad As Integer
    Private _fecha As String
    Private _hora As String


    Public Property id_registro As String
        Get
            Return _id_registro
        End Get
        Set(value As String)
            _id_registro = value
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
    Public Property id_articulo As String
        Get
            Return _id_articulo
        End Get
        Set(value As String)
            _id_articulo = value
        End Set
    End Property

    Public Property motivo As String
        Get
            Return _motivo
        End Get
        Set(value As String)
            _motivo = value
        End Set
    End Property

    Public Property accion As String
        Get
            Return _accion
        End Get
        Set(value As String)
            _accion = value
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

    Public Property cantidad As String
        Get
            Return _cantidad
        End Get
        Set(value As String)
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

    Public Property hora As String
        Get
            Return _hora
        End Get
        Set(value As String)
            _hora = value
        End Set
    End Property

End Class