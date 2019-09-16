import { Injectable } from "@angular/core";
import { Http } from "@angular/http";
import "rxjs/add/operator/map";

@Injectable()
export class MakeService {
  constructor(private http: Http) {}

  getMakes() {
    let makes = this.http.get("/api/makes").map(res => res.json());
    return makes;
  }
}
