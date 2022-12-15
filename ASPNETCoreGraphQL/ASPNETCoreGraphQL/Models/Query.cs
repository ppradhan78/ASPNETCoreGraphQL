using ASPNETCoreGraphQL.Services;
using System.Collections.Generic;

namespace ASPNETCoreGraphQL.Models
{
    public class Query
    {
        IStudentServices _studentServices = null;
        public Query(IStudentServices studentServices)
        {
            _studentServices = studentServices;
        }

        public List<Student> Students => _studentServices.GetList();
    }
}
