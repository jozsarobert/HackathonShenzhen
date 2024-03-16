import { Injectable } from '@angular/core';
import { Observable, Subject, of } from 'rxjs';

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
}
