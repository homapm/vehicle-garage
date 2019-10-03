import { Component, OnInit } from "@angular/core";
import { VehicleService } from "../../services/vehicle.service";

@Component({
  selector: "app-vehicle-form",
  templateUrl: "./vehicle-form.component.html",
  styleUrls: ["./vehicle-form.component.css"]
})
export class VehicleFormComponent implements OnInit {
  makes: any = [];
  features: any = [];
  models: any = [];
  vehicle: any = {
    features: [],
    contact: {}
  };

  constructor(private vehicleService: VehicleService) {}

  ngOnInit() {
    this.vehicleService.getMakes().subscribe(makes => {
      console.log("makes :", makes);
      this.makes = makes;
    });

    this.vehicleService.getFeatures().subscribe(features => {
      this.features = features;
    });
  }

  onMakeChange() {
    var selectedMake = this.makes.find(
      (m: { id: any }) => m.id == this.vehicle.makeId
    );
    this.models = selectedMake.models ? selectedMake.models : [];
    // this.models = selectedMake ? selectedMake.models : [];
    delete this.vehicle.modelId;
  }

  onFeatureToggle(featureId: any, $event: any) {
    console.log("featureId :", featureId);
    if ($event.target.checked) {
      this.vehicle.features.push(featureId);
      console.log("featureId added:", featureId);
    } else {
      var index = this.vehicle.features.indexOf(featureId);
      this.vehicle.features.splice(index, 1);
    }
  }

  submit() {
    this.vehicleService
      .create(this.vehicle)
      .subscribe(vehicle => console.log("vehicle :", vehicle));
  }
}
