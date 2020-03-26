import { Component, OnInit } from '@angular/core';
import { NEWSService } from '../service/new-service/news.service';
import { news } from '../Models/News.Models';

@Component({
  selector: 'app-news-list',
  templateUrl: './news-list.page.html',
  styleUrls: ['./news-list.page.scss'],
})
export class NewsListPage implements OnInit {
  //Pongo corchetes para definir com un arreglo de NEWS
news: news[];
  constructor(private NewsService: NEWSService) { }

  ngOnInit() {
    this.NewsService.NewsView().subscribe((news)=>{
      this.news = news;
console.log(news)

//Mostrarme si ocurrio un error

    },(ErrorGet)=>{
      console.log(ErrorGet)
    })
  }

}
