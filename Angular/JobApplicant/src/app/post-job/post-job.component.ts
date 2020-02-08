import { Component, OnInit } from '@angular/core';
import {FormBuilder, FormGroup, Validators} from '@angular/forms';

@Component({
  selector: 'app-post-job',
  templateUrl: './post-job.component.html',
  styleUrls: ['./post-job.component.css']
})
export class PostJobComponent implements OnInit {
addForm: FormGroup;

onSubmit() {
console.log(this.addForm.value);
}
  constructor(private formBuilder: FormBuilder) { }

  ngOnInit() {
    this.addForm = this.formBuilder.group({
      JobTitle: ['', Validators.required],
      SalaryRange: ['', Validators.required]
    });
  }

}
