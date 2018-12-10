﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo
{
    public class UpperStringActionResult : ActionResult
    {
        private readonly string str;

        public UpperStringActionResult(string str)
        {
            this.str = str;
        }

        public override void ExecuteResult(ActionContext context)
        {
            var upperStringBytes = Encoding.UTF8.GetBytes(str.ToUpper());

            context.HttpContext.Response.Body.Write(upperStringBytes, 0, upperStringBytes.Length);
        }

    }
}
