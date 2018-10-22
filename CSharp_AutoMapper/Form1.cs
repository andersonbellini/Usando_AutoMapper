using System;
using System.Windows.Forms;
using AutoMapper;

namespace CSharp_AutoMapper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnCriarMapeamento_Click(object sender, EventArgs e)
        {
            Mapper.CreateMap<Aluno, AlunoViewItem>()
               .ForMember(av => av.Endereco,
                          m => m.MapFrom(a =>
                                         a.Endereco.Pais + ", " +
                                         a.Endereco.Cidade + ", " +
                                         a.Endereco.Rua + ", " +
                                         a.Endereco.Cep)
               )
               .ForMember(av => av.Nascimento, 
                           m => m.ResolveUsing(src =>
                                                    {
                                                      var dt = (DateTime)src.Nascimento;
                                                      return dt.ToShortDateString();
                                                    })
               );

            Aluno aluno = new Aluno
            {
                Nome = "Anderson Bellini",
                Email = "teste@teste.com",
                Endereco = new Endereco
                {
                    Pais = "Brasil",
                    Cidade = "Araraquara",
                    Rua = "Rua Bento de Abreu 2018",
                    Cep = "14807-000"
                },
                Genero = "Masculino",
                Idade = 35,
                Nascimento = new DateTime(1983, 9, 9)
            };

            AlunoViewItem _alunoViewItem = Mapper.Map<Aluno, AlunoViewItem>(aluno);

            lbDados.Items.Add(_alunoViewItem.Nome);
            lbDados.Items.Add(_alunoViewItem.Email);
            lbDados.Items.Add(_alunoViewItem.Endereco);
            lbDados.Items.Add(_alunoViewItem.Genero);
            lbDados.Items.Add(_alunoViewItem.Nascimento);
            lbDados.Items.Add(_alunoViewItem.Idade);
        }
       
    }
}
