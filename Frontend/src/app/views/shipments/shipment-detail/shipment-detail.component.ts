import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-shipment-detail',
  templateUrl: './shipment-detail.component.html',
  styleUrls: ['./shipment-detail.component.scss'],
})
export class ShipmentDetailComponent implements OnInit {
  public constructor(private route: ActivatedRoute, private router: Router) {}

  public ngOnInit(): void {
    // todo overwrite title
  }

  pieces = [
    {
      id: 'Piece 1',
      icon: 'cisTruck',
      color: 'danger',
      values: [
        { title: 'Temp', value: '12°C' },
        { title: 'Location', value: 'ZRH Building 1' },
        { title: 'Weight', value: '12kg' },
        { title: 'Volume', value: 'todo' },
        { title: 'Flight No.', value: 'LX14' },
        { title: 'Departure', value: '16.03.2024' },
        { title: 'Status', value: 'Alert' },
      ],
    },
    {
      id: 'Piece 2',
      icon: 'cisTruck',
      color: 'success',
      values: [
        { title: 'Temp', value: '12°C' },
        { title: 'Location', value: 'ZRH Building 1' },
        { title: 'Weight', value: '12kg' },
        { title: 'Volume', value: 'todo' },
        { title: 'Flight No.', value: 'LX14' },
        { title: 'Departure', value: '16.03.2024' },
        { title: 'Status', value: 'Alert' },
      ],
    },
    {
      id: 'Piece 2',
      icon: 'cisTruck',
      color: 'danger',
      values: [
        { title: 'Temp', value: '4°C' },
        { title: 'Location', value: 'ZRH Building 1' },
        { title: 'Weight', value: '12kg' },
        { title: 'Volume', value: 'todo' },
        { title: 'Flight No.', value: 'LX14' },
        { title: 'Departure', value: '16.03.2024' },
        { title: 'Status', value: 'Alert' },
      ],
    },
  ];

  public navigateToPieceDetail(pieceId: string): void {
    this.router.navigate([`pieces/detail/${pieceId}`]);
  }
}
