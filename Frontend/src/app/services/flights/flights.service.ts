import { Injectable } from '@angular/core';
import { Observable, Subject, delay, of } from 'rxjs';
import { FlightDto } from '../../../model/flightDto';
import { PieceDto } from 'src/model/pieceDto';

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
    const piece1: PieceDto = {
      id: '123',
      currentTemperature: 20,
      isTemperatureControlled: true,
      location: 'Warehouse A',
      weight: { unit: 'kg', value: 10 },
      volume: { unit: 'm3', value: 2 },
      flight: {
        flightNo: 'AB123',
        originCode: 'NYC',
        destinationlCode: 'LAX',
        departureDateTime: '16.03.2024',
        arrivalDateTime: '16.03.2024',
      },
      alertType: 'temperature',
      temperatureHistory: [
        // Assuming MeasuredTemperature is an object with properties temperature and timestamp
        { value: 18, timestamp: '2021-09-01T00:00:00Z', unit: 'C°' },
        { value: 18, timestamp: '2021-09-01T00:00:00Z', unit: 'C°' },
        { value: 18, timestamp: '2021-09-01T00:00:00Z', unit: 'C°' },
      ],
      minTemperature: 18,
      maxTemperature: 22,
      hasAlert: false,
    };

    return of({
      flightNo: 'LX14/16MAR',
      originCode: 'ZRH',
      departureDateTime: '16.03.2024',
      destinationlCode: 'JFK',
      arrivalDateTime: '2023-01-01T06:00', // todo
      shipments: [
        {
          id: 1234,
          waybillNumber: '724-14329302',
          pieces: [piece1],
          flights: null,
          hasAlert: false,
        },
        {
          id: 1234,
          waybillNumber: '724-14329302',
          pieces: [piece1],
          flights: null,
          hasAlert: true,
        },
        {
          id: 1234,
          waybillNumber: '724-14329302',
          pieces: [piece1],
          flights: null,
          hasAlert: false,
        },
        {
          id: 1234,
          waybillNumber: '724-14329302',
          pieces: [piece1],
          flights: null,
          hasAlert: false,
        },
      ],
    }).pipe(delay(2000));
  }

  // todo replace with backend
  public mockGetFlightById(id: string): Observable<FlightDto> {
    const piece1: PieceDto = {
      id: '123',
      currentTemperature: 20,
      isTemperatureControlled: true,
      location: 'Warehouse A',
      weight: { unit: 'kg', value: 10 },
      volume: { unit: 'm3', value: 2 },
      flight: {
        flightNo: 'AB123',
        originCode: 'NYC',
        destinationlCode: 'LAX',
        departureDateTime: '16.03.2024',
        arrivalDateTime: '16.03.2024',
      },
      alertType: 'temperature',
      temperatureHistory: [
        // Assuming MeasuredTemperature is an object with properties temperature and timestamp
        { value: 18, timestamp: '2021-09-01T00:00:00Z', unit: 'C°' },
        { value: 18, timestamp: '2021-09-01T00:00:00Z', unit: 'C°' },
        { value: 18, timestamp: '2021-09-01T00:00:00Z', unit: 'C°' },
      ],
      minTemperature: 18,
      maxTemperature: 22,
      hasAlert: false,
    };

    return of({
      flightNo: 'LX14',
      originCode: 'ZRH',
      departureDateTime: '16.03.2024',
      destinationlCode: 'JFK',
      arrivalDateTime: '2023-01-01T06:00', // todo
      shipments: [
        {
          id: 1234,
          waybillNumber: '724-14329302',
          pieces: [piece1],
          flights: null,
          hasAlert: false,
        },
        {
          id: 1234,
          waybillNumber: '724-14329302',
          pieces: [piece1],
          flights: null,
          hasAlert: true,
        },
        {
          id: 1234,
          waybillNumber: '724-14329302',
          pieces: [piece1],
          flights: null,
          hasAlert: false,
        },
        {
          id: 1234,
          waybillNumber: '724-14329302',
          pieces: [piece1],
          flights: null,
          hasAlert: false,
        },
      ],
    });
  }
}
