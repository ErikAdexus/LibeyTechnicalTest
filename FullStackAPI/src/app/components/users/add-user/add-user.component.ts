import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { user } from 'src/app/models/user.model';
import { usersService } from 'src/app/services/users.service';

@Component({
  selector: 'app-add-user',
  templateUrl: './add-user.component.html',
  styleUrls: ['./add-user.component.css']
})
export class AdduserComponent implements OnInit{

  adduserRequest: user = {
    documentNumber: '',
    documentTypeId: 1,
    name: '',
    fathersLastName : '',
    mothersLastName : '',
    address : '',
    regionCode : '',
    provinceCode: '',       
    ubigeoCode: '',
    phone : '',
    email : '',
    password : '',
    active : true
  };

  constructor(private userService : usersService, private router : Router){}

  ngOnInit(): void {    
  }

  adduser(){
    this.userService.adduser(this.adduserRequest)
    .subscribe({
      next: (user) =>{
        console.log(user);
        this.router.navigate(['users']);
      }
    });

  }
}
