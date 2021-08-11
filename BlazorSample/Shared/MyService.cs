﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSample.Shared
{
    public interface IMyService
    {
        event Action RefreshRequested;

        void CallRequestRefresh();
    }

    public class MyService : IMyService
    {
        public event Action RefreshRequested;

        public void CallRequestRefresh()
        {
            RefreshRequested?.Invoke();
        }
    }
}