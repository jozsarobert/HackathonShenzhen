import { Component } from '@angular/core';

@Component({
  selector: 'app-flight-detail',
  templateUrl: './flight-detail.component.html',
  styleUrls: ['./flight-detail.component.scss'],
})
export class FlightDetailComponent {
  // todo replace mock
  flight = {
    flightNumber: 'LX14',
    displayValues: [
      { title: 'Date', value: '16.03.2024' },
      { title: 'Origin', value: 'ZRH' },
      { title: 'Destination', value: 'JFK' },
    ],
    // id: 'flight1234',
    // flightNumber: 'LX15',
    // date: '16.03.2024',
    // origin: 'ZRH',
    // destination: 'JFK',
    // shipments: ['shipment1', 'shipment2'],
    // status: 'alert',
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
}
