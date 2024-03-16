import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ShipmentDetailComponent } from './shipment-detail/shipment-detail.component';
import { ShipmentsOverviewComponent } from './shipments-overview/shipments-overview.component';

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
        component: ShipmentsOverviewComponent,
      },
      {
        path: 'detail/:id',
        pathMatch: 'full',
        component: ShipmentDetailComponent,
      },
    ],
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class ShipmentsRoutingModule {}
