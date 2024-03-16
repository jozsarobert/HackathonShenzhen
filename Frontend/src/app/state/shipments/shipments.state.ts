import { Injectable } from '@angular/core';
import { Action, State, StateContext } from '@ngxs/store';
import { ShipmentsActions } from './shipments.actions';
import { Observable, tap } from 'rxjs';
import { ShipmentsService } from '../../services/shipments/shipments.service';

export interface ShipmentsStateModel {
  shipments: string[] | undefined;
}

@State<ShipmentsStateModel>({
  name: 'shipments',
  defaults: {
    shipments: undefined,
  },
})
@Injectable()
export class ShipmentsState {
  public constructor(private shipmentsService: ShipmentsService) {}

  @Action(ShipmentsActions.getShipment)
  public getShipment(
    ctx: StateContext<ShipmentsStateModel>,
    action: ShipmentsActions.getShipment
  ): Observable<any> {
    const state = ctx.getState();

    return this.shipmentsService.mockGetShipments(action.shipmentCode).pipe(
      tap((result) => {
        ctx.setState({
          ...state,
          shipments: result,
        });
      })
    );

    // return this.scanService.mockGetShipment(action.shipmentCode).pipe(
    //   tap((result) => {
    //     ctx.setState({
    //       ...state,
    //       shipment: result,
    //     });
    //   })
    // );
  }
}
