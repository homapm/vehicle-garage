import { Injectable } from "@angular/core";
import { Http } from "@angular/http";
import "rxjs/add/operator/map";

@Injectable()
export class VehicleService {
  constructor(private http: Http) {}

  getMakes() {
    let makes = this.http.get("/api/makes").map(res => res.json());
    return makes;
  }

  getFeatures() {
    let features = this.http.get("/api/features").map(res => res.json());
    console.log("features :", features);
    return features;
  }

  create(vehicle: any) {
    return this.http.post("/api/vehicles", vehicle).map(res => res.json());
  }
}
