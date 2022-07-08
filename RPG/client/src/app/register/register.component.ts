import { outputAst } from '@angular/compiler';
import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { AccountService } from '../services/account.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
@Output() cancelRegister = new EventEmitter<boolean>();
  model: any = {};

  constructor(private accountService:AccountService) { }

  ngOnInit(): void {

  }
  register() {
    this.accountService.register(this.model).subscribe(
      {
      next:(n)=>{
      console.log(n);
      this.cancel();
    },
    error:(e)=>{
      console.log(e)
    },
    complete:()=>{
      console.log('complete');
    }})

    console.log(this.model);
  }
  cancel() {
    this.cancelRegister.emit(false);
  }
}
