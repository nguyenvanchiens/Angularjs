using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FasFood.Model.Abstract
{
    public interface IAuditable
    {
         string MetaKeyWord { get; set; }
         string MetaDescription { get; set; }
         DateTime CreatedDate { get; set; }
         string CreatedBy { get; set; }
         DateTime UpdatedDate { get; set; }
         string UpdatedBy { get; set; }
         bool Status { get; set; }
    }
}
