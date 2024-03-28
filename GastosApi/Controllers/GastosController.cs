using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GastosApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GastosController : ControllerBase
    {
        [HttpGet]
        public decimal Get(decimal gasto, decimal gastoDos) {
        
        return gasto + gastoDos;    

        }

        [HttpPost]
        public decimal Add(decimal gasto, decimal gastoDos)
        {

            return gasto + gastoDos;

        }

        [HttpPut]
        public decimal Edit(decimal gasto, decimal gastoDos)
        {

            return gasto + gastoDos;

        }

        [HttpDelete]
        public decimal Delete(decimal gasto, decimal gastoDos)
        {

            return gasto + gastoDos;

        }
    }
}
