using Domain.Interfaces;

namespace Infrastructure.Data;

public class DataAccess : IDataAccess
{
    public string GetData()
    {
        return "This is the data from the Data Access class.";
    }
}
