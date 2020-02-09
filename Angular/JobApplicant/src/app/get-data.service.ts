import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class GetDataService {

  constructor(private http: HttpClient) { }
  getAllJobs()  {
   return this.http.get('https://localhost:44318/api/job');
  // .subscribe(data => {        });
   // return  [{ JobTitle: 'Software Developer', SalaryRang: '70000 - 90000' },
   // { JobTitle: 'Software Engineer', SalaryRang: '70000 - 90000' }];
  }
}
