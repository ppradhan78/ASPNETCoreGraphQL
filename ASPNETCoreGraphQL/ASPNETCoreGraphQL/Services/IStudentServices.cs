using ASPNETCoreGraphQL.Models;
using System.Collections.Generic;

namespace ASPNETCoreGraphQL.Services
{
    public interface IStudentServices
    {
        List<Student> GetList();
    }
}
