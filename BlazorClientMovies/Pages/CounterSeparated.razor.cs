using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace BlazorClientMovies.Pages
{
    public partial class CounterSeparated : ComponentBase
    {

        protected int CurrentCount = 0;

        protected void IncrementCount()
        {
            CurrentCount++;
        }

    }
}
