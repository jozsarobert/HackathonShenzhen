import { Component } from '@angular/core';
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
    private flightsService: FlightsService
  ) {
    this.flight =
      this.router?.getCurrentNavigation()?.extras?.state?.['flight'];

    // via url
    this.route.paramMap.subscribe((params) => {
      this.flightId = params.get('id');
    });

    // todo fetch from API
    if (!this.flight && this.flightId) {
      this.flightsService
        .mockGetFlightById(this.flightId)
        .subscribe((flight) => {
          this.flight = flight;
        });
    }

    if (this.flight) {
      this.setFlightDisplayValues(this.flight);

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

  // todo why all this data?
  // shipments = [
  //   {
  //     id: '724-14329302',
  //     color: 'danger',
  //     values: [
  //       { title: 'Flight', value: 'LX138' },
  //       { title: 'Dest', value: 'HKG' },
  //       { title: 'Date', value: 'todo' },
  //       { title: 'SMC', value: 'COL' },
  //       { title: 'SLA', value: '2.0 - 5.0 C°' },
  //       { title: 'Temp', value: '2.0°C' },
  //       { title: 'Status', value: 'OK' },
  //     ],
  //   },
  //   {
  //     id: '724-14329303',
  //     color: 'success',
  //     values: [
  //       { title: 'Pieces', value: '2' },
  //       { title: 'Status', value: 'OK' },
  //     ],
  //   },
  //   {
  //     id: '724-14329304',
  //     color: 'success',
  //     values: [
  //       { title: 'Pieces', value: '5' },
  //       { title: 'Status', value: 'OK' },
  //     ],
  //   },
  // ];

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
}
