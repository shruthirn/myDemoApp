import { DetailsComponent } from './details/details.component';
import { AuthGuard } from './_gaurds/auth.guard';
import { MessagesComponent } from './messages/messages.component';
import { MemberListComponent } from './member-list/member-list.component';
import { HomeComponent } from './home/home.component';

import { Routes, CanActivate } from '@angular/router';
import { ListsComponent } from './lists/lists.component';

export const appRoutes = [

{path : '', component: HomeComponent},
{path : 'members', component: MemberListComponent, canActivate: [AuthGuard]},
{path : 'messages', component: MessagesComponent, canActivate: [AuthGuard]},
{path : 'lists', component: ListsComponent, canActivate: [AuthGuard]},
{path: 'details/:id',component: DetailsComponent},
{path : '**', redirectTo: '', pathMatch: 'full'}
];