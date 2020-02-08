import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class GetDataService {

  constructor() { }
  getAllJobs()  {
    return  [{ JobTitle: 'Software Developer', SalaryRang: '70000 - 90000' },
    { JobTitle: 'Software Engineer', SalaryRang: '70000 - 90000' }];
  }
}
