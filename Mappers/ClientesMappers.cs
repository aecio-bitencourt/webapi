using API.Dtos.Clientes;
using API.Models;

namespace API.Mappers
{
    public static class ClientesMappers
    {
        public static ClientesDto ToClientesDto(this Clientes ClientesModel)
        {
            return new ClientesDto
            {
                Codigo = ClientesModel.Codigo,
                Nome = ClientesModel.Nome,
                CNPJ = ClientesModel.CNPJ,
                Inscricao = ClientesModel.Inscricao,
                Endereco = ClientesModel.Endereco,
                CEP = ClientesModel.CEP,
                Estado = ClientesModel.Estado,
                Contato = ClientesModel.Contato,
                Telefone = ClientesModel.Telefone,
                Tipo_do_Cliente = ClientesModel.Tipo_do_Cliente,
                Regiao = ClientesModel.Regiao,
                Endereco_de_Cobranca = ClientesModel.Endereco_de_Cobranca,
                Bairro_de_Cobranca = ClientesModel.Bairro_de_Cobranca,
                CEP_de_Cobranca = ClientesModel.CEP_de_Cobranca,
                Municipio_de_Cobranca = ClientesModel.Municipio_de_Cobranca,
                Estado_de_Cobranca = ClientesModel.Estado_de_Cobranca,
                Vendedor = ClientesModel.Vendedor,
                Telefone_de_Cobranca = ClientesModel.Telefone_de_Cobranca,
                Contato_de_Cobranca = ClientesModel.Contato_de_Cobranca,
                Endereco_de_Entrega = ClientesModel.Endereco_de_Entrega,
                Bairro_de_Entrega = ClientesModel.Bairro_de_Entrega,
                CEP_de_Entrega = ClientesModel.CEP_de_Entrega,
                Municipio_de_Entrega = ClientesModel.Municipio_de_Entrega,
                Estado_de_Entrega = ClientesModel.Estado_de_Entrega,
                Pais_de_Entrega = ClientesModel.Pais_de_Entrega,
                Telefone_de_Entrega = ClientesModel.Telefone_de_Entrega,
                Contato_de_Entrega = ClientesModel.Contato_de_Entrega,
                Departamento1 = ClientesModel.Departamento1,
                Centro_de_Custo = ClientesModel.Centro_de_Custo,
                Grupo_Empresarial = ClientesModel.Grupo_Empresarial,
                Codigo_Matriz = ClientesModel.Codigo_Matriz,
                Email = ClientesModel.Email
            };
        }
    }
}