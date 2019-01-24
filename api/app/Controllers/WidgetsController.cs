using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using api.Models;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WidgetsController : ControllerBase
    {
        private readonly coreContext _context;

        public WidgetsController(coreContext context)
        {
            _context = context;
        }

        // GET api/widgets
        [HttpGet]
        public IQueryable<Widgets> GetWidgets()
        {
            var widgets = 
            from w in _context.Widgets
            select w;
            return widgets;
        }


        // GET api/widgets/5
        [HttpGet("{id}")]
        public Widgets GetWidgetById(int id)
        {
            Widgets widget = _context.Widgets.Find(id);
            return widget;
        }

        // POST api/widgets
        [HttpPost]
        public void Post([FromBody] Widgets widget)
        {
            _context.Widgets.Add(widget);
            _context.SaveChanges();
        }

        // PUT api/widgets/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Widgets updatedWidget)
        {
            Widgets widget = _context.Widgets.Find(id);
            widget.Name = updatedWidget.Name;
            widget.Quantity = updatedWidget.Quantity;

            _context.SaveChanges();
        }

        // DELETE api/widgets/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Widgets widget = _context.Widgets.Find(id);  
            _context.Widgets.Remove(widget);  
            _context.SaveChanges();  
        }
    }
}
