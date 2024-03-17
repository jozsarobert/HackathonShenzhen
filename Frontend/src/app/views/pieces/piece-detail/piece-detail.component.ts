import { Component, OnInit } from '@angular/core';
import { cilArrowTop, cilOptions } from '@coreui/icons';
import { getStyle } from '@coreui/utils';

@Component({
  selector: 'app-piece-detail',
  templateUrl: './piece-detail.component.html',
  styleUrls: ['./piece-detail.component.scss'],
})
export class PieceDetailComponent implements OnInit {
  icons = { cilOptions, cilArrowTop };

  data: any = {};
  options: any = {};

  labels = ['08:00', '08:10', '08:20', '08:30', '08:40', '08:50', '09:00'];

  datasets1 = [
    {
      label: 'Temperature in C°',
      backgroundColor: 'transparent',
      borderColor: 'rgba(255,255,255,.55)',
      pointBackgroundColor: '#FFFFFF',
      pointHoverBorderColor: getStyle('--cui-primary'),
      data: [4, 5, 2, 6, 20, 17, 15],
    },
  ];

  datasets2 = [
    {
      label: 'Temperature in C°',
      backgroundColor: 'transparent',
      borderColor: 'rgba(255,255,255,.55)',
      pointBackgroundColor: '#FFFFFF',
      pointHoverBorderColor: getStyle('--cui-primary'),
      data: [4, 5, 2, 6, 6, 6, 4],
    },
  ];

  optionsDefault1 = {
    plugins: {
      legend: {
        display: false,
      },
    },
    maintainAspectRatio: true,
    scales: {
      x: {
        grid: {
          display: false,
          drawBorder: false,
        },
        ticks: {
          display: false,
        },
      },
      y: {
        min: -10,
        max: 25,
        display: false,
        grid: {
          display: false,
        },
        ticks: {
          display: false,
        },
      },
    },
    elements1: {
      line: {
        borderWidth: 1,
        tension: 0.4,
      },
      point: {
        radius: 4,
        hitRadius: 10,
        hoverRadius: 4,
      },
    },
  };

  colors1 = {
    backgroundColor: 'rgba(255,255,255,.1)',
    borderColor: 'rgba(255,255,255,.55)',
    pointHoverBackgroundColor: '#fff',
  };

  brandData1 = [
    {
      icon: 'cisTruck',
      values: [
        { title: 'Temp', value: '15°C' },
        { title: 'Location', value: 'ZRH Building 1' },
      ],
      capBg: { '--cui-card-cap-bg': '#3b5998' },
      labels: ['kek'],
      data: {
        labels: ['ligma'],
        datasets: [
          {
            ...this.datasets1,
            data: [65, 59, 84, 84, 51, 55, 40],
            label: 'Facebook',
            ...this.colors1,
          },
        ],
      },
      color: this.colors1,
    },
  ];

  public ngOnInit(): void {
    this.data = {
      labels: this.labels.slice(0, 7),
      datasets: this.datasets2,
    };
    this.options = this.optionsDefault1;
  }
}
