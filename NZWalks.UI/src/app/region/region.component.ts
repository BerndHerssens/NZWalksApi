import { Component, OnInit } from '@angular/core';
import { RegionService } from '../services/region.service';

@Component({
  selector: 'app-region',
  templateUrl: './region.component.html',
  styleUrl: './region.component.css'
})
export class RegionComponent implements OnInit{
  regions : any[] = []


  constructor(private regionService : RegionService){}
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
}

