import { Product } from './product.model';

export class Supplier {
  constructor(
    public supplierId?: number,
    public name?: string,
    public city?: string,
    public state?: string,
    public products?: Product[]) { }
}
