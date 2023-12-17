﻿using Microsoft.AspNetCore.Diagnostics;
using SurveyApi.Core.DTOs;
using SurveyApi.Service.Exceptions;
using System.Text.Json;

namespace SurveyApi.Api.Middlewares
{
    public static class UseCustomExceptionHandler
    {
        public static void UseCustomException(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(config =>
            {
                config.Run(async context =>
                {
                    context.Response.ContentType = "application/json";
                    var exceptionfeature = context.Features.Get<IExceptionHandlerFeature>();
                    var statusCode = exceptionfeature.Error switch
                    {
                        ClientSideException => 400,
                        NotFoundException => 404,
                        _ => 500
                    };

                    context.Response.StatusCode = statusCode;

                    var response = CustomResponseDto<NoContentDto>.Fail(statusCode, exceptionfeature.Error.Message);

                    await context.Response.WriteAsync(JsonSerializer.Serialize(response));
                });
            });
        }
    }
}
