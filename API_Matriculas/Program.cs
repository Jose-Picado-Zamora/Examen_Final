using Services;
using Services.Niveles;
using Services.Matriculas;
using Services.Estudiantes;
using Services.Cursos;
using Services.Carreras;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddScoped<ISvCarrera, SvCarrera>();
builder.Services.AddScoped<IsVCursos, SvCursos>();
builder.Services.AddScoped<IsVEstudiantes, SvEstudiantes>();
builder.Services.AddScoped<IsVMatriculas, SvMatriculas>();
builder.Services.AddScoped<IsVNiveles, SvNiveles>();

//
builder.Services.AddControllers()
    .AddNewtonsoftJson(x =>
 x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);


builder.Services.AddCors(options =>
{
    options.AddPolicy("Policy1", builder =>
    {
        builder.WithOrigins("https://localhost:5173")
            .WithMethods("GET", "POST")
            .WithHeaders("Content-Type");
    });

});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
