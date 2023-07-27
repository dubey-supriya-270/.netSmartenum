namespace SmartEnumApi.Repository
{
    public class Order
    {
        public int id { get; set; }
        public StatusEnum status { get; set; } = StatusEnum.Open;
    }
}
