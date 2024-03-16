import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PieceDetailComponent } from './piece-detail/piece-detail.component';
import { PiecesOverviewComponent } from './pieces-overview/pieces-overview.component';

const routes: Routes = [
  {
    path: '',
    data: {
      title: 'Piece',
    },
    children: [
      {
        path: '',
        pathMatch: 'full',
        component: PiecesOverviewComponent,
      },
      {
        path: 'detail/:id',
        pathMatch: 'full',
        component: PieceDetailComponent,
      },
    ],
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class PiecesRoutingModule {}
