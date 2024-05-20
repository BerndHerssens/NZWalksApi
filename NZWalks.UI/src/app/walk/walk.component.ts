import { Component } from '@angular/core';
import { WalkService } from '../services/walk.service';

@Component({
  selector: 'app-walk',
  templateUrl: './walk.component.html',
  styleUrl: './walk.component.css',
})
export class WalkComponent {
  walks: any[] = [];

  constructor(private walkService: WalkService) {}
  ngOnInit(): void {
    this.walkService.getRegions().subscribe(
      (data) => {
        this.walks = data; // Handle the response data as needed
      },
      (error) => {
        console.error('Error fetching regions:', error);
      }
    );
  }
}
