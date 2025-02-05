using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduProfFiler.Views.Interfaces
{
    public interface IClasses
    {
        string Cl_Code { get; set; }
        string Cl_Name { get; set; }
        string Cl_Grade { get; set; }
        string SY_Code { get; set; }
    }
}
