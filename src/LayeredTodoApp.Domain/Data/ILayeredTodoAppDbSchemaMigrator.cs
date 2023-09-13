using System.Threading.Tasks;

namespace LayeredTodoApp.Data;

public interface ILayeredTodoAppDbSchemaMigrator
{
    Task MigrateAsync();
}
