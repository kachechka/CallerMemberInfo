using System;
using System.Diagnostics;
using System.Reflection;

namespace CallerMemberInfo
{
    public class CallInfo
    {
        public string MemberName { get; set; }
        public string Namespace { get; set; }
        public string ClassName { get; set; }
        public MemberTypes MemberType { get; set; }

        public CallInfo()
        { }

        internal CallInfo(StackFrame frame)
        {
            if (frame is null)
            {
                throw new ArgumentNullException(nameof(frame));
            }

            var method = frame.GetMethod();
            var declaringType = method.DeclaringType;
            
            MemberName = method.Name;
            Namespace = declaringType.Namespace;
            MemberType = method.MemberType;
            ClassName = declaringType.Name;
        }
    }
}