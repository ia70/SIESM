Public Class E_usuario

    Private _id_usuario As String
    Private _contrasena As String
    Private _nombre As String
    Private _apellidos As String
    Private _sexo As String
    Private _tipo As Integer
    Private _imagen As Byte()
    Private _fecha As String

    Public Property id_usuario As String
        Get
            Return _id_usuario
        End Get
        Set(value As String)
            _id_usuario = value
        End Set
    End Property
    Public Property contrasena As String
        Get
            Return _contrasena
        End Get
        Set(value As String)
            _contrasena = value
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
    Public Property apellidos As String
        Get
            Return _apellidos
        End Get
        Set(value As String)
            _apellidos = value
        End Set
    End Property
    Public Property sexo As String
        Get
            Return _sexo
        End Get
        Set(value As String)
            If value = "Femenino" Then
                _sexo = "F"
            Else
                _sexo = "M"
            End If
        End Set
    End Property
    Public Property tipo As Integer
        Get
            Return _tipo
        End Get
        Set(value As Integer)
            _tipo = value
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

