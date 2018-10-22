Imports AutoMapper

Public Class Form1

    Private Sub btnGerarMapeamento_Click(sender As Object, e As EventArgs) Handles btnGerarMapeamento.Click

        Mapper.CreateMap(Of Aluno, AlunoViewItem)() _
        .ForMember(Function(av) av.Endereco, Sub(m) m.MapFrom(Function(a) a.Endereco.Cidade + ", " + a.Endereco.Rua)) _
        '.ForMember(Function(av) av.Nascimento, Function(m) m.ResolveUsing(Function(src)
        '                                                                      Dim dt = DirectCast(src.Nascimento, DateTime)
        '                                                                      Return dt.ToShortDateString()
        '                                                                  End Function))
        Dim aluno As New Aluno() With
        { _
                    .Nome = "Macoratti", _
                   .Email = "macoratti@yahoo.com", _
                   .Endereco = New Endereco() With
                               { _
                               .Pais = "Brasil", _
                               .Cidade = "Brasilia", _
                               .Rua = "Rua Projetada 100", _
                               .Cep = "88900-520" _
                              }, _
                   .Genero = "Masculino", _
                   .Idade = 35, _
                   .Nascimento = New DateTime(1975, 10, 9) _
        }

        Dim _alunoViewItem As AlunoViewItem = Mapper.Map(Of Aluno, AlunoViewItem)(aluno)

        lbDados.Items.Add(_alunoViewItem.Nome)
        lbDados.Items.Add(_alunoViewItem.Email)
        lbDados.Items.Add(_alunoViewItem.Endereco)
        lbDados.Items.Add(_alunoViewItem.Genero)
        lbDados.Items.Add(_alunoViewItem.Nascimento)
        lbDados.Items.Add(_alunoViewItem.Idade)

    End Sub
End Class
