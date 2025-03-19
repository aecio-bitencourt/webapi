using API.Dtos.Clientes;
using API.Models;

namespace API.Mappers
{
    public static class ClientesMappers
    {
        public static ClientesDto ToClientesDto(this Clientes clientesModel)
        {
            return new ClientesDto
            {
                Codigo = clientesModel.Codigo,
                Nome = clientesModel.Nome,
                CNPJ = clientesModel.CNPJ,
                Inscricao = clientesModel.Inscricao,
                Endereco = clientesModel.Endereco,
                CEP = clientesModel.CEP,
                Estado = clientesModel.Estado,
                Contato = clientesModel.Contato,
                Telefone = clientesModel.Telefone,
                Tipo_do_Cliente = clientesModel.Tipo_do_Cliente,
                Regiao = clientesModel.Regiao,
                Endereco_de_Cobranca = clientesModel.Endereco_de_Cobranca,
                Bairro_de_Cobranca = clientesModel.Bairro_de_Cobranca,
                CEP_de_Cobranca = clientesModel.CEP_de_Cobranca,
                Municipio_de_Cobranca = clientesModel.Municipio_de_Cobranca,
                Estado_de_Cobranca = clientesModel.Estado_de_Cobranca,
                Vendedor = clientesModel.Vendedor,
                Telefone_de_Cobranca = clientesModel.Telefone_de_Cobranca,
                Contato_de_Cobranca = clientesModel.Contato_de_Cobranca,
                Endereco_de_Entrega = clientesModel.Endereco_de_Entrega,
                Bairro_de_Entrega = clientesModel.Bairro_de_Entrega,
                CEP_de_Entrega = clientesModel.CEP_de_Entrega,
                Municipio_de_Entrega = clientesModel.Municipio_de_Entrega,
                Estado_de_Entrega = clientesModel.Estado_de_Entrega,
                Pais_de_Entrega = clientesModel.Pais_de_Entrega,
                Telefone_de_Entrega = clientesModel.Telefone_de_Entrega,
                Contato_de_Entrega = clientesModel.Contato_de_Entrega,
                Departamento1 = clientesModel.Departamento1,
                Centro_de_Custo = clientesModel.Centro_de_Custo,
                Grupo_Empresarial = clientesModel.Grupo_Empresarial,
                Codigo_Matriz = clientesModel.Codigo_Matriz,
                Email = clientesModel.Email
            };
        }
    }
}
