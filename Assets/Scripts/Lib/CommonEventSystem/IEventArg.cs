public class IEventArg
{
    private object[] m_params = null;

    public object[] Params { get => m_params; set => m_params = value; }

    public IEventArg(params object[] param) { Init(param); }
    public void Init(params object[] param)
    {
        Params = param;
    }
}
