import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';

import {
  ButtonGroupModule,
  ButtonModule,
  CalloutModule,
  CardModule,
  CollapseModule,
  DropdownModule,
  FormModule,
  GridModule,
  HeaderModule,
  NavbarModule,
  NavModule,
  ProgressBarComponent,
  ProgressComponent,
  SharedModule,
  SpinnerModule,
  UtilitiesModule,
  WidgetModule,
  TableModule
} from '@coreui/angular';

import { RouterModule } from '@angular/router';
import { ChartjsComponent } from '@coreui/angular-chartjs';
import { IconModule } from '@coreui/icons-angular';
import { FlightDetailComponent } from './flight-detail/flight-detail.component';
import { FlightsOverviewComponent } from './flights-overview/flights-overview.component';
import { FlightsRoutingModule } from './flights-routing.module';

@NgModule({
  declarations: [FlightsOverviewComponent, FlightDetailComponent],
  imports: [
    CommonModule,
    RouterModule,
    FlightsRoutingModule,
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
    HeaderModule,
    CalloutModule,
    SpinnerModule,
    TableModule
  ],
})
export class FlightsModule {}
