using System;
using System.Diagnostics;

namespace CallerMemberInfo
{
    public class CallInfoService : ICallInfoService
    {
        public CallInfoService()
        { }

        public CallInfo GetInfo(int skipFrame = 0)
        {
            if (skipFrame < 0)
            {
                throw new IndexOutOfRangeException(
                    $"'{nameof(skipFrame)}' can't be negative number");
            }

            var skip = skipFrame + 1;

            var frame = new StackFrame(skip);

            var info = new CallInfo(frame);

            return info;
        }
    }
}
