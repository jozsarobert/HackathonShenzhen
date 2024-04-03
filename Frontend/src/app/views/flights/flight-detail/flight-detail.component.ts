import { ChangeDetectorRef, Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { FlightsService } from 'src/app/services/flights/flights.service';
import { FlightDto } from 'src/model/flightDto';
import { ShipmentDto } from 'src/model/shipmentDto';

@Component({
  selector: 'app-flight-detail',
  templateUrl: './flight-detail.component.html',
  styleUrls: ['./flight-detail.component.scss'],
})

// todo: get flight data via router param or fetch if not existing
export class FlightDetailComponent {
  flight: FlightDto | undefined = undefined;
  flightDisplayValues: any = undefined;

  flightId: string | null = null; // via url

  shipmentsDisplayValues: any = [];

  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private flightsService: FlightsService,
    private cdr: ChangeDetectorRef
  ) {
    this.flight =
      this.router?.getCurrentNavigation()?.extras?.state?.['flight'];

    // via url
    this.route.paramMap.subscribe((params) => {
      this.flightId = params.get('id');
    });

    // todo fetch from API if not received via navigation
    if (!this.flight && this.flightId) {
      this.flightsService
        .mockGetFlightByFlightnumberAndDate() //todo change function?
        .subscribe((flight) => {
          this.flight = flight;

          this.setFlightDisplayValues(this.flight);
          this.setShipmentDisplayValues(this.flight);
        });
    }

    if (this.flight) {
      this.setFlightDisplayValues(this.flight);

      // todo replace with function (setShipmentDisplayValues)
      this.flight?.shipments?.forEach((shipment) => {
        this.shipmentsDisplayValues.push({
          id: shipment.id,
          awb: shipment.waybillNumber,
          color: shipment.hasAlert ? 'danger' : 'success',
          values: [
            { title: 'Pieces', value: shipment.pieces?.length },
            { title: 'Status', value: shipment.hasAlert ? 'Alert' : 'OK' },
          ],
        });
      });
    }
  }

  public navigateToShipmentDetail(shipment: ShipmentDto): void {
    this.router.navigate([`shipments/detail/${shipment.id}`], {
      state: { shipment: shipment },
    });
  }

  public setFlightDisplayValues(flight: FlightDto): void {
    this.flightDisplayValues = [
      { title: 'Date', value: flight.departureDateTime },
      { title: 'Origin', value: flight.originCode },
      { title: 'Destination', value: flight.destinationlCode },
    ];
  }

  public setShipmentDisplayValues(flight: FlightDto) {
    flight?.shipments?.forEach((shipment) => {
      this.shipmentsDisplayValues.push({
        id: shipment.id,
        awb: shipment.waybillNumber,
        color: shipment.hasAlert ? 'danger' : 'success',
        values: [
          { title: 'Pieces', value: shipment.pieces?.length },
          { title: 'Status', value: shipment.hasAlert ? 'Alert' : 'OK' },
        ],
      });
    });
  }
}
