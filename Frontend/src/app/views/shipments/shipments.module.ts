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
  ProgressModule,
  SharedModule,
  UtilitiesModule,
  WidgetModule,
} from '@coreui/angular';

import { IconModule } from '@coreui/icons-angular';
import { ShipmentsRoutingModule } from './shipments-routing.module';
import { ShipmentDetailComponent } from './shipment-detail/shipment-detail.component';
import { ShipmentsOverviewComponent } from './shipments-overview/shipments-overview.component';
import { ChartsModule } from '../charts/charts.module';
import { ChartjsModule } from '@coreui/angular-chartjs';

@NgModule({
  declarations: [ShipmentDetailComponent, ShipmentsOverviewComponent],
  imports: [
    CommonModule,
    ShipmentsRoutingModule,
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
    ChartjsModule,
    ProgressModule,
  ],
})
export class ShipmentsModule {}
