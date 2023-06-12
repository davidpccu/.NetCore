import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { OperasComponent } from './operas/operas.component';
import { OperacreatComponent } from './operacreat/operacreat.component';
import { OperaEditComponent } from './opera-edit/opera-edit.component';

const routes: Routes = [
  { path: "", redirectTo: "/operas", pathMatch: "full" }
  , { path: "operas", component: OperasComponent }
  , { path: "create", component: OperacreatComponent }
  ,{path:"edit/:operaid",component:OperaEditComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
