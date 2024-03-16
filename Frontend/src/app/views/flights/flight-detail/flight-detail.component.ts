import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-flight-detail',
  templateUrl: './flight-detail.component.html',
  styleUrls: ['./flight-detail.component.scss'],
})
export class FlightDetailComponent {
  public constructor(private route: ActivatedRoute, private router: Router) {}

  // todo replace mock
  flight = {
    flightNumber: 'LX14',
    displayValues: [
      { title: 'Date', value: '16.03.2024' },
      { title: 'Origin', value: 'ZRH' },
      { title: 'Destination', value: 'JFK' },
    ],
  };

  // todo replace mock
  shipments = [
    {
      id: '724-14329302',
      color: 'danger',
      values: [
        { title: 'Flight', value: 'LX138' },
        { title: 'Dest', value: 'HKG' },
        { title: 'Date', value: 'todo' },
        { title: 'SMC', value: 'COL' },
        { title: 'SLA', value: '2.0 - 5.0 C°' },
        { title: 'Temp', value: '2.0°C' },
        { title: 'Status', value: 'OK' },
      ],
    },
    {
      id: '724-14329303',
      color: 'success',
      values: [
        { title: 'Pieces', value: '2' },
        { title: 'Status', value: 'OK' },
      ],
    },
    {
      id: '724-14329304',
      color: 'success',
      values: [
        { title: 'Pieces', value: '5' },
        { title: 'Status', value: 'OK' },
      ],
    },
  ];

  public navigateToShipmentDetail(shipmentId: string): void {
    this.router.navigate([`shipments/detail/${shipmentId}`]);
  }
}
