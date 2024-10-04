using Entities.ErrorModel;
using Entities.Exceptions;
using Microsoft.AspNetCore.Diagnostics;
using Services.Contracts;
using System.Net;

namespace WebApi.Extensions
{
	public static class ExceptionMiddlewareExtensions
	{
		// bu kodun uygulamada meydana gelen hataları yakalayıp, belirli bir formatta istemciye geri döndürmektir.
		public static void ConfigureExceptionHandler(this WebApplication app, ILoggerService logger)
		{
			app.UseExceptionHandler(appError =>
			{
				//hata meydana geldiğinde çalıştırılacak olan kod
				appError.Run(async context =>
				{
					context.Response.ContentType = "application/json"; //Yanıtın içerik tipi JSON olarak belirlenir

					var contextFeature = context.Features.Get<IExceptionHandlerFeature>(); //hataya neden olan özellikleri ve hatayı yakalar
					if (contextFeature is not null) 
					{
						context.Response.StatusCode = contextFeature.Error switch
						{
							NotFoundException => StatusCodes.Status404NotFound,
							_ => StatusCodes.Status500InternalServerError

						};

						logger.LogError($"Something went wrong: {contextFeature.Error}");
						await context.Response.WriteAsync(new ErrorDetails() {
							StatusCode = context.Response.StatusCode,
							Message = contextFeature.Error.Message
						}.ToString()); //Hata detaylarını içeren bir JSON yanıtı istemciye gönderilir. Bu yanıt, ErrorDetails sınıfı kullanılarak yapılandırılır
					}
				});
			});
		}
	}
}
