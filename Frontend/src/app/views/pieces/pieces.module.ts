import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';

import {
  ButtonGroupModule,
  ButtonModule,
  CardModule,
  CollapseModule,
  DropdownModule,
  FormModule,
  GridModule,
  NavbarModule,
  NavModule,
  ProgressBarComponent,
  ProgressComponent,
  SharedModule,
  UtilitiesModule,
  WidgetModule,
} from '@coreui/angular';

import { IconModule } from '@coreui/icons-angular';
import { PieceDetailComponent } from './piece-detail/piece-detail.component';
import { PiecesRoutingModule } from './pieces-routing.module';
import { ChartjsComponent } from '@coreui/angular-chartjs';
import { PiecesOverviewComponent } from './pieces-overview/pieces-overview.component';

@NgModule({
  declarations: [PieceDetailComponent, PiecesOverviewComponent],
  imports: [
    CommonModule,
    PiecesRoutingModule,
    ButtonModule,
    ButtonGroupModule,
    GridModule,
    IconModule,
    CardModule,
    UtilitiesModule,
    DropdownModule,
    SharedModule,
    FormModule,
    ReactiveFormsModule,
    NavbarModule,
    CollapseModule,
    NavModule,
    NavbarModule,
    WidgetModule,
    ChartjsComponent,
    ProgressComponent,
    ProgressBarComponent,
  ],
})
export class PiecesModule {}
