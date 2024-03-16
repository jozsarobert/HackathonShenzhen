import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { cilCalendar } from '@coreui/icons';
import { Subscription } from 'rxjs';
import { FlightsService } from 'src/app/services/flights/flights.service';
import { FlightDto } from 'src/model/flightDto';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.scss'],
})
export class SearchComponent implements OnInit {
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

  public flight: FlightDto | undefined = undefined;
  public flightDisplayValues: any;
  public flightHasAlert: boolean = false; // loop through shipments and check if any has alert

  public constructor(
    private router: Router,
    private flightsService: FlightsService
  ) {}

  public ngOnInit(): void {
    //this.subscribeToStatusChanges();
  }

  // disable every field except the one that is being filled
  // private subscribeToStatusChanges(): void {
  //   Object.keys(this.searchForm.controls).forEach((key) => {
  //     const subscription = this.searchForm
  //       .get(key)
  //       ?.statusChanges.subscribe((status) => {
  //         if (status === 'VALID' && this.searchForm?.get(key)?.value) {
  //           this.unsubscribeFromStatusChanges();
  //           Object.keys(this.searchForm.controls).forEach((controlKey) => {
  //             if (controlKey !== key) {
  //               this.searchForm?.get(controlKey)?.disable();
  //             }
  //           });
  //           this.subscribeToStatusChanges();
  //         } else if (status === 'VALID' && !this.searchForm.get(key)?.value) {
  //           this.unsubscribeFromStatusChanges();
  //           Object.keys(this.searchForm.controls).forEach((controlKey) => {
  //             this.searchForm.get(controlKey)?.enable();
  //           });
  //           this.subscribeToStatusChanges();
  //         }
  //       });
  //     if (subscription) {
  //       this.subscriptions.push(subscription);
  //     }
  //   });
  // }

  public navigateToPage(page: string) {
    this.router.navigate([page]);
  }

  // todo rename
  public getFilledOutFieldIds(): void {
    // let filledOutFieldIds: string[] = [];
    // Object.keys(this.searchForm.controls).forEach((controlKey) => {
    //   if (this.searchForm.get(controlKey)?.value) {
    //     filledOutFieldIds.push(controlKey);
    //   }
    // });

    // todo get type selected and fetch data according to type
    this.flightsService
      .mockGetFlightByFlightnumberAndDate()
      .subscribe((flight: FlightDto) => {
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

  // private unsubscribeFromStatusChanges(): void {
  //   this.subscriptions.forEach((subscription) => subscription.unsubscribe());
  //   this.subscriptions = [];
  // }
}
