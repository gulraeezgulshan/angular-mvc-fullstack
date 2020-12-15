import { Product } from "./product.model";
import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";

const productsUrl = "/api/products";

@Injectable()
export class Repository {
  product: Product;
  products: Product[];

  constructor(private http: HttpClient) {
    this.getProducts(true);
  }
  getProduct(id: number) {
    this.http.get<Product>(`${productsUrl}/${id}`)
      .subscribe(p => this.product = p);
  }
  getProducts(related = false) {
    this.http.get<Product[]>(`${productsUrl}?related=${related}`)
      .subscribe(prods => this.products = prods);
  }
}
