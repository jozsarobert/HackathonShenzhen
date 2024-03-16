import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AlertsOverviewComponent } from './alerts-overview/alerts-overview.component';

const routes: Routes = [
  {
    path: '',
    data: {
      title: 'Alerts',
    },
    children: [
      {
        path: '',
        pathMatch: 'full',
        component: AlertsOverviewComponent,
      },
    ],
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class AlertsRoutingModule {}
