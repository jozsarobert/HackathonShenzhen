import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ShipmentsService } from 'src/app/services/shipments/shipments.service';
import { ShipmentDto } from 'src/model/shipmentDto';
import { PieceDto } from 'src/model/pieceDto';

@Component({
  selector: 'app-shipment-detail',
  templateUrl: './shipment-detail.component.html',
  styleUrls: ['./shipment-detail.component.scss'],
})
export class ShipmentDetailComponent implements OnInit {
  shipment: ShipmentDto | undefined = undefined;
  pieces: PieceDto[] | undefined = undefined;
  piecesDisplayValues: any = [];

  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private shipmentsService: ShipmentsService // todo
  ) {
    this.shipment =
      this.router?.getCurrentNavigation()?.extras?.state?.['shipment'];

    // todo via url
    // this.route.paramMap.subscribe((params) => {
    //   this.flightId = params.get('id');
    // });

    // // todo fetch from API
    // if (!this.flight && this.flightId) {
    //   this.flightsService
    //     .mockGetFlightById(this.flightId)
    //     .subscribe((flight) => {
    //       this.flight = flight;
    //     });
    // }

    if (this.shipment) {
      //   this.setFlightDisplayValues(this.flight);
      //   this.flight?.shipments?.forEach((shipment) => {
      //     this.shipmentsDisplayValues.push({
      //       id: shipment.id,
      //       awb: shipment.waybillNumber,
      //       color: shipment.hasAlert ? 'danger' : 'success',
      //       values: [
      //         { title: 'Pieces', value: shipment.pieces?.length },
      //         { title: 'Status', value: shipment.hasAlert ? 'Alert' : 'OK' },
      //       ],
      //     });
      //   });
      // todo wait until pieceDTO is in in shipmentDTO
      // this.shipment.pieces?.forEach((piece) => {
      //   this.piecesDisplayValues.push({
      //     id: piece.,
      //     icon: 'cisTruck',
      //     color: piece.hasAlert ? 'danger' : 'success',
      //     values: [
      //       { title: 'Temp', value: piece.temperature },
      //       { title: 'Location', value: piece.location },
      //       { title: 'Weight', value: piece.weight },
      //       { title: 'Volume', value: piece.volume },
      //       { title: 'Flight No.', value: piece.flightNumber },
      //       { title: 'Departure', value: piece.departure },
      //       { title: 'Status', value: piece.hasAlert ? 'Alert' : 'OK' },
      //     ],
      //   });
      //   })
      // });
    }

    this.pieces = [
      {
        id: 'LX-9384756873-SWC',
        currentTemperature: 3,
        isTemperatureControlled: true,
        location: 'Warehouse A',
        weight: {
          unit: 'kg',
          value: 10,
        },
        volume: {
          unit: 'm³',
          value: 2,
        },
        flight: {
          flightNo: 'LX14',
          originCode: 'ZRH',
          departureDateTime: '16.03.2024',
          destinationlCode: 'JFK',
          arrivalDateTime: '17.03.2024',
        },
        alertType: 'temperature',
        temperatureHistory: [
          {
            value: 20,
            unit: 'C°',
            timestamp: '08:00',
          },
          {
            value: 20,
            unit: 'C°',
            timestamp: '08:05',
          },
        ],
      },
      {
        id: 'LX-9124749273-SWC',
        currentTemperature: 4,
        isTemperatureControlled: true,
        location: 'Warehouse A',
        weight: {
          unit: 'kg',
          value: 8,
        },
        volume: {
          unit: 'm³',
          value: 1.5,
        },
        flight: {
          flightNo: 'LX14',
          originCode: 'ZRH',
          departureDateTime: '16.03.2024',
          destinationlCode: 'JFK',
          arrivalDateTime: '17.03.2024',
        },
        alertType: null,
        temperatureHistory: [
          {
            value: 20,
            unit: 'C°',
            timestamp: '08:00',
          },
          {
            value: 20,
            unit: 'C°',
            timestamp: '08:05',
          },
        ],
      },
      {
        id: 'LX-9129482271-SWC',
        currentTemperature: 2,
        isTemperatureControlled: true,
        location: 'Warehouse A',
        weight: {
          unit: 'kg',
          value: 2,
        },
        volume: {
          unit: 'm³',
          value: 0.5,
        },
        flight: {
          flightNo: 'LX14',
          originCode: 'ZRH',
          departureDateTime: '16.03.2024',
          destinationlCode: 'JFK',
          arrivalDateTime: '17.03.2024',
        },
        alertType: null,
        temperatureHistory: [
          {
            value: 20,
            unit: 'C°',
            timestamp: '08:00',
          },
          {
            value: 20,
            unit: 'C°',
            timestamp: '08:05',
          },
        ],
      },
    ];

    this.pieces.forEach((piece) => {
      console.log(piece);

      this.piecesDisplayValues.push({
        id: piece.id,
        color: piece.alertType ? 'danger' : 'success',
        values: [
          { title: 'Temp', value: `${piece.currentTemperature}°C` },
          { title: 'Location', value: piece.location },
          {
            title: 'Weight',
            value: `${piece.weight?.value}${piece.weight?.unit}`,
          },
          {
            title: 'Volume',
            value: `${piece.volume?.value}${piece.volume?.unit}`,
          },
          { title: 'Flight', value: piece.flight?.flightNo },
          { title: 'Departure', value: piece.flight?.originCode },
        ],
      });
    });
  }

  public ngOnInit(): void {
    // todo overwrite title
  }

  // todo I don't remember why I did this
  pieces2 = [
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
    // todo go to different piece and submit piece object
    this.router.navigate([`pieces/detail/${pieceId}`]);
  }
}
