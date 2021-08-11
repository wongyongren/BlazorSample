using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BlazorSample.Shared
{


    public class MyService : IMyService
    {
        public event Func<Task> RefreshRequested;

        public async Task CallRequestRefresh()
        {
            await this.RefreshRequested.Invoke();
        }
    }
}