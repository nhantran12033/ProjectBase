import { ListService, LocalizationPipe, PagedResultDto } from '@abp/ng.core';
import { CommonModule } from '@angular/common';
import { Component, OnInit, inject } from '@angular/core';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';
import { BookService, BookDto } from '@proxy/books';
@Component({
  selector: 'app-book',
  standalone: true,
  imports: [CommonModule, NgxDatatableModule, LocalizationPipe],
  templateUrl: './book.component.html',
  styleUrls: ['./book.component.scss'],
  providers: [ListService],
})
export class BookComponent implements OnInit {
  book = { items: [], totalCount: 0 } as PagedResultDto<BookDto>;

  public readonly list = inject(ListService);
  private readonly bookService = inject(BookService);

  ngOnInit() {
    const bookStreamCreator = (query) => this.bookService.getList(query);

    this.list.hookToQuery(bookStreamCreator).subscribe((response) => {
      this.book = response;
    });
  }
}
