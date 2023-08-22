import { Component, OnInit } from '@angular/core';
import { user } from 'src/app/models/user.model';
import { usersService } from 'src/app/services/users.service';

@Component({
  selector: 'app-users-list',
  templateUrl: './users-list.component.html',
  styleUrls: ['./users-list.component.css']
})
export class usersListComponent implements OnInit{

  users: user[] = [];
  constructor(private usersService : usersService){}

  ngOnInit(): void{
    this.usersService.getAllusers()
    .subscribe({
      next: (users) => {
        this.users = users;
        console.log(users);
      },
      error: (response) => {
        console.log(response);
      },
    })
  }
}
