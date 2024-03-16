import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { cilSearch, cilCalendar } from '@coreui/icons';

@Component({
  selector: 'app-flights-overview',
  templateUrl: './flights-overview.component.html',
  styleUrls: ['./flights-overview.component.scss'],
})
export class FlightsOverviewComponent {
  icons = { cilSearch, cilCalendar };

  public constructor(private route: ActivatedRoute, private router: Router) {}

  flights = [
    {
      id: 'LX14',
      values: [
        { title: 'Date', value: '16.03.2024' },
        { title: 'Origin', value: 'ZRH' },
        { title: 'Destination', value: 'JFK' },
        { title: 'Shipments', value: '2' },
        { title: 'Status', value: 'Alert' },
      ],
    },
  ];

  public navigateToDetail(flightId: string): void {
    this.router.navigate([`detail/${flightId}`], {
      relativeTo: this.route,
    });
  }
}
