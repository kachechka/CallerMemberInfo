namespace CallerMemberInfo
{
    public interface ICallInfoService
    {
        CallInfo GetInfo(int skipFrame = 0);
    }
}
