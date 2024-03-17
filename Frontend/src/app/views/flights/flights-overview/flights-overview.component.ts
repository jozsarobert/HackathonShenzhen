import { Component } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { cilCalendar, cilSearch } from '@coreui/icons';
import { FlightService } from 'src/api/flight.service';

@Component({
  selector: 'app-flights-overview',
  templateUrl: './flights-overview.component.html',
  styleUrls: ['./flights-overview.component.scss'],
})
export class FlightsOverviewComponent {
  icons = { cilSearch, cilCalendar };
  searchForm: FormGroup = new FormGroup({
    date: new FormControl(null),
    flightNumber: new FormControl(null),
  });

  public flights: any = undefined;
  public isLoading: boolean = false;

  public constructor(
    private route: ActivatedRoute,
    private router: Router,
    private flightService: FlightService
  ) {}

  public navigateToDetail(flightId: string): void {
    this.router.navigate([`detail/${flightId}`], {
      relativeTo: this.route,
    });
  }
  public onSearch() {
    const date = this.searchForm.get('date')?.value;
    const flightNumber = this.searchForm.get('flightNumber')?.value;

    if (date && flightNumber) {
      this.isLoading = true;

      //todo catch http errors
      this.flightService
        .apiFlightGetbyflightGet(flightNumber, new Date(date).toISOString())
        .subscribe((flights) => {
          this.isLoading = false;
          // todo date type is currently string
          this.flights = flights;
        });
    }

    // this.flights = [
    //   {
    //     id: 'LX14',
    //     values: [
    //       { title: 'Date', value: '16.03.2024' },
    //       { title: 'Origin', value: 'ZRH' },
    //       { title: 'Destination', value: 'JFK' },
    //       { title: 'Shipments', value: '2' },
    //       { title: 'Status', value: 'Alert' },
    //     ],
    //   },
    // ];
  }
}
