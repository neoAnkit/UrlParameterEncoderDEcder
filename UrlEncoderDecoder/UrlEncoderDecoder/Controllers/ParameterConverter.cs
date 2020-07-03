using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UrlEncoderDecoder.Controllers
{
    public class ParameterConverter : ActionFilterAttribute
    {
        private readonly string _parameterName;

        public ParameterConverter(string parameterName)
        {
            _parameterName = parameterName;
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.RouteData.Values[_parameterName] != null)
            {
                int id = filterContext.RouteData.Values[_parameterName].ToString() == "a" ? 1 : 2;
                filterContext.ActionParameters[_parameterName] = id;
            }
        }
    }
}