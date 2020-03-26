import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { from, Observable } from 'rxjs';
import { news } from 'src/app/Models/News.Models';

@Injectable({
  providedIn: 'root'
})
export class NEWSService {

  constructor(public http: HttpClient) { }

  NewsView() : Observable<news[]>{
  return this.http.get<news[]>("http:/localhost:5582/api/news/NewsView");

  }
}

