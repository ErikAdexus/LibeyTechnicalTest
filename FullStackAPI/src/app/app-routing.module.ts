import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { usersListComponent } from './components/users/users-list/users-list.component';
import { AdduserComponent } from './components/users/add-user/add-user.component';
import { EdituserComponent } from './components/users/edit-user/edit-user.component';

const routes: Routes = [
  {
    path: '',
    component: usersListComponent
  },
  {
    path: 'users',
    component: usersListComponent
  },
  {
    path: 'users/add',
    component: AdduserComponent
  },
  {
    path: 'users/edit/:id',
    component: EdituserComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
