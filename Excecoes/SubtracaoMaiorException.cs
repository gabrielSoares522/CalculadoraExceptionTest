[System.Serializable]
public class SubtracaoMaiorException : System.Exception
{
    public SubtracaoMaiorException() { }
    public SubtracaoMaiorException(string message) : base(message) { }
    public SubtracaoMaiorException(string message, System.Exception inner) : base(message, inner) { }
    protected SubtracaoMaiorException(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}