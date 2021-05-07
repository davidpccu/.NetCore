import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Opera } from '../opera';
import { OperaService } from '../opera.service';

@Component({
  selector: 'app-opera-edit',
  templateUrl: './opera-edit.component.html',
  styleUrls: ['./opera-edit.component.css']
})
export class OperaEditComponent implements OnInit {
  opera: Opera;
  constructor(private operaService: OperaService,
      private rout: ActivatedRoute, private router: Router
    ) { }

  ngOnInit(): void {
    this.rout.paramMap.subscribe(params => {
            let id: number = +params.get('operaid');
            this.operaService.getOpera(id)
              .subscribe(opera => {
                this.opera = opera;
              });
          });
  }
  onSubmit() {
        this.operaService.updateOperas(this.opera)
          .subscribe(() => {
            this.router.navigate(["/operas"]);
          });
      } 

}
