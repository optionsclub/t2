import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { VolumeScreenerComponent } from './screens/volume-screener/volume-screener.component';

const routes: Routes = [
  {
    path: 'volume-screener',
    component: VolumeScreenerComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
