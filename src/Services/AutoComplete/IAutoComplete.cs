﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuliusSweetland.OptiKey.Services.AutoComplete
{
    public interface IAutoComplete
    {
        IEnumerable<string> GetSuggestions(string root);
    }
}
