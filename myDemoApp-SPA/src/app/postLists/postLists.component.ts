import { Component, OnInit } from '@angular/core';
import { DataService } from '../data.service';
import { Observable } from 'rxjs';
@Component({
  selector: 'app-postLists',
  templateUrl: './postLists.component.html',
  styleUrls: ['./postLists.component.css']
})
export class PostListsComponent implements OnInit {

  posts$: Object;
  constructor(private data: DataService) { }

  ngOnInit() {
    this.data.getPosts().subscribe(
      data => this.posts$ = data
    );
  }

}
