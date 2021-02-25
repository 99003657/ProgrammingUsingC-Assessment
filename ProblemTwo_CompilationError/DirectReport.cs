using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemTwo_CompilationError
{
    class DirectReport: Manager
    {
        public Employee ReportsTo { get; set; }
        public string ProjectCode { get; set; }
        public int eid { get; set; }
        public int  { get; set; }
        public int  { get; set; }
        

        public virtual DirectReport(int eID,String eName,eLevel,eDoJ,EmployeemanagerEmpObj,string pCode) 
        {
            ReportsTo = managerEmpObj;
            ProjectCode = pCode;
        }
    }
}
