import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { usersService } from 'src/app/services/users.service';
import { user } from 'src/app/models/user.model';
import { Router } from '@angular/router';

@Component({
  selector: 'app-edit-user',
  templateUrl: './edit-user.component.html',
  styleUrls: ['./edit-user.component.css']
})
export class EdituserComponent implements OnInit {
  
  userDetails: user = {
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

  constructor(private route: ActivatedRoute, private userService: usersService,  private router : Router){}

  ngOnInit():void{
    this.route.paramMap.subscribe({
      next:(params) => {
        const id = params.get('id');

        if(id){
          this.userService.getuser(id)
          .subscribe({
            next: (response) => {
              this.userDetails=response;
            }
          })
        }
      }
    })
  } 

  edituser(){  
    console.log(this.userDetails);
    this.userService.edituser(this.userDetails.documentNumber, this.userDetails)
    .subscribe({
      next: (response) => {
        this.router.navigate(['users']);
      },
      error: (response) => {
        console.log(response);
      },
    });
  }

  deleteuser(id : string){
  
    console.log(this.userDetails);
    this.userService.deleteuser(id)
    .subscribe({
      next: (response) => {
        this.router.navigate(['users']);
      },
      error: (response) => {
        console.log(response);
      },
    });
  }

}
