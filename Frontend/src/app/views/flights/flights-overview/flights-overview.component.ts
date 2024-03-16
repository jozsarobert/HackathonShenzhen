import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { cilCalendar, cilSearch } from '@coreui/icons';
import { FlightsService } from '../../../services/flights/flights.service';
import { FormControl, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-flights-overview',
  templateUrl: './flights-overview.component.html',
  styleUrls: ['./flights-overview.component.scss'],
})
export class FlightsOverviewComponent implements OnInit {
  icons = { cilSearch, cilCalendar };
  searchForm: FormGroup = new FormGroup({
    date: new FormControl(null),
    flightNumber: new FormControl(null),
  });

  public flights: any = undefined;

  public constructor(
    private route: ActivatedRoute,
    private router: Router,
    private flightsService: FlightsService
  ) {}

  // todo destroy on leave page or prevent to double initiate
  public ngOnInit(): void {
    this.flightsService.connect().subscribe((data) => {
      console.log(data);
    });
  }

  public navigateToDetail(flightId: string): void {
    this.router.navigate([`detail/${flightId}`], {
      relativeTo: this.route,
    });
  }

  // todo get data from backend
  public onSearch() {
    const date = this.searchForm.get('date')?.value;
    const flightNumber = this.searchForm.get('flightNumber')?.value;

    this.flights = [
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

    console.log('kek', date, flightNumber);
  }
}
