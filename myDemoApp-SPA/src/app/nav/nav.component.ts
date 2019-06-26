import { AuthService } from './../_services/auth.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
 model: any = {} ; //creating this variable to store username and pwd from the view
  constructor(private authservice: AuthService) { }

  ngOnInit() {
  }
  login()
  {
    this.authservice.login(this.model).subscribe(
      next => {
        console.log('sucessfully logged in ');
      }, error => {
        console.log('failed to log in');
      }
    );
    console.log(this.model);
  }

  loggedIn()
  {
    const token = localStorage.getItem('token');
    return !!token; //return true or false
  }

  loggedOut(){
    localStorage.removeItem('token');
    console.log("user is logged out");
  }
}
