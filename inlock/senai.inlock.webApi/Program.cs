using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

//Adiciona o serviço de Controllers
builder.Services.AddControllers();

//Adiciona servicos de Jwt Bearer (forma de autenticacao)
builder.Services.AddAuthentication(options =>
{
	options.DefaultChallengeScheme = "JwtBearer";
	options.DefaultAuthenticateScheme = "JwtBearer";
})

.AddJwtBearer("JwtBearer", options =>
{
	options.TokenValidationParameters = new TokenValidationParameters
	{
		//valida quem esta solicitanto
		ValidateIssuer = true,

		//valida quem recebe
		ValidateAudience = true,

		//define se tempo de expiracao sera validado
		ValidateLifetime = true,

		//forma de criptografia e valida a chave de autenticacao
		IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("User-chave-autenticacao-senai.inlock.webApi-dev")),

		//valida o tempo de expiracao do token
		ClockSkew = TimeSpan.FromMinutes(5),

		//nome do issuer(onde esta vindo)
		ValidIssuer = "senai.inlock.webApi",

		//nome do audience (para onde esta indo)
		ValidAudience = "senai.inlock.webApi"
	};
});

//Adicione o gerador do Swagger à coleção de serviços
builder.Services.AddSwaggerGen(options =>
{
	options.SwaggerDoc("v1", new OpenApiInfo
	{
		Version = "v1",
		Title = "ToDo API",
		Description = "An ASP.NET Core Web API for managing ToDo items",
		TermsOfService = new Uri("https://example.com/terms"),
		Contact = new OpenApiContact
		{
			Name = "Example Contact",
			Url = new Uri("https://example.com/contact")
		},
		License = new OpenApiLicense
		{
			Name = "Example License",
			Url = new Uri("https://example.com/license")
		}
	});
	var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
	options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));



	//Usando a autenticaçao no Swagger
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

//Começa a configuração do Swagger
//https://learn.microsoft.com/pt-br/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-7.0&tabs=visual-studio

//Habilite o middleware para atender ao documento JSON gerado e à interface do usuário do Swagger
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

//Para atender à interface do usuário do Swagger na raiz do aplicativo
app.UseSwaggerUI(options =>
{
	options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
	options.RoutePrefix = string.Empty;
});

//Finaliza a configuração do Swagger

//Adiciona mapeamento dos Controllers
app.MapControllers();

//Adiciona autenticacao
app.UseAuthentication();

//Adiciona autorizacao
app.UseAuthorization();

app.UseHttpsRedirection();

app.Run();
