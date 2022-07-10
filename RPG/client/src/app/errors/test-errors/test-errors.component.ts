import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-test-errors',
  templateUrl: './test-errors.component.html',
  styleUrls: ['./test-errors.component.css'],
})
export class TestErrorsComponent implements OnInit {
  baseURL = 'https://localhost:7216/api/';
  validationErrors: string[]=[];

  constructor(private http: HttpClient) {}

  ngOnInit(): void {}
  get404Error() {
    this.http.get(this.baseURL + 'buggy/not-found').subscribe({
      next: (n) => {
        console.log(n);
      },
      error: (e) => {
        console.log(e);
      },
      complete: () => {
        console.log('complete');
      },
    });
  }
  get400Error() {
    this.http.get(this.baseURL + 'buggy/bad-request').subscribe({
      next: (n) => {
        console.log(n);
      },
      error: (e) => {
        console.log(e);
      },
      complete: () => {
        console.log('complete');
      },
    });
  }
  get500Error() {
    this.http.get(this.baseURL + 'buggy/server-error').subscribe({
      next: (n) => {
        console.log(n);
      },
      error: (e) => {
        console.log(e);
      },
      complete: () => {
        console.log('complete');
      },
    });
  }
  get401Error() {
    this.http.get(this.baseURL + 'buggy/auth').subscribe({
      next: (n) => {
        console.log(n);
      },
      error: (e) => {
        console.log(e);
      },
      complete: () => {
        console.log('complete');
      },
    });
  }
  get400ValidationError() {
    this.http.post(this.baseURL + 'account/register',{ }).subscribe({
      next: (n) => {
        console.log(n);
      },
      error: (e) => {
        this.validationErrors=e;

        console.log(e);
      },
      complete: () => {},
    });
  }
}
