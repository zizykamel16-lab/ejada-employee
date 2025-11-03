using AutoMapper;
using ejada.employees.Books;

namespace ejada.employees.Web;

public class employeesWebAutoMapperProfile : Profile
{
    public employeesWebAutoMapperProfile()
    {
        CreateMap<BookDto, CreateUpdateBookDto>();
        
        //Define your object mappings here, for the Web project
    }
}
