import { INavData } from '@coreui/angular';

export const navItems: INavData[] = [
  {
    name: 'Search',
    url: '/search',
    iconComponent: { name: 'cil-search' },
  },

  // Status
  {
    title: true,
    name: 'Status',
  },
  {
    name: 'Alerts',
    url: '/alerts',
    iconComponent: { name: 'cil-bell-exclamation' },
  },

  // todo: define what are warnings
  // {
  //   name: 'Warnings',
  //   url: '/warnings',
  //   iconComponent: { name: 'cil-alarm' },
  // },

  // todo icon
  {
    name: 'Flights',
    url: '/flights',
    iconComponent: { name: 'cilFlightTakeoff' },
  },
  {
    name: 'Shipments',
    url: '/shipments',
    iconComponent: { name: 'cil-inbox' },
  },
];
