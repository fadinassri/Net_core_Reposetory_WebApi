import { Component, OnInit } from '@angular/core';
import { GetDataService } from '../get-data.service';


@Component({
  selector: 'app-jobs',
  templateUrl: './jobs.component.html',
  styleUrls: ['./jobs.component.css']
})
export class JobsComponent implements OnInit {
AllJobs: any ;
  constructor(private getData: GetDataService ) { }

  ngOnInit() {
    this.getData.getAllJobs().subscribe(data => {
     this.AllJobs = data;
    });
    console.log(this.AllJobs);
  }
}
