export namespace ShipmentsActions {
  // todo
  export class getShipment {
    public static readonly type = '[Shipments] Get Shipment';
    public constructor(public shipmentCode: string) {}
  }
}
