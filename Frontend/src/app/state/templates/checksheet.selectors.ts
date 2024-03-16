/*import { Selector, createSelector } from '@ngxs/store';
import { CheckSheetState, CheckSheetStateModel } from './checksheet.state';

export class ChecksheetStateSelectors {
  @Selector([CheckSheetState])
  public static shipment(state: CheckSheetStateModel) {
    return state.shipment;
  }
  static preparationChecksheetByUldNumber(uldNumber: string) {
    return createSelector([CheckSheetState], (state: CheckSheetStateModel) => {
      const tets = state.checkSheet;

      return state.checkSheet?.find(
        (checksheet) => checksheet.preparationSheet?.uldNumber === uldNumber
      );
    });
  }
}*/
