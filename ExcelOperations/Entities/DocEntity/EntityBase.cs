namespace ExcelOperations.Entities.DocEntity
{
    public abstract class EntityBase : IEntityBase
    {
        public static int GetTableNumber(Type type)
        {
            return type
                .GetInterfaces()
                .Any(i => typeof(IListAccess).IsAssignableFrom(i))
                ? 1
                : 0;
        }

        public static int GetTableNumber<T>()
            where T : IEntityBase
        {
            return GetTableNumber(typeof(T));
        }
    }
}
