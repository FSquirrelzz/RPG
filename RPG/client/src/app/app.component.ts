import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { User } from './models/user';
import { AccountService } from './services/account.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  title = 'League of Ancients';
  users: any;
  constructor (private accountService : AccountService) {}
  ngOnInit(): void {
    this.setCurrentUser();
  }
  setCurrentUser()
  {
    const userFromLS:any = localStorage.getItem('user');
    const user:User = JSON.parse(userFromLS);
    this.accountService.setCurrentUser(user);
  }

}
