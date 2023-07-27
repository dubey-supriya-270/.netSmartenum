using Ardalis.SmartEnum;
namespace SmartEnumApi.Repository
{
    public class StatusEnum : SmartEnum<StatusEnum>
    {
        public static readonly StatusEnum Open = new StatusEnum(nameof(Open), 1);
        public static readonly StatusEnum Closed = new StatusEnum(nameof(Closed), 2);

        protected StatusEnum(string name, int value) : base(name, value)
        {
        }
    }
}
