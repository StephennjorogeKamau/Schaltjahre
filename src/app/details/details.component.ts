import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Maintenance } from '../Maintenance';
import { Sensor_Data } from '../mock-data';
import { Sensor } from '../Sensor';

@Component({
  selector: 'app-details',
  templateUrl: './details.component.html',
  styleUrls: ['./details.component.css']
})
export class DetailsComponent implements OnInit {

  item: Sensor | undefined;
  
  
  constructor(
    private route: ActivatedRoute
  ) { }

  ngOnInit(): void {
    const id = Number(this.route.snapshot.paramMap.get("id"))
    this.item = Sensor_Data.find(a => a.id === id)

  }

}
