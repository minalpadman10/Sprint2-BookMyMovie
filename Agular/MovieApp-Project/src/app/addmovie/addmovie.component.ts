import { Component, OnInit } from '@angular/core';
import { AddmovieService } from 'src/app/services/addmovie.service';

@Component({
  selector: 'app-addmovie',
  templateUrl: './addmovie.component.html',
  styleUrls: ['./addmovie.component.css']
})
export class AddmovieComponent implements OnInit {

  public Movies : any = [];
  public grandTotal !: number;
  constructor(private addmovieService : AddmovieService) { }


  ngOnInit(): void {
    this.addmovieService.getMovies()
    .subscribe(res=>{
      this.Movies = res;
      this.grandTotal = this.addmovieService.getTotalPrice();
    })
  }
  removeItem(item: any){
    this.addmovieService.removeAddmovieItem(item);
  }
  emptyaddmovie(){
    this.addmovieService.removeAllMovie();
  }

}