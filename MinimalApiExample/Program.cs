
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MinimalApiExample;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();


app.MapGet("/Dbms/{dbmsId}", (string dbmsId,IDbmsService service) =>
    service.GetById(dbmsId).ToDto());

app.MapPost("/Dbms", [Authorize]([FromBody]DbmsDto dto, IDbmsService service) =>
    service.Add(dto.ToDomain()));

app.MapGet("/Dbms/Host/{hostId}", (string hostId,IHostService service) =>
        service.GetById(hostId).ToDto());


app.Run();

