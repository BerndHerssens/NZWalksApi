
namespace NZWalksApi.Data.Entities
{
    public interface IEntity
    {
        DateTime Created { get; set; }
        int ID { get; set; }
        DateTime Updated { get; set; }
    }
}