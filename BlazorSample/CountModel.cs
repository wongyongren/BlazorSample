using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlazorSample
{
    public class CountModel
    {
        public int Count { get; set; }

        public void Increment()
        {
            Count++;
        }
    }
}