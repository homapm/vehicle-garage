import { Injectable } from "@angular/core";
import { Http } from "@angular/http";
import "rxjs/add/operator/map";

@Injectable()
export class FeatureService {
  constructor(private http: Http) {}

  getFeatures() {
    let features = this.http.get("/api/features").map(res => res.json());
    console.log("features :", features);
    return features;
  }
}
