import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FlightDetailComponent } from './flight-detail/flight-detail.component';
import { FlightsOverviewComponent } from './flights-overview/flights-overview.component';

const routes: Routes = [
  {
    path: '',
    data: {
      title: 'Shipments',
    },
    children: [
      {
        path: '',
        pathMatch: 'full',
        component: FlightsOverviewComponent,
      },
      {
        path: 'detail/:id',
        pathMatch: 'full',
        component: FlightDetailComponent,
      },
    ],
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class FlightsRoutingModule {}
