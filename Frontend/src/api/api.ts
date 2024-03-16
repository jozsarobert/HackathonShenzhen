export * from './alert.service';
import { AlertService } from './alert.service';
export * from './flight.service';
import { FlightService } from './flight.service';
export * from './piece.service';
import { PieceService } from './piece.service';
export * from './shipment.service';
import { ShipmentService } from './shipment.service';
export const APIS = [AlertService, FlightService, PieceService, ShipmentService];
