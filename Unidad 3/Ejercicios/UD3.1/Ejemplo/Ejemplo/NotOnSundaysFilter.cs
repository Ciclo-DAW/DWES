using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejemplo
{
    public class NotOnSundaysFilter : Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
                context.Result = new ContentResult()
                {
                    Content = "Lo siento, no trabajo los domingos"
                };
        }
    }
}
