using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SS.Lib.Model;


namespace SS.Lib.Service
{
    public class ScreepService:NameBase
    {
        public override string Url
        {
            get { return "http://personer.eniro.se/resultat/{0}"; }
        }
    }
}
