import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { Router } from '@angular/router';
@Component({
  selector: 'app-registration-success',
  templateUrl: './registration-success.component.html',
  styleUrls: ['./registration-success.component.css'],
  standalone:true,
  imports:[CommonModule,ReactiveFormsModule,]
})
export class RegistrationSuccessComponent implements OnInit {

  paymentData: any;

  ngOnInit(): void {
    // Fetch the data from localStorage
    const storedData = localStorage.getItem('paymentData');
    if (storedData) {
      this.paymentData = JSON.parse(storedData);
    }
  }
}
