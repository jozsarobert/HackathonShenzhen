import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { cilCalendar } from '@coreui/icons';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.scss'],
})
export class SearchComponent {
  icons = { cilCalendar };

  public constructor(private route: ActivatedRoute, private router: Router) {}

  public navigateToPage(page: string) {
    this.router.navigate([page]);
  }
}
