import { AlertifyService } from './../_services/alertify.service';
import { AuthService } from './../_services/auth.service';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
 model: any = {} ; //creating this variable to store username and pwd from the view
  constructor(public authservice: AuthService, private alertifyService: AlertifyService, private router: Router) { }

  ngOnInit() {
  }
  login()
  {
    this.authservice.login(this.model).subscribe(
      next => {
        this.alertifyService.success('sucessfully logged in ');
      }, error => {
        this.alertifyService.error('failed to log in');
      },() => {
        this.router.navigate(['/members']);
      }
    );
    console.log(this.model);
  }

  loggedIn()
  {
    return this.authservice.loggedIn();
    //const token = localStorage.getItem('token');
    //return !!token; //return true or false
  }

  loggedOut(){
    localStorage.removeItem('token');
    this.alertifyService.message("logged out");
    this.router.navigate(['/home']);
  }
}
