import { Component } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { cilCalendar } from '@coreui/icons';
import { Subscription } from 'rxjs';
import { FlightsService } from 'src/app/services/flights/flights.service';
import { FlightDto } from 'src/model/flightDto';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.scss'],
})
export class SearchComponent {
  icons = { cilCalendar };

  searchForm: FormGroup = new FormGroup({
    shipmentNo: new FormControl(null),
    flight: new FormControl(null),
    date: new FormControl(null),
    origin: new FormControl(null),
    destination: new FormControl(null),
    pieceId: new FormControl(null),
  });

  isAnyFieldTouched: boolean = false;

  subscriptions: Subscription[] = [];

  isLoading: boolean = false;

  public flight: FlightDto | undefined = undefined;
  public flightDisplayValues: any;
  public flightHasAlert: boolean = false; // loop through shipments and check if any has alert

  public constructor(
    private router: Router,
    private flightsService: FlightsService
  ) {}

  public navigateToPage(page: string) {
    this.router.navigate([page]);
  }

  // todo rename
  public getFilledOutFieldIds(): void {
    this.isLoading = true;

    // todo get type selected and fetch data according to type
    this.flightsService
      .mockGetFlightByFlightnumberAndDate()
      .subscribe((flight: FlightDto) => {
        this.isLoading = false;
        this.flight = flight;
        this.flightDisplayValues = {
          id: flight.flightNo,
          values: [
            { title: 'Date', value: flight.departureDateTime },
            { title: 'Origin', value: flight.originCode },
            { title: 'Destination', value: flight.destinationlCode },
            { title: 'Shipments', value: flight.shipments?.length },
          ],
        };

        this.flightHasAlert =
          flight.shipments?.some((shipment) => shipment.hasAlert) || false;
      });
  }

  public navigateToFlightDetail(flightId: string): void {
    this.router.navigate([`flights/detail/${flightId}`], {
      state: { flight: this.flight },
    });
  }
}
