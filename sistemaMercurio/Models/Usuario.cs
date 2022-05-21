using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaMercurio.Models
{
    internal class Usuario
    {
        public int id_usuario { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public string funcao { get; set; }
        public string cpf { get; set; }
        public string data_nascimento { get; set; }
        public string celular { get; set; }
        public string cep { get; set; }
        public string logradouro { get; set; }
        public int numero { get; set; }
        public string uf { get; set; }
        public string bairro { get; set; }
        public string cargo { get; set; }


        public Usuario(
                       string _nome, 
                       string _email,
                       string _senha,
                       string _funcao,
                       string _cpf,
                       string _data_nascimento,
                       string _celular,
                       string _cep,
                       string _logradouro,
                       int _numero,
                       string _uf,
                       string _bairro,
                       string _cargo
            )
        {
            nome = _nome;
            email = _email; 
            senha = _senha; 
            funcao = _funcao;   
            cpf = _cpf; 
            data_nascimento = _data_nascimento; 
            celular = _celular; 
            cep = _cep; 
            logradouro = _logradouro;   
            uf = _uf;   
            bairro = _bairro;   
            cargo = _cargo;
            numero = _numero;
        }

    }
}
