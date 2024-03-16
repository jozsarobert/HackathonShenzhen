import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';

import {
  BadgeComponent,
  ButtonGroupModule,
  ButtonModule,
  CardModule,
  CollapseModule,
  DropdownModule,
  FormModule,
  GridModule,
  ListGroupModule,
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
import { AlertsOverviewComponent } from './alerts-overview/alerts-overview.component';
import { AlertsRoutingModule } from './alerts-routing.module';

@NgModule({
  declarations: [AlertsOverviewComponent],
  imports: [
    CommonModule,
    AlertsRoutingModule,
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
    BadgeComponent,
    ListGroupModule,
  ],
})
export class AlertsModule {}
