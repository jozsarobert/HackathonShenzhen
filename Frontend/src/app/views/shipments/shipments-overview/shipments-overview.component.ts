import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { cilArrowRight, cilChartPie, cilPlus } from '@coreui/icons';
import { Store } from '@ngxs/store';
import { Observable } from 'rxjs';
import { ShipmentsStateSelectors } from '../../../state/shipments/shipments.selectors';

@Component({
  selector: 'app-shipments-overview',
  templateUrl: './shipments-overview.component.html',
  styleUrls: ['./shipments-overview.component.scss'],
})
export class ShipmentsOverviewComponent implements OnInit {
  public shipments$: Observable<string[] | undefined> | undefined;

  icons = { cilChartPie, cilArrowRight, cilPlus };

  public constructor(
    private route: ActivatedRoute,
    private router: Router,
    private store: Store
  ) {}

  public ngOnInit(): void {
    this.shipments$ = this.store.select(ShipmentsStateSelectors);

    this.shipments$.subscribe((shipments) => {
      console.log(shipments, 'kek');
    });
  }

  shipments = [
    {
      id: '724-14329302',
      values: [
        { title: 'Flight', value: 'LX138' },
        { title: 'Dest', value: 'HKG' },
        { title: 'Date', value: 'todo' },
        { title: 'SMC', value: 'COL' },
        { title: 'SLA', value: '2.0 - 5.0 C°' },
        { title: 'Temp', value: '2.0°C' },
        { title: 'Status', value: 'OK' },
      ],
    },
    {
      id: '724-14329303',
      values: [
        { title: 'Pieces', value: '2' },
        { title: 'Status', value: 'OK' },
      ],
    },
    {
      id: '724-14329304',
      values: [
        { title: 'Pieces', value: '5' },
        { title: 'Status', value: 'OK' },
      ],
    },
  ];

  public navigateToDetail(shipmentId: string): void {
    this.router.navigate([`detail/${shipmentId}`], {
      relativeTo: this.route,
    });
  }
}
