import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { User } from '../models/user';
import { AccountService } from '../services/account.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  currentUser$:Observable<User>;
  model:any={};
  constructor(private accountService: AccountService,private router:Router) {
    this.currentUser$=this.accountService.currentUser$;
   }
  ngOnInit(): void {
    this.login();
  }
  login(){
    this.accountService.login(this.model)
    .subscribe(
      {
        next: (n) => {
          this.router.navigateByUrl('/members')
          console.log(n);
        },
        error: (e) => {
          console.log(e);
        },
        complete: () => {
          console.log('complete');
        }
      })
    console.log(this.model);
  }
  logout()
  {
    this.accountService.logout();
  }
}
