using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSample.Shared
{
    public interface IMyService
    {
        event Func<Task> RefreshRequested;

        Task CallRequestRefresh();
    }
}
