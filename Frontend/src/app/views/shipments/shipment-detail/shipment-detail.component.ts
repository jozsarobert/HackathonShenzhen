import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-shipment-detail',
  templateUrl: './shipment-detail.component.html',
  styleUrls: ['./shipment-detail.component.scss'],
})
export class ShipmentDetailComponent {
  public constructor(private route: ActivatedRoute, private router: Router) {}

  pieces = [
    {
      id: 'Piece 1',
      icon: 'cisTruck',
      values: [
        { title: 'Temp', value: '4°C' },
        { title: 'Location', value: 'ZRH Building 1' },
      ],
    },
    {
      id: 'Piece 2',
      icon: 'cisTruck',
      values: [
        { title: 'Temp', value: '8°C' },
        { title: 'Location', value: 'ZRH Building 1' },
      ],
    },
    {
      id: 'Piece 2',
      icon: 'cisTruck',
      values: [
        { title: 'Temp', value: '2°C' },
        { title: 'Location', value: 'ZRH Building 1' },
      ],
    },
  ];

  public navigateToPieceDetail(pieceId: string): void {
    this.router.navigate([`piece/${pieceId}`]);
  }
}
