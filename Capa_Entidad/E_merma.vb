Public Class E_merma
    Private _id_merma As Integer
    Private _id_usuario As String
    Private _id_articulo As String
    Private _id_sucursal As Integer
    Private _motivo As String
    Private _cantidad As Integer
    Private _fecha As String
    Private _hora As String
    
    Public Property id_merma As Integer
        Get
            Return _id_merma
        End Get
        Set(value As Integer)
            _id_merma = value
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
    Public Property id_sucursal As Integer
        Get
            Return _id_sucursal
        End Get
        Set(value As Integer)
            _id_sucursal = value
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
    Public Property cantidad As Decimal
        Get
            Return _cantidad
        End Get
        Set(value As Decimal)
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
