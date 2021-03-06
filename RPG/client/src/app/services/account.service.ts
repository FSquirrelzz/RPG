import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BehaviorSubject, EMPTY, map, ReplaySubject } from 'rxjs';
import {User} from '../models/user';
@Injectable({
  providedIn: 'root'
})
export class AccountService {
  baseUrl= 'https://localhost:7216/api/'
  private currentUserSource$:any = new ReplaySubject<User>(1);
  currentUser$ = this.currentUserSource$.asObservable();


  constructor(private http:HttpClient) {}
  register(model:any)
  {
    return this.http.post<User>(this.baseUrl + 'account/register', model)
    .pipe(
      map((user:User)=>{
        if(user){
          localStorage.setItem('user',JSON.stringify(user));
          this.currentUserSource$.next(user);
        }
        return user;
      })
    )
  }
  login(model:any){
    return this.http.post<User>(this.baseUrl + 'account/login',model).pipe(
      map((response:User)=>{
        const user = response;
        if(user)
        {
          localStorage.setItem('user',JSON.stringify(user));
          this.currentUserSource$.next(user);
        }
        return user;
      })
    )
  }
  setCurrentUser(user:User)
  {
    this.currentUserSource$.next(user);
  }
  logout()
  {
    localStorage.removeItem('user');
    this.currentUserSource$.next();
  }
}
