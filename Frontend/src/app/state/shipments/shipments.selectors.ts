import { createSelector } from '@ngxs/store';
import { ShipmentsState, ShipmentsStateModel } from './shipments.state';

export class ShipmentsStateSelectors {
  static getShipments() {
    return createSelector([ShipmentsState], (state: ShipmentsStateModel) => {
      return state.shipments;
    });
  }
}
