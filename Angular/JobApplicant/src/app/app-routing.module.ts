import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {PostJobComponent} from './post-job/post-job.component';
import {JobsComponent} from './jobs/jobs.component';


const routes: Routes = [
{path: 'post-job', component: PostJobComponent},
{path: 'job', component: JobsComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
