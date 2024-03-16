import { Injectable } from '@angular/core';
import { of } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class ShipmentsService {
  constructor() {}

  public mockGetShipments(shipmentsCode: string) {
    console.log('shipments service ');

    return of(['shipment1_kek', 'shipment2']);
  }
}
