import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DetailsMaintenanceComponent } from './details-maintenance/details-maintenance.component';
import { DetailsComponent } from './details/details.component';
import { ListComponent } from './list/list.component';

const routes: Routes = [
  {path: '',component: ListComponent},
  {path: 'details/:id',component: DetailsComponent},
  {path: 'details-maintenance/:id',component: DetailsMaintenanceComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
