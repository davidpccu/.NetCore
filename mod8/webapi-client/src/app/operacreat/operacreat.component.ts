import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Opera } from '../opera';
import { OperaService } from '../opera.service';

@Component({
  selector: 'app-operacreat',
  templateUrl: './operacreat.component.html',
  styleUrls: ['./operacreat.component.css']
})
export class OperacreatComponent implements OnInit {
  opera: Opera;
  constructor(private operaService: OperaService, private router: Router) {
    this.opera = { title: "", year: 1000, composer: "" };
  }

  ngOnInit(): void {
  }

  onSubmit(){
    this.operaService.insertOperas(this.opera)
    .subscribe(() => {
      this.router.navigate(["/operas"]);
    })
  }
}
