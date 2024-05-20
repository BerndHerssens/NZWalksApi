import { Component, OnInit } from '@angular/core';
import { RegionService } from '../services/region.service';

@Component({
  selector: 'app-region',
  templateUrl: './region.component.html',
  styleUrl: './region.component.css',
})
export class RegionComponent implements OnInit {
  regions: any[] = [];

  constructor(private regionService: RegionService) {}
  ngOnInit(): void {
    this.regionService.getRegions().subscribe(
      (data) => {
        this.regions = data; // Handle the response data as needed
      },
      (error) => {
        console.error('Error fetching regions:', error);
      }
    );
  }

  AddRegion() {
    this.regionService.addRegion().subscribe(
      (response) => {
        console.log('Region added successfully:', response);
        // Handle the response as needed (e.g., update UI, show success message)
      },
      (error) => {
        console.error('Error adding region:', error);
        // Handle the error (e.g., show error message)
      }
    );
  }
}
