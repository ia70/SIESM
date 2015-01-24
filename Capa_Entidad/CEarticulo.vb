Public Class CEarticulo
    Private _id_articulo As String
    Private _nombre_corto As String
    Private _nombre_largo As String
    Private _descripcion As String
    Private _imagen As Byte()
    Private _fecha_registro As String

    Public Property id_articulo As String
        Get
            Return _id_articulo
        End Get
        Set(value As String)
            _id_articulo = value
        End Set
    End Property
    Public Property nombre_corto As String
        Get
            Return _nombre_corto
        End Get
        Set(value As String)
            _nombre_corto = value
        End Set
    End Property
    Public Property nombre_largo As String
        Get
            Return _nombre_largo
        End Get
        Set(value As String)
            _nombre_largo = value
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
    Public Property imagen As Byte()
        Get
            Return _imagen
        End Get
        Set(value As Byte())
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
