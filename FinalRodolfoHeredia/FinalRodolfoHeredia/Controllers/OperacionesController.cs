using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalRodolfoHeredia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperacionesController : ControllerBase
    {
        [HttpGet]
        public string operaciones(int numero)
        {
            if (numero == 0)
                return "Realizado por Rodolfo Heredia";
            else if (numero < 0)
                return "Error";
            else
                return "https://image.freepik.com/vector-gratis/numeros-cartel-imagen_1639-6453.jpg";

        }
    }
}
