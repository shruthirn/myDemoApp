import { AlertifyService } from './../_services/alertify.service';
import { AuthService } from './../_services/auth.service';
import { Component, OnInit, Output, EventEmitter } from '@angular/core';


@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  model: any = {};
 //child to parent communication
 @Output() cancelRegister = new EventEmitter();
  constructor(private authService: AuthService, private alertifyService: AlertifyService) { }

  ngOnInit() {
  }
  register(){
    this.authService.register(this.model).subscribe(() => {
      this.alertifyService.success('registeration successful');
    },error => {
     this.alertifyService.error(error);
    });
  }

  cancel(){
    this.cancelRegister.emit(false);
   
  }

 

}
