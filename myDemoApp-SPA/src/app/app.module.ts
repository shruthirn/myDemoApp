import { AuthGuard } from './_gaurds/auth.guard';
import { AlertifyService } from './_services/alertify.service';
import { ErrorInterceptorProvider } from './_services/error.interceptor';
import { AuthService } from './_services/auth.service';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {HttpClientModule} from '@angular/common/http';
//import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ValueComponent } from './value/value.component';
import { SidebarComponent } from './sidebar/sidebar.component';
import { UsersComponent } from './users/users.component';
import { DetailsComponent } from './details/details.component';
import { PostListsComponent } from './postLists/postLists.component';
import { NavComponent } from './nav/nav.component';
import {FormsModule} from '@angular/forms';
import { HomeComponent } from './home/home.component';
import { RegisterComponent } from './register/register.component';
import { BsDropdownModule } from 'ngx-bootstrap';
import { MemberListComponent } from './member-list/member-list.component';
import { MessagesComponent } from './messages/messages.component';
import { ListsComponent } from './lists/lists.component';
import { RouterModule } from '@angular/router';
import { appRoutes } from './routes';

@NgModule({
   declarations: [
      AppComponent,
      ValueComponent,
      SidebarComponent,
      UsersComponent,
      DetailsComponent,
      PostListsComponent,
      NavComponent,
      HomeComponent,
      RegisterComponent,
      MemberListComponent,
      MessagesComponent,
      ListsComponent
   ],
   imports: [
      BrowserModule,
     // AppRoutingModule,
      HttpClientModule,
      FormsModule,
      BsDropdownModule.forRoot(),
      RouterModule.forRoot(appRoutes)
   ],
   providers: [
      AuthService,
      ErrorInterceptorProvider,
      AlertifyService,
      AuthGuard
   ],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
