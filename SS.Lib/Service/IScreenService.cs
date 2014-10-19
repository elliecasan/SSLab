using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SS.Lib.Model;


// ReSharper disable once CheckNamespace
namespace SS.Lib.Service
{
    public interface IScreenService
    {
        Name GetName(string input);
    }
}
