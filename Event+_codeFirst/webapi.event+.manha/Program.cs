using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

//Adiciona o servi�o de Controller
builder.Services.AddControllers();

//Adiciona servi�o Jwt Bearer (forma de autentica��o)
//Deixar indentado assim:
builder.Services.AddAuthentication(options =>
{
    options.DefaultChallengeScheme = "JwtBearer";
    options.DefaultAuthenticateScheme = "JwtBearer";
})

//Deixar indentado assim:
.AddJwtBearer("JwtBearer", options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        //Valida quem esta solicitando 
        ValidateIssuer = true,

        //Valida quem esta recebendo
        ValidateAudience = true,

        //Define se o tempo de expira��o ser� validado
        ValidateLifetime = true,

        //Forma de criptografia que valida a chave de autentifica��o
        IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("senai-event+codefirst-chave-autenticacao-webapi-dev")),

        //Valida o tempo de expira��o do token
        ClockSkew = TimeSpan.FromMinutes(10),

        //Nome do issuer (de onde esta vindo)
        ValidIssuer = "webapi.event+.manha",

        //Nome do issuer (para onde esta indo)
        ValidAudience = "webapi.event+.manha"
    };
});


//Adiciona o servi�o swagger
builder.Services.AddSwaggerGen(options =>
{

//Adiciona informa��es sobre a API no Swagger
options.SwaggerDoc("v1", new OpenApiInfo
{
    Version = "v1",
    Title = "API Event+",
    Description = "API para gerenciamento de Eventps (backend API)",

    Contact = new OpenApiContact
    {
        Name = "Everton - DevManh�",
        Url = new Uri("https://github.com/Evertonaraujo88")
    },
});

//Configura o swagger para usar o arquivo XML gerado
// using System.Reflection;
var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));

options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
{
    Name = "Authorization",
    Type = SecuritySchemeType.ApiKey,
    Scheme = "Bearer",
    BearerFormat = "JWT",
    In = ParameterLocation.Header,
    Description = "Value: Bearer TokenJWT ",
});
options.AddSecurityRequirement(new OpenApiSecurityRequirement
 {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] {}
        }
    });
});

var app = builder.Build();

//Come�a a configura��o do swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
});
//Finaliza a configura��o do swagger

//Adiciona mapeamento dos Controllers
app.MapControllers();

//Adiciona autentifica��o
app.UseAuthentication();

//Adiciona autoriza��o
app.UseAuthorization();

app.UseHttpsRedirection();

app.Run();
