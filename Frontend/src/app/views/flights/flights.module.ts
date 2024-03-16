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
  UtilitiesModule,
  WidgetModule,
} from '@coreui/angular';

import { ChartjsComponent } from '@coreui/angular-chartjs';
import { IconModule } from '@coreui/icons-angular';
import { FlightsOverviewComponent } from './flights-overview/flights-overview.component';
import { FlightsRoutingModule } from './flights-routing.module';
import { FlightDetailComponent } from './flight-detail/flight-detail.component';

@NgModule({
  declarations: [FlightsOverviewComponent, FlightDetailComponent],
  imports: [
    CommonModule,
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
  ],
})
export class FlightsModule {}
