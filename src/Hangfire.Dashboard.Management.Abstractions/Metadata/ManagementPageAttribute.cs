using System;

namespace Hangfire.Dashboard.Management.Metadata
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ManagementPageAttribute : Attribute
    {
        public string Title { get; }
        //public string MenuName { get; }
        public string Queue { get; }

        public ManagementPageAttribute(string title/*, string menuName*/, string queue = null)
        {
            Title = title;
            //MenuName = menuName;
            Queue = queue;
        }
    }
}