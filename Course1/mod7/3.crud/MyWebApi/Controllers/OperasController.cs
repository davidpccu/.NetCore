using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyWebApi.Data;
using MyWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController] // 限制json資料類型 (FromBody)
    //[ApiConventionType(typeof(DefaultApiConventions))] //增加Swagger輔助資訊功能，就無需每個action新增 (缺點:也會同時show出建議作法，過於冗長)

    public class OperasController : ControllerBase
    {
        readonly OperaContext _context;
        public OperasController(OperaContext context)
        {
            _context = context;
        }

        // 一般GET(同步)
        // GET: api/<OperasController>
        //[HttpGet]
        //public ActionResult<IEnumerable<Opera>> Get()
        //{
        //    return _context.Operas.ToList();
        //}

        // 非同步
        // GET: api/<OperasController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Opera>>> Get()
        {
            return await _context.Operas.ToListAsync();
        }


        //[HttpGet("{id}")]
        //public ActionResult<Opera> GetOpera(int id)
        //{
        //    var opera = _context.Operas.Find(id);

        //    if(opera == null)
        //    {
        //        return NotFound();
        //    }

        //    return opera;
        //}

        [HttpGet("{id}")]
        public async Task< ActionResult<Opera>> GetOpera(int id)
        {
            var opera = await _context.Operas.FindAsync(id);

            if (opera == null)
            {
                return NotFound();
            }

            return opera;
        }


        // POST api/<ValuesController>
        [HttpPost]
        public async Task <ActionResult <Opera>> Post(Opera opera)
        {
            _context.Operas.Add(opera);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetOpera", new { id = opera.OperaID }, opera);
            return CreatedAtAction(nameof(GetOpera), new { id = opera.OperaID }, opera);
        }

        // PUT api/<ValuesController>/5
        // 增加Swagger輔助資訊功能，不影響程式運行 (MyWebApi.csproj)
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Put(int id, Opera opera)
        {
            if(id != opera.OperaID)
            {
                return BadRequest();
            }

            _context.Update(opera);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // DELETE api/<ValuesController>/5
        // 增加Swagger輔助資訊功能，不影響程式運行 (MyWebApi.csproj)
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<Opera>> Delete(int id)
        {
            var opera = await _context.Operas.FindAsync(id);

            if(opera == null)
            {
                return NotFound();
            }

            _context.Operas.Remove(opera);
            await _context.SaveChangesAsync();
            return opera;
        }
    }
}
