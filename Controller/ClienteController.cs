using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    public class ClienteController
    {
        public Endereco buscarEnderecoWS(String cep)
        {
            return new EnderecoImpl().buscarEnderecoWebService(cep);
        }
    }
}
