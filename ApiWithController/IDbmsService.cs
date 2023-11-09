namespace ApiWithController;

public interface IDbmsService
{
    public void Add(Dbms dbms);
    public Dbms GetById(string id);
}

public interface IHostService
{
    public void Add(Host host);
    public Host GetById(string id);
}

public record Dbms(string Name);
public record Host(string Name);
public record DbmsDto(string Name);
public record HostDto(string Name);

public static class DbmsHostExtensions{

    public static Dbms ToDomain(this DbmsDto dbms) => new(dbms.Name);
    public static Host ToDomain(this HostDto host) => new(host.Name);
    
    public static DbmsDto ToDto(this Dbms dbms) => new(dbms.Name);
    public static HostDto ToDto(this Host host) => new(host.Name);
}