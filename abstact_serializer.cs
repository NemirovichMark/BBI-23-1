namespace serializer_library
{
    public abstract class abstact_serializer
    {
        public virtual void Serializetion<T>(T obj, string filePath)
        {
        }
        public virtual T Deserializetion<T>(string filePath)
        {
            return default(T);
        }
    }
}
