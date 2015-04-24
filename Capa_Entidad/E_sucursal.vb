Public Class E_sucursal
    Private _id_sucursal As Integer
    Private _nombre As String
    Private _direccion As String
    Private _descripcion As String
    Private _telefono As String
    Private _imagen As String
    Private _fecha_registro As String

    Public Property id_sucursal As Integer
        Get
            Return _id_sucursal
        End Get
        Set(value As Integer)
            _id_sucursal = value
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
    Public Property direccion As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            _direccion = value
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
    Public Property telefono As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value
        End Set
    End Property
    Public Property imagen As String
        Get
            Return _imagen
        End Get
        Set(value As String)
            _imagen = value
        End Set
    End Property
    Public Property fecha_registro As String
        Get
            Return _fecha_registro
        End Get
        Set(value As String)
            _fecha_registro = value
        End Set
    End Property

End Class
