import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-alerts-overview',
  templateUrl: './alerts-overview.component.html',
  styleUrls: ['./alerts-overview.component.scss'],
})
export class AlertsOverviewComponent {
  public constructor(private route: ActivatedRoute, private router: Router) {}

  public alerts = [
    {
      id: '724-14329302',
      values: [
        { title: 'Flight', value: 'LX14' },
        { title: 'Origin', value: 'ZRH' },
        { title: 'Dest', value: 'JFK' },
        { title: 'Departure', value: '16.03.2024' },
        { title: 'Pieces', value: '5' },
      ],
    },
    {
      id: '724-14329303',
      values: [
        { title: 'Flight', value: 'LX14' },
        { title: 'Origin', value: 'ZRH' },
        { title: 'Dest', value: 'JFK' },
        { title: 'Departure', value: '16.03.2024' },
        { title: 'Pieces', value: '5' },
      ],
    },
  ];

  public navigateToDetail(shipmentId: string): void {
    this.router.navigate([`shipments/detail/${shipmentId}`]);
  }
}
