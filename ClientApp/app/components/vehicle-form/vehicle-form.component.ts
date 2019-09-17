import { Component, OnInit } from "@angular/core";

import { MakeService } from "../../services/make.service";
import { FeatureService } from "./../../services/feature.service";

@Component({
  selector: "app-vehicle-form",
  templateUrl: "./vehicle-form.component.html",
  styleUrls: ["./vehicle-form.component.css"]
})
export class VehicleFormComponent implements OnInit {
  makes: any = [];
  features: any = [];
  models: any = [];
  vehicle: any = {};

  constructor(
    private makeService: MakeService,
    private featureService: FeatureService
  ) {}

  ngOnInit() {
    this.makeService.getMakes().subscribe(makes => {
      this.makes = makes;
      console.log("this.makes in comp:", this.makes);
    });

    this.featureService.getFeatures().subscribe(features => {
      this.features = features;
      console.log("this.features :", this.features);
    });
  }

  onMakeChange() {
    var selectedMake = this.makes.find(
      (m: { id: any }) => m.id == this.vehicle.make
    );
    this.models = selectedMake.models ? selectedMake.models : [];
  }
}
