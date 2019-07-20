using Pedido.DTO;
using Pedido.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Pedido.WebApi.Controllers
{
    public class ProdutoController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage Listar()
        {
            HttpResponseMessage response;
            try
            {
                response = Request.CreateResponse(HttpStatusCode.OK, ProdutoService.ListarTodosProdutos());
            }
            catch (Exception ex)
            {
                response = Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
            
            return response;
        }
    }
}
