import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Maintenance } from '../Maintenance';
import { Main_Data } from '../mock-mainten';

@Component({
  selector: 'app-details-maintenance',
  templateUrl: './details-maintenance.component.html',
  styleUrls: ['./details-maintenance.component.css']
})
export class DetailsMaintenanceComponent implements OnInit {

  item: Maintenance | undefined;
  
  constructor(private route: ActivatedRoute) {}

  ngOnInit(): void {
    const id = Number(this.route.snapshot.paramMap.get("id"))
  this.item = Main_Data.find(a => a.wartung_id === id)
  }
  
}
