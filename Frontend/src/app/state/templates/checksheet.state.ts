/*import { Injectable } from '@angular/core';
import { Action, State, StateContext } from '@ngxs/store';
import { Observable, delay, map, of, tap } from 'rxjs';
import { SheetDto } from 'src/model/sheetDto';
import { ScanService } from '../../scan/services/scan.service';
import { ChecksheetActions } from './checksheet.actions';
import { ShipmentDto } from 'src/model/shipmentDto';
import { append, patch } from '@ngxs/store/operators';

export interface CheckSheetStateModel {
  checkSheet: SheetDto[] | undefined;
  shipment: ShipmentDto | undefined;
}

@State<CheckSheetStateModel>({
  name: 'checksheet',
  defaults: {
    checkSheet: undefined,
    shipment: undefined,
  },
})
@Injectable()
export class CheckSheetState {
  public constructor(private scanService: ScanService) {}

  // send shipment code and receive shipment
  @Action(ChecksheetActions.getShipment)
  public getShipment(
    ctx: StateContext<CheckSheetStateModel>,
    action: ChecksheetActions.getShipment
  ): Observable<any> {
    const state = ctx.getState();

    // todo robert: replace mock service
    return this.scanService.mockGetShipment(action.shipmentCode).pipe(
      tap((result) => {
        ctx.setState({
          ...state,
          shipment: result,
        });
      })
    );
  }

  // send ULD code and receive checksheet
  @Action(ChecksheetActions.getChecksheet)
  public getChecksheet(
    ctx: StateContext<CheckSheetStateModel>,
    action: ChecksheetActions.getChecksheet
  ): Observable<any> {
    const state = ctx.getState();

    // todo replace mock service
    return this.scanService.mockgetChecksheet(action.uldId).pipe(
      tap((result) => {
        ctx.setState(
          patch<CheckSheetStateModel>({
            checkSheet: append<SheetDto>([result]),
          })
        );
      })
    );
  }

  @Action(ChecksheetActions.submitOriginHandlingSheet)
  public submitOriginHandlingSheet(
    ctx: StateContext<CheckSheetStateModel>,
    action: ChecksheetActions.submitOriginHandlingSheet
  ): Observable<boolean> {
    const state = ctx.getState();

    // todo connect
    return of(true).pipe(delay(1000));
  }

  @Action(ChecksheetActions.submiDestinationHandlingSheet)
  public submitDestinationHandlingSheet(
    ctx: StateContext<CheckSheetStateModel>,
    action: ChecksheetActions.submiDestinationHandlingSheet
  ): Observable<boolean> {
    const state = ctx.getState();

    // todo connect
    return of(true).pipe(delay(1000));
  }
}*/
