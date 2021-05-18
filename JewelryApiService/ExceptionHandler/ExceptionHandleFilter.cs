using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace JewelryApiService.ExceptionHandler
{
    public class ExceptionHandleFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            HttpStatusCode statusCode = HttpStatusCode.InternalServerError;
            string errorMessage = context.Exception.Message;
            string customErrorMessage = "error";
            string stackTrace = context.Exception.StackTrace;

            HttpResponse response = context.HttpContext.Response;
            response.StatusCode = (int)statusCode;
            response.ContentType = "application/json";
            var result = JsonConvert.SerializeObject(
                new
                {
                    message = customErrorMessage,
                    isError = true,
                    errorMessage = errorMessage,
                    errorCode = statusCode,
                    model = string.Empty
                });
            #region Logging  
            #endregion Logging  
            response.ContentLength = result.Length;
            response.WriteAsync(result);
        }
    }
}
