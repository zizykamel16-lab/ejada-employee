using AutoMapper;
using ejada.employees.Books;

namespace ejada.employees;

public class employeesApplicationAutoMapperProfile : Profile
{
    public employeesApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
