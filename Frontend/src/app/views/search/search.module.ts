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
  SpinnerModule,
  UtilitiesModule,
  WidgetModule,
} from '@coreui/angular';

import { ChartjsComponent } from '@coreui/angular-chartjs';
import { IconModule } from '@coreui/icons-angular';
import { SearchRoutingModule } from './search-routing.module';
import { SearchComponent } from './search/search.component';
import { ButtonsComponent } from '../buttons/buttons/buttons.component';

@NgModule({
  declarations: [SearchComponent],
  imports: [
    CommonModule,
    SearchRoutingModule,
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
    SpinnerModule,
  ],
})
export class SearchModule {}
