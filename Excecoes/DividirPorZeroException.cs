[System.Serializable]
public class DividirPorZeroException : System.Exception
{
    public DividirPorZeroException() { }
    public DividirPorZeroException(string message) : base(message) { }
    public DividirPorZeroException(string message, System.Exception inner) : base(message, inner) { }
    protected DividirPorZeroException(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}
