using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace RESTService.Lib
{
    class WebOperationContextWrapper
    {
        public virtual WebOperationContext context
        {
            get
            {
                return WebOperationContext.Current;
            }
        }
    }
}
