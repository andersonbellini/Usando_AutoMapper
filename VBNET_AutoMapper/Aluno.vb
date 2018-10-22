Public Class Aluno
    Public Property Nome() As String
    Public Property Email() As String
    Public Property Endereco() As Endereco
    Public Property Genero() As String
    Public Property Idade() As Integer
    Public Property Nascimento() As DateTime
End Class

Public Class Endereco
    Public Property Pais() As String
    Public Property Cidade() As String
    Public Property Rua() As String
    Public Property Cep() As String
End Class

Public Class AlunoViewItem
    Public Property Nome() As String
    Public Property Email() As String
    Public Property Endereco() As String
    Public Property Genero() As String
    Public Property Idade() As Integer
    Public Property Nascimento() As String

End Class