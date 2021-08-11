using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using BlazorSample.Shared;


namespace BlazorSample
{
    public class CountModel
    {
        private readonly IMyService _myservice1;

        public CountModel(IMyService myservice1)
        {
            _myservice1 = myservice1;
        }
        public int Count { get; set; }

        public void Increment()
        {
            Console.WriteLine("increase");
            Count++;
            _myservice1.CallRequestRefresh();
        }
    }
}