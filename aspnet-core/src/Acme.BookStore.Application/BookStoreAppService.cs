using System;
using Acme.BookStore.Books;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Books;

public class BookAppService :
    CrudAppService<
        Book, // Thực thể Entity (từ dự án Domain)
        BookDto, // DTO dùng để hiển thị (từ dự án Application.Contracts)
        Guid, // Kiểu dữ liệu của khóa chính
        PagedAndSortedResultRequestDto, // DTO cho phân trang và sắp xếp
        CreateUpdateBookDto>, // DTO dùng để tạo và cập nhật
    IBookAppService // Interface bạn đã định nghĩa
{
    public BookAppService(IRepository<Book, Guid> repository)
        : base(repository)
    {
    }
}