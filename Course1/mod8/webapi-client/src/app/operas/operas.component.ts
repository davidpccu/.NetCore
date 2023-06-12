import { Component, OnInit } from '@angular/core';
import { Opera } from '../opera';
import { OperaService } from '../opera.service';

@Component({
  selector: 'app-operas',
  templateUrl: './operas.component.html',
  styleUrls: ['./operas.component.css']
})
export class OperasComponent implements OnInit {
  operas: Opera[];
  constructor(private operaService: OperaService) { }

  ngOnInit() {
    this.getAllOperas();
  }

  getAllOperas() {
    this.operaService.getAllOperas()
    .subscribe(operas => this.operas = operas);
  }

  onDelete(id: number) {
    if(window.confirm("delete?")){
      this.operaService.deleteOpera(id)
      .subscribe(() => {this.getAllOperas()});
    }
  }
}
