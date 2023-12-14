using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SurveyApi.Api.Filters;
using SurveyApi.Core.Repositories;
using SurveyApi.Core.Services;
using SurveyApi.Core.UnitOfWorks;
using SurveyApi.Repository;
using SurveyApi.Repository.Repositories;
using SurveyApi.Repository.UnitOfWorks;
using SurveyApi.Service.Mapping;
using SurveyApi.Service.Services;
using SurveyApi.Service.Validations;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//filter'ý buraya ekledik
builder.Services.AddControllers(options => options.Filters.Add(new ValidateFilterAttribute())).AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<AnswerDtoPostValidator>()).AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<QuestionDtoPostValidator>())
    .AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<SurveyDtoPostValidator>());
//api nin kendisinin döndüðü modeli kapatacaðýz ki bizim filterdaki model dönsün hatada:
builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.SuppressModelStateInvalidFilter = true;
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUnitOfWork,UnitOfWork>();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(IService<>), typeof(Service<>));
builder.Services.AddScoped<ISurveyService,SurveyService>();
builder.Services.AddScoped<ISurveyRepository,SurveyRepository>();
builder.Services.AddScoped<IQuestionService, QuestionService>();
builder.Services.AddScoped<IQuestionRepository, QuestionRepository>();
builder.Services.AddAutoMapper(typeof(MapProfile));

builder.Services.AddDbContext<AppDbContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), option =>
    {
        option.MigrationsAssembly(Assembly.GetAssembly(typeof(AppDbContext)).GetName().Name);
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
