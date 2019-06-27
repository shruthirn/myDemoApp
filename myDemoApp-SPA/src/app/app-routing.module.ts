import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { UsersComponent } from './users/users.component';
import { DetailsComponent } from './details/details.component';
import { PostListsComponent } from './postLists/postLists.component';

const routes1: Routes = [
  {
    path: '',
    component: UsersComponent
  },
  {
    path: 'details/:id',
    component: DetailsComponent
  },
  {
    path: 'posts',
    component: PostListsComponent
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes1)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
