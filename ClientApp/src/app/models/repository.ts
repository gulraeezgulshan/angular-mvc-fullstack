import { Product } from "./product.model";
import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Filter } from './configClasses.repository';

const productsUrl = "/api/products";

@Injectable()
export class Repository {
  product: Product;
  products: Product[];
  filter: Filter = new Filter();

  constructor(private http: HttpClient) {
    this.filter.category = "education";
    this.filter.related = true;
    this.getProducts();
    this.getProducts(true);

  }
  getProduct(id: number) {
    this.http.get<Product>(`${productsUrl}/${id}`)
      .subscribe(p => this.product = p);
  }
  getProducts(related = false) {
    let url = `${productsUrl}?related=${this.filter.related}`;
    if (this.filter.category) {
      url += `&category=${this.filter.category}`;
    }
    if (this.filter.search) {
      url += `&search=${this.filter.search}`;
    }
    this.http.get<Product[]>(url).subscribe(prods => this.products = prods);
  }
}
