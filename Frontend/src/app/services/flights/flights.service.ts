import { Injectable } from '@angular/core';
import { Observable, Subject, of } from 'rxjs';
import { FlightDto } from '../../../model/flightDto';

@Injectable({
  providedIn: 'root',
})
export class FlightsService {
  private test: Subject<any>;

  constructor() {
    this.test = new Subject<any>();
  }

  public connect(): Subject<any> {
    setTimeout(() => {
      this.test.next({ test: 'test' });
    }, 1000);
    return this.test;
  }

  // todo re
  public mockGetFlightByDepartureDateAndFlightNumber(
    flightNumber: string,
    departureDate: string
  ): Observable<any> {
    return of({
      id: flightNumber,
      values: [
        { title: 'Date', value: departureDate },
        { title: 'Origin', value: 'ZRH' },
        { title: 'Destination', value: 'JFK' },
        { title: 'Shipments', value: '2' },
        { title: 'Status', value: 'Alert' },
      ],
    });
  }

  // todo replce mock with real backend
  public mockGetFlightByFlightnumberAndDate(): Observable<FlightDto> {
    return of({
      flightNo: 'LX14',
      originCode: 'ZRH',
      departureDateTime: '16.03.2024',
      destinationlCode: 'JFK',
      arrivalDateTime: '2023-01-01T06:00', // todo
      shipments: [
        {
          id: 'todo',
          waybillNumber: '724-14329302',
          pieces: ['piece1', 'piece2'],
          hasAlert: false,
        },
        {
          id: 'todo',
          waybillNumber: '724-14329302',
          pieces: ['piece1', 'piece2'],
          hasAlert: true,
        },
      ],
    });
  }

  // todo replace with backend
  public mockGetFlightById(id: string): Observable<FlightDto> {
    return of({
      flightNo: 'LX14',
      originCode: 'ZRH',
      departureDateTime: '16.03.2024',
      destinationlCode: 'JFK',
      arrivalDateTime: '2023-01-01T06:00', // todo
      shipments: [
        {
          id: 'todo',
          waybillNumber: '724-14329302',
          pieces: ['piece1', 'piece2'],
          hasAlert: false,
        },
        {
          id: 'todo',
          waybillNumber: '724-14329302',
          pieces: ['piece1', 'piece2'],
          hasAlert: true,
        },
      ],
    });
  }
}
