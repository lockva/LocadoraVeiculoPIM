using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Model
{
    public class EnderecoImpl
    {
        /**
         * Método responsavel por buscar o CEP e retornar um endereço
        **/
        public Endereco buscarEnderecoWebService(String cep)
        {
            Endereco end = new Endereco();

            try
            {
                DataSet ds = new DataSet();
                ds.ReadXml("https://viacep.com.br/ws/" + cep + "/xml/");

                if ( ds != null ) 
                {

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        end.cep = ds.Tables[0].Rows[0]["cep"].ToString().Trim();
                        end.logradouro = ds.Tables[0].Rows[0]["logradouro"].ToString().Trim();
                        end.bairro = ds.Tables[0].Rows[0]["bairro"].ToString().Trim();
                        end.localidade = ds.Tables[0].Rows[0]["localidade"].ToString().Trim();
                        end.uf = ds.Tables[0].Rows[0]["uf"].ToString().Trim();
                    }
                    else
                    {
                        end = null;
                    }
                }
            }
            catch (ArgumentException e)
            {
                end = null;
            }

            return end;
        }

    }
}
 