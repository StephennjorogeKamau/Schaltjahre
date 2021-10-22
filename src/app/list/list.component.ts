import { Component, OnInit } from '@angular/core';
import { Sensor_Data } from '../mock-data';
import { Main_Data } from '../mock-mainten';



@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.css']
})
export class ListComponent implements OnInit {

list = Sensor_Data;
list2 = Main_Data;

  constructor() {}
  utcTime: any;
  ngOnInit(): void {
    
  }

}
