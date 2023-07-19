Option Strict On
Imports System.ComponentModel

<DataObject>
Public Class EnumDataSource(Of T As {Structure, IComparable, IFormattable, IConvertible})
    Implements IListSource

    <DataObjectMethod(DataObjectMethodType.Fill)>
    Public Function GetValues() As IEnumerable(Of EnumItem(Of T))
        Return [Enum].GetValues(GetType(T)).
                Cast(Of T)().
                Select(Function(v) New EnumItem(Of T)(v))
    End Function

    Public ReadOnly Property ContainsListCollection As Boolean Implements IListSource.ContainsListCollection
        Get
            Return True
        End Get
    End Property

    Public Function GetList() As IList Implements IListSource.GetList
        Return GetValues().ToList()
    End Function
End Class

Public Class EnumItem(Of T As {Structure, IComparable, IFormattable, IConvertible})

    Public Shared ReadOnly Property Items As IEnumerable(Of EnumItem(Of T))
        Get
            Return From value In [Enum].GetValues(GetType(T))
                   Select New EnumItem(Of T)(CType(value, T))
        End Get
    End Property

    Public Sub New(_value As T)
        If TypeOf _value IsNot [Enum] Then Throw New Exception("EnumItem(Of T) only accepts Enum types")
        Me.Value = _value
        Dim field As Reflection.FieldInfo = EnumType.GetField(Name)
        Dim attr() As DescriptionAttribute = DirectCast(field.GetCustomAttributes(GetType(DescriptionAttribute), False), DescriptionAttribute())
        If attr.Length > 0 Then
            Me.Description = attr(0).Description
        End If
    End Sub

    Public ReadOnly Property EnumType As Type
        Get
            Return GetType(T)
        End Get
    End Property
    Public ReadOnly Property Value As T
    Public ReadOnly Property Name As String
        Get
            Return [Enum].GetName(GetType(T), Value)
        End Get
    End Property

    Public ReadOnly Property IntValue As Integer
        Get
            Return Value.ToInt32(Nothing)
        End Get
    End Property

    Public ReadOnly Property Description As String

End Class
